<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUserPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnLogin = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.lblRegLink = New System.Windows.Forms.LinkLabel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.picLoginLogo = New System.Windows.Forms.PictureBox()
        Me.pnlLoginFooter = New System.Windows.Forms.Panel()
        Me.ctrlbxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.ctrlbxLoginMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        CType(Me.picLoginLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoginFooter.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtUsername.BorderRadius = 5
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.Parent = Me.txtUsername
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.FocusedState.Parent = Me.txtUsername
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.HoverState.Parent = Me.txtUsername
        Me.txtUsername.IconLeft = CType(resources.GetObject("txtUsername.IconLeft"), System.Drawing.Image)
        Me.txtUsername.Location = New System.Drawing.Point(63, 190)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.MaxLength = 25
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.ShadowDecoration.Parent = Me.txtUsername
        Me.txtUsername.Size = New System.Drawing.Size(304, 35)
        Me.txtUsername.TabIndex = 0
        '
        'txtUserPwd
        '
        Me.txtUserPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUserPwd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtUserPwd.BorderRadius = 5
        Me.txtUserPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserPwd.DefaultText = ""
        Me.txtUserPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserPwd.DisabledState.Parent = Me.txtUserPwd
        Me.txtUserPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserPwd.FillColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(16, Byte), Integer))
        Me.txtUserPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserPwd.FocusedState.Parent = Me.txtUserPwd
        Me.txtUserPwd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserPwd.HoverState.Parent = Me.txtUserPwd
        Me.txtUserPwd.IconLeft = CType(resources.GetObject("txtUserPwd.IconLeft"), System.Drawing.Image)
        Me.txtUserPwd.Location = New System.Drawing.Point(63, 242)
        Me.txtUserPwd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserPwd.MaxLength = 25
        Me.txtUserPwd.Name = "txtUserPwd"
        Me.txtUserPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserPwd.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.txtUserPwd.PlaceholderText = "Password"
        Me.txtUserPwd.SelectedText = ""
        Me.txtUserPwd.ShadowDecoration.Parent = Me.txtUserPwd
        Me.txtUserPwd.Size = New System.Drawing.Size(304, 35)
        Me.txtUserPwd.TabIndex = 1
        Me.txtUserPwd.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.AutoRoundedCorners = True
        Me.btnLogin.BorderRadius = 11
        Me.btnLogin.CheckedState.Parent = Me.btnLogin
        Me.btnLogin.CustomImages.Parent = Me.btnLogin
        Me.btnLogin.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnLogin.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.HoverState.Parent = Me.btnLogin
        Me.btnLogin.Location = New System.Drawing.Point(140, 294)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.ShadowDecoration.Parent = Me.btnLogin
        Me.btnLogin.Size = New System.Drawing.Size(150, 35)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Sign In"
        '
        'lblRegLink
        '
        Me.lblRegLink.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.lblRegLink.AutoSize = True
        Me.lblRegLink.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegLink.LinkColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.lblRegLink.Location = New System.Drawing.Point(307, 15)
        Me.lblRegLink.Name = "lblRegLink"
        Me.lblRegLink.Size = New System.Drawing.Size(54, 17)
        Me.lblRegLink.TabIndex = 0
        Me.lblRegLink.TabStop = True
        Me.lblRegLink.Text = "Sign Up"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'picLoginLogo
        '
        Me.picLoginLogo.Image = CType(resources.GetObject("picLoginLogo.Image"), System.Drawing.Image)
        Me.picLoginLogo.Location = New System.Drawing.Point(151, 45)
        Me.picLoginLogo.Name = "picLoginLogo"
        Me.picLoginLogo.Size = New System.Drawing.Size(129, 86)
        Me.picLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLoginLogo.TabIndex = 5
        Me.picLoginLogo.TabStop = False
        '
        'pnlLoginFooter
        '
        Me.pnlLoginFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlLoginFooter.Controls.Add(Me.lblMenu)
        Me.pnlLoginFooter.Controls.Add(Me.lblRegLink)
        Me.pnlLoginFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlLoginFooter.Location = New System.Drawing.Point(0, 384)
        Me.pnlLoginFooter.Name = "pnlLoginFooter"
        Me.pnlLoginFooter.Size = New System.Drawing.Size(430, 46)
        Me.pnlLoginFooter.TabIndex = 6
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
        Me.ctrlbxClose.TabIndex = 7
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(63, 15)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(164, 17)
        Me.lblMenu.TabIndex = 5
        Me.lblMenu.Text = "Don't have an account yet?"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(180, 148)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(71, 25)
        Me.lblLogin.TabIndex = 9
        Me.lblLogin.Text = "Sign In"
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.ctrlbxClose)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(430, 39)
        Me.pnlHeader.TabIndex = 14
        '
        'ctrlbxLoginMin
        '
        Me.ctrlbxLoginMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlbxLoginMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ctrlbxLoginMin.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ctrlbxLoginMin.HoverState.Parent = Me.ctrlbxLoginMin
        Me.ctrlbxLoginMin.IconColor = System.Drawing.Color.White
        Me.ctrlbxLoginMin.Location = New System.Drawing.Point(350, 0)
        Me.ctrlbxLoginMin.Name = "ctrlbxLoginMin"
        Me.ctrlbxLoginMin.ShadowDecoration.Parent = Me.ctrlbxLoginMin
        Me.ctrlbxLoginMin.Size = New System.Drawing.Size(45, 29)
        Me.ctrlbxLoginMin.TabIndex = 8
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlHeader
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 430)
        Me.Controls.Add(Me.ctrlbxLoginMin)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.pnlLoginFooter)
        Me.Controls.Add(Me.picLoginLogo)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUserPwd)
        Me.Controls.Add(Me.txtUsername)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conisch"
        CType(Me.picLoginLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoginFooter.ResumeLayout(False)
        Me.pnlLoginFooter.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUserPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents lblRegLink As LinkLabel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlLoginFooter As Panel
    Friend WithEvents picLoginLogo As PictureBox
    Friend WithEvents ctrlbxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblMenu As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents ctrlbxLoginMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
