Imports MySql.Data.MySqlClient
Public Class frmRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Try
            If txtConfirmPwd.Text <> txtRegPwd.Text Then
                MessageBox.Show("Confirm Password and Password must match.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                cm = New MySqlCommand("INSERT INTO users VALUES (NULL,'" & txtRegUsername.Text & "','" & txtRegEmail.Text & "','" & txtRegPwd.Text & "', 0 , 0 , 1)", constring)
                MessageBox.Show("Successfully registered.")
                frmLogin.Show()
                Me.Hide()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class