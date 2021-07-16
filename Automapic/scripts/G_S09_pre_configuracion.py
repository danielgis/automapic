# Importar librerias
import arcpy
import json
import packages_aut as pkg
import settings_aut as st
import tempfile

response = dict()
response['status'] = 1
response['message'] = 'success'

# try:
# Verificacion de parametros
# Obtenemos el directorio de archivos temporales actual
_TEMP_FOLDER = pkg.get_config_param_value('TEMP_FOLDER', one=True)
# Si no se ha configurado
if _TEMP_FOLDER is None:
    # Se agrega automaticamente el folder de archivos temporales por defecto de ArcMap
    _TEMP_FOLDER = tempfile.gettempdir()
    pkg.set_config_param(1, _TEMP_FOLDER, iscommit=True)

# Obtenemos la conexion a la base de datos coorporativa de ingemmet
_SDE_CONN = pkg.get_config_param_value('SDE_CONN', one=True)
# Si no se ha configurado
# if (_SDE_CONN is None) or (_SDE_CONN == st._BDGEOCAT_SDE_DEV) or (_SDE_CONN == st._BDGEOCAT_SDE):
if (_SDE_CONN is None):
    # Se agrega automaticamente el SDE registado dentro de la aplicacion
    _SDE_CONN = st._BDGEOCAT_SDE
    pkg.set_config_param(3, _SDE_CONN, iscommit=True)
    pkg.set_datasources_tree_layers(_SDE_CONN, 1, 9, iscommit=True)
# except Exception as e:
#     response['status'] = 0
#     response['message'] = e.message
# finally:
#     response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
#     arcpy.SetParameterAsText(1, response)
