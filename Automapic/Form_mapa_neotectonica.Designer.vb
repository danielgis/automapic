<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_mapa_neotectonica
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
        Me.UserControl_ComboBoxRegiones1 = New Automapic.UserControl_ComboBoxRegiones()
        Me.UserControl_ComboBoxRegiones2 = New Automapic.UserControl_ComboBoxRegiones()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.UserControl_ComboBoxRegiones1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.UserControl_ComboBoxRegiones2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(330, 582)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'UserControl_ComboBoxRegiones1
        '
        Me.UserControl_ComboBoxRegiones1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UserControl_ComboBoxRegiones1.Location = New System.Drawing.Point(2, 6)
        Me.UserControl_ComboBoxRegiones1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserControl_ComboBoxRegiones1.Name = "UserControl_ComboBoxRegiones1"
        Me.UserControl_ComboBoxRegiones1.Size = New System.Drawing.Size(326, 41)
        Me.UserControl_ComboBoxRegiones1.TabIndex = 0
        '
        'UserControl_ComboBoxRegiones2
        '
        Me.UserControl_ComboBoxRegiones2.Location = New System.Drawing.Point(2, 2)
        Me.UserControl_ComboBoxRegiones2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UserControl_ComboBoxRegiones2.Name = "UserControl_ComboBoxRegiones2"
        Me.UserControl_ComboBoxRegiones2.Size = New System.Drawing.Size(300, 1)
        Me.UserControl_ComboBoxRegiones2.TabIndex = 1
        '
        'Form_mapa_neotectonica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 582)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form_mapa_neotectonica"
        Me.Text = "Form_mapa_neotectonica"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UserControl_ComboBoxRegiones1 As UserControl_ComboBoxRegiones
    Friend WithEvents UserControl_ComboBoxRegiones2 As UserControl_ComboBoxRegiones
End Class
