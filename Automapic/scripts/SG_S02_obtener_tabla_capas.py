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
import pythonaddins
import Tkinter, tkFileDialog

gdb_origen = arcpy.GetParameterAsText(0)
gdb_destino = arcpy.GetParameterAsText(1)
filtro = arcpy.GetParameterAsText(2)
dataset = arcpy.GetParameterAsText(3)


response = dict()
response['status'] = 1
response['message'] = 'success'


def getcapas(gdb, ds=None):
    """
    Obtiene el listado de FeatureClass y Tablas de una gdb
    params:
    gdb: gdb en la cual se buscarán los elementos a listar
    ds: si no es nulo se lista dataset/fc, de ser nulo solo se muestra el nombre de la capa
    """

    arcpy.env.workspace = gdb
    listacapas = []
    capasraiz = arcpy.ListFeatureClasses()
    listatablas = arcpy.ListTables()
    listacapas = listacapas + capasraiz + listatablas
    lds = arcpy.ListDatasets()
    if len(lds) > 0:
        for dataset in lds:
            arcpy.env.workspace = os.path.join(gdb, dataset)
            ltemp = arcpy.ListFeatureClasses()
            if ds is not None:
                ltemp = list(map(lambda x:os.path.join(dataset,x), ltemp))
            listacapas = listacapas + ltemp
    return listacapas


def get_filtrados(valor, lista, gdb):
    """
    Busca que el texto del valor ingresado se encuentre en el elemento de lista
    Si el valor existe, devuelve el elemento de la lista que lo contiene y el indicador 1
    Si el valor no existe, devuelve el nombre del valor y el indicador 0
    """
    for i in lista:
        if valor[0] in i:
            return [1, i, os.path.join(gdb,i)]
    return [0, valor[0],valor[1]]


def get_nombre_destino(valor, ds):
    """
    devuelve el nombre de la capa con o sin dataset especificado segun filtro
    """
    if ds:
        return valor
    else:
        return os.path.basename(valor)


def existe_destino(valor, gdb):
    """
    Valida si el valor existe dentro de la gdb, retorna 1 si existe, 0 si no
    """
    ruta = os.path.join(gdb, valor)
    if arcpy.Exists(ruta):
        return 1
    else:
        return 0

def getnum_ini(source):
    """
    retorna el numero de registros que contiene la capa inicial en el source especificado
    """
    num=0
    if str(source)=="0":
        pass
    else:
        num = int(arcpy.GetCount_management(source).getOutput(0))
    return num

def getnum_fin(capa, gdb_final):
    """
    retorna el numero de registro que contiene una capa perteneciente a un gdb_final
    """
    arcpy.env.workspace = gdb_final
    ds = None
    fc= None
    lista_splitcapa = os.path.split(capa)
    if len(lista_splitcapa)>1:
        ds,fc = lista_splitcapa
    else:
        fc = capa
    num=0
    if ds:
        if arcpy.Exists(ds):
            arcpy.env.workspace=ds
            capa_path = os.path.join(gdb_final, ds, fc)
            if arcpy.Exists(capa_path):
                num = int(arcpy.GetCount_management(capa_path).getOutput(0))
    else :
        arcpy.env.workspace = gdb_final
        capa_path = os.path.join(gdb_final, fc)
        if arcpy.Exists(capa_path):
            num = int(arcpy.GetCount_management(capa_path).getOutput(0))
    # return gdb_final+capa+"-"+str(num)
    return num


def getboolean(numero):
    if numero<=0:
        return 0
    else:
        return 1
def get_tabla(gdbini, gdbfin, filtro=None, ds=None):
    lista_ini = getcapas(gdbini, ds='si')
    # lista_fin = getcapas(ini, ds)
    lista_filtro = []

    if filtro == st._ORIGEN:
        pass
    elif filtro == st._MXD_ACTUAL:
        mxd = arcpy.mapping.MapDocument("current")
        listalayers = arcpy.mapping.ListLayers(mxd)
        listatablas = arcpy.mapping.ListTableViews(mxd)
        if len(listalayers) >0:
            for capa in listalayers:
                source = capa.dataSource
                if '.gdb' in source:
                    name = source.split('.gdb')[1][1:]
                elif '.sde' in source:
                    name = source.split('.sde')[1][1:]
                else:
                    name =os.path.basename(source)
                lista_filtro.append([name, source])
        if len(listatablas)>0:
            for tabla in listatablas:
                source = tabla.dataSource
                if '.gdb' in source:
                    name = source.split('.gdb')[1][1:]
                elif '.sde' in source:
                    name = source.split('.sde')[1][1:]
                else:
                    name =os.path.basename(source)
                lista_filtro.append([name,source])
        
        if len(listalayers)==0 and len(listatablas)==0:
            pythonaddins.MessageBox(_ERROR_EMPTY_MXD, _ERROR_DIALOG,0)


    else:
        if filtro.endswith('.csv'):
            dataf = pd.read_csv(filtro)
        elif filtro.endswith('.xls') or filtro.endswith('.xlsx'):
            dataf = pd.read_excel(filtro)
        firstcolumn = dataf.iloc[:, 0]
        listafiltro = firstcolumn.tolist()
        lista_filtro = [[x,0] for x in listafiltro]

    if len(lista_filtro) == 0:
        # Agregamos nuevo elemnto para source
        lista_ini_ = [[1,x, os.path.join(gdbini,x)] for x in lista_ini] 
    else:
        lista_ini_ = list(
            map(lambda x: get_filtrados(x, lista_ini, gdbini), lista_filtro))

    dff = pd.DataFrame(lista_ini_)
    dff.columns = ["existe_origen", "origen","source"]    
    dff["existe_destino"] = dff.apply(
        lambda x: existe_destino(x["origen"], gdbfin), axis=1)
    dff["nombre_destino"] = dff.apply(
        lambda x: get_nombre_destino(x["origen"], ds), axis=1)
    dff["num_origen"] = dff.apply(
        lambda x: getnum_ini(x["source"]), axis=1)
    dff["num_destino"] = dff.apply(
        lambda x: getnum_fin(x["nombre_destino"], gdbfin), axis=1)
    
    dff["enviar"] = dff["existe_origen"] +dff["num_origen"] -dff["existe_destino"] - dff["num_destino"]
    dff["enviar"] = dff.apply(lambda x :getboolean(x["enviar"]), axis=1)

    resultado =dff.to_dict('records')
    # pathcsv = "D:\JYUPANQUI\csvpruebita_num.csv"
    # dff.to_csv(pathcsv)

    return resultado

try:
    if dataset.lower() == 'no':
        dataset= None
    dataframeAsJson = get_tabla(gdb_origen, gdb_destino, filtro, dataset)
    response['response'] = dataframeAsJson
    
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response)
    arcpy.SetParameterAsText(4, response)
