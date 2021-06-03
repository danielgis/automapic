<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl_CheckBoxAddLayers
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tvw_layers = New System.Windows.Forms.TreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UserControl_ComboBoxDataframes1 = New Automapic.UserControl_ComboBoxDataframes()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvw_layers
        '
        Me.tvw_layers.CheckBoxes = True
        Me.tvw_layers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvw_layers.Location = New System.Drawing.Point(4, 64)
        Me.tvw_layers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tvw_layers.Name = "tvw_layers"
        Me.tvw_layers.ShowLines = False
        Me.tvw_layers.Size = New System.Drawing.Size(480, 385)
        Me.tvw_layers.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tvw_layers, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UserControl_ComboBoxDataframes1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(488, 453)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'UserControl_ComboBoxDataframes1
        '
        Me.UserControl_ComboBoxDataframes1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControl_ComboBoxDataframes1.Location = New System.Drawing.Point(3, 3)
        Me.UserControl_ComboBoxDataframes1.Name = "UserControl_ComboBoxDataframes1"
        Me.UserControl_ComboBoxDataframes1.Size = New System.Drawing.Size(482, 54)
        Me.UserControl_ComboBoxDataframes1.TabIndex = 1
        '
        'UserControl_CheckBoxAddLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UserControl_CheckBoxAddLayers"
        Me.Size = New System.Drawing.Size(488, 453)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvw_layers As System.Windows.Forms.TreeView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UserControl_ComboBoxDataframes1 As UserControl_ComboBoxDataframes
End Class
