# -*-coding: utf-8-*-

# import snippets

# snippets.ArcMap_AddPictureElement()
# snippets.ArcMap_AddTextElement()


# import imgkit

# imgkit.from_url('http://google.com', r'C:\daniel\proyectos\ingemmet\OS13012021\desarrollo\Automapic\Automapic\scripts\img.jpg')
# imgkit.from_file('test.html', 'out.jpg')
# imgkit.from_string('Hello!', 'out.jpg')










# # from reportlab.graphics import renderPM
# # # from reportlab.pdfgen import canvas
# # from reportlab.graphics.shapes import Drawing, String, Rect, colors
# # from reportlab.lib.units import cm

# # # c = canvas()
# # d = Drawing(7 * cm, 3.5 * cm)
# # d.add(Rect(0*cm, 0*cm, 7*cm, 3.5*cm, fillColor=colors.white, strokeColor=colors.red))

# # # d.add(Rect(5.5*cm, 0*cm, 7*cm, 1.6*cm, fillColor=colors.white))
# # # d.add(Rect(50, 50, 7*cm, 3*cm, fillColor=colors.yellow))
# # # d.add(String(150, 100, 'Hello World', fontSize=18, fillColor=colors.red))
# # # d.add(String(180, 86, 'Special characters \
# # # \xc2\xa2\xc2\xa9\xc2\xae\xc2\xa3\xce\xb1\xce\xb2',
# #             #  fillColor=colors.red))
# # renderPM.drawToFile(d, r'C:\daniel\proyectos\ingemmet\OS13012021\desarrollo\automapic\Automapic\scripts\example1.png', 'PNG')
# # #  dpi=1024
# # # c.drawImage(company_logo,225,750,width=(483/3),height=(122/3))

# # # from PIL import Image, ImageDraw

# # # size of image
# # # canvas = (400, 300)

# # # scale ration
# # # scale = 5
# # # thumb = canvas[0]/scale, canvas[1]/scale

# # # rectangles (width, height, left position, top position)
# # # frames = [(50, 50, 5, 5), (60, 60, 100, 50), (100, 100, 205, 120)]

# # # init canvas
# # # im = Image.new('RGBA', canvas, (255, 255, 255, 255))
# # # draw = ImageDraw.Draw(im)

# # # draw rectangles
# # # for frame in frames:
# # #     x1, y1 = frame[2], frame[3]
# # #     x2, y2 = frame[2] + frame[0], frame[3] + frame[1]

# # # draw.rectangle([0, 0, 7, 3.5], outline=(0, 0, 0, 255))

# # # make thumbnail
# # # im.thumbnail(thumb)

# # # save image
# # # im.save(r'C:\daniel\proyectos\ingemmet\OS13012021\desarrollo\automapic\Automapic\scripts\example1.png')

# # Text Variables
# Header = '>>>This resume was generated entirely in Python. For full sourcecode, view my portfolio.'
# Name = 'EDDIE KIRKLAND'
# Title = 'Data Science & Analytics'
# Contact = 'Atlanta, GA\n404-XXX-XXXX\nwekrklndATgmailDOTcom\nlinkedin.com/in/ekirkland\ngithub.com/e-kirkland'
# ProjectsHeader = 'PROJECTS/PUBLICATIONS'
# ProjectOneTitle = 'Increasing Kaggle Revenue'
# ProjectOneDesc = '- Published by Towards Data Science\n- Analyzed user survey to recommend most profitable future revenue source\n- Cleaned/visualized data using pandas/matplotlib libraries in Python'
# ProjectTwoTitle = 'NYC School Data Cleaning & Analysis'
# ProjectTwoDesc = '- Cleaned and combined several tables using pandas library in Python\n- Used PDE and visualization to determine correlations for future study'
# ProjectThreeTitle = 'Pandas Cleaning and Visualization'
# ProjectThreeDesc = '- Cleaned data for analysis using pandas library in Python\n- Used pandas and matplotlib to explore which cars hold the most value over time'
# Portfolio = 'Portfolio: rebrand.ly/ekirkland'
# WorkHeader = 'EXPERIENCE'
# WorkOneTitle = 'Example Company / Example Position'
# WorkOneTime = '8/2013-Present'
# WorkOneDesc = '- Raised $350k in startup funds, recruited/organized launch team\n- Coordinated branding and communication strategy\n- Led team of 80 volunteer and staff leaders'
# WorkTwoTitle = 'Second Company / Second Position'
# WorkTwoTime = '2/2007-8/2013'
# WorkTwoDesc = '- Led team of over 100 full-time and contract staff\n- Helped create branding and messaging for weekly content\n- Created/directed musical elements at weekly events for up to 10,000 people'
# WorkThreeTitle = 'Third Company / Third Position'
# WorkThreeTime = '6/2004-2/2007'
# WorkThreeDesc = '- Planned/Coordianted Toronto arena event and South Africa speaking tour\n- Oversaw research for published products'
# EduHeader = 'EDUCATION'
# EduOneTitle = 'Example University, Bachelor of Business Administration'
# EduOneTime = '2000-2004'
# EduOneDesc = '- Major: Management, Minor: Statistics'
# EduTwoTitle = 'Example University, Master of Arts'
# EduTwoTime = '2013-2017'
# SkillsHeader = 'Skills'
# SkillsDesc = '- Python\n- Pandas\n- NumPy\n- Data Visualization\n- Data Cleaning\n- Command Line\n- Git and Version Control\n- SQL\n- APIs\n- Probability/Statistics\n- Data Manipulation\n- Excel'
# ExtrasTitle = 'DataQuest\nData Scientist Path'
# ExtrasDesc = 'Learned popular data science\nlanguages, data cleaning and\nmanipulation, machine learning \nand statistical analysis'
# CodeTitle = 'View Portfolio'
# # Setting style for bar graphs
import matplotlib.pyplot as plt
import matplotlib.image as mpimg
from matplotlib.offsetbox import TextArea, DrawingArea, OffsetImage, AnnotationBbox
# # %matplotlib inline
# # set font
# plt.rcParams['font.family'] = 'sans-serif'
# plt.rcParams['font.sans-serif'] = 'STIXGeneral'
cm = 1/2.54
# cm = 1
fig, ax = plt.subplots(figsize=(7 * cm, 3.5 * cm))
# # Decorative Lines
ax.set_xlim(0, 7*cm)
ax.set_ylim(0, 3.5*cm)
# ax.axvline(x=.01, ymin=0, ymax=1, color='#000000', linewidth=2)
# ax.axhline(y=.01, xmin=0, xmax=1, color='#000000', linewidth=2)

csfont = {'fontname':'Times New Roman'}

# margen
ax.vlines([0, 7*cm], ymin=0, ymax=3.5*cm, color='#000000', linewidth=1)
ax.hlines([0, 3.5*cm], xmin=0, xmax=7*cm, color='#000000', linewidth=1)

# box number
ax.vlines([5.5*cm], ymin=0, ymax=1.6*cm, color='#000000', linewidth=0.5)

# title 1
ax.hlines([1.6*cm, 2.4*cm], xmin=0, xmax=7*cm, color='#000000', linewidth=0.5)

# 0.8 7
ax.hlines([0.8*cm], xmin=0, xmax=5.5*cm, color='#000000', linewidth=0.5)


plt.annotate('MAPA HIDROQUIMICO\nSECTOR DE YURA', (2.75*cm, 1.2*cm), ha='center', va='center', fontname='Times New Roman', weight='bold', fontsize=7)
plt.annotate(u'HIDROGEOLOGÍA DE LA CUENCA DEL RÍO\nQUILCA-VITOR-CHILI (132)', (3.5*cm, 2.0*cm), ha='center', va='center', fontname='Times New Roman', weight='bold', fontsize=6)
plt.annotate(u'Dirección de Geología Ambiental y Riesgo Geológico', (3.5*cm, 2.55*cm), ha='center', va='center', fontname='Times New Roman', weight='bold', fontsize=6)

# plt.annotate(u'INGEMMET', (3.5*cm, 3.1*cm), ha='center', va='center', fontname='Arial Black', weight='bold', fontsize=14, color='#006aa8')

arr_lena = mpimg.imread(r'C:\daniel\proyectos\ingemmet\OSXXXX2021\hidrogeologia\desarrollo\logo_ingemmet.png')
imagebox = OffsetImage(arr_lena, zoom=0.15)

ab = AnnotationBbox(imagebox, (3.5*cm, 3*cm), frameon=False)

ax.add_artist(ab)
plt.annotate(u'INSTITUTO GEOLÓGICO MINERO Y METALÚRGICO', (2.3*cm, 2.77*cm), fontname='Arial', weight='bold', fontsize=3)
plt.annotate(u'SECTOR ENERGÍA Y MINAS', (2.3*cm, 3.3*cm), fontname='Arial', weight='bold', fontsize=3)

plt.annotate(u'9.5', (6.25*cm, 0.35*cm), ha='center', fontname='Arial', weight='regular', fontsize=24)
plt.annotate(u'FIGURA', (6.25*cm, 1.25*cm), ha='center', fontname='Times New Roman', weight='bold', fontsize=6.2)

plt.annotate(u'Escala:  1/ 500 000 Datum: WGS 84 Zona 19Sur\nVersión digital : Año 2021  Lima – Perú', (2.75*cm, 0.4*cm), ha='center', va='center', fontname='Times New Roman', weight='regular', fontsize=6.4)


# ax.axhline(y=.99, xmin=0, xmax=1, color='#000000', linewidth=2)

# # ax.axvline(x=.5, ymin=0, ymax=1, color='#007ACC', alpha=0.0, linewidth=50)
# # plt.axvline(x=.99, color='#000000', alpha=0.5, linewidth=300)
# # plt.axhline(y=.88, xmin=0, xmax=1, color='#ffffff', linewidth=3)
# # set background color
# ax.set_facecolor('white')
# # remove axes
# # plt.axis('off')
# # add text
# # plt.annotate(Header, (.02,.98), weight='regular', fontsize=8, alpha=.75)
# # plt.annotate(Name, (.02,.94), weight='bold', fontsize=20)
# # plt.annotate(Title, (.02,.91), weight='regular', fontsize=14)
# # plt.annotate(Contact, (.7,.906), weight='regular', fontsize=8, color='#ffffff')
# # plt.annotate(ProjectsHeader, (.02,.86), weight='bold', fontsize=10, color='#58C1B2')
# # plt.annotate(ProjectOneTitle, (.02,.832), weight='bold', fontsize=10)
# # plt.annotate(ProjectOneDesc, (.04,.78), weight='regular', fontsize=9)
# # plt.annotate(ProjectTwoTitle, (.02,.745), weight='bold', fontsize=10)
# # plt.annotate(ProjectTwoDesc, (.04,.71), weight='regular', fontsize=9)
# # plt.annotate(ProjectThreeTitle, (.02,.672), weight='bold', fontsize=10)
# # plt.annotate(ProjectThreeDesc, (.04,.638), weight='regular', fontsize=9)
# # plt.annotate(Portfolio, (.02,.6), weight='bold', fontsize=10)
# # plt.annotate(WorkHeader, (.02,.54), weight='bold', fontsize=10, color='#58C1B2')
# # plt.annotate(WorkOneTitle, (.02,.508), weight='bold', fontsize=10)
# # plt.annotate(WorkOneTime, (.02,.493), weight='regular', fontsize=9, alpha=.6)
# # plt.annotate(WorkOneDesc, (.04,.445), weight='regular', fontsize=9)
# # plt.annotate(WorkTwoTitle, (.02,.4), weight='bold', fontsize=10)
# # plt.annotate(WorkTwoTime, (.02,.385), weight='regular', fontsize=9, alpha=.6)
# # plt.annotate(WorkTwoDesc, (.04,.337), weight='regular', fontsize=9)
# # plt.annotate(WorkThreeTitle, (.02,.295), weight='bold', fontsize=10)
# # plt.annotate(WorkThreeTime, (.02,.28), weight='regular', fontsize=9, alpha=.6)
# # plt.annotate(WorkThreeDesc, (.04,.247), weight='regular', fontsize=9)
# # plt.annotate(EduHeader, (.02,.185), weight='bold', fontsize=10, color='#58C1B2')
# # plt.annotate(EduOneTitle, (.02,.155), weight='bold', fontsize=10)
# # plt.annotate(EduOneTime, (.02,.14), weight='regular', fontsize=9, alpha=.6)
# # plt.annotate(EduOneDesc, (.04,.125), weight='regular', fontsize=9)
# # plt.annotate(EduTwoTitle, (.02,.08), weight='bold', fontsize=10)
# # plt.annotate(EduTwoTime, (.02,.065), weight='regular', fontsize=9, alpha=.6)
# # plt.annotate(SkillsHeader, (.7,.8), weight='bold', fontsize=10, color='#ffffff')
# # plt.annotate(SkillsDesc, (.7,.56), weight='regular', fontsize=10, color='#ffffff')
# # plt.annotate(ExtrasTitle, (.7,.43), weight='bold', fontsize=10, color='#ffffff')
# # plt.annotate(ExtrasDesc, (.7,.345), weight='regular', fontsize=10, color='#ffffff')
# # plt.annotate(CodeTitle, (.7,.2), weight='bold', fontsize=10, color='#ffffff')
# #add qr code
# # from matplotlib.offsetbox import TextArea, DrawingArea, OffsetImage, AnnotationBbox
# # import matplotlib.image as mpimg
# # arr_code = mpimg.imread('C:\daniel\proyectos\ingemmet\OS13012021\desarrollo\automapic\Automapic\scripts\ekresumecode.png')
# # imagebox = OffsetImage(arr_code, zoom=0.5)
# # ab = AnnotationBbox(imagebox, (0.84, 0.12))
# # ax.add_artist(ab)
# plt.gca().set_axis_off()
plt.subplots_adjust(top=1, bottom=0, right=1, left=0, hspace=0, wspace=0)
# fig.subplots_adjust(left   = left_margin / box_width,
                    # bottom = bottom_margin / box_height,
                    # right  = 1. - right_margin / box_width,
                    # top    = 1. - top_margin   / box_height,
                    # )
plt.margins(0,0)
plt.gca().xaxis.set_major_locator(plt.NullLocator())
plt.gca().yaxis.set_major_locator(plt.NullLocator())
# # plt.savefig("filename.pdf", bbox_inches = 'tight',
# #     pad_inches = 0)
plt.axis('off')
extent = ax.get_window_extent().transformed(fig.dpi_scale_trans.inverted())
plt.savefig(r'C:\daniel\proyectos\ingemmet\OS13012021\desarrollo\automapic\Automapic\scripts\resumeexample.png', dpi=600, bbox_inches='tight', pad_inches=0)
# , width=3,pad_inches = 0)

import matplotlib.font_manager
# print matplotlib.font_manager.findSystemFonts(fontpaths=None, fontext='ttf')
