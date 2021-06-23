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
        Me.tab_mg_topologia = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clb_mg_topologias = New System.Windows.Forms.CheckedListBox()
        Me.rbt_mg_seleccion = New System.Windows.Forms.RadioButton()
        Me.btn_mg_run_topology = New System.Windows.Forms.Button()
        Me.ilist_mg_50k = New System.Windows.Forms.ImageList(Me.components)
        Me.rbt_mg_actual = New System.Windows.Forms.RadioButton()
        Me.btn_mg_SelectlayerByLocation = New System.Windows.Forms.Button()
        Me.tb_mg_query = New System.Windows.Forms.TabPage()
        Me.tb_mg_perfil = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbx_mg_pathdata = New System.Windows.Forms.TextBox()
        Me.btn_mg_loaddata = New System.Windows.Forms.Button()
        Me.lbl_mg_cargar_dem = New System.Windows.Forms.Label()
        Me.btn_mg_drawline = New System.Windows.Forms.Button()
        Me.btn_mp_seccion = New System.Windows.Forms.Button()
        Me.nud_mg_tolerancia = New System.Windows.Forms.NumericUpDown()
        Me.lbl_mg_tolerancia = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nud_mg_altura = New System.Windows.Forms.NumericUpDown()
        Me.tb_mg_mapa = New System.Windows.Forms.TabPage()
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
        Me.lbl_mg_topology_res = New System.Windows.Forms.Label()
        Me.tc_mg_50k.SuspendLayout()
        Me.tab_mg_topologia.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tb_mg_perfil.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.nud_mg_tolerancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nud_mg_altura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_mg_50k
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tc_mg_50k, 9)
        Me.tc_mg_50k.Controls.Add(Me.tab_mg_topologia)
        Me.tc_mg_50k.Controls.Add(Me.tb_mg_query)
        Me.tc_mg_50k.Controls.Add(Me.tb_mg_perfil)
        Me.tc_mg_50k.Controls.Add(Me.tb_mg_mapa)
        Me.tc_mg_50k.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_mg_50k.Enabled = False
        Me.tc_mg_50k.ImageList = Me.ilist_mg_50k
        Me.tc_mg_50k.Location = New System.Drawing.Point(2, 70)
        Me.tc_mg_50k.Margin = New System.Windows.Forms.Padding(2)
        Me.tc_mg_50k.Name = "tc_mg_50k"
        Me.tc_mg_50k.SelectedIndex = 0
        Me.tc_mg_50k.Size = New System.Drawing.Size(365, 494)
        Me.tc_mg_50k.TabIndex = 0
        '
        'tab_mg_topologia
        '
        Me.tab_mg_topologia.Controls.Add(Me.TableLayoutPanel3)
        Me.tab_mg_topologia.ImageIndex = 16
        Me.tab_mg_topologia.Location = New System.Drawing.Point(4, 23)
        Me.tab_mg_topologia.Margin = New System.Windows.Forms.Padding(2)
        Me.tab_mg_topologia.Name = "tab_mg_topologia"
        Me.tab_mg_topologia.Padding = New System.Windows.Forms.Padding(2)
        Me.tab_mg_topologia.Size = New System.Drawing.Size(357, 467)
        Me.tab_mg_topologia.TabIndex = 0
        Me.tab_mg_topologia.Text = "Topología"
        Me.tab_mg_topologia.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.clb_mg_topologias, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.rbt_mg_seleccion, 0, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_mg_run_topology, 0, 8)
        Me.TableLayoutPanel3.Controls.Add(Me.rbt_mg_actual, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.btn_mg_SelectlayerByLocation, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.lbl_mg_topology_res, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 9
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(353, 463)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Location = New System.Drawing.Point(3, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(347, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccione el tipo de análisis"
        '
        'clb_mg_topologias
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.clb_mg_topologias, 2)
        Me.clb_mg_topologias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clb_mg_topologias.FormattingEnabled = True
        Me.clb_mg_topologias.Location = New System.Drawing.Point(3, 23)
        Me.clb_mg_topologias.Name = "clb_mg_topologias"
        Me.clb_mg_topologias.Size = New System.Drawing.Size(347, 74)
        Me.clb_mg_topologias.TabIndex = 4
        '
        'rbt_mg_seleccion
        '
        Me.rbt_mg_seleccion.AutoSize = True
        Me.rbt_mg_seleccion.Location = New System.Drawing.Point(3, 231)
        Me.rbt_mg_seleccion.Name = "rbt_mg_seleccion"
        Me.rbt_mg_seleccion.Size = New System.Drawing.Size(180, 17)
        Me.rbt_mg_seleccion.TabIndex = 5
        Me.rbt_mg_seleccion.Text = "Seleccionar hojas espacialmente"
        Me.rbt_mg_seleccion.UseVisualStyleBackColor = True
        Me.rbt_mg_seleccion.Visible = False
        '
        'btn_mg_run_topology
        '
        Me.TableLayoutPanel3.SetColumnSpan(Me.btn_mg_run_topology, 2)
        Me.btn_mg_run_topology.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mg_run_topology.ImageIndex = 16
        Me.btn_mg_run_topology.ImageList = Me.ilist_mg_50k
        Me.btn_mg_run_topology.Location = New System.Drawing.Point(3, 436)
        Me.btn_mg_run_topology.Name = "btn_mg_run_topology"
        Me.btn_mg_run_topology.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_mg_run_topology.Size = New System.Drawing.Size(347, 24)
        Me.btn_mg_run_topology.TabIndex = 6
        Me.btn_mg_run_topology.Text = "Aplicar topología"
        Me.btn_mg_run_topology.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mg_run_topology.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_mg_run_topology.UseVisualStyleBackColor = True
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
        Me.ilist_mg_50k.Images.SetKeyName(7, "Legend16.png")
        Me.ilist_mg_50k.Images.SetKeyName(8, "3DAnalystInterpolateProfileGraphCreate16.png")
        Me.ilist_mg_50k.Images.SetKeyName(9, "ArcGlobe16.png")
        Me.ilist_mg_50k.Images.SetKeyName(10, "GeodatabaseAdd16.png")
        Me.ilist_mg_50k.Images.SetKeyName(11, "EditingBuffer16.png")
        Me.ilist_mg_50k.Images.SetKeyName(12, "ElementMakeSameHeight.ico")
        Me.ilist_mg_50k.Images.SetKeyName(13, "GeodatabaseRasterGrid16.png")
        Me.ilist_mg_50k.Images.SetKeyName(14, "ElementLineSegmentBlack.ico")
        Me.ilist_mg_50k.Images.SetKeyName(15, "SelectionSelectTool16.png")
        Me.ilist_mg_50k.Images.SetKeyName(16, "GeodatabaseTopology16.png")
        Me.ilist_mg_50k.Images.SetKeyName(17, "GenericFilterByLayerChecked16.png")
        '
        'rbt_mg_actual
        '
        Me.rbt_mg_actual.AutoSize = True
        Me.rbt_mg_actual.Checked = True
        Me.rbt_mg_actual.Location = New System.Drawing.Point(3, 208)
        Me.rbt_mg_actual.Name = "rbt_mg_actual"
        Me.rbt_mg_actual.Size = New System.Drawing.Size(138, 17)
        Me.rbt_mg_actual.TabIndex = 7
        Me.rbt_mg_actual.TabStop = True
        Me.rbt_mg_actual.Text = "Aplicar en la hoja actual"
        Me.rbt_mg_actual.UseVisualStyleBackColor = True
        Me.rbt_mg_actual.Visible = False
        '
        'btn_mg_SelectlayerByLocation
        '
        Me.btn_mg_SelectlayerByLocation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mg_SelectlayerByLocation.Enabled = False
        Me.btn_mg_SelectlayerByLocation.ImageIndex = 15
        Me.btn_mg_SelectlayerByLocation.ImageList = Me.ilist_mg_50k
        Me.btn_mg_SelectlayerByLocation.Location = New System.Drawing.Point(317, 231)
        Me.btn_mg_SelectlayerByLocation.Name = "btn_mg_SelectlayerByLocation"
        Me.TableLayoutPanel3.SetRowSpan(Me.btn_mg_SelectlayerByLocation, 2)
        Me.btn_mg_SelectlayerByLocation.Size = New System.Drawing.Size(33, 29)
        Me.btn_mg_SelectlayerByLocation.TabIndex = 8
        Me.btn_mg_SelectlayerByLocation.UseVisualStyleBackColor = True
        Me.btn_mg_SelectlayerByLocation.Visible = False
        '
        'tb_mg_query
        '
        Me.tb_mg_query.ImageIndex = 17
        Me.tb_mg_query.Location = New System.Drawing.Point(4, 23)
        Me.tb_mg_query.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_mg_query.Name = "tb_mg_query"
        Me.tb_mg_query.Padding = New System.Windows.Forms.Padding(2)
        Me.tb_mg_query.Size = New System.Drawing.Size(357, 467)
        Me.tb_mg_query.TabIndex = 1
        Me.tb_mg_query.Text = "Consulta"
        Me.tb_mg_query.UseVisualStyleBackColor = True
        '
        'tb_mg_perfil
        '
        Me.tb_mg_perfil.Controls.Add(Me.TableLayoutPanel2)
        Me.tb_mg_perfil.ImageIndex = 8
        Me.tb_mg_perfil.Location = New System.Drawing.Point(4, 23)
        Me.tb_mg_perfil.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_mg_perfil.Name = "tb_mg_perfil"
        Me.tb_mg_perfil.Size = New System.Drawing.Size(357, 467)
        Me.tb_mg_perfil.TabIndex = 3
        Me.tb_mg_perfil.Text = "Sección"
        Me.tb_mg_perfil.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_mg_pathdata, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mg_loaddata, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_mg_cargar_dem, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mg_drawline, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mp_seccion, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.nud_mg_tolerancia, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_mg_tolerancia, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.nud_mg_altura, 1, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 8
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(357, 467)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'tbx_mg_pathdata
        '
        Me.tbx_mg_pathdata.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_mg_pathdata.Enabled = False
        Me.tbx_mg_pathdata.Location = New System.Drawing.Point(2, 22)
        Me.tbx_mg_pathdata.Margin = New System.Windows.Forms.Padding(2)
        Me.tbx_mg_pathdata.Name = "tbx_mg_pathdata"
        Me.tbx_mg_pathdata.Size = New System.Drawing.Size(293, 20)
        Me.tbx_mg_pathdata.TabIndex = 0
        '
        'btn_mg_loaddata
        '
        Me.btn_mg_loaddata.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mg_loaddata.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mg_loaddata.Location = New System.Drawing.Point(299, 22)
        Me.btn_mg_loaddata.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_mg_loaddata.Name = "btn_mg_loaddata"
        Me.btn_mg_loaddata.Size = New System.Drawing.Size(56, 20)
        Me.btn_mg_loaddata.TabIndex = 3
        Me.btn_mg_loaddata.Text = "..."
        Me.btn_mg_loaddata.UseVisualStyleBackColor = True
        '
        'lbl_mg_cargar_dem
        '
        Me.lbl_mg_cargar_dem.AutoSize = True
        Me.lbl_mg_cargar_dem.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_mg_cargar_dem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_mg_cargar_dem.ImageIndex = 13
        Me.lbl_mg_cargar_dem.ImageList = Me.ilist_mg_50k
        Me.lbl_mg_cargar_dem.Location = New System.Drawing.Point(2, 7)
        Me.lbl_mg_cargar_dem.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mg_cargar_dem.Name = "lbl_mg_cargar_dem"
        Me.lbl_mg_cargar_dem.Size = New System.Drawing.Size(293, 13)
        Me.lbl_mg_cargar_dem.TabIndex = 4
        Me.lbl_mg_cargar_dem.Text = "Cargar DEM"
        '
        'btn_mg_drawline
        '
        Me.btn_mg_drawline.BackColor = System.Drawing.SystemColors.Control
        Me.btn_mg_drawline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mg_drawline.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mg_drawline.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mg_drawline.ImageIndex = 14
        Me.btn_mg_drawline.ImageList = Me.ilist_mg_50k
        Me.btn_mg_drawline.Location = New System.Drawing.Point(299, 94)
        Me.btn_mg_drawline.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_mg_drawline.Name = "btn_mg_drawline"
        Me.btn_mg_drawline.Size = New System.Drawing.Size(56, 28)
        Me.btn_mg_drawline.TabIndex = 5
        Me.btn_mg_drawline.UseVisualStyleBackColor = False
        '
        'btn_mp_seccion
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btn_mp_seccion, 2)
        Me.btn_mp_seccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mp_seccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mp_seccion.ImageKey = "3DAnalystInterpolateProfileGraphCreate16.png"
        Me.btn_mp_seccion.ImageList = Me.ilist_mg_50k
        Me.btn_mp_seccion.Location = New System.Drawing.Point(2, 441)
        Me.btn_mp_seccion.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_mp_seccion.Name = "btn_mp_seccion"
        Me.btn_mp_seccion.Size = New System.Drawing.Size(353, 24)
        Me.btn_mp_seccion.TabIndex = 6
        Me.btn_mp_seccion.Text = "Generar sección geológica"
        Me.btn_mp_seccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mp_seccion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_mp_seccion.UseVisualStyleBackColor = True
        '
        'nud_mg_tolerancia
        '
        Me.nud_mg_tolerancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nud_mg_tolerancia.Location = New System.Drawing.Point(299, 46)
        Me.nud_mg_tolerancia.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_mg_tolerancia.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nud_mg_tolerancia.Name = "nud_mg_tolerancia"
        Me.nud_mg_tolerancia.Size = New System.Drawing.Size(56, 20)
        Me.nud_mg_tolerancia.TabIndex = 8
        Me.nud_mg_tolerancia.Value = New Decimal(New Integer() {150, 0, 0, 0})
        '
        'lbl_mg_tolerancia
        '
        Me.lbl_mg_tolerancia.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_mg_tolerancia.AutoSize = True
        Me.lbl_mg_tolerancia.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_mg_tolerancia.ImageIndex = 11
        Me.lbl_mg_tolerancia.ImageList = Me.ilist_mg_50k
        Me.lbl_mg_tolerancia.Location = New System.Drawing.Point(2, 49)
        Me.lbl_mg_tolerancia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mg_tolerancia.Name = "lbl_mg_tolerancia"
        Me.lbl_mg_tolerancia.Size = New System.Drawing.Size(293, 13)
        Me.lbl_mg_tolerancia.TabIndex = 7
        Me.lbl_mg_tolerancia.Text = "Establecer radio de búsqueda de POG's (m)"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.ImageIndex = 12
        Me.Label1.ImageList = Me.ilist_mg_50k
        Me.Label1.Location = New System.Drawing.Point(2, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Establecer altura de inicio (m)"
        '
        'nud_mg_altura
        '
        Me.nud_mg_altura.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nud_mg_altura.Increment = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nud_mg_altura.Location = New System.Drawing.Point(299, 70)
        Me.nud_mg_altura.Margin = New System.Windows.Forms.Padding(2)
        Me.nud_mg_altura.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.nud_mg_altura.Minimum = New Decimal(New Integer() {5000, 0, 0, -2147483648})
        Me.nud_mg_altura.Name = "nud_mg_altura"
        Me.nud_mg_altura.Size = New System.Drawing.Size(56, 20)
        Me.nud_mg_altura.TabIndex = 10
        '
        'tb_mg_mapa
        '
        Me.tb_mg_mapa.ImageIndex = 9
        Me.tb_mg_mapa.Location = New System.Drawing.Point(4, 23)
        Me.tb_mg_mapa.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_mg_mapa.Name = "tb_mg_mapa"
        Me.tb_mg_mapa.Size = New System.Drawing.Size(357, 467)
        Me.tb_mg_mapa.TabIndex = 2
        Me.tb_mg_mapa.Text = "Mapa Geológico"
        Me.tb_mg_mapa.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
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
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(369, 566)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'cbx_mg_fila
        '
        Me.cbx_mg_fila.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_mg_fila.Enabled = False
        Me.cbx_mg_fila.FormattingEnabled = True
        Me.cbx_mg_fila.Location = New System.Drawing.Point(67, 11)
        Me.cbx_mg_fila.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_mg_fila.Name = "cbx_mg_fila"
        Me.cbx_mg_fila.Size = New System.Drawing.Size(34, 21)
        Me.cbx_mg_fila.TabIndex = 1
        '
        'cbx_mg_col
        '
        Me.cbx_mg_col.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_mg_col.Enabled = False
        Me.cbx_mg_col.FormattingEnabled = True
        Me.cbx_mg_col.Location = New System.Drawing.Point(183, 11)
        Me.cbx_mg_col.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_mg_col.Name = "cbx_mg_col"
        Me.cbx_mg_col.Size = New System.Drawing.Size(34, 21)
        Me.cbx_mg_col.TabIndex = 2
        '
        'cbx_mg_cuad
        '
        Me.cbx_mg_cuad.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_mg_cuad.Enabled = False
        Me.cbx_mg_cuad.FormattingEnabled = True
        Me.cbx_mg_cuad.Location = New System.Drawing.Point(299, 11)
        Me.cbx_mg_cuad.Margin = New System.Windows.Forms.Padding(2)
        Me.cbx_mg_cuad.Name = "cbx_mg_cuad"
        Me.cbx_mg_cuad.Size = New System.Drawing.Size(34, 21)
        Me.cbx_mg_cuad.TabIndex = 3
        '
        'lbl_dato_hoja
        '
        Me.lbl_dato_hoja.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.lbl_dato_hoja, 7)
        Me.lbl_dato_hoja.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_dato_hoja.Location = New System.Drawing.Point(2, 51)
        Me.lbl_dato_hoja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_dato_hoja.Name = "lbl_dato_hoja"
        Me.lbl_dato_hoja.Size = New System.Drawing.Size(331, 13)
        Me.lbl_dato_hoja.TabIndex = 5
        Me.lbl_dato_hoja.Text = "..."
        '
        'lbl_mg_fila
        '
        Me.lbl_mg_fila.AutoSize = True
        Me.lbl_mg_fila.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_mg_fila.Location = New System.Drawing.Point(28, 8)
        Me.lbl_mg_fila.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mg_fila.Name = "lbl_mg_fila"
        Me.lbl_mg_fila.Size = New System.Drawing.Size(35, 28)
        Me.lbl_mg_fila.TabIndex = 6
        Me.lbl_mg_fila.Text = "Fila"
        Me.lbl_mg_fila.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mg_col
        '
        Me.lbl_mg_col.AutoSize = True
        Me.lbl_mg_col.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_mg_col.Location = New System.Drawing.Point(105, 8)
        Me.lbl_mg_col.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mg_col.Name = "lbl_mg_col"
        Me.lbl_mg_col.Size = New System.Drawing.Size(74, 28)
        Me.lbl_mg_col.TabIndex = 7
        Me.lbl_mg_col.Text = "Columna"
        Me.lbl_mg_col.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_mg_cuad
        '
        Me.lbl_mg_cuad.AutoSize = True
        Me.lbl_mg_cuad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_mg_cuad.Location = New System.Drawing.Point(221, 8)
        Me.lbl_mg_cuad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_mg_cuad.Name = "lbl_mg_cuad"
        Me.lbl_mg_cuad.Size = New System.Drawing.Size(74, 28)
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
        Me.btn_load_code.ImageIndex = 15
        Me.btn_load_code.ImageList = Me.ilist_mg_50k
        Me.btn_load_code.Location = New System.Drawing.Point(341, 10)
        Me.btn_load_code.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_load_code.Name = "btn_load_code"
        Me.btn_load_code.Size = New System.Drawing.Size(26, 24)
        Me.btn_load_code.TabIndex = 9
        Me.btn_load_code.UseVisualStyleBackColor = False
        '
        'btn_load_gdb
        '
        Me.btn_load_gdb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_load_gdb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_load_gdb.ImageIndex = 10
        Me.btn_load_gdb.ImageList = Me.ilist_mg_50k
        Me.btn_load_gdb.Location = New System.Drawing.Point(2, 10)
        Me.btn_load_gdb.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_load_gdb.Name = "btn_load_gdb"
        Me.btn_load_gdb.Size = New System.Drawing.Size(22, 24)
        Me.btn_load_gdb.TabIndex = 10
        Me.btn_load_gdb.UseVisualStyleBackColor = True
        '
        'lbl_mg_topology_res
        '
        Me.lbl_mg_topology_res.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.lbl_mg_topology_res, 2)
        Me.lbl_mg_topology_res.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_mg_topology_res.Location = New System.Drawing.Point(3, 105)
        Me.lbl_mg_topology_res.Name = "lbl_mg_topology_res"
        Me.lbl_mg_topology_res.Size = New System.Drawing.Size(347, 13)
        Me.lbl_mg_topology_res.TabIndex = 9
        Me.lbl_mg_topology_res.Text = "..."
        '
        'Form_mapa_geologico_50k
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 566)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form_mapa_geologico_50k"
        Me.Text = "Form_mapa_geologico_50k"
        Me.tc_mg_50k.ResumeLayout(False)
        Me.tab_mg_topologia.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.tb_mg_perfil.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.nud_mg_tolerancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nud_mg_altura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tc_mg_50k As System.Windows.Forms.TabControl
    Friend WithEvents tab_mg_topologia As System.Windows.Forms.TabPage
    Friend WithEvents tb_mg_query As System.Windows.Forms.TabPage
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nud_mg_altura As System.Windows.Forms.NumericUpDown
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clb_mg_topologias As System.Windows.Forms.CheckedListBox
    Friend WithEvents rbt_mg_seleccion As System.Windows.Forms.RadioButton
    Friend WithEvents btn_mg_run_topology As System.Windows.Forms.Button
    Friend WithEvents rbt_mg_actual As System.Windows.Forms.RadioButton
    Friend WithEvents btn_mg_SelectlayerByLocation As System.Windows.Forms.Button
    Friend WithEvents lbl_mg_topology_res As System.Windows.Forms.Label
End Class
