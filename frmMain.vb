﻿Imports MySql.Data.MySqlClient
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

    Private originalDataTable As DataTable

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGenres()
    End Sub
    Private Sub pnlDiscover_Paint(sender As Object, e As PaintEventArgs) Handles pnlDiscover.Paint
        LoadTrackData()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        pnlUpload.Visible = True
        pnlDiscover.Visible = False
    End Sub

    Private Sub btnDiscover_Click(sender As Object, e As EventArgs) Handles btnDiscover.Click
        pnlUpload.Visible = False
        pnlDiscover.Visible = True
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

    Private Sub LoadTrackData()
        'Dim conn = New MySqlConnection(My.Settings.connString)
        Dim query As String = "SELECT trk_picture, trk_name, trk_artist, trk_genre, trk_featartist, DATE_FORMAT(trk_date, '%M %e, %Y') AS trk_date, DATE_FORMAT(trk_created, '%M %e, %Y %h:%i%p') AS trk_created FROM track"

        Dim cmd As New MySqlCommand(query, conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        conn.Open()
        da.Fill(dt)
        conn.Close()

        ' Associate columns with DataPropertyName
        dgvSongs.Columns("trk_picture").DataPropertyName = "trk_picture"
        dgvSongs.Columns("trk_name").DataPropertyName = "trk_name"
        dgvSongs.Columns("trk_artist").DataPropertyName = "trk_artist"
        dgvSongs.Columns("trk_genre").DataPropertyName = "trk_genre"
        dgvSongs.Columns("trk_featartist").DataPropertyName = "trk_featartist"
        dgvSongs.Columns("trk_date").DataPropertyName = "trk_date"
        dgvSongs.Columns("trk_created").DataPropertyName = "trk_created"

        dgvSongs.Columns("trk_picture").Width = 50
        dgvSongs.Columns("trk_name").Width = 50
        dgvSongs.Columns("trk_artist").Width = 50
        dgvSongs.Columns("trk_genre").Width = 50
        dgvSongs.Columns("trk_featartist").Width = 50
        dgvSongs.Columns("trk_date").Width = 50
        dgvSongs.Columns("trk_created").Width = 50
        dgvSongs.Columns("trk_edit").Width = 50
        dgvSongs.Columns("trk_delete").Width = 50

        dgvSongs.Columns("trk_picture").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_artist").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_genre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_featartist").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_date").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_created").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_edit").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvSongs.Columns("trk_delete").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        dgvSongs.AllowUserToAddRows = False

        'dgvSongs.Columns.Clear()
        dgvSongs.DataSource = dt

        ' Save the original DataTable
        originalDataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            originalDataTable.ImportRow(row)
        Next

    End Sub

    'Creating search function for Product datagridview table. Connects to the database to accomplish this
    Private Function SearchTrack() As DataTable
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        Try
            conn.Open()
            sql = "SELECT trk_picture, trk_name, trk_artist, trk_genre, trk_featartist, DATE_FORMAT(trk_date, '%M %e, %Y') AS trk_date, DATE_FORMAT(trk_created, '%M %e, %Y %h:%i%p') AS trk_created 
                    FROM track WHERE CONCAT_WS(trk_name, trk_artist, trk_genre, trk_featartist) LIKE '%" & txtDiscSearch.Text & "%'"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            dgvSongs.DataSource = dt
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            da.Dispose()
        End Try

        ' Save the filtered DataTable
        Dim filteredDataTable As New DataTable()
        filteredDataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            filteredDataTable.ImportRow(row)
        Next

        ' Restore the original DataTable
        dt = originalDataTable.Clone()
        For Each row As DataRow In originalDataTable.Rows
            dt.ImportRow(row)
        Next

        ' Return the filtered DataTable
        Return filteredDataTable
    End Function

    Sub PlayBackgroundSoundFile()
        My.Computer.Audio.Play("C:\Waterfall.wav",
        AudioPlayMode.WaitToComplete)
    End Sub

    Private Sub picTrkPic_Click(sender As Object, e As EventArgs) Handles picTrkPic.Click
        Try
            Dim ofd As FileDialog = New OpenFileDialog()

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.bmp;*.png;*.gif;*.jpeg;"

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
                txtFilePath.Text = Path.GetFileName(ofd.FileName)
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
                            MessageBox.Show("Songg uploaded successfully.")
                        Else
                            MessageBox.Show("Upload was unsuccessful.")
                        End If
                        cmd.Parameters.Clear()
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub
    Private Sub btnTrkClear_Click(sender As Object, e As EventArgs) Handles btnTrkClear.Click
        For Each control As Control In pnlUpload.Controls
            If TypeOf control Is Guna2DateTimePicker Then
                control.Text = Date.Now
            End If
            If TypeOf control Is PictureBox Then
                CType(control, PictureBox).Image = Nothing
                If control.Name = "picTrkPic" Then
                    CType(control, PictureBox).Image = Image.FromFile(Application.StartupPath & "\icons\icons8-plus-math-100.png")
                End If
            End If
            If TypeOf control Is Guna2Button Then
                Dim button As Guna2Button = CType(control, Guna2Button)
                If button.Name = "btnChooseUpload" Then
                    Dim openFileDialog As New OpenFileDialog()
                    openFileDialog.FileName = ""
                End If
            End If

            lblAddImage.Visible = True

            txtFilePath.Text = ""
            txtTrkName.Text = ""
            txtArtist.Text = ""
            cbxGenre.SelectedIndex = -1
            txtFtArtist.Text = ""
        Next
    End Sub

    Private Sub txtDiscSearch_TextChanged(sender As Object, e As EventArgs) Handles txtDiscSearch.TextChanged
        If txtDiscSearch.Focused Then
            SearchTrack()
        End If
    End Sub

    Private Sub ctrlbxClose_Click(sender As Object, e As EventArgs) Handles ctrlbxClose.Click
        Application.Exit()
    End Sub
End Class