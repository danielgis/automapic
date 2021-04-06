from comtypes.client import GetModule, CreateObject
from snippets import GetStandaloneModules, InitStandalone
import arcpy
from bisect import bisect


GetStandaloneModules()
InitStandalone()

install_dir = arcpy.GetInstallInfo()['InstallDir']



def set_scale_properties(mxd_path, name_scale, **kwargs):
    global install_dir
    esriCarto = GetModule(r'{}\com\esriCarto.olb'.format(install_dir))
    mxdObject = CreateObject(esriCarto.MapDocument, interface=esriCarto.IMapDocument)
    mxdObject.Open(mxd_path)

    IMap = mxdObject.ActiveView.FocusMap

    for i in xrange(0, IMap.MapSurroundCount):
        element = IMap.MapSurround(i)
        if element.name == name_scale:
            IScaleBar = element.QueryInterface(esriCarto.IScaleBar)
            if kwargs.get('UnitLabel'):
                IScaleBar.UnitLabel = kwargs['UnitLabel']
            if kwargs.get('Division'):
                IScaleBar.Division = kwargs['Division']
            if kwargs.get('Units'):
                IScaleBar.Units = kwargs['Units']
            break
    mxdObject.Save()
    del mxdObject


def select_grid(mxd_path, scale):
    global install_dir

    esriCarto = GetModule(r'{}\com\esriCarto.olb'.format(install_dir))
    mxdObject = CreateObject(esriCarto.MapDocument, interface=esriCarto.IMapDocument)
    mxdObject.Open(mxd_path)

    IMap = mxdObject.ActiveView.FocusMap

    activeView = mxdObject.ActiveView
    pageLayout = activeView.QueryInterface(esriCarto.IPageLayout)
    graphicsContainer = pageLayout.QueryInterface(esriCarto.IGraphicsContainer)

    frameElement = graphicsContainer.FindFrame(IMap)
    mapFrame = frameElement.QueryInterface(esriCarto.IMapFrame)

    mapGrids = mapFrame.QueryInterface(esriCarto.IMapGrids)
    grids = [mapGrids.MapGrid(i) for i in xrange(mapGrids.MapGridCount)]
    # arcpy.AddMessage([i.Name for i in grids])
    grids_names = [int(i.Name) for i in grids]
    grids_names.sort()
    idx = bisect(grids_names, scale) - 1

    selected_grid = str(grids_names[idx])
    
    for g in grids:
        if g.Name == selected_grid:
            g.Visible = True
        else:
            g.Visible = False
    mxdObject.Save()
    del mxdObject


# params = {'Units': 9, 'UnitLabel': 'Meters', 'Division': 850}
# set_text_element_popup_properties(r'C:\assets\temp\26f1279bf0db4a71831727ee2b7ec0d8\LoremIpsum.mxd', 'FIGURAPOPUP', **params)
# select_grid(r'C:\assets\temp\9b0cc985d36747188929cd2c332f371b\LoremIpsum.mxd', 250000)