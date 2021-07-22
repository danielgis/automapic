# Importar librerias
import arcpy
import json
import settings_aut as st
import uuid
import os
import arcobjects as arc

# Parametros
response = dict()
response['status'] = 1
response['message'] = 'success'

cd_depa = arcpy.GetParameterAsText(0)       # Codigo de la departamento (string requerido)
orientacion = arcpy.GetParameter(1)   # 1: Horizontal, 0: Vertical (integer requerido)
zona = arcpy.GetParameter(2)          # Zona geografica 17, 18, 19 (integer requerido)
escala = arcpy.GetParameter(3)        # 25000, 50000, 100000... (integer requerido)
autores = arcpy.GetParameterAsText(4)       # "Juanito, Perez, Lui, ... " (string opcional)
outmxd = arcpy.GetParameterAsText(5)        # Ruta de salida del mapa (string opcional)


_DFMAPAPRINCIPAL = "DFMAPAPRINCIPAL"
_DFMAUBICACION = "DFMAPAUBICACION"
_ELM_TITLE = "ELM_TITLE"
_ELM_TITLE_ORIG = "ELM_TITLE_ORIG"
_ELM_AUTOR = "ELM_AUTOR"
_ELM_AUTOR_ORIG = "ELM_AUTOR_ORIG"
_ELM_DATUM = "ELM_DATUM"
_ELM_DATUM_ORIG = "ELM_DATUM_ORIG"


try:
    # Localizar el archivo mxd
    mxd_path = st._MXD_A0_H if orientacion == 1 else st._MXD_A0_V

    # Cargar el mxd
    mxd = arcpy.mapping.MapDocument(mxd_path)

    # DataFrame activo _DFMAPAPRINCIPAL
    df_mapa_principal = mxd.activeDataFrame

    # Dataframe del mapa de ubicacion
    df_mapa_ubicacion = arcpy.mapping.ListDataFrames(mxd, '*{}*'.format(_DFMAUBICACION))[0] 

    # Query departamentos
    query_departamentos = "{} not in ('{}', '99')".format(st._CD_DEPA_FIELD, cd_depa)

    # Query departamento
    query_departamento = "{} = '{}'".format(st._CD_DEPA_FIELD, cd_depa)

    # Departamentos del dataframe principal
    departamentos = arcpy.mapping.ListLayers(mxd, '*{}*'.format(st._LAYER_DEPARTAMENTOS), df_mapa_principal)[0]
    departamentos.definitionQuery = query_departamentos

    departamento = arcpy.mapping.ListLayers(mxd, '*{}'.format(st._LAYER_DEPARTAMENTO), df_mapa_principal)[0]
    departamento.definitionQuery = query_departamento

    arcpy.AddMessage(query_departamento)
    arcpy.AddMessage(arcpy.GetCount_management(departamento))

    arcpy.RefreshActiveView()

    # Nombre del departamento
    nm_depa = map(lambda i: i[0], arcpy.da.SearchCursor(st._TB_REGION_CONFIG, [st._NM_DEPA_FIELD], query_departamento))[0]

    # Departamentos del dataframe ubicacion
    departamento_ubicacion = arcpy.mapping.ListLayers(mxd, '*{}*'.format(st._LAYER_DEPARTAMENTO), df_mapa_ubicacion)[0]
    departamento_ubicacion.definitionQuery = query_departamento

    elms = arcpy.mapping.ListLayoutElements(mxd, "TEXT_ELEMENT")

    # Configurar rotulos
    for elm in elms:
        if elm.name in (_ELM_TITLE, _ELM_TITLE_ORIG):
            # pass
            elm.text = elm.text.format(nm_depa)
        if autores and elm.name in (_ELM_AUTOR, _ELM_AUTOR_ORIG):
            elm.text = autores
        if elm.name in (_ELM_DATUM, _ELM_DATUM_ORIG):
            elm.text = elm.text.format(zona)

    # Configurando la escala
    df_mapa_principal.extent = departamento.getExtent()
    df_mapa_principal.scale = escala

    arcpy.RefreshActiveView()
    arcpy.RefreshTOC()

    # Devolver la ubicacion del mapa
    response['response'] = outmxd if outmxd else os.path.join(st._TEMP_FOLDER, 'response_{}.mxd'.format(uuid.uuid4().hex))
    mxd.saveACopy(response['response'])
    del mxd

    # Seleccionar la grilla del mapa principal
    arc.select_grid_by_name(response['response'], '327{}'.format(zona), exclude_grids=['4326'])

except Exception as e:
    # En caso de error, se retorna un json con la descripcion del error
    response['status'] = 0
    response['message'] = e.message
finally:
    # Se guarda el json de respuesta
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(6, response)
