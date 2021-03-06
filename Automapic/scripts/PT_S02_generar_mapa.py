import arcpy
import settings_aut as st
import messages_aut as msg
from arcpy import mapping
import os
import uuid
# import traceback

_LABEL_CODIGOHOJA = 'CODIGOHOJA'
_LABEL_TITULOMAPA = 'TITULOMAPA'

# Capturamos los parametros
fila = arcpy.GetParameterAsText(0)
columna = arcpy.GetParameterAsText(1)
cuadrante = arcpy.GetParameterAsText(2)
rumbo = arcpy.GetParameterAsText(3)
# author = arcpy.GetParameterAsText(4)

state, message, response = 0, str(), str()

try:

    # output_dir = tempfile.gettempdir()
    id_process = uuid.uuid4().get_hex()
    # Capturamos el autor del mapa

    # author = 'Daniel Aguado'

    # Generamos el codigo de la hoja
    code = '{}{}{}{}'.format(fila, columna, cuadrante, rumbo)
    # code = '10d1no'

    # Realizamos la sentencia sql para el filtro de hoja
    query = "{} = '{}'".format(st._CODE_FIELD, code)

    # Accedemos al feature de cuadriculas para obtener informacion de nombre y zona
    cursor = arcpy.da.SearchCursor(st._CUADRICULAS_PATH, [st._NOMBRE_FIELD, st._ZONA_FIELD], query)
    cuadricula_info = map(lambda i: i, cursor)

    # Si el codigo ingresado no retorna registros se ejecuta un error
    if not cuadricula_info:
        raise RuntimeError(msg._ERROR_CODE_NOT_EXISTS)

    # Capturamos el nombre de la hoja y la zona geografica
    name, zona = cuadricula_info[0]

    # Seleccionar el mxd
    if int(zona) == st._ZONAS_GEOGRAFICAS[0]:
        mxd_path = st._MXD_17
    elif int(zona) == st._ZONAS_GEOGRAFICAS[1]:
        mxd_path = st._MXD_18
    elif int(zona) == st._ZONAS_GEOGRAFICAS[2]:
        mxd_path = st._MXD_19

    # Accedemos al objeto mxd
    mxd = arcpy.mapping.MapDocument(mxd_path)

    # Obtenemos el nombre del feature de cuadriculas
    name_cuadriculas = os.path.basename(st._CUADRICULAS_PATH)

    # Obtenemos el layer de cuadriculas a travez del nombre
    cuad_layers = arcpy.mapping.ListLayers(mxd, name_cuadriculas)

    if not cuad_layers:
        raise RuntimeError(msg._ERROR_NOT_LAYER_CUADRICULAS)

    cuad_lyr = cuad_layers[0]

    # Accedemos al data frame
    dataframes = arcpy.mapping.ListDataFrames(mxd)

    if not dataframes:
        raise RuntimeError(msg._ERROR_NOT_DATAFRAMES)

    dframe = dataframes[0]

    # Actualizamos etiquetas
    elements = arcpy.mapping.ListLayoutElements(mxd, "TEXT_ELEMENT")

    for i in elements:
        if i.name == _LABEL_CODIGOHOJA:
            i.text += code.upper()
        elif i.name == _LABEL_TITULOMAPA:
            i.text += '{} ({})'.format(name, code)
            i.text = i.text.upper()

    # Listamos todas las capas
    all_layers = arcpy.mapping.ListLayers(mxd)

    # Filtramos todas las capas en funcion a la consulta sql (query)
    for lyr in all_layers:
        # Si tiene soporte de consultas
        if lyr.supports("DEFINITIONQUERY"):
            lyr.definitionQuery = query

    # Configurando la extension del mapa
    dframe.extent = cuad_lyr.getExtent()

    # Configurando la escala del mapa
    dframe.scale = st._SCALE_MAPA_TOPOGRAFICO_25K

    # Metadatos del mapa
    mxd.title = code
    # mxd.author = author

    # Refrescando la tabla de contenidos
    arcpy.RefreshTOC()

    # Refrescando la vista activa
    arcpy.RefreshActiveView()

    output_dir_mxd = os.path.join(st._TEMP_FOLDER, id_process)
    os.mkdir(output_dir_mxd)

    name_out = '{}.mxd'.format(code)

    response = os.path.join(output_dir_mxd, name_out)

    # Guardando una copia
    mxd.saveACopy(response)
    del mxd

    state, message, response = 1, 'success', response

except Exception as e:
    message = e.message
finally:
    arcpy.SetParameterAsText(4, state)
    arcpy.SetParameterAsText(5, message)
    arcpy.SetParameterAsText(6, response)