'Imports System.Web.Script.Serialization
'Imports System.Web.Extensions
'Imports Newtonsoft.Json
Imports System.Windows.Forms
Imports ESRI.ArcGIS.Carto
Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Display
'Imports ESRI.ArcGIS.Desktop.AddIns
Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Framework

Public Class Form_mapa_peligros_geologicos
    Dim path_shapefile As String
    Dim params As New List(Of Object)
    Dim layer As String
    Dim toggleTool As Boolean = False
    Private Shared _instance As Form_mapa_peligros_geologicos
    Private Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Shared Function GetInstance() As Form_mapa_peligros_geologicos

        If _instance Is Nothing Then
            _instance = New Form_mapa_peligros_geologicos()
        End If

        Return _instance

    End Function
    Private Sub Form_mapa_peligros_geologicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbx_autor.Text = user
    End Sub
    Private Sub btn_loadshp_Click(sender As Object, e As EventArgs) Handles btn_loadshp.Click
        path_shapefile = openDialogBoxESRI(f_shapefile)
        If path_shapefile Is Nothing Then
            Return
        End If
        runProgressBar()
        tbx_pathshp.Text = path_shapefile
        params.Clear()
        params.Add(path_shapefile)
        ExecuteGP(_tool_addFeatureToMap, params, _toolboxPath_automapic, getresult:=False)
        runProgressBar("ini")
        'Dim rawresp As String = "{""id"":174543706,""first_name"":""Hamed"",""last_name"":""Ap"",""username"":""hamed_ap"",""type"":""private""}"
        'Dim jsonResulttodict = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(rawresp)
        'Dim firstItem = jsonResulttodict.Item("id")
        'MessageBox.Show(firstItem)
    End Sub

    Private Sub btn_draw_Click(sender As Object, e As EventArgs) Handles btn_draw.Click
        Cursor.Current = Cursors.WaitCursor
        If toggleTool Then
            My.ArcMap.Application.CurrentTool = Nothing
            toggleTool = False
            btn_draw.FlatAppearance.BorderColor = Drawing.Color.Gray
            runProgressBar("ini")
            Return
        End If
        btn_draw.FlatAppearance.BorderColor = Drawing.Color.Red
        Dim dockWinID As UID = New UIDClass()
        dockWinID.Value = My.ThisAddIn.IDs.DrawPolygon
        Dim commandItem As ICommandItem = My.ArcMap.Application.Document.CommandBars.Find(dockWinID, False, False)
        Cursor.Current = Cursors.Default
        My.ArcMap.Application.CurrentTool = commandItem
        toggleTool = True
    End Sub

    'Private Sub mouseUpEvent(ByVal arg As Tool.MouseEventArgs) MyBase.OnMouseDown(arg)
    '    MessageBox.Show("si funciona")
    'End Sub



End Class