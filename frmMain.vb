Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.IO
Imports System.Data
Imports System.DateTime
Imports System.Drawing.Imaging
Imports WMPLib

Public Class frmMain
    Dim conn = New MySqlConnection(My.Settings.connString)

    Dim result As Integer
    Dim imgpath As String
    Dim arrimage() As Byte
    Dim audiopath As String
    Dim sql As String

    Private originalDataTable As DataTable
    Private originalYourDataTable As DataTable
    Private originalUserDataTable As DataTable

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

    Private Sub ClearUploadTrack()
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

    Private Sub ClearCreateUser()
        txtCrtUsername.Text = ""
        txtCrtEmail.Text = ""
        txtCrtPwd.Text = ""
        txtCrtConfirmPwd.Text = ""
        cbxCrtType.SelectedIndex = -1
        chkCrtActive.Checked = False
    End Sub

    Private Sub LoadTrackData()
        Dim query As String = "SELECT trk_id, trk_picture, trk_name, trk_artist, trk_genre, trk_featartist, DATE_FORMAT(trk_date, '%M %e, %Y') AS trk_date, DATE_FORMAT(trk_created, '%M %e, %Y %h:%i%p') AS trk_created FROM track"
        Dim cmd As New MySqlCommand(query, conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        conn.Open()
        da.Fill(dt)
        conn.Close()

        ' Associate columns with DataPropertyName
        dgvSongs.Columns("trk_id").DataPropertyName = "trk_id"
        dgvSongs.Columns("trk_picture").DataPropertyName = "trk_picture"
        dgvSongs.Columns("trk_name").DataPropertyName = "trk_name"
        dgvSongs.Columns("trk_artist").DataPropertyName = "trk_artist"
        dgvSongs.Columns("trk_genre").DataPropertyName = "trk_genre"
        dgvSongs.Columns("trk_featartist").DataPropertyName = "trk_featartist"
        dgvSongs.Columns("trk_date").DataPropertyName = "trk_date"
        dgvSongs.Columns("trk_created").DataPropertyName = "trk_created"

        'dgvSongs.Columns("trk_id").Width = 30
        'dgvSongs.Columns("trk_picture").Width = 50
        'dgvSongs.Columns("trk_name").Width = 50
        'dgvSongs.Columns("trk_artist").Width = 50
        'dgvSongs.Columns("trk_genre").Width = 50
        'dgvSongs.Columns("trk_featartist").Width = 50
        'dgvSongs.Columns("trk_date").Width = 50
        'dgvSongs.Columns("trk_created").Width = 50
        'dgvSongs.Columns("trk_edit").Width = 50
        'dgvSongs.Columns("trk_delete").Width = 50
        'dgvSongs.Columns("trk_play").Width = 50
        'dgvSongs.Columns("trk_print").Width = 50

        dgvSongs.Columns("trk_id").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvSongs.Columns("trk_picture").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvSongs.Columns("trk_name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_artist").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_genre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_featartist").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_date").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_created").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvSongs.Columns("trk_edit").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvSongs.Columns("trk_delete").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvSongs.Columns("trk_play").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvSongs.Columns("trk_print").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        dgvSongs.RowTemplate.Height = 30

        dgvSongs.DataSource = dt

        ' Save the original DataTable
        originalDataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            originalDataTable.ImportRow(row)
        Next
    End Sub

    Private Sub LoadYourTrackData()
        Dim query As String = "SELECT trk_id, trk_picture, trk_name, trk_artist, trk_genre, trk_featartist, DATE_FORMAT(trk_date, '%M %e, %Y') AS trk_date, DATE_FORMAT(trk_created, '%M %e, %Y %h:%i%p') AS trk_created FROM track WHERE trk_user = " & frmLogin.intCurID
        Dim cmd As New MySqlCommand(query, conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        conn.Open()
        da.Fill(dt)
        conn.Close()

        ' Associate columns with DataPropertyName
        dgvYourTrack.Columns("trk_yourid").DataPropertyName = "trk_id"
        dgvYourTrack.Columns("trk_yourpicture").DataPropertyName = "trk_picture"
        dgvYourTrack.Columns("trk_yourname").DataPropertyName = "trk_name"
        dgvYourTrack.Columns("trk_yourartist").DataPropertyName = "trk_artist"
        dgvYourTrack.Columns("trk_yourgenre").DataPropertyName = "trk_genre"
        dgvYourTrack.Columns("trk_yourfeatartist").DataPropertyName = "trk_featartist"
        dgvYourTrack.Columns("trk_yourdate").DataPropertyName = "trk_date"
        dgvYourTrack.Columns("trk_yourcreated").DataPropertyName = "trk_created"

        dgvYourTrack.Columns("trk_yourid").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvYourTrack.Columns("trk_yourpicture").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvYourTrack.Columns("trk_yourname").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvYourTrack.Columns("trk_yourartist").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvYourTrack.Columns("trk_yourgenre").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvYourTrack.Columns("trk_yourfeatartist").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvYourTrack.Columns("trk_yourdate").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvYourTrack.Columns("trk_yourcreated").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvYourTrack.Columns("trk_yourdelete").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvYourTrack.Columns("trk_yourplay").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        dgvYourTrack.RowTemplate.Height = 30

        dgvYourTrack.DataSource = dt

        ' Save the original DataTable
        originalYourDataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            originalYourDataTable.ImportRow(row)
        Next
    End Sub
    Private Sub LoadUserData()
        Dim query As String = "SELECT user_id, user_username, user_email, user_password, user_active, user_istype FROM users"
        Dim cmd As New MySqlCommand(query, conn)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()

        conn.Open()
        da.Fill(dt)
        conn.Close()

        ' Associate columns with DataPropertyName
        dgvUsers.Columns("user_id").DataPropertyName = "user_id"
        dgvUsers.Columns("user_username").DataPropertyName = "user_username"
        dgvUsers.Columns("user_email").DataPropertyName = "user_email"
        dgvUsers.Columns("user_password").DataPropertyName = "user_password"
        dgvUsers.Columns("user_active").DataPropertyName = "user_active"
        dgvUsers.Columns("user_istype").DataPropertyName = "user_istype"

        dgvUsers.Columns("user_id").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvUsers.Columns("user_username").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvUsers.Columns("user_email").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvUsers.Columns("user_password").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvUsers.Columns("user_active").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvUsers.Columns("user_istype").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvUsers.Columns("user_update").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvUsers.Columns("user_print").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvUsers.Columns("user_changepwd").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        dgvUsers.Columns("user_delete").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        dgvUsers.RowTemplate.Height = 30

        'dgvSongs.Columns("trk_id").Visible = False

        dgvUsers.DataSource = dt

        ' Save the original DataTable
        originalUserDataTable = dt.Clone()
        For Each row As DataRow In dt.Rows
            originalUserDataTable.ImportRow(row)
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
            sql = "SELECT trk_id, trk_picture, trk_name, trk_artist, trk_genre, trk_featartist, DATE_FORMAT(trk_date, '%M %e, %Y') AS trk_date, DATE_FORMAT(trk_created, '%M %e, %Y %h:%i%p') AS trk_created 
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

    Private Function SearchYourTrack() As DataTable
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        Try
            conn.Open()
            sql = "SELECT trk_id, trk_picture, trk_name, trk_artist, trk_genre, trk_featartist, DATE_FORMAT(trk_date, '%M %e, %Y') AS trk_date, DATE_FORMAT(trk_created, '%M %e, %Y %h:%i%p') AS trk_created 
                    FROM track WHERE CONCAT_WS(trk_name, trk_artist, trk_genre, trk_featartist) LIKE '%" & txtYourSearch.Text & "%' AND trk_user = " & frmLogin.intCurID
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            dgvYourTrack.DataSource = dt
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
        dt = originalYourDataTable.Clone()
        For Each row As DataRow In originalYourDataTable.Rows
            dt.ImportRow(row)
        Next

        ' Return the filtered DataTable
        Return filteredDataTable
    End Function

    Private Function SearchUser() As DataTable
        Dim cmd As MySqlCommand
        Dim da As MySqlDataAdapter
        Dim dt As DataTable
        Dim sql As String

        Try
            conn.Open()
            sql = "SELECT user_id, user_username, user_email, user_password, user_active, user_istype
                    FROM users WHERE CONCAT_WS(user_username, user_email, user_istype) LIKE '%" & txtUserSearch.Text & "%'"
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            dt = New DataTable
            da.SelectCommand = cmd
            da.Fill(dt)
            dgvUsers.DataSource = dt
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
        dt = originalUserDataTable.Clone()
        For Each row As DataRow In originalUserDataTable.Rows
            dt.ImportRow(row)
        Next

        ' Return the filtered DataTable
        Return filteredDataTable
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGenres()
        If frmLogin.strCurType = "Admin" Then

        ElseIf frmLogin.strCurType = "Manager" Then
            btnCreateUser.Visible = False

            dgvUsers.Columns("user_delete").Visible = False

        ElseIf frmLogin.strCurType = "User" Then
            btnCreateUser.Visible = False
            btnUsers.Visible = False

            dgvSongs.Columns("trk_edit").Visible = False
            dgvSongs.Columns("trk_delete").Visible = False

        End If
    End Sub

    Private Sub pnlHomeAdmin_Paint(sender As Object, e As PaintEventArgs) Handles pnlHomeAdmin.Paint
        lblAdminWelcome.Text = lblAdminWelcome.Text & " " & frmLogin.strCurUsername

        Try
            conn.Open()
            Dim cmdActU As New MySqlCommand("SELECT COUNT(*) FROM users WHERE user_active = 1", conn)
            Dim countActUsers As Object = cmdActU.ExecuteScalar()

            Dim cmdUnActU As New MySqlCommand("SELECT COUNT(*) FROM users WHERE user_active = 0", conn)
            Dim countUnActUsers As Object = cmdUnActU.ExecuteScalar()

            Dim cmdTotTrk As New MySqlCommand("SELECT COUNT(*) FROM track", conn)
            Dim countTotTrk As Object = cmdTotTrk.ExecuteScalar()

            tbtnCountActUsers.Text = countActUsers.ToString() & " Active Users"
            tbtnCountUnActUsers.Text = countUnActUsers.ToString() & " Unactive Users"
            tbtnCountTotTrk.Text = countTotTrk.ToString() & " Uploaded Songs"
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub pnlDiscover_Paint(sender As Object, e As PaintEventArgs) Handles pnlDiscover.Paint
        LoadTrackData()
    End Sub

    Private Sub pnlYourSongs_Paint(sender As Object, e As PaintEventArgs) Handles pnlYourSongs.Paint
        LoadYourTrackData()
    End Sub

    Private Sub pnlUsers_Paint(sender As Object, e As PaintEventArgs) Handles pnlUsers.Paint
        LoadUserData()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        If frmLogin.strCurType = "Admin" Or frmLogin.strCurType = "Manager" Then
            pnlHomeAdmin.Visible = True
            pnlDiscover.Visible = False
            pnlYourSongs.Visible = False
            pnlUpload.Visible = False
            pnlUsers.Visible = False
            pnlCreateUser.Visible = False
        End If
    End Sub

    Private Sub btnDiscover_Click(sender As Object, e As EventArgs) Handles btnDiscover.Click
        pnlHomeAdmin.Visible = False
        pnlDiscover.Visible = True
        pnlYourSongs.Visible = False
        pnlUpload.Visible = False
        pnlUsers.Visible = False
        pnlCreateUser.Visible = False
    End Sub

    Private Sub btnYourSongs_Click(sender As Object, e As EventArgs) Handles btnYourSongs.Click
        pnlHomeAdmin.Visible = False
        pnlDiscover.Visible = False
        pnlYourSongs.Visible = True
        pnlUpload.Visible = False
        pnlUsers.Visible = False
        pnlCreateUser.Visible = False
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        pnlHomeAdmin.Visible = False
        pnlDiscover.Visible = False
        pnlYourSongs.Visible = False
        pnlUpload.Visible = True
        pnlUsers.Visible = False
        pnlCreateUser.Visible = False
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        pnlHomeAdmin.Visible = False
        pnlDiscover.Visible = False
        pnlYourSongs.Visible = False
        pnlUpload.Visible = False
        pnlUsers.Visible = True
        pnlCreateUser.Visible = False
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        pnlHomeAdmin.Visible = False
        pnlDiscover.Visible = False
        pnlYourSongs.Visible = False
        pnlUpload.Visible = False
        pnlUsers.Visible = False
        pnlCreateUser.Visible = True
    End Sub

    '========================================All Actions for pnlSongs====================================================================
    Private Sub dgvSongs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSongs.CellContentClick
        Dim trkName As String
        Dim trkID As Integer
        Try
            If dgvSongs.Columns(e.ColumnIndex).Name = "trk_play" Then
                trkID = CInt(dgvSongs.Rows(e.RowIndex).Cells("trk_id").Value)
                Dim query As String = "SELECT trk_audio FROM track WHERE trk_id = " & trkID
                Dim filePath As String = ""

                Using conn
                    conn.Open()

                    Using cmd As New MySqlCommand(query, conn)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            filePath = reader("trk_audio").ToString()
                        End If

                        reader.Close()
                    End Using

                    conn.Close()
                End Using

                If filePath <> "" Then
                    ' Set the URL property of the media player control to the file path
                    AxWindowsMediaPlayer1.URL = filePath
                    ' Start playing the audio and show the play/pause button as "pause"
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                End If

            ElseIf dgvSongs.Columns(e.ColumnIndex).Name = "trk_edit" Then
                ' Get the trk_name of the selected row
                trkName = dgvSongs.Rows(e.RowIndex).Cells("trk_name").Value.ToString()

                '' Open the Edit form and pass the trk_name as a parameter
                'Dim editForm As New EditForm(trkName)
                'editForm.ShowDialog()

                ' Reload the data when the Edit form is closed
                LoadTrackData()
                'frmTrkEdit.Show()

            ElseIf dgvSongs.Columns(e.ColumnIndex).Name = "trk_delete" Then
                ' Get the trk_name of the selected row
                trkName = dgvSongs.Rows(e.RowIndex).Cells("trk_name").Value.ToString()
                trkID = Convert.ToInt32(dgvSongs.Rows(e.RowIndex).Cells("trk_id").Value)

                ' Prompt the user to confirm the deletion
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete '{trkName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Delete the row from the database
                    Dim query As String = $"DELETE FROM track WHERE trk_id = '{trkID}'"
                    Dim cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    ' Remove the row from the DataGridView
                    dgvSongs.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '========================================All Actions for pnlYourTrack====================================================================
    Private Sub dgvYourTrack_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvYourTrack.CellContentClick
        Dim trkYourName As String
        Dim trkYourID As Integer
        Try
            If dgvYourTrack.Columns(e.ColumnIndex).Name = "trk_yourplay" Then
                trkYourID = CInt(dgvYourTrack.Rows(e.RowIndex).Cells("trk_yourid").Value)
                Dim query As String = "SELECT trk_audio FROM track WHERE trk_id = " & trkYourID
                Dim filePath As String = ""

                Using conn
                    conn.Open()

                    Using cmd As New MySqlCommand(query, conn)
                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.Read() Then
                            filePath = reader("trk_audio").ToString()
                        End If

                        reader.Close()
                    End Using

                    conn.Close()
                End Using

                If filePath <> "" Then
                    ' Set the URL property of the media player control to the file path
                    AxWindowsMediaPlayer1.URL = filePath
                    ' Start playing the audio and show the play/pause button as "pause"
                    AxWindowsMediaPlayer1.Ctlcontrols.play()
                End If

            ElseIf dgvYourTrack.Columns(e.ColumnIndex).Name = "trk_youredit" Then
                ' Get the trk_name of the selected row
                trkYourName = dgvYourTrack.Rows(e.RowIndex).Cells("trk_yourname").Value.ToString()
                LoadTrackData()

            ElseIf dgvYourTrack.Columns(e.ColumnIndex).Name = "trk_yourdelete" Then
                ' Get the trk_name of the selected row
                trkYourName = dgvYourTrack.Rows(e.RowIndex).Cells("trk_yourname").Value.ToString()
                trkYourID = Convert.ToInt32(dgvYourTrack.Rows(e.RowIndex).Cells("trk_yourid").Value)

                ' Prompt the user to confirm the deletion
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete '{trkYourName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Delete the row from the database
                    Dim query As String = $"DELETE FROM track WHERE trk_id = '{trkYourID}'"
                    Dim cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    ' Remove the row from the DataGridView
                    dgvYourTrack.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '========================================All Actions for pnlUsers====================================================================
    Private Sub dgvUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellContentClick
        Dim userName As String
        Dim userID As Integer
        Dim userActive As Boolean
        Dim userIsType As String
        Try
            If dgvUsers.Columns(e.ColumnIndex).Name = "user_update" Then
                userName = dgvUsers.Rows(e.RowIndex).Cells("user_username").Value.ToString()
                userID = Convert.ToInt32(dgvUsers.Rows(e.RowIndex).Cells("user_id").Value)
                userActive = CBool(dgvUsers.Rows(e.RowIndex).Cells("user_active").Value)
                userIsType = dgvUsers.Rows(e.RowIndex).Cells("user_istype").Value.ToString()

                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to update '{userName}'?", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Update the database with the new values
                If result = DialogResult.Yes Then
                    Using conn
                        conn.Open()
                        Dim query As String = "UPDATE users SET user_active=@uactive, user_istype=@uistype WHERE user_id=@uid"
                        Using cmd As New MySqlCommand(query, conn)
                            cmd.Parameters.AddWithValue("@uactive", userActive)
                            cmd.Parameters.AddWithValue("@uistype", userIsType)
                            cmd.Parameters.AddWithValue("@uid", userID)
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using

                    MessageBox.Show($"'{userName}' was successfully updated.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LoadTrackData()
                Else
                    MessageBox.Show($"Update unsuccesful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            ElseIf dgvUsers.Columns(e.ColumnIndex).Name = "user_delete" Then
                ' Get the trk_name of the selected row
                userName = dgvUsers.Rows(e.RowIndex).Cells("user_username").Value.ToString()
                userID = Convert.ToInt32(dgvUsers.Rows(e.RowIndex).Cells("user_id").Value)

                ' Prompt the user to confirm the deletion
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete '{userName}'?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If result = DialogResult.Yes Then
                    ' Delete the row from the database
                    Dim query As String = $"DELETE FROM users WHERE user_id = '{userID}'"
                    Dim cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    ' Remove the row from the DataGridView
                    dgvUsers.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '========================================All Actions for pnlUpload====================================================================
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

                        Dim cmd As New MySqlCommand("INSERT INTO track(trk_name, trk_artist, trk_audio, trk_picture, trk_genre, trk_featartist, trk_date, trk_user) VALUES(@tname,@tartist,@taudiopath,@tpic,@tgenre,@tftartist,@tdate,@tuser)", conn)
                        cmd.Parameters.AddWithValue("@tname", txtTrkName.Text)
                        cmd.Parameters.AddWithValue("@tartist", txtArtist.Text)
                        cmd.Parameters.AddWithValue("@taudiopath", audiopath)
                        cmd.Parameters.AddWithValue("@tpic", arrimage)
                        cmd.Parameters.AddWithValue("@tgenre", cbxGenre.Text)
                        cmd.Parameters.AddWithValue("@tftartist", txtFtArtist.Text)
                        cmd.Parameters.AddWithValue("@tdate", dateString)
                        cmd.Parameters.AddWithValue("@tuser", frmLogin.intCurID)

                        Dim x As Integer

                        x = cmd.ExecuteNonQuery()

                        If x > 0 Then
                            MessageBox.Show("Song uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearUploadTrack()
                        Else
                            MessageBox.Show("Upload was unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        ClearUploadTrack()
    End Sub
    '========================================All Actions for pnlCreateUser====================================================================
    Private Sub btnUploadUser_Click(sender As Object, e As EventArgs) Handles btnUploadUser.Click
        Dim isActive As Boolean = chkCrtActive.Checked

        If String.IsNullOrEmpty(txtCrtUsername.Text) OrElse String.IsNullOrEmpty(txtCrtEmail.Text) OrElse String.IsNullOrEmpty(txtCrtPwd.Text) OrElse
            String.IsNullOrEmpty(cbxCrtType.Text) OrElse Not chkCrtActive.Checked Then
            MessageBox.Show("Please enter a value in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ' Saves the image by connecting to the database (Image is saved as byte)
            If txtCrtConfirmPwd.Text = txtCrtPwd.Text Then
                Try
                    Using conn
                        conn.Open()

                        Dim cmd As New MySqlCommand("INSERT INTO users(user_username, user_email, user_password, user_active, user_istype) VALUES(@uname,@uemail,@upwd,@uactive,@uistype)", conn)
                        cmd.Parameters.AddWithValue("@uname", txtCrtUsername.Text)
                        cmd.Parameters.AddWithValue("@uemail", txtCrtEmail.Text)
                        cmd.Parameters.AddWithValue("@upwd", txtCrtPwd.Text)
                        cmd.Parameters.AddWithValue("@uactive", isActive)
                        cmd.Parameters.AddWithValue("@uistype", cbxCrtType.Text)

                        Dim x As Integer

                        x = cmd.ExecuteNonQuery()

                        If x > 0 Then
                            MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ClearCreateUser()
                        Else
                            MessageBox.Show("User was not created.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                        cmd.Parameters.Clear()
                    End Using

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            Else
                MessageBox.Show("Confirm Password and Password must be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub btnCrtClear_Click(sender As Object, e As EventArgs) Handles btnCrtClear.Click
        ClearCreateUser()
    End Sub

    Private Sub txtDiscSearch_TextChanged(sender As Object, e As EventArgs) Handles txtDiscSearch.TextChanged
        If txtDiscSearch.Focused Then
            SearchTrack()
        End If
    End Sub

    Private Sub txtYourSearch_TextChanged(sender As Object, e As EventArgs) Handles txtYourSearch.TextChanged
        If txtYourSearch.Focused Then
            SearchYourTrack()
        End If
    End Sub

    Private Sub txtUserSearch_TextChanged(sender As Object, e As EventArgs) Handles txtUserSearch.TextChanged
        If txtUserSearch.Focused Then
            SearchUser()
        End If
    End Sub

    Private Sub btnSignOut_Click(sender As Object, e As EventArgs) Handles btnSignOut.Click
        Dim msgSignOut = MessageBox.Show("Are you sure you want to sign out?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgSignOut = Windows.Forms.DialogResult.Yes Then
            Me.Close()
            frmLogin.Show()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ctrlbxClose_Click(sender As Object, e As EventArgs) Handles ctrlbxClose.Click
        Dim msgClose = MessageBox.Show("Are you sure you want to close the application?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If msgClose = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            Exit Sub
        End If
    End Sub
End Class