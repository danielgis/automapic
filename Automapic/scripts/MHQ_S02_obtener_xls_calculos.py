#!/usr/bin/env python
# -*- coding: utf-8 -*-
# Importar librerias
import arcpy
import os
import json
import pandas as pd
# import openpyxl
import settings_aut as st
import MHQ_S01_ingresar_datos as mhq_id
response = dict()
response['status'] = 1
response['message'] = 'success'

xls_in = arcpy.GetParameterAsText(0)
xls_out = arcpy.GetParameterAsText(1)
csv_out = xls_out.split('.')[0]+'.csv'



try:
    mhq_id.preparar_datos_csv(xls_in, csv_out)
    response["response"]= xls_out
    arcpy.AddMessage("Hello World!")
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(2, response)
