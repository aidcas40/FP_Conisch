Imports Guna.UI2.WinForms
Public Class frmSplashScreen
    ' Handles Timer event for the Splash Screen
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Once time timer has stopped, the splash screen for is hiden and the Login form is opened
        Me.Hide()
        frmLogin.Show()
        Timer1.Stop() ' Stops timer so it doesn't run in the background
    End Sub
End Class