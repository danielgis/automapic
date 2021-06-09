#!/usr/bin/env python
# -*- coding: utf-8 -*-
import sqlite3
from sqlite3 import Error
import os

_DATABASE_PATH = os.path.join(os.path.dirname(__file__), 'automapic.db')

conn = sqlite3.connect(_DATABASE_PATH, isolation_level=None, check_same_thread=False)
cursor = conn.cursor()

def packageDecore(func):
    def decorator(*args, **kwargs):
        global conn, cursor    
        package = func(*args, **kwargs)
        if kwargs.get('iscommit'):
            cursor.execute(package)
            return
        elif kwargs.get('getcursor'):
            cursor.execute(package)
            return cursor
        elif kwargs.get('returnsql'):
            return package
        elif kwargs.get('one'):
            cursor.execute(package)
            return cursor.fetchone()[0]
        elif kwargs.get('as_dataframe'):
            import pandas as pd
            return pd.read_sql(package, conn)
        else:
            cursor.execute(package)
            return cursor.fetchall()

    return decorator


@packageDecore
def get_config_param_value(name, one=True):
    return "SELECT VALUE FROM TB_CONFIG WHERE STATE = 1 AND NAME = '{}'".format(name)

@packageDecore
def get_validate_user(user, one=True):
    return "SELECT COUNT(*) FROM TB_USER WHERE USER='{}'".format(user)

@packageDecore
def get_validate_user_pass(user, password, one=True):
    return "SELECT COUNT(*) FROM TB_USER WHERE USER  ='{}' AND PASSWORD = '{}'".format(user, password)

@packageDecore
def get_perfil(user):
    return "select id_modulo, modulo from vw_access where user = '{}'".format(user)

@packageDecore
def get_user_login(one=True):
    return "SELECT USER FROM TB_USER WHERE LOGIN = 1"

@packageDecore
def set_user_login(user, iscommit=True):
    return "UPDATE TB_USER SET LOGIN = 1 WHERE USER = '{}'".format(user)

@packageDecore
def set_all_user_logout(iscommit=True):
    return "UPDATE TB_USER SET LOGIN = 0"

@packageDecore
def get_config_by_user(user):
    return "select config, name from VW_USER_CONFIG WHERE USER = '{}'".format(user)

@packageDecore
def set_config_param(id_parameter, value, iscommit=True):
    return "UPDATE TB_CONFIG SET VALUE = '{}' WHERE ID = {}".format(value, id_parameter)

@packageDecore
def get_tree_layers(category, as_dataframe=True):
    return "SELECT * FROM TB_LAYERS WHERE CATEGORY = {} ORDER BY ID".format(category)

@packageDecore
def set_datasources_tree_layers(datasource, category, settable, iscommit=True):
    return "UPDATE TB_LAYERS SET DATASOURCE = '{}' WHERE CATEGORY = {} AND SETTABLE = {}".format(datasource, category, settable)

@packageDecore
def get_layers_selected(where, as_dataframe=True):
    return "SELECT * FROM TB_LAYERS WHERE {}".format(where)
# @packageDecore
# def get_log_data(getcursor=True, returnsql=False):
#     return 'SELECT * FROM TB_LOG'


# @packageDecore
# def ins_log_data(url, state, error='', iscommit=True):
#     return "INSERT INTO TB_LOG (URL, STATE, ERROR) VALUES ('{}', {}, '{}')".format(url, state, error)


# @packageDecore
# def deleteLogRows(iscommit=True):
#     return 'DELETE FROM TB_LOG'