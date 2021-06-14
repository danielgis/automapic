Imports System.Windows.Forms
Imports ESRI.ArcGIS.GeoprocessingUI
Imports ESRI.ArcGIS.Geoprocessing
Imports ESRI.ArcGIS.Geodatabase
'Imports cademternet.GPHelper
Imports ESRI.ArcGIS.esriSystem

Module toolbox
    '1. Variables globales
    '* _toolboxPath: Construye la ruta donde se encuentra el archivo *.tbx
    Public _toolboxPath_plano_topografico As String = _path & "\scripts\T01_plano_topografico_25k.tbx"
    Public _toolboxPath_peligros_geologicos As String = _path & "\scripts\T02_mapa_peligros_geologicos.tbx"
    Public _toolboxPath_automapic As String = _path & "\scripts\T00_automapic.tbx"
    Public _toolboxPath_mapa_geologico As String = _path & "\scripts\T03_mapa_geologico_50k.tbx"
    Public _toolboxPath_mapa_hidrogeologico As String = _path & "\scripts\T04_mapa_hidrogeologico.tbx"
    Public _toolboxPath_sincronizacion_geodatabase As String = _path & "\scripts\T06_sincronizacion_geodatabase.tbx"

    '* Nombre de herramientas del tbx _toolboxPath

    ':HERRAMIENTAS DEL MODULO DE PLANOS TOPOGRAFICOS
    Public _tool_getComponentCodeSheet As String = "getComponentCodeSheet"
    Public _tool_generateTopographicMap As String = "generateTopographicMap"

    ':HERRAMIENTAS DEL SISTEMA
    Public _tool_addFeatureToMap As String = "addFeatureToMap"
    Public _tool_addRasterToMap As String = "addRasterToMap"
    Public _tool_exportMXDToMPK As String = "exportMXDToMPK"
    Public _tool_validateUser As String = "validateUser"
    Public _tool_updateSettings As String = "updateSettings"
    Public _tool_updatePreSettings As String = "updatePreSettings"
    Public _tool_installPackages As String = "installPackages"
    Public _tool_treeLayers As String = "treeLayers"
    Public _tool_addLayerToDataFrame As String = "addLayerToDataFrame"
    Public _tool_removeFeatureOfTOC As String = "removeFeatureOfTOC"

    ':HERRAMIENTAS DEL MODULO DE MAPAS DE PELIGROS GEOLOGICOS
    Public _tool_mapGeologicalHazards As String = "mapGeologicalHazards"

    ':HERRAMIENTAS DEL MODULO DE MAPAS GEOLOGICOS 50K
    Public _tool_getComponentCodeSheetMg As String = "getComponentCodeSheetMg"
    Public _tool_addFeatureQuadsToMapMg As String = "addFeatureQuadsToMapMg"
    Public _tool_generateProfile As String = "generateProfile"
    Public _tool_setSrcDataframeByCodHoja As String = "setSrcDataframeByCodHoja"
    Public _tool_addFeaturesByCodHoja As String = "addFeaturesByCodHoja"

    ':HERRAMIENTAS DEL MODULO DE MAPAS HIDROGEOLOGICOS
    Public _tool_addFeatureWatershedsToMapMhg As String = "addFeatureWatershedsToMapMhg"
    Public _tool_getCodewatershedsMhg As String = "getCodewatershedsMhg"
    Public _tool_getAutoresMgh As String = "getAutoresMgh"
    Public _tool_generateRotuloMhg As String = "generateRotuloMhg"
    Public _tool_getListFormHidrogMgh As String = "getListFormHidrogMgh"
    Public _tool_generateLegendMhg As String = "generateLegendMhg"
    Public _tool_clipLayerSelectedByCuenca As String = "clipLayerSelectedByCuenca"
    Public _tool_generateMapLocation As String = "generateMapLocation"

    ':HERRAMIENTAS DEL MODULO DE SINCRONIZACION DE GEODATABASE
    Public _tool_getFilterModeOptions As String = "getFilterModeOptions"
    Public _tool_getListOfLayers As String = "getListOfLayers"
    Public _tool_sendFilesToGDB As String = "sendFilesToGDB"



    'Public _tool_verificarpoligonosflotantes As String = "verificarpoligonosflotantes"

    '5. Funciones globales de toolbox
    '   - Funciones que devuelven resultados y que puedes ser usados en cualquier parte del proceso

    '* GPToolDialog: Inicia un cuadro de dialogo que trae un scriptool en pantalla
    '* parametros:
    '   - tool: Nombre de la herramienta
    '   - modal: True: "Si requiere que la ventana invocar bloquea la ventana principal de arcamap" 
    '            False: "Si no desea bloquer la ventana principal"; por defecto es False
    '   - tbxpath: Ruta de un nuevo tbx; por defecto el valor apunta a la variable _toolboxPath
    Function GPToolDialog(ByVal tool As String, Optional ByVal modal As Boolean = False, Optional ByVal tbxpath As String = Nothing)
        Try
            ' Si no se especifico la ruta del tbx
            If tbxpath Is Nothing Then
                tbxpath = ""
            End If

            Dim pToolHelper As IGPToolCommandHelper2 = New GPToolCommandHelper
            pToolHelper.SetToolByName(tbxpath, tool)

            If modal Then
                'Realiza la invocacion del ScriptTool bloqueando la funcionalidad de ArcMap
                Dim msgs As IGPMessages = New GPMessages
                pToolHelper.InvokeModal(0, Nothing, True, msgs)
            Else
                'Realiza la invocacion del ScriptTool sin bloquear la funcionalidad de ArcMap
                pToolHelper.Invoke(Nothing)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return Nothing
    End Function

    '* ExecuteGP: Ejecuta una herramienta personalizada
    '* parametros:
    '   - tool: Nombre de la herramienta
    '   - parameters: True: Lista de parametros que deben ser pasados a la herramienta
    '   - tbxpath: Ruta de un nuevo tbx; por defecto el valor apunta a la variable _toolboxPath
    Function ExecuteGP(ByVal tool As String, ByVal parameters As List(Of Object), Optional ByVal tbxpath As String = Nothing, Optional getresult As Boolean = True)
        Try
            ' Si no se especifico la ruta del tbx
            If tbxpath Is Nothing Then
                tbxpath = ""
            End If

            Dim response_object As IGeoProcessorResult = Nothing

            'Dim gpEventHandler As GPMessageEventHandler = New GPMessageEventHandler()

            Dim GP As GeoProcessor = New GeoProcessor()

            'Se registra el geoprocesor para capturar sus mensajes
            'GP.RegisterGeoProcessorEvents(gpEventHandler)

            ' Agregar el evento que capturara el mensaje
            'AddHandler gpEventHandler.GPMessage, AddressOf OnGPMessage

            'Agrega la ruta el tbx
            GP.AddToolbox(tbxpath)

            'Se crea el contedor de parametros
            Dim params As IVariantArray = New VarArrayClass()

            'Se agregan todos los parametros
            For Each i In parameters
                params.Add(i)
            Next
            Dim response = ""
            If getresult Then
                response_object = CType(GP.Execute(tool, params, Nothing), IGeoProcessorResult)
                response = response_object.ReturnValue

                'Desconectar el geoprocesor de la funcion que captura los eventos del mensaje
                'RemoveHandler gpEventHandler.GPMessage, AddressOf OnGPMessage

                'Remover el registro para escuchar eventos
                'GP.UnRegisterGeoProcessorEvents(gpEventHandler)
            Else
                GP.AddOutputsToMap = True
                GP.Execute(tool, params, Nothing)
                response = "Success"
            End If
            Return response
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    'Public Sub OnGPMessage(ByVal sender As Object, ByVal e As GPMessageEventArgs)
    '    Trace.WriteLine(e.Message)
    'End Sub

End Module