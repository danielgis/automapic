import arcpy
import json
import packages as pkg

arcpy.env.overwriteOutput = True

response = dict()
response['status'] = 1
response['message'] = 'success'

category = arcpy.GetParameterAsText(0)

# try:
df = pkg.get_tree_layers(category, as_dataframe=True)
response['response'] = df.to_dict('records')
# except Exception as e:
# response['status'] = 0
# response['message'] = e.message
# finally:
response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
arcpy.SetParameterAsText(1, response)
