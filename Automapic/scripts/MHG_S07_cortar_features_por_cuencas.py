# Importar librerias
import arcpy
import json
import settings_aut as st
import packages_aut as pkg
import automapic as aut
import pythonaddins
import os

arcpy.env.overwriteOutput = True

response = dict()
response['status'] = 1
response['message'] = 'success'

features = arcpy.GetParameterAsText(0)
cuencas = arcpy.GetParameterAsText(1)
dataframe = arcpy.GetParameterAsText(2)


def split_data_by_polygon(row, geom):
    if row['query'] in ('1', '9'):
        return
    response = os.path.join(arcpy.env.scratchGDB, row['layer_name'])
    feature = os.path.join(row['datasource'], row['feature'])
    name_feature= os.path.basename(feature).split('.')[1]
    # arcpy.AddMessage(feature)
    # arcpy.AddMessage(response)
    # arcpy.AddMessage("*"*20)
    try:
        arcpy.Clip_analysis(feature, geom, response)
        aut.add_layer_with_new_datasource(row['layer_name'], name_feature, arcpy.env.scratchGDB, "FILEGDB_WORKSPACE", df_name=dataframe)
    except Exception as e:
        pythonaddins.MessageBox("Ocurrio un error con el feature {}\n{}".format(row['feature'], e.message), st.__title__)
        return

# try:
# Obteniendo area geografica de las cuencas
cuencas = cuencas.replace("'", '').replace(' ', '')
cuencas = "('{}')".format("', '".join(cuencas.split(',')))
query_cuencas = "{} IN {}".format(st._CD_CUENCA, cuencas)
cuencas_mfl = arcpy.MakeFeatureLayer_management(st._PL_01_CUENCAS_HIDROGRAFICAS_PATH, "cuencas_mfl", query_cuencas)
cuencas_diss = arcpy.Dissolve_management(cuencas_mfl, 'in_memory\\cuencas_diss')

# Se obtiene todas las capas seleccionadas
query_features = "{} IN ({})".format(st._ID, ','.join(features.split(",")))
df = pkg.get_layers_selected(query_features, as_dataframe=True)
for i, r in df.iterrows():
    split_data_by_polygon(r, cuencas_diss)
# Insertar procesos
# except Exception as e:
# response['status'] = 0
# response['message'] = e.message
# finally:
response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
arcpy.SetParameterAsText(1, response)
