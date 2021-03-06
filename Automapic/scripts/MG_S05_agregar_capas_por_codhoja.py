# import arcpy
import json
import settings_aut as st
from automapic import *

response = dict()
response['status'] = 1
response['message'] = 'success'

# geodatabase = arcpy.GetParameterAsText(0)
zona = arcpy.GetParameterAsText(0)
codhoja = arcpy.GetParameterAsText(1)

try:
    features = [
        st._ULITO_MG_PATH,
        st._POG_MG_PATH
    ]
    features = map(lambda i: i.format(zona, zona), features)
    query = "{} = '{}'".format(st._CODHOJA_FIELD, codhoja)
    name_ulito = os.path.basename(features[0])
    layers = [
        os.path.join(st._BASE_DIR, 'layers/{}_G.lyr'.format(name_ulito)),
        os.path.join(st._BASE_DIR, 'layers/pog.lyr')
    ]
    check_layer_inside_data_frame(features, layers, df_name=None, query=query)
    response['response'] = True
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response)
    arcpy.SetParameterAsText(2, response)
