Imports MySql.Data.MySqlClient
Public Class frmUserChangePwd
    Dim conn = New MySqlConnection(My.Settings.connString)
    Dim command As MySqlCommand

    Private Sub frmUserChangePwd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChgUserPwd.MaxLength = 25
        txtChgConfirmPwd.MaxLength = 25
    End Sub

    Private Sub btnChangePwd_Click(sender As Object, e As EventArgs) Handles btnChangePwd.Click
        If String.IsNullOrEmpty(txtChgUserPwd.Text) OrElse String.IsNullOrEmpty(txtChgConfirmPwd.Text) Then
            MessageBox.Show("Please enter a value in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim changePwd As DialogResult = MessageBox.Show($"Are you sure you want to change your password?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Update the database with the new values
            If txtChgConfirmPwd.Text <> txtChgUserPwd.Text Then
                MessageBox.Show($"Confirm Password and Password must match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Try
                    If changePwd = DialogResult.Yes Then
                        Using conn
                            conn.Open()
                            Dim query As String = "UPDATE users SET user_password=@upassword WHERE user_id=@uid"
                            Using cmd As New MySqlCommand(query, conn)
                                cmd.Parameters.AddWithValue("@upassword", txtChgUserPwd.Text)
                                cmd.Parameters.AddWithValue("@uid", frmMain.intCurIDMain)

                                cmd.ExecuteNonQuery()
                            End Using
                        End Using
                        'MessageBox.Show($"@upassword: {txtChgUserPwd.Text}, @uid: {frmMain.intCurIDMain}")
                        MessageBox.Show($"Your password was successfully updated.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtChgUserPwd.Text = ""
                        txtChgConfirmPwd.Text = ""
                        Me.Close()
                    Else
                        MessageBox.Show($"Password Change was unsuccesful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class