<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrint))
        Me.picTrkPicPrt = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtTrkNamePrt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtArtistPrt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtFtArtistPrt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtGenrePrt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDatePrt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnTrkPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.txtCreatedPrt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.lblTrkNamePrt = New System.Windows.Forms.Label()
        Me.lblArtistPrt = New System.Windows.Forms.Label()
        Me.lblGenrePrt = New System.Windows.Forms.Label()
        Me.lblFtArtistPrt = New System.Windows.Forms.Label()
        Me.lblDatePrt = New System.Windows.Forms.Label()
        Me.lblCreatedPrt = New System.Windows.Forms.Label()
        CType(Me.picTrkPicPrt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picTrkPicPrt
        '
        Me.picTrkPicPrt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picTrkPicPrt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picTrkPicPrt.Image = CType(resources.GetObject("picTrkPicPrt.Image"), System.Drawing.Image)
        Me.picTrkPicPrt.Location = New System.Drawing.Point(12, 42)
        Me.picTrkPicPrt.Name = "picTrkPicPrt"
        Me.picTrkPicPrt.ShadowDecoration.Parent = Me.picTrkPicPrt
        Me.picTrkPicPrt.Size = New System.Drawing.Size(249, 220)
        Me.picTrkPicPrt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picTrkPicPrt.TabIndex = 5
        Me.picTrkPicPrt.TabStop = False
        '
        'txtTrkNamePrt
        '
        Me.txtTrkNamePrt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTrkNamePrt.DefaultText = ""
        Me.txtTrkNamePrt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTrkNamePrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTrkNamePrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTrkNamePrt.DisabledState.Parent = Me.txtTrkNamePrt
        Me.txtTrkNamePrt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTrkNamePrt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTrkNamePrt.FocusedState.Parent = Me.txtTrkNamePrt
        Me.txtTrkNamePrt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTrkNamePrt.HoverState.Parent = Me.txtTrkNamePrt
        Me.txtTrkNamePrt.Location = New System.Drawing.Point(288, 42)
        Me.txtTrkNamePrt.Margin = New System.Windows.Forms.Padding(5)
        Me.txtTrkNamePrt.Name = "txtTrkNamePrt"
        Me.txtTrkNamePrt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTrkNamePrt.PlaceholderText = "Song Name"
        Me.txtTrkNamePrt.ReadOnly = True
        Me.txtTrkNamePrt.SelectedText = ""
        Me.txtTrkNamePrt.ShadowDecoration.Parent = Me.txtTrkNamePrt
        Me.txtTrkNamePrt.Size = New System.Drawing.Size(200, 36)
        Me.txtTrkNamePrt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtTrkNamePrt.TabIndex = 6
        '
        'txtArtistPrt
        '
        Me.txtArtistPrt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtArtistPrt.DefaultText = ""
        Me.txtArtistPrt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtArtistPrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtArtistPrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtArtistPrt.DisabledState.Parent = Me.txtArtistPrt
        Me.txtArtistPrt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtArtistPrt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArtistPrt.FocusedState.Parent = Me.txtArtistPrt
        Me.txtArtistPrt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtArtistPrt.HoverState.Parent = Me.txtArtistPrt
        Me.txtArtistPrt.Location = New System.Drawing.Point(288, 134)
        Me.txtArtistPrt.Margin = New System.Windows.Forms.Padding(8)
        Me.txtArtistPrt.Name = "txtArtistPrt"
        Me.txtArtistPrt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtArtistPrt.PlaceholderText = "Artist"
        Me.txtArtistPrt.ReadOnly = True
        Me.txtArtistPrt.SelectedText = ""
        Me.txtArtistPrt.ShadowDecoration.Parent = Me.txtArtistPrt
        Me.txtArtistPrt.Size = New System.Drawing.Size(200, 36)
        Me.txtArtistPrt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtArtistPrt.TabIndex = 7
        '
        'txtFtArtistPrt
        '
        Me.txtFtArtistPrt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFtArtistPrt.DefaultText = ""
        Me.txtFtArtistPrt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFtArtistPrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFtArtistPrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFtArtistPrt.DisabledState.Parent = Me.txtFtArtistPrt
        Me.txtFtArtistPrt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFtArtistPrt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFtArtistPrt.FocusedState.Parent = Me.txtFtArtistPrt
        Me.txtFtArtistPrt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFtArtistPrt.HoverState.Parent = Me.txtFtArtistPrt
        Me.txtFtArtistPrt.Location = New System.Drawing.Point(535, 42)
        Me.txtFtArtistPrt.Margin = New System.Windows.Forms.Padding(13)
        Me.txtFtArtistPrt.Name = "txtFtArtistPrt"
        Me.txtFtArtistPrt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFtArtistPrt.PlaceholderText = "Featuring Artist"
        Me.txtFtArtistPrt.ReadOnly = True
        Me.txtFtArtistPrt.SelectedText = ""
        Me.txtFtArtistPrt.ShadowDecoration.Parent = Me.txtFtArtistPrt
        Me.txtFtArtistPrt.Size = New System.Drawing.Size(200, 36)
        Me.txtFtArtistPrt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtFtArtistPrt.TabIndex = 9
        '
        'txtGenrePrt
        '
        Me.txtGenrePrt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtGenrePrt.DefaultText = ""
        Me.txtGenrePrt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtGenrePrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtGenrePrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGenrePrt.DisabledState.Parent = Me.txtGenrePrt
        Me.txtGenrePrt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtGenrePrt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGenrePrt.FocusedState.Parent = Me.txtGenrePrt
        Me.txtGenrePrt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtGenrePrt.HoverState.Parent = Me.txtGenrePrt
        Me.txtGenrePrt.Location = New System.Drawing.Point(288, 226)
        Me.txtGenrePrt.Margin = New System.Windows.Forms.Padding(8)
        Me.txtGenrePrt.Name = "txtGenrePrt"
        Me.txtGenrePrt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGenrePrt.PlaceholderText = "Genre"
        Me.txtGenrePrt.ReadOnly = True
        Me.txtGenrePrt.SelectedText = ""
        Me.txtGenrePrt.ShadowDecoration.Parent = Me.txtGenrePrt
        Me.txtGenrePrt.Size = New System.Drawing.Size(200, 36)
        Me.txtGenrePrt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtGenrePrt.TabIndex = 10
        '
        'txtDatePrt
        '
        Me.txtDatePrt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDatePrt.DefaultText = ""
        Me.txtDatePrt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDatePrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDatePrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDatePrt.DisabledState.Parent = Me.txtDatePrt
        Me.txtDatePrt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDatePrt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDatePrt.FocusedState.Parent = Me.txtDatePrt
        Me.txtDatePrt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDatePrt.HoverState.Parent = Me.txtDatePrt
        Me.txtDatePrt.Location = New System.Drawing.Point(535, 134)
        Me.txtDatePrt.Margin = New System.Windows.Forms.Padding(8)
        Me.txtDatePrt.Name = "txtDatePrt"
        Me.txtDatePrt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDatePrt.PlaceholderText = "Realeased"
        Me.txtDatePrt.ReadOnly = True
        Me.txtDatePrt.SelectedText = ""
        Me.txtDatePrt.ShadowDecoration.Parent = Me.txtDatePrt
        Me.txtDatePrt.Size = New System.Drawing.Size(200, 36)
        Me.txtDatePrt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtDatePrt.TabIndex = 11
        '
        'btnTrkPrint
        '
        Me.btnTrkPrint.AutoRoundedCorners = True
        Me.btnTrkPrint.BorderRadius = 21
        Me.btnTrkPrint.CheckedState.Parent = Me.btnTrkPrint
        Me.btnTrkPrint.CustomImages.Parent = Me.btnTrkPrint
        Me.btnTrkPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnTrkPrint.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrkPrint.ForeColor = System.Drawing.Color.White
        Me.btnTrkPrint.HoverState.Parent = Me.btnTrkPrint
        Me.btnTrkPrint.Location = New System.Drawing.Point(288, 304)
        Me.btnTrkPrint.Name = "btnTrkPrint"
        Me.btnTrkPrint.ShadowDecoration.Parent = Me.btnTrkPrint
        Me.btnTrkPrint.Size = New System.Drawing.Size(180, 45)
        Me.btnTrkPrint.TabIndex = 0
        Me.btnTrkPrint.Text = "Print"
        '
        'txtCreatedPrt
        '
        Me.txtCreatedPrt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreatedPrt.DefaultText = ""
        Me.txtCreatedPrt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCreatedPrt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCreatedPrt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreatedPrt.DisabledState.Parent = Me.txtCreatedPrt
        Me.txtCreatedPrt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCreatedPrt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreatedPrt.FocusedState.Parent = Me.txtCreatedPrt
        Me.txtCreatedPrt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCreatedPrt.HoverState.Parent = Me.txtCreatedPrt
        Me.txtCreatedPrt.Location = New System.Drawing.Point(535, 226)
        Me.txtCreatedPrt.Margin = New System.Windows.Forms.Padding(8)
        Me.txtCreatedPrt.Name = "txtCreatedPrt"
        Me.txtCreatedPrt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCreatedPrt.PlaceholderText = "Created"
        Me.txtCreatedPrt.ReadOnly = True
        Me.txtCreatedPrt.SelectedText = ""
        Me.txtCreatedPrt.ShadowDecoration.Parent = Me.txtCreatedPrt
        Me.txtCreatedPrt.Size = New System.Drawing.Size(200, 36)
        Me.txtCreatedPrt.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCreatedPrt.TabIndex = 19
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'lblTrkNamePrt
        '
        Me.lblTrkNamePrt.AutoSize = True
        Me.lblTrkNamePrt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrkNamePrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblTrkNamePrt.Location = New System.Drawing.Point(295, 33)
        Me.lblTrkNamePrt.Name = "lblTrkNamePrt"
        Me.lblTrkNamePrt.Size = New System.Drawing.Size(72, 15)
        Me.lblTrkNamePrt.TabIndex = 20
        Me.lblTrkNamePrt.Text = "Song Name:"
        '
        'lblArtistPrt
        '
        Me.lblArtistPrt.AutoSize = True
        Me.lblArtistPrt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistPrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblArtistPrt.Location = New System.Drawing.Point(296, 123)
        Me.lblArtistPrt.Name = "lblArtistPrt"
        Me.lblArtistPrt.Size = New System.Drawing.Size(38, 15)
        Me.lblArtistPrt.TabIndex = 21
        Me.lblArtistPrt.Text = "Artist:"
        '
        'lblGenrePrt
        '
        Me.lblGenrePrt.AutoSize = True
        Me.lblGenrePrt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenrePrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblGenrePrt.Location = New System.Drawing.Point(295, 216)
        Me.lblGenrePrt.Name = "lblGenrePrt"
        Me.lblGenrePrt.Size = New System.Drawing.Size(41, 15)
        Me.lblGenrePrt.TabIndex = 22
        Me.lblGenrePrt.Text = "Genre:"
        '
        'lblFtArtistPrt
        '
        Me.lblFtArtistPrt.AutoSize = True
        Me.lblFtArtistPrt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFtArtistPrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblFtArtistPrt.Location = New System.Drawing.Point(542, 33)
        Me.lblFtArtistPrt.Name = "lblFtArtistPrt"
        Me.lblFtArtistPrt.Size = New System.Drawing.Size(91, 15)
        Me.lblFtArtistPrt.TabIndex = 23
        Me.lblFtArtistPrt.Text = "Featuring Artist:"
        '
        'lblDatePrt
        '
        Me.lblDatePrt.AutoSize = True
        Me.lblDatePrt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDatePrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblDatePrt.Location = New System.Drawing.Point(542, 123)
        Me.lblDatePrt.Name = "lblDatePrt"
        Me.lblDatePrt.Size = New System.Drawing.Size(73, 15)
        Me.lblDatePrt.TabIndex = 24
        Me.lblDatePrt.Text = "Released on:"
        '
        'lblCreatedPrt
        '
        Me.lblCreatedPrt.AutoSize = True
        Me.lblCreatedPrt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreatedPrt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.lblCreatedPrt.Location = New System.Drawing.Point(542, 216)
        Me.lblCreatedPrt.Name = "lblCreatedPrt"
        Me.lblCreatedPrt.Size = New System.Drawing.Size(78, 15)
        Me.lblCreatedPrt.TabIndex = 25
        Me.lblCreatedPrt.Text = "Uploaded on:"
        '
        'frmPrint
        '
        Me.AcceptButton = Me.btnTrkPrint
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 372)
        Me.Controls.Add(Me.lblTrkNamePrt)
        Me.Controls.Add(Me.lblCreatedPrt)
        Me.Controls.Add(Me.lblDatePrt)
        Me.Controls.Add(Me.lblFtArtistPrt)
        Me.Controls.Add(Me.lblGenrePrt)
        Me.Controls.Add(Me.lblArtistPrt)
        Me.Controls.Add(Me.btnTrkPrint)
        Me.Controls.Add(Me.picTrkPicPrt)
        Me.Controls.Add(Me.txtTrkNamePrt)
        Me.Controls.Add(Me.txtFtArtistPrt)
        Me.Controls.Add(Me.txtDatePrt)
        Me.Controls.Add(Me.txtArtistPrt)
        Me.Controls.Add(Me.txtGenrePrt)
        Me.Controls.Add(Me.txtCreatedPrt)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Print View"
        CType(Me.picTrkPicPrt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picTrkPicPrt As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtTrkNamePrt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtArtistPrt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtFtArtistPrt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtGenrePrt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDatePrt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnTrkPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCreatedPrt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents lblTrkNamePrt As Label
    Friend WithEvents lblArtistPrt As Label
    Friend WithEvents lblGenrePrt As Label
    Friend WithEvents lblFtArtistPrt As Label
    Friend WithEvents lblDatePrt As Label
    Friend WithEvents lblCreatedPrt As Label
End Class
