<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_mapa_geologico_50k
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_mapa_geologico_50k))
        Me.tc_mg_50k = New System.Windows.Forms.TabControl()
        Me.tab_mg_leyenda = New System.Windows.Forms.TabPage()
        Me.tb_mg_adicionales = New System.Windows.Forms.TabPage()
        Me.tb_mg_perfil = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbx_mg_pathdata = New System.Windows.Forms.TextBox()
        Me.btn_mg_loaddata = New System.Windows.Forms.Button()
        Me.lbl_mg_cargar_dem = New System.Windows.Forms.Label()
        Me.btn_mg_drawline = New System.Windows.Forms.Button()
        Me.btn_mp_seccion = New System.Windows.Forms.Button()
        Me.tb_mg_mapa = New System.Windows.Forms.TabPage()
        Me.ilist_mg_50k = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_mg_fila = New System.Windows.Forms.ComboBox()
        Me.cbx_mg_col = New System.Windows.Forms.ComboBox()
        Me.cbx_mg_cuad = New System.Windows.Forms.ComboBox()
        Me.lbl_dato_hoja = New System.Windows.Forms.Label()
        Me.lbl_mg_fila = New System.Windows.Forms.Label()
        Me.lbl_mg_col = New System.Windows.Forms.Label()
        Me.lbl_mg_cuad = New System.Windows.Forms.Label()
        Me.btn_load_code = New System.Windows.Forms.Button()
        Me.btn_load_gdb = New System.Windows.Forms.Button()
        Me.lbl_mg_tolerancia = New System.Windows.Forms.Label()
        Me.nud_mg_tolerancia = New System.Windows.Forms.NumericUpDown()
        Me.tc_mg_50k.SuspendLayout()
        Me.tb_mg_perfil.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nud_mg_tolerancia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tc_mg_50k
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tc_mg_50k, 9)
        Me.tc_mg_50k.Controls.Add(Me.tab_mg_leyenda)
        Me.tc_mg_50k.Controls.Add(Me.tb_mg_adicionales)
        Me.tc_mg_50k.Controls.Add(Me.tb_mg_perfil)
        Me.tc_mg_50k.Controls.Add(Me.tb_mg_mapa)
        Me.tc_mg_50k.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_mg_50k.Enabled = False
        Me.tc_mg_50k.ImageList = Me.ilist_mg_50k
        Me.tc_mg_50k.Location = New System.Drawing.Point(3, 88)
        Me.tc_mg_50k.Name = "tc_mg_50k"
        Me.tc_mg_50k.SelectedIndex = 0
        Me.tc_mg_50k.Size = New System.Drawing.Size(486, 605)
        Me.tc_mg_50k.TabIndex = 0
        '
        'tab_mg_leyenda
        '
        Me.tab_mg_leyenda.ImageIndex = 0
        Me.tab_mg_leyenda.Location = New System.Drawing.Point(4, 25)
        Me.tab_mg_leyenda.Name = "tab_mg_leyenda"
        Me.tab_mg_leyenda.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_mg_leyenda.Size = New System.Drawing.Size(478, 576)
        Me.tab_mg_leyenda.TabIndex = 0
        Me.tab_mg_leyenda.Text = "Leyenda"
        Me.tab_mg_leyenda.UseVisualStyleBackColor = True
        '
        'tb_mg_adicionales
        '
        Me.tb_mg_adicionales.ImageIndex = 1
        Me.tb_mg_adicionales.Location = New System.Drawing.Point(4, 25)
        Me.tb_mg_adicionales.Name = "tb_mg_adicionales"
        Me.tb_mg_adicionales.Padding = New System.Windows.Forms.Padding(3)
        Me.tb_mg_adicionales.Size = New System.Drawing.Size(478, 576)
        Me.tb_mg_adicionales.TabIndex = 1
        Me.tb_mg_adicionales.Text = "Adicionales"
        Me.tb_mg_adicionales.UseVisualStyleBackColor = True
        '
        'tb_mg_perfil
        '
        Me.tb_mg_perfil.Controls.Add(Me.TableLayoutPanel2)
        Me.tb_mg_perfil.ImageIndex = 4
        Me.tb_mg_perfil.Location = New System.Drawing.Point(4, 25)
        Me.tb_mg_perfil.Name = "tb_mg_perfil"
        Me.tb_mg_perfil.Size = New System.Drawing.Size(478, 576)
        Me.tb_mg_perfil.TabIndex = 3
        Me.tb_mg_perfil.Text = "Sección"
        Me.tb_mg_perfil.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_mg_pathdata, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mg_loaddata, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_mg_cargar_dem, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mg_drawline, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mp_seccion, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.nud_mg_tolerancia, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_mg_tolerancia, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 7
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(478, 576)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'tbx_mg_pathdata
        '
        Me.tbx_mg_pathdata.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_mg_pathdata.Enabled = False
        Me.tbx_mg_pathdata.Location = New System.Drawing.Point(3, 29)
        Me.tbx_mg_pathdata.Name = "tbx_mg_pathdata"
        Me.tbx_mg_pathdata.Size = New System.Drawing.Size(392, 22)
        Me.tbx_mg_pathdata.TabIndex = 0
        '
        'btn_mg_loaddata
        '
        Me.btn_mg_loaddata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mg_loaddata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mg_loaddata.Location = New System.Drawing.Point(401, 28)
        Me.btn_mg_loaddata.Name = "btn_mg_loaddata"
        Me.btn_mg_loaddata.Size = New System.Drawing.Size(74, 24)
        Me.btn_mg_loaddata.TabIndex = 3
        Me.btn_mg_loaddata.Text = "..."
        Me.btn_mg_loaddata.UseVisualStyleBackColor = True
        '
        'lbl_mg_cargar_dem
        '
        Me.lbl_mg_cargar_dem.AutoSize = True
        Me.lbl_mg_cargar_dem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_mg_cargar_dem.Location = New System.Drawing.Point(3, 8)
        Me.lbl_mg_cargar_dem.Name = "lbl_mg_cargar_dem"
        Me.lbl_mg_cargar_dem.Size = New System.Drawing.Size(392, 17)
        Me.lbl_mg_cargar_dem.TabIndex = 4
        Me.lbl_mg_cargar_dem.Text = "Cargar DEM"
        '
        'btn_mg_drawline
        '
        Me.btn_mg_drawline.BackColor = System.Drawing.SystemColors.Control
        Me.btn_mg_drawline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mg_drawline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mg_drawline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mg_drawline.Image = CType(resources.GetObject("btn_mg_drawline.Image"), System.Drawing.Image)
        Me.btn_mg_drawline.Location = New System.Drawing.Point(401, 88)
        Me.btn_mg_drawline.Name = "btn_mg_drawline"
        Me.btn_mg_drawline.Size = New System.Drawing.Size(74, 44)
        Me.btn_mg_drawline.TabIndex = 5
        Me.btn_mg_drawline.UseVisualStyleBackColor = False
        '
        'btn_mp_seccion
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btn_mp_seccion, 2)
        Me.btn_mp_seccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mp_seccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mp_seccion.Location = New System.Drawing.Point(3, 544)
        Me.btn_mp_seccion.Name = "btn_mp_seccion"
        Me.btn_mp_seccion.Size = New System.Drawing.Size(472, 29)
        Me.btn_mp_seccion.TabIndex = 6
        Me.btn_mp_seccion.Text = "Generar sección geológica"
        Me.btn_mp_seccion.UseVisualStyleBackColor = True
        '
        'tb_mg_mapa
        '
        Me.tb_mg_mapa.ImageIndex = 6
        Me.tb_mg_mapa.Location = New System.Drawing.Point(4, 25)
        Me.tb_mg_mapa.Name = "tb_mg_mapa"
        Me.tb_mg_mapa.Size = New System.Drawing.Size(478, 576)
        Me.tb_mg_mapa.TabIndex = 2
        Me.tb_mg_mapa.Text = "Mapa Geológico"
        Me.tb_mg_mapa.UseVisualStyleBackColor = True
        '
        'ilist_mg_50k
        '
        Me.ilist_mg_50k.ImageStream = CType(resources.GetObject("ilist_mg_50k.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilist_mg_50k.TransparentColor = System.Drawing.Color.Transparent
        Me.ilist_mg_50k.Images.SetKeyName(0, "legend.png")
        Me.ilist_mg_50k.Images.SetKeyName(1, "makeTable.png")
        Me.ilist_mg_50k.Images.SetKeyName(2, "settings.png")
        Me.ilist_mg_50k.Images.SetKeyName(3, "database.png")
        Me.ilist_mg_50k.Images.SetKeyName(4, "surface.png")
        Me.ilist_mg_50k.Images.SetKeyName(5, "select.png")
        Me.ilist_mg_50k.Images.SetKeyName(6, "GenericGlobe64.png")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tc_mg_50k, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_mg_fila, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_mg_col, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_mg_cuad, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_dato_hoja, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_mg_fila, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_mg_col, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_mg_cuad, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_load_code, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_load_gdb, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(492, 696)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cbx_mg_fila
        '
        Me.cbx_mg_fila.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_mg_fila.Enabled = False
        Me.cbx_mg_fila.FormattingEnabled = True
        Me.cbx_mg_fila.Location = New System.Drawing.Point(91, 15)
        Me.cbx_mg_fila.Name = "cbx_mg_fila"
        Me.cbx_mg_fila.Size = New System.Drawing.Size(44, 24)
        Me.cbx_mg_fila.TabIndex = 1
        '
        'cbx_mg_col
        '
        Me.cbx_mg_col.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_mg_col.Enabled = False
        Me.cbx_mg_col.FormattingEnabled = True
        Me.cbx_mg_col.Location = New System.Drawing.Point(247, 15)
        Me.cbx_mg_col.Name = "cbx_mg_col"
        Me.cbx_mg_col.Size = New System.Drawing.Size(44, 24)
        Me.cbx_mg_col.TabIndex = 2
        '
        'cbx_mg_cuad
        '
        Me.cbx_mg_cuad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_mg_cuad.Enabled = False
        Me.cbx_mg_cuad.FormattingEnabled = True
        Me.cbx_mg_cuad.Location = New System.Drawing.Point(403, 15)
        Me.cbx_mg_cuad.Name = "cbx_mg_cuad"
        Me.cbx_mg_cuad.Size = New System.Drawing.Size(44, 24)
        Me.cbx_mg_cuad.TabIndex = 3
        '
        'lbl_dato_hoja
        '
        Me.lbl_dato_hoja.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lbl_dato_hoja, 7)
        Me.lbl_dato_hoja.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_dato_hoja.Location = New System.Drawing.Point(3, 63)
        Me.lbl_dato_hoja.Name = "lbl_dato_hoja"
        Me.lbl_dato_hoja.Size = New System.Drawing.Size(444, 17)
        Me.lbl_dato_hoja.TabIndex = 5
        Me.lbl_dato_hoja.Text = "..."
        '
        'lbl_mg_fila
        '
        Me.lbl_mg_fila.AutoSize = True
        Me.lbl_mg_fila.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_mg_fila.Location = New System.Drawing.Point(38, 10)
        Me.lbl_mg_fila.Name = "lbl_mg_fila"
        Me.lbl_mg_fila.Size = New System.Drawing.Size(47, 35)
        Me.lbl_mg_fila.TabIndex = 6
        Me.lbl_mg_fila.Text = "Fila"
        Me.lbl_mg_fila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mg_col
        '
        Me.lbl_mg_col.AutoSize = True
        Me.lbl_mg_col.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_mg_col.Location = New System.Drawing.Point(141, 10)
        Me.lbl_mg_col.Name = "lbl_mg_col"
        Me.lbl_mg_col.Size = New System.Drawing.Size(100, 35)
        Me.lbl_mg_col.TabIndex = 7
        Me.lbl_mg_col.Text = "Columna"
        Me.lbl_mg_col.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mg_cuad
        '
        Me.lbl_mg_cuad.AutoSize = True
        Me.lbl_mg_cuad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_mg_cuad.Location = New System.Drawing.Point(297, 10)
        Me.lbl_mg_cuad.Name = "lbl_mg_cuad"
        Me.lbl_mg_cuad.Size = New System.Drawing.Size(100, 35)
        Me.lbl_mg_cuad.TabIndex = 8
        Me.lbl_mg_cuad.Text = "Cuadrante"
        Me.lbl_mg_cuad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_load_code
        '
        Me.btn_load_code.BackColor = System.Drawing.SystemColors.Control
        Me.btn_load_code.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_load_code.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_load_code.Enabled = False
        Me.btn_load_code.ImageIndex = 5
        Me.btn_load_code.ImageList = Me.ilist_mg_50k
        Me.btn_load_code.Location = New System.Drawing.Point(458, 13)
        Me.btn_load_code.Name = "btn_load_code"
        Me.btn_load_code.Size = New System.Drawing.Size(31, 29)
        Me.btn_load_code.TabIndex = 9
        Me.btn_load_code.UseVisualStyleBackColor = False
        '
        'btn_load_gdb
        '
        Me.btn_load_gdb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_load_gdb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_load_gdb.ImageIndex = 3
        Me.btn_load_gdb.ImageList = Me.ilist_mg_50k
        Me.btn_load_gdb.Location = New System.Drawing.Point(3, 13)
        Me.btn_load_gdb.Name = "btn_load_gdb"
        Me.btn_load_gdb.Size = New System.Drawing.Size(29, 29)
        Me.btn_load_gdb.TabIndex = 10
        Me.btn_load_gdb.UseVisualStyleBackColor = True
        '
        'lbl_mg_tolerancia
        '
        Me.lbl_mg_tolerancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_mg_tolerancia.AutoSize = True
        Me.lbl_mg_tolerancia.Location = New System.Drawing.Point(3, 61)
        Me.lbl_mg_tolerancia.Name = "lbl_mg_tolerancia"
        Me.lbl_mg_tolerancia.Size = New System.Drawing.Size(392, 17)
        Me.lbl_mg_tolerancia.TabIndex = 7
        Me.lbl_mg_tolerancia.Text = "Establecer radio de búsqueda de POG's (m)"
        '
        'nud_mg_tolerancia
        '
        Me.nud_mg_tolerancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nud_mg_tolerancia.Location = New System.Drawing.Point(401, 59)
        Me.nud_mg_tolerancia.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nud_mg_tolerancia.Name = "nud_mg_tolerancia"
        Me.nud_mg_tolerancia.Size = New System.Drawing.Size(74, 22)
        Me.nud_mg_tolerancia.TabIndex = 8
        Me.nud_mg_tolerancia.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'Form_mapa_geologico_50k
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 696)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_mapa_geologico_50k"
        Me.Text = "Form_mapa_geologico_50k"
        Me.tc_mg_50k.ResumeLayout(False)
        Me.tb_mg_perfil.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nud_mg_tolerancia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tc_mg_50k As System.Windows.Forms.TabControl
    Friend WithEvents tab_mg_leyenda As System.Windows.Forms.TabPage
    Friend WithEvents tb_mg_adicionales As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbx_mg_fila As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_mg_col As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_mg_cuad As System.Windows.Forms.ComboBox
    Friend WithEvents tb_mg_perfil As System.Windows.Forms.TabPage
    Friend WithEvents tb_mg_mapa As System.Windows.Forms.TabPage
    Friend WithEvents ilist_mg_50k As System.Windows.Forms.ImageList
    Friend WithEvents lbl_dato_hoja As System.Windows.Forms.Label
    Friend WithEvents lbl_mg_fila As System.Windows.Forms.Label
    Friend WithEvents lbl_mg_col As System.Windows.Forms.Label
    Friend WithEvents lbl_mg_cuad As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbx_mg_pathdata As System.Windows.Forms.TextBox
    Friend WithEvents btn_mg_loaddata As System.Windows.Forms.Button
    Friend WithEvents lbl_mg_cargar_dem As System.Windows.Forms.Label
    Friend WithEvents btn_mg_drawline As System.Windows.Forms.Button
    Friend WithEvents btn_mp_seccion As System.Windows.Forms.Button
    Friend WithEvents btn_load_code As System.Windows.Forms.Button
    Friend WithEvents btn_load_gdb As System.Windows.Forms.Button
    Friend WithEvents nud_mg_tolerancia As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_mg_tolerancia As System.Windows.Forms.Label
End Class
