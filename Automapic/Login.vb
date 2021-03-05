Imports System.Windows.Forms
Public Class Login
    Private Sub LoginValidate(user As String, password As String)

    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Incluir proceso de validacion
        'LoginValidate(user, password)
        user = tbx_user.Text
        pass = tbx_pass.Text
        If Not (user = "admin" And pass = "admin") Then
            MessageBox.Show("Usuario y contraseña incorrecta", __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        '------------------------------
        Dim ModulosForm = New Modulos()
        openFormByName(ModulosForm, Me.Parent)
    End Sub
End Class