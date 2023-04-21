Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.IO
Imports System.Data
Imports System.Drawing.Imaging

Public Class frmMain
    Dim conn = New MySqlConnection(My.Settings.connString)
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable

    Dim Table_Name As String = "vbnet_mysql_item_table" 'your table name
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim IDRam, NameRam, PriceRam, AmountRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"
    Dim SqlCmdSearchstr As String
    Dim Col0Ram As Integer = 0

    'Dim result As Integer
    'Dim imgpath As String
    'Dim arrimage() As Byte
    'Dim sql As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowData()
    End Sub

    Private Sub ShowData()
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show("Connection failed !!!" & vbCrLf & "Please check that the server is ready !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        Try
            If LoadImagesStr = False Then
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT Name, ID, Price, Amount FROM " & Table_Name & " ORDER BY Name"
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, conn)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    dgvSongs.DataSource = Nothing
                    dgvSongs.DataSource = DT
                    dgvSongs.Columns(2).DefaultCellStyle.Format = "c"
                    dgvSongs.DefaultCellStyle.ForeColor = Color.Black
                    dgvSongs.ClearSelection()
                Else
                    dgvSongs.DataSource = DT
                End If
            Else
                MySQLCMD.CommandType = CommandType.Text
                MySQLCMD.CommandText = "SELECT Images FROM " & Table_Name & " WHERE ID LIKE " & IDRam
                MySQLDA = New MySqlDataAdapter(MySQLCMD.CommandText, conn)
                DT = New DataTable
                Data = MySQLDA.Fill(DT)
                If Data > 0 Then
                    Dim ImgArray() As Byte = DT.Rows(0).Item("Images")
                    Dim lmgStr As New System.IO.MemoryStream(ImgArray)
                    picTrkPic.Image = Image.FromStream(lmgStr)
                    picTrkPic.SizeMode = PictureBoxSizeMode.Zoom
                    lmgStr.Close()
                End If
                LoadImagesStr = False
            End If
        Catch ex As Exception
            MsgBox("Failed to load Database !!!" & vbCr & ex.Message, MsgBoxStyle.Critical, "Error Message")
            conn.Close()
            Return
        End Try

        DT = Nothing
        conn.Close()
    End Sub

    Private Sub ClearInputUpdateData()
        TextBoxName.Text = ""
        TextBoxID.Text = ""
        TextBoxPrice.Text = ""
        TextBoxAmount.Text = ""
        PictureBoxImageInput.Image = My.Resources.Click_to_browse
    End Sub

    Private Sub picTrkPic_Click(sender As Object, e As EventArgs) Handles picTrkPic.Click
        Try
            Dim ofd As FileDialog = New OpenFileDialog()

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg;"

            'With ofd
            '    'Filtering file type
            '    .Filter = ("Image Files| *.png; *.Jpeg; *.jpg")
            '    .FilterIndex = 1
            'End With

            If ofd.ShowDialog() = DialogResult.OK Then
                imgpath = ofd.FileName
                picTrkPic.ImageLocation = imgpath
                lblAddImage.Visible = False 'Add Image label visiblility is set to false as an Image is chosen
            End If

            ofd = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnTrkInsert_Click(sender As Object, e As EventArgs) Handles btnTrkInsert.Click
        If String.IsNullOrEmpty(txtTrkName.Text) OrElse String.IsNullOrEmpty(txtArtist.Text) OrElse String.IsNullOrEmpty(txtDescr.Text) OrElse String.IsNullOrEmpty(txtGenre.Text) OrElse
            dtpDate.Value = Nothing Then
            MessageBox.Show("Please enter a value in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ' Saves the image by connecting to the database (Image is saved as byte)
            If Not IsNothing(picTrkPic.Image) Then
                Try
                    Dim ms As New MemoryStream()
                    picTrkPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim filesize As UInt32
                    filesize = ms.Length
                    ms.Close()

                    conn.open()

                    Dim cmd As New MySqlCommand("INSERT INTO track(trk_name, trk_artist, trk_description, trk_picture, trk_genre, trk_featartist, trk_date) VALUES(@tname,@tartist,@tdescr,@tpic,@tgenre,@tftartist,@tdate)", conn)
                    cmd.Parameters.AddWithValue("@tname", txtTrkName.Text)
                    cmd.Parameters.AddWithValue("@tartist", txtArtist.Text)
                    cmd.Parameters.AddWithValue("@tdescr", txtDescr.Text)
                    cmd.Parameters.AddWithValue("@tpic", arrimage)
                    cmd.Parameters.AddWithValue("@tgenre", txtGenre.Text)
                    cmd.Parameters.AddWithValue("@tftartist", txtFtArtist.Text)
                    cmd.Parameters.AddWithValue("@tdate", dtpDate.Text)

                    Dim x As Integer

                    x = cmd.ExecuteNonQuery()

                    If x > 0 Then
                        MessageBox.Show("Successfully added Song.")
                    Else
                        MessageBox.Show("Record not saved.")
                    End If
                    cmd.Parameters.Clear()
                    conn.Close()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

End Class