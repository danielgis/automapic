Imports System.Windows.Forms
Imports ESRI.ArcGIS.esriSystem
Imports ESRI.ArcGIS.Framework
Imports Newtonsoft.Json
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.IO
Public Class Form_mapa_hidrogeoquimico
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim ruta_gdb_mhq As String
    Dim ruta_xls_mhq As String
    Dim params As New List(Of Object)
    Dim valid_gdb As Integer = 0
    Dim valid_xls As Integer = 0


    Private Sub btn_mhq_gdb_Click(sender As Object, e As EventArgs) Handles btn_mhq_gdb.Click

        ruta_gdb_mhq = openDialogBoxESRI(f_workspace)
        If ruta_gdb_mhq Is Nothing Then
            'Cursor.Current = Cursors.Default
            valid_gdb = 0
            btn_mhq_cargar.Enabled = False
            Return
        End If
        tbx_mhq_gdb.Text = ruta_gdb_mhq
        valid_gdb = 1
        If valid_gdb = 1 And valid_xls = 1 Then
            btn_mhq_cargar.Enabled = True
        End If


    End Sub

    Private Sub btn_mhq_excel_Click(sender As Object, e As EventArgs) Handles btn_mhq_excel.Click

        'OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Dim validador = OpenFileDialog1.ShowDialog()
        ruta_xls_mhq = OpenFileDialog1.FileName

        If validador = 2 Then
            'Cursor.Current = Cursors.Default
            valid_xls = 0
            btn_mhq_cargar.Enabled = False
            Return
        End If
        tbx_mhq_excel.Text = ruta_xls_mhq
        valid_xls = 1
        If valid_gdb = 1 And valid_xls = 1 Then
            btn_mhq_cargar.Enabled = True
        End If
    End Sub

    Private Sub btn_mhq_cargar_Click(sender As Object, e As EventArgs) Handles btn_mhq_cargar.Click
        runProgressBar()

        params.Clear()
        params.Add(ruta_gdb_mhq)
        params.Add(ruta_xls_mhq)


        Dim response = ExecuteGP(_tool_insertarDatosGdb, params, _toolboxPath_mapa_hidrogeoquimico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)

            runProgressBar("ini")
            'Cursor.Current = Cursors.Default
            Return
        End If
        runProgressBar("ini")
    End Sub
End Class