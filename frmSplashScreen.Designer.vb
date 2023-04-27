<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSplashScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashScreen))
        Me.picSSLogo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblLoading = New System.Windows.Forms.Label()
        CType(Me.picSSLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSSLogo
        '
        Me.picSSLogo.Image = CType(resources.GetObject("picSSLogo.Image"), System.Drawing.Image)
        Me.picSSLogo.Location = New System.Drawing.Point(211, 66)
        Me.picSSLogo.Name = "picSSLogo"
        Me.picSSLogo.ShadowDecoration.Parent = Me.picSSLogo
        Me.picSSLogo.Size = New System.Drawing.Size(176, 148)
        Me.picSSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSSLogo.TabIndex = 0
        Me.picSSLogo.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 8000
        '
        'lblLoading
        '
        Me.lblLoading.AutoSize = True
        Me.lblLoading.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoading.ForeColor = System.Drawing.Color.White
        Me.lblLoading.Location = New System.Drawing.Point(266, 191)
        Me.lblLoading.Name = "lblLoading"
        Me.lblLoading.Size = New System.Drawing.Size(75, 21)
        Me.lblLoading.TabIndex = 1
        Me.lblLoading.Text = "Loading..."
        '
        'frmSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(610, 302)
        Me.Controls.Add(Me.lblLoading)
        Me.Controls.Add(Me.picSSLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSplashScreen"
        CType(Me.picSSLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSSLogo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblLoading As Label
End Class
