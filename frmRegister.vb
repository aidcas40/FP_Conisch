Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms

Public Class frmRegister
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        ' Defining various variables to trim and hold user input from the Sign Up form
        Dim regUsername As String = txtRegUsername.Text.Trim()
        Dim regEmail As String = txtRegEmail.Text.Trim()
        Dim regPassword As String = txtRegPwd.Text.Trim()

        ' Declaring variable of type boolean to be used in confirming if the user has filled out all textboxes
        Dim hasErrors As Boolean = False

        ' For loop that checks if any of the textboxes on the Sign Up form are empty and provides a relevant message box warning
        For Each item As Control In Me.Controls()
            If (TypeOf item Is Guna2TextBox) Then
                Dim textbox As Guna2TextBox = DirectCast(item, Guna2TextBox)
                If (textbox.Text = "") Then
                    MessageBox.Show(Me, "All fields are required!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    hasErrors = True
                    Exit For
                End If
            End If
        Next

        If Not hasErrors Then
            ' If statement that checks if the Confirm Password and Password Textbox are not the same and provides a relevant message box warning
            If txtConfirmPwd.Text <> txtRegPwd.Text Then
                MessageBox.Show(Me, "Confirm Password and Password must match.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Dim conn = New MySqlConnection(My.Settings.connString)
                Try
                    ' Opening a conncetion to the database so that the various user inputs are inserted into te users table of the database
                    conn.Open()

                    Using conn
                        Dim cmd = New MySqlCommand("INSERT INTO users(user_username, user_email, user_password) VALUES(@uname,@uemail,@upass)", conn)

                        With cmd.Parameters
                            .AddWithValue("@uname", regUsername)
                            .AddWithValue("@uemail", regEmail)
                            .AddWithValue("@upass", regPassword)
                        End With

                        Dim status As Integer
                        status = cmd.ExecuteNonQuery()

                        If (status > 0) Then
                            MessageBox.Show(Me, "Record Inserted!", "Information", MessageBoxButtons.OK)
                        Else
                            MessageBox.Show(Me, "Record not inserted!", "Information", MessageBoxButtons.OK)
                        End If
                    End Using

                Catch ex As Exception
                    MessageBox.Show(Me, ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Dispose()
                    conn.Close()

                End Try
            End If
        End If
    End Sub

    Private Sub lblLogLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLogLink.LinkClicked
        ' Opens Login form and hides current form when Sign In Link is clicked
        frmLogin.Show()
        Me.Hide()
    End Sub
End Class