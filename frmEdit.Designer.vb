<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEdit))
        Me.picTrkPicUpd = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtTrkNameUpd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtArtistUpd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cbxGenreUpd = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtFtArtistUpd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.dtpDateUpd = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lblGenreUpd = New System.Windows.Forms.Label()
        Me.lblDateUpd = New System.Windows.Forms.Label()
        Me.btnTrkUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.lblUpdateHead = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblChangeImage = New System.Windows.Forms.Label()
        CType(Me.picTrkPicUpd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTrkPicUpd
        '
        Me.picTrkPicUpd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTrkPicUpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTrkPicUpd.Image = CType(resources.GetObject("picTrkPicUpd.Image"), System.Drawing.Image)
        Me.picTrkPicUpd.Location = New System.Drawing.Point(28, 65)
        Me.picTrkPicUpd.Name = "picTrkPicUpd"
        Me.picTrkPicUpd.ShadowDecoration.Parent = Me.picTrkPicUpd
        Me.picTrkPicUpd.Size = New System.Drawing.Size(218, 193)
        Me.picTrkPicUpd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picTrkPicUpd.TabIndex = 4
        Me.picTrkPicUpd.TabStop = False
        '
        'txtTrkNameUpd
        '
        Me.txtTrkNameUpd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrkNameUpd.DefaultText = ""
        Me.txtTrkNameUpd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTrkNameUpd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTrkNameUpd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTrkNameUpd.DisabledState.Parent = Me.txtTrkNameUpd
        Me.txtTrkNameUpd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTrkNameUpd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTrkNameUpd.FocusedState.Parent = Me.txtTrkNameUpd
        Me.txtTrkNameUpd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTrkNameUpd.HoverState.Parent = Me.txtTrkNameUpd
        Me.txtTrkNameUpd.Location = New System.Drawing.Point(274, 65)
        Me.txtTrkNameUpd.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTrkNameUpd.Name = "txtTrkNameUpd"
        Me.txtTrkNameUpd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTrkNameUpd.PlaceholderText = "Song Name"
        Me.txtTrkNameUpd.SelectedText = ""
        Me.txtTrkNameUpd.ShadowDecoration.Parent = Me.txtTrkNameUpd
        Me.txtTrkNameUpd.Size = New System.Drawing.Size(200, 36)
        Me.txtTrkNameUpd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtTrkNameUpd.TabIndex = 0
        '
        'txtArtistUpd
        '
        Me.txtArtistUpd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtArtistUpd.DefaultText = ""
        Me.txtArtistUpd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtArtistUpd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtArtistUpd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtArtistUpd.DisabledState.Parent = Me.txtArtistUpd
        Me.txtArtistUpd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtArtistUpd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArtistUpd.FocusedState.Parent = Me.txtArtistUpd
        Me.txtArtistUpd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArtistUpd.HoverState.Parent = Me.txtArtistUpd
        Me.txtArtistUpd.Location = New System.Drawing.Point(274, 143)
        Me.txtArtistUpd.Margin = New System.Windows.Forms.Padding(8)
        Me.txtArtistUpd.Name = "txtArtistUpd"
        Me.txtArtistUpd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtArtistUpd.PlaceholderText = "Artist"
        Me.txtArtistUpd.SelectedText = ""
        Me.txtArtistUpd.ShadowDecoration.Parent = Me.txtArtistUpd
        Me.txtArtistUpd.Size = New System.Drawing.Size(200, 36)
        Me.txtArtistUpd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtArtistUpd.TabIndex = 1
        '
        'cbxGenreUpd
        '
        Me.cbxGenreUpd.BackColor = System.Drawing.Color.Transparent
        Me.cbxGenreUpd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbxGenreUpd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxGenreUpd.FocusedColor = System.Drawing.Color.Empty
        Me.cbxGenreUpd.FocusedState.Parent = Me.cbxGenreUpd
        Me.cbxGenreUpd.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cbxGenreUpd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cbxGenreUpd.FormattingEnabled = True
        Me.cbxGenreUpd.HoverState.Parent = Me.cbxGenreUpd
        Me.cbxGenreUpd.ItemHeight = 30
        Me.cbxGenreUpd.ItemsAppearance.Parent = Me.cbxGenreUpd
        Me.cbxGenreUpd.Location = New System.Drawing.Point(274, 221)
        Me.cbxGenreUpd.Name = "cbxGenreUpd"
        Me.cbxGenreUpd.ShadowDecoration.Parent = Me.cbxGenreUpd
        Me.cbxGenreUpd.Size = New System.Drawing.Size(200, 36)
        Me.cbxGenreUpd.TabIndex = 2
        '
        'txtFtArtistUpd
        '
        Me.txtFtArtistUpd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFtArtistUpd.DefaultText = ""
        Me.txtFtArtistUpd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFtArtistUpd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFtArtistUpd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFtArtistUpd.DisabledState.Parent = Me.txtFtArtistUpd
        Me.txtFtArtistUpd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFtArtistUpd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFtArtistUpd.FocusedState.Parent = Me.txtFtArtistUpd
        Me.txtFtArtistUpd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFtArtistUpd.HoverState.Parent = Me.txtFtArtistUpd
        Me.txtFtArtistUpd.Location = New System.Drawing.Point(528, 65)
        Me.txtFtArtistUpd.Margin = New System.Windows.Forms.Padding(13)
        Me.txtFtArtistUpd.Name = "txtFtArtistUpd"
        Me.txtFtArtistUpd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFtArtistUpd.PlaceholderText = "Featuring Artist"
        Me.txtFtArtistUpd.SelectedText = ""
        Me.txtFtArtistUpd.ShadowDecoration.Parent = Me.txtFtArtistUpd
        Me.txtFtArtistUpd.Size = New System.Drawing.Size(200, 36)
        Me.txtFtArtistUpd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtFtArtistUpd.TabIndex = 3
        '
        'dtpDateUpd
        '
        Me.dtpDateUpd.BorderColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.dtpDateUpd.BorderThickness = 1
        Me.dtpDateUpd.CheckedState.Parent = Me.dtpDateUpd
        Me.dtpDateUpd.FillColor = System.Drawing.Color.White
        Me.dtpDateUpd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.dtpDateUpd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateUpd.HoverState.Parent = Me.dtpDateUpd
        Me.dtpDateUpd.Location = New System.Drawing.Point(528, 143)
        Me.dtpDateUpd.MaxDate = New Date(2050, 1, 1, 0, 0, 0, 0)
        Me.dtpDateUpd.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dtpDateUpd.Name = "dtpDateUpd"
        Me.dtpDateUpd.ShadowDecoration.Parent = Me.dtpDateUpd
        Me.dtpDateUpd.Size = New System.Drawing.Size(200, 36)
        Me.dtpDateUpd.TabIndex = 4
        Me.dtpDateUpd.Value = New Date(2023, 4, 20, 13, 7, 49, 604)
        '
        'lblGenreUpd
        '
        Me.lblGenreUpd.AutoSize = True
        Me.lblGenreUpd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenreUpd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblGenreUpd.Location = New System.Drawing.Point(280, 203)
        Me.lblGenreUpd.Name = "lblGenreUpd"
        Me.lblGenreUpd.Size = New System.Drawing.Size(81, 15)
        Me.lblGenreUpd.TabIndex = 13
        Me.lblGenreUpd.Text = "Choose Genre"
        '
        'lblDateUpd
        '
        Me.lblDateUpd.AutoSize = True
        Me.lblDateUpd.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateUpd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblDateUpd.Location = New System.Drawing.Point(534, 125)
        Me.lblDateUpd.Name = "lblDateUpd"
        Me.lblDateUpd.Size = New System.Drawing.Size(116, 15)
        Me.lblDateUpd.TabIndex = 16
        Me.lblDateUpd.Text = "Choose Release Date"
        '
        'btnTrkUpdate
        '
        Me.btnTrkUpdate.AutoRoundedCorners = True
        Me.btnTrkUpdate.BorderRadius = 21
        Me.btnTrkUpdate.CheckedState.Parent = Me.btnTrkUpdate
        Me.btnTrkUpdate.CustomImages.Parent = Me.btnTrkUpdate
        Me.btnTrkUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnTrkUpdate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrkUpdate.ForeColor = System.Drawing.Color.White
        Me.btnTrkUpdate.HoverState.Parent = Me.btnTrkUpdate
        Me.btnTrkUpdate.Location = New System.Drawing.Point(274, 291)
        Me.btnTrkUpdate.Name = "btnTrkUpdate"
        Me.btnTrkUpdate.ShadowDecoration.Parent = Me.btnTrkUpdate
        Me.btnTrkUpdate.Size = New System.Drawing.Size(180, 45)
        Me.btnTrkUpdate.TabIndex = 5
        Me.btnTrkUpdate.Text = "Update"
        '
        'lblUpdateHead
        '
        Me.lblUpdateHead.AutoSize = True
        Me.lblUpdateHead.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdateHead.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblUpdateHead.Location = New System.Drawing.Point(6, 17)
        Me.lblUpdateHead.Name = "lblUpdateHead"
        Me.lblUpdateHead.Size = New System.Drawing.Size(109, 21)
        Me.lblUpdateHead.TabIndex = 18
        Me.lblUpdateHead.Text = "Update Song"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblChangeImage
        '
        Me.lblChangeImage.AutoSize = True
        Me.lblChangeImage.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangeImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblChangeImage.Location = New System.Drawing.Point(97, 279)
        Me.lblChangeImage.Name = "lblChangeImage"
        Me.lblChangeImage.Size = New System.Drawing.Size(84, 15)
        Me.lblChangeImage.TabIndex = 19
        Me.lblChangeImage.Text = "Change Image"
        '
        'frmEdit
        '
        Me.AcceptButton = Me.btnTrkUpdate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 372)
        Me.Controls.Add(Me.lblChangeImage)
        Me.Controls.Add(Me.lblUpdateHead)
        Me.Controls.Add(Me.btnTrkUpdate)
        Me.Controls.Add(Me.lblDateUpd)
        Me.Controls.Add(Me.lblGenreUpd)
        Me.Controls.Add(Me.dtpDateUpd)
        Me.Controls.Add(Me.txtFtArtistUpd)
        Me.Controls.Add(Me.cbxGenreUpd)
        Me.Controls.Add(Me.txtArtistUpd)
        Me.Controls.Add(Me.txtTrkNameUpd)
        Me.Controls.Add(Me.picTrkPicUpd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Update Song"
        CType(Me.picTrkPicUpd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTrkPicUpd As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtTrkNameUpd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtArtistUpd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cbxGenreUpd As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtFtArtistUpd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpDateUpd As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents lblGenreUpd As Label
    Friend WithEvents lblDateUpd As Label
    Friend WithEvents btnTrkUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblUpdateHead As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblChangeImage As Label
End Class
