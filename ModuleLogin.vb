Imports MySql.Data.MySqlClient

Module ModuleLogin
    Public constring As MySqlConnection
    Public cm As MySqlCommand

    Sub connection()
        Try
            constring = New MySqlConnection("server=localhost; port=3307; database=cs206finalproject; user=root; password='';")
            constring.Open()
            MsgBox("Connected to database successfully")
        Catch ex As Exception
            MsgBox("Connection failed: ")
        End Try
    End Sub
End Module
