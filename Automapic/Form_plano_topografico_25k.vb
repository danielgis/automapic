Imports System.Windows.Forms
Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Carto
Imports ESRI.ArcGIS.Catalog
Imports ESRI.ArcGIS.Framework
'Imports ESRI.ArcGIS.ArcMapUI
'Imports ESRI.ArcGIS.Carto
'Imports System.Linq

Public Class Form_plano_topografico_25k
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim params As New List(Of Object)
    Dim fila_selected As String
    Dim columna_selected As String
    Dim cuadrante_selected As String
    Dim orientacion_selected As String
    Dim path_template As String

    'Private m_application As IApplication

    'Public m_application As IApplication
    Private Sub Form_plano_topografico_25k_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        runProgressBar()
        Cursor.Current = Cursors.WaitCursor
        params.Clear()
        Dim response = ExecuteGP(_tool_getComponentCodeSheet, params, _toolboxPath_plano_topografico, True)
        response = Split(response, ";")
        'Si ocurrio un error durante el proceso este devuelve el primer valor como 0
        'Se imprime el error como PythonError
        If response(0) = 0 Then
            RuntimeError.PythonError = response(2)
            MessageBox.Show(response(2))
            Return
        End If

        Dim filas = response(2).ToString()
        filas = Trim(filas)
        Dim filas_arr = filas.Split(",")

        For Each i In filas_arr
            cbx_fila.Items.Add(i)
        Next

        'Carga opciones al combo box de modulos
        'Dim dictionary As New Dictionary(Of Integer, String)
        'Dictionary.Add(1, "Peligros geologicos")
        'Dictionary.Add(2, "Plano Topográfico 25000")
        'cbx_modulos.DataSource = New BindingSource(dictionary, Nothing)
        'cbx_modulos.DisplayMember = "Value"
        'cbx_modulos.ValueMember = "Key"
        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub
    Private Sub cbx_fila_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_fila.SelectedIndexChanged
        params.Clear()
        cbx_columna.Items.Clear()
        cbx_cuad.Items.Clear()
        cbx_orien.Items.Clear()
        fila_selected = cbx_fila.SelectedItem.ToString()
        params.Add(fila_selected)
        Dim response = ExecuteGP(_tool_getComponentCodeSheet, params, _toolboxPath_plano_topografico)
        response = Split(response, ";")
        'Si ocurrio un error durante el proceso este devuelve el primer valor como 0
        'Se imprime el error como PythonError
        If response(0) = 0 Then
            RuntimeError.PythonError = response(2)
            MessageBox.Show(response(2))
            Return
        End If

        Dim columnas = response(2).ToString()
        columnas = Trim(columnas)
        Dim columnas_arr = columnas.Split(",")

        For Each i In columnas_arr
            cbx_columna.Items.Add(i)
        Next
        btn_generar_mapa.Enabled = False
        btn_export.Enabled = False
    End Sub
    Private Sub cbx_columna_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_columna.SelectedIndexChanged
        params.Clear()
        cbx_cuad.Items.Clear()
        cbx_orien.Items.Clear()
        fila_selected = cbx_fila.SelectedItem.ToString()
        columna_selected = cbx_columna.SelectedItem.ToString()
        params.Add(fila_selected)
        params.Add(columna_selected)
        Dim response = ExecuteGP(_tool_getComponentCodeSheet, params, _toolboxPath_plano_topografico)
        response = Split(response, ";")
        'Si ocurrio un error durante el proceso este devuelve el primer valor como 0
        'Se imprime el error como PythonError
        If response(0) = 0 Then
            RuntimeError.PythonError = response(2)
            MessageBox.Show(response(2), __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim cuadriculas = response(2).ToString()
        cuadriculas = Trim(cuadriculas)
        Dim cuadriculas_arr = cuadriculas.Split(",")

        For Each i In cuadriculas_arr
            cbx_cuad.Items.Add(i)
        Next
        btn_generar_mapa.Enabled = False
        btn_export.Enabled = False
    End Sub

    Private Sub cbx_cuad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_cuad.SelectedIndexChanged
        params.Clear()
        cbx_orien.Items.Clear()
        fila_selected = cbx_fila.SelectedItem.ToString()
        columna_selected = cbx_columna.SelectedItem.ToString()
        cuadrante_selected = cbx_cuad.SelectedItem.ToString()
        params.Add(fila_selected)
        params.Add(columna_selected)
        params.Add(cuadrante_selected)
        Dim response = ExecuteGP(_tool_getComponentCodeSheet, params, _toolboxPath_plano_topografico)
        response = Split(response, ";")
        'Si ocurrio un error durante el proceso este devuelve el primer valor como 0
        'Se imprime el error como PythonError
        If response(0) = 0 Then
            RuntimeError.PythonError = response(2)
            MessageBox.Show(response(2), __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim orientacion = response(2).ToString()
        orientacion = Trim(orientacion)
        Dim orientacion_arr = orientacion.Split(",")

        For Each i In orientacion_arr
            cbx_orien.Items.Add(i)
        Next
        btn_generar_mapa.Enabled = False
        btn_export.Enabled = False
    End Sub

    Private Sub cbx_orien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_orien.SelectedIndexChanged
        orientacion_selected = cbx_orien.SelectedItem.ToString()
        btn_generar_mapa.Enabled = True
        btn_export.Enabled = False
    End Sub

    Private Sub btn_generar_mapa_Click(sender As Object, e As EventArgs) Handles btn_generar_mapa.Click
        runProgressBar()
        Cursor.Current = Cursors.WaitCursor
        params.Clear()
        params.Add(fila_selected)
        params.Add(columna_selected)
        params.Add(cuadrante_selected)
        params.Add(orientacion_selected)
        Dim response = ExecuteGP(_tool_generateTopographicMap, params, _toolboxPath_plano_topografico)
        response = Split(response, ";")
        'Si ocurrio un error durante el proceso este devuelve el primer valor como 0
        'Se imprime el error como PythonError
        If response(0) = 0 Then
            RuntimeError.PythonError = response(2)
            MessageBox.Show(response(2), __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            'Throw RuntimeError
        End If

        'Dim path_mxd As String = response(2).ToString()
        'orientacion = orientacion.Replace(" ", "")
        'Dim orientacion_arr = orientacion.Split(",")

        'For Each i In orientacion_arr
        'cbx_orien.Items.Add(i)
        'Next

        path_template = LTrim(response(2).ToString())
        My.ArcMap.Application.OpenDocument(path_template)
        btn_export.Enabled = True
        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        runProgressBar()
        Cursor.Current = Cursors.WaitCursor
        params.Clear()
        params.Add(path_template)

        Dim response = ExecuteGP(_tool_exportMXDToMPK, params, _toolboxPath_plano_topografico)
        response = Split(response, ";")
        'Si ocurrio un error durante el proceso este devuelve el primer valor como 0
        'Se imprime el error como PythonError
        If response(0) = 0 Then
            RuntimeError.PythonError = response(2)
            MessageBox.Show(response(2), __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
            'Throw RuntimeError
        End If

        Dim path_dirname As String = LTrim(response(2).ToString())
        Process.Start(path_dirname)
        '_LOADER_CONTROL.Visible = False
        Cursor.Current = Cursors.Default
        runProgressBar("end")
        successProcess()
    End Sub
End Class