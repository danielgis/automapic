Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class UserControl_CheckBoxAddLayers
    Dim params_ui_cbox As New List(Of Object)
    Dim arrayParents As New List(Of Object)
    Dim arrayChilds As New List(Of Object)
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Dim zona_geografica_ui_cbox As String
    Dim query_ui_cbox As String
    Private Sub UserControl_CheckBoxAddLayers_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub LoadOptions(category As String, Optional zona As String = Nothing, Optional query As String = Nothing)
        params_ui_cbox.Clear()
        params_ui_cbox.Add(category)
        tvw_layers.Nodes.Clear()
        arrayChilds.Clear()
        zona_geografica_ui_cbox = zona
        query_ui_cbox = query
        Dim response = ExecuteGP(_tool_treeLayers, params_ui_cbox, _toolboxPath_automapic)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cursor.Current = Cursors.Default
            runProgressBar("ini")
            Return
        End If

        RemoveHandler tvw_layers.BeforeCheck, AddressOf tvw_layers_BeforeCheck
        RemoveHandler tvw_layers.AfterCheck, AddressOf tvw_layers_AfterCheck
        For Each kvp In responseJson.Item("response")
            If tvw_layers.Nodes.ContainsKey(kvp.item("description")) Then
                Continue For
            End If
            Dim treeNode As TreeNode = New TreeNode(kvp.item("description"))
            treeNode.Name = kvp.item("id")
            treeNode.Tag = kvp.item("parent")
            If kvp.item("parent") = "999" Then
                arrayParents.Add(treeNode)
                tvw_layers.Nodes.Add(treeNode)
                treeNode.Checked = True
                'tvw_layers.Checked = e.Node.Checked
                Continue For
            End If
            'If kvp.item("state") = 1 Then
            '    treeNode.Checked = True
            'End If
            For Each prn In arrayParents
                If prn.Name = kvp.item("parent") Then
                    treeNode.Tag = kvp.item("datasource").value & "\" & kvp.item("feature").value
                    prn.Nodes.Add(treeNode)
                    arrayChilds.Add(kvp)
                    Continue For
                End If
            Next
        Next
        AddHandler tvw_layers.BeforeCheck, AddressOf tvw_layers_BeforeCheck
        AddHandler tvw_layers.AfterCheck, AddressOf tvw_layers_AfterCheck
    End Sub
    Private Sub tvw_layers_BeforeCheck(sender As Object, e As TreeViewCancelEventArgs) Handles tvw_layers.BeforeCheck
        Dim clickedNode = e.Node
        If clickedNode.Tag = "999" Then
            e.Cancel = True
        End If
    End Sub
    Private Sub tvw_layers_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles tvw_layers.AfterCheck
        Dim clickedNode = e.Node
        'If clickedNode Is Nothing Then
        '    Return
        'End If
        Dim df = UserControl_ComboBoxDataframes1.getDataframeSelected()
        If df Is Nothing Then
            MessageBox.Show("Seleccione un DataFrame", __title__, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        For Each kvp In arrayChilds
            If kvp.item("id") = Integer.Parse(clickedNode.Name) Then
                params_ui_cbox.Clear()
                If clickedNode.Checked Then
                    If kvp.item("feature").value Is Nothing Or kvp.item("feature").value = "" Then
                        MessageBox.Show("El feature no existe", __title__, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return
                    End If
                    Dim feature = kvp.item("datasource").value & "\" & kvp.item("feature").value
                    If kvp.item("withzone").value = 1 Then
                        feature = String.Format(feature, zona_geografica_ui_cbox, zona_geografica_ui_cbox)
                    End If
                    params_ui_cbox.Add(feature)
                    Dim lyer = kvp.item("layer").value
                    If lyer Is Nothing Or lyer = "" Then
                        params_ui_cbox.Add(feature)
                    Else
                        params_ui_cbox.Add(lyer)
                    End If
                    params_ui_cbox.Add(kvp.item("datasource"))
                    params_ui_cbox.Add(kvp.item("typedatasource"))
                    params_ui_cbox.Add(df)
                    Dim query = kvp.item("query").Value
                    If query <> 1 Then
                        params_ui_cbox.Add(Nothing)
                    Else
                        params_ui_cbox.Add(query_ui_cbox)
                    End If



                    ExecuteGP(_tool_addLayerToDataFrame, params_ui_cbox, _toolboxPath_automapic, getresult:=False)
                Else
                    Dim lyer_n = kvp.item("layer_name").value
                    If kvp.item("withzone").value = 1 Then
                        lyer_n = String.Format(lyer_n, zona_geografica_ui_cbox)
                    End If

                    If lyer_n Is Nothing Or lyer_n = "" Then
                        Return
                    End If
                    params_ui_cbox.Add(lyer_n)
                    params_ui_cbox.Add(df)
                    ExecuteGP(_tool_removeFeatureOfTOC, params_ui_cbox, _toolboxPath_automapic, getresult:=False)
                End If

                Exit For
            End If


        Next

        'tbx_mh_descriph.Enabled = True
        'Dim text = clasificacionDescriptDict.Item(clickedNode)
        'tbx_mh_descriph.Text = text
    End Sub
    Public Function getChildsLayerSelected(parentNode As TreeNode, nodes_checked As List(Of String))
        For Each childNode As TreeNode In parentNode.Nodes
            If childNode.Checked = True Then
                nodes_checked.Add(childNode.Name)
                getChildsLayerSelected(childNode, nodes_checked)
            End If
        Next
    End Function
    Public Function getLayerSelected()
        Dim nodes_checked As New List(Of String)
        For Each treenode In tvw_layers.Nodes
            If treenode.tag = "999" Then
                getChildsLayerSelected(treenode, nodes_checked)
            End If
        Next
        Return nodes_checked
    End Function
    Public Function getNameDataFrame()
        Dim nameDataFrame = UserControl_ComboBoxDataframes1.getDataframeSelected()
        Return nameDataFrame
    End Function
    'Public Function getListChildsByState(checked As Boolean)
    '    For i in 
    'End Function
End Class
