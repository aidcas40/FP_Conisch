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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.pnlBar = New Guna.UI2.WinForms.Guna2Panel()
        Me.ctrlbxMin = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlbxMax = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.ctrlbxClose = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.pnlMenu = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.sepMenu = New Guna.UI2.WinForms.Guna2Separator()
        Me.btnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.lblGeneral = New System.Windows.Forms.Label()
        Me.btnUpload = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnYourSongs = New Guna.UI2.WinForms.Guna2Button()
        Me.btnDiscover = New Guna.UI2.WinForms.Guna2Button()
        Me.btnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.lblMenu = New System.Windows.Forms.Label()
        Me.pnlPlayer = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.pnlUpload = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnTrkClear = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFilePath = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblGenre = New System.Windows.Forms.Label()
        Me.cbxGenre = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblAddImage = New System.Windows.Forms.Label()
        Me.btnTrkInsert = New Guna.UI2.WinForms.Guna2Button()
        Me.dtpDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btnChooseUpload = New Guna.UI2.WinForms.Guna2Button()
        Me.txtFtArtist = New Guna.UI2.WinForms.Guna2TextBox()
        Me.picTrkPic = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtArtist = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblUploadHead = New System.Windows.Forms.Label()
        Me.txtTrkName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pnlDiscover = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtDiscSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvSongs = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.trk_picture = New System.Windows.Forms.DataGridViewImageColumn()
        Me.trk_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_artist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_featartist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_created = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.trk_edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.trk_delete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.pnlBar.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlUpload.SuspendLayout()
        CType(Me.picTrkPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDiscover.SuspendLayout()
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
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.Guna2Button2)
        Me.pnlMenu.Controls.Add(Me.Guna2Button1)
        Me.pnlMenu.Controls.Add(Me.sepMenu)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.lblGeneral)
        Me.pnlMenu.Controls.Add(Me.btnUpload)
        Me.pnlMenu.Controls.Add(Me.btnUsers)
        Me.pnlMenu.Controls.Add(Me.btnYourSongs)
        Me.pnlMenu.Controls.Add(Me.btnDiscover)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Controls.Add(Me.lblMenu)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 28)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.ShadowDecoration.Parent = Me.pnlMenu
        Me.pnlMenu.Size = New System.Drawing.Size(200, 495)
        Me.pnlMenu.TabIndex = 1
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Guna2Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2Button2.HoverState.Image = CType(resources.GetObject("Guna2Button2.HoverState.Image"), System.Drawing.Image)
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Image = CType(resources.GetObject("Guna2Button2.Image"), System.Drawing.Image)
        Me.Guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.Location = New System.Drawing.Point(12, 423)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button2.TabIndex = 11
        Me.Guna2Button2.Text = "Sign Out"
        Me.Guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button2.TextOffset = New System.Drawing.Point(27, 0)
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.Guna2Button1.HoverState.Image = CType(resources.GetObject("Guna2Button1.HoverState.Image"), System.Drawing.Image)
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
        Me.Guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.Location = New System.Drawing.Point(12, 372)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button1.TabIndex = 10
        Me.Guna2Button1.Text = "About Developers"
        Me.Guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Guna2Button1.TextOffset = New System.Drawing.Point(27, 0)
        '
        'sepMenu
        '
        Me.sepMenu.FillColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.sepMenu.Location = New System.Drawing.Point(12, 283)
        Me.sepMenu.Name = "sepMenu"
        Me.sepMenu.Size = New System.Drawing.Size(174, 10)
        Me.sepMenu.TabIndex = 9
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
        Me.btnLogout.Location = New System.Drawing.Point(12, 321)
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
        Me.lblGeneral.Location = New System.Drawing.Point(12, 301)
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
        Me.btnUpload.Location = New System.Drawing.Point(12, 182)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.ShadowDecoration.Parent = Me.btnUpload
        Me.btnUpload.Size = New System.Drawing.Size(180, 45)
        Me.btnUpload.TabIndex = 6
        Me.btnUpload.Text = "Upload Song"
        Me.btnUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnUpload.TextOffset = New System.Drawing.Point(27, 0)
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
        Me.btnUsers.Location = New System.Drawing.Point(12, 232)
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
        Me.btnYourSongs.Location = New System.Drawing.Point(12, 132)
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
        Me.btnDiscover.Location = New System.Drawing.Point(12, 82)
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
        Me.btnHome.Location = New System.Drawing.Point(12, 32)
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
        Me.lblMenu.Location = New System.Drawing.Point(12, 12)
        Me.lblMenu.Name = "lblMenu"
        Me.lblMenu.Size = New System.Drawing.Size(43, 17)
        Me.lblMenu.TabIndex = 0
        Me.lblMenu.Text = "Menu"
        '
        'pnlPlayer
        '
        Me.pnlPlayer.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(164, Byte), Integer))
        Me.pnlPlayer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPlayer.Location = New System.Drawing.Point(0, 523)
        Me.pnlPlayer.Name = "pnlPlayer"
        Me.pnlPlayer.ShadowDecoration.Parent = Me.pnlPlayer
        Me.pnlPlayer.Size = New System.Drawing.Size(1220, 81)
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
        Me.pnlUpload.AutoRoundedCorners = True
        Me.pnlUpload.BackColor = System.Drawing.Color.White
        Me.pnlUpload.BorderRadius = 246
        Me.pnlUpload.Controls.Add(Me.btnTrkClear)
        Me.pnlUpload.Controls.Add(Me.txtFilePath)
        Me.pnlUpload.Controls.Add(Me.lblGenre)
        Me.pnlUpload.Controls.Add(Me.cbxGenre)
        Me.pnlUpload.Controls.Add(Me.lblAddImage)
        Me.pnlUpload.Controls.Add(Me.btnTrkInsert)
        Me.pnlUpload.Controls.Add(Me.dtpDate)
        Me.pnlUpload.Controls.Add(Me.btnChooseUpload)
        Me.pnlUpload.Controls.Add(Me.txtFtArtist)
        Me.pnlUpload.Controls.Add(Me.picTrkPic)
        Me.pnlUpload.Controls.Add(Me.txtArtist)
        Me.pnlUpload.Controls.Add(Me.lblUploadHead)
        Me.pnlUpload.Controls.Add(Me.txtTrkName)
        Me.pnlUpload.Location = New System.Drawing.Point(200, 28)
        Me.pnlUpload.Name = "pnlUpload"
        Me.pnlUpload.ShadowDecoration.Parent = Me.pnlUpload
        Me.pnlUpload.Size = New System.Drawing.Size(1020, 495)
        Me.pnlUpload.TabIndex = 3
        '
        'btnTrkClear
        '
        Me.btnTrkClear.AutoRoundedCorners = True
        Me.btnTrkClear.BorderRadius = 21
        Me.btnTrkClear.CheckedState.Parent = Me.btnTrkClear
        Me.btnTrkClear.CustomImages.Parent = Me.btnTrkClear
        Me.btnTrkClear.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnTrkClear.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnTrkClear.ForeColor = System.Drawing.Color.White
        Me.btnTrkClear.HoverState.Parent = Me.btnTrkClear
        Me.btnTrkClear.Location = New System.Drawing.Point(525, 423)
        Me.btnTrkClear.Name = "btnTrkClear"
        Me.btnTrkClear.ShadowDecoration.Parent = Me.btnTrkClear
        Me.btnTrkClear.Size = New System.Drawing.Size(180, 45)
        Me.btnTrkClear.TabIndex = 14
        Me.btnTrkClear.Text = "Clear"
        '
        'txtFilePath
        '
        Me.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFilePath.DefaultText = ""
        Me.txtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilePath.DisabledState.Parent = Me.txtFilePath
        Me.txtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilePath.FocusedState.Parent = Me.txtFilePath
        Me.txtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFilePath.HoverState.Parent = Me.txtFilePath
        Me.txtFilePath.Location = New System.Drawing.Point(298, 95)
        Me.txtFilePath.Margin = New System.Windows.Forms.Padding(13)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFilePath.PlaceholderText = ""
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.SelectedText = ""
        Me.txtFilePath.ShadowDecoration.Parent = Me.txtFilePath
        Me.txtFilePath.Size = New System.Drawing.Size(250, 36)
        Me.txtFilePath.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtFilePath.TabIndex = 13
        '
        'lblGenre
        '
        Me.lblGenre.AutoSize = True
        Me.lblGenre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblGenre.Location = New System.Drawing.Point(311, 305)
        Me.lblGenre.Name = "lblGenre"
        Me.lblGenre.Size = New System.Drawing.Size(81, 15)
        Me.lblGenre.TabIndex = 12
        Me.lblGenre.Text = "Choose Genre"
        '
        'cbxGenre
        '
        Me.cbxGenre.BackColor = System.Drawing.Color.Transparent
        Me.cbxGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGenre.FocusedColor = System.Drawing.Color.Empty
        Me.cbxGenre.FocusedState.Parent = Me.cbxGenre
        Me.cbxGenre.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxGenre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxGenre.FormattingEnabled = True
        Me.cbxGenre.HoverState.Parent = Me.cbxGenre
        Me.cbxGenre.ItemHeight = 30
        Me.cbxGenre.ItemsAppearance.Parent = Me.cbxGenre
        Me.cbxGenre.Location = New System.Drawing.Point(298, 323)
        Me.cbxGenre.Name = "cbxGenre"
        Me.cbxGenre.ShadowDecoration.Parent = Me.cbxGenre
        Me.cbxGenre.Size = New System.Drawing.Size(200, 36)
        Me.cbxGenre.TabIndex = 11
        '
        'lblAddImage
        '
        Me.lblAddImage.AutoSize = True
        Me.lblAddImage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAddImage.Location = New System.Drawing.Point(105, 293)
        Me.lblAddImage.Name = "lblAddImage"
        Me.lblAddImage.Size = New System.Drawing.Size(81, 15)
        Me.lblAddImage.TabIndex = 10
        Me.lblAddImage.Text = "Upload Image"
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
        Me.btnTrkInsert.Location = New System.Drawing.Point(298, 423)
        Me.btnTrkInsert.Name = "btnTrkInsert"
        Me.btnTrkInsert.ShadowDecoration.Parent = Me.btnTrkInsert
        Me.btnTrkInsert.Size = New System.Drawing.Size(180, 45)
        Me.btnTrkInsert.TabIndex = 9
        Me.btnTrkInsert.Text = "Upload"
        '
        'dtpDate
        '
        Me.dtpDate.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dtpDate.BorderThickness = 1
        Me.dtpDate.CheckedState.Parent = Me.dtpDate
        Me.dtpDate.FillColor = System.Drawing.Color.White
        Me.dtpDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.HoverState.Parent = Me.dtpDate
        Me.dtpDate.Location = New System.Drawing.Point(599, 244)
        Me.dtpDate.MaxDate = New Date(2050, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.ShadowDecoration.Parent = Me.dtpDate
        Me.dtpDate.Size = New System.Drawing.Size(200, 36)
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
        Me.btnChooseUpload.Location = New System.Drawing.Point(599, 91)
        Me.btnChooseUpload.Name = "btnChooseUpload"
        Me.btnChooseUpload.ShadowDecoration.Parent = Me.btnChooseUpload
        Me.btnChooseUpload.Size = New System.Drawing.Size(180, 45)
        Me.btnChooseUpload.TabIndex = 6
        Me.btnChooseUpload.Text = "Choose File"
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
        Me.txtFtArtist.Location = New System.Drawing.Point(599, 165)
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
        'picTrkPic
        '
        Me.picTrkPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTrkPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTrkPic.Image = CType(resources.GetObject("picTrkPic.Image"), System.Drawing.Image)
        Me.picTrkPic.Location = New System.Drawing.Point(40, 95)
        Me.picTrkPic.Name = "picTrkPic"
        Me.picTrkPic.ShadowDecoration.Parent = Me.picTrkPic
        Me.picTrkPic.Size = New System.Drawing.Size(211, 195)
        Me.picTrkPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
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
        Me.txtArtist.Location = New System.Drawing.Point(298, 244)
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
        Me.lblUploadHead.Location = New System.Drawing.Point(17, 57)
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
        Me.txtTrkName.Location = New System.Drawing.Point(298, 165)
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
        'pnlDiscover
        '
        Me.pnlDiscover.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlDiscover.BackColor = System.Drawing.Color.White
        Me.pnlDiscover.Controls.Add(Me.txtDiscSearch)
        Me.pnlDiscover.Controls.Add(Me.Label1)
        Me.pnlDiscover.Controls.Add(Me.dgvSongs)
        Me.pnlDiscover.Location = New System.Drawing.Point(200, 28)
        Me.pnlDiscover.Name = "pnlDiscover"
        Me.pnlDiscover.ShadowDecoration.Parent = Me.pnlDiscover
        Me.pnlDiscover.Size = New System.Drawing.Size(1020, 495)
        Me.pnlDiscover.TabIndex = 10
        '
        'txtDiscSearch
        '
        Me.txtDiscSearch.AutoRoundedCorners = True
        Me.txtDiscSearch.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.txtDiscSearch.BorderRadius = 17
        Me.txtDiscSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDiscSearch.DefaultText = ""
        Me.txtDiscSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDiscSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDiscSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDiscSearch.DisabledState.Parent = Me.txtDiscSearch
        Me.txtDiscSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDiscSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiscSearch.FocusedState.Parent = Me.txtDiscSearch
        Me.txtDiscSearch.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDiscSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(144, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.txtDiscSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDiscSearch.HoverState.Parent = Me.txtDiscSearch
        Me.txtDiscSearch.IconLeft = CType(resources.GetObject("txtDiscSearch.IconLeft"), System.Drawing.Image)
        Me.txtDiscSearch.Location = New System.Drawing.Point(726, 49)
        Me.txtDiscSearch.Margin = New System.Windows.Forms.Padding(5)
        Me.txtDiscSearch.Name = "txtDiscSearch"
        Me.txtDiscSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiscSearch.PlaceholderText = "Search"
        Me.txtDiscSearch.SelectedText = ""
        Me.txtDiscSearch.ShadowDecoration.Parent = Me.txtDiscSearch
        Me.txtDiscSearch.Size = New System.Drawing.Size(252, 36)
        Me.txtDiscSearch.TabIndex = 3
        Me.txtDiscSearch.TextOffset = New System.Drawing.Point(5, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Browse All"
        '
        'dgvSongs
        '
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        Me.dgvSongs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSongs.BackgroundColor = System.Drawing.Color.White
        Me.dgvSongs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSongs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvSongs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSongs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvSongs.ColumnHeadersHeight = 44
        Me.dgvSongs.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.trk_picture, Me.trk_name, Me.trk_artist, Me.trk_genre, Me.trk_featartist, Me.trk_date, Me.trk_created, Me.trk_edit, Me.trk_delete})
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSongs.DefaultCellStyle = DataGridViewCellStyle19
        Me.dgvSongs.EnableHeadersVisualStyles = False
        Me.dgvSongs.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvSongs.Location = New System.Drawing.Point(38, 95)
        Me.dgvSongs.Name = "dgvSongs"
        Me.dgvSongs.RowHeadersVisible = False
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvSongs.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSongs.Size = New System.Drawing.Size(940, 280)
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
        Me.dgvSongs.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'trk_picture
        '
        Me.trk_picture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.trk_picture.HeaderText = "Image"
        Me.trk_picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.trk_picture.Name = "trk_picture"
        Me.trk_picture.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.trk_picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.trk_picture.Width = 87
        '
        'trk_name
        '
        Me.trk_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.trk_name.DefaultCellStyle = DataGridViewCellStyle13
        Me.trk_name.FillWeight = 50.0!
        Me.trk_name.HeaderText = "Song"
        Me.trk_name.Name = "trk_name"
        Me.trk_name.Width = 74
        '
        'trk_artist
        '
        Me.trk_artist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.trk_artist.DefaultCellStyle = DataGridViewCellStyle14
        Me.trk_artist.FillWeight = 50.0!
        Me.trk_artist.HeaderText = "Artist"
        Me.trk_artist.Name = "trk_artist"
        Me.trk_artist.Width = 76
        '
        'trk_genre
        '
        Me.trk_genre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.trk_genre.DefaultCellStyle = DataGridViewCellStyle15
        Me.trk_genre.FillWeight = 50.0!
        Me.trk_genre.HeaderText = "Genre"
        Me.trk_genre.Name = "trk_genre"
        Me.trk_genre.Width = 84
        '
        'trk_featartist
        '
        Me.trk_featartist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.trk_featartist.DefaultCellStyle = DataGridViewCellStyle16
        Me.trk_featartist.FillWeight = 50.0!
        Me.trk_featartist.HeaderText = "Featuring Artist"
        Me.trk_featartist.Name = "trk_featartist"
        Me.trk_featartist.Width = 155
        '
        'trk_date
        '
        Me.trk_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.Format = "d"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.trk_date.DefaultCellStyle = DataGridViewCellStyle17
        Me.trk_date.FillWeight = 50.0!
        Me.trk_date.HeaderText = "Released"
        Me.trk_date.Name = "trk_date"
        Me.trk_date.Width = 106
        '
        'trk_created
        '
        Me.trk_created.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.Format = "g"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.trk_created.DefaultCellStyle = DataGridViewCellStyle18
        Me.trk_created.FillWeight = 30.0!
        Me.trk_created.HeaderText = "Uploaded"
        Me.trk_created.Name = "trk_created"
        Me.trk_created.Width = 113
        '
        'trk_edit
        '
        Me.trk_edit.FillWeight = 50.0!
        Me.trk_edit.HeaderText = "Edit"
        Me.trk_edit.Name = "trk_edit"
        Me.trk_edit.Text = "Edit"
        Me.trk_edit.UseColumnTextForButtonValue = True
        '
        'trk_delete
        '
        Me.trk_delete.FillWeight = 50.0!
        Me.trk_delete.HeaderText = "Delete"
        Me.trk_delete.Name = "trk_delete"
        Me.trk_delete.Text = "Delete"
        Me.trk_delete.UseColumnTextForButtonValue = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1220, 604)
        Me.Controls.Add(Me.pnlDiscover)
        Me.Controls.Add(Me.pnlUpload)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlPlayer)
        Me.Controls.Add(Me.pnlBar)
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
        Me.pnlDiscover.ResumeLayout(False)
        Me.pnlDiscover.PerformLayout()
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
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblGeneral As Label
    Friend WithEvents pnlUpload As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txtTrkName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnChooseUpload As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtFtArtist As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picTrkPic As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtArtist As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblUploadHead As Label
    Friend WithEvents dtpDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents btnTrkInsert As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlDiscover As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents dgvSongs As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblAddImage As Label
    Friend WithEvents cbxGenre As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblGenre As Label
    Friend WithEvents txtFilePath As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnTrkClear As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents sepMenu As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDiscSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents trk_picture As DataGridViewImageColumn
    Friend WithEvents trk_name As DataGridViewTextBoxColumn
    Friend WithEvents trk_artist As DataGridViewTextBoxColumn
    Friend WithEvents trk_genre As DataGridViewTextBoxColumn
    Friend WithEvents trk_featartist As DataGridViewTextBoxColumn
    Friend WithEvents trk_date As DataGridViewTextBoxColumn
    Friend WithEvents trk_created As DataGridViewTextBoxColumn
    Friend WithEvents trk_edit As DataGridViewButtonColumn
    Friend WithEvents trk_delete As DataGridViewButtonColumn
End Class
