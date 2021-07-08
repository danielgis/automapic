Imports System.Drawing
Imports System.Windows.Forms
Imports Newtonsoft.Json
Imports System.Data.SQLite
Imports System.Threading

Public Class Login
    Dim params As New List(Of Object)
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim waitTime As Integer = 500
    Private Sub Login_load(sender As Object, e As EventArgs) Handles Me.Load
        pbx_login_loader.Image = Image.FromFile(_path_loader)
        pbx_login_loader.SizeMode = PictureBoxSizeMode.StretchImage
        'Dim response As String = ExecuteGP(_tool_preLoad, params, _toolboxPath_automapic)

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
        lbl_login_log.Visible = True
        params.Clear()
        bgw_login.RunWorkerAsync()
    End Sub

    Private Sub bgw_login_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_login.DoWork
        Cursor.Current = Cursors.WaitCursor
        'Incluir proceso de validacion
        'params.Clear()
        user = tbx_user.Text
        pass = tbx_pass.Text

        bgw_login.ReportProgress(10, "Validando usuario...")

        'Value to search as SQL Query - return first match
        Dim SQLstr_validate As String = String.Format("SELECT COUNT(*) FROM TB_USER WHERE USER  ='{0}' AND PASSWORD = '{1}'", user, pass)
        Dim SQLstr_modulos As String = String.Format("SELECT ID_MODULO, MODULO FROM VW_ACCESS WHERE USER = '{0}'", user)
        Dim SQLstr_login As String = String.Format("UPDATE TB_USER SET LOGIN = 1 WHERE USER = '{0}'", user)
        Dim SQLstr_logout As String = "UPDATE TB_USER SET LOGIN = 0"

        'Define file to open - .path passed from parent form
        Dim connection As String = "Data Source=" & _path_sqlite
        Dim SQLConn As New SQLiteConnection(connection)
        Dim SQLcmd As New SQLiteCommand(SQLConn)
        Dim SQLdr As SQLiteDataReader
        SQLConn.Open()

        'Validacion de usuario
        SQLcmd.Connection = SQLConn
        SQLcmd.CommandText = SQLstr_validate
        SQLdr = SQLcmd.ExecuteReader()
        SQLdr.Read()
        Dim conteo As Integer = SQLdr.GetValue(0)
        SQLdr.Close()

        'Modulos asociados al usuario
        SQLcmd.CommandText = SQLstr_modulos
        SQLdr = SQLcmd.ExecuteReader()
        modulosDict.Clear()
        While SQLdr.Read()
            modulosDict.Add(SQLdr.GetValue(0), SQLdr.GetValue(1))
        End While
        SQLdr.Close()

        Dim QueryString As String = String.Concat(SQLstr_logout, ";", SQLstr_login)
        SQLcmd.CommandText = QueryString
        SQLcmd.ExecuteNonQuery()

        'Cierre de conexion
        SQLConn.Close()

        Dim responseJson As New Dictionary(Of String, Object)
        responseJson.Add("status", conteo)
        Dim _message As String

        If conteo = 0 Then
            _message = "Credenciales incorrectas!"
            responseJson.Add("message", _message)
            e.Result = responseJson
            Return
        End If

        _message = "success"
        responseJson.Add("message", _message)
        e.Result = responseJson

        ' Se instalan librerias necesarias
        Thread.Sleep(waitTime)
        params.Clear()
        bgw_login.ReportProgress(50, "Verificando dependencias...")
        ExecuteGP(_tool_installPackages, params, _toolboxPath_automapic, False)

        bgw_login.ReportProgress(90, "Preconfiguración automática...")
        ExecuteGP(_tool_updatePreSettings, params, _toolboxPath_automapic, False)
        Thread.Sleep(waitTime)

        bgw_login.ReportProgress(100, "Bienvenido")
        Thread.Sleep(waitTime)

    End Sub
    Private Sub bgw_login_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bgw_login.ProgressChanged
        lbl_login_log.Text = DirectCast(e.UserState, String)
    End Sub
    Private Sub bgw_login_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw_login.RunWorkerCompleted
        If e.Result.Item("status") = 0 Then
            tbx_user.Enabled = True
            tbx_pass.Enabled = True
            btn_login.Enabled = True
            pbx_login_loader.Visible = False
            lbl_login_log.Visible = False
            Cursor.Current = Cursors.Default
            RuntimeError.PythonError = e.Result.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        ' Se carga el modulo
        Dim ModulosForm = New Modulos()
        Cursor.Current = Cursors.Default
        openFormByName(ModulosForm, Me.Parent)
    End Sub
End Class