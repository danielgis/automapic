import arcpy
import packages as pkg

usuario = arcpy.GetParameterAsText(0)
temp_folder = arcpy.GetParameterAsText(1)
gdb_pt25000 = arcpy.GetParameterAsText(2)

pkg.set_config_param(1, temp_folder, iscommit=True)

if gdb_pt25000:
    pkg.set_config_param(2, gdb_pt25000, iscommit=True)

