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
        print(args)
        print(kwargs)
        cursor.execute(package)
        if kwargs.get('iscommit'):
            return
        elif kwargs.get('getcursor'):
            return cursor
        elif kwargs.get('returnsql'):
            return package
        elif kwargs.get('one'):
            return cursor.fetchone()[0]
        return cursor.fetchall()

    return decorator


@packageDecore
def get_config_param_value(name, one=True):
    return "SELECT VALUE FROM TB_CONFIG WHERE STATE = 1 AND NAME = '{}'".format(name)


# @packageDecore
# def get_config_param():
#     return 'SELECT ID, PARAMETER, VALUE, DESCRIPTION FROM TB_CONFIG WHERE STATE = 1'


# @packageDecore
# def get_config_default():
#     return 'SELECT ID, PARAMETER, VALUE_DEFAULT FROM TB_CONFIG WHERE STATE = 1'


# @packageDecore
# def set_config_param(id_parameter, value, iscommit=True):
#     return "UPDATE TB_CONFIG SET VALUE = '{}' WHERE ID = {}".format(value, id_parameter)


# @packageDecore
# def get_log_data(getcursor=True, returnsql=False):
#     return 'SELECT * FROM TB_LOG'


# @packageDecore
# def ins_log_data(url, state, error='', iscommit=True):
#     return "INSERT INTO TB_LOG (URL, STATE, ERROR) VALUES ('{}', {}, '{}')".format(url, state, error)


# @packageDecore
# def deleteLogRows(iscommit=True):
#     return 'DELETE FROM TB_LOG'