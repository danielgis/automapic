import arcpy
import packages as pkg
import settings as st
import messages as msg

usuario = arcpy.GetParameterAsText(0)
temp_folder = arcpy.GetParameterAsText(1)
gdb_pt25000 = arcpy.GetParameterAsText(2)
bdgeocat_conn = arcpy.GetParameterAsText(3)
gdb_mhidrogeo = arcpy.GetParameterAsText(4)

arcpy.AddMessage(msg._SET_CONFIG_TEMP_FOLDER)
pkg.set_config_param(1, temp_folder, iscommit=True)

SDE_WORKSPACE = 'SDE_WORKSPACE'

if gdb_pt25000:
    arcpy.AddMessage(msg._SET_CONFIG_GDB_PT)
    pkg.set_config_param(2, gdb_pt25000, iscommit=True)

    arcpy.AddMessage(msg._SET_CONFIG_MXD_PT_17)
    mxd17 = arcpy.mapping.MapDocument(st._MXD_17)
    mxd17.findAndReplaceWorkspacePaths("", gdb_pt25000)
    mxd17.save()
    del mxd17

    arcpy.AddMessage(msg._SET_CONFIG_MXD_PT_18)
    mxd18 = arcpy.mapping.MapDocument(st._MXD_18)
    mxd18.findAndReplaceWorkspacePaths("", gdb_pt25000)
    mxd18.save()
    del mxd18

    arcpy.AddMessage(msg._SET_CONFIG_MXD_PT_19)
    mxd19 = arcpy.mapping.MapDocument(st._MXD_19)
    mxd19.findAndReplaceWorkspacePaths("", gdb_pt25000)
    mxd19.save()
    del mxd19

if bdgeocat_conn:
    arcpy.AddMessage(msg._SET_CONFIG_GDB_PG)
    pkg.set_config_param(3, bdgeocat_conn, iscommit=True)

    arcpy.AddMessage(msg._SET_CONFIG_MXD_PG_17)
    mxd17_pg = arcpy.mapping.MapDocument(st._MXD_PG_17)
    mxd17_pg.replaceWorkspaces("", "", bdgeocat_conn, SDE_WORKSPACE, False)
    mxd17_pg.save()
    del mxd17_pg

    arcpy.AddMessage(msg._SET_CONFIG_MXD_PG_18)
    mxd18_pg = arcpy.mapping.MapDocument(st._MXD_PG_18)
    mxd18_pg.replaceWorkspaces("", "", bdgeocat_conn, SDE_WORKSPACE, False)
    mxd18_pg.save()
    del mxd18_pg

    arcpy.AddMessage(msg._SET_CONFIG_MXD_PG_19)
    mxd19_pg = arcpy.mapping.MapDocument(st._MXD_PG_19)
    mxd19_pg.replaceWorkspaces("", "", bdgeocat_conn, SDE_WORKSPACE, False)
    mxd19_pg.save()
    del mxd19_pg

    pkg.set_datasources_tree_layers(bdgeocat_conn, 1, 9, iscommit=True)
else:
    # Se asigna la geodatabase por defecto en la raiz de automapic
    bdgeocat_conn = st._BDGEOCAT_SDE_DEV if st.__status__ == 'Development' else st._BDGEOCAT_SDE
    pkg.set_config_param(3, bdgeocat_conn, iscommit=True)
    pkg.set_datasources_tree_layers(bdgeocat_conn, 1, 9, iscommit=True)

arcpy.AddMessage(msg._SET_GDB_MHIDROGEO)
if gdb_mhidrogeo:
    pkg.set_config_param(4, gdb_mhidrogeo, iscommit=True)
    pkg.set_datasources_tree_layers(gdb_mhidrogeo, 1, 1, iscommit=True)

arcpy.AddMessage(msg._PROCESS_FINISHED)