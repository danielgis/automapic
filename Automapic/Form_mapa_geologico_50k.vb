﻿Imports System.Windows.Forms
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
        MessageBox.Show(drawLine_wkt, __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            If r = DialogResult.No Then
                Return
            Else
                codhoja = Nothing
                cbx_mg_fila.Enabled = True
                cbx_mg_col.Enabled = True
                cbx_mg_cuad.Enabled = True
                Return
            End If
        End If
        cbx_mg_fila.Enabled = False
        cbx_mg_col.Enabled = False
        cbx_mg_cuad.Enabled = False
        codhoja = String.Concat(cbx_mg_fila.SelectedItem.ToString(), cbx_mg_col.SelectedItem.ToString(), cbx_mg_cuad.SelectedItem.ToString())
    End Sub
End Class