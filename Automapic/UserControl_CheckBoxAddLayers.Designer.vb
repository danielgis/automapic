﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.SuspendLayout()
        '
        'tvw_layers
        '
        Me.tvw_layers.CheckBoxes = True
        Me.tvw_layers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvw_layers.Location = New System.Drawing.Point(0, 0)
        Me.tvw_layers.Name = "tvw_layers"
        Me.tvw_layers.Size = New System.Drawing.Size(366, 368)
        Me.tvw_layers.TabIndex = 0
        '
        'UserControl_CheckBoxAddLayers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tvw_layers)
        Me.Name = "UserControl_CheckBoxAddLayers"
        Me.Size = New System.Drawing.Size(366, 368)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tvw_layers As System.Windows.Forms.TreeView
End Class
