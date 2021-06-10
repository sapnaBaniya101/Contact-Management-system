<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.minimize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.maximize = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.btnclose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2GradientButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton3 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton4 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton5 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2GradientButton6 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.homepnl = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.minimize)
        Me.Guna2Panel1.Controls.Add(Me.maximize)
        Me.Guna2Panel1.Controls.Add(Me.btnclose)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(995, 44)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox2.BorderRadius = 2
        Me.Guna2PictureBox2.FillColor = System.Drawing.Color.White
        Me.Guna2PictureBox2.Image = Global.first.My.Resources.Resources.iconfinder_logout_account_exit_door_3005766
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(667, 10)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(33, 31)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox2.TabIndex = 12
        Me.Guna2PictureBox2.TabStop = False
        Me.Guna2PictureBox2.UseTransparentBackground = True
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.BorderColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(667, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(152, 38)
        Me.Guna2Button1.TabIndex = 11
        Me.Guna2Button1.Text = "Log Out"
        '
        'minimize
        '
        Me.minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minimize.BackColor = System.Drawing.Color.Transparent
        Me.minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.minimize.FillColor = System.Drawing.Color.Transparent
        Me.minimize.HoverState.FillColor = System.Drawing.Color.White
        Me.minimize.HoverState.Parent = Me.minimize
        Me.minimize.IconColor = System.Drawing.Color.Black
        Me.minimize.Location = New System.Drawing.Point(888, 0)
        Me.minimize.Name = "minimize"
        Me.minimize.ShadowDecoration.Parent = Me.minimize
        Me.minimize.Size = New System.Drawing.Size(38, 32)
        Me.minimize.TabIndex = 10
        '
        'maximize
        '
        Me.maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maximize.BackColor = System.Drawing.Color.Transparent
        Me.maximize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.maximize.FillColor = System.Drawing.Color.Transparent
        Me.maximize.HoverState.FillColor = System.Drawing.Color.White
        Me.maximize.HoverState.Parent = Me.maximize
        Me.maximize.IconColor = System.Drawing.Color.Black
        Me.maximize.Location = New System.Drawing.Point(922, 0)
        Me.maximize.Name = "maximize"
        Me.maximize.ShadowDecoration.Parent = Me.maximize
        Me.maximize.Size = New System.Drawing.Size(38, 32)
        Me.maximize.TabIndex = 9
        '
        'btnclose
        '
        Me.btnclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnclose.BackColor = System.Drawing.Color.Transparent
        Me.btnclose.FillColor = System.Drawing.Color.Transparent
        Me.btnclose.HoverState.FillColor = System.Drawing.Color.White
        Me.btnclose.HoverState.Parent = Me.btnclose
        Me.btnclose.IconColor = System.Drawing.Color.Black
        Me.btnclose.Location = New System.Drawing.Point(957, 0)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.ShadowDecoration.Parent = Me.btnclose
        Me.btnclose.Size = New System.Drawing.Size(38, 32)
        Me.btnclose.TabIndex = 8
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackgroundImage = Global.first.My.Resources.Resources.contact_logo_emblem_contact_logo_emblem_logo_design_template_vector_104292504
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(223, 196)
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2GradientButton1
        '
        Me.Guna2GradientButton1.BorderThickness = 1
        Me.Guna2GradientButton1.CheckedState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.CustomImages.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Guna2GradientButton1.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton1.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton1.HoverState.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Location = New System.Drawing.Point(0, 202)
        Me.Guna2GradientButton1.Name = "Guna2GradientButton1"
        Me.Guna2GradientButton1.ShadowDecoration.Parent = Me.Guna2GradientButton1
        Me.Guna2GradientButton1.Size = New System.Drawing.Size(223, 68)
        Me.Guna2GradientButton1.TabIndex = 2
        Me.Guna2GradientButton1.Text = "Home"
        '
        'Guna2GradientButton2
        '
        Me.Guna2GradientButton2.BorderThickness = 1
        Me.Guna2GradientButton2.CheckedState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.CustomImages.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Guna2GradientButton2.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton2.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton2.HoverState.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Location = New System.Drawing.Point(0, 267)
        Me.Guna2GradientButton2.Name = "Guna2GradientButton2"
        Me.Guna2GradientButton2.ShadowDecoration.Parent = Me.Guna2GradientButton2
        Me.Guna2GradientButton2.Size = New System.Drawing.Size(223, 60)
        Me.Guna2GradientButton2.TabIndex = 3
        Me.Guna2GradientButton2.Text = "Profile"
        '
        'Guna2GradientButton3
        '
        Me.Guna2GradientButton3.BorderThickness = 1
        Me.Guna2GradientButton3.CheckedState.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.CustomImages.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Guna2GradientButton3.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton3.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton3.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton3.HoverState.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.Location = New System.Drawing.Point(0, 322)
        Me.Guna2GradientButton3.Name = "Guna2GradientButton3"
        Me.Guna2GradientButton3.ShadowDecoration.Parent = Me.Guna2GradientButton3
        Me.Guna2GradientButton3.Size = New System.Drawing.Size(223, 58)
        Me.Guna2GradientButton3.TabIndex = 4
        Me.Guna2GradientButton3.Text = "Contact"
        '
        'Guna2GradientButton4
        '
        Me.Guna2GradientButton4.BorderThickness = 1
        Me.Guna2GradientButton4.CheckedState.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.CustomImages.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Guna2GradientButton4.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton4.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton4.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton4.HoverState.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.Location = New System.Drawing.Point(0, 376)
        Me.Guna2GradientButton4.Name = "Guna2GradientButton4"
        Me.Guna2GradientButton4.ShadowDecoration.Parent = Me.Guna2GradientButton4
        Me.Guna2GradientButton4.Size = New System.Drawing.Size(223, 62)
        Me.Guna2GradientButton4.TabIndex = 5
        Me.Guna2GradientButton4.Text = "Email"
        '
        'Guna2GradientButton5
        '
        Me.Guna2GradientButton5.BorderThickness = 1
        Me.Guna2GradientButton5.CheckedState.Parent = Me.Guna2GradientButton5
        Me.Guna2GradientButton5.CustomImages.Parent = Me.Guna2GradientButton5
        Me.Guna2GradientButton5.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Guna2GradientButton5.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton5.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton5.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton5.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton5.HoverState.Parent = Me.Guna2GradientButton5
        Me.Guna2GradientButton5.Location = New System.Drawing.Point(0, 435)
        Me.Guna2GradientButton5.Name = "Guna2GradientButton5"
        Me.Guna2GradientButton5.ShadowDecoration.Parent = Me.Guna2GradientButton5
        Me.Guna2GradientButton5.Size = New System.Drawing.Size(223, 58)
        Me.Guna2GradientButton5.TabIndex = 6
        Me.Guna2GradientButton5.Text = "Group"
        '
        'Guna2GradientButton6
        '
        Me.Guna2GradientButton6.BorderThickness = 1
        Me.Guna2GradientButton6.CheckedState.Parent = Me.Guna2GradientButton6
        Me.Guna2GradientButton6.CustomImages.Parent = Me.Guna2GradientButton6
        Me.Guna2GradientButton6.FillColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Guna2GradientButton6.FillColor2 = System.Drawing.Color.Gray
        Me.Guna2GradientButton6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton6.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientButton6.HoverState.BorderColor = System.Drawing.Color.White
        Me.Guna2GradientButton6.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientButton6.HoverState.Parent = Me.Guna2GradientButton6
        Me.Guna2GradientButton6.Location = New System.Drawing.Point(0, 490)
        Me.Guna2GradientButton6.Name = "Guna2GradientButton6"
        Me.Guna2GradientButton6.ShadowDecoration.Parent = Me.Guna2GradientButton6
        Me.Guna2GradientButton6.Size = New System.Drawing.Size(223, 64)
        Me.Guna2GradientButton6.TabIndex = 7
        Me.Guna2GradientButton6.Text = "Setting"
        '
        'homepnl
        '
        Me.homepnl.BackColor = System.Drawing.Color.Transparent
        Me.homepnl.Location = New System.Drawing.Point(229, 50)
        Me.homepnl.Name = "homepnl"
        Me.homepnl.ShadowDecoration.Parent = Me.homepnl
        Me.homepnl.Size = New System.Drawing.Size(766, 548)
        Me.homepnl.TabIndex = 8
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 20
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2AnimateWindow1
        '
        Me.Guna2AnimateWindow1.TargetForm = Me
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.first.My.Resources.Resources.working_from_home_death_knell_offices
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 599)
        Me.Controls.Add(Me.homepnl)
        Me.Controls.Add(Me.Guna2GradientButton6)
        Me.Controls.Add(Me.Guna2GradientButton5)
        Me.Controls.Add(Me.Guna2GradientButton4)
        Me.Controls.Add(Me.Guna2GradientButton3)
        Me.Controls.Add(Me.Guna2GradientButton2)
        Me.Controls.Add(Me.Guna2GradientButton1)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "home"
        Me.Text = "home"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2GradientButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton3 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton4 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton5 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2GradientButton6 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnclose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents maximize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents minimize As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents homepnl As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
End Class
