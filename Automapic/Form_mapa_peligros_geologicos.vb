Imports System.Web.Script.Serialization
Imports System.Web.Extensions
Public Class Form_mapa_peligros_geologicos
    Dim path_shapefile As String
    Dim params As New List(Of Object)
    Dim layer As String
    Private Sub btn_loadshp_Click(sender As Object, e As EventArgs) Handles btn_loadshp.Click
        path_shapefile = openDialogBoxESRI(f_shapefile)
        If path_shapefile Is Nothing Then
            Return
        End If
        runProgressBar()
        tbx_pathshp.Text = path_shapefile
        params.Clear()
        params.Add(path_shapefile)
        ExecuteGP(_tool_addFeatureToMap, params, _toolboxPath_automapic, getresult:=False)
        runProgressBar("ini")
        'Dim rawresp As String = "{""id"":174543706,""first_name"":""Hamed"",""last_name"":""Ap"",""username"":""hamed_ap"",""type"":""private""}"

        'Dim jss As New JavaScriptSerializer()
        'Dim dict As Dictionary(Of String, String) = jss.Deserialize(Of Dictionary(Of String, String))(rawresp)
        'JsonConvert.
        's = dict("id")

    End Sub
End Class