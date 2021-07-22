﻿Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class Form_mapa_neotectonica
    Dim params As New List(Of Object)
    Dim properties
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim regionesDictByCombobox As New Dictionary(Of String, String)
    Dim cd_depa As String
    Dim idx_zona As String
    Private Sub Form_mapa_neotectonica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemoveHandler cbx_mn_region.SelectedIndexChanged, AddressOf cbx_mn_region_SelectedIndexChanged
        params.Clear()
        Dim response As String = ExecuteGP(_tool_getRegions, params, tbxpath:=_toolboxPath_automapic)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)

        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        regionesDictByCombobox.Add("-1", "----- Seleccione una región -----")
        For Each current In responseJson.Item("response")
            regionesDictByCombobox.Add(current(0), current(1))
        Next

        cbx_mn_region.DataSource = New BindingSource(regionesDictByCombobox, Nothing)
        cbx_mn_region.DisplayMember = "Value"
        cbx_mn_region.ValueMember = "Key"

        AddHandler cbx_mn_region.SelectedIndexChanged, AddressOf cbx_mn_region_SelectedIndexChanged

        params.Clear()
        UserControl_CheckListBox1.populateChekListBox(_tool_getAutoresMn, _toolboxPath_mapa_neotectonica, params)

    End Sub

    Private Sub cbx_mn_region_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_mn_region.SelectedIndexChanged
        cd_depa = (CType(cbx_mn_region.SelectedItem, KeyValuePair(Of String, String))).Key

        If cd_depa = "-1" Then
            Return
        End If


        params.Clear()
        params.Add(cd_depa)
        Dim response As String = ExecuteGP(_tool_getpropertiesRegion, params, tbxpath:=_toolboxPath_mapa_neotectonica)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)

        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        properties = responseJson.Item("response")

        'Validando la orientacion
        If properties.item("orientacion") = 1 Then
            rdb_mn_horizontal.Checked = True
        Else
            rdb_mn_vertical.Checked = True
        End If

        'Validando la escala
        nud_mn_escala.Value = Convert.ToInt32(properties.item("escala"))


        'Validando zona
        If properties.item("zona").value = 17 Then
            idx_zona = 0
        ElseIf properties.item("zona").value = 18 Then
            idx_zona = 1
        ElseIf properties.item("zona").value = 19 Then
            idx_zona = 2
        Else
            idx_zona = -1
        End If
        cbx_mn_zona.SelectedIndex = idx_zona

        'validando titulo
        'tbx_mn_titulo.Text = "MAPA NEOTECTÓNICO REGIÓN " & properties.item("nm_depa")

    End Sub

    Private Sub btn_mn_mapa_Click(sender As Object, e As EventArgs) Handles btn_mn_mapa.Click
        Cursor.Current = Cursors.WaitCursor
        runProgressBar()

        params.Clear()
        'parametro cd_depa
        params.Add(cd_depa)

        'parametro orientacion
        If rdb_mn_horizontal.Checked Then
            params.Add(1)
        Else
            params.Add(2)
        End If

        'Parametro de zona
        params.Add(Convert.ToInt32(cbx_mn_zona.Text))

        'Parametro de escala
        params.Add(Convert.ToInt32(nud_mn_escala.Value))

        'Parametro autores
        Dim autores As String = UserControl_CheckListBox1.getAutorsCheked()
        params.Add(autores)

        'Parametro outmxd
        Dim outmxd As String = String.Format("{0}/response_{1}.mxd", __tempdir__, Guid.NewGuid.ToString())

        Dim response As String = ExecuteGP(_tool_generateMapNeotectonica, params, tbxpath:=_toolboxPath_mapa_neotectonica)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)

        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim mxd_path As String = responseJson.Item("response")
        My.ArcMap.Application.OpenDocument(mxd_path)
        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub
End Class