import settings_aut as st
import arcpy

connarc = arcpy.ArcSDESQLExecute(st._BDGEOCAT_SDE)

def arcPackageDecore(func):
    def decorator(*args, **kwargs):
        global connarc    
        package = func(*args, **kwargs)
        cursor = connarc.execute(package)
        return cursor

    return decorator

@arcPackageDecore
def get_all_regions():
    return "SELECT CD_DEPA, CD_DEPA || ' - ' || NM_DEPA FROM DATA_GIS.GPO_DEP_DEPARTAMENTO WHERE CD_DEPA <> '99'"
