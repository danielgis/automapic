Imports System.Windows.Forms
Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Carto
Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Framework
Imports Newtonsoft.Json

Public Class Form_mapa_peligros_geologicos
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim path_shapefile As String
    Dim params As New List(Of Object)
    Dim layer As String
    Dim toggleTool As Boolean = False
    Dim maptype As String = Nothing
    Dim xmin As Double
    Dim ymin As Double
    Dim xmax As Double
    Dim ymax As Double
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
        tbx_autor_pg.Text = user
    End Sub
    Private Sub btn_loadshp_Click(sender As Object, e As EventArgs) Handles btn_loadshp.Click
        Cursor.Current = Cursors.WaitCursor
        path_shapefile = openDialogBoxESRI(f_shapefile)
        If path_shapefile Is Nothing Then
            Return
        End If
        runProgressBar()
        tbx_pathshp.Text = path_shapefile
        params.Clear()
        params.Add(path_shapefile)
        ExecuteGP(_tool_addFeatureToMap, params, _toolboxPath_automapic, getresult:=False)
        btn_generar_mapa_pg.Enabled = True
        If tbx_xmin.Text <> 0 Then
            Dim r As DialogResult = MessageBox.Show("Desea mantener la extensión especificada", __title__, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If r = DialogResult.No Then
                tbx_xmin.Text = 0
                tbx_ymin.Text = 0
                tbx_xmax.Text = 0
                tbx_ymax.Text = 0
            End If
        End If
        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub

    Public Sub ToggleDataView()
        Dim pMxDoc As IMxDocument
        pMxDoc = My.ArcMap.Application.Document
        If TypeOf pMxDoc.ActiveView Is IPageLayout Then
            pMxDoc.ActiveView = pMxDoc.FocusMap
        Else
            Return
        End If
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
        ToggleDataView()
        btn_draw.FlatAppearance.BorderColor = Drawing.Color.Red
        Dim dockWinID As UID = New UIDClass()
        dockWinID.Value = My.ThisAddIn.IDs.DrawPolygon
        Dim commandItem As ICommandItem = My.ArcMap.Application.Document.CommandBars.Find(dockWinID, False, False)
        Cursor.Current = Cursors.Default
        My.ArcMap.Application.CurrentTool = commandItem
        toggleTool = True
    End Sub

    Private Sub rbt_pg_Click(sender As Object, e As EventArgs) Handles rbt_pg.Click
        If rbt_pg.Checked Then
            tbx_detalle_pg.Enabled = False
            tbx_detalle_pg.Text = ""
        End If
    End Sub

    Private Sub rbt_zc_Click(sender As Object, e As EventArgs) Handles rbt_zc.Click
        If rbt_zc.Checked Then
            tbx_detalle_pg.Enabled = False
            tbx_detalle_pg.Text = ""
        End If
    End Sub

    Private Sub rbt_smm_Click(sender As Object, e As EventArgs) Handles rbt_smm.Click
        If rbt_smm.Checked Then
            tbx_detalle_pg.Enabled = True
        End If
    End Sub
    Private Sub rbt_sief_Click(sender As Object, e As EventArgs) Handles rbt_sief.Click
        If rbt_sief.Checked Then
            tbx_detalle_pg.Enabled = True
        End If
    End Sub

    Private Sub btn_generar_mapa_pg_Click(sender As Object, e As EventArgs) Handles btn_generar_mapa_pg.Click
        Cursor.Current = Cursors.WaitCursor
        runProgressBar()
        params.Clear()

        params.Add(path_shapefile)

        If rbt_pg.Checked Then
            maptype = "PG"
        ElseIf rbt_zc.Checked Then
            maptype = "ZC"
        ElseIf rbt_smm.Checked Then
            maptype = "SMM"
        ElseIf rbt_sief.Checked Then
            maptype = "SIEF"
        Else
            MessageBox.Show("Debe marcar el tipo de mapa que desea generar", __title__, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            runProgressBar("ini")
            Return
        End If

        params.Add(maptype)
        params.Add(tbx_title_pg.Text)
        params.Add(tbx_autor_pg.Text)
        params.Add(tbx_escala_pg.Text)
        params.Add(tbx_numero_pg.Text)
        params.Add(tbx_detalle_pg.Text)
        xmin = CDbl(Val(tbx_xmin.Text))
        params.Add(xmin)
        ymin = CDbl(Val(tbx_ymin.Text))
        params.Add(ymin)
        xmax = CDbl(Val(tbx_xmax.Text))
        params.Add(xmax)
        ymax = CDbl(Val(tbx_ymax.Text))
        params.Add(ymax)

        Dim response As String = ExecuteGP(_tool_mapGeologicalHazards, params, _toolboxPath_peligros_geologicos)

        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            MessageBox.Show(responseJson.Item("message"), __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            runProgressBar("ini")
            Return
        End If

        Dim mxd_path As String = responseJson.Item("response").Item("mxd")
        My.ArcMap.Application.OpenDocument(mxd_path)
        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub

    Private Sub btn_blank_extent_Click(sender As Object, e As EventArgs) Handles btn_blank_extent.Click
        tbx_xmin.Text = 0
        tbx_ymin.Text = 0
        tbx_xmax.Text = 0
        tbx_ymax.Text = 0
    End Sub

    Private Sub btn_pg_export_Click(sender As Object, e As EventArgs) Handles btn_pg_export.Click
        runProgressBar()
        Cursor.Current = Cursors.WaitCursor
        params.Clear()
        params.Add("CURRENT")

        Dim response = ExecuteGP(_tool_exportMXDToMPK, params, _toolboxPath_automapic)
        response = Split(response, ";")
        'Si ocurrio un error durante el proceso este devuelve el primer valor como 0
        'Se imprime el error como PythonError
        If response(0) = 0 Then
            RuntimeError.PythonError = response(2)
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            'Throw RuntimeError
        End If

        Dim path_dirname As String = LTrim(response(2).ToString())
        Process.Start(path_dirname)
        Cursor.Current = Cursors.Default
        runProgressBar("end")
        successProcess()
    End Sub
End Class