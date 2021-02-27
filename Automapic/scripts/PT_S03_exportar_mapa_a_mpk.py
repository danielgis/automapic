import arcpy
import settings as st
import os
import messages as msg

mxd_path = arcpy.GetParameterAsText(0)

state, message, response = 0, str(), str()

try:
    mxd_path_dirname = os.path.dirname(mxd_path)
    mxd_name = os.path.basename(mxd_path)
    mxd_name_copy = '{}_copy.mxd'.format(mxd_name.split('.')[0])
    mpk_name = '{}.mpk'.format(mxd_name.split('.')[0])
    zip_name = '{}.zip'.format(mxd_name.split('.')[0])

    if not arcpy.Exists(mxd_path):
        raise RuntimeError(msg._ERROR_MXD_PATH_NOT_EXISTS)

    mxd = arcpy.mapping.MapDocument(mxd_path)
    if not mxd.description:
        mxd.description = mxd_name

    mxd_copy = os.path.join(mxd_path_dirname, mxd_name_copy)

    mxd.saveACopy(mxd_copy)
    del mxd

    mpk_path = os.path.join(mxd_path_dirname, mpk_name)
    _CONVERT = 'CONVERT'
    _CONVER_ARCSDE = 'CONVERT_ARCSDE'

    params = list()
    params.append(mxd_copy)
    params.append(mpk_path)
    params.append(_CONVERT)
    params.append(_CONVER_ARCSDE)

    arcpy.PackageMap_management(*params)

    os.remove(mxd_copy)

    zip_path = os.path.join(mxd_path_dirname, zip_name)
    os.rename(mpk_path, zip_path)

    state, message, response = 1, 'success', mxd_path_dirname
except Exception as e:
    mesage = e.message
finally:
    arcpy.SetParameterAsText(1, state)
    arcpy.SetParameterAsText(2, message)
    arcpy.SetParameterAsText(3, response)

