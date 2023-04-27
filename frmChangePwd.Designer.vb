<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePwd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangePwd))
        Me.txtCrtPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblChangePwd = New System.Windows.Forms.Label()
        Me.txtCrtConfirmPwd = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnUpdatePwd = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'txtCrtPwd
        '
        Me.txtCrtPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrtPwd.DefaultText = ""
        Me.txtCrtPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCrtPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCrtPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCrtPwd.DisabledState.Parent = Me.txtCrtPwd
        Me.txtCrtPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCrtPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrtPwd.FocusedState.Parent = Me.txtCrtPwd
        Me.txtCrtPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrtPwd.HoverState.Parent = Me.txtCrtPwd
        Me.txtCrtPwd.Location = New System.Drawing.Point(55, 75)
        Me.txtCrtPwd.Margin = New System.Windows.Forms.Padding(37, 34, 37, 34)
        Me.txtCrtPwd.Name = "txtCrtPwd"
        Me.txtCrtPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCrtPwd.PlaceholderText = "New Password"
        Me.txtCrtPwd.SelectedText = ""
        Me.txtCrtPwd.ShadowDecoration.Parent = Me.txtCrtPwd
        Me.txtCrtPwd.Size = New System.Drawing.Size(333, 58)
        Me.txtCrtPwd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCrtPwd.TabIndex = 0
        Me.txtCrtPwd.UseSystemPasswordChar = True
        '
        'lblChangePwd
        '
        Me.lblChangePwd.AutoSize = True
        Me.lblChangePwd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangePwd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblChangePwd.Location = New System.Drawing.Point(22, 20)
        Me.lblChangePwd.Name = "lblChangePwd"
        Me.lblChangePwd.Size = New System.Drawing.Size(144, 21)
        Me.lblChangePwd.TabIndex = 12
        Me.lblChangePwd.Text = "Change Password"
        '
        'txtCrtConfirmPwd
        '
        Me.txtCrtConfirmPwd.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCrtConfirmPwd.DefaultText = ""
        Me.txtCrtConfirmPwd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCrtConfirmPwd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCrtConfirmPwd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCrtConfirmPwd.DisabledState.Parent = Me.txtCrtConfirmPwd
        Me.txtCrtConfirmPwd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCrtConfirmPwd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrtConfirmPwd.FocusedState.Parent = Me.txtCrtConfirmPwd
        Me.txtCrtConfirmPwd.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCrtConfirmPwd.HoverState.Parent = Me.txtCrtConfirmPwd
        Me.txtCrtConfirmPwd.Location = New System.Drawing.Point(55, 161)
        Me.txtCrtConfirmPwd.Margin = New System.Windows.Forms.Padding(62, 55, 62, 55)
        Me.txtCrtConfirmPwd.Name = "txtCrtConfirmPwd"
        Me.txtCrtConfirmPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCrtConfirmPwd.PlaceholderText = "Confirm Password"
        Me.txtCrtConfirmPwd.SelectedText = ""
        Me.txtCrtConfirmPwd.ShadowDecoration.Parent = Me.txtCrtConfirmPwd
        Me.txtCrtConfirmPwd.Size = New System.Drawing.Size(333, 58)
        Me.txtCrtConfirmPwd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtCrtConfirmPwd.TabIndex = 1
        Me.txtCrtConfirmPwd.UseSystemPasswordChar = True
        '
        'btnUpdatePwd
        '
        Me.btnUpdatePwd.AutoRoundedCorners = True
        Me.btnUpdatePwd.BorderRadius = 21
        Me.btnUpdatePwd.CheckedState.Parent = Me.btnUpdatePwd
        Me.btnUpdatePwd.CustomImages.Parent = Me.btnUpdatePwd
        Me.btnUpdatePwd.FillColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.btnUpdatePwd.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdatePwd.ForeColor = System.Drawing.Color.White
        Me.btnUpdatePwd.HoverState.Parent = Me.btnUpdatePwd
        Me.btnUpdatePwd.Location = New System.Drawing.Point(131, 247)
        Me.btnUpdatePwd.Name = "btnUpdatePwd"
        Me.btnUpdatePwd.ShadowDecoration.Parent = Me.btnUpdatePwd
        Me.btnUpdatePwd.Size = New System.Drawing.Size(180, 45)
        Me.btnUpdatePwd.TabIndex = 2
        Me.btnUpdatePwd.Text = "Change"
        '
        'frmChangePwd
        '
        Me.AcceptButton = Me.btnUpdatePwd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(452, 396)
        Me.Controls.Add(Me.btnUpdatePwd)
        Me.Controls.Add(Me.txtCrtConfirmPwd)
        Me.Controls.Add(Me.lblChangePwd)
        Me.Controls.Add(Me.txtCrtPwd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChangePwd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCrtPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblChangePwd As Label
    Friend WithEvents txtCrtConfirmPwd As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnUpdatePwd As Guna.UI2.WinForms.Guna2Button
End Class
