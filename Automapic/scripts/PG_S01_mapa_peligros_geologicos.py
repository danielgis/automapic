import arcpy
import settings as st
import messages as msg
import arcobjects as arc
import os
from bisect import bisect
import uuid
import json

_DF_MAPAPRINCIPAL = 'DFMAPAPRINCIPAL'
_PT_LAYER_INTERES = 'PT_area_interes_{}'
_PL_LAYER_INTERES = 'PL_area_interes_{}'
_PO_LAYER_INTERES = 'PO_area_interes_{}'

_TITULO_MAPA_TEXT_ELEMENT = 'TITULOMAPA'
_AUTOR_TEXT_ELEMENT = 'AUTOR'
_NUMEROMAPA_TEXT_ELEMENT = 'NUMEROMAPA'
_BARRA_ESCALA = 'BARRAESCALA'


def get_orientation():
    pass

def get_scale(scale):
    range_a = range(0, 1001, 500)
    range_b = range(5000, 100000, 5000)
    range_c = range(100000, 500000, 50000)
    scales = range_a + range_b + range_c
    idx = bisect(scales, scale)
    response = scales[idx]
    return response


def set_scale_bar(scale):
    _UNITS_KM = 10
    _UNITS_M = 9
    response = dict()
    scale_ratio = scale/100
    response['Division'] = scale_ratio/1000.0 if scale >= 100000 else scale_ratio
    response['UnitLabel'] = 'Kilometers'if scale >= 100000 else 'Meters'
    response['Units'] = _UNITS_KM if scale >= 100000 else _UNITS_M
    return response

def set_PG(mxd):
    return mxd

def set_ZC(mxd):
    return mxd

def set_SIEF(mxd):
    return mxd

def set_SSM(mxd):
    return mxd

def generate_map():
    global titulo, autor, escala, numero
    response = dict()
    id_process = uuid.uuid4().get_hex()
    desc = arcpy.Describe(feature)
    wkid = desc.spatialReference.factoryCode

    if not wkid:
        raise RuntimeError(msg._ERROR_NOT_PROJECTION)

    if wkid == st._EPSG_W17S:
        mxd_path = st._MXD_PG_17
    elif wkid == st._EPSG_W18S:
        mxd_path = st._MXD_PG_18
    elif wkid == st._EPSG_W19S:
        mxd_path = st._MXD_PG_19
    else:
        raise RuntimeError(msg._ERROR_PROJECTION_NO_VALID)
    
    shapeType = desc.shapetype.lower()

    zona = str(wkid)[3:]

    if shapeType == 'point':
        _NAME_LAYER_INTERES = _PT_LAYER_INTERES
    elif shapeType == 'polyline':
        _NAME_LAYER_INTERES = _PL_LAYER_INTERES
    elif shapeType == 'polygon':
        _NAME_LAYER_INTERES = _PO_LAYER_INTERES

    _NAME_LAYER_INTERES = _NAME_LAYER_INTERES.format(zona)

    mxd = arcpy.mapping.MapDocument(mxd_path)
    df_principal = arcpy.mapping.ListDataFrames(mxd, '{}'.format(_DF_MAPAPRINCIPAL))[0]
    lyr_interes = arcpy.mapping.ListLayers(mxd, '{}'.format(_NAME_LAYER_INTERES), df_principal)[0]

    shape_dir = os.path.dirname(feature)
    shape_name =  os.path.basename(feature)
    shape_name_without_ext = shape_name.split('.')[0]

    lyr_interes.replaceDataSource(shape_dir, "SHAPEFILE_WORKSPACE", shape_name_without_ext, False)
    arcpy.RefreshTOC()
    arcpy.RefreshActiveView()

    coords = [xmin, ymin, xmax, ymax]
    coords = filter(lambda i: i, coords)

    ext = arcpy.Extent(*coords) if len(coords) == 4 else lyr_interes.getExtent()
    lyr_interes.visible = True

    response['extent'] = json.loads(ext.JSON)

    df_principal.extent = ext
    scale = get_scale(df_principal.scale)
    df_principal.scale = scale

    arcpy.RefreshTOC()
    arcpy.RefreshActiveView()

    if not titulo:
        titulo = 'Lorem Ipsum'
    if not autor:
        autor = 'AUtomapic'
    if not numero:
        numero = '1'

    mxd.author = autor

    text_elements = arcpy.mapping.ListLayoutElements(mxd , "TEXT_ELEMENT")

    for elm in text_elements:
        if elm.name == _TITULO_MAPA_TEXT_ELEMENT:
            elm.text = titulo.upper()
        # elif elm.name == _AUTOR_TEXT_ELEMENT:
        #     elm.text += autor
        elif elm.name == _NUMEROMAPA_TEXT_ELEMENT:
            elm.text = numero.zfill(2)

    arcpy.RefreshTOC()
    arcpy.RefreshActiveView()

    output_dir_mxd = os.path.join(st._TEMP_FOLDER, id_process)
    os.mkdir(output_dir_mxd)
    name = titulo.replace(' ', '')
    name_out = '{}.mxd'.format(name)
    response['mxd'] = os.path.join(output_dir_mxd, name_out)
    mxd.saveACopy(response['mxd'])

    params = set_scale_bar(scale)
    arc.set_scale_properties(response['mxd'], _BARRA_ESCALA, **params)
    arc.select_grid(response['mxd'], scale)
    return response

    
if __name__ == '__main__':
    response = dict()
    response['status'] = 0
    feature = arcpy.GetParameterAsText(0)
    maptype = arcpy.GetParameterAsText(1)
    titulo = arcpy.GetParameterAsText(2)
    autor = arcpy.GetParameterAsText(3)
    escala = arcpy.GetParameter(4)
    numero = arcpy.GetParameterAsText(5)
    detalle = arcpy.GetParameterAsText(6)
    xmin = arcpy.GetParameter(7)
    ymin = arcpy.GetParameter(8)
    xmax = arcpy.GetParameter(9)
    ymax = arcpy.GetParameter(10)

    try:
        response['response'] = generate_map()
        response['status'] = 1
    except Exception as e:
        response['message'] = e.message
    finally:
        response = json.dumps(response)
        arcpy.SetParameterAsText(11, response)

