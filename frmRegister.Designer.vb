<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.txtRegUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRegEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRegPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtConfirmPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLogLink = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'txtRegUsername
        '
        Me.txtRegUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRegUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegUsername.BorderRadius = 15
        Me.txtRegUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegUsername.DefaultText = ""
        Me.txtRegUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegUsername.DisabledState.Parent = Me.txtRegUsername
        Me.txtRegUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.txtRegUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegUsername.FocusedState.Parent = Me.txtRegUsername
        Me.txtRegUsername.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegUsername.HoverState.Parent = Me.txtRegUsername
        Me.txtRegUsername.IconLeft = CType(resources.GetObject("txtRegUsername.IconLeft"), System.Drawing.Image)
        Me.txtRegUsername.Location = New System.Drawing.Point(284, 135)
        Me.txtRegUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegUsername.PlaceholderText = "Username"
        Me.txtRegUsername.SelectedText = ""
        Me.txtRegUsername.ShadowDecoration.Parent = Me.txtRegUsername
        Me.txtRegUsername.Size = New System.Drawing.Size(232, 35)
        Me.txtRegUsername.TabIndex = 1
        '
        'txtRegEmail
        '
        Me.txtRegEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRegEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegEmail.BorderRadius = 15
        Me.txtRegEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegEmail.DefaultText = ""
        Me.txtRegEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegEmail.DisabledState.Parent = Me.txtRegEmail
        Me.txtRegEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.txtRegEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegEmail.FocusedState.Parent = Me.txtRegEmail
        Me.txtRegEmail.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegEmail.HoverState.Parent = Me.txtRegEmail
        Me.txtRegEmail.IconLeft = CType(resources.GetObject("txtRegEmail.IconLeft"), System.Drawing.Image)
        Me.txtRegEmail.Location = New System.Drawing.Point(284, 180)
        Me.txtRegEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegEmail.Name = "txtRegEmail"
        Me.txtRegEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegEmail.PlaceholderText = "Email"
        Me.txtRegEmail.SelectedText = ""
        Me.txtRegEmail.ShadowDecoration.Parent = Me.txtRegEmail
        Me.txtRegEmail.Size = New System.Drawing.Size(232, 35)
        Me.txtRegEmail.TabIndex = 2
        '
        'txtRegPwd
        '
        Me.txtRegPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRegPwd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegPwd.BorderRadius = 15
        Me.txtRegPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRegPwd.DefaultText = ""
        Me.txtRegPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtRegPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtRegPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegPwd.DisabledState.Parent = Me.txtRegPwd
        Me.txtRegPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRegPwd.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.txtRegPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegPwd.FocusedState.Parent = Me.txtRegPwd
        Me.txtRegPwd.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtRegPwd.HoverState.Parent = Me.txtRegPwd
        Me.txtRegPwd.IconLeft = CType(resources.GetObject("txtRegPwd.IconLeft"), System.Drawing.Image)
        Me.txtRegPwd.Location = New System.Drawing.Point(284, 225)
        Me.txtRegPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegPwd.Name = "txtRegPwd"
        Me.txtRegPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegPwd.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegPwd.PlaceholderText = "Password"
        Me.txtRegPwd.SelectedText = ""
        Me.txtRegPwd.ShadowDecoration.Parent = Me.txtRegPwd
        Me.txtRegPwd.Size = New System.Drawing.Size(232, 35)
        Me.txtRegPwd.TabIndex = 3
        Me.txtRegPwd.UseSystemPasswordChar = True
        '
        'btnRegister
        '
        Me.btnRegister.AutoRoundedCorners = True
        Me.btnRegister.BorderRadius = 16
        Me.btnRegister.CheckedState.Parent = Me.btnRegister
        Me.btnRegister.CustomImages.Parent = Me.btnRegister
        Me.btnRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnRegister.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.HoverState.Parent = Me.btnRegister
        Me.btnRegister.Location = New System.Drawing.Point(284, 312)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.ShadowDecoration.Parent = Me.btnRegister
        Me.btnRegister.Size = New System.Drawing.Size(130, 35)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "REGISTER"
        '
        'txtConfirmPwd
        '
        Me.txtConfirmPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtConfirmPwd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtConfirmPwd.BorderRadius = 15
        Me.txtConfirmPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConfirmPwd.DefaultText = ""
        Me.txtConfirmPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtConfirmPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtConfirmPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPwd.DisabledState.Parent = Me.txtConfirmPwd
        Me.txtConfirmPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtConfirmPwd.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.txtConfirmPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPwd.FocusedState.Parent = Me.txtConfirmPwd
        Me.txtConfirmPwd.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtConfirmPwd.HoverState.Parent = Me.txtConfirmPwd
        Me.txtConfirmPwd.IconLeft = CType(resources.GetObject("txtConfirmPwd.IconLeft"), System.Drawing.Image)
        Me.txtConfirmPwd.Location = New System.Drawing.Point(284, 270)
        Me.txtConfirmPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPwd.Name = "txtConfirmPwd"
        Me.txtConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPwd.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtConfirmPwd.PlaceholderText = "Confirm Password"
        Me.txtConfirmPwd.SelectedText = ""
        Me.txtConfirmPwd.ShadowDecoration.Parent = Me.txtConfirmPwd
        Me.txtConfirmPwd.Size = New System.Drawing.Size(232, 35)
        Me.txtConfirmPwd.TabIndex = 5
        Me.txtConfirmPwd.UseSystemPasswordChar = True
        '
        'lblLogLink
        '
        Me.lblLogLink.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblLogLink.AutoSize = True
        Me.lblLogLink.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblLogLink.Location = New System.Drawing.Point(415, 321)
        Me.lblLogLink.Name = "lblLogLink"
        Me.lblLogLink.Size = New System.Drawing.Size(101, 16)
        Me.lblLogLink.TabIndex = 6
        Me.lblLogLink.TabStop = True
        Me.lblLogLink.Text = "Back To Login?"
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblLogLink)
        Me.Controls.Add(Me.txtConfirmPwd)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtRegPwd)
        Me.Controls.Add(Me.txtRegEmail)
        Me.Controls.Add(Me.txtRegUsername)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conisch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRegUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtConfirmPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLogLink As LinkLabel
End Class
