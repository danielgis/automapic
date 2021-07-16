<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_mapa_neotectonica
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdb_mn_horizontal = New System.Windows.Forms.RadioButton()
        Me.rdb_mn_vertical = New System.Windows.Forms.RadioButton()
        Me.nud_mn_escala = New System.Windows.Forms.NumericUpDown()
        Me.tbx_mn_titulo = New System.Windows.Forms.TextBox()
        Me.clb_mn_autor = New System.Windows.Forms.CheckedListBox()
        Me.btn_mn_mapa = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbx_mn_region = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nud_mn_escala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.4433!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.5567!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.rdb_mn_horizontal, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.rdb_mn_vertical, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.nud_mn_escala, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_mn_titulo, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.clb_mn_autor, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_mn_mapa, 0, 14)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_mn_region, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 15
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(388, 664)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label1, 2)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Location = New System.Drawing.Point(3, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(382, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione orientación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label2, 2)
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label2.Location = New System.Drawing.Point(3, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(382, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Defina una escala"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label3.Location = New System.Drawing.Point(3, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(382, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Especifique un título"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label4.Location = New System.Drawing.Point(3, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(382, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Autores"
        '
        'rdb_mn_horizontal
        '
        Me.rdb_mn_horizontal.AutoSize = True
        Me.rdb_mn_horizontal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdb_mn_horizontal.Location = New System.Drawing.Point(3, 78)
        Me.rdb_mn_horizontal.Name = "rdb_mn_horizontal"
        Me.rdb_mn_horizontal.Size = New System.Drawing.Size(116, 24)
        Me.rdb_mn_horizontal.TabIndex = 5
        Me.rdb_mn_horizontal.TabStop = True
        Me.rdb_mn_horizontal.Text = "Horizontal"
        Me.rdb_mn_horizontal.UseVisualStyleBackColor = True
        '
        'rdb_mn_vertical
        '
        Me.rdb_mn_vertical.AutoSize = True
        Me.rdb_mn_vertical.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdb_mn_vertical.Location = New System.Drawing.Point(125, 78)
        Me.rdb_mn_vertical.Name = "rdb_mn_vertical"
        Me.rdb_mn_vertical.Size = New System.Drawing.Size(260, 24)
        Me.rdb_mn_vertical.TabIndex = 6
        Me.rdb_mn_vertical.TabStop = True
        Me.rdb_mn_vertical.Text = "Vertical"
        Me.rdb_mn_vertical.UseVisualStyleBackColor = True
        '
        'nud_mn_escala
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.nud_mn_escala, 2)
        Me.nud_mn_escala.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nud_mn_escala.Increment = New Decimal(New Integer() {25000, 0, 0, 0})
        Me.nud_mn_escala.Location = New System.Drawing.Point(3, 133)
        Me.nud_mn_escala.Maximum = New Decimal(New Integer() {2000000, 0, 0, 0})
        Me.nud_mn_escala.Minimum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nud_mn_escala.Name = "nud_mn_escala"
        Me.nud_mn_escala.Size = New System.Drawing.Size(382, 22)
        Me.nud_mn_escala.TabIndex = 7
        Me.nud_mn_escala.Value = New Decimal(New Integer() {100000, 0, 0, 0})
        '
        'tbx_mn_titulo
        '
        Me.tbx_mn_titulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.tbx_mn_titulo, 2)
        Me.tbx_mn_titulo.Location = New System.Drawing.Point(3, 189)
        Me.tbx_mn_titulo.Name = "tbx_mn_titulo"
        Me.tbx_mn_titulo.Size = New System.Drawing.Size(382, 22)
        Me.tbx_mn_titulo.TabIndex = 8
        '
        'clb_mn_autor
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.clb_mn_autor, 2)
        Me.clb_mn_autor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clb_mn_autor.FormattingEnabled = True
        Me.clb_mn_autor.Location = New System.Drawing.Point(3, 243)
        Me.clb_mn_autor.Name = "clb_mn_autor"
        Me.clb_mn_autor.Size = New System.Drawing.Size(382, 383)
        Me.clb_mn_autor.TabIndex = 9
        '
        'btn_mn_mapa
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btn_mn_mapa, 2)
        Me.btn_mn_mapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mn_mapa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mn_mapa.Image = Global.Automapic.My.Resources.Resources.MapRange16
        Me.btn_mn_mapa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_mn_mapa.Location = New System.Drawing.Point(3, 632)
        Me.btn_mn_mapa.Name = "btn_mn_mapa"
        Me.btn_mn_mapa.Size = New System.Drawing.Size(382, 29)
        Me.btn_mn_mapa.TabIndex = 10
        Me.btn_mn_mapa.Text = "Generar mapa"
        Me.btn_mn_mapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_mn_mapa.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.TableLayoutPanel1.SetColumnSpan(Me.Label5, 2)
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(382, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Seleccione una región"
        '
        'cbx_mn_region
        '
        Me.cbx_mn_region.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.SetColumnSpan(Me.cbx_mn_region, 2)
        Me.cbx_mn_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbx_mn_region.FormattingEnabled = True
        Me.cbx_mn_region.Location = New System.Drawing.Point(3, 23)
        Me.cbx_mn_region.Name = "cbx_mn_region"
        Me.cbx_mn_region.Size = New System.Drawing.Size(382, 24)
        Me.cbx_mn_region.TabIndex = 12
        '
        'Form_mapa_neotectonica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 664)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_mapa_neotectonica"
        Me.Text = "Form_mapa_neotectonica"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nud_mn_escala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nud_mn_escala As System.Windows.Forms.NumericUpDown
    Friend WithEvents tbx_mn_titulo As System.Windows.Forms.TextBox
    Friend WithEvents clb_mn_autor As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_mn_mapa As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rdb_mn_horizontal As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_mn_vertical As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbx_mn_region As System.Windows.Forms.ComboBox
End Class
