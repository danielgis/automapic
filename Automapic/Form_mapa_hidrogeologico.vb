Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class Form_mapa_hidrogeologico
    'Dim controller As Integer = 0
    Dim cuencasDictSelected As New Dictionary(Of String, String)
    Dim params As New List(Of Object)
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim cuencasDictByCombobox As New Dictionary(Of String, String)

    Private Sub Form_mapa_hidrogeologico_load(sender As Object, e As EventArgs) Handles Me.Load
        runProgressBar()
        Cursor.Current = Cursors.WaitCursor
        params.Clear()
        Dim response = ExecuteGP(_tool_getCodewatershedsMhg, params, _toolboxPath_mapa_hidrogeologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cursor.Current = Cursors.Default
            runProgressBar("ini")
            Return
        End If
        For Each current In responseJson.Item("response")
            cuencasDictByCombobox.Add(current(0), current(1))
        Next
        cbx_mh_cuencas.DataSource = New BindingSource(cuencasDictByCombobox, Nothing)
        cbx_mh_cuencas.DisplayMember = "Value"
        cbx_mh_cuencas.ValueMember = "Key"
        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub

    Private Sub cbx_mh_cuencas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mh_cuencas.SelectionChangeCommitted
        Dim cuenca_sel_key As String = (CType(cbx_mh_cuencas.SelectedItem, KeyValuePair(Of String, String))).Key
        Dim cuenca_sel_value As String = (CType(cbx_mh_cuencas.SelectedItem, KeyValuePair(Of String, String))).Value
        If cbx_mh_cuencas.SelectedIndex = -1 Then
            Return
        End If
        'controller = controller + 1
        If cuencasDictSelected.ContainsKey(cuenca_sel_key) Then
            MessageBox.Show("La cuenca ya fue seleccionada", __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        cuencasDictSelected.Add(cuenca_sel_key, cuenca_sel_value)
        Dim codcuencasArray As New List(Of Object)
        For Each ikey As String In cuencasDictSelected.Keys
            codcuencasArray.Add(ikey)
        Next
        Dim query As String = String.Join(",", codcuencasArray)
        params.Clear()
        params.Add(query)
        Dim response = ExecuteGP(_tool_addFeatureWatershedsToMapMhg, params, _toolboxPath_mapa_hidrogeologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        lbx_mh_cuencas.DataSource = New BindingSource(cuencasDictSelected, Nothing)
        lbx_mh_cuencas.DisplayMember = "Value"
        lbx_mh_cuencas.ValueMember = "Key"
        cbx_mh_cuencas.SelectedIndex = -1
    End Sub

    Private Sub lbx_mh_cuencas_doubleclick(sender As Object, e As EventArgs) Handles lbx_mh_cuencas.DoubleClick
        If lbx_mh_cuencas.Items.Count = 0 Then
            Return
        End If
        Dim cuenca_sel_idx = lbx_mh_cuencas.SelectedItem
        If cuencasDictSelected.Count = 0 Then
            Return
        End If
        If cuenca_sel_idx.key = -1 Then
            Return
        End If
        Dim cuenca_key As String = (CType(cuenca_sel_idx, KeyValuePair(Of String, String))).Key
        cuencasDictSelected.Remove(cuenca_key)
        lbx_mh_cuencas.DataSource = New BindingSource(cuencasDictSelected, Nothing)
        lbx_mh_cuencas.DisplayMember = "Value"
        lbx_mh_cuencas.ValueMember = "Key"

        Dim codcuencasArray As New List(Of Object)
        For Each ikey As String In cuencasDictSelected.Keys
            codcuencasArray.Add(ikey)
        Next
        Dim query As String = String.Join(",", codcuencasArray)
        If query = "" Then
            query = "6caa6007e67b4c05a3333fcce39ef2e6"
        End If
        params.Clear()
        params.Add(query)
        Dim response = ExecuteGP(_tool_addFeatureWatershedsToMapMhg, params, _toolboxPath_mapa_hidrogeologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub

End Class