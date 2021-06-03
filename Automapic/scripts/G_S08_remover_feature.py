# Importar librerias
import arcpy
import json

response = dict()
response['status'] = 1
response['message'] = 'success'

lyr_name = arcpy.GetParameterAsText(0)
df_name = arcpy.GetParameterAsText(1)

try:
    mxd = arcpy.mapping.MapDocument("CURRENT")
    dfs = arcpy.mapping.ListDataFrames(mxd, "*{}*".format(df_name))
    if not len(dfs):
        raise RuntimeError("El dataframe especificado no existe")
    df = dfs[0]
    lyrs = arcpy.mapping.ListLayers(mxd, "*{}*".format(lyr_name), df)
    if len(lyrs):
       arcpy.mapping.RemoveLayer(df, lyrs[0])
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(1, response)
