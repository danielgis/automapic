from comtypes.client import GetModule, CreateObject
from snippets import GetStandaloneModules, InitStandalone
import arcpy

GetStandaloneModules()
InitStandalone()

install_dir = arcpy.GetInstallInfo()['InstallDir']


def set_scale_properties(mxd_path, name_scale, **kwargs):
    global install_dir
    esriCarto = GetModule(r'{}\com\esriCarto.olb'.format(install_dir))

    mxdObject.Open(mxd_path)

    IMap = mxdObject.ActiveView.FocusMap

    for i in xrange(0, IMap.MapSurroundCount):
        element = IMap.MapSurround(i)
        if element.name == name_scale:    
            IScaleBar = element.QueryInterface(esriCarto.IScaleBar)
            for k, v in kwargs.items():
                IScaleBar.__dict__[k] = v
                # IScaleBar.__dict__['UnitLabel'] = kwargs['UnitLabel']
                # IScaleBar.__dict__['Division'] = kwargs['Division']
                # IScaleBar.__dict__['Units'] = kwargs['Units']
            break
    mxdObject.Save()
    del mxdObject


# from comtypes.client import GetModule, CreateObject
# from snippets import GetStandaloneModules, InitStandalone
# import arcpy

# GetStandaloneModules()
# InitStandalone()


# mxd_path = arcpy.GetParameterAsText(0)

# install_dir = arcpy.GetInstallInfo()['InstallDir']

# # Get the Carto module
# esriCarto = GetModule(r'{}\com\esriCarto.olb'.format(install_dir))

# mxdObject = CreateObject(esriCarto.MapDocument, interface=esriCarto.IMapDocument)

# mxdObject.Open(mxd_path)

# IMap = mxdObject.ActiveView.FocusMap

# for i in xrange(0, IMap.MapSurroundCount):
#     element = IMap.MapSurround(i)
#     if element.name == 'ESCALA':
#         IScaleBar = element.QueryInterface(esriCarto.IScaleBar)
#         IScaleBar.UnitLabel = 'Kilometers'
#         IScaleBar.Division = 1
#         IScaleBar.Units = 10
#         mxdObject.Save()