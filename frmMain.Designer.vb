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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.pnlUpload = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnTrkInsert = New Guna.UI2.WinForms.Guna2Button()
        Me.txtGenre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnChooseUpload = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFtArtist = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.picTrkPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtArtist = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUploadHead = New System.Windows.Forms.Label()
        Me.txtTrkName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlSongs = New Guna.UI2.WinForms.Guna2Panel()
        Me.dgvSongs = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.trk_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_artist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_picture = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_featartist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_created = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.trk_delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblAddImage = New System.Windows.Forms.Label()
        Me.pnlBar.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlUpload.SuspendLayout()
        CType(Me.picTrkPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSongs.SuspendLayout()
        CType(Me.dgvSongs, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlBar.Location = New System.Drawing.Point(200, 0)
        Me.pnlBar.Name = "pnlBar"
        Me.pnlBar.ShadowDecoration.Parent = Me.pnlBar
        Me.pnlBar.Size = New System.Drawing.Size(1020, 28)
        Me.pnlBar.TabIndex = 0
        '
        'ctrlbxMin
        '
        Me.ctrlbxMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ctrlbxMin.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.ctrlbxMin.FillColor = System.Drawing.Color.Transparent
        Me.ctrlbxMin.HoverState.Parent = Me.ctrlbxMin
        Me.ctrlbxMin.IconColor = System.Drawing.Color.White
        Me.ctrlbxMin.Location = New System.Drawing.Point(924, 5)
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
        Me.ctrlbxMax.Location = New System.Drawing.Point(954, 5)
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
        Me.ctrlbxClose.Location = New System.Drawing.Point(984, 5)
        Me.ctrlbxClose.Name = "ctrlbxClose"
        Me.ctrlbxClose.ShadowDecoration.Parent = Me.ctrlbxClose
        Me.ctrlbxClose.Size = New System.Drawing.Size(24, 20)
        Me.ctrlbxClose.TabIndex = 3
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoScroll = True
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
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
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShadowDecoration.Parent = Me.pnlMenu
        Me.pnlMenu.Size = New System.Drawing.Size(200, 499)
        Me.pnlMenu.TabIndex = 1
        '
        'btnLogout
        '
        Me.btnLogout.BorderRadius = 10
        Me.btnLogout.CheckedState.Parent = Me.btnLogout
        Me.btnLogout.CustomImages.Parent = Me.btnLogout
        Me.btnLogout.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
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
        Me.btnUpload.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
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
        Me.btnSongs.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
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
        Me.btnUsers.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
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
        Me.btnYourSongs.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
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
        Me.btnDiscover.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
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
        Me.btnHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
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
        'pnlUpload
        '
        Me.pnlUpload.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlUpload.BackColor = System.Drawing.Color.White
        Me.pnlUpload.Controls.Add(Me.lblAddImage)
        Me.pnlUpload.Controls.Add(Me.btnTrkInsert)
        Me.pnlUpload.Controls.Add(Me.txtGenre)
        Me.pnlUpload.Controls.Add(Me.dtpDate)
        Me.pnlUpload.Controls.Add(Me.btnChooseUpload)
        Me.pnlUpload.Controls.Add(Me.txtFtArtist)
        Me.pnlUpload.Controls.Add(Me.txtDescr)
        Me.pnlUpload.Controls.Add(Me.picTrkPic)
        Me.pnlUpload.Controls.Add(Me.txtArtist)
        Me.pnlUpload.Controls.Add(Me.lblUploadHead)
        Me.pnlUpload.Controls.Add(Me.txtTrkName)
        Me.pnlUpload.Location = New System.Drawing.Point(200, 28)
        Me.pnlUpload.Name = "pnlUpload"
        Me.pnlUpload.ShadowDecoration.Parent = Me.pnlUpload
        Me.pnlUpload.Size = New System.Drawing.Size(1020, 471)
        Me.pnlUpload.TabIndex = 3
        '
        'btnTrkInsert
        '
        Me.btnTrkInsert.AutoRoundedCorners = True
        Me.btnTrkInsert.BorderRadius = 21
        Me.btnTrkInsert.CheckedState.Parent = Me.btnTrkInsert
        Me.btnTrkInsert.CustomImages.Parent = Me.btnTrkInsert
        Me.btnTrkInsert.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnTrkInsert.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTrkInsert.ForeColor = System.Drawing.Color.White
        Me.btnTrkInsert.HoverState.Parent = Me.btnTrkInsert
        Me.btnTrkInsert.Location = New System.Drawing.Point(246, 342)
        Me.btnTrkInsert.Name = "btnTrkInsert"
        Me.btnTrkInsert.ShadowDecoration.Parent = Me.btnTrkInsert
        Me.btnTrkInsert.Size = New System.Drawing.Size(180, 45)
        Me.btnTrkInsert.TabIndex = 9
        Me.btnTrkInsert.Text = "Upload"
        '
        'txtGenre
        '
        Me.txtGenre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGenre.DefaultText = ""
        Me.txtGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGenre.DisabledState.Parent = Me.txtGenre
        Me.txtGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGenre.FocusedState.Parent = Me.txtGenre
        Me.txtGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGenre.HoverState.Parent = Me.txtGenre
        Me.txtGenre.Location = New System.Drawing.Point(548, 114)
        Me.txtGenre.Margin = New System.Windows.Forms.Padding(13)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGenre.PlaceholderText = "Genre"
        Me.txtGenre.SelectedText = ""
        Me.txtGenre.ShadowDecoration.Parent = Me.txtGenre
        Me.txtGenre.Size = New System.Drawing.Size(200, 36)
        Me.txtGenre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtGenre.TabIndex = 8
        '
        'dtpDate
        '
        Me.dtpDate.CheckedState.Parent = Me.dtpDate
        Me.dtpDate.FillColor = System.Drawing.Color.White
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.HoverState.Parent = Me.dtpDate
        Me.dtpDate.Location = New System.Drawing.Point(548, 183)
        Me.dtpDate.MaxDate = New Date(2050, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShadowDecoration.Parent = Me.dtpDate
        Me.dtpDate.Size = New System.Drawing.Size(230, 36)
        Me.dtpDate.TabIndex = 7
        Me.dtpDate.Value = New Date(2023, 4, 20, 13, 7, 49, 604)
        '
        'btnChooseUpload
        '
        Me.btnChooseUpload.AutoRoundedCorners = True
        Me.btnChooseUpload.BorderRadius = 21
        Me.btnChooseUpload.CheckedState.Parent = Me.btnChooseUpload
        Me.btnChooseUpload.CustomImages.Parent = Me.btnChooseUpload
        Me.btnChooseUpload.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnChooseUpload.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnChooseUpload.ForeColor = System.Drawing.Color.White
        Me.btnChooseUpload.HoverState.Parent = Me.btnChooseUpload
        Me.btnChooseUpload.Location = New System.Drawing.Point(246, 263)
        Me.btnChooseUpload.Name = "btnChooseUpload"
        Me.btnChooseUpload.ShadowDecoration.Parent = Me.btnChooseUpload
        Me.btnChooseUpload.Size = New System.Drawing.Size(180, 45)
        Me.btnChooseUpload.TabIndex = 6
        Me.btnChooseUpload.Text = "Choose File to Upload"
        '
        'txtFtArtist
        '
        Me.txtFtArtist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFtArtist.DefaultText = ""
        Me.txtFtArtist.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFtArtist.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFtArtist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFtArtist.DisabledState.Parent = Me.txtFtArtist
        Me.txtFtArtist.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFtArtist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFtArtist.FocusedState.Parent = Me.txtFtArtist
        Me.txtFtArtist.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFtArtist.HoverState.Parent = Me.txtFtArtist
        Me.txtFtArtist.Location = New System.Drawing.Point(548, 45)
        Me.txtFtArtist.Margin = New System.Windows.Forms.Padding(13)
        Me.txtFtArtist.Name = "txtFtArtist"
        Me.txtFtArtist.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFtArtist.PlaceholderText = "Featuring Artist"
        Me.txtFtArtist.SelectedText = ""
        Me.txtFtArtist.ShadowDecoration.Parent = Me.txtFtArtist
        Me.txtFtArtist.Size = New System.Drawing.Size(200, 36)
        Me.txtFtArtist.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtFtArtist.TabIndex = 5
        '
        'txtDescr
        '
        Me.txtDescr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescr.DefaultText = ""
        Me.txtDescr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDescr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDescr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescr.DisabledState.Parent = Me.txtDescr
        Me.txtDescr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDescr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescr.FocusedState.Parent = Me.txtDescr
        Me.txtDescr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescr.HoverState.Parent = Me.txtDescr
        Me.txtDescr.Location = New System.Drawing.Point(246, 183)
        Me.txtDescr.Margin = New System.Windows.Forms.Padding(13)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescr.PlaceholderText = "Description"
        Me.txtDescr.SelectedText = ""
        Me.txtDescr.ShadowDecoration.Parent = Me.txtDescr
        Me.txtDescr.Size = New System.Drawing.Size(200, 36)
        Me.txtDescr.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtDescr.TabIndex = 4
        '
        'picTrkPic
        '
        Me.picTrkPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTrkPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTrkPic.Image = CType(resources.GetObject("picTrkPic.Image"), System.Drawing.Image)
        Me.picTrkPic.Location = New System.Drawing.Point(12, 45)
        Me.picTrkPic.Name = "picTrkPic"
        Me.picTrkPic.ShadowDecoration.Parent = Me.picTrkPic
        Me.picTrkPic.Size = New System.Drawing.Size(203, 183)
        Me.picTrkPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picTrkPic.TabIndex = 3
        Me.picTrkPic.TabStop = False
        '
        'txtArtist
        '
        Me.txtArtist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtArtist.DefaultText = ""
        Me.txtArtist.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtArtist.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtArtist.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtArtist.DisabledState.Parent = Me.txtArtist
        Me.txtArtist.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtArtist.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArtist.FocusedState.Parent = Me.txtArtist
        Me.txtArtist.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArtist.HoverState.Parent = Me.txtArtist
        Me.txtArtist.Location = New System.Drawing.Point(246, 114)
        Me.txtArtist.Margin = New System.Windows.Forms.Padding(8)
        Me.txtArtist.Name = "txtArtist"
        Me.txtArtist.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtArtist.PlaceholderText = "Artist"
        Me.txtArtist.SelectedText = ""
        Me.txtArtist.ShadowDecoration.Parent = Me.txtArtist
        Me.txtArtist.Size = New System.Drawing.Size(200, 36)
        Me.txtArtist.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtArtist.TabIndex = 2
        '
        'lblUploadHead
        '
        Me.lblUploadHead.AutoSize = True
        Me.lblUploadHead.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUploadHead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUploadHead.Location = New System.Drawing.Point(8, 13)
        Me.lblUploadHead.Name = "lblUploadHead"
        Me.lblUploadHead.Size = New System.Drawing.Size(148, 21)
        Me.lblUploadHead.TabIndex = 1
        Me.lblUploadHead.Text = "Upload Your Song"
        '
        'txtTrkName
        '
        Me.txtTrkName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrkName.DefaultText = ""
        Me.txtTrkName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTrkName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTrkName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTrkName.DisabledState.Parent = Me.txtTrkName
        Me.txtTrkName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTrkName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTrkName.FocusedState.Parent = Me.txtTrkName
        Me.txtTrkName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTrkName.HoverState.Parent = Me.txtTrkName
        Me.txtTrkName.Location = New System.Drawing.Point(246, 45)
        Me.txtTrkName.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTrkName.Name = "txtTrkName"
        Me.txtTrkName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTrkName.PlaceholderText = "Song Name"
        Me.txtTrkName.SelectedText = ""
        Me.txtTrkName.ShadowDecoration.Parent = Me.txtTrkName
        Me.txtTrkName.Size = New System.Drawing.Size(200, 36)
        Me.txtTrkName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtTrkName.TabIndex = 0
        '
        'pnlSongs
        '
        Me.pnlSongs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSongs.BackColor = System.Drawing.Color.White
        Me.pnlSongs.Controls.Add(Me.dgvSongs)
        Me.pnlSongs.Location = New System.Drawing.Point(200, 28)
        Me.pnlSongs.Name = "pnlSongs"
        Me.pnlSongs.ShadowDecoration.Parent = Me.pnlSongs
        Me.pnlSongs.Size = New System.Drawing.Size(1020, 471)
        Me.pnlSongs.TabIndex = 10
        '
        'dgvSongs
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvSongs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSongs.BackgroundColor = System.Drawing.Color.White
        Me.dgvSongs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSongs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSongs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSongs.ColumnHeadersHeight = 44
        Me.dgvSongs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trk_id, Me.trk_name, Me.trk_artist, Me.trk_description, Me.trk_picture, Me.trk_genre, Me.trk_featartist, Me.trk_date, Me.trk_created, Me.trk_edit, Me.trk_delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSongs.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSongs.EnableHeadersVisualStyles = False
        Me.dgvSongs.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSongs.Location = New System.Drawing.Point(6, 37)
        Me.dgvSongs.Name = "dgvSongs"
        Me.dgvSongs.RowHeadersVisible = False
        Me.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSongs.Size = New System.Drawing.Size(1002, 280)
        Me.dgvSongs.TabIndex = 0
        Me.dgvSongs.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgvSongs.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSongs.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvSongs.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvSongs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvSongs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvSongs.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgvSongs.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSongs.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSongs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSongs.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSongs.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvSongs.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvSongs.ThemeStyle.HeaderStyle.Height = 44
        Me.dgvSongs.ThemeStyle.ReadOnly = False
        Me.dgvSongs.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvSongs.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSongs.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvSongs.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvSongs.ThemeStyle.RowsStyle.Height = 22
        Me.dgvSongs.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSongs.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'trk_id
        '
        Me.trk_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_id.HeaderText = "ID"
        Me.trk_id.Name = "trk_id"
        Me.trk_id.Width = 50
        '
        'trk_name
        '
        Me.trk_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_name.HeaderText = "Song"
        Me.trk_name.Name = "trk_name"
        Me.trk_name.Width = 72
        '
        'trk_artist
        '
        Me.trk_artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_artist.HeaderText = "Artist"
        Me.trk_artist.Name = "trk_artist"
        Me.trk_artist.Width = 74
        '
        'trk_description
        '
        Me.trk_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_description.HeaderText = "Description"
        Me.trk_description.Name = "trk_description"
        Me.trk_description.Width = 120
        '
        'trk_picture
        '
        Me.trk_picture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_picture.HeaderText = "Image"
        Me.trk_picture.Name = "trk_picture"
        Me.trk_picture.Width = 85
        '
        'trk_genre
        '
        Me.trk_genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_genre.HeaderText = "Genre"
        Me.trk_genre.Name = "trk_genre"
        Me.trk_genre.Width = 82
        '
        'trk_featartist
        '
        Me.trk_featartist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_featartist.HeaderText = "Featuring Artist"
        Me.trk_featartist.Name = "trk_featartist"
        Me.trk_featartist.Width = 139
        '
        'trk_date
        '
        Me.trk_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_date.HeaderText = "Date Released"
        Me.trk_date.Name = "trk_date"
        Me.trk_date.Width = 135
        '
        'trk_created
        '
        Me.trk_created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_created.HeaderText = "Date Uploaded"
        Me.trk_created.Name = "trk_created"
        Me.trk_created.Width = 141
        '
        'trk_edit
        '
        Me.trk_edit.HeaderText = "Edit"
        Me.trk_edit.Name = "trk_edit"
        '
        'trk_delete
        '
        Me.trk_delete.HeaderText = "Delete"
        Me.trk_delete.Name = "trk_delete"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblAddImage
        '
        Me.lblAddImage.AutoSize = True
        Me.lblAddImage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddImage.Location = New System.Drawing.Point(73, 245)
        Me.lblAddImage.Name = "lblAddImage"
        Me.lblAddImage.Size = New System.Drawing.Size(81, 15)
        Me.lblAddImage.TabIndex = 10
        Me.lblAddImage.Text = "Upload Image"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1220, 604)
        Me.Controls.Add(Me.pnlBar)
        Me.Controls.Add(Me.pnlUpload)
        Me.Controls.Add(Me.pnlSongs)
        Me.Controls.Add(Me.pnlMenu)
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
        Me.pnlUpload.ResumeLayout(False)
        Me.pnlUpload.PerformLayout()
        CType(Me.picTrkPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSongs.ResumeLayout(False)
        CType(Me.dgvSongs, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents pnlUpload As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtTrkName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnChooseUpload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFtArtist As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picTrkPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtArtist As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUploadHead As Label
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtGenre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnTrkInsert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlSongs As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvSongs As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents trk_id As DataGridViewTextBoxColumn
    Friend WithEvents trk_name As DataGridViewTextBoxColumn
    Friend WithEvents trk_artist As DataGridViewTextBoxColumn
    Friend WithEvents trk_description As DataGridViewTextBoxColumn
    Friend WithEvents trk_picture As DataGridViewTextBoxColumn
    Friend WithEvents trk_genre As DataGridViewTextBoxColumn
    Friend WithEvents trk_featartist As DataGridViewTextBoxColumn
    Friend WithEvents trk_date As DataGridViewTextBoxColumn
    Friend WithEvents trk_created As DataGridViewTextBoxColumn
    Friend WithEvents trk_edit As DataGridViewButtonColumn
    Friend WithEvents trk_delete As DataGridViewButtonColumn
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblAddImage As Label
End Class
