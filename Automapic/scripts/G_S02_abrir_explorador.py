import pythonaddins
import os
import messages as msg
import arcpy


# class MyValidator(object):
#     def __init__(self, tag, extension):
#         self.tag = tag
#         self.extension = extension

#     def __str__(self):
#         return self.tag

#     def __call__(self, filename):
#         if self.extension:
#             if os.path.isfile(filename) and filename.lower().endswith(self.extension):
#                 return True
#         else:
#             if os.path.isdir(filename):
#                 return True
#         return False

pythonaddins.OpenDialog()
# if __name__ == '__main__':
#     state, response = None, None
#     try:
#         texto = arcpy.GetParameterAsText(0)
#         extension = arcpy.GetParameterAsText(1)
#         seleccion_multiple = arcpy.GetParameter(2)

#         # pythonaddins.OpenDialog('asdasd', True, '#', 'Seleccionar', "#", '*.shp')
#         response = pythonaddins.OpenDialog(
#             msg._OPEN_DIALOG_TITLE,
#             seleccion_multiple,
#             "#",
#             msg._OPEN_DIALOG_BUTTON_TITLE,
#             "#",
#             '*.{}'.format(extension))
#             #filter=MyValidator(texto, extension))
#         if response:
#             state = 1
#         else:
#             raise RuntimeError('Se cancelo el proceso')
#     except Exception as e:
#         state = 0
#         response = e.message.__str__()
#     finally:
#         arcpy.SetParameterAsText(3, state)
#         arcpy.SetParameterAsText(4, response)
