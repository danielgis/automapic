# -*- coding: utf-8 -*-

import arcpy
import json
import settings as st
import messages as msg
import matplotlib.pyplot as plt
import matplotlib.image as mpimg
from matplotlib.offsetbox import TextArea, DrawingArea, OffsetImage, AnnotationBbox
import PG_S01_mapa_peligros_geologicos as mpg
from datetime import datetime
import uuid


# tamanio = arcpy.GetParameterAsText(0)
# autores = arcpy.GetParameterAsText(1)
# titulo1 = arcpy.GetParameterAsText(2)
# titulo2 = arcpy.GetParameterAsText(3)
# numero = arcpy.GetParameterAsText(4)
tamanio = '1'
autores = ''
titulo1 = u'HIDROGEOLOGÍA DE LA CUENCA DEL RÍO TARAU, COATA'
titulo2 = u'Mapa Hidrogeológico Sector Imaginacionlandia'
numero = '9.5'

cm = 1/2.54

nombre_dgar = u'Dirección de Geología Ambiental y Riesgo Geológico'
nombre_ingemmet = u'INSTITUTO GEOLÓGICO MINERO Y METALÚRGICO'
nombre_sector = u'SECTOR ENERGÍA Y MINAS'

border_color = '#000000'
font_TimesNewRoman = 'Times New Roman'
font_Arial = 'Arial'
fontsize_titulo1 = 6
fontsize_titulo2 = 7
fontisze_numero = 24
fontsize_figura = 6.2
fontsize_detalle = 6.4
fontsize_nombre_dgar = 6
fontsize_nombre_ingemmet = 3
fontsize_nombre_sector = 3

if tamanio == '1':
    # :Dimensiones de rotulo
    w, h = 7 * cm, 3.5* cm
    w_numero, h_numero = 1.5 * cm, 1.6 * cm
    w_titulo1, h_titulo1 = w, 0.8 * cm
    w_detalle, h_detalle = w - w_numero, 0.8 * cm
    
    # :PlotObject
    fig, ax = plt.subplots(figsize=(w, h))

    # :Limites de dibujo
    ax.set_xlim(0, w)
    ax.set_ylim(0, h)

    # :Bordes
    ax.vlines([0, w], ymin=0, ymax=h, color=border_color, linewidth=1)                             # Bordes verticales
    ax.hlines([0, h], xmin=0, xmax=w, color=border_color, linewidth=1)                             # Bordes horizontales
    ax.vlines([w - w_numero], ymin=0, ymax=h_numero, color=border_color, linewidth=0.5)            # Borde vertical de la seccion "numero de mapa"
    ax.hlines([h_numero, h_numero + h_titulo1], xmin=0, xmax=w, color=border_color, linewidth=0.5) # Bordes horizontales de la seccion "titulo 1"
    ax.hlines([h_detalle], xmin=0, xmax=w_detalle, color=border_color, linewidth=0.5)              # Borde horizontal de la seccion "detalle"

    # :Texto
    titulo1 = mpg.set_detalle(titulo1, 35, first_line=True)
    plt.annotate(titulo1, (3.5*cm, 2.0*cm), ha='center', va='center', fontname=font_TimesNewRoman, weight='bold', fontsize=fontsize_titulo1)
    titulo2 = mpg.set_detalle(titulo2, 20, first_line=True)
    plt.annotate(titulo2, (2.75*cm, 1.2*cm), ha='center', va='center', fontname=font_TimesNewRoman, weight='bold', fontsize=fontsize_titulo2)
    plt.annotate(nombre_dgar, (3.5*cm, 2.55*cm), ha='center', va='center', fontname=font_TimesNewRoman, weight='bold', fontsize=fontsize_nombre_dgar)
    plt.annotate(nombre_ingemmet, (2.3*cm, 2.77*cm), fontname=font_Arial, weight='bold', fontsize=fontsize_nombre_ingemmet)
    plt.annotate(nombre_sector, (2.3*cm, 3.3*cm), fontname=font_Arial, weight='bold', fontsize=fontsize_nombre_sector)
    
    arr_logo = mpimg.imread(st._IMG_LOGO_INGEMMET)
    imagebox = OffsetImage(arr_logo, zoom=0.15)

    ab = AnnotationBbox(imagebox, (3.5*cm, 3*cm), frameon=False)

    ax.add_artist(ab)


    plt.annotate(numero, (6.25*cm, 0.35*cm), ha='center', fontname=font_Arial, weight='regular', fontsize=fontisize_numero)
    plt.annotate(u'FIGURA', (6.25*cm, 1.25*cm), ha='center', fontname=font_TimesNewRoman, weight='bold', fontsize=fontisize_figura)

    escala = mxd.activeDataFrame.scale
    wkid = str(mxd.activeDataFrame.spatialReference.factoryCode)
    wkid = '32718'
    if wkid == '4326':
        datum = 'WGS 84 GCS'
    elif wkid == '4248':
        datum = 'PSAD 56 GCS'
    elif '327' in str(wkid):
        datum = 'WGS 84 Zona {}Sur'.format(wkid[3:])
    elif '248' in str(wkid):
        datum = 'PSAD 56 Zona 1{}Sur'.format(wkid[-1])
    
    year = datetime.today().year

    detalle = u'Escala:  1/ {} Datum: {}\nVersión digital : Año {}  Lima – Perú'.format(escala, datum, year)

    plt.annotate(detalle, (2.75*cm, 0.4*cm), ha='center', va='center', fontname=font_TimesNewRoman, weight='regular', fontsize=6.4)

else:
    pass


plt.subplots_adjust(top=1, bottom=0, right=1, left=0, hspace=0, wspace=0)
plt.margins(0,0)
plt.gca().xaxis.set_major_locator(plt.NullLocator())
plt.gca().yaxis.set_major_locator(plt.NullLocator())
plt.axis('off')
extent = ax.get_window_extent().transformed(fig.dpi_scale_trans.inverted())
rotulo_path = os.path.join(st._TEMP_FOLDER, 'rotulo_{}.png'.format(uuid.uuid4().hex))
plt.savefig(rotulo_path, dpi=600, bbox_inches='tight', pad_inches=0)
print rotulo_path



# response = dict()
# response['status'] = 1
# response['message'] = 'success'


# try:
#     feature = st._PL_01_CUENCAS_HIDROGRAFICAS_PATH
#     if not arcpy.Exists(feature):
#         raise RuntimeError(msg._ERROR_FEATURE_CUENCAS_HG)
#     cursor = arcpy.da.SearchCursor(feature, [st._CD_CUENCA, st._NM_CUENCA])
#     response["response"] = list(map(lambda i: [i[0], i[1] + " - " +  str(i[0])], cursor))
# except Exception as e:
#     response['status'] = 0
#     response['message'] = e.message
# finally:
#     response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
#     arcpy.SetParameterAsText(0, response)
