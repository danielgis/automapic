# import arcpy
import json
import settings as st
from automapic import *

response = dict()
response['status'] = 1
response['message'] = 'success'

geodatabase = arcpy.GetParameterAsText(0)
zona = arcpy.GetParameterAsText(1)
codhoja = arcpy.GetParameterAsText(2)


features = [
    st._ULITO_MG_PATH,
    st._POG_MG_PATH
]

layers = [
    None,
    os.path.join(st._BASE_DIR, 'layers/pog.lyr')
]

try:
    features = map(lambda i: os.path.join(geodatabase, i.format(zona, zona)), features)
    query = "{} = '{}'".format(st._CODHOJA_FIELD, codhoja)
    check_layer_inside_data_frame(features, layers, df_name=None, query=query)
    response['response'] = True
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response)
    arcpy.SetParameterAsText(3, response)
