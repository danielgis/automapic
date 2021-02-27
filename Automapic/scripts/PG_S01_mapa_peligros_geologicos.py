import arcpy
import settings as st
import messages as msg
import arcobjects as arc
import os
from bisect import bisect
import uuid


code = arcpy.GetParameterAsText(0)
zona = arcpy.GetParameterAsText(0)
maptype = arcpy.GetParameterAsText(1)
# titulo = arcpy.GetParameterAsText(2)
# autor = arcpy.GetParameterAsText(3)
# numero = arcpy.GetParameterAsText(4)
# detalle = arcpy.GetParameterAsText(6)
# descripcion = arcpy.GetParameterAsText(7)


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


def set_PG(mxd):
    return mxd

def set_ZC(mxd):
    return mxd

def set_SIEF(mxd):
    return mxd

def set_SSM(mxd):
    return mxd


# def set_scale_bar():
#     2000

def generate_map():
    id_process = uuid.uuid4().get_hex()
    if int(zona) == st._ZONAS_GEOGRAFICAS[0]:
        mxd_path = ''
        feature = st._FC_PO_AREA_INTERES_17
    elif int(zona) == st._ZONAS_GEOGRAFICAS[1]:
        mxd_path = ''
        feature = st._FC_PO_AREA_INTERES_18
    elif int(zona) == st._ZONAS_GEOGRAFICAS[2]:
        mxd_path = ''
        feature = st._FC_PO_AREA_INTERES_19

    query = "{} = '{}'".format(_ID_AREA, code)

    mxd = arcpy.mapping.MapDocument(mxd_path)
    dframe_main = arcpy.mapping.ListDataFrames(mxd)[0]
    name_feature = os.path.basename(feature)

    layers = arcpy.mapping.ListLayers(mxd, name_feature, dframe_main)[0]

    if not layers:
        raise RuntimeError(msg._ERROR_NOT_LAYER)
        
    lyr = layers[0]

    # Si tiene soporte de consultas
    if lyr.supports("DEFINITIONQUERY"):
        lyr.definitionQuery = query
    
    arcpy.RefreshActiveView()

    dframe_main.extent = lyr.getExtent()
    scale = get_scale(dframe.scale)
    dframe.scale = scale

    arcpy.RefreshActiveView()

    if maptype == 1:
        mxd = et_PG(mxd)
    elif mapdtype == 2:
        mxd = set_ZC(mxd)
    elif maptype == 3:
        mxd = set_SIEF(mxd)
    elif maptype == 4:
        mxd = set_SSM(mxd)

    output_dir_mxd = os.path.join(st._TEMP_FOLDER, id_process)
    os.mkdir(output_dir_mxd)



    # name_out = '{}_{}.mxd'.format(code)

    # response = os.path.join(output_dir_mxd, name_out)

    # mxd.saveACopy()

    