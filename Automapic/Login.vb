Imports System.Drawing
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports System.Threading

Public Class Login
    Dim params As New List(Of Object)
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Private Sub Login_load(sender As Object, e As EventArgs) Handles Me.Load
        pbx_login_loader.Image = Image.FromFile("C:\Users\daniel\Downloads\icon-1.1s-47px.gif")
        pbx_login_loader.SizeMode = PictureBoxSizeMode.StretchImage
        Dim response As String = ExecuteGP(_tool_preLoad, params, _toolboxPath_automapic)

    End Sub
    Private Sub LoginValidate(user As String, password As String)

    End Sub
    Private Sub text_box_consulta_uea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'Si se presiona la tecla enter y el boton buscar esta habilitado
        If e.KeyChar = Chr(13) Then
            'Llama a la funcion buscar
            Call btn_login_Click(sender, e)
        End If
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        tbx_user.Enabled = False
        tbx_pass.Enabled = False
        btn_login.Enabled = False
        pbx_login_loader.Visible = True
        params.Clear()
        bgw_login.RunWorkerAsync()
    End Sub

    Private Sub bgw_login_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_login.DoWork
        Cursor.Current = Cursors.WaitCursor
        'Incluir proceso de validacion
        params.Clear()
        user = tbx_user.Text
        pass = tbx_pass.Text
        params.Add(user)
        params.Add(pass)
        Dim response As String = ExecuteGP(_tool_validateUser, params, _toolboxPath_automapic)

        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        e.Result = responseJson
        If responseJson.Item("status") = 0 Then
            'tbx_user.Enabled = True
            'tbx_pass.Enabled = True
            'btn_login.Enabled = True
            'Cursor.Current = Cursors.Default
            'RuntimeError.PythonError = responseJson.Item("message")
            'MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'For Each current In responseJson.Item("response")
        '    modulosDict.Add(current(0), current(1))
        'Next

        ' Se instalan librerias necesarias
        params.Clear()
        ExecuteGP(_tool_installPackages, params, _toolboxPath_automapic, False)
        ExecuteGP(_tool_updatePreSettings, params, _toolboxPath_automapic, False)

    End Sub
    Private Sub bgw_login_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgw_login.ProgressChanged

    End Sub
    Private Sub bgw_login_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw_login.RunWorkerCompleted
        If e.Result.Item("status") = 0 Then
            tbx_user.Enabled = True
            tbx_pass.Enabled = True
            btn_login.Enabled = True
            Cursor.Current = Cursors.Default
            RuntimeError.PythonError = e.Result.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        For Each current In e.Result.Item("response")
            modulosDict.Add(current(0), current(1))
        Next
        ' Se carga el modulo
        Dim ModulosForm = New Modulos()
        Cursor.Current = Cursors.Default
        openFormByName(ModulosForm, Me.Parent)
    End Sub
End Class