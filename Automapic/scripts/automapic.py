import arcpy
import os

def check_layer_inside_data_frame(features, symbols, df_name=None, query=None):
    mxd = arcpy.mapping.MapDocument("CURRENT")
    if df_name :
        dfs = arcpy.mapping.ListDataFrames(mxd, '*{}*'.format(df_name))
        if not len(dfs):
            raise RuntimeError()
        df = dfs[0]
    else:
        df = mxd.activeDataFrame

    features = zip(features, symbols)

    for feature, symbol in features:
        name = os.path.basename(feature)
        lyrs = arcpy.mapping.ListLayers(mxd, "*{}*".format(name), df)
        if not len(lyrs):
            lyr = arcpy.mapping.Layer(feature)
        else:
            lyr = lyrs[0]
        
        if query:
            lyr.definitionQuery = query
        
        if symbol:
            arcpy.ApplySymbologyFromLayer_management(lyr, symbol)

        if not len(lyrs):
            arcpy.mapping.AddLayer(df, lyr)
        
        arcpy.RefreshTOC()
        arcpy.RefreshActiveView()