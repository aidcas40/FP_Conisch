Imports MySql.Data.MySqlClient
Public Class frmChangePwd
    Dim conn = New MySqlConnection(My.Settings.connString)
    Dim command As MySqlCommand
    Private Sub btnUpdatePwd_Click(sender As Object, e As EventArgs) Handles btnUpdatePwd.Click
        If String.IsNullOrEmpty(txtCrtPwd.Text) OrElse String.IsNullOrEmpty(txtCrtConfirmPwd.Text) Then
            MessageBox.Show("Please enter a value in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim changePwd As DialogResult = MessageBox.Show($"Are you sure you want to update '{frmMain.strSelUserName}' password?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Update the database with the new values
            If txtCrtConfirmPwd.Text <> txtCrtPwd.Text Then
                MessageBox.Show($"Confirm Password and Password must match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                Try
                    If changePwd = DialogResult.Yes Then
                        Using conn
                            conn.Open()
                            Dim query As String = "UPDATE users SET user_password=@upassword WHERE user_id=@uid"
                            Using cmd As New MySqlCommand(query, conn)
                                cmd.Parameters.AddWithValue("@upassword", txtCrtPwd.Text)
                                cmd.Parameters.AddWithValue("@uid", frmMain.intSelUserID)
                                cmd.ExecuteNonQuery()
                            End Using
                        End Using

                        MessageBox.Show($"'{frmMain.strSelUserName}' password was successfully updated.", "Change Password", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtCrtPwd.Text = ""
                        txtCrtConfirmPwd.Text = ""
                        Me.Close()
                    Else
                        MessageBox.Show($"Password Change was unsuccesful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub
End Class