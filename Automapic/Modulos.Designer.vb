<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Modulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modulos))
        Me.tlp_modulos = New System.Windows.Forms.TableLayoutPanel()
        Me.tlp_modulos_controles = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_modulos = New System.Windows.Forms.ComboBox()
        Me.lbl_modulos = New System.Windows.Forms.Label()
        Me.pbx_search = New System.Windows.Forms.PictureBox()
        Me.pbx_add = New System.Windows.Forms.PictureBox()
        Me.pnl_modulos_form = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_cerrar_sesion = New System.Windows.Forms.Button()
        Me.pgb_modulos = New System.Windows.Forms.ProgressBar()
        Me.tlp_modulos.SuspendLayout()
        Me.tlp_modulos_controles.SuspendLayout()
        CType(Me.pbx_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlp_modulos
        '
        Me.tlp_modulos.ColumnCount = 3
        Me.tlp_modulos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlp_modulos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_modulos.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlp_modulos.Controls.Add(Me.tlp_modulos_controles, 1, 1)
        Me.tlp_modulos.Controls.Add(Me.pnl_modulos_form, 1, 2)
        Me.tlp_modulos.Controls.Add(Me.TableLayoutPanel1, 1, 3)
        Me.tlp_modulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_modulos.Location = New System.Drawing.Point(0, 0)
        Me.tlp_modulos.Name = "tlp_modulos"
        Me.tlp_modulos.RowCount = 5
        Me.tlp_modulos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlp_modulos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tlp_modulos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_modulos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlp_modulos.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlp_modulos.Size = New System.Drawing.Size(474, 618)
        Me.tlp_modulos.TabIndex = 0
        '
        'tlp_modulos_controles
        '
        Me.tlp_modulos_controles.ColumnCount = 3
        Me.tlp_modulos_controles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_modulos_controles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlp_modulos_controles.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlp_modulos_controles.Controls.Add(Me.cbx_modulos, 0, 1)
        Me.tlp_modulos_controles.Controls.Add(Me.lbl_modulos, 0, 0)
        Me.tlp_modulos_controles.Controls.Add(Me.pbx_search, 1, 1)
        Me.tlp_modulos_controles.Controls.Add(Me.pbx_add, 2, 1)
        Me.tlp_modulos_controles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_modulos_controles.Location = New System.Drawing.Point(13, 13)
        Me.tlp_modulos_controles.Name = "tlp_modulos_controles"
        Me.tlp_modulos_controles.RowCount = 2
        Me.tlp_modulos_controles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_modulos_controles.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_modulos_controles.Size = New System.Drawing.Size(448, 49)
        Me.tlp_modulos_controles.TabIndex = 0
        '
        'cbx_modulos
        '
        Me.cbx_modulos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbx_modulos.FormattingEnabled = True
        Me.cbx_modulos.Location = New System.Drawing.Point(3, 23)
        Me.cbx_modulos.Name = "cbx_modulos"
        Me.cbx_modulos.Size = New System.Drawing.Size(372, 24)
        Me.cbx_modulos.TabIndex = 0
        '
        'lbl_modulos
        '
        Me.lbl_modulos.AutoSize = True
        Me.lbl_modulos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_modulos.Location = New System.Drawing.Point(3, 3)
        Me.lbl_modulos.Name = "lbl_modulos"
        Me.lbl_modulos.Size = New System.Drawing.Size(372, 17)
        Me.lbl_modulos.TabIndex = 1
        Me.lbl_modulos.Text = "Seleccionar módulo"
        '
        'pbx_search
        '
        Me.pbx_search.BackgroundImage = CType(resources.GetObject("pbx_search.BackgroundImage"), System.Drawing.Image)
        Me.pbx_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbx_search.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_search.Location = New System.Drawing.Point(381, 23)
        Me.pbx_search.Name = "pbx_search"
        Me.pbx_search.Size = New System.Drawing.Size(29, 23)
        Me.pbx_search.TabIndex = 2
        Me.pbx_search.TabStop = False
        '
        'pbx_add
        '
        Me.pbx_add.BackgroundImage = Global.Automapic.My.Resources.Resources.TaskUpdate32
        Me.pbx_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbx_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbx_add.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbx_add.Location = New System.Drawing.Point(416, 23)
        Me.pbx_add.Name = "pbx_add"
        Me.pbx_add.Size = New System.Drawing.Size(29, 23)
        Me.pbx_add.TabIndex = 3
        Me.pbx_add.TabStop = False
        '
        'pnl_modulos_form
        '
        Me.pnl_modulos_form.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_modulos_form.Location = New System.Drawing.Point(13, 68)
        Me.pnl_modulos_form.Name = "pnl_modulos_form"
        Me.pnl_modulos_form.Size = New System.Drawing.Size(448, 497)
        Me.pnl_modulos_form.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_cerrar_sesion, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pgb_modulos, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(13, 571)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(448, 34)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btn_cerrar_sesion
        '
        Me.btn_cerrar_sesion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_cerrar_sesion.Location = New System.Drawing.Point(351, 3)
        Me.btn_cerrar_sesion.Name = "btn_cerrar_sesion"
        Me.btn_cerrar_sesion.Size = New System.Drawing.Size(94, 28)
        Me.btn_cerrar_sesion.TabIndex = 1
        Me.btn_cerrar_sesion.Text = "Salir"
        Me.btn_cerrar_sesion.UseVisualStyleBackColor = True
        '
        'pgb_modulos
        '
        Me.pgb_modulos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgb_modulos.Location = New System.Drawing.Point(3, 3)
        Me.pgb_modulos.Name = "pgb_modulos"
        Me.pgb_modulos.Size = New System.Drawing.Size(342, 28)
        Me.pgb_modulos.TabIndex = 2
        '
        'Modulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(474, 618)
        Me.Controls.Add(Me.tlp_modulos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Modulos"
        Me.Text = "Modulos"
        Me.tlp_modulos.ResumeLayout(False)
        Me.tlp_modulos_controles.ResumeLayout(False)
        Me.tlp_modulos_controles.PerformLayout()
        CType(Me.pbx_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_modulos As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tlp_modulos_controles As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbx_modulos As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_modulos As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar_sesion As System.Windows.Forms.Button
    Friend WithEvents pnl_modulos_form As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pgb_modulos As System.Windows.Forms.ProgressBar
    Friend WithEvents pbx_search As System.Windows.Forms.PictureBox
    Friend WithEvents pbx_add As System.Windows.Forms.PictureBox
End Class
