Imports MySql.Data.MySqlClient
Imports System.IO
Public Class frmEdit
    'Defining connection string and mysql commands
    Dim conn = New MySqlConnection(My.Settings.connString)
    Dim command As MySqlCommand

    'Declaration of variable to hold the path of the selected image file and to hold image data as byte
    Dim imgpath As String
    Dim arrimage() As Byte

    ' Fuction that queries all the genres from the genre table in the database
    Private Sub LoadGenres()
        conn.Open()
        Dim gcmd As New MySqlCommand("SELECT gnr_name FROM genre", conn)
        Dim gda As New MySqlDataAdapter(gcmd)
        Dim gdt As New DataTable()
        gda.Fill(gdt)

        ' Binds the data to the combo box
        cbxGenreUpd.DataSource = gdt
        cbxGenreUpd.DisplayMember = "gnr_name"
        conn.Close()
    End Sub

    Private Sub frmEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Loading data of selected music track in the form and populating the various controls
        Dim ms As New MemoryStream(frmMain.bytSelTrkPic)
        picTrkPicUpd.Image = Image.FromStream(ms)
        txtTrkNameUpd.Text = frmMain.strSelTrkName
        txtArtistUpd.Text = frmMain.strSelTrkArtist
        cbxGenreUpd.Text = frmMain.strSelTrkGenre
        dtpDateUpd.Text = frmMain.strSelTrkDate

        ' If statement that handles if the featuring artist is empty or not for the selected music track and populates the textbox accordingly
        If frmMain.strSelTrkFtArtist = "" Then
            txtFtArtistUpd.PlaceholderText = "Featuring Artist"
        Else
            txtFtArtistUpd.Text = frmMain.strSelTrkFtArtist
        End If

        ' Calling LoadGenres() function to populate the combo box on the form
        LoadGenres()
    End Sub

    ' This code handles the Click event of the Update button on a form
    Private Sub btnTrkUpdate_Click(sender As Object, e As EventArgs) Handles btnTrkUpdate.Click
        ' Displays a message box asking the user to confirm whether they want to update the selected track
        Dim updateTrk As DialogResult = MessageBox.Show($"Are you sure you want to update '{frmMain.strSelTrkName}'?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        Try
            ' Converts the selected date to a string in the format "yyyy-MM-dd"
            Dim dateValue As DateTime = dtpDateUpd.Value
            Dim dateString As String = dateValue.ToString("yyyy-MM-dd")

            ' Converts the selected image to an array of bytes using MemoryStream() for storage in the database
            Dim ms As New MemoryStream()
            picTrkPicUpd.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrimage = ms.GetBuffer()
            Dim filesize As UInt32
            filesize = ms.Length
            ms.Close()

            ' If the user confirms the update, update the track in the database
            If updateTrk = DialogResult.Yes Then
                ' Opens a connection to the database
                Using conn
                    conn.Open()
                    ' Executes an SQL query to update the track with the new information
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
                ' Displays a message box indicating that the track was successfully updated and closes the form
                MessageBox.Show($"'{frmMain.strSelTrkName}' was successfully updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()

                ' If the user cancels the update, do nothing
            ElseIf updateTrk = DialogResult.No Then
                Exit Sub
            Else
                MessageBox.Show($"Update was unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' This code handles the Click event of the Change/Update Image on the form
    Private Sub picTrkPicUpd_Click(sender As Object, e As EventArgs) Handles picTrkPicUpd.Click
        Try
            ' Creates a new instance of the OpenFileDialog class
            Dim ofd As FileDialog = New OpenFileDialog()

            ' Sets the filter for the file dialog to only allow image files
            ofd.Filter = "Image File (*.jpg;*.png;*.gif;*.jpeg)|*.jpg;*.bmp;*.png;*.gif;*.jpeg;"

            ' If the user selects a valid image file, sets the ImageLocation property of the picture box to the path
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