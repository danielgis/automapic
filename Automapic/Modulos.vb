Imports System.Windows.Forms

Public Class Modulos
    Private Sub btn_modulo_nuevo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btn_cerrar_sesion_Click(sender As Object, e As EventArgs) Handles btn_cerrar_sesion.Click
        Dim response As DialogResult = MessageBox.Show("¿Está seguro que deasea cerrar sesión en Automapic?", __title__, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.No Then
            Return
        End If
        Dim LoginForm = New Login()
        openFormByName(LoginForm, Me.Parent)
        modulosDict.Clear()
    End Sub

    Private Sub Modulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Carga opciones al combo box de modulos
        'Dim dictionary As New Dictionary(Of Integer, String)
        'dictionary.Add(1, "Peligros geologicos")
        'dictionary.Add(2, "Plano Topográfico 25000")
        'For Each current In modulosList
        '    dictionary.Add(current(0), current(1))
        'Next
        cbx_modulos.DataSource = New BindingSource(modulosDict, Nothing)
        cbx_modulos.DisplayMember = "Value"
        cbx_modulos.ValueMember = "Key"


        _LOADER_CONTROL = Me.pgb_modulos
    End Sub

    Private Sub Modulos_resizeEnd(sender As Object, e As EventArgs) Handles MyBase.Resize
        'Permite cambiar el size del formulario en funcion del DockableWindow
        Dim numberControls As Integer = pnl_modulos_form.Controls.Count()
        If (numberControls) Then
            Dim control = pnl_modulos_form.Controls.Item(0)
            Try
                control.Size = pnl_modulos_form.Size
                control.Update()
            Catch ex As Exception
                MessageBox.Show(ex.Message())
            End Try
        End If
    End Sub

    Private Sub cbx_modulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_modulos.SelectedIndexChanged
        Dim modulo As Integer = (CType(cbx_modulos.SelectedItem, KeyValuePair(Of Integer, String))).Key
        If (modulo = 1) Then
            Dim plano_topografico_form = New Form_plano_topografico_25k()
            openFormByName(plano_topografico_form, pnl_modulos_form)
        ElseIf (modulo = 2) Then
            Dim mapa_peligros_geologicos = Form_mapa_peligros_geologicos.GetInstance()
            openFormByName(mapa_peligros_geologicos, pnl_modulos_form)
        ElseIf (modulo = 3) Then
            Dim mapa_geologico_50k = New Form_mapa_geologico_50k()
            openFormByName(mapa_geologico_50k, pnl_modulos_form)
        ElseIf (modulo = 4) Then
            Dim mapa_hidrogeologico = New Form_mapa_hidrogeologico()
            openFormByName(mapa_hidrogeologico, pnl_modulos_form)
        ElseIf (modulo = 6) Then
            Dim sincronizacion_gdb = New Form_sincronizacion_geodatabase()
            openFormByName(sincronizacion_gdb, pnl_modulos_form)
        End If

    End Sub

    Private Sub pbx_add_Click(sender As Object, e As EventArgs) Handles pbx_add.Click
        Dim mgs As String = "¿Está seguro que desea realizar una nueva configuración? Es posible que los cambios realizados se pierdan."
        Dim r As DialogResult = MessageBox.Show(mgs, __title__, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.No Then
            Return
        End If
        GPToolDialog(_tool_updateSettings, True, _toolboxPath_automapic)
        Call cbx_modulos_SelectedIndexChanged(sender, e)
        'Me.Refresh()
    End Sub
End Class