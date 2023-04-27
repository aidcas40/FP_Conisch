<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserChangePwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserChangePwd))
        Me.lblChangePwd = New System.Windows.Forms.Label()
        Me.txtChgUserPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtChgConfirmPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnChangePwd = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblChangePwd
        '
        Me.lblChangePwd.AutoSize = True
        Me.lblChangePwd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblChangePwd.Location = New System.Drawing.Point(6, 17)
        Me.lblChangePwd.Name = "lblChangePwd"
        Me.lblChangePwd.Size = New System.Drawing.Size(144, 21)
        Me.lblChangePwd.TabIndex = 13
        Me.lblChangePwd.Text = "Change Password"
        '
        'txtChgUserPwd
        '
        Me.txtChgUserPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChgUserPwd.DefaultText = ""
        Me.txtChgUserPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChgUserPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChgUserPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChgUserPwd.DisabledState.Parent = Me.txtChgUserPwd
        Me.txtChgUserPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChgUserPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChgUserPwd.FocusedState.Parent = Me.txtChgUserPwd
        Me.txtChgUserPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChgUserPwd.HoverState.Parent = Me.txtChgUserPwd
        Me.txtChgUserPwd.Location = New System.Drawing.Point(55, 75)
        Me.txtChgUserPwd.Margin = New System.Windows.Forms.Padding(37, 34, 37, 34)
        Me.txtChgUserPwd.Name = "txtChgUserPwd"
        Me.txtChgUserPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChgUserPwd.PlaceholderText = "New Password"
        Me.txtChgUserPwd.SelectedText = ""
        Me.txtChgUserPwd.ShadowDecoration.Parent = Me.txtChgUserPwd
        Me.txtChgUserPwd.Size = New System.Drawing.Size(333, 58)
        Me.txtChgUserPwd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtChgUserPwd.TabIndex = 0
        Me.txtChgUserPwd.UseSystemPasswordChar = True
        '
        'txtChgConfirmPwd
        '
        Me.txtChgConfirmPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtChgConfirmPwd.DefaultText = ""
        Me.txtChgConfirmPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtChgConfirmPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtChgConfirmPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChgConfirmPwd.DisabledState.Parent = Me.txtChgConfirmPwd
        Me.txtChgConfirmPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtChgConfirmPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChgConfirmPwd.FocusedState.Parent = Me.txtChgConfirmPwd
        Me.txtChgConfirmPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtChgConfirmPwd.HoverState.Parent = Me.txtChgConfirmPwd
        Me.txtChgConfirmPwd.Location = New System.Drawing.Point(55, 161)
        Me.txtChgConfirmPwd.Margin = New System.Windows.Forms.Padding(62, 55, 62, 55)
        Me.txtChgConfirmPwd.Name = "txtChgConfirmPwd"
        Me.txtChgConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtChgConfirmPwd.PlaceholderText = "Confirm Password"
        Me.txtChgConfirmPwd.SelectedText = ""
        Me.txtChgConfirmPwd.ShadowDecoration.Parent = Me.txtChgConfirmPwd
        Me.txtChgConfirmPwd.Size = New System.Drawing.Size(333, 58)
        Me.txtChgConfirmPwd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtChgConfirmPwd.TabIndex = 1
        Me.txtChgConfirmPwd.UseSystemPasswordChar = True
        '
        'btnChangePwd
        '
        Me.btnChangePwd.AutoRoundedCorners = True
        Me.btnChangePwd.BorderRadius = 21
        Me.btnChangePwd.CheckedState.Parent = Me.btnChangePwd
        Me.btnChangePwd.CustomImages.Parent = Me.btnChangePwd
        Me.btnChangePwd.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnChangePwd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePwd.ForeColor = System.Drawing.Color.White
        Me.btnChangePwd.HoverState.Parent = Me.btnChangePwd
        Me.btnChangePwd.Location = New System.Drawing.Point(131, 247)
        Me.btnChangePwd.Name = "btnChangePwd"
        Me.btnChangePwd.ShadowDecoration.Parent = Me.btnChangePwd
        Me.btnChangePwd.Size = New System.Drawing.Size(180, 45)
        Me.btnChangePwd.TabIndex = 2
        Me.btnChangePwd.Text = "Change"
        '
        'frmUserChangePwd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 396)
        Me.Controls.Add(Me.btnChangePwd)
        Me.Controls.Add(Me.txtChgConfirmPwd)
        Me.Controls.Add(Me.txtChgUserPwd)
        Me.Controls.Add(Me.lblChangePwd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUserChangePwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Your Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChangePwd As Label
    Friend WithEvents txtChgUserPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtChgConfirmPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnChangePwd As Guna.UI2.WinForms.Guna2Button
End Class
