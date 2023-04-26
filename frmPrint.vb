Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class frmPrint
    'Defining connection string and mysql commands
    Dim conn = New MySqlConnection(My.Settings.connString)

    Private Sub frmPrintUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            Dim cmdCreated As New MySqlCommand("SELECT DATE_FORMAT(trk_created, '%M %e, %Y %h:%i%p') FROM track WHERE trk_id = " & frmMain.intSelTrkID, conn)
            Dim objCreated As Object = cmdCreated.ExecuteScalar().ToString()

            txtCreatedPrt.Text = $"{objCreated}"

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            conn.Close()
            conn.Dispose()
        End Try

        Dim ms As New MemoryStream(frmMain.bytSelTrkPic)
        picTrkPicPrt.Image = Image.FromStream(ms)
        txtTrkNamePrt.Text = frmMain.strSelTrkName
        txtArtistPrt.Text = frmMain.strSelTrkArtist
        txtGenrePrt.Text = frmMain.strSelTrkGenre
        txtDatePrt.Text = frmMain.strSelTrkDate
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Get the control to be printed
        Dim ctrl As Control = Me

        'Create a Bitmap object to hold the image of the control
        Dim bmp As New Bitmap(ctrl.Width, ctrl.Height)

        'Draw the control to the bitmap
        ctrl.DrawToBitmap(bmp, ctrl.ClientRectangle)

        'Draw the bitmap to the printer
        e.Graphics.DrawImage(bmp, 0, 0)
    End Sub

    Private Sub btnTrkPrint_Click(sender As Object, e As EventArgs) Handles btnTrkPrint.Click
        PrintDialog1.Document = PrintDocument1

        'Display the Print dialog box
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            'Print the document
            PrintDocument1.Print()
        End If
    End Sub
End Class