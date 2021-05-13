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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.cbx_mh_cuencas = New System.Windows.Forms.ComboBox()
        Me.lbx_mh_cuencas = New System.Windows.Forms.ListBox()
        Me.lbl_mh_nota1 = New System.Windows.Forms.Label()
        Me.lbl_mh_cuenca = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cbx_mh_cuencas As System.Windows.Forms.ComboBox
    Friend WithEvents lbx_mh_cuencas As System.Windows.Forms.ListBox
    Friend WithEvents lbl_mh_nota1 As System.Windows.Forms.Label
    Friend WithEvents lbl_mh_cuenca As System.Windows.Forms.Label
End Class
