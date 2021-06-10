<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class email
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtfrom = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtsubject = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtto = New Guna.UI2.WinForms.Guna2TextBox()
        Me.message = New System.Windows.Forms.RichTextBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Subject"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "TO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Message"
        '
        'txtfrom
        '
        Me.txtfrom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfrom.DefaultText = ""
        Me.txtfrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfrom.DisabledState.Parent = Me.txtfrom
        Me.txtfrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfrom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfrom.FocusedState.Parent = Me.txtfrom
        Me.txtfrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtfrom.ForeColor = System.Drawing.Color.Black
        Me.txtfrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfrom.HoverState.Parent = Me.txtfrom
        Me.txtfrom.Location = New System.Drawing.Point(187, 76)
        Me.txtfrom.Name = "txtfrom"
        Me.txtfrom.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfrom.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtfrom.PlaceholderText = ""
        Me.txtfrom.SelectedText = ""
        Me.txtfrom.ShadowDecoration.Parent = Me.txtfrom
        Me.txtfrom.Size = New System.Drawing.Size(319, 40)
        Me.txtfrom.TabIndex = 4
        '
        'txtsubject
        '
        Me.txtsubject.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsubject.DefaultText = ""
        Me.txtsubject.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsubject.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsubject.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsubject.DisabledState.Parent = Me.txtsubject
        Me.txtsubject.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsubject.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsubject.FocusedState.Parent = Me.txtsubject
        Me.txtsubject.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtsubject.ForeColor = System.Drawing.Color.Black
        Me.txtsubject.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsubject.HoverState.Parent = Me.txtsubject
        Me.txtsubject.Location = New System.Drawing.Point(187, 136)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsubject.PlaceholderText = ""
        Me.txtsubject.SelectedText = ""
        Me.txtsubject.ShadowDecoration.Parent = Me.txtsubject
        Me.txtsubject.Size = New System.Drawing.Size(319, 41)
        Me.txtsubject.TabIndex = 5
        '
        'txtto
        '
        Me.txtto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtto.DefaultText = ""
        Me.txtto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtto.DisabledState.Parent = Me.txtto
        Me.txtto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtto.FocusedState.Parent = Me.txtto
        Me.txtto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtto.ForeColor = System.Drawing.Color.Black
        Me.txtto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtto.HoverState.Parent = Me.txtto
        Me.txtto.Location = New System.Drawing.Point(187, 196)
        Me.txtto.Name = "txtto"
        Me.txtto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtto.PlaceholderText = ""
        Me.txtto.SelectedText = ""
        Me.txtto.ShadowDecoration.Parent = Me.txtto
        Me.txtto.Size = New System.Drawing.Size(319, 41)
        Me.txtto.TabIndex = 6
        '
        'message
        '
        Me.message.Location = New System.Drawing.Point(187, 264)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(392, 164)
        Me.message.TabIndex = 7
        Me.message.Text = ""
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(187, 471)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(392, 62)
        Me.Guna2Button1.TabIndex = 8
        Me.Guna2Button1.Text = "SENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(350, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 36)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email"
        '
        'email
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.first.My.Resources.Resources._69867587
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(903, 579)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.txtto)
        Me.Controls.Add(Me.txtsubject)
        Me.Controls.Add(Me.txtfrom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "email"
        Me.Text = "email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfrom As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtsubject As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents message As RichTextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
End Class
