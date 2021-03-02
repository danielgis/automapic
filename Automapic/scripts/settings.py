import os
import packages as pkg


_BASE_DIR = os.path.dirname(__file__)
_TEMP_FOLDER = pkg.get_config_param_value('TEMP_FOLDER', one=True)
_ZONAS_GEOGRAFICAS = [17, 18, 19]

_LAYERS_DIR = os.path.join(_BASE_DIR, 'layers')
_EXT_LAYER = '.lyr'     # Extension de archivos Layer


# ---------------------------------------------------------------------------------------------------
# Plano topografico 25000

_GDB_DIR = pkg.get_config_param_value('GDB_PATH_PT', one=True)
_CUADRICULAS_PATH = os.path.join(_GDB_DIR, 'PO_00_cuadriculas')
_MXD_DIR = os.path.join(_BASE_DIR, 'mxd')
_MXD_17 = os.path.join(_MXD_DIR, 'T0117.mxd')
_MXD_18 = os.path.join(_MXD_DIR, 'T0218.mxd')
_MXD_19 = os.path.join(_MXD_DIR, 'T0319.mxd')


# GENERAL FIELDS
_CODE_FIELD = 'code'
_ZONA_FIELD = 'zona'
_NOMBRE_FIELD = 'nombre'
_FILA_FIELD = 'fila'
_COLUMNA_FIELD = 'columna'
_CUADRANTE_FIELD = 'cuadrante'
_RUMBO_FIELD = 'rumbo'

_SCALE_MAPA_TOPOGRAFICO_25K = 25000

# ---------------------------------------------------------------------------------------------------
# Mapas DGAR

_GDB_DIR_DGAR = pkg.get_config_param_value('GDB_PATH_PG', one=True)

_FC_PO_AREA_INTERES_17 = os.path.join(_GDB_DIR_DGAR, 'PO_area_interes_17')
_FC_PO_AREA_INTERES_18 = os.path.join(_GDB_DIR_DGAR, 'PO_area_interes_18')
_FC_PO_AREA_INTERES_19 = os.path.join(_GDB_DIR_DGAR, 'PO_area_interes_19')

# GENERAL FIELDS
_ID_AREA = 'id_area'


# ---------------------------------------------------------------------------------------------------
# 