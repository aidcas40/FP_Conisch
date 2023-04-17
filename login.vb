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
            query = "SELECT * FROM  users WHERE user_username ='" & txtUsername.Text & "' AND user_password='" & txtUserPwd.Text & "' "
            command = New MySqlCommand(query, Mysqlcon)
            reader = command.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1
            End While

            If count = 1 Then
                MessageBox.Show("Username and Password is correct.")
                frmMain.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password Duplicate.")
            Else
                MessageBox.Show("Username and password incorrect.")
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
