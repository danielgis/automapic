Imports System.Windows.Forms
Imports ESRI.ArcGIS.Catalog
Imports ESRI.ArcGIS.CatalogUI

Module settings
    '1. Metadata
    '   - Variables que obtienen informacion sobre desarrollo, fecha, etc.

    Public __title__ As String = "Automapic 2021"
    Public __author__ As String = "Daniel Fernando Aguado Huaccharaqui"
    Public __copyright__ As String = "INGEMMET 2021"
    Public __credits__ As String = "Daniel Aguado H."
    Public __version__ As String = "1.0.1"
    Public __maintainer__ As String = __credits__
    Public __mail__ As String = "daguado@ingemmet.gob.pe"
    Public __status__ As String = "Development"

    '2. Variables globales estaticas
    '   - Estas variables no deben ser modificadas durante el proceso
    '   - Su nombre inicia con un guin bajo

    '* _path: Obtiene la ruta actual en donde se almacena la instalacion del addin
    Public _path As String = __file__()
    Public _scripts_path As String = _path & "\scripts"
    Public _layer_path As String = _scripts_path & "\layers"

    '3. Variables dinamicas alterables segun fin
    '   - Estas variables solo podran ser alteradas manejandolas dentro del contexto que fueron creados

    '* controller_sesion: Variable que toma valores de {0: "Sin incio de sesion, 1: "Usuario logeado"}
    Public user As String
    Public pass As String
    Public currentModule As Integer
    Public modulosDict As New Dictionary(Of Integer, String)
    Public controller_sesion As Integer = 0
    Public python_path As String = ""

    '4. Variables globales dinamicas
    ' - Su valor puede alterarse en todo los procesos

    Public d_contador As Integer = 0
    Public d_standar_output As String
    Public _LOADER_CONTROL As ProgressBar
    Public drawLine_wkt As String

    Public xmin As Double
    Public ymin As Double
    Public xmax As Double
    Public ymax As Double

    '5. Nombre de formatos GIS

    Public f_shapefile As String = "shapefile"
    Public f_featureclass As String = "featureclass"
    Public f_geodatabase As String = "geodatabase"
    Public f_raster As String = "raster"
    Public f_workspace As String = "workspace"
    Public f_table As String = "table"
    Public f_file As String = "file"

    '6. Funciones globales
    '   - Funciones que devuelven resultados y que puedes ser usados en cualquier parte del proceso

    '* __file__: Obtiene la ruta actual en donde se almacena la instalacion del addin
    '* parametros: No recibe parametros

    Public Function __file__()
        Dim codeBase As String = Reflection.Assembly.GetExecutingAssembly.CodeBase
        Dim uriBuilder As UriBuilder = New UriBuilder(codeBase)
        Dim path As String = Uri.UnescapeDataString(uriBuilder.Path)
        Return IO.Path.GetDirectoryName(path)
    End Function

    Public Function openFormByName(myForm As Form, container As Control)
        Dim existForm As Boolean = container.Controls.Contains(myForm)
        If (existForm) Then
            Return Nothing
        Else
            container.Controls.Clear()
        End If
        myForm.TopLevel = False
        myForm.AutoScroll = True
        myForm.Size = container.Size
        container.Controls.Add(myForm)
        myForm.Show()
        Return Nothing
    End Function

    Public Function runProgressBar(Optional position As String = Nothing)
        If _LOADER_CONTROL Is Nothing Then
            Return Nothing
        End If
        If (position = "ini") Then
            _LOADER_CONTROL.Value = 0
        ElseIf (position = "end") Then
            _LOADER_CONTROL.Value = 100
        Else
            Dim number = New Random
            _LOADER_CONTROL.Value = number.Next(20, 80)
        End If
        Return Nothing
    End Function
    Public Function successProcess()
        Dim message As String = "Proceso finalizado con exito"
        MessageBox.Show(message, __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
        runProgressBar("ini")
        Return Nothing
    End Function
    Public Function GetFilter(filetype As String) As Object
        Dim objfilter As IGxObjectFilter = Nothing
        Select Case filetype
            Case f_shapefile
                objfilter = New GxFilterShapefiles()
            Case f_featureclass
                objfilter = New GxFilterFGDBFeatureClasses()
            Case f_geodatabase
                objfilter = New GxFilterFileGeodatabases()
            Case f_raster
                objfilter = New GxFilterRasterDatasets()
            Case f_workspace
                objfilter = New GxFilterWorkspaces()
            Case f_table
                objfilter = New GxFilterTables()
            Case f_file
                objfilter = New GxFilterFiles()
        End Select
        Return objfilter
    End Function

    Public Function openDialogBoxESRI(filetype As String, Optional textButton As String = "Agregar") As Object
        Dim pEnumGX As IEnumGxObject = Nothing
        Dim pGxDialog As GxDialog = New GxDialogClass
        pGxDialog.AllowMultiSelect = False
        pGxDialog.Title = "Seleccionar"
        If filetype IsNot Nothing Then
            pGxDialog.Title = String.Format("Seleccionar {0}", filetype)
        End If
        pGxDialog.ObjectFilter = GetFilter(filetype)
        pGxDialog.ButtonCaption = textButton

        If Not pGxDialog.DoModalOpen(0, pEnumGX) Then
            Return Nothing
        End If

        Dim objGxObject As IGxObject = pEnumGX.Next
        Return objGxObject.FullName

    End Function
    'Public Sub DrawPolygon(ByVal activeView As IActiveView)

    '    If activeView Is Nothing Then
    '        Return
    '    End If

    '    Dim screenDisplay As IScreenDisplay = activeView.ScreenDisplay

    '    ' Constant
    '    screenDisplay.StartDrawing(screenDisplay.hDC, CShort(esriScreenCache.esriNoScreenCache))
    '    Dim rgbColor As IRgbColor = New RgbColorClass
    '    rgbColor.Red = 255

    '    Dim color As IColor = rgbColor ' Implicit Cast
    '    Dim simpleFillSymbol As ISimpleFillSymbol = New SimpleFillSymbolClass
    '    simpleFillSymbol.Color = color

    '    Dim symbol As ISymbol = TryCast(simpleFillSymbol, ISymbol) ' Dynamic Cast
    '    Dim rubberBand As IRubberBand = New RubberPolygonClass
    '    Dim geometry As ESRI.ArcGIS.Geometry.IGeometry = rubberBand.TrackNew(screenDisplay, symbol)
    '    screenDisplay.SetSymbol(symbol)
    '    screenDisplay.DrawPolygon(geometry)
    '    screenDisplay.FinishDrawing()

    'End Sub
End Module
