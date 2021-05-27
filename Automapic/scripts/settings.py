import os
import packages as pkg


_BASE_DIR = os.path.dirname(__file__)
_TEMP_FOLDER = pkg.get_config_param_value('TEMP_FOLDER', one=True)
_REQUIREMENTS_DIR = os.path.join(_BASE_DIR, 'require')

_IMG_DIR = os.path.join(_BASE_DIR, 'img')
_IMG_LOGO_INGEMMET = os.path.join(_IMG_DIR, 'logo_ingemmet.png')

_ZONAS_GEOGRAFICAS = [17, 18, 19]
_EPSG_W17S = 32717
_EPSG_W18S = 32718
_EPSG_W19S = 32719

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

# MXD
_MXD_PG_17 = os.path.join(_MXD_DIR, 'T01PG17.mxd')
_MXD_PG_18 = os.path.join(_MXD_DIR, 'T01PG18.mxd')
_MXD_PG_19 = os.path.join(_MXD_DIR, 'T01PG19.mxd')

# GENERAL FIELDS
_ID_AREA = 'id_area'


# ---------------------------------------------------------------------------------------------------
# Mapa Geologico
# PATHS

_CODHOJA_FIELD = 'CODHOJA'
_POG_FIELD = 'POG'
_AZIMUT_FIELD = 'AZIMUT'
_CODI_FIELD = 'CODI'
_BUZAMIENTO_FIELD = 'BUZAMIENTO'
_BZ_REAL_FIELD = 'BZ_REAL'
_A_BZ_SECC_FIELD = "A_BZ_SECC"
_BZ_SEC_FIELD = "BZ_SEC" 
_P_SECC_FIELD = "P_SECC"
_BZ_APAR_DD_FIELD = "BZ_APAR_DD"
_BZ_APAR_FIELD = "BZ_APAR"

_CUADRICULAS_MG_PATH = r'DS01_DATO_GEOGRAFICO\GPO_DG_HOJAS_50K'
_ULITO_MG_PATH = r'DS06_GEOLOGIA_{}S\GPO_DGR_ULITO_{}S'
_POG_MG_PATH = r'DS06_GEOLOGIA_{}S\GPT_DGR_POG_{}S'
_POG_MG_PERFIL_PATH = r'DS12_PERFIL_{}S\GPT_MG_PERFIL_{}S'
_GPL_MG_PERFIL_PATH = r'DS12_PERFIL_{}S\GPL_MG_PERFIL_{}S'
_TB_MG_BUZAMIENTO_APARENTE_PATH = 'TB_MG_BUZAMIENTO_APARENTE'


# ---------------------------------------------------------------------------------------------------
# :Mapa HidroGeologico
# :PATHS
_GDB_PATH_HG = pkg.get_config_param_value('GDB_PATH_HG', one=True)
_PL_01_CUENCAS_HIDROGRAFICAS_PATH = os.path.join(_GDB_PATH_HG if _GDB_PATH_HG else '', 'PL_01_cuencas_hidrograficas')
_TB_01_AUTOR_PATH = os.path.join(_GDB_PATH_HG if _GDB_PATH_HG else '', 'TB_01_autor')
_PO_01_FORMACION_HIDROGEOLOGICA_PATH = os.path.join(_GDB_PATH_HG if _GDB_PATH_HG else '', 'PO_01_formacion_hidrogeologica_{}s')
_TB_01_UNIDAD_HIDROGEOLOGICA_PATH = os.path.join(_GDB_PATH_HG if _GDB_PATH_HG else '', 'TB_01_unidadad_hidrogeologica')
_TB_01_LEYENDA_AUX_PATH = os.path.join(_GDB_PATH_HG if _GDB_PATH_HG else '', 'TB_01_leyenda_aux')
_PO_01_LEYENDA_DIVISIONES_PATH = os.path.join(_GDB_PATH_HG if _GDB_PATH_HG else '', 'PO_01_leyenda')
_PT_01_LEYENDA_ETIQUETAS_PATH = os.path.join(_GDB_PATH_HG if _GDB_PATH_HG else '', 'PT_01_leyenda_etiquetas')

# :FIELDS
_CD_CUENCA = 'cd_cuenca'
_NM_CUENCA = 'nm_cuenca'

_ID_AUTOR = "id_autor"
_ABREV = "abrev"

_ID_FHIDROG = "id_fhidrog"
_N_FHIDROG = "n_fhidrog"
_D_FHIDROG = "d_fhidrog"
_LITOLOGIA_G = "litologia_g"
_ORDEN = "orden"
_UHIDROG = "uhidrog"

_ID = "id"
_GREEN = "green"
_RED = "red"
_BLUE = "blue"

_CL_HIDROG = "cl_hidrog"
_SCL_HIDROG = "scl_hidrog"