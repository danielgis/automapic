<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.tlp_login = New System.Windows.Forms.TableLayoutPanel()
        Me.tbx_user = New System.Windows.Forms.TextBox()
        Me.tbx_pass = New System.Windows.Forms.TextBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.img_list_login = New System.Windows.Forms.ImageList(Me.components)
        Me.lbl_pass = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbx_login_loader = New System.Windows.Forms.PictureBox()
        Me.bgw_login = New System.ComponentModel.BackgroundWorker()
        Me.tlp_login.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx_login_loader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlp_login
        '
        Me.tlp_login.ColumnCount = 5
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251.0!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlp_login.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11.0!))
        Me.tlp_login.Controls.Add(Me.tbx_user, 2, 4)
        Me.tlp_login.Controls.Add(Me.tbx_pass, 2, 6)
        Me.tlp_login.Controls.Add(Me.lbl_user, 2, 3)
        Me.tlp_login.Controls.Add(Me.lbl_pass, 2, 5)
        Me.tlp_login.Controls.Add(Me.btn_login, 2, 7)
        Me.tlp_login.Controls.Add(Me.PictureBox1, 2, 1)
        Me.tlp_login.Controls.Add(Me.pbx_login_loader, 2, 9)
        Me.tlp_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlp_login.Location = New System.Drawing.Point(0, 0)
        Me.tlp_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tlp_login.Name = "tlp_login"
        Me.tlp_login.RowCount = 11
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlp_login.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.tlp_login.Size = New System.Drawing.Size(531, 658)
        Me.tlp_login.TabIndex = 0
        '
        'tbx_user
        '
        Me.tbx_user.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_user.Location = New System.Drawing.Point(143, 234)
        Me.tbx_user.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbx_user.Name = "tbx_user"
        Me.tbx_user.Size = New System.Drawing.Size(245, 22)
        Me.tbx_user.TabIndex = 0
        '
        'tbx_pass
        '
        Me.tbx_pass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_pass.Location = New System.Drawing.Point(143, 284)
        Me.tbx_pass.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbx_pass.Name = "tbx_pass"
        Me.tbx_pass.Size = New System.Drawing.Size(245, 22)
        Me.tbx_pass.TabIndex = 1
        Me.tbx_pass.UseSystemPasswordChar = True
        '
        'lbl_user
        '
        Me.lbl_user.AutoSize = True
        Me.lbl_user.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_user.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_user.ImageIndex = 0
        Me.lbl_user.ImageList = Me.img_list_login
        Me.lbl_user.Location = New System.Drawing.Point(143, 215)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(245, 17)
        Me.lbl_user.TabIndex = 2
        Me.lbl_user.Text = "Usuario"
        '
        'img_list_login
        '
        Me.img_list_login.ImageStream = CType(resources.GetObject("img_list_login.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img_list_login.TransparentColor = System.Drawing.Color.Transparent
        Me.img_list_login.Images.SetKeyName(0, "UserBlue16.png")
        Me.img_list_login.Images.SetKeyName(1, "CarKey_B_16.png")
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_pass.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_pass.ImageIndex = 1
        Me.lbl_pass.ImageList = Me.img_list_login
        Me.lbl_pass.Location = New System.Drawing.Point(143, 265)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(245, 17)
        Me.lbl_pass.TabIndex = 3
        Me.lbl_pass.Text = "Contraseña"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(143, 314)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(245, 30)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "Ingresar"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Automapic.My.Resources.Resources.user
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(143, 52)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 146)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'pbx_login_loader
        '
        Me.pbx_login_loader.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pbx_login_loader.Location = New System.Drawing.Point(242, 359)
        Me.pbx_login_loader.Name = "pbx_login_loader"
        Me.pbx_login_loader.Size = New System.Drawing.Size(47, 47)
        Me.pbx_login_loader.TabIndex = 7
        Me.pbx_login_loader.TabStop = False
        Me.pbx_login_loader.Visible = False
        '
        'bgw_login
        '
        Me.bgw_login.WorkerReportsProgress = True
        Me.bgw_login.WorkerSupportsCancellation = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(531, 658)
        Me.Controls.Add(Me.tlp_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.tlp_login.ResumeLayout(False)
        Me.tlp_login.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx_login_loader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlp_login As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbx_user As System.Windows.Forms.TextBox
    Friend WithEvents tbx_pass As System.Windows.Forms.TextBox
    Friend WithEvents lbl_user As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents img_list_login As System.Windows.Forms.ImageList
    Friend WithEvents pbx_login_loader As System.Windows.Forms.PictureBox
    Friend WithEvents bgw_login As ComponentModel.BackgroundWorker
End Class
