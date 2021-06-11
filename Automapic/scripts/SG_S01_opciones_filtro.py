import sys


import arcpy
import settings as st
import messages as msg
import traceback
import os
import json


response = dict()
response['status'] = 1
response['message'] = 'success'

try:

    items = [st._ORIGEN, st._EXTFILE, st._MXD_ACTUAL]
    response['response'] = ','.join(items)
    
except Exception as e:
    response['status'] = 0
    response['message'] = e.message
finally:
    response = json.dumps(response)
    arcpy.SetParameterAsText(0, response)

arcpy.SetParameterAsText(0, response)