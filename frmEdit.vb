Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmEdit
    'Defining connection string and mysql commands
    Dim conn = New MySqlConnection(My.Settings.connString)
    Dim command As MySqlCommand
    Dim imgpath As String
    Dim arrimage() As Byte

    Private Sub LoadGenres()
        conn.Open()
        Dim gcmd As New MySqlCommand("SELECT gnr_name FROM genre", conn)
        Dim gda As New MySqlDataAdapter(gcmd)
        Dim gdt As New DataTable()
        gda.Fill(gdt)
        cbxGenreUpd.DataSource = gdt
        cbxGenreUpd.DisplayMember = "gnr_name"
        conn.Close()
    End Sub

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ms As New System.IO.MemoryStream(frmMain.bytSelTrkPic)
        picTrkPicUpd.Image = Image.FromStream(ms)
        txtTrkNameUpd.Text = frmMain.strSelTrkName
        txtArtistUpd.Text = frmMain.strSelTrkArtist
        cbxGenreUpd.Text = frmMain.strSelTrkGenre
        dtpDateUpd.Text = frmMain.strSelTrkDate

        If frmMain.strSelTrkFtArtist = "" Then
            txtFtArtistUpd.PlaceholderText = "Featuring Artist"
        Else
            txtFtArtistUpd.Text = frmMain.strSelTrkFtArtist
        End If

        LoadGenres()
    End Sub

    Private Sub btnTrkUpdate_Click(sender As Object, e As EventArgs) Handles btnTrkUpdate.Click

        Dim updateTrk As DialogResult = MessageBox.Show($"Are you sure you want to update '{frmMain.strSelTrkName}'?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try
            Dim dateValue As DateTime = dtpDateUpd.Value
            Dim dateString As String = dateValue.ToString("yyyy-MM-dd")

            Dim ms As New MemoryStream()
            picTrkPicUpd.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = ms.GetBuffer()
            Dim filesize As UInt32
            filesize = ms.Length
            ms.Close()

            If updateTrk = DialogResult.Yes Then
                Using conn
                    conn.Open()
                    Dim query As String = "UPDATE track SET trk_name=@tname, trk_artist=@tartist, trk_picture=@tpic, trk_genre=@tgenre, trk_featartist=@tftartist, trk_date=@tdate WHERE trk_id=@tid"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@tname", txtTrkNameUpd.Text)
                        cmd.Parameters.AddWithValue("@tartist", txtArtistUpd.Text)
                        cmd.Parameters.AddWithValue("@tpic", arrimage)
                        cmd.Parameters.AddWithValue("@tgenre", cbxGenreUpd.Text)
                        cmd.Parameters.AddWithValue("@tftartist", txtFtArtistUpd.Text)
                        cmd.Parameters.AddWithValue("@tdate", dateString)
                        cmd.Parameters.AddWithValue("@tid", frmMain.intSelTrkID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show($"'{frmMain.strSelTrkName}' was successfully updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
            Else
                MessageBox.Show($"Update was unsuccesful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub picTrkPicUpd_Click(sender As Object, e As EventArgs) Handles picTrkPicUpd.Click
        Try
            Dim ofd As FileDialog = New OpenFileDialog()

            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.bmp;*.png;*.gif;*.jpeg;"

            If ofd.ShowDialog() = DialogResult.OK Then
                imgpath = ofd.FileName
                picTrkPicUpd.ImageLocation = imgpath
                lblChangeImage.Visible = False 'Add Image label visiblility is set to false as an Image is chosen
            End If

            ofd = Nothing

        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class