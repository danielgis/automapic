<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_mapa_peligros_geologicos
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_loadshp = New System.Windows.Forms.Label()
        Me.tbx_pathshp = New System.Windows.Forms.TextBox()
        Me.btn_loadshp = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_title_pg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbx_autor_pg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbx_escala_pg = New System.Windows.Forms.TextBox()
        Me.tbx_detalle_pg = New System.Windows.Forms.TextBox()
        Me.tbx_detalle = New System.Windows.Forms.Label()
        Me.rbt_pg = New System.Windows.Forms.RadioButton()
        Me.rbt_zc = New System.Windows.Forms.RadioButton()
        Me.rbt_smm = New System.Windows.Forms.RadioButton()
        Me.rbt_sief = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbx_numero_pg = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_generar_mapa_pg = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbx_xmin = New System.Windows.Forms.TextBox()
        Me.tbx_ymin = New System.Windows.Forms.TextBox()
        Me.tbx_xmax = New System.Windows.Forms.TextBox()
        Me.tbx_ymax = New System.Windows.Forms.TextBox()
        Me.lbl_xmin = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_draw = New System.Windows.Forms.Button()
        Me.btn_pg_export = New System.Windows.Forms.Button()
        Me.btn_blank_extent = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.tbx_numero_pg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_loadshp, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_pathshp, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_loadshp, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_title_pg, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_autor_pg, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_escala_pg, 0, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_detalle_pg, 0, 17)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_detalle, 0, 16)
        Me.TableLayoutPanel1.Controls.Add(Me.rbt_pg, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.rbt_zc, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.rbt_smm, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.rbt_sief, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_numero_pg, 1, 15)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_generar_mapa_pg, 0, 21)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_draw, 1, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 18)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_pg_export, 1, 19)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_blank_extent, 0, 19)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 23
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 677)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_loadshp
        '
        Me.lbl_loadshp.AutoSize = True
        Me.lbl_loadshp.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_loadshp.Location = New System.Drawing.Point(3, 13)
        Me.lbl_loadshp.Name = "lbl_loadshp"
        Me.lbl_loadshp.Size = New System.Drawing.Size(324, 17)
        Me.lbl_loadshp.TabIndex = 0
        Me.lbl_loadshp.Text = "Cargar shapefile"
        '
        'tbx_pathshp
        '
        Me.tbx_pathshp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_pathshp.Enabled = False
        Me.tbx_pathshp.Location = New System.Drawing.Point(3, 34)
        Me.tbx_pathshp.Name = "tbx_pathshp"
        Me.tbx_pathshp.Size = New System.Drawing.Size(324, 22)
        Me.tbx_pathshp.TabIndex = 1
        '
        'btn_loadshp
        '
        Me.btn_loadshp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_loadshp.Location = New System.Drawing.Point(333, 33)
        Me.btn_loadshp.Name = "btn_loadshp"
        Me.btn_loadshp.Size = New System.Drawing.Size(74, 24)
        Me.btn_loadshp.TabIndex = 2
        Me.btn_loadshp.Text = "..."
        Me.btn_loadshp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_loadshp.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(3, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(324, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre del sector o zona evaluada"
        '
        'tbx_title_pg
        '
        Me.tbx_title_pg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbx_title_pg, 2)
        Me.tbx_title_pg.Location = New System.Drawing.Point(3, 244)
        Me.tbx_title_pg.Name = "tbx_title_pg"
        Me.tbx_title_pg.Size = New System.Drawing.Size(404, 22)
        Me.tbx_title_pg.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(3, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Autor"
        '
        'tbx_autor_pg
        '
        Me.tbx_autor_pg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbx_autor_pg, 2)
        Me.tbx_autor_pg.Location = New System.Drawing.Point(3, 294)
        Me.tbx_autor_pg.Name = "tbx_autor_pg"
        Me.tbx_autor_pg.Size = New System.Drawing.Size(404, 22)
        Me.tbx_autor_pg.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(3, 323)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Escala"
        '
        'tbx_escala_pg
        '
        Me.tbx_escala_pg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_escala_pg.Location = New System.Drawing.Point(3, 344)
        Me.tbx_escala_pg.Name = "tbx_escala_pg"
        Me.tbx_escala_pg.Size = New System.Drawing.Size(324, 22)
        Me.tbx_escala_pg.TabIndex = 8
        '
        'tbx_detalle_pg
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbx_detalle_pg, 2)
        Me.tbx_detalle_pg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_detalle_pg.Enabled = False
        Me.tbx_detalle_pg.Location = New System.Drawing.Point(3, 393)
        Me.tbx_detalle_pg.Multiline = True
        Me.tbx_detalle_pg.Name = "tbx_detalle_pg"
        Me.tbx_detalle_pg.Size = New System.Drawing.Size(404, 114)
        Me.tbx_detalle_pg.TabIndex = 9
        '
        'tbx_detalle
        '
        Me.tbx_detalle.AutoSize = True
        Me.tbx_detalle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tbx_detalle.Location = New System.Drawing.Point(3, 373)
        Me.tbx_detalle.Name = "tbx_detalle"
        Me.tbx_detalle.Size = New System.Drawing.Size(324, 17)
        Me.tbx_detalle.TabIndex = 10
        Me.tbx_detalle.Text = "Detalle"
        '
        'rbt_pg
        '
        Me.rbt_pg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbt_pg.AutoSize = True
        Me.rbt_pg.Location = New System.Drawing.Point(3, 94)
        Me.rbt_pg.Name = "rbt_pg"
        Me.rbt_pg.Size = New System.Drawing.Size(324, 21)
        Me.rbt_pg.TabIndex = 11
        Me.rbt_pg.TabStop = True
        Me.rbt_pg.Text = "Peligros geológicos"
        Me.rbt_pg.UseVisualStyleBackColor = True
        '
        'rbt_zc
        '
        Me.rbt_zc.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbt_zc.AutoSize = True
        Me.rbt_zc.Location = New System.Drawing.Point(3, 124)
        Me.rbt_zc.Name = "rbt_zc"
        Me.rbt_zc.Size = New System.Drawing.Size(324, 21)
        Me.rbt_zc.TabIndex = 12
        Me.rbt_zc.TabStop = True
        Me.rbt_zc.Text = "Zonas críticas"
        Me.rbt_zc.UseVisualStyleBackColor = True
        '
        'rbt_smm
        '
        Me.rbt_smm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbt_smm.AutoSize = True
        Me.rbt_smm.Location = New System.Drawing.Point(3, 154)
        Me.rbt_smm.Name = "rbt_smm"
        Me.rbt_smm.Size = New System.Drawing.Size(324, 21)
        Me.rbt_smm.TabIndex = 13
        Me.rbt_smm.TabStop = True
        Me.rbt_smm.Text = "Susceptibilidad por movimientos en masa"
        Me.rbt_smm.UseVisualStyleBackColor = True
        '
        'rbt_sief
        '
        Me.rbt_sief.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbt_sief.AutoSize = True
        Me.rbt_sief.Location = New System.Drawing.Point(3, 184)
        Me.rbt_sief.Name = "rbt_sief"
        Me.rbt_sief.Size = New System.Drawing.Size(324, 21)
        Me.rbt_sief.TabIndex = 14
        Me.rbt_sief.TabStop = True
        Me.rbt_sief.Text = "Susceptibilidad por inundación y erosión"
        Me.rbt_sief.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(3, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(324, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Seleccione tipo de mapa"
        '
        'tbx_numero_pg
        '
        Me.tbx_numero_pg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_numero_pg.Location = New System.Drawing.Point(333, 344)
        Me.tbx_numero_pg.Name = "tbx_numero_pg"
        Me.tbx_numero_pg.Size = New System.Drawing.Size(74, 22)
        Me.tbx_numero_pg.TabIndex = 16
        Me.tbx_numero_pg.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label6.Location = New System.Drawing.Point(333, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nro"
        '
        'btn_generar_mapa_pg
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btn_generar_mapa_pg, 2)
        Me.btn_generar_mapa_pg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_generar_mapa_pg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_generar_mapa_pg.Enabled = False
        Me.btn_generar_mapa_pg.Location = New System.Drawing.Point(3, 635)
        Me.btn_generar_mapa_pg.Name = "btn_generar_mapa_pg"
        Me.btn_generar_mapa_pg.Size = New System.Drawing.Size(404, 29)
        Me.btn_generar_mapa_pg.TabIndex = 19
        Me.btn_generar_mapa_pg.Text = "Generar mapa"
        Me.btn_generar_mapa_pg.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 4
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_xmin, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_ymin, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_xmax, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_ymax, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_xmin, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label8, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 3, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 513)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(324, 49)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'tbx_xmin
        '
        Me.tbx_xmin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_xmin.Enabled = False
        Me.tbx_xmin.Location = New System.Drawing.Point(3, 23)
        Me.tbx_xmin.Name = "tbx_xmin"
        Me.tbx_xmin.Size = New System.Drawing.Size(75, 22)
        Me.tbx_xmin.TabIndex = 0
        Me.tbx_xmin.Text = "0"
        '
        'tbx_ymin
        '
        Me.tbx_ymin.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_ymin.Enabled = False
        Me.tbx_ymin.Location = New System.Drawing.Point(84, 23)
        Me.tbx_ymin.Name = "tbx_ymin"
        Me.tbx_ymin.Size = New System.Drawing.Size(75, 22)
        Me.tbx_ymin.TabIndex = 1
        Me.tbx_ymin.Text = "0"
        '
        'tbx_xmax
        '
        Me.tbx_xmax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_xmax.Enabled = False
        Me.tbx_xmax.Location = New System.Drawing.Point(165, 23)
        Me.tbx_xmax.Name = "tbx_xmax"
        Me.tbx_xmax.Size = New System.Drawing.Size(75, 22)
        Me.tbx_xmax.TabIndex = 2
        Me.tbx_xmax.Text = "0"
        '
        'tbx_ymax
        '
        Me.tbx_ymax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_ymax.Enabled = False
        Me.tbx_ymax.Location = New System.Drawing.Point(246, 23)
        Me.tbx_ymax.Name = "tbx_ymax"
        Me.tbx_ymax.Size = New System.Drawing.Size(75, 22)
        Me.tbx_ymax.TabIndex = 3
        Me.tbx_ymax.Text = "0"
        '
        'lbl_xmin
        '
        Me.lbl_xmin.AutoSize = True
        Me.lbl_xmin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_xmin.Location = New System.Drawing.Point(3, 3)
        Me.lbl_xmin.Name = "lbl_xmin"
        Me.lbl_xmin.Size = New System.Drawing.Size(75, 17)
        Me.lbl_xmin.TabIndex = 4
        Me.lbl_xmin.Text = "xmin"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label7.Location = New System.Drawing.Point(84, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 17)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ymin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label8.Location = New System.Drawing.Point(165, 3)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "xmax"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label9.Location = New System.Drawing.Point(246, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "ymax"
        '
        'btn_draw
        '
        Me.btn_draw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_draw.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_draw.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_draw.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_draw.Image = Global.Automapic.My.Resources.Resources.EditingCopyFeaturesTool32
        Me.btn_draw.Location = New System.Drawing.Point(333, 513)
        Me.btn_draw.Name = "btn_draw"
        Me.btn_draw.Size = New System.Drawing.Size(74, 49)
        Me.btn_draw.TabIndex = 20
        Me.btn_draw.UseVisualStyleBackColor = True
        '
        'btn_pg_export
        '
        Me.btn_pg_export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pg_export.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.btn_pg_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pg_export.Image = Global.Automapic.My.Resources.Resources.MapPackageMPKFile32
        Me.btn_pg_export.Location = New System.Drawing.Point(333, 568)
        Me.btn_pg_export.Name = "btn_pg_export"
        Me.btn_pg_export.Size = New System.Drawing.Size(74, 39)
        Me.btn_pg_export.TabIndex = 18
        Me.btn_pg_export.UseVisualStyleBackColor = True
        '
        'btn_blank_extent
        '
        Me.btn_blank_extent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_blank_extent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_blank_extent.Image = Global.Automapic.My.Resources.Resources.RepresentationEraseTool32
        Me.btn_blank_extent.Location = New System.Drawing.Point(3, 568)
        Me.btn_blank_extent.Name = "btn_blank_extent"
        Me.btn_blank_extent.Size = New System.Drawing.Size(75, 39)
        Me.btn_blank_extent.TabIndex = 22
        Me.btn_blank_extent.UseVisualStyleBackColor = True
        '
        'Form_mapa_peligros_geologicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(0, 600)
        Me.ClientSize = New System.Drawing.Size(410, 677)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_mapa_peligros_geologicos"
        Me.Text = "Form_mapa_peligros_geologicos"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.tbx_numero_pg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_loadshp As System.Windows.Forms.Label
    Friend WithEvents tbx_pathshp As System.Windows.Forms.TextBox
    Friend WithEvents btn_loadshp As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_title_pg As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_autor_pg As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbx_escala_pg As System.Windows.Forms.TextBox
    Friend WithEvents tbx_detalle_pg As System.Windows.Forms.TextBox
    Friend WithEvents tbx_detalle As System.Windows.Forms.Label
    Friend WithEvents rbt_pg As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_zc As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_smm As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_sief As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbx_numero_pg As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_pg_export As System.Windows.Forms.Button
    Friend WithEvents btn_generar_mapa_pg As System.Windows.Forms.Button
    Friend WithEvents btn_draw As System.Windows.Forms.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbx_xmin As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ymin As System.Windows.Forms.TextBox
    Friend WithEvents tbx_xmax As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ymax As System.Windows.Forms.TextBox
    Friend WithEvents lbl_xmin As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_blank_extent As System.Windows.Forms.Button
End Class
