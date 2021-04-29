from osgeo import gdal
import arcpy
import os
import settings as st
import json
import math
# import geopandas as gpd
# import geopandas
import pandas as pd
import numpy as np
import uuid

arcpy.env.overwriteOutput = True

raster_dem = arcpy.GetParameterAsText(0)
linestring_wkt = arcpy.GetParameterAsText(1)
codhoja = arcpy.GetParameterAsText(2)
geodatabase = arcpy.GetParameterAsText(3)
zona = arcpy.GetParameterAsText(4)
tolerancia = arcpy.GetParameterAsText(5)

response = dict()
response['status'] = 1
response['message'] = 'success'

wkid = int('327{}'.format(zona))
_GEOMETRY_FIELD = 'shape'


def getm(azimut):
    """
    obtiene la pendiente en radianes
    :param azimut: azimut del Punto de observación geológico POG
    :return: pendiente en radianes
    """
    pi = math.pi
    ang_s = 0

    quad = math.ceil(azimut / 90.0)
    ang_s = 90 * (quad + int(not quad % 2)) - azimut

    ang_r = ang_s * math.pi / 180
    return math.tan(ang_r)


def getanglebtwnlines(m1, m2):
    """
    obtener angulo entre rectas a partir de sus angulos de pendientes
    :param a_m1: ángulo de la pendiente 1 en radianes
    :param a_m2: ángulo de la pendiente 2 en radianes

    :return: retorna el menor ángulo que se forma en la intersección de las rectas en sexagesimales
    """
    # obtenemos pendientes
    # m1 = math.tan(a_m1)
    # m2 = math.tan(a_m2)

    # propiedad entre dos rectas que intersectan

    tan_angulo = abs((m2 - m1) / (1 + (m2 * m1)))
    return math.degrees(math.atan(tan_angulo))


def dataframe_to_feature(dataframe, output, geometry_column, src=None):
    arr = dataframe.to_records(index=False)
    dt = arr.dtype
    desc = dt.descr
    for i in range(len(desc)):
        arcpy.AddMessage(desc[i][1])
        if desc[i][1] == '|O':
            desc[i] = (desc[i][0], '<U300')

    dt = np.dtype(desc)
    arr = arr.astype(dt)
    arcpy.AddMessage(arr.dtype)
    feature = arcpy.da.NumPyArrayToFeatureClass(arr, output, geometry_column)
    return feature

def buzamiento_aparente(buzamiento_real, ang_seccion_azimut, df_buzamiento_aparente):
    df = df_buzamiento_aparente
    bz_real_list = df[st._BZ_REAL_FIELD].unique()
    bz_real_sel = min(bz_real_list, key=lambda x: abs(x - buzamiento_real))
    ang_sec_azm_list = df[df[st._BZ_REAL_FIELD] == bz_real_sel][st._A_BZ_SECC_FIELD].unique()
    ang_sec_azm_sel = min(ang_sec_azm_list, key=lambda x: abs(x - ang_seccion_azimut))
    response = df.loc[(df[st._BZ_REAL_FIELD] == bz_real_sel) & (df[st._A_BZ_SECC_FIELD] == ang_sec_azm_sel)][st._BZ_APAR_DD_FIELD]
    response = response.tolist()
    arcpy.AddMessage(response)
    # response = df[(df['BZ_REAL'] == bz_real_sel) & (df['A_BZ_SECC'] == ang_sec_azm_sel)]['BZ_APAR_DD'][0]
    # arcpy.AddMessage(response)
    # arcpy.AddMessage(dir(response))
    return response[0]

# try:
mxd = arcpy.mapping.MapDocument('CURRENT')

raster_dem_src = arcpy.Describe(raster_dem).spatialReference
pog_path = os.path.join(geodatabase, st._POG_MG_PATH.format(zona, zona))
pog_seccion_path = os.path.join(geodatabase, st._POG_MG_PERFIL_PATH.format(zona, zona))


linestring_geom = arcpy.FromWKT(linestring_wkt, mxd.activeDataFrame.spatialReference)
cuadriculas_path = os.path.join(geodatabase, st._CUADRICULAS_MG_PATH)
query = "{} = '{}'".format(st._CODHOJA_FIELD, codhoja)
cuadricula = arcpy.da.SearchCursor(cuadriculas_path, ['shape@'], query, raster_dem_src)
cuadricula_geom = map(lambda i: i[0], cuadricula)[0]

buzamiento_aparente_path = os.path.join(geodatabase, st._TB_MG_BUZAMIENTO_APARENTE_PATH)
np_buzamiento_aparente = arcpy.da.TableToNumPyArray(buzamiento_aparente_path, ["*"])
df_buzamiento_aparente = pd.DataFrame(np_buzamiento_aparente)

xmin_cuad, ymin_cuad = cuadricula_geom.extent.XMin, cuadricula_geom.extent.YMin

y_ini = ymin_cuad - 8000
y_top = 0

if raster_dem_src.factoryCode != mxd.activeDataFrame.spatialReference.factoryCode:
    linestring_geom = linestring_geom.projectAs(raster_dem_src)

raster = gdal.Open(raster_dem)
gt = raster.GetGeoTransform()

width_resolution = gt[1]
heigth_resolution = gt[-1]

coords = list()

iterable = range(0, int(linestring_geom.length), int(width_resolution))
iterable.append(linestring_geom.length)

first_point = linestring_geom.firstPoint
end_point = linestring_geom.lastPoint

for i, r in enumerate(iterable, 1):
    pnt = linestring_geom.positionAlongLine(r, False)
    x, y = pnt.centroid.X, pnt.centroid.Y
    raster_x = int((x - gt[0]) / gt[1])
    raster_y = int((y - gt[3]) / gt[5])

    z_arr = raster.GetRasterBand(1).ReadAsArray(raster_x, raster_y, 1, 1)
    z = z_arr[0][0] + y_ini
    coords.append('{} {}'.format(first_point.X + r, z))
    if z_arr[0][0] > y_top:
        y_top = z_arr[0][0]


linestring_layer = arcpy.MakeFeatureLayer_management(linestring_geom, 'linestring_layer')
pog_layer = arcpy.MakeFeatureLayer_management(pog_path, os.path.basename(pog_path + '_mfl'))
arcpy.SelectLayerByLocation_management(linestring_layer,"INTERSECT", pog_layer, "{} meters".format(tolerancia), "NEW_SELECTION")
query2 = '({}) AND ({} IN (201, 204))'.format(query, st._CODI_FIELD)
cursor = arcpy.da.SearchCursor(pog_layer, ["OID@", st._AZIMUT_FIELD, 'SHAPE@', st._BUZAMIENTO_FIELD, st._CODI_FIELD], query2)
cursor = map(lambda i: i, cursor)

# Pendiente de la linea
linestring_geom_m = (end_point.Y - first_point.Y) / (end_point.X - first_point.X)

# geojson = dict()
# geojson["type"] = "FeatureCollection"
# geojson["features"] = list()

rows = list()

for pog in cursor:
    if not pog[1]:
        continue
    pog_m, pnt = getm(pog[1]), pog[2]
    # arcpy.AddMessage(pog_m)
    
       
    x = ((linestring_geom_m * end_point.X) - (pog_m * pnt.centroid.X) - end_point.Y + pnt.centroid.Y) / (linestring_geom_m - pog_m)
    y = linestring_geom_m * (x - end_point.X) + end_point.Y

    point = arcpy.Point()
    point.X = x
    point.Y = y

    if not linestring_geom.extent.contains(point):
        continue

    ang_secc = getanglebtwnlines(linestring_geom_m, pog_m)

    distance = linestring_geom.measureOnLine(point)

    raster_x = int((x - gt[0]) / gt[1])
    raster_y = int((y - gt[3]) / gt[5])

    z_arr = raster.GetRasterBand(1).ReadAsArray(raster_x, raster_y, 1, 1)

    if not z_arr:
        continue
    z = z_arr[0][0] + y_ini
    coords.append('{} {}'.format(first_point.X + distance, z))
    rows.append({
        'x': first_point.X + distance,
        'y': z,
        st._CODI_FIELD: pog[4],
        st._POG_FIELD: pog[0],
        st._BZ_REAL_FIELD: pog[3], 
        st._A_BZ_SECC_FIELD: ang_secc,
        st._BZ_APAR_FIELD: buzamiento_aparente(pog[3], ang_secc, df_buzamiento_aparente),
        st._BZ_SEC_FIELD: 0,
        st._P_SECC_FIELD: 0,
        st._CODHOJA_FIELD: codhoja
    })
    if z_arr[0][0] > y_top:
        y_top = z_arr[0][0]

arcpy.AddMessage(rows)
df = pd.DataFrame(rows)
tmp_name = 'pog_proyectados_{}'.format(uuid.uuid4().get_hex())

pog_seccion_mfl = arcpy.MakeFeatureLayer_management(pog_seccion_path, tmp_name)

arcpy.SelectLayerByAttribute_management(pog_seccion_mfl, "NEW_SELECTION", query)
arcpy.DeleteRows_management(pog_seccion_mfl)
arcpy.SelectLayerByAttribute_management(pog_seccion_mfl, "CLEAR_SELECTION")

shp_output = os.path.join(st._TEMP_FOLDER, tmp_name + '.shp')
dataframe_to_feature(df, shp_output, ['x', 'y'], mxd.activeDataFrame.spatialReference)
arcpy.Append_management(shp_output, pog_seccion_path, "NO_TEST")

coords.sort(key=lambda i: i.split(' ')[0])


y_top = y_top * 1.2 + y_ini


aux_lines = [first_point.X, y_top, first_point.X, y_ini, first_point.X + linestring_geom.length, y_ini, first_point.X + linestring_geom.length, y_top]

aux_lines_string = '{} {}, {} {}, {} {}, {} {}'.format(*aux_lines)

sec_lines_string = ','.join(coords)

wkt = "MULTILINESTRING (({}), ({}))".format(sec_lines_string, aux_lines_string)


g = arcpy.FromWKT(wkt)

output_name = 'seccion_geologica_{}.shp'.format(codhoja)
output_seccion = os.path.join(st._TEMP_FOLDER, output_name)
arcpy.CopyFeatures_management(g, output_seccion)
response['response'] = output_seccion
# except Exception as e:
#     response['status'] = 0
#     response['message'] = e.message
# finally:
response = json.dumps(response)
arcpy.RefreshTOC()
arcpy.RefreshActiveView()
arcpy.SetParameterAsText(6, response)