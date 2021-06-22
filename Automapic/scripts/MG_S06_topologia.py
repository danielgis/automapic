# Importar librerias
import arcpy
import json
import settings_aut as st
import packages_aut as pkg
import messages_aut as msg
import os
import automapic as aut

response = dict()
response['status'] = 1
response['message'] = 'success'

hojas = arcpy.GetParameterAsText(0)
topologias = arcpy.GetParameterAsText(1)
zona = arcpy.GetParameterAsText(2)
geodatabase = arcpy.GetParameterAsText(3)

workspace = arcpy.env.scratchGDB

def topology_overlaps(geologia):
    global workspace
    response = os.path.join(workspace, 'Overlaps')
    its = arcpy.Intersect_analysis(geologia, response)
    return response


def topology_holes(geologia, hoja):
    global workspace
    geologia_diss = arcpy.Dissolve_management(geologia, 'in_memory\\geologia_diss')
    shape_diss = map(lambda i: i[0], arcpy.da.SearchCursor(geologia_diss, ["SHAPE@"]))[0]
    hojas_diss = arcpy.Dissolve_management(hoja, 'in_memory\\hojas_diss')
    shape_hoja = map(lambda i: i[0], arcpy.da.SearchCursor(hojas_diss, ["SHAPE@"]))[0]
    symdif = shape_diss.symmetricDifference(shape_hoja)
    symdif_feature = arcpy.CopyFeatures_management(symdif, 'in_memory\\symdif')
    response = os.path.join(workspace, 'Holes')
    arcpy.MultipartToSinglepart_management(symdif_feature, response)
    return response

try:
    # Se construye la consulta de hojas seleccionadas
    hojas = hojas.replace("'", '').replace(" ", '')
    query = "{} in ('{}')".format(st._CODHOJA_FIELD, "', '".join(hojas.split(',')))
    
    # Se construye la consulta de topologias seleccionadas
    topologias = topologias.replace("'", '').replace(" ", '')

    # Se obtiene el makefeaturelayer de las hojas seleccionadas
    feature_path = os.path.join(geodatabase, _ULITO_MG_PATH.format(zona, zona))
    feature_mfl = arcpy.MakeFeatureLayer_management(feature_path, 'ulitomfl', query)

    # Evaluando topologias
    df = pkg.get_topology_items(topologias, as_dataframe=True)
    for idx, row in df.iterrows():
        if row['ID'] == 1:
            # Topologias overlaps
            response = topology_overlaps(feature_mfl)
            layer = os.path.join(st._LAYERS_DIR, 'GPO_MG_OVERLAPS.lyr')
        elif row['ID'] == 2:
            # Topologia holes
            hojas = arcpy.MakeFeatureLayer_managementst.(st._CUADRICULAS_MG_PATH, 'hojas', query)
            response = topology_holes(feature_mfl, hojas)
            layer = os.path.join(st._LAYERS_DIR, 'GPO_MG_HOLES.lyr')

        name_feature = os.path.basename(response)
        aut.add_layer_with_new_datasource(layer, response, workspace, 'FILEGDB_WORKSPACE', zoom=True)

except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(4, response)
