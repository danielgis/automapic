﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_mapa_hidrogeoquimico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tc_mhq_procesos = New System.Windows.Forms.TabControl()
        Me.tp_mhq_procesos_ingreso = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lml_mhq_gdb = New System.Windows.Forms.Label()
        Me.btn_mhq_gdb = New System.Windows.Forms.Button()
        Me.tbx_mhq_gdb = New System.Windows.Forms.TextBox()
        Me.lbl_mhq_excel = New System.Windows.Forms.Label()
        Me.tbx_mhq_excel = New System.Windows.Forms.TextBox()
        Me.btn_mhq_excel = New System.Windows.Forms.Button()
        Me.btn_mhq_cargar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btn_mhq_calc_xls = New System.Windows.Forms.Button()
        Me.lbl_mhq_id_xls = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tc_mhq_procesos.SuspendLayout()
        Me.tp_mhq_procesos_ingreso.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tc_mhq_procesos, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(308, 550)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tc_mhq_procesos
        '
        Me.tc_mhq_procesos.Controls.Add(Me.tp_mhq_procesos_ingreso)
        Me.tc_mhq_procesos.Controls.Add(Me.TabPage2)
        Me.tc_mhq_procesos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tc_mhq_procesos.Location = New System.Drawing.Point(3, 8)
        Me.tc_mhq_procesos.Name = "tc_mhq_procesos"
        Me.tc_mhq_procesos.SelectedIndex = 0
        Me.tc_mhq_procesos.Size = New System.Drawing.Size(302, 534)
        Me.tc_mhq_procesos.TabIndex = 0
        '
        'tp_mhq_procesos_ingreso
        '
        Me.tp_mhq_procesos_ingreso.Controls.Add(Me.TableLayoutPanel2)
        Me.tp_mhq_procesos_ingreso.Location = New System.Drawing.Point(4, 22)
        Me.tp_mhq_procesos_ingreso.Name = "tp_mhq_procesos_ingreso"
        Me.tp_mhq_procesos_ingreso.Padding = New System.Windows.Forms.Padding(3)
        Me.tp_mhq_procesos_ingreso.Size = New System.Drawing.Size(294, 508)
        Me.tp_mhq_procesos_ingreso.TabIndex = 0
        Me.tp_mhq_procesos_ingreso.Text = "Ingreso de Datos"
        Me.tp_mhq_procesos_ingreso.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lml_mhq_gdb, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mhq_gdb, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_mhq_gdb, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_mhq_excel, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.tbx_mhq_excel, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mhq_excel, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mhq_cargar, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_mhq_calc_xls, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_mhq_id_xls, 0, 6)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 10
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(288, 502)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'lml_mhq_gdb
        '
        Me.lml_mhq_gdb.AutoSize = True
        Me.lml_mhq_gdb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lml_mhq_gdb.Location = New System.Drawing.Point(3, 4)
        Me.lml_mhq_gdb.Name = "lml_mhq_gdb"
        Me.lml_mhq_gdb.Size = New System.Drawing.Size(222, 16)
        Me.lml_mhq_gdb.TabIndex = 0
        Me.lml_mhq_gdb.Text = "Seleccione GDB"
        '
        'btn_mhq_gdb
        '
        Me.btn_mhq_gdb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_mhq_gdb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mhq_gdb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mhq_gdb.Location = New System.Drawing.Point(231, 23)
        Me.btn_mhq_gdb.Name = "btn_mhq_gdb"
        Me.btn_mhq_gdb.Size = New System.Drawing.Size(54, 22)
        Me.btn_mhq_gdb.TabIndex = 1
        Me.btn_mhq_gdb.Text = "+"
        Me.btn_mhq_gdb.UseVisualStyleBackColor = True
        '
        'tbx_mhq_gdb
        '
        Me.tbx_mhq_gdb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_mhq_gdb.Enabled = False
        Me.tbx_mhq_gdb.Location = New System.Drawing.Point(3, 23)
        Me.tbx_mhq_gdb.Name = "tbx_mhq_gdb"
        Me.tbx_mhq_gdb.Size = New System.Drawing.Size(222, 20)
        Me.tbx_mhq_gdb.TabIndex = 2
        '
        'lbl_mhq_excel
        '
        Me.lbl_mhq_excel.AutoSize = True
        Me.lbl_mhq_excel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_mhq_excel.Location = New System.Drawing.Point(3, 48)
        Me.lbl_mhq_excel.Name = "lbl_mhq_excel"
        Me.lbl_mhq_excel.Size = New System.Drawing.Size(222, 16)
        Me.lbl_mhq_excel.TabIndex = 3
        Me.lbl_mhq_excel.Text = "Seleccione archivo excel"
        '
        'tbx_mhq_excel
        '
        Me.tbx_mhq_excel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbx_mhq_excel.Enabled = False
        Me.tbx_mhq_excel.Location = New System.Drawing.Point(3, 67)
        Me.tbx_mhq_excel.Name = "tbx_mhq_excel"
        Me.tbx_mhq_excel.Size = New System.Drawing.Size(222, 20)
        Me.tbx_mhq_excel.TabIndex = 4
        '
        'btn_mhq_excel
        '
        Me.btn_mhq_excel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mhq_excel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mhq_excel.Location = New System.Drawing.Point(231, 67)
        Me.btn_mhq_excel.Name = "btn_mhq_excel"
        Me.btn_mhq_excel.Size = New System.Drawing.Size(54, 22)
        Me.btn_mhq_excel.TabIndex = 5
        Me.btn_mhq_excel.Text = "+"
        Me.btn_mhq_excel.UseVisualStyleBackColor = True
        '
        'btn_mhq_cargar
        '
        Me.TableLayoutPanel2.SetColumnSpan(Me.btn_mhq_cargar, 2)
        Me.btn_mhq_cargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mhq_cargar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_mhq_cargar.Enabled = False
        Me.btn_mhq_cargar.Location = New System.Drawing.Point(3, 139)
        Me.btn_mhq_cargar.Name = "btn_mhq_cargar"
        Me.btn_mhq_cargar.Size = New System.Drawing.Size(282, 24)
        Me.btn_mhq_cargar.TabIndex = 6
        Me.btn_mhq_cargar.Text = "Cargar Datos a GDB"
        Me.btn_mhq_cargar.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(294, 508)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "xls"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Excel 97-2003|*.xls|Excel |*.xlsx|Todos los archivos|*.*"
        Me.OpenFileDialog1.RestoreDirectory = True
        Me.OpenFileDialog1.Title = "Abrir"
        '
        'btn_mhq_calc_xls
        '
        Me.btn_mhq_calc_xls.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mhq_calc_xls.Enabled = False
        Me.btn_mhq_calc_xls.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mhq_calc_xls.Location = New System.Drawing.Point(231, 103)
        Me.btn_mhq_calc_xls.Name = "btn_mhq_calc_xls"
        Me.btn_mhq_calc_xls.Size = New System.Drawing.Size(54, 22)
        Me.btn_mhq_calc_xls.TabIndex = 7
        Me.btn_mhq_calc_xls.Text = "Guardar"
        Me.btn_mhq_calc_xls.UseVisualStyleBackColor = True
        '
        'lbl_mhq_id_xls
        '
        Me.lbl_mhq_id_xls.AutoSize = True
        Me.lbl_mhq_id_xls.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_mhq_id_xls.Location = New System.Drawing.Point(3, 100)
        Me.lbl_mhq_id_xls.Name = "lbl_mhq_id_xls"
        Me.lbl_mhq_id_xls.Size = New System.Drawing.Size(222, 28)
        Me.lbl_mhq_id_xls.TabIndex = 8
        Me.lbl_mhq_id_xls.Text = "Guardar xls con cálculos de iones (opcional)"
        Me.lbl_mhq_id_xls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.CheckPathExists = False
        Me.SaveFileDialog1.DefaultExt = "xlsx"
        Me.SaveFileDialog1.Filter = "Excel 97-2003|*.xls|Excel |*.xlsx|Todos los archivos|*.*"
        Me.SaveFileDialog1.FilterIndex = 2
        Me.SaveFileDialog1.Title = "Guardar xlsx"
        '
        'Form_mapa_hidrogeoquimico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(308, 550)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_mapa_hidrogeoquimico"
        Me.Text = "Form_mapa_hidrogeoquimico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tc_mhq_procesos.ResumeLayout(False)
        Me.tp_mhq_procesos_ingreso.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tc_mhq_procesos As System.Windows.Forms.TabControl
    Friend WithEvents tp_mhq_procesos_ingreso As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lml_mhq_gdb As System.Windows.Forms.Label
    Friend WithEvents btn_mhq_gdb As System.Windows.Forms.Button
    Friend WithEvents tbx_mhq_gdb As System.Windows.Forms.TextBox
    Friend WithEvents lbl_mhq_excel As System.Windows.Forms.Label
    Friend WithEvents tbx_mhq_excel As System.Windows.Forms.TextBox
    Friend WithEvents btn_mhq_excel As System.Windows.Forms.Button
    Friend WithEvents btn_mhq_cargar As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btn_mhq_calc_xls As System.Windows.Forms.Button
    Friend WithEvents lbl_mhq_id_xls As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
