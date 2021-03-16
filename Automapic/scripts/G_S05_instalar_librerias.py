import os
from subprocess import call
import sys
import settings as st
import glob

# Install packages
def decore_subprocess(func):
    """
    Decora funciones que devuelvan una sentencia ejecutable del consola(cmd)
    :param func: Funcion a decorar
    :return: Nueva funcion
    """

    def decorator(*args):
        command = func(*args)
        p = call('{}\python.exe {}'.format(sys.exec_prefix, command), shell=True)

    return decorator


@decore_subprocess
def install_pip():
    """
    Funcion decorada con decore_subprocess()
    :return: sentencia para la instalacion de pip desde consola
    """
    return '{}\get-pip.py'.format(st._REQUIREMENTS_DIR)


@decore_subprocess
def upgrade_pip():
    """
    Funcion decorada con decore_subprocess()
    :return: sentencia para la actualizacion de pip desde consola
    """
    return '-m easy_install pip==20.2.1'


@decore_subprocess
def install_package(package):
    """
    Funcion decorada con decore_subprocess()
    :param package: Modulo o *whl a instalar
    :return: sentencia para la actualizacion de cualquier paquete desde consola
    """
    return '-m pip install {}'.format(package)


if __name__ == '__main__':
    try:
        import pip
    except:
        install_pip()
        upgrade_pip()
    try:
        import comtypes
    except:
        packages = glob.glob('{}/*.whl'.format(st._REQUIREMENTS_DIR))
        map(install_package, packages)
