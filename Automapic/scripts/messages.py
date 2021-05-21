# -*-coding: utf-8-*-

from datetime import datetime

_ERROR_MXD_PATH_NOT_EXISTS = 'La ubicacion del archivo mxd especificado no existe'
_ERROR_CODE_NOT_EXISTS = 'El codigo de cuadricula especificado no existe'
_ERROR_NOT_LAYER_CUADRICULAS = 'El layer de cuadriculas no exista o no se encuentra presente en el mapa'
_ERROR_NOT_DATAFRAMES = 'No se encontramos data frames en el mapa'

_OPEN_DIALOG_TITLE = 'Seleccione un directorio'
_OPEN_DIALOG_BUTTON_TITLE = 'Seleccionar'

_ERROR_NOT_PROJECTION = 'El archivo especificado no tiene una proyeccion cartografica valida'
_ERROR_PROJECTION_NO_VALID = u'El archivo especificado tiene una proyección no valida. Proyecciones validas WGS 17, 18, 19S'

_ERROR_UNREGISTERED_USER = 'El usuario ingresado no esta registrado'
_ERROR_INCORRECT_PASSWORD = u'La contraseña ingresada no es correcta'
_ERROR_NO_MODULES_ASSIGNED = u'El usuario no tiene módulos asignados'
_ERROR_ADD_USER = 'Por favor ingrese un nombre de usuario'
_ERROR_ADD_PASSWORD = 'Por favor ingrese una contraseña'

_SET_CONFIG_TEMP_FOLDER = u'Configuración del directorio de archivos temporales'
_SET_CONFIG_GDB_PT = u'Configuración de la geodatabase de archivos para el módulo de Planos Topográficos 25000'
_SET_CONFIG_MXD_PT_17 = u'Configuración del documento de mapa en zona 17 para el módulo de Planos Topográficos 25000'
_SET_CONFIG_MXD_PT_18 = u'Configuración del documento de mapa en zona 18 para el módulo de Planos Topográficos 25000'
_SET_CONFIG_MXD_PT_19 = u'Configuración del documento de mapa en zona 19 para el módulo de Planos Topográficos 25000'
_SET_CONFIG_MXD_PG_17 = u'Configuración del documento de mapa en zona 17 para el módulo de Peligros Geológicos'
_SET_CONFIG_MXD_PG_18 = u'Configuración del documento de mapa en zona 18 para el módulo de Peligros Geológicos'
_SET_CONFIG_MXD_PG_19 = u'Configuración del documento de mapa en zona 19 para el módulo de Peligros Geológicos'
_SET_GDB_MHIDROGEO = u'Configuración de la geodatabase de archivos para el módulo de Mapas Hidrogeológicos'
_PROCESS_FINISHED = 'Proceso finalizado correctamente'
_SET_CONFIG_GDB_PG = 'Configuración de la geodatabase de archivos para el módulo de Peligros Geológicos'

_ERROR_FEATURE_CUADRICULAS_MG = 'El feature class de hojas a escala 500000 no se encuentra en la geodatabase'
_ERROR_FEATURE_CUENCAS_HG = u'El feature class de Cuencas no existe, o no se declaro la geodatabase en la sección de configuración'
_ERROR_FEATURE_AUTORES_HG = u'El feature table de Autores no existe, o no se declaro la geodatabase en la sección de configuración'
_ERROR_FEATURE_FHIDROGEO_HG = u'El feature class de Formaciones hidrogeológicas no existe, o no se declaro la geodatabase en la sección de configuración'
_ERROR_FEATURE_UHIDROGEO_HG = u'El feature class de Unidades hidrogeológicas no existe, o no se declaro la geodatabase en la sección de configuración'

_NAME_DGAR = u'Dirección de Geología Ambiental y Riesgo Geológico'
_NAME_INGEMMET = u'INSTITUTO GEOLÓGICO MINERO Y METALÚRGICO'
_NAME_SECTOR = u'SECTOR ENERGÍA Y MINAS'

year = datetime.today().year
_DETALLE_ROTULO = u'Versión digital: Año {} Lima - Perú'.format(year)
