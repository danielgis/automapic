﻿Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class Login
    Dim params As New List(Of Object)
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Private Sub Login_load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Private Sub LoginValidate(user As String, password As String)

    End Sub
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'Incluir proceso de validacion
        'LoginValidate(user, password)
        params.Clear()
        user = tbx_user.Text
        pass = tbx_pass.Text
        params.Add(user)
        params.Add(pass)
        Dim response As String = ExecuteGP(_tool_validateUser, params, _toolboxPath_automapic)

        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
            'runProgressBar("ini")
            Return
        End If

        'modulosList = responseJson.Item("response")
        For Each current In responseJson.Item("response")
            modulosDict.Add(current(0), current(1))
        Next

        'Dictionary.Add(1, "Peligros geologicos")
        'Dictionary.Add(2, "Plano Topográfico 25000")
        'If Not (user = "admin" And pass = "admin") Then
        '    MessageBox.Show("Usuario y contraseña incorrecta", __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If
        '------------------------------
        Dim ModulosForm = New Modulos()
        openFormByName(ModulosForm, Me.Parent)
    End Sub
End Class