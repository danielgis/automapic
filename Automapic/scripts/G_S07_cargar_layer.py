# Importar librerias
import arcpy
import json
import automapic as aut
import os
import settings as st

response = dict()
response['status'] = 1
response['message'] = 'success'

feature = arcpy.GetParameterAsText(0)
layer = arcpy.GetParameterAsText(1)
workspace = arcpy.GetParameterAsText(2)
typeworkspace = arcpy.GetParameterAsText(3)
df_name = arcpy.GetParameterAsText(4)
query = arcpy.GetParameterAsText(5)
zoom = arcpy.GetParameter(6)


try:
    name_feature = os.path.basename(feature)
    if layer:
        layer = os.path.join(st._LAYERS_DIR, layer)
    aut.add_layer_with_new_datasource(layer, name_feature, workspace, typeworkspace, df_name=df_name, query=query, zoom=zoom)
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(7, response)
