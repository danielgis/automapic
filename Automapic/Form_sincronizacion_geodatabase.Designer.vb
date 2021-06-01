<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_sincronizacion_geodatabase
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_sg_origen = New System.Windows.Forms.Label()
        Me.lbl_sg_destino = New System.Windows.Forms.Label()
        Me.btn_sg_origen = New System.Windows.Forms.Button()
        Me.btn_sg_destino = New System.Windows.Forms.Button()
        Me.tbx_origen = New System.Windows.Forms.TextBox()
        Me.tbx_destino = New System.Windows.Forms.TextBox()
        Me.lbl_sg_filtrocapas = New System.Windows.Forms.Label()
        Me.lbl_sg_estdestino = New System.Windows.Forms.Label()
        Me.cbx_sg_filtrocapas = New System.Windows.Forms.ComboBox()
        Me.rbtn_sg_estds = New System.Windows.Forms.RadioButton()
        Me.rbtn_sg_estraiz = New System.Windows.Forms.RadioButton()
        Me.dg_sg_capas = New System.Windows.Forms.DataGridView()
        Me.btn_sg_enviar = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.dg_sg_capas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_sg_origen, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_sg_destino, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_sg_origen, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_sg_destino, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_origen, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbx_destino, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_sg_filtrocapas, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_sg_estdestino, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.cbx_sg_filtrocapas, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.rbtn_sg_estds, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.rbtn_sg_estraiz, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.dg_sg_capas, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_sg_enviar, 0, 13)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 677)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_sg_origen
        '
        Me.lbl_sg_origen.AutoSize = True
        Me.lbl_sg_origen.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_sg_origen.Location = New System.Drawing.Point(3, 8)
        Me.lbl_sg_origen.Name = "lbl_sg_origen"
        Me.lbl_sg_origen.Size = New System.Drawing.Size(324, 17)
        Me.lbl_sg_origen.TabIndex = 0
        Me.lbl_sg_origen.Text = "Fuente de datos :"
        '
        'lbl_sg_destino
        '
        Me.lbl_sg_destino.AutoSize = True
        Me.lbl_sg_destino.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_sg_destino.Location = New System.Drawing.Point(3, 58)
        Me.lbl_sg_destino.Name = "lbl_sg_destino"
        Me.lbl_sg_destino.Size = New System.Drawing.Size(324, 17)
        Me.lbl_sg_destino.TabIndex = 2
        Me.lbl_sg_destino.Text = "Ruta de destino :"
        '
        'btn_sg_origen
        '
        Me.btn_sg_origen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_sg_origen.Location = New System.Drawing.Point(333, 28)
        Me.btn_sg_origen.Name = "btn_sg_origen"
        Me.btn_sg_origen.Size = New System.Drawing.Size(74, 24)
        Me.btn_sg_origen.TabIndex = 6
        Me.btn_sg_origen.Text = "+"
        Me.btn_sg_origen.UseVisualStyleBackColor = True
        '
        'btn_sg_destino
        '
        Me.btn_sg_destino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_sg_destino.Location = New System.Drawing.Point(333, 78)
        Me.btn_sg_destino.Name = "btn_sg_destino"
        Me.btn_sg_destino.Size = New System.Drawing.Size(74, 24)
        Me.btn_sg_destino.TabIndex = 3
        Me.btn_sg_destino.Text = "+"
        Me.btn_sg_destino.UseVisualStyleBackColor = True
        '
        'tbx_origen
        '
        Me.tbx_origen.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_origen.Enabled = False
        Me.tbx_origen.Location = New System.Drawing.Point(3, 29)
        Me.tbx_origen.Name = "tbx_origen"
        Me.tbx_origen.Size = New System.Drawing.Size(324, 22)
        Me.tbx_origen.TabIndex = 10
        '
        'tbx_destino
        '
        Me.tbx_destino.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_destino.Enabled = False
        Me.tbx_destino.Location = New System.Drawing.Point(3, 79)
        Me.tbx_destino.Name = "tbx_destino"
        Me.tbx_destino.Size = New System.Drawing.Size(324, 22)
        Me.tbx_destino.TabIndex = 11
        '
        'lbl_sg_filtrocapas
        '
        Me.lbl_sg_filtrocapas.AutoSize = True
        Me.lbl_sg_filtrocapas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_sg_filtrocapas.Location = New System.Drawing.Point(3, 208)
        Me.lbl_sg_filtrocapas.Name = "lbl_sg_filtrocapas"
        Me.lbl_sg_filtrocapas.Size = New System.Drawing.Size(324, 17)
        Me.lbl_sg_filtrocapas.TabIndex = 7
        Me.lbl_sg_filtrocapas.Text = "Filtrar capas por:"
        '
        'lbl_sg_estdestino
        '
        Me.lbl_sg_estdestino.AutoSize = True
        Me.lbl_sg_estdestino.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_sg_estdestino.Location = New System.Drawing.Point(3, 118)
        Me.lbl_sg_estdestino.Name = "lbl_sg_estdestino"
        Me.lbl_sg_estdestino.Size = New System.Drawing.Size(324, 17)
        Me.lbl_sg_estdestino.TabIndex = 12
        Me.lbl_sg_estdestino.Text = "Estructura del destino:"
        '
        'cbx_sg_filtrocapas
        '
        Me.cbx_sg_filtrocapas.Enabled = False
        Me.cbx_sg_filtrocapas.FormattingEnabled = True
        Me.cbx_sg_filtrocapas.Location = New System.Drawing.Point(3, 228)
        Me.cbx_sg_filtrocapas.Name = "cbx_sg_filtrocapas"
        Me.cbx_sg_filtrocapas.Size = New System.Drawing.Size(199, 24)
        Me.cbx_sg_filtrocapas.TabIndex = 8
        '
        'rbtn_sg_estds
        '
        Me.rbtn_sg_estds.AutoSize = True
        Me.rbtn_sg_estds.Checked = True
        Me.rbtn_sg_estds.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbtn_sg_estds.Location = New System.Drawing.Point(3, 141)
        Me.rbtn_sg_estds.Name = "rbtn_sg_estds"
        Me.rbtn_sg_estds.Size = New System.Drawing.Size(324, 21)
        Me.rbtn_sg_estds.TabIndex = 13
        Me.rbtn_sg_estds.TabStop = True
        Me.rbtn_sg_estds.Text = "Mantener Datasets"
        Me.rbtn_sg_estds.UseVisualStyleBackColor = True
        '
        'rbtn_sg_estraiz
        '
        Me.rbtn_sg_estraiz.AutoSize = True
        Me.rbtn_sg_estraiz.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rbtn_sg_estraiz.Location = New System.Drawing.Point(3, 171)
        Me.rbtn_sg_estraiz.Name = "rbtn_sg_estraiz"
        Me.rbtn_sg_estraiz.Size = New System.Drawing.Size(324, 21)
        Me.rbtn_sg_estraiz.TabIndex = 14
        Me.rbtn_sg_estraiz.Text = "Enviar a la raiz"
        Me.rbtn_sg_estraiz.UseVisualStyleBackColor = True
        '
        'dg_sg_capas
        '
        Me.dg_sg_capas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.dg_sg_capas, 2)
        Me.dg_sg_capas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_sg_capas.Location = New System.Drawing.Point(3, 268)
        Me.dg_sg_capas.Name = "dg_sg_capas"
        Me.dg_sg_capas.RowTemplate.Height = 24
        Me.dg_sg_capas.Size = New System.Drawing.Size(404, 371)
        Me.dg_sg_capas.TabIndex = 15
        '
        'btn_sg_enviar
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.btn_sg_enviar, 2)
        Me.btn_sg_enviar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_sg_enviar.Location = New System.Drawing.Point(3, 650)
        Me.btn_sg_enviar.Name = "btn_sg_enviar"
        Me.btn_sg_enviar.Size = New System.Drawing.Size(404, 24)
        Me.btn_sg_enviar.TabIndex = 16
        Me.btn_sg_enviar.Text = "Enviar"
        Me.btn_sg_enviar.UseVisualStyleBackColor = True
        '
        'Form_sincronizacion_geodatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 677)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_sincronizacion_geodatabase"
        Me.Text = "Form_sincronizacion_geodatabase"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.dg_sg_capas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_sg_origen As System.Windows.Forms.Label
    Friend WithEvents lbl_sg_destino As System.Windows.Forms.Label
    Friend WithEvents btn_sg_destino As System.Windows.Forms.Button
    Friend WithEvents btn_sg_origen As System.Windows.Forms.Button
    Friend WithEvents lbl_sg_filtrocapas As System.Windows.Forms.Label
    Friend WithEvents cbx_sg_filtrocapas As System.Windows.Forms.ComboBox
    Friend WithEvents tbx_origen As System.Windows.Forms.TextBox
    Friend WithEvents tbx_destino As System.Windows.Forms.TextBox
    Friend WithEvents lbl_sg_estdestino As System.Windows.Forms.Label
    Friend WithEvents rbtn_sg_estds As System.Windows.Forms.RadioButton
    Friend WithEvents rbtn_sg_estraiz As System.Windows.Forms.RadioButton
    Friend WithEvents dg_sg_capas As System.Windows.Forms.DataGridView
    Friend WithEvents btn_sg_enviar As System.Windows.Forms.Button
End Class
