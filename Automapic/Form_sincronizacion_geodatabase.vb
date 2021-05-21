Imports System.Windows.Forms

Public Class Form_sincronizacion_geodatabase
    Dim ruta_origen As String
    Private Sub btn_sg_origen_Click(sender As Object, e As EventArgs) Handles btn_sg_origen.Click

        ruta_origen = openDialogBoxESRI(f_geodatabase)
        If ruta_origen Is Nothing Then
            'Cursor.Current = Cursors.Default
            Return
        End If
        tbx_origen.Text = ruta_origen


    End Sub
End Class