Imports System.Windows.Forms
Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Geometry
Imports ESRI.ArcGIS.Carto
Imports Newtonsoft.Json

Public Class Form_mapa_hidrogeologico
    'Dim controller As Integer = 0
    Dim cuencasDictSelected As New Dictionary(Of String, String)
    Dim params As New List(Of Object)
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim cuencasDictByCombobox As New Dictionary(Of String, String)
    Dim autoresDictByCheckListBox As New Dictionary(Of String, String)
    Delegate Sub ProcessItemCheck(ByRef ListBoxObject As CheckedListBox)

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

        Dim response2 = ExecuteGP(_tool_getAutoresMgh, params, _toolboxPath_mapa_hidrogeologico)
        Dim responseJson2 = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response2)
        If responseJson2.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson2.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cursor.Current = Cursors.Default
            runProgressBar("ini")
            Return
        End If
        For Each current In responseJson2.Item("response")
            autoresDictByCheckListBox.Add(current(0), current(1))
        Next
        clb_mh_autores.DataSource = New BindingSource(autoresDictByCheckListBox, Nothing)
        clb_mh_autores.DisplayMember = "Value"
        clb_mh_autores.ValueMember = "Key"

        tc_mh_tools.Enabled = False
        'tbx_mh_title2.Text = "MAPA HIDROGEOLÓGICO"
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
        Dim idx = cbx_mh_cuencas.SelectedIndex
        'cbx_mh_cuencas.Items(idx).Enabled = False
        If cuencasDictSelected.ContainsKey(cuenca_sel_key) Then
            MessageBox.Show("La cuenca ya fue seleccionada", __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        cuencasDictSelected.Add(cuenca_sel_key, cuenca_sel_value)
        Dim codcuencasArray As New List(Of Object)
        Dim nomcuencasArray As New List(Of String)
        For Each ikey As String In cuencasDictSelected.Keys
            codcuencasArray.Add(ikey)
            If Not cuencasDictSelected(ikey).ToLower().Contains("intercuenca") Then
                Dim nm_cuenca = Trim(cuencasDictSelected(ikey).ToLower.Replace("cuenca", "").Split("-")(0))
                nomcuencasArray.Add(nm_cuenca.ToUpper())
            End If
        Next
        tbx_mh_title1.Text = SetTitle1(nomcuencasArray)
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

        If cuencasDictSelected.Count > 0 Then
            tc_mh_tools.Enabled = True
        End If

        lbx_mh_cuencas.DataSource = New BindingSource(cuencasDictSelected, Nothing)
        lbx_mh_cuencas.DisplayMember = "Value"
        lbx_mh_cuencas.ValueMember = "Key"
        cbx_mh_cuencas.SelectedIndex = -1
    End Sub

    Private Function SetTitle1(arrayCuencas As IList(Of String))
        Dim response As String = "HIDROGEOLOGÍA DE LA CUENCA DEL RÍO " & String.Join(", ", arrayCuencas)
        Return response
    End Function

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

        If cuencasDictSelected.Count = 0 Then
            tc_mh_tools.Enabled = False
        End If

        Dim codcuencasArray As New List(Of Object)
        Dim nomcuencasArray As New List(Of String)
        For Each ikey As String In cuencasDictSelected.Keys
            codcuencasArray.Add(ikey)
            If Not cuencasDictSelected(ikey).ToLower().Contains("intercuenca") Then
                Dim nm_cuenca = Trim(cuencasDictSelected(ikey).ToLower.Replace("cuenca", "").Split("-")(0))
                nomcuencasArray.Add(nm_cuenca.ToUpper())
            End If
        Next
        tbx_mh_title1.Text = SetTitle1(nomcuencasArray)
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

    Private Sub ProcessItemCheckSub(ByRef ListBoxObject As CheckedListBox)
        Dim nomautores As New List(Of String)

        For i As Integer = 0 To clb_mh_autores.Items.Count - 1
            If i < 0 Then
                Continue For
            End If
            Dim st As CheckState = clb_mh_autores.GetItemCheckState(i)
            Dim val As String = clb_mh_autores.GetItemText(clb_mh_autores.Items.Item(i))
            If st = CheckState.Checked Then
                nomautores.Add(val)
            End If
        Next
        tbx_mh_autores.Text = String.Join(" & ", nomautores)
    End Sub

    Private Sub clb_mh_autores_ItemCheck(sender As Object, e As EventArgs) Handles clb_mh_autores.ItemCheck
        Dim Objects As Object() = {clb_mh_autores}
        BeginInvoke(New ProcessItemCheck(AddressOf ProcessItemCheckSub), Objects)
    End Sub

    Private Sub btn_mh_grotulo_Click(sender As Object, e As EventArgs) Handles btn_mh_grotulo.Click
        runProgressBar()
        Cursor.Current = Cursors.WaitCursor
        params.Clear()
        Dim tamanio As String
        If rbt_mh_pequenio.Checked Then
            tamanio = "1"
        Else
            tamanio = "2"
        End If
        params.Add(tamanio)
        params.Add(tbx_mh_autores.Text)
        params.Add(tbx_mh_title1.Text)
        params.Add(tbx_mh_title2.Text)
        params.Add(nud_mh_numero.Value)
        Dim response = ExecuteGP(_tool_generateRotuloMhg, params, _toolboxPath_mapa_hidrogeologico)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cursor.Current = Cursors.Default
            runProgressBar("ini")
            Return
        End If

        Dim pMxDoc As IMxDocument
        pMxDoc = My.ArcMap.Application.Document
        If TypeOf pMxDoc.ActiveView IsNot IPageLayout Then
            pMxDoc.ActiveView = pMxDoc.PageLayout
        End If

        pMxDoc.PageLayout.Page.Units = ESRI.ArcGIS.esriSystem.esriUnits.esriCentimeters
        pMxDoc.ActivatedView.Refresh()

        Dim graphicsContainer As IGraphicsContainer = pMxDoc.PageLayout
        Dim PictureElement As IPictureElement = New JpgPictureElement()

        Dim pEnv As IEnvelope = New Envelope()
        If tamanio = "1" Then
            pEnv.PutCoords(0, 0, 7.1, 3.6)
        Else
            pEnv.PutCoords(0, 0, 14.1, 9.1)
        End If

        PictureElement.ImportPictureFromFile(responseJson("response"))
        Dim IElement As IElement = PictureElement
        IElement.Geometry = pEnv
        graphicsContainer.AddElement(IElement, 0)

        pMxDoc.ActivatedView.Refresh()
        Cursor.Current = Cursors.Default
        runProgressBar("ini")
    End Sub
End Class