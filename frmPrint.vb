Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Imports System.IO
Public Class frmPrint
    'Defining connection string and mysql commands
    Dim conn = New MySqlConnection(My.Settings.connString)

    Private Sub frmPrintUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Open connection to the database
            conn.Open()

            ' Create a command object that selects the date when a specific music track was created, and formats it using the DATE_FORMAT() function
            Dim cmdCreated As New MySqlCommand("SELECT DATE_FORMAT(trk_created, '%M %e, %Y %h:%i%p') FROM track WHERE trk_id = " & frmMain.intSelTrkID, conn)
            Dim objCreated As Object = cmdCreated.ExecuteScalar().ToString()

            ' Assign the formatted date to a textbox
            txtCreatedPrt.Text = $"{objCreated}"

        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            ' Close and dispose of the database connection
            conn.Close()
            conn.Dispose()
        End Try

        ' Create a new memory stream and  set the Image property of a picture box related to the selected music track
        Dim ms As New MemoryStream(frmMain.bytSelTrkPic)
        picTrkPicPrt.Image = Image.FromStream(ms)

        ' Populate various text boxes on the form with data related to the selected music track
        txtTrkNamePrt.Text = frmMain.strSelTrkName
        txtArtistPrt.Text = frmMain.strSelTrkArtist
        txtGenrePrt.Text = frmMain.strSelTrkGenre

        ' If statement that handles if the featuring artist is empty or not for the selected music track and populates the textbox accordingly
        If frmMain.strSelTrkFtArtist = "" Then
            txtFtArtistPrt.PlaceholderText = ""
        Else
            txtFtArtistPrt.Text = frmMain.strSelTrkFtArtist
        End If
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

        ' Set the page settings
        PrintDocument1.DefaultPageSettings.Landscape = True ' Orientation
        PrintDocument1.DefaultPageSettings.Margins = New Printing.Margins(50, 50, 50, 50) ' Margins

        'Display the Print dialog box
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            'Print the document
            PrintDocument1.Print()
        End If
    End Sub
End Class