<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_mapa_hidrogeologico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_mapa_hidrogeologico))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_mh_cuencas = New System.Windows.Forms.ComboBox()
        Me.lbx_mh_cuencas = New System.Windows.Forms.ListBox()
        Me.lbl_mh_nota1 = New System.Windows.Forms.Label()
        Me.lbl_mh_cuenca = New System.Windows.Forms.Label()
        Me.tc_mh_tools = New System.Windows.Forms.TabControl()
        Me.tp_mh_rotulo = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.clb_mh_autores = New System.Windows.Forms.CheckedListBox()
        Me.lbl_mh_autor = New System.Windows.Forms.Label()
        Me.img_list_mh = New System.Windows.Forms.ImageList(Me.components)
        Me.rbt_mh_pequenio = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_mh_autores = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbx_mh_title1 = New System.Windows.Forms.TextBox()
        Me.tbx_mh_title2 = New System.Windows.Forms.TextBox()
        Me.btn_mh_grotulo = New System.Windows.Forms.Button()
        Me.nud_mh_numero = New System.Windows.Forms.NumericUpDown()
        Me.lbl_mh_numero = New System.Windows.Forms.Label()
        Me.rbt_mh_grande = New System.Windows.Forms.RadioButton()
        Me.tp_mh_leyenda = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_mh_leyenda = New System.Windows.Forms.Button()
        Me.tc_mh_leyenda_tools = New System.Windows.Forms.TabControl()
        Me.tp_mh_classif = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgv_mh_leyenda = New System.Windows.Forms.DataGridView()
        Me.lbl_mh_uhcount = New System.Windows.Forms.Label()
        Me.tp_mh_dhidrog = New System.Windows.Forms.TabPage()
        Me.tlp_mh_dhidrog = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_mh_acuiferos = New System.Windows.Forms.Label()
        Me.lbl_mh_acuitardos = New System.Windows.Forms.Label()
        Me.lbl_mh_acuicludo = New System.Windows.Forms.Label()
        Me.lbl_mh___acuifugo = New System.Windows.Forms.Label()
        Me.tbx_mh_acuiferos = New System.Windows.Forms.TextBox()
        Me.tbx_mh_acuitardos = New System.Windows.Forms.TextBox()
        Me.tbx_mh_acuicludo = New System.Windows.Forms.TextBox()
        Me.tbx_mh_acuifugo = New System.Windows.Forms.TextBox()
        Me.UserControl_ComboBoxDatarames1 = New Automapic.UserControl_ComboBoxDatarames()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tc_mh_tools.SuspendLayout()
        Me.tp_mh_rotulo.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.nud_mh_numero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_mh_leyenda.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.tc_mh_leyenda_tools.SuspendLayout()
        Me.tp_mh_classif.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.dgv_mh_leyenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tp_mh_dhidrog.SuspendLayout()
        Me.tlp_mh_dhidrog.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_mh_cuencas, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lbx_mh_cuencas, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_mh_nota1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_mh_cuenca, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tc_mh_tools, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(463, 701)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'cbx_mh_cuencas
        '
        Me.cbx_mh_cuencas.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_mh_cuencas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbx_mh_cuencas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbx_mh_cuencas.FormattingEnabled = True
        Me.cbx_mh_cuencas.Location = New System.Drawing.Point(3, 28)
        Me.cbx_mh_cuencas.Name = "cbx_mh_cuencas"
        Me.cbx_mh_cuencas.Size = New System.Drawing.Size(457, 24)
        Me.cbx_mh_cuencas.TabIndex = 0
        '
        'lbx_mh_cuencas
        '
        Me.lbx_mh_cuencas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbx_mh_cuencas.FormattingEnabled = True
        Me.lbx_mh_cuencas.ItemHeight = 16
        Me.lbx_mh_cuencas.Location = New System.Drawing.Point(3, 58)
        Me.lbx_mh_cuencas.Name = "lbx_mh_cuencas"
        Me.lbx_mh_cuencas.Size = New System.Drawing.Size(457, 74)
        Me.lbx_mh_cuencas.TabIndex = 2
        '
        'lbl_mh_nota1
        '
        Me.lbl_mh_nota1.AutoSize = True
        Me.lbl_mh_nota1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_mh_nota1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_mh_nota1.Location = New System.Drawing.Point(3, 135)
        Me.lbl_mh_nota1.Name = "lbl_mh_nota1"
        Me.lbl_mh_nota1.Size = New System.Drawing.Size(457, 15)
        Me.lbl_mh_nota1.TabIndex = 3
        Me.lbl_mh_nota1.Text = "(*) Doble clic para eliminar item"
        Me.lbl_mh_nota1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lbl_mh_cuenca
        '
        Me.lbl_mh_cuenca.AutoSize = True
        Me.lbl_mh_cuenca.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_mh_cuenca.Location = New System.Drawing.Point(3, 8)
        Me.lbl_mh_cuenca.Name = "lbl_mh_cuenca"
        Me.lbl_mh_cuenca.Size = New System.Drawing.Size(457, 17)
        Me.lbl_mh_cuenca.TabIndex = 4
        Me.lbl_mh_cuenca.Text = "Seleccionar cuenca"
        '
        'tc_mh_tools
        '
        Me.tc_mh_tools.Controls.Add(Me.tp_mh_rotulo)
        Me.tc_mh_tools.Controls.Add(Me.tp_mh_leyenda)
        Me.tc_mh_tools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_mh_tools.ImageList = Me.img_list_mh
        Me.tc_mh_tools.Location = New System.Drawing.Point(3, 158)
        Me.tc_mh_tools.Name = "tc_mh_tools"
        Me.tc_mh_tools.SelectedIndex = 0
        Me.tc_mh_tools.Size = New System.Drawing.Size(457, 540)
        Me.tc_mh_tools.TabIndex = 5
        '
        'tp_mh_rotulo
        '
        Me.tp_mh_rotulo.Controls.Add(Me.TableLayoutPanel2)
        Me.tp_mh_rotulo.ImageIndex = 3
        Me.tp_mh_rotulo.Location = New System.Drawing.Point(4, 25)
        Me.tp_mh_rotulo.Name = "tp_mh_rotulo"
        Me.tp_mh_rotulo.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_mh_rotulo.Size = New System.Drawing.Size(449, 511)
        Me.tp_mh_rotulo.TabIndex = 0
        Me.tp_mh_rotulo.Text = "Rótulo"
        Me.tp_mh_rotulo.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.clb_mh_autores, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_mh_autor, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.rbt_mh_pequenio, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_mh_autores, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_mh_title1, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_mh_title2, 0, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mh_grotulo, 0, 13)
        Me.TableLayoutPanel2.Controls.Add(Me.nud_mh_numero, 2, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_mh_numero, 0, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.rbt_mh_grande, 1, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 14
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(443, 505)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'clb_mh_autores
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.clb_mh_autores, 3)
        Me.clb_mh_autores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clb_mh_autores.FormattingEnabled = True
        Me.clb_mh_autores.Location = New System.Drawing.Point(3, 73)
        Me.clb_mh_autores.MultiColumn = True
        Me.clb_mh_autores.Name = "clb_mh_autores"
        Me.clb_mh_autores.Size = New System.Drawing.Size(437, 144)
        Me.clb_mh_autores.TabIndex = 1
        '
        'lbl_mh_autor
        '
        Me.lbl_mh_autor.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_mh_autor, 3)
        Me.lbl_mh_autor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_mh_autor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_mh_autor.ImageIndex = 7
        Me.lbl_mh_autor.ImageList = Me.img_list_mh
        Me.lbl_mh_autor.Location = New System.Drawing.Point(3, 53)
        Me.lbl_mh_autor.Name = "lbl_mh_autor"
        Me.lbl_mh_autor.Size = New System.Drawing.Size(437, 17)
        Me.lbl_mh_autor.TabIndex = 0
        Me.lbl_mh_autor.Text = "Seleccione los autores"
        '
        'img_list_mh
        '
        Me.img_list_mh.ImageStream = CType(resources.GetObject("img_list_mh.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_list_mh.TransparentColor = System.Drawing.Color.Transparent
        Me.img_list_mh.Images.SetKeyName(0, "GeoprocessingFunction32.png")
        Me.img_list_mh.Images.SetKeyName(1, "ServiceProcessing16.png")
        Me.img_list_mh.Images.SetKeyName(2, "TabletPC32.png")
        Me.img_list_mh.Images.SetKeyName(3, "Apply_to_View16.png")
        Me.img_list_mh.Images.SetKeyName(4, "Apply_to_View24.png")
        Me.img_list_mh.Images.SetKeyName(5, "Apply_to_View32.png")
        Me.img_list_mh.Images.SetKeyName(6, "Legend16.png")
        Me.img_list_mh.Images.SetKeyName(7, "GenericCheckMarkSmall16.png")
        '
        'rbt_mh_pequenio
        '
        Me.rbt_mh_pequenio.AutoSize = True
        Me.rbt_mh_pequenio.Checked = True
        Me.rbt_mh_pequenio.Location = New System.Drawing.Point(3, 23)
        Me.rbt_mh_pequenio.Name = "rbt_mh_pequenio"
        Me.rbt_mh_pequenio.Size = New System.Drawing.Size(190, 19)
        Me.rbt_mh_pequenio.TabIndex = 2
        Me.rbt_mh_pequenio.TabStop = True
        Me.rbt_mh_pequenio.Text = "Pequeño (escala grande)"
        Me.rbt_mh_pequenio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label1, 3)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Seleccione tamaño de rotulo"
        '
        'tbx_mh_autores
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.tbx_mh_autores, 3)
        Me.tbx_mh_autores.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_mh_autores.Location = New System.Drawing.Point(3, 223)
        Me.tbx_mh_autores.Name = "tbx_mh_autores"
        Me.tbx_mh_autores.Size = New System.Drawing.Size(437, 22)
        Me.tbx_mh_autores.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label2, 3)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(3, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(437, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Título 1 (cuencas)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.Label3, 3)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(3, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(437, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Título 2 (tipo de mapa)"
        '
        'tbx_mh_title1
        '
        Me.tbx_mh_title1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.tbx_mh_title1, 3)
        Me.tbx_mh_title1.Location = New System.Drawing.Point(3, 274)
        Me.tbx_mh_title1.Name = "tbx_mh_title1"
        Me.tbx_mh_title1.Size = New System.Drawing.Size(437, 22)
        Me.tbx_mh_title1.TabIndex = 8
        '
        'tbx_mh_title2
        '
        Me.tbx_mh_title2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.tbx_mh_title2, 3)
        Me.tbx_mh_title2.Location = New System.Drawing.Point(3, 329)
        Me.tbx_mh_title2.Name = "tbx_mh_title2"
        Me.tbx_mh_title2.Size = New System.Drawing.Size(437, 22)
        Me.tbx_mh_title2.TabIndex = 9
        Me.tbx_mh_title2.Text = "Mapa Hidrogeológico"
        '
        'btn_mh_grotulo
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btn_mh_grotulo, 3)
        Me.btn_mh_grotulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mh_grotulo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btn_mh_grotulo.ImageIndex = 3
        Me.btn_mh_grotulo.ImageList = Me.img_list_mh
        Me.btn_mh_grotulo.Location = New System.Drawing.Point(3, 468)
        Me.btn_mh_grotulo.Name = "btn_mh_grotulo"
        Me.btn_mh_grotulo.Size = New System.Drawing.Size(437, 34)
        Me.btn_mh_grotulo.TabIndex = 10
        Me.btn_mh_grotulo.Text = "Generar rótulo"
        Me.btn_mh_grotulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mh_grotulo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_mh_grotulo.UseVisualStyleBackColor = True
        '
        'nud_mh_numero
        '
        Me.nud_mh_numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nud_mh_numero.DecimalPlaces = 1
        Me.nud_mh_numero.Location = New System.Drawing.Point(385, 359)
        Me.nud_mh_numero.Name = "nud_mh_numero"
        Me.nud_mh_numero.Size = New System.Drawing.Size(55, 22)
        Me.nud_mh_numero.TabIndex = 11
        '
        'lbl_mh_numero
        '
        Me.lbl_mh_numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_mh_numero.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.lbl_mh_numero, 2)
        Me.lbl_mh_numero.Location = New System.Drawing.Point(3, 361)
        Me.lbl_mh_numero.Name = "lbl_mh_numero"
        Me.lbl_mh_numero.Size = New System.Drawing.Size(376, 17)
        Me.lbl_mh_numero.TabIndex = 12
        Me.lbl_mh_numero.Text = "Especifique el número de mapa"
        '
        'rbt_mh_grande
        '
        Me.rbt_mh_grande.AutoSize = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.rbt_mh_grande, 2)
        Me.rbt_mh_grande.Dock = System.Windows.Forms.DockStyle.Left
        Me.rbt_mh_grande.Location = New System.Drawing.Point(203, 23)
        Me.rbt_mh_grande.Name = "rbt_mh_grande"
        Me.rbt_mh_grande.Size = New System.Drawing.Size(192, 19)
        Me.rbt_mh_grande.TabIndex = 3
        Me.rbt_mh_grande.Text = "Grande (escala pequeña)"
        Me.rbt_mh_grande.UseVisualStyleBackColor = True
        '
        'tp_mh_leyenda
        '
        Me.tp_mh_leyenda.AutoScroll = True
        Me.tp_mh_leyenda.Controls.Add(Me.TableLayoutPanel3)
        Me.tp_mh_leyenda.ImageIndex = 6
        Me.tp_mh_leyenda.Location = New System.Drawing.Point(4, 25)
        Me.tp_mh_leyenda.Name = "tp_mh_leyenda"
        Me.tp_mh_leyenda.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_mh_leyenda.Size = New System.Drawing.Size(449, 511)
        Me.tp_mh_leyenda.TabIndex = 1
        Me.tp_mh_leyenda.Text = "Leyenda"
        Me.tp_mh_leyenda.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btn_mh_leyenda, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.tc_mh_leyenda_tools, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.UserControl_ComboBoxDatarames1, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(443, 505)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'btn_mh_leyenda
        '
        Me.btn_mh_leyenda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mh_leyenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mh_leyenda.ImageIndex = 6
        Me.btn_mh_leyenda.ImageList = Me.img_list_mh
        Me.btn_mh_leyenda.Location = New System.Drawing.Point(3, 468)
        Me.btn_mh_leyenda.Name = "btn_mh_leyenda"
        Me.btn_mh_leyenda.Size = New System.Drawing.Size(437, 34)
        Me.btn_mh_leyenda.TabIndex = 0
        Me.btn_mh_leyenda.Text = "Generar Leyenda"
        Me.btn_mh_leyenda.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mh_leyenda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_mh_leyenda.UseVisualStyleBackColor = True
        '
        'tc_mh_leyenda_tools
        '
        Me.tc_mh_leyenda_tools.Controls.Add(Me.tp_mh_classif)
        Me.tc_mh_leyenda_tools.Controls.Add(Me.tp_mh_dhidrog)
        Me.tc_mh_leyenda_tools.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_mh_leyenda_tools.Location = New System.Drawing.Point(3, 3)
        Me.tc_mh_leyenda_tools.Name = "tc_mh_leyenda_tools"
        Me.tc_mh_leyenda_tools.SelectedIndex = 0
        Me.tc_mh_leyenda_tools.Size = New System.Drawing.Size(437, 399)
        Me.tc_mh_leyenda_tools.TabIndex = 0
        '
        'tp_mh_classif
        '
        Me.tp_mh_classif.Controls.Add(Me.TableLayoutPanel4)
        Me.tp_mh_classif.Location = New System.Drawing.Point(4, 25)
        Me.tp_mh_classif.Name = "tp_mh_classif"
        Me.tp_mh_classif.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_mh_classif.Size = New System.Drawing.Size(429, 370)
        Me.tp_mh_classif.TabIndex = 0
        Me.tp_mh_classif.Text = "Clasificación"
        Me.tp_mh_classif.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.dgv_mh_leyenda, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lbl_mh_uhcount, 0, 1)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(423, 364)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'dgv_mh_leyenda
        '
        Me.dgv_mh_leyenda.AllowUserToAddRows = False
        Me.dgv_mh_leyenda.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgv_mh_leyenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_mh_leyenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_mh_leyenda.Location = New System.Drawing.Point(3, 3)
        Me.dgv_mh_leyenda.Name = "dgv_mh_leyenda"
        Me.dgv_mh_leyenda.RowTemplate.Height = 24
        Me.dgv_mh_leyenda.Size = New System.Drawing.Size(417, 333)
        Me.dgv_mh_leyenda.TabIndex = 0
        '
        'lbl_mh_uhcount
        '
        Me.lbl_mh_uhcount.AutoSize = True
        Me.lbl_mh_uhcount.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_mh_uhcount.Location = New System.Drawing.Point(3, 347)
        Me.lbl_mh_uhcount.Name = "lbl_mh_uhcount"
        Me.lbl_mh_uhcount.Size = New System.Drawing.Size(417, 17)
        Me.lbl_mh_uhcount.TabIndex = 1
        Me.lbl_mh_uhcount.Text = "..."
        Me.lbl_mh_uhcount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tp_mh_dhidrog
        '
        Me.tp_mh_dhidrog.AutoScroll = True
        Me.tp_mh_dhidrog.AutoScrollMinSize = New System.Drawing.Size(0, 500)
        Me.tp_mh_dhidrog.Controls.Add(Me.tlp_mh_dhidrog)
        Me.tp_mh_dhidrog.Location = New System.Drawing.Point(4, 25)
        Me.tp_mh_dhidrog.Name = "tp_mh_dhidrog"
        Me.tp_mh_dhidrog.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_mh_dhidrog.Size = New System.Drawing.Size(429, 370)
        Me.tp_mh_dhidrog.TabIndex = 1
        Me.tp_mh_dhidrog.Text = "Descripción Hidrogeológica"
        Me.tp_mh_dhidrog.UseVisualStyleBackColor = True
        '
        'tlp_mh_dhidrog
        '
        Me.tlp_mh_dhidrog.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tlp_mh_dhidrog.ColumnCount = 1
        Me.tlp_mh_dhidrog.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_mh_dhidrog.Controls.Add(Me.lbl_mh_acuiferos, 0, 0)
        Me.tlp_mh_dhidrog.Controls.Add(Me.lbl_mh_acuitardos, 0, 2)
        Me.tlp_mh_dhidrog.Controls.Add(Me.lbl_mh_acuicludo, 0, 4)
        Me.tlp_mh_dhidrog.Controls.Add(Me.lbl_mh___acuifugo, 0, 6)
        Me.tlp_mh_dhidrog.Controls.Add(Me.tbx_mh_acuiferos, 0, 1)
        Me.tlp_mh_dhidrog.Controls.Add(Me.tbx_mh_acuitardos, 0, 3)
        Me.tlp_mh_dhidrog.Controls.Add(Me.tbx_mh_acuicludo, 0, 5)
        Me.tlp_mh_dhidrog.Controls.Add(Me.tbx_mh_acuifugo, 0, 7)
        Me.tlp_mh_dhidrog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_mh_dhidrog.Location = New System.Drawing.Point(3, 3)
        Me.tlp_mh_dhidrog.Name = "tlp_mh_dhidrog"
        Me.tlp_mh_dhidrog.RowCount = 9
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.tlp_mh_dhidrog.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_mh_dhidrog.Size = New System.Drawing.Size(402, 494)
        Me.tlp_mh_dhidrog.TabIndex = 0
        '
        'lbl_mh_acuiferos
        '
        Me.lbl_mh_acuiferos.AutoSize = True
        Me.lbl_mh_acuiferos.Location = New System.Drawing.Point(3, 0)
        Me.lbl_mh_acuiferos.Name = "lbl_mh_acuiferos"
        Me.lbl_mh_acuiferos.Size = New System.Drawing.Size(83, 17)
        Me.lbl_mh_acuiferos.TabIndex = 0
        Me.lbl_mh_acuiferos.Text = "1. Acuíferos"
        '
        'lbl_mh_acuitardos
        '
        Me.lbl_mh_acuitardos.AutoSize = True
        Me.lbl_mh_acuitardos.Location = New System.Drawing.Point(3, 120)
        Me.lbl_mh_acuitardos.Name = "lbl_mh_acuitardos"
        Me.lbl_mh_acuitardos.Size = New System.Drawing.Size(91, 17)
        Me.lbl_mh_acuitardos.TabIndex = 1
        Me.lbl_mh_acuitardos.Text = "2. Acuitardos"
        '
        'lbl_mh_acuicludo
        '
        Me.lbl_mh_acuicludo.AutoSize = True
        Me.lbl_mh_acuicludo.Location = New System.Drawing.Point(3, 240)
        Me.lbl_mh_acuicludo.Name = "lbl_mh_acuicludo"
        Me.lbl_mh_acuicludo.Size = New System.Drawing.Size(85, 17)
        Me.lbl_mh_acuicludo.TabIndex = 2
        Me.lbl_mh_acuicludo.Text = "3. Acuicludo"
        '
        'lbl_mh___acuifugo
        '
        Me.lbl_mh___acuifugo.AutoSize = True
        Me.lbl_mh___acuifugo.Location = New System.Drawing.Point(3, 360)
        Me.lbl_mh___acuifugo.Name = "lbl_mh___acuifugo"
        Me.lbl_mh___acuifugo.Size = New System.Drawing.Size(79, 17)
        Me.lbl_mh___acuifugo.TabIndex = 3
        Me.lbl_mh___acuifugo.Text = "4. Acuifugo"
        '
        'tbx_mh_acuiferos
        '
        Me.tbx_mh_acuiferos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_mh_acuiferos.Enabled = False
        Me.tbx_mh_acuiferos.Location = New System.Drawing.Point(3, 23)
        Me.tbx_mh_acuiferos.Multiline = True
        Me.tbx_mh_acuiferos.Name = "tbx_mh_acuiferos"
        Me.tbx_mh_acuiferos.Size = New System.Drawing.Size(396, 94)
        Me.tbx_mh_acuiferos.TabIndex = 4
        '
        'tbx_mh_acuitardos
        '
        Me.tbx_mh_acuitardos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_mh_acuitardos.Enabled = False
        Me.tbx_mh_acuitardos.Location = New System.Drawing.Point(3, 143)
        Me.tbx_mh_acuitardos.Multiline = True
        Me.tbx_mh_acuitardos.Name = "tbx_mh_acuitardos"
        Me.tbx_mh_acuitardos.Size = New System.Drawing.Size(396, 94)
        Me.tbx_mh_acuitardos.TabIndex = 5
        '
        'tbx_mh_acuicludo
        '
        Me.tbx_mh_acuicludo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_mh_acuicludo.Enabled = False
        Me.tbx_mh_acuicludo.Location = New System.Drawing.Point(3, 263)
        Me.tbx_mh_acuicludo.Multiline = True
        Me.tbx_mh_acuicludo.Name = "tbx_mh_acuicludo"
        Me.tbx_mh_acuicludo.Size = New System.Drawing.Size(396, 94)
        Me.tbx_mh_acuicludo.TabIndex = 6
        '
        'tbx_mh_acuifugo
        '
        Me.tbx_mh_acuifugo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_mh_acuifugo.Enabled = False
        Me.tbx_mh_acuifugo.Location = New System.Drawing.Point(3, 383)
        Me.tbx_mh_acuifugo.Multiline = True
        Me.tbx_mh_acuifugo.Name = "tbx_mh_acuifugo"
        Me.tbx_mh_acuifugo.Size = New System.Drawing.Size(396, 94)
        Me.tbx_mh_acuifugo.TabIndex = 7
        '
        'UserControl_ComboBoxDatarames1
        '
        Me.UserControl_ComboBoxDatarames1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControl_ComboBoxDatarames1.Location = New System.Drawing.Point(3, 408)
        Me.UserControl_ComboBoxDatarames1.Name = "UserControl_ComboBoxDatarames1"
        Me.UserControl_ComboBoxDatarames1.Size = New System.Drawing.Size(437, 54)
        Me.UserControl_ComboBoxDatarames1.TabIndex = 1
        '
        'Form_mapa_hidrogeologico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 701)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_mapa_hidrogeologico"
        Me.Text = "Form_mapa_hidrogeologico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.tc_mh_tools.ResumeLayout(False)
        Me.tp_mh_rotulo.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.nud_mh_numero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_mh_leyenda.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.tc_mh_leyenda_tools.ResumeLayout(False)
        Me.tp_mh_classif.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        CType(Me.dgv_mh_leyenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tp_mh_dhidrog.ResumeLayout(False)
        Me.tlp_mh_dhidrog.ResumeLayout(False)
        Me.tlp_mh_dhidrog.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbx_mh_cuencas As System.Windows.Forms.ComboBox
    Friend WithEvents lbx_mh_cuencas As System.Windows.Forms.ListBox
    Friend WithEvents lbl_mh_nota1 As System.Windows.Forms.Label
    Friend WithEvents lbl_mh_cuenca As System.Windows.Forms.Label
    Friend WithEvents tc_mh_tools As System.Windows.Forms.TabControl
    Friend WithEvents tp_mh_rotulo As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_mh_autor As System.Windows.Forms.Label
    Friend WithEvents tp_mh_leyenda As System.Windows.Forms.TabPage
    Friend WithEvents clb_mh_autores As System.Windows.Forms.CheckedListBox
    Friend WithEvents rbt_mh_pequenio As System.Windows.Forms.RadioButton
    Friend WithEvents rbt_mh_grande As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_mh_autores As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbx_mh_title1 As System.Windows.Forms.TextBox
    Friend WithEvents tbx_mh_title2 As System.Windows.Forms.TextBox
    Friend WithEvents btn_mh_grotulo As System.Windows.Forms.Button
    Friend WithEvents img_list_mh As System.Windows.Forms.ImageList
    Friend WithEvents nud_mh_numero As System.Windows.Forms.NumericUpDown
    Friend WithEvents lbl_mh_numero As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btn_mh_leyenda As System.Windows.Forms.Button
    Friend WithEvents tc_mh_leyenda_tools As System.Windows.Forms.TabControl
    Friend WithEvents tp_mh_classif As System.Windows.Forms.TabPage
    Friend WithEvents tp_mh_dhidrog As System.Windows.Forms.TabPage
    Friend WithEvents UserControl_ComboBoxDatarames1 As UserControl_ComboBoxDatarames
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents dgv_mh_leyenda As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_mh_uhcount As System.Windows.Forms.Label
    Friend WithEvents tlp_mh_dhidrog As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_mh_acuiferos As System.Windows.Forms.Label
    Friend WithEvents lbl_mh_acuitardos As System.Windows.Forms.Label
    Friend WithEvents lbl_mh_acuicludo As System.Windows.Forms.Label
    Friend WithEvents lbl_mh___acuifugo As System.Windows.Forms.Label
    Friend WithEvents tbx_mh_acuiferos As System.Windows.Forms.TextBox
    Friend WithEvents tbx_mh_acuitardos As System.Windows.Forms.TextBox
    Friend WithEvents tbx_mh_acuicludo As System.Windows.Forms.TextBox
    Friend WithEvents tbx_mh_acuifugo As System.Windows.Forms.TextBox
End Class
