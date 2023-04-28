Imports MySql.Data.MySqlClient
Public Class frmUserChangePwd
    Dim conn = New MySqlConnection(My.Settings.connString)
    Dim command As MySqlCommand

    Private Sub btnChangePwd_Click(sender As Object, e As EventArgs) Handles btnChangePwd.Click
        ' Checking if any of the textboxes are empty
        If String.IsNullOrEmpty(txtChgUserPwd.Text) OrElse String.IsNullOrEmpty(txtChgConfirmPwd.Text) Then
            MessageBox.Show("Please enter a value in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim changePwd As DialogResult = MessageBox.Show($"Are you sure you want to change your password?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Checking if the Confirm password and password textboxes match
            If txtChgConfirmPwd.Text <> txtChgUserPwd.Text Then
                MessageBox.Show($"Confirm Password and Password must match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Try
                    'If the user clicked 'Yes' in the confirmation message box
                    If changePwd = DialogResult.Yes Then
                        ' Open database connection
                        Using conn
                            conn.Open()
                            ' Creating an SQL query to update the user's password
                            Dim query As String = "UPDATE users SET user_password=@upassword WHERE user_id=@uid"
                            Using cmd As New MySqlCommand(query, conn)
                                cmd.Parameters.AddWithValue("@upassword", txtChgUserPwd.Text)
                                cmd.Parameters.AddWithValue("@uid", frmMain.intCurIDMain)

                                cmd.ExecuteNonQuery()
                            End Using
                        End Using

                        ' Displaying a message box informing the user that their password was updated
                        MessageBox.Show($"Your password was successfully updated.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clearing the textboxes
                        txtChgUserPwd.Text = ""
                        txtChgConfirmPwd.Text = ""
                        Me.Close()
                    Else
                        ' Displaying a message box informing the user that the password update was unsuccessful
                        MessageBox.Show($"Password Change was unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class