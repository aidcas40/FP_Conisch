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
    Public Shared intCurID As Int32
    Public Shared intCurActive As Int32
    Public Shared strCurUsername As String
    Public Shared strCurType As String

    Dim conn = New MySqlConnection(My.Settings.connString)
    Dim command As MySqlCommand
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim reader As MySqlDataReader

        Try
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
                'intCurID = reader.GetValue(0)
                'strCurUsername = reader.GetValue(1)
                'intCurActive = reader.GetValue(4)
                'strCurType = reader.GetValue(5)

                intCurID = reader.GetInt32(0)
                strCurUsername = reader.GetString(1)
                If Not reader.IsDBNull(4) Then
                    intCurActive = reader.GetInt32(4)
                End If
                If Not reader.IsDBNull(5) Then
                    strCurType = reader.GetString(5)
                End If

                If intCurActive <> 1 Then
                    MessageBox.Show(Me, "Account hasn't been activated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf strCurType = Nothing Then
                    MessageBox.Show(Me, "Account hasn't been assigned a role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show(Me, "Successfully login as " & strCurType & ".", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frmMain.Show()
                    Me.Hide()
                End If

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
            conn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Private Sub lblRegLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegLink.LinkClicked
        frmRegister.Show()
        Me.Hide()
    End Sub
End Class
