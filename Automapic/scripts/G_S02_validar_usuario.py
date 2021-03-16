import arcpy
import packages as pkg
import messages as msg
import json

user = arcpy.GetParameterAsText(0)
password = arcpy.GetParameterAsText(1)

response = dict()
response['status'] = 0

try:
    if not user:
        raise RuntimeError(msg._ERROR_ADD_USER)
    if not password:
        raise RuntimeError(msg._ERROR_ADD_PASSWORD)
    # Valida si el usuario existe
    validate_user = pkg.get_validate_user(user, one=True)
    if not validate_user:
        raise RuntimeError(msg._ERROR_UNREGISTERED_USER)
    # Valida si el usuario y password existen
    validate_user_pass = pkg.get_validate_user_pass(user, password, one=True)
    if not validate_user_pass:
        raise RuntimeError(msg._ERROR_INCORRECT_PASSWORD)
    # Valida si el usuario tiene modulos asignados
    perfil = pkg.get_perfil(user)
    if not perfil:
        raise RuntimeError(msg._ERROR_NO_MODULES_ASSIGNED)
    
    modules = [[i[0], i[1].encode('windows-1252')] for i in perfil]
    response['status'] = 1
    response['response'] = modules
except Exception as e:
    response['message'] = e.message
finally:
    arcpy.SetParameterAsText(2, json.dumps(response, ensure_ascii=False))