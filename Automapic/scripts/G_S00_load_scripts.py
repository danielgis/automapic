import arcpy
import settings_aut as st
# import packages_aut as pkg
# import messages_aut as msg
import json
import os

response = dict()
response['status'] = 1
response['message'] = 'success'



# try:
# st._BASE_DIR = st._BASE_DIR.replace('\\\\', '\\')
arcpy.ImportToolbox(os.path.join(st._BASE_DIR, "T00_automapic"))
arcpy.ImportToolbox(os.path.join(st._BASE_DIR, "T01_plano_topografico_25k"))
arcpy.ImportToolbox(os.path.join(st._BASE_DIR, "T02_mapa_peligros_geologicos"))
arcpy.ImportToolbox(os.path.join(st._BASE_DIR, "T03_mapa_geologico_50k"))
# Insertar procesos
response['response'] = 1
# except Exception as e:
#     response['status'] = 0
#     response['message'] = e.message
# finally:
response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
arcpy.SetParameterAsText(0, response)