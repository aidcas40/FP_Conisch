<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlbxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlbxMax = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlbxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.btnUpload = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSongs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnYourSongs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDiscover = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.pnlPlayer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlBar.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'pnlBar
        '
        Me.pnlBar.Controls.Add(Me.ctrlbxMin)
        Me.pnlBar.Controls.Add(Me.ctrlbxMax)
        Me.pnlBar.Controls.Add(Me.ctrlbxClose)
        Me.pnlBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBar.Location = New System.Drawing.Point(0, 0)
        Me.pnlBar.Name = "pnlBar"
        Me.pnlBar.ShadowDecoration.Parent = Me.pnlBar
        Me.pnlBar.Size = New System.Drawing.Size(1220, 28)
        Me.pnlBar.TabIndex = 0
        '
        'ctrlbxMin
        '
        Me.ctrlbxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlbxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ctrlbxMin.FillColor = System.Drawing.Color.Transparent
        Me.ctrlbxMin.HoverState.Parent = Me.ctrlbxMin
        Me.ctrlbxMin.IconColor = System.Drawing.Color.White
        Me.ctrlbxMin.Location = New System.Drawing.Point(1124, 5)
        Me.ctrlbxMin.Name = "ctrlbxMin"
        Me.ctrlbxMin.ShadowDecoration.Parent = Me.ctrlbxMin
        Me.ctrlbxMin.Size = New System.Drawing.Size(24, 20)
        Me.ctrlbxMin.TabIndex = 4
        '
        'ctrlbxMax
        '
        Me.ctrlbxMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlbxMax.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.ctrlbxMax.FillColor = System.Drawing.Color.Transparent
        Me.ctrlbxMax.HoverState.Parent = Me.ctrlbxMax
        Me.ctrlbxMax.IconColor = System.Drawing.Color.White
        Me.ctrlbxMax.Location = New System.Drawing.Point(1154, 5)
        Me.ctrlbxMax.Name = "ctrlbxMax"
        Me.ctrlbxMax.ShadowDecoration.Parent = Me.ctrlbxMax
        Me.ctrlbxMax.Size = New System.Drawing.Size(24, 20)
        Me.ctrlbxMax.TabIndex = 4
        '
        'ctrlbxClose
        '
        Me.ctrlbxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlbxClose.FillColor = System.Drawing.Color.Transparent
        Me.ctrlbxClose.HoverState.Parent = Me.ctrlbxClose
        Me.ctrlbxClose.IconColor = System.Drawing.Color.White
        Me.ctrlbxClose.Location = New System.Drawing.Point(1184, 5)
        Me.ctrlbxClose.Name = "ctrlbxClose"
        Me.ctrlbxClose.ShadowDecoration.Parent = Me.ctrlbxClose
        Me.ctrlbxClose.Size = New System.Drawing.Size(24, 20)
        Me.ctrlbxClose.TabIndex = 3
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoScroll = True
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.lblGeneral)
        Me.pnlMenu.Controls.Add(Me.btnUpload)
        Me.pnlMenu.Controls.Add(Me.btnSongs)
        Me.pnlMenu.Controls.Add(Me.btnUsers)
        Me.pnlMenu.Controls.Add(Me.btnYourSongs)
        Me.pnlMenu.Controls.Add(Me.btnDiscover)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Controls.Add(Me.lblMenu)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 28)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShadowDecoration.Parent = Me.pnlMenu
        Me.pnlMenu.Size = New System.Drawing.Size(200, 471)
        Me.pnlMenu.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.BorderRadius = 10
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnLogout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnLogout.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnLogout.HoverState.Image = CType(resources.GetObject("btnLogout.HoverState.Image"), System.Drawing.Image)
        Me.btnLogout.HoverState.Parent = Me.btnLogout
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.Location = New System.Drawing.Point(12, 405)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.ShadowDecoration.Parent = Me.btnLogout
        Me.btnLogout.Size = New System.Drawing.Size(180, 45)
        Me.btnLogout.TabIndex = 8
        Me.btnLogout.Text = "About Program"
        Me.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnLogout.TextOffset = New System.Drawing.Point(27, 0)
        '
        'lblGeneral
        '
        Me.lblGeneral.AutoSize = True
        Me.lblGeneral.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeneral.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lblGeneral.Location = New System.Drawing.Point(12, 385)
        Me.lblGeneral.Name = "lblGeneral"
        Me.lblGeneral.Size = New System.Drawing.Size(55, 17)
        Me.lblGeneral.TabIndex = 7
        Me.lblGeneral.Text = "General"
        '
        'btnUpload
        '
        Me.btnUpload.BorderRadius = 10
        Me.btnUpload.CheckedState.Parent = Me.btnUpload
        Me.btnUpload.CustomImages.Parent = Me.btnUpload
        Me.btnUpload.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpload.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnUpload.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUpload.HoverState.Image = CType(resources.GetObject("btnUpload.HoverState.Image"), System.Drawing.Image)
        Me.btnUpload.HoverState.Parent = Me.btnUpload
        Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Image)
        Me.btnUpload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpload.Location = New System.Drawing.Point(12, 223)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.ShadowDecoration.Parent = Me.btnUpload
        Me.btnUpload.Size = New System.Drawing.Size(180, 45)
        Me.btnUpload.TabIndex = 6
        Me.btnUpload.Text = "Upload Song"
        Me.btnUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpload.TextOffset = New System.Drawing.Point(27, 0)
        '
        'btnSongs
        '
        Me.btnSongs.BorderRadius = 10
        Me.btnSongs.CheckedState.Parent = Me.btnSongs
        Me.btnSongs.CustomImages.Parent = Me.btnSongs
        Me.btnSongs.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSongs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnSongs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnSongs.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnSongs.HoverState.Image = CType(resources.GetObject("btnSongs.HoverState.Image"), System.Drawing.Image)
        Me.btnSongs.HoverState.Parent = Me.btnSongs
        Me.btnSongs.Image = CType(resources.GetObject("btnSongs.Image"), System.Drawing.Image)
        Me.btnSongs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSongs.Location = New System.Drawing.Point(12, 323)
        Me.btnSongs.Name = "btnSongs"
        Me.btnSongs.ShadowDecoration.Parent = Me.btnSongs
        Me.btnSongs.Size = New System.Drawing.Size(180, 45)
        Me.btnSongs.TabIndex = 5
        Me.btnSongs.Text = "Songs"
        Me.btnSongs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSongs.TextOffset = New System.Drawing.Point(27, 0)
        '
        'btnUsers
        '
        Me.btnUsers.BorderRadius = 10
        Me.btnUsers.CheckedState.Parent = Me.btnUsers
        Me.btnUsers.CustomImages.Parent = Me.btnUsers
        Me.btnUsers.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnUsers.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUsers.HoverState.Image = CType(resources.GetObject("btnUsers.HoverState.Image"), System.Drawing.Image)
        Me.btnUsers.HoverState.Parent = Me.btnUsers
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.Location = New System.Drawing.Point(12, 273)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.ShadowDecoration.Parent = Me.btnUsers
        Me.btnUsers.Size = New System.Drawing.Size(180, 45)
        Me.btnUsers.TabIndex = 4
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUsers.TextOffset = New System.Drawing.Point(27, 0)
        '
        'btnYourSongs
        '
        Me.btnYourSongs.BorderRadius = 10
        Me.btnYourSongs.CheckedState.Parent = Me.btnYourSongs
        Me.btnYourSongs.CustomImages.Parent = Me.btnYourSongs
        Me.btnYourSongs.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnYourSongs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnYourSongs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnYourSongs.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnYourSongs.HoverState.Image = CType(resources.GetObject("btnYourSongs.HoverState.Image"), System.Drawing.Image)
        Me.btnYourSongs.HoverState.Parent = Me.btnYourSongs
        Me.btnYourSongs.Image = CType(resources.GetObject("btnYourSongs.Image"), System.Drawing.Image)
        Me.btnYourSongs.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnYourSongs.Location = New System.Drawing.Point(12, 173)
        Me.btnYourSongs.Name = "btnYourSongs"
        Me.btnYourSongs.ShadowDecoration.Parent = Me.btnYourSongs
        Me.btnYourSongs.Size = New System.Drawing.Size(180, 45)
        Me.btnYourSongs.TabIndex = 3
        Me.btnYourSongs.Text = "Your Songs"
        Me.btnYourSongs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnYourSongs.TextOffset = New System.Drawing.Point(27, 0)
        '
        'btnDiscover
        '
        Me.btnDiscover.BorderRadius = 10
        Me.btnDiscover.CheckedState.Parent = Me.btnDiscover
        Me.btnDiscover.CustomImages.Parent = Me.btnDiscover
        Me.btnDiscover.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnDiscover.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDiscover.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnDiscover.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnDiscover.HoverState.Image = CType(resources.GetObject("btnDiscover.HoverState.Image"), System.Drawing.Image)
        Me.btnDiscover.HoverState.Parent = Me.btnDiscover
        Me.btnDiscover.Image = CType(resources.GetObject("btnDiscover.Image"), System.Drawing.Image)
        Me.btnDiscover.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDiscover.Location = New System.Drawing.Point(12, 123)
        Me.btnDiscover.Name = "btnDiscover"
        Me.btnDiscover.ShadowDecoration.Parent = Me.btnDiscover
        Me.btnDiscover.Size = New System.Drawing.Size(180, 45)
        Me.btnDiscover.TabIndex = 2
        Me.btnDiscover.Text = "Discover"
        Me.btnDiscover.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnDiscover.TextOffset = New System.Drawing.Point(27, 0)
        '
        'btnHome
        '
        Me.btnHome.BorderRadius = 10
        Me.btnHome.CheckedState.Parent = Me.btnHome
        Me.btnHome.CustomImages.Parent = Me.btnHome
        Me.btnHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnHome.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnHome.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnHome.HoverState.Image = CType(resources.GetObject("btnHome.HoverState.Image"), System.Drawing.Image)
        Me.btnHome.HoverState.Parent = Me.btnHome
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.Location = New System.Drawing.Point(12, 73)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.ShadowDecoration.Parent = Me.btnHome
        Me.btnHome.Size = New System.Drawing.Size(180, 45)
        Me.btnHome.TabIndex = 1
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnHome.TextOffset = New System.Drawing.Point(27, 0)
        '
        'lblMenu
        '
        Me.lblMenu.AutoSize = True
        Me.lblMenu.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.lblMenu.Location = New System.Drawing.Point(12, 53)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(46, 17)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "MENU"
        '
        'pnlPlayer
        '
        Me.pnlPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.pnlPlayer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPlayer.Location = New System.Drawing.Point(0, 499)
        Me.pnlPlayer.Name = "pnlPlayer"
        Me.pnlPlayer.ShadowDecoration.Parent = Me.pnlPlayer
        Me.pnlPlayer.Size = New System.Drawing.Size(1220, 105)
        Me.pnlPlayer.TabIndex = 2
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.pnlBar
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1220, 604)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlBar)
        Me.Controls.Add(Me.pnlPlayer)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMain"
        Me.pnlBar.ResumeLayout(False)
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlMenu As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlBar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ctrlbxMin As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlbxMax As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents ctrlbxClose As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlPlayer As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblMenu As Label
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnYourSongs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnDiscover As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUpload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSongs As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblGeneral As Label
End Class
