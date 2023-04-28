'----------------------------------------------------------------------------------
'Program Title: 		Conisch
'Program Author: 		Aiden Castillo, Kayden Cervantes, Dennis Villanueva, Francis Sharp
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
    'Declaring public variables to save data from current login user to be used across various forms
    Public Shared intCurID As Int32
    Public Shared intCurActive As Int32
    Public Shared strCurUsername As String
    Public Shared strCurType As String

    'Defining connection string and declaring mysql commands to query data from the database 
    Dim conn = New MySqlConnection(My.Settings.connString)
    Dim command As MySqlCommand

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim reader As MySqlDataReader

        Try
            'Connecting to the database to check if the username and password entered in the login form matches
            conn.Open()
            Dim query As String
            query = "SELECT * FROM  users WHERE user_username ='" & txtUsername.Text & "' AND BINARY user_password='" & txtUserPwd.Text & "' "
            command = New MySqlCommand(query, conn)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                ' use reader function to save specific user data from the database, such as Username, Active and UserType
                intCurID = reader.GetInt32(0)
                strCurUsername = reader.GetString(1)
                If Not reader.IsDBNull(4) Then
                    intCurActive = reader.GetInt32(4)
                End If
                If Not reader.IsDBNull(5) Then
                    strCurType = reader.GetString(5)
                End If

                ' if statements to deal with various login scenarios
                ' if statement for unactivated users
                If intCurActive <> 1 Then
                    MessageBox.Show(Me, "Account hasn't been activated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    ' else if statement for users that haven't been assigned a role/type
                ElseIf strCurType = Nothing Then
                    MessageBox.Show(Me, "Account hasn't been assigned a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(Me, "Successfully login as " & strCurType & ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmMain.Show()
                    Me.Hide()
                End If

                ' else if statement that checks for duplicate users in the database
            ElseIf count > 1 Then
                MessageBox.Show(Me, "Username and Password Duplicate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                ' if statements that check for invalid or empty user input for the username and password textboxes
                If txtUsername.Text = "" Then
                    MessageBox.Show(Me, "Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf txtUserPwd.Text = "" Then
                    MessageBox.Show(Me, "Please enter a password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(Me, "Invalid login, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub lblRegLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegLink.LinkClicked
        ' opens Register form and hides current form when Sign Up Link is clicked
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class
