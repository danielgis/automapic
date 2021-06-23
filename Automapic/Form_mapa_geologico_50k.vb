Imports System.Windows.Forms
Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Framework
Imports Newtonsoft.Json

Public Class Form_mapa_geologico_50k
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim path_raster As String = Nothing
    Dim path_geodatabase As String
    Dim params As New List(Of Object)
    Dim toggleTool As Boolean = False
    Dim mgs_workspace As String = "Desea establecer una nueva geodatabase de trabajo"
    Dim fila_selected As String
    Dim columna_selected As String
    Dim cuadrante_selected As String
    Dim codhoja As String = Nothing
    Dim zona As String = Nothing
    Dim topologyDict As New Dictionary(Of String, String)
    Private Sub btn_mg_loaddata_Click(sender As Object, e As EventArgs) Handles btn_mg_loaddata.Click
        Cursor.Current = Cursors.WaitCursor
        path_raster = openDialogBoxESRI(f_raster)
        If path_raster Is Nothing Then
            Cursor.Current = Cursors.Default
            Return
        End If
        runProgressBar()
        tbx_mg_pathdata.Text = path_raster
        params.Clear()
        params.Add(path_raster)
        ExecuteGP(_tool_addRasterToMap, params, _toolboxPath_automapic, getresult:=False)
        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub

    Private Sub btn_mg_drawline_Click(sender As Object, e As EventArgs) Handles btn_mg_drawline.Click
        Cursor.Current = Cursors.WaitCursor
        If toggleTool Then
            My.ArcMap.Application.CurrentTool = Nothing
            toggleTool = False
            btn_mg_drawline.FlatAppearance.BorderColor = Drawing.Color.Gray
            runProgressBar("ini")
            Return
        End If
        Form_mapa_peligros_geologicos.GetInstance().ToggleDataView()
        btn_mg_drawline.FlatAppearance.BorderColor = Drawing.Color.Red
        Dim dockWinID As UID = New UIDClass()
        dockWinID.Value = My.IDs.DrawLine
        Dim commandItem As ICommandItem = My.ArcMap.Application.Document.CommandBars.Find(dockWinID, False, False)
        Cursor.Current = Cursors.Default
        My.ArcMap.Application.CurrentTool = commandItem
        toggleTool = True
    End Sub

    Private Sub btn_mp_seccion_Click(sender As Object, e As EventArgs) Handles btn_mp_seccion.Click
        'MessageBox.Show(drawLine_wkt, __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
        runProgressBar()
        params.Clear()
        params.Add(tbx_mg_pathdata.Text)
        params.Add(drawLine_wkt)
        params.Add(codhoja)
        params.Add(path_geodatabase)
        params.Add(zona)
        params.Add(nud_mg_tolerancia.Value.ToString)
        params.Add(nud_mg_altura.Value.ToString)
        Dim response = ExecuteGP(_tool_generateProfile, params, _toolboxPath_mapa_geologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            runProgressBar("ini")
            Return
        End If
        'params.Clear()
        'params.Add(responseJson.Item("response").Item("seccion"))
        'ExecuteGP(_tool_addFeatureToMap, params, _toolboxPath_automapic)
        'params.Clear()
        'params.Add(responseJson.Item("response").Item("pog"))
        'ExecuteGP(_tool_addFeatureToMap, params, _toolboxPath_automapic)
        runProgressBar("ini")
    End Sub

    Private Sub btn_load_gdb_Click(sender As Object, e As EventArgs) Handles btn_load_gdb.Click
        Dim response_open_dialog As String
        If path_geodatabase IsNot Nothing Then
            Dim r As DialogResult = MessageBox.Show(mgs_workspace, __title__, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If r = DialogResult.No Then
                runProgressBar("ini")
                Return
            End If
        End If
        response_open_dialog = openDialogBoxESRI(f_geodatabase)
        If response_open_dialog Is Nothing Then
            runProgressBar("ini")
            Return
        End If
        path_geodatabase = response_open_dialog
        runProgressBar()
        Cursor.Current = Cursors.WaitCursor
        'Cargar cuadriculas
        params.Clear()
        params.Add(path_geodatabase)
        Dim response_load_cuad = ExecuteGP(_tool_addFeatureQuadsToMapMg, params, _toolboxPath_mapa_geologico)
        Dim response_load_cuad_split = Split(response_load_cuad, ";")
        Dim responseJson_load_cuad = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response_load_cuad_split(1))
        If responseJson_load_cuad.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson_load_cuad.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbx_mg_fila.Enabled = False
            cbx_mg_col.Enabled = False
            cbx_mg_cuad.Enabled = False
            tc_mg_50k.Enabled = False
            runProgressBar("ini")
            Cursor.Current = Cursors.Default
            Return
        End If

        'Cargar la lista de filas
        params.Clear()
        cbx_mg_fila.Items.Clear()
        cbx_mg_col.Items.Clear()
        cbx_mg_cuad.Items.Clear()

        params.Add(path_geodatabase)
        params.Add(True)
        Dim response = ExecuteGP(_tool_getComponentCodeSheetMg, params, _toolboxPath_mapa_geologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbx_mg_fila.Enabled = False
            cbx_mg_col.Enabled = False
            cbx_mg_cuad.Enabled = False
            tc_mg_50k.Enabled = False
            runProgressBar("ini")
            Cursor.Current = Cursors.Default
            Return
        End If

        Dim filas As String = responseJson.Item("response")
        filas = Trim(filas)
        Dim filas_arr = filas.Split(",")

        For Each i In filas_arr
            cbx_mg_fila.Items.Add(i)
        Next

        'Habilitar la seleccion de codigos
        cbx_mg_fila.Enabled = True
        cbx_mg_col.Enabled = True
        cbx_mg_cuad.Enabled = True
        btn_load_code.Enabled = False
        tc_mg_50k.Enabled = False
        codhoja = Nothing

        'fin de proceso
        runProgressBar()
        Cursor.Current = Cursors.Default
        runProgressBar("ini")

    End Sub

    Private Sub cbx_mg_fila_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mg_fila.SelectedIndexChanged
        params.Clear()
        cbx_mg_col.Items.Clear()
        cbx_mg_cuad.Items.Clear()
        fila_selected = cbx_mg_fila.SelectedItem.ToString()
        params.Add(path_geodatabase)
        params.Add(True)
        params.Add(fila_selected)
        Dim response = ExecuteGP(_tool_getComponentCodeSheetMg, params, _toolboxPath_mapa_geologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            runProgressBar("ini")
            Return
        End If

        Dim columnas As String = responseJson.Item("response")
        'Dim columnas = response(2).ToString()
        columnas = Trim(columnas)
        Dim columnas_arr = columnas.Split(",")

        For Each i In columnas_arr
            cbx_mg_col.Items.Add(i)
        Next
        btn_load_code.Enabled = False
    End Sub

    Private Sub cbx_mg_col_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mg_col.SelectedIndexChanged
        params.Clear()
        cbx_mg_cuad.Items.Clear()
        columna_selected = cbx_mg_col.SelectedItem.ToString()
        params.Add(path_geodatabase)
        params.Add(True)
        params.Add(fila_selected)
        params.Add(columna_selected)
        Dim response = ExecuteGP(_tool_getComponentCodeSheetMg, params, _toolboxPath_mapa_geologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            runProgressBar("ini")
            Return
        End If

        Dim cuadrante As String = responseJson.Item("response")
        cuadrante = Trim(cuadrante)
        Dim cuadrante_arr = cuadrante.Split(",")

        For Each i In cuadrante_arr
            cbx_mg_cuad.Items.Add(i)
        Next
        btn_load_code.Enabled = False
    End Sub

    Private Sub cbx_mg_cuad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mg_cuad.SelectedIndexChanged
        params.Clear()
        'cbx_mg_cuad.Items.Clear()
        cuadrante_selected = cbx_mg_cuad.SelectedItem.ToString()
        params.Add(path_geodatabase)
        params.Add(True)
        params.Add(fila_selected)
        params.Add(columna_selected)
        params.Add(cuadrante_selected)
        Dim response = ExecuteGP(_tool_getComponentCodeSheetMg, params, _toolboxPath_mapa_geologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            runProgressBar("ini")
            Return
        End If

        btn_load_code.Enabled = True
        'Dim cuadrante As String = responseJson.Item("response")
        'cuadrante = Trim(cuadrante)
        'Dim cuadrante_arr = cuadrante.Split(",")

        'For Each i In cuadrante_arr
        '    cbx_mg_cuad.Items.Add(i)
        'Next
    End Sub

    Private Sub btn_load_code_MouseHover(sender As Object, e As EventArgs) Handles btn_load_code.MouseHover
        Dim tt_load_code As ToolTip = New ToolTip()
        tt_load_code.SetToolTip(btn_load_code, "Cargar código de hoja a utilizar")
    End Sub

    Private Sub btn_load_code_Click(sender As Object, e As EventArgs) Handles btn_load_code.Click
        If codhoja IsNot Nothing Then
            Dim r As DialogResult = MessageBox.Show("Esta seguro que desea cambiar de hoja", __title__, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If r = DialogResult.Yes Then
                codhoja = Nothing
                cbx_mg_fila.Enabled = True
                cbx_mg_col.Enabled = True
                cbx_mg_cuad.Enabled = True
                tc_mg_50k.Enabled = False
            End If
            Return
        End If
        cbx_mg_fila.Enabled = False
        cbx_mg_col.Enabled = False
        cbx_mg_cuad.Enabled = False
        tc_mg_50k.Enabled = True
        codhoja = String.Concat(cbx_mg_fila.SelectedItem.ToString(), cbx_mg_col.SelectedItem.ToString(), cbx_mg_cuad.SelectedItem.ToString())
        params.Clear()
        params.Add(codhoja)
        params.Add(path_geodatabase)
        Dim response = ExecuteGP(_tool_setSrcDataframeByCodHoja, params, _toolboxPath_mapa_geologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 1 Then
            zona = responseJson.Item("response")
            params.Clear()
            params.Add(path_geodatabase)
            params.Add(zona.ToString)
            params.Add(codhoja)
            ExecuteGP(_tool_addFeaturesByCodHoja, params, _toolboxPath_mapa_geologico, getresult:=False)
        End If

        If clb_mg_topologias.Items.Count > 0 Then
            Return
        End If

        params.Clear()
        params.Add(currentModule)
        Dim response2 As String = ExecuteGP(_tool_getListTopologyByModule, params, _toolboxPath_automapic)
        Dim responseJson2 = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response2)
        If responseJson2.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson2.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cursor.Current = Cursors.Default
            runProgressBar("ini")
            Return
        End If

        For Each current In responseJson2.Item("response")
            topologyDict.Add(current.Item("id").value, current.Item("name").value)
        Next

        clb_mg_topologias.DataSource = New BindingSource(topologyDict, Nothing)
        clb_mg_topologias.DisplayMember = "Value"
        clb_mg_topologias.ValueMember = "Key"

    End Sub

    Private Sub btn_mg_SelectlayerByLocation_Click(sender As Object, e As EventArgs) Handles btn_mg_SelectlayerByLocation.Click
        Dim myUid As UID = New UID()
        myUid.Value = "esriArcMapUI.SelectFeaturesTool"
        Dim ThisDoc As IDocument = My.ArcMap.Application.Document
        Dim CommandBars As ICommandBars = TryCast(ThisDoc.CommandBars, ICommandBars)
        CommandBars.Find(myUid)
        Dim myItem As ICommandItem = TryCast(CommandBars.Find(myUid), ICommandItem)
        myItem.Execute()
    End Sub

    Private Sub rbt_mg_seleccion_CheckedChanged(sender As Object, e As EventArgs) Handles rbt_mg_seleccion.CheckedChanged
        btn_mg_SelectlayerByLocation.Enabled = rbt_mg_seleccion.Checked
    End Sub

    Private Sub btn_mg_run_topology_Click(sender As Object, e As EventArgs) Handles btn_mg_run_topology.Click
        runProgressBar()
        Cursor.Current = Cursors.WaitCursor
        Dim topologias As New List(Of String)
        For i As Integer = 0 To clb_mg_topologias.Items.Count - 1
            If i < 0 Then
                Continue For
            End If
            Dim st As CheckState = clb_mg_topologias.GetItemCheckState(i)
            Dim val As String = clb_mg_topologias.Items.Item(i).key
            If st = CheckState.Checked Then
                topologias.Add(val)
            End If
        Next
        If topologias.Count = 0 Then
            Cursor.Current = Cursors.Default
            runProgressBar("ini")
            MessageBox.Show("Debe seleccionar al menos un tipo de análisis topológico", __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim topologias_string As String = String.Join(",", topologias)
        params.Clear()
        params.Add(codhoja)
        params.Add(topologias_string)
        params.Add(zona)
        params.Add(path_geodatabase)
        Dim response = ExecuteGP(_tool_applyTopology, params, _toolboxPath_mapa_geologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            Cursor.Current = Cursors.Default
            runProgressBar("ini")
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        lbl_mg_topology_res.Text = responseJson.Item("response")

        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub
End Class