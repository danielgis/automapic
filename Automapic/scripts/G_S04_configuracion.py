import arcpy
import packages as pkg
import settings as st
import messages as msg

usuario = arcpy.GetParameterAsText(0)
temp_folder = arcpy.GetParameterAsText(1)
gdb_pt25000 = arcpy.GetParameterAsText(2)

arcpy.AddMessage(msg.SET_CONFIG_TEMP_FOLDER)
pkg.set_config_param(1, temp_folder, iscommit=True)

if gdb_pt25000:
    arcpy.AddMessage(msg.SET_CONFIG_GDB_PT)
    pkg.set_config_param(2, gdb_pt25000, iscommit=True)

    arcpy.AddMessage(msg.SET_CONFIG_MXD_PT_17)
    mxd17 = arcpy.mapping.MapDocument(st._MXD_17)
    mxd17.findAndReplaceWorkspacePaths("", gdb_pt25000)
    mxd17.save()
    del mxd17

    arcpy.AddMessage(msg.SET_CONFIG_MXD_PT_18)
    mxd18 = arcpy.mapping.MapDocument(st._MXD_18)
    mxd18.findAndReplaceWorkspacePaths("", gdb_pt25000)
    mxd18.save()
    del mxd18

    arcpy.AddMessage(msg.SET_CONFIG_MXD_PT_19)
    mxd19 = arcpy.mapping.MapDocument(st._MXD_19)
    mxd19.findAndReplaceWorkspacePaths("", gdb_pt25000)
    mxd19.save()
    del mxd19

arcpy.AddMessage(msg.PROCESS_FINISHED)