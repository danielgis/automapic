import arcpy
import os

def check_layer_inside_data_frame(features, symbols, df_name=None, query=None, zoom=False):
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
        
        if zoom:
            mxd.activeDataFrame.extent = lyr.getExtent()
        
        arcpy.RefreshTOC()
        arcpy.RefreshActiveView()

def add_layer_with_new_datasource(layer, name_feature, workspace, typeWorkspace, df_name=None, query=None, zoom=False, scale=None):
    # Mapa actual
    mxd = arcpy.mapping.MapDocument("CURRENT")

    # Si no se ingresa un nombre de daraframe
    if df_name:
        dfs = arcpy.mapping.ListDataFrames(mxd, "*{}*".format(df_name))
        if not len(dfs):
            raise RuntimeError("El data frame ingresado no existe")
        df = dfs[0]
    else:
        df = mxd.activeDataFrame
    
    # Obteniendo el nombre del layer
    name = os.path.basename(layer).split('.')[0]

    # Obteniendo las capas actuales en el mapa con el nombre del layer 
    layers = arcpy.mapping.ListLayers(mxd, "*{}*".format(name), df)
    arcpy.AddMessage(layers)

    # Si el layer ya existe en el mapa
    if len(layers):
        lyr = layers[0]
    else:
        # Si el layer no existe, crear un layer
        lyr = arcpy.mapping.Layer(layer)

    # Reemplaza el datasource
    # if replace:
    lyr.replaceDataSource(workspace, typeWorkspace, name_feature, False)
    
    # Si es necesario aplicar un filtro
    if query:
        lyr.definitionQuery = query
    
    # Se agrega si el layer no esta en el mapa
    if not len(layers):
        arcpy.mapping.AddLayer(df, lyr)
    
    if zoom:
        df.extent = lyr.getExtent()
    
    if scale:
        df.scale = scale

    arcpy.RefreshTOC()
    arcpy.RefreshActiveView()
    
def split_line_at_points(geometry_line, geometry_points):
    p_ini = geometry_line.firstPoint
    p_end = geometry_line.firstPoint

    parts = list()

    for i in geometry_points:
        if not i.within(geometry_line):
            continue
        if i.X ==  p_ini.X and i.Y == p_ini.Y:
            continue
        if i.X ==  p_end.X and i.Y == p_end.Y:
            continue
        m = geometry_line.measureOnLine(i)
        part_line = geometry_line.segmentAlongLine(0, m)
        parts.append(part_line)
    
    parts.append(geometry_line)
    
    parts.sort(key=lambda l: l.length)
    response = [b.symmetricDifference(a) for a, b in zip(parts, parts[1:])]
    response.insert(0, parts[0])
    return response



