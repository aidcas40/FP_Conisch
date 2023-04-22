Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.IO
Imports System.Data
Imports System.DateTime
Imports System.Drawing.Imaging

Public Class frmMain
    Dim conn = New MySqlConnection(My.Settings.connString)

    Dim result As Integer
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim audiopath As String
    Dim sql As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGenres()
    End Sub
    Private Sub LoadGenres()
        conn.Open()
        Dim gcmd As New MySqlCommand("SELECT gnr_name FROM genre", conn)
        Dim gda As New MySqlDataAdapter(gcmd)
        Dim gdt As New DataTable()
        gda.Fill(gdt)
        cbxGenre.DataSource = gdt
        cbxGenre.DisplayMember = "gnr_name"
        cbxGenre.SelectedIndex = -1
        cbxGenre.Text = ""
        conn.Close()
    End Sub


    'Sub PlayBackgroundSoundFile()
    '    My.Computer.Audio.Play("C:\Waterfall.wav",
    '    AudioPlayMode.WaitToComplete)
    'End Sub

    Private Sub picTrkPic_Click(sender As Object, e As EventArgs) Handles picTrkPic.Click
        Try
            Dim ofd As FileDialog = New OpenFileDialog()

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.bmp;*.gif;*.jpeg;"

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

    Private Sub btnChooseUpload_Click(sender As Object, e As EventArgs) Handles btnChooseUpload.Click
        Try
            Dim ofd As FileDialog = New OpenFileDialog()

            ofd.Filter = "Audio File (*.wav;*.mp3)|*.wav;*.mp3;"

            If ofd.ShowDialog() = DialogResult.OK Then
                audiopath = ofd.FileName
            End If

            ofd = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnTrkInsert_Click(sender As Object, e As EventArgs) Handles btnTrkInsert.Click
        If String.IsNullOrEmpty(txtTrkName.Text) OrElse String.IsNullOrEmpty(txtArtist.Text) OrElse String.IsNullOrEmpty(cbxGenre.Text) OrElse
            dtpDate.Value = Nothing Then
            MessageBox.Show("Please enter a value in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ' Saves the image by connecting to the database (Image is saved as byte)
            If Not IsNothing(picTrkPic.Image) And Not String.IsNullOrEmpty(audiopath) Then
                Try
                    Dim dateValue As DateTime = dtpDate.Value
                    Dim dateString As String = dateValue.ToString("yyyy-MM-dd")

                    Dim ms As New MemoryStream()
                    picTrkPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    arrimage = ms.GetBuffer()
                    Dim filesize As UInt32
                    filesize = ms.Length
                    ms.Close()

                    Using conn
                        conn.Open()

                        Dim cmd As New MySqlCommand("INSERT INTO track(trk_name, trk_artist, trk_audio, trk_picture, trk_genre, trk_featartist, trk_date) VALUES(@tname,@tartist,@taudiopath,@tpic,@tgenre,@tftartist,@tdate)", conn)
                        cmd.Parameters.AddWithValue("@tname", txtTrkName.Text)
                        cmd.Parameters.AddWithValue("@tartist", txtArtist.Text)
                        cmd.Parameters.AddWithValue("@taudiopath", audiopath)
                        cmd.Parameters.AddWithValue("@tpic", arrimage)
                        cmd.Parameters.AddWithValue("@tgenre", cbxGenre.Text)
                        cmd.Parameters.AddWithValue("@tftartist", txtFtArtist.Text)
                        cmd.Parameters.AddWithValue("@tdate", dateString)

                        Dim x As Integer

                        x = cmd.ExecuteNonQuery()

                        If x > 0 Then
                            MessageBox.Show("Successfully added Song.")
                        Else
                            MessageBox.Show("Record not saved.")
                        End If
                        cmd.Parameters.Clear()
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub

    Private Sub ctrlbxClose_Click(sender As Object, e As EventArgs) Handles ctrlbxClose.Click
        Application.Exit()
    End Sub
End Class