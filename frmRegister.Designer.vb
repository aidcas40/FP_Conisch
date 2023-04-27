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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegister))
        Me.txtRegUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRegEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtRegPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.txtConfirmPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLogLink = New System.Windows.Forms.LinkLabel()
        Me.pnlRegFooter = New System.Windows.Forms.Panel()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.picRegLogo = New System.Windows.Forms.PictureBox()
        Me.lblReg = New System.Windows.Forms.Label()
        Me.ctrlbxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlbxRegMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.pnlRegFooter.SuspendLayout()
        CType(Me.picRegLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRegUsername
        '
        Me.txtRegUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRegUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegUsername.BorderRadius = 5
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
        Me.txtRegUsername.Location = New System.Drawing.Point(63, 170)
        Me.txtRegUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegUsername.MaxLength = 25
        Me.txtRegUsername.Name = "txtRegUsername"
        Me.txtRegUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegUsername.PlaceholderText = "Username"
        Me.txtRegUsername.SelectedText = ""
        Me.txtRegUsername.ShadowDecoration.Parent = Me.txtRegUsername
        Me.txtRegUsername.Size = New System.Drawing.Size(304, 35)
        Me.txtRegUsername.TabIndex = 0
        '
        'txtRegEmail
        '
        Me.txtRegEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRegEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegEmail.BorderRadius = 5
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
        Me.txtRegEmail.Location = New System.Drawing.Point(63, 212)
        Me.txtRegEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegEmail.MaxLength = 25
        Me.txtRegEmail.Name = "txtRegEmail"
        Me.txtRegEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegEmail.PlaceholderText = "Email"
        Me.txtRegEmail.SelectedText = ""
        Me.txtRegEmail.ShadowDecoration.Parent = Me.txtRegEmail
        Me.txtRegEmail.Size = New System.Drawing.Size(304, 35)
        Me.txtRegEmail.TabIndex = 1
        '
        'txtRegPwd
        '
        Me.txtRegPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtRegPwd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegPwd.BorderRadius = 5
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
        Me.txtRegPwd.Location = New System.Drawing.Point(63, 254)
        Me.txtRegPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRegPwd.MaxLength = 25
        Me.txtRegPwd.Name = "txtRegPwd"
        Me.txtRegPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRegPwd.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtRegPwd.PlaceholderText = "Password"
        Me.txtRegPwd.SelectedText = ""
        Me.txtRegPwd.ShadowDecoration.Parent = Me.txtRegPwd
        Me.txtRegPwd.Size = New System.Drawing.Size(304, 35)
        Me.txtRegPwd.TabIndex = 2
        Me.txtRegPwd.UseSystemPasswordChar = True
        '
        'btnRegister
        '
        Me.btnRegister.AutoRoundedCorners = True
        Me.btnRegister.BorderRadius = 11
        Me.btnRegister.CheckedState.Parent = Me.btnRegister
        Me.btnRegister.CustomImages.Parent = Me.btnRegister
        Me.btnRegister.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnRegister.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.HoverState.Parent = Me.btnRegister
        Me.btnRegister.Location = New System.Drawing.Point(150, 338)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.ShadowDecoration.Parent = Me.btnRegister
        Me.btnRegister.Size = New System.Drawing.Size(130, 35)
        Me.btnRegister.TabIndex = 4
        Me.btnRegister.Text = "Sign Up"
        '
        'txtConfirmPwd
        '
        Me.txtConfirmPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtConfirmPwd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtConfirmPwd.BorderRadius = 5
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
        Me.txtConfirmPwd.Location = New System.Drawing.Point(63, 296)
        Me.txtConfirmPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtConfirmPwd.MaxLength = 25
        Me.txtConfirmPwd.Name = "txtConfirmPwd"
        Me.txtConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtConfirmPwd.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtConfirmPwd.PlaceholderText = "Confirm Password"
        Me.txtConfirmPwd.SelectedText = ""
        Me.txtConfirmPwd.ShadowDecoration.Parent = Me.txtConfirmPwd
        Me.txtConfirmPwd.Size = New System.Drawing.Size(304, 35)
        Me.txtConfirmPwd.TabIndex = 3
        Me.txtConfirmPwd.UseSystemPasswordChar = True
        '
        'lblLogLink
        '
        Me.lblLogLink.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblLogLink.AutoSize = True
        Me.lblLogLink.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblLogLink.Location = New System.Drawing.Point(317, 15)
        Me.lblLogLink.Name = "lblLogLink"
        Me.lblLogLink.Size = New System.Drawing.Size(50, 16)
        Me.lblLogLink.TabIndex = 0
        Me.lblLogLink.TabStop = True
        Me.lblLogLink.Text = "Sign In"
        '
        'pnlRegFooter
        '
        Me.pnlRegFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlRegFooter.Controls.Add(Me.lblMenu)
        Me.pnlRegFooter.Controls.Add(Me.lblLogLink)
        Me.pnlRegFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlRegFooter.Location = New System.Drawing.Point(0, 404)
        Me.pnlRegFooter.Name = "pnlRegFooter"
        Me.pnlRegFooter.Size = New System.Drawing.Size(430, 46)
        Me.pnlRegFooter.TabIndex = 7
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(63, 15)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(156, 17)
        Me.lblMenu.TabIndex = 5
        Me.lblMenu.Text = "Already have an account?"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'picRegLogo
        '
        Me.picRegLogo.Image = CType(resources.GetObject("picRegLogo.Image"), System.Drawing.Image)
        Me.picRegLogo.Location = New System.Drawing.Point(151, 45)
        Me.picRegLogo.Name = "picRegLogo"
        Me.picRegLogo.Size = New System.Drawing.Size(129, 86)
        Me.picRegLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picRegLogo.TabIndex = 8
        Me.picRegLogo.TabStop = False
        '
        'lblReg
        '
        Me.lblReg.AutoSize = True
        Me.lblReg.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReg.ForeColor = System.Drawing.Color.White
        Me.lblReg.Location = New System.Drawing.Point(180, 138)
        Me.lblReg.Name = "lblReg"
        Me.lblReg.Size = New System.Drawing.Size(71, 25)
        Me.lblReg.TabIndex = 10
        Me.lblReg.Text = "Sign In"
        '
        'ctrlbxClose
        '
        Me.ctrlbxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlbxClose.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ctrlbxClose.HoverState.Parent = Me.ctrlbxClose
        Me.ctrlbxClose.IconColor = System.Drawing.Color.White
        Me.ctrlbxClose.Location = New System.Drawing.Point(385, 0)
        Me.ctrlbxClose.Name = "ctrlbxClose"
        Me.ctrlbxClose.ShadowDecoration.Parent = Me.ctrlbxClose
        Me.ctrlbxClose.Size = New System.Drawing.Size(45, 29)
        Me.ctrlbxClose.TabIndex = 11
        '
        'ctrlbxRegMin
        '
        Me.ctrlbxRegMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlbxRegMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ctrlbxRegMin.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ctrlbxRegMin.HoverState.Parent = Me.ctrlbxRegMin
        Me.ctrlbxRegMin.IconColor = System.Drawing.Color.White
        Me.ctrlbxRegMin.Location = New System.Drawing.Point(350, 0)
        Me.ctrlbxRegMin.Name = "ctrlbxRegMin"
        Me.ctrlbxRegMin.ShadowDecoration.Parent = Me.ctrlbxRegMin
        Me.ctrlbxRegMin.Size = New System.Drawing.Size(45, 29)
        Me.ctrlbxRegMin.TabIndex = 12
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.ctrlbxClose)
        Me.pnlHeader.Controls.Add(Me.ctrlbxRegMin)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(430, 39)
        Me.pnlHeader.TabIndex = 13
        '
        'frmRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 450)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.lblReg)
        Me.Controls.Add(Me.picRegLogo)
        Me.Controls.Add(Me.pnlRegFooter)
        Me.Controls.Add(Me.txtConfirmPwd)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtRegPwd)
        Me.Controls.Add(Me.txtRegEmail)
        Me.Controls.Add(Me.txtRegUsername)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conisch"
        Me.pnlRegFooter.ResumeLayout(False)
        Me.pnlRegFooter.PerformLayout()
        CType(Me.picRegLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRegUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtRegPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents txtConfirmPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLogLink As LinkLabel
    Friend WithEvents pnlRegFooter As Panel
    Friend WithEvents lblMenu As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents picRegLogo As PictureBox
    Friend WithEvents lblReg As Label
    Friend WithEvents ctrlbxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlbxRegMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
