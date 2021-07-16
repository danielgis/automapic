# Importar librerias
import arcpy
import json
import settings_aut as st
import uuid
import os

response = dict()
response['status'] = 1
response['message'] = 'success'

cd_depa = arcpy.GetParameterAsText(0)
orientacion = arcpy.GetParameterAsText(1)
escala = arcpy.GetParameterAsText(2)
# titulo = arcpy.GetParameterAsText(3)
# autores = arcpy.GetParameterAsText(4)
# zona = arcpy.GetParameterAsText(5)
# hoja = arcpy.GetParameterAsText(6)

try:
    mxd_path = st._MXD_A0_H if orientacion == "1" else st._MXD_A0_V

    mxd = arcpy.mapping.MapDocument(mxd_path)
    df = mxd.activeDataFrame

    departamentos = arcpy.mapping.ListLayers(mxd, '*{}*'.format(st._LAYER_DEPARTAMENTOS), df)[0]
    query_departamentos = "{} not in ('{}', '99')".format(st._CD_DEPA_FIELD, cd_depa)
    departamentos.definitionQuery = query_departamentos

    departamento = arcpy.mapping.ListLayers(mxd, '*{}'.format(st._LAYER_DEPARTAMENTO), df)[0]
    query_departamento = "{} = '{}'".format(st._CD_DEPA_FIELD, cd_depa)
    departamento.definitionQuery = query_departamento
    arcpy.RefreshActiveView()

    mxd.activeDataFrame.extent = departamento.getExtent()
    mxd.activeDataFrame.scale = int(escala)

    arcpy.RefreshActiveView()

    response['response'] = os.path.join(st._TEMP_FOLDER, 'response_{}.mxd'.format(uuid.uuid4().hex))
    mxd.saveACopy(response['response'])

except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(3, response)
