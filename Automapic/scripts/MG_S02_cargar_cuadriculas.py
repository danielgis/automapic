import arcpy
import settings_aut as st
import os
import json
import messages_aut as msg

arcpy.env.addOutputsToMap = True

gdb_path = arcpy.GetParameterAsText(0)

response = dict()
response['status'] = 1
response['message'] = 'success'

try:
    params = arcpy.GetParameterInfo()

    path_feature = os.path.join(gdb_path, st._CUADRICULAS_MG_PATH)
    mxd = arcpy.mapping.MapDocument("CURRENT")
    mxd.activeDataFrame.spatialReference = arcpy.SpatialReference(4326)
    if not arcpy.Exists(path_feature):
        raise RuntimeError(msg._ERROR_FEATURE_CUADRICULAS_MG)
    response['response'] = path_feature
    
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response)
    arcpy.SetParameterAsText(1, path_feature)
    arcpy.SetParameterAsText(2, response)
