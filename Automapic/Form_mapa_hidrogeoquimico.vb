Public Class Form_mapa_hidrogeoquimico
    Dim ruta_gdb_mhq As String
    Dim ruta_xls_mhq As String

    Private Sub btn_mhq_gdb_Click(sender As Object, e As EventArgs) Handles btn_mhq_gdb.Click

        ruta_gdb_mhq = openDialogBoxESRI(f_workspace)
        If ruta_gdb_mhq Is Nothing Then
            'Cursor.Current = Cursors.Default
            Return
        End If
        tbx_mhq_gdb.Text = ruta_gdb_mhq


    End Sub

    Private Sub btn_mhq_excel_Click(sender As Object, e As EventArgs) Handles btn_mhq_excel.Click

        'OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Dim validador = OpenFileDialog1.ShowDialog()
        ruta_xls_mhq = OpenFileDialog1.FileName

        If validador = 2 Then
            'Cursor.Current = Cursors.Default
            Return
        End If
        tbx_mhq_excel.Text = ruta_xls_mhq
    End Sub


End Class