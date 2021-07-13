#!/usr/bin/env python
# -*- coding: utf-8 -*-
# Importar librerias
import arcpy
import os
import json
import pandas as pd
import difflib as diff
import traceback
import settings_aut as st

response = dict()
response['status'] = 1
response['message'] = 'success'

gdb_base = arcpy.GetParameterAsText(0)
xls_file = arcpy.GetParameterAsText(1)
arcpy.env.workspace = gdb_base

## Definimos las variables estaticas
_scratch = arcpy.env.scratchFolder
_nombre_tabla = r'BASE_EXCEL_LAB_TABLA'
_nombre_tabla_corregida = r'BASE_EXCEL_LAB_CORREGIDA'
_nombre_fc = r'BASE_EXCEL_LAB_FC'
_tabla_relacion_campos = r'SIS_RELACION_CAMPOS'
_tabla_dominios = r'SIS_DOMAINS'
_cvs_temporal = os.path.join(_scratch, r'datos_temp.csv')

campo_dominio = [[x[0], x[3]] for x in
                 arcpy.da.SearchCursor(_tabla_relacion_campos, ["campo_fc", "tipo", "largo", "dominio"])]
listacampos = [x[0] for x in campo_dominio]
listadominios = [x[1] for x in campo_dominio]

# creamos el diccionario de equivalencias
dic_equiv = dict()
tabla_equivalencias = _tabla_relacion_campos

with arcpy.da.SearchCursor(tabla_equivalencias, ['campo_lab', 'campo_fc']) as cursor:
    for row in cursor:
        dic_equiv[row[0]] = row[1]


# definimos funciones
def crear_tablas(gdb):
    if not arcpy.Exists(_nombre_tabla):
        arcpy.CreateTable_management(gdb, _nombre_tabla)

    if not arcpy.Exists(_nombre_tabla_corregida):
        arcpy.CreateTable_management(gdb, _nombre_tabla_corregida)

    if not arcpy.Exists(_nombre_fc):
        # creamos feature class para pasar los valores de tabla base, creando coordenadas y respetando dominios
        arcpy.CreateFeatureclass_management(gdb, _nombre_fc, "POINT", spatial_reference=4326)


# Agregamos los campos a cada una de las tablas
def agregarcampos(capa):
    # arcpy.env.workspace = gdb_base
    try:
        with arcpy.da.SearchCursor(_tabla_relacion_campos, ["campo_fc", "tipo", "largo", "dominio"]) as cursor:
            for row in cursor:
                if 'TABLA' in capa:
                    largo = row[2]
                    if row[3]:
                        largo = 250
                    arcpy.AddField_management(in_table=capa, field_name=row[0], field_type=row[1], field_length=largo)
                else:
                    arcpy.AddField_management(in_table=capa, field_name=row[0], field_type=row[1], field_length=row[2],
                                              field_domain=row[3])
    except:
        print "ya existen los campos para el objeto {0}".format(capa)


def crear_capas_auxiliares(gdb):
    crear_tablas(gdb)
    agregarcampos(_nombre_tabla)
    agregarcampos(_nombre_fc)
    agregarcampos(_nombre_tabla_corregida)


### funciones para ingreso de datos de laboratorio
def getequivalentfc(column_name):
    response = column_name
    if dic_equiv.get(column_name):
        response = dic_equiv.get(column_name)
    return response

def sum_equiv(a,b):
    suma = a+b
    resta = a-b
    return (resta/suma)*100

def preparar_datos_csv(excel_ingreso):
    xls = excel_ingreso
    # df=pd.read_excel(xls,'Avenida')
    x = pd.ExcelFile(xls)
    sheets = x.sheet_names
    sheets.sort()

    df = pd.read_excel(xls, sheets[0])
    columnas_xls = df.columns
    columnasfc = [getequivalentfc(x) for x in columnas_xls]
    df.columns = columnasfc
    # Reemplazamos los guiones por vacios
    df = df.replace('-', '')

    # Actualizamos el codigo con el sufijo de temporada
    df[st._CODIGO] = df[st._CODIGO] + "_" + df["TEMPORADA"].str[0]

    # Calculamos valores para cationes
    df["Ca_meq/l"] = df["Ca_dis"].apply(lambda x: x if str(x)[0] != "<" else "0")
    df["Ca_meq/l"] = df["Ca_meq/l"].apply(lambda x: x*2/40 if x != "-" else "-")

    df["Mg_meq/l"] = df["Mg_dis"].apply(lambda x: x if str(x)[0] != "<" else "0")
    df["Mg_meq/l"] = df["Mg_meq/l"].apply(lambda x: x*2/24.3 if x != "-" else "-")

    df["Na_meq/l"] = df["Na_dis"].apply(lambda x: x if str(x)[0] != "<" else "0")
    df["Na_meq/l"] = df["Na_meq/l"].apply(lambda x: x/23 if x != "-" else "-")

    df["K_meq/l"] = df["K_dis"].apply(lambda x: x if str(x)[0] != "<" else "0")
    df["K_meq/l"] = df["K_meq/l"].apply(lambda x: x/39.1 if x != "-" else "-")

    df["Total_meq/l_cat"] = df["Ca_meq/l"] + df["Mg_meq/l"] + df["Na_meq/l"] + df["K_meq/l"]
    df["Total_meq/l_cat"] = df["Total_meq/l_cat"].apply(lambda x:x if type(x) in (int,float) else '-' )

    # Calculamos valores para aniones
    df["HCO3_meq/l"] = df["HCO3-"].apply(lambda x: x if str(x)[0] != "<" else "0")
    df["HCO3_meq/l"] = df["HCO3_meq/l"].apply(lambda x: x/61 if x != "-" else "-")

    df["CO3_meq/l"] = df["CO3= (mg/L)"].apply(lambda x: x if str(x)[0] != "<" else "0")
    df["CO3_meq/l"] = df["CO3_meq/l"].apply(lambda x: x*2/60 if x != "-" else "-")

    df["SO4_meq/l"] = df["SO4="].apply(lambda x: x if str(x)[0] != "<" else "0")
    df["SO4_meq/l"] = df["SO4_meq/l"].apply(lambda x: x*2/96 if x != "-" else "-")

    df["Cl_meq/l"] = df["Cl-"].apply(lambda x: x if str(x)[0] != "<" else "0")
    df["Cl_meq/l"] = df["Cl_meq/l"].apply(lambda x: x/35.45 if x != "-" else "-")

    df["Total_meq/l_an"] = df["HCO3_meq/l"] + df["CO3_meq/l"] + df["SO4_meq/l"] + df["Cl_meq/l"]
    df["Total_meq/l_an"] = df["Total_meq/l_an"].apply(lambda x:x if type(x) in (int,float) else '-' )

    # Calculos
    df["BI_%"] = df.apply(lambda x: sum_equiv(x["Total_meq/l_cat"], x["Total_meq/l_an"]) if x["Total_meq/l_cat"]!='-' else '-', axis=1)
    df["Ca_%"] = df.apply(lambda x: 100 * x["Ca_meq/l"]/x["Total_meq/l_cat"] if x["Total_meq/l_cat"]!='-' else '-', axis=1)
    df["Mg_%"] = df.apply(lambda x: 100 * x["Mg_meq/l"]/x["Total_meq/l_cat"] if x["Total_meq/l_cat"]!='-' else '-', axis=1)
    df["Na+K_%"] = df.apply(lambda x: 100 * (x["Na_meq/l"] + x["K_meq/l"])/x["Total_meq/l_cat"] if x["Total_meq/l_cat"]!='-' else '-', axis=1)


    df.to_csv(_cvs_temporal, index=False, encoding='utf-8-sig')




####

def csvtemp_to_tabla_base(csv, target):
    arcpy.Append_management(csv, target, "NO_TEST")


###
### funciones para ingresar datos del csv a la gdb
def getvalues_dominio(nom_dominio):
    diccionario_dominio = dict()
    with arcpy.da.SearchCursor(_tabla_dominios, ["DOMINIO", "KEY", "VALUE"],
                               where_clause="DOMINIO ='{}'".format(nom_dominio)) as cursor:
        for row in cursor:
            diccionario_dominio[row[2]] = row[1]

    return diccionario_dominio


def get_valor_equiv(valor, diccionario):
    # obtiene el valor euivalente de dominio

    coincidencia = diff.get_close_matches(valor, [key for key in diccionario], n=1, cutoff=0.6)
    coincidencia = coincidencia[0] if len(coincidencia) > 0 else None
    return diccionario.get(coincidencia)


def creargeometria(coor_x, coor_y, zona):
    zona = int(zona)
    sr_wgs = arcpy.SpatialReference(4326)
    references = {17: 32717, 18: 32718, 19: 32719}
    reference = references[zona]

    point = arcpy.Point()
    point.X = coor_x
    point.Y = coor_y
    srf = arcpy.SpatialReference(reference)

    pointGeometry = arcpy.PointGeometry(point, srf)
    pointGeometry_wgs = pointGeometry.projectAs(sr_wgs)
    return pointGeometry_wgs


def insertar_fc(capa):
    # insertamos registros de la tabla base a la tabla corregida y al fc
    icursor = arcpy.da.InsertCursor(capa, listacampos)

    with arcpy.da.SearchCursor(_nombre_tabla, listacampos) as cursor:
        for row in cursor:
            fila = []
            for columna in range(len(row)):
                dominio_nombre = listadominios[columna]

                if dominio_nombre:

                    dic_dom = getvalues_dominio(dominio_nombre)

                    if row[columna]:
                        valor = row[columna].lower()

                        if valor == u'sí':
                            valor = 'si'
                        valor_equiv = get_valor_equiv(valor, dic_dom)

                        if valor_equiv:
                            valor_columna = valor_equiv
                        else:
                            valor_columna = None
                    else:
                        valor_columna = None

                else:
                    valor_columna = row[columna]
                del dominio_nombre
                fila.append(valor_columna)
            fila_as_tupla = tuple(fila)
            # print fila
            icursor.insertRow(fila_as_tupla)

    del icursor


def act_geometria(fc):
    with arcpy.da.UpdateCursor(fc, ["ESTE", "NORTE", "ZONA", "SHAPE@", "LONGITUD", "LATITUD"]) as ucursor:
        for row in ucursor:
            geometria = creargeometria(row[0], row[1], row[2])
            row[3] = geometria
            row[4] = geometria.centroid.Y
            row[5] = geometria.centroid.X
            ucursor.updateRow(row)


def insertar_de_base_a_capas_intermedias():
    insertar_fc(_nombre_fc)
    insertar_fc(_nombre_tabla_corregida)
    act_geometria(_nombre_fc)


def insertar_capas_produccion():
    arcpy.Append_management(_nombre_fc, r'DS_LINEABASEGEOAMBIENTAL\GPT_LINEA_BASE_GEOAMBIENTAL', "NO_TEST")
    arcpy.Append_management(_nombre_fc, r'DS_LINEABASEGEOAMBIENTAL\GPT_LINEA_BASE_GEOAMBIENTAL_HIDROQUIMICA', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_ANIONS', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_ANIONS_MEQ_L', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_ANIONS_MEQ_L_PORC', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_ASPECT_GEOL_LIT', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_CAT_MEQ_L', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_CAT_MEQ_L_PORC', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_CAT_TOT', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_INDICES_CALC', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_LOCAL', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_PARAM_FISQUIM', "NO_TEST")
    arcpy.Append_management(_nombre_tabla_corregida, r'TB_USO_FUENTE', "NO_TEST")


try:
    crear_capas_auxiliares(gdb_base)
    preparar_datos_csv(xls_file)
    csvtemp_to_tabla_base(_cvs_temporal, _nombre_tabla)
    insertar_de_base_a_capas_intermedias()
    insertar_capas_produccion()
    response["response"] = "response"
except Exception as e:
    response['status'] = 0
    response['message'] = traceback.format_exc()
finally:
    response = json.dumps(response, encoding='windows-1252', ensure_ascii=False)
    arcpy.SetParameterAsText(2, response)
