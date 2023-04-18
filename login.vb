'----------------------------------------------------------------------------------
'Program Title: 		Conisch
'Program Author: 		Aiden Castillo, Kayden Cervantes, Dennis Villanueva
'Date Created:  		15 April, 2023
'School:			    Corozal Junior College
'Course Number/Name:	CS206 - Programming II
'Program Description:	This program demonstrates a fully functional CRUD Desktop App and allows for different
'                       user access-levels (admin, manager, user). The program center arounds a music streaming
'                       service (like Spotify/SoundCloud) that allow users to play and share music. MySQL is used
'                       for the inserting, updating, deleting and querying. The GUNA UI framework is being used
'                       for UI purposes.
'----------------------------------------------------------------------------------
Imports MySql.Data.MySqlClient

Public Class frmLogin
    Dim Mysqlcon As MySqlConnection
    Dim command As MySqlCommand
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Mysqlcon = New MySqlConnection
        Mysqlcon.ConnectionString = ("server=localhost; port=3307; database=cs206finalproject; user=root; password='';")
        Dim reader As MySqlDataReader

        Try
            Mysqlcon.Open()
            Dim query As String
            query = "SELECT * FROM  users WHERE user_username ='" & txtUsername.Text & "' AND BINARY user_password='" & txtUserPwd.Text & "' "
            command = New MySqlCommand(query, Mysqlcon)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show(Me, "Successfully login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                frmMain.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show(Me, "Username and Password Duplicate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If txtUsername.Text = "" Then
                    MessageBox.Show(Me, "Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf txtUserPwd.Text = "" Then
                    MessageBox.Show(Me, "Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(Me, "Invalid login, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

            Mysqlcon.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            Mysqlcon.Dispose()
        End Try
    End Sub

    Private Sub lblRegLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegLink.LinkClicked
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class
