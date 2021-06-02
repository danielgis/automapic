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
                ltemp = list(map(lambda x: dataset+'/'+x, ltemp))
            listacapas = listacapas + ltemp
    return listacapas


def get_filtrados(valor, lista):
    """
    Busca que el texto del valor ingresado se encuentre en el elemento de lista
    Si el valor existe, devuelve el elemento de la lista que lo contiene y el indicador 1
    Si el valor no existe, devuelve el nombre del valor y el indicador 0
    """
    for i in lista:
        if valor in i:
            return [1, i]
    return [0, valor]


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


def getnum(capa, gdb):
    """
    retorna el numero de registro ques contiene una capa perteneciente a un gdb
    """
    arcpy.env.workspace = gdb
    ds = None
    fc= None
    if '/' in capa:
        ds,fc = capa.split('/')
    else:
        fc = capa
    num=0
    if ds:
        if arcpy.Exists(ds):
            arcpy.env.workspace=ds
            if arcpy.Exists(fc):
                num = int(arcpy.GetCount_management(fc).getOutput(0))
    return num


def get_tabla(gdbini, gdbfin, filtro=None, ds=None):
    lista_ini = getcapas(gdbini, ds='si')
    # lista_fin = getcapas(ini, ds)
    lista_filtro = []

    if not filtro:
        pass

    elif filtro == _MXD_ACTUAL:
        mxd = arcpy.mapping.MapDocument("current")
        listafiltro = arcpy.mapping.ListLayers(mxd)
        if len(listafiltro) >0:
            for capa in listafiltro:
                source = capa.dataSource
                name = source.split('.gdb\\')[1]
                lista_filtro.append(name)
        else:
            pythonaddins.MessageBox(_ERROR_EMPTY_MXD, _ERROR_DIALOG,0)


    elif filtro == _EXTFILE:
        # filtrofile = pythonaddins.OpenDialog(_OPEN_DIALOG_TITLE, False,_DESKTOP_PATH, _OPEN_DIALOG_BUTTON_TITLE)
        root = Tkinter.Tk()
        root.withdraw()
        filtrofile = tkFileDialog.askopenfilename(initialdir = "/",title = _OPEN_DIALOG_TITLE ,filetypes = (("Archivos CSV","*.csv"),("Archivos EXCEL","*.xls*"),("Todos los archivos","*.*")))
        if filtrofile.endswith('.csv'):
            dataf = pd.read_csv(filtrofile)
        elif filtrofile.endswith('.xls') or filtrofile.endswith('.xlsx'):
            dataf = pd.read_excel(filtrofile)
        firstcolumn = dataf.iloc[:, 0]
        listafiltro = firstcolumn.tolist()
        lista_filtro = listafiltro

    if len(lista_filtro) == 0:
        lista_ini_ = [[1,x] for x in lista_ini] 
    else:
        lista_ini_ = list(
            map(lambda x: get_filtrados(x, lista_ini), lista_filtro))

    dff = pd.DataFrame(lista_ini_)
    dff.columns = ["existe_origen", "origen"]    
    dff["existe_destino"] = dff.apply(
        lambda x: existe_destino(x["origen"], gdbfin), axis=1)
    dff["nombre_destino"] = dff.apply(
        lambda x: get_nombre_destino(x["origen"], ds), axis=1)
    dff["num_origen"] = dff.apply(
        lambda x: getnum(x["origen"], gdbini), axis=1)
    dff["num_destino"] = dff.apply(
        lambda x: getnum(x["nombre_destino"], gdbfin), axis=1)
    
    dff["enviar"] = dff["existe_origen"]

    resultado =dff.to_dict('records')

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
