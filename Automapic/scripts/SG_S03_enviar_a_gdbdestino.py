#!/usr/bin/env python
# -*- coding: utf-8 -*-
import sys
import arcpy
import os
import settings as st
import messages as msg
import traceback
import json
import pandas as pd

arcpy.env.overwriteOutput= True

gdb_origen = arcpy.GetParameterAsText(0)
gdb_destino = arcpy.GetParameterAsText(1)
rutaarchivo = arcpy.GetParameterAsText(2)

response = dict()
response['status'] = 1
response['message'] = 'success'

def enviardatos(gdbini, gdbfin, rutacsv):
    df = pd.read_csv(rutacsv)
    contador = 0
    for index, row in df.iterrows():
        if row["enviar"]== True:
            fc_inicial = os.path.join(gdb_origen, row["origen"])
            fc_destino = os.path.join(gdb_destino, row["nombre_destino"])
            arcpy.CopyFeatures_management(fc_inicial,fc_destino)
            contador +=1
    return contador


try:
    num_capas_actualizadas = enviardatos(gdb_origen, gdb_destino, rutaarchivo)
    response['response'] = num_capas_actualizadas
    
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response)
    arcpy.SetParameterAsText(3, response)