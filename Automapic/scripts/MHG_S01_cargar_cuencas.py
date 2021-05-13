import arcpy
import settings as st
import os
import json
import messages as msg
import automapic as aut

arcpy.env.addOutputsToMap = True

# Parametro de codigos separados por comas
codigos_cuencas = arcpy.GetParameterAsText(0)

response = dict()
response['status'] = 1
response['message'] = 'success'

try:
    query = "{} IN ('{}')".format(st._CD_CUENCA, "', '".join(codigos_cuencas.split(',')))
    if not arcpy.Exists(st._PL_01_CUENCAS_HIDROGRAFICAS_PATH):
        raise RuntimeError(msg._ERROR_FEATURE_CUENCAS_HG)

    features = [st._PL_01_CUENCAS_HIDROGRAFICAS_PATH]
    symbols = [None]

    aut.check_layer_inside_data_frame(features, symbols, df_name=None, query=query, zoom=True)
    response['response'] = True
    
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response)
    arcpy.SetParameterAsText(1, response)
