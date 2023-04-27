Imports Guna.UI2.WinForms
Public Class frmSplashScreen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Hide()
        frmLogin.Show()
        Timer1.Stop()
    End Sub
End Class