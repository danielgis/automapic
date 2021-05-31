Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class UserControl_CheckBoxAddLayers
    Dim params As New List(Of Object)
    Dim arrayParents As New List(Of Object)
    Dim RuntimeError As AutomapicExceptions = New AutomapicExceptions()
    Private Sub UserControl_CheckBoxAddLayers_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Public Sub LoadOptions(category As String, Optional parent As Boolean = False)
        params.Clear()
        params.Add(category)
        Dim response = ExecuteGP(_tool_treeLayers, params, _toolboxPath_automapic)
        Dim responseJson = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(response)
        If responseJson.Item("status") = 0 Then
            RuntimeError.PythonError = responseJson.Item("message")
            MessageBox.Show(RuntimeError.PythonError, __title__, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Cursor.Current = Cursors.Default
            runProgressBar("ini")
            Return
        End If

        For Each kvp In responseJson.Item("response")
            If tvw_layers.Nodes.ContainsKey(kvp.item("description")) Then
                Continue For
            End If
            Dim treeNode As TreeNode = New TreeNode(kvp.item("description"))
            treeNode.Name = kvp.item("value")
            treeNode.Tag = kvp.item("parent")
            If kvp.item("parent") = "999" Then
                arrayParents.Add(treeNode)
                tvw_layers.Nodes.Add(treeNode)
                Continue For
            End If
            For Each prn In arrayParents
                If prn.Name = kvp.item("parent") Then
                    prn.Nodes.Add(treeNode)
                End If
            Next
        Next
    End Sub
End Class
