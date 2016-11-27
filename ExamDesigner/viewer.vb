Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.IO
Imports System.Drawing.Printing
Imports System.Data.SqlClient

Public Class viewer
    Public myConn As SqlConnection = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")

    Public myViewCmd As SqlCommand
    Public myViewReader As SqlDataReader
    Public myViewResults As String

    Public savestatus = False
    Public tmpdir = Path.GetTempPath()
    Private Sub viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If System.IO.File.Exists(tmpdir + "tmptest.html") Then
            System.IO.File.Delete(tmpdir + "tmptest.html")
        End If
        Dim q, A1, A2, A3, A4 As String

        Dim htmlInit As String = "<!DOCTYPE html><html><body><form>"
        Dim content = ""
        Dim htmlClose As String = "</body></html>"
        Dim i = 0
        Dim fS As String = htmlInit

        'load from db and create html
        myViewCmd = myConn.CreateCommand
        myViewCmd.CommandText = "SELECT * FROM finalq"
        myConn.Open()
        myViewCmd.ExecuteNonQuery()
        myViewReader = myViewCmd.ExecuteReader()
        Do While myViewReader.Read()
            i += 1
            q = "Qestion #" + i.ToString + "   " + myViewReader.GetString(0)
            A1 = myViewReader.GetString(1)
            A2 = myViewReader.GetString(2)
            A3 = myViewReader.GetString(3)
            A4 = myViewReader.GetString(4)
            content = "<p><b>" + q + "</b></p></br><input type=""checkbox"">" + A1 + "<br><br><br><br><input type=""checkbox"">" + A2 + "<br><br><br><br><input type=""checkbox"">" + A3 + "<br><br><br><br><input type=""checkbox"">" + A4 + "<br><br><hr>"
            fS += content
        Loop
        fS += htmlClose
        myViewReader.Close()
        myConn.Close()
        'create testfile and load it into viewer
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(tmpdir + "tmptest.html", True)
        file.WriteLine(fS)
        file.Close()
        WebBrowser1.Navigate(tmpdir + "tmptest.html")

        '==============================AKYRO======================================================

        'For i = 0 To 64
        '    Dim pnl As Panel = New Panel
        '    Dim qlabel As Label = New Label
        '    Dim a1Chk As CheckBox = New CheckBox
        '    Dim a2Chk As CheckBox = New CheckBox
        '    Dim a3Chk As CheckBox = New CheckBox
        '    Dim a4Chk As CheckBox = New CheckBox
        '    pnl.Size = New Size(1100, 200)
        '    pnl.Location = New Point(30, 10 + i * 210)
        '    qlabel.Location = New Point(21, 11)
        '    a1Chk.Location = New Point(21, 90)
        '    a2Chk.Location = New Point(381, 90)
        '    a3Chk.Location = New Point(21, 150)
        '    a4Chk.Location = New Point(381, 150)
        '    pnl.BorderStyle = BorderStyle.FixedSingle
        '    qlabel.AutoSize = True
        '    a1Chk.AutoSize = True
        '    a2Chk.AutoSize = True
        '    a3Chk.AutoSize = True
        '    a4Chk.AutoSize = True
        '    qlabel.Text = "QUESTION TEXT " + (i + 1).ToString + " XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        '    a1Chk.Text = "Answer 1 XXXXXXXXXXXXXXXXXXXXXXXX"
        '    a2Chk.Text = "Answer 2 XXXXXXXXXXXXXXXXXXXXXXXX"
        '    a3Chk.Text = "Answer 3 XXXXXXXXXXXXXXXXXXXXXXXX"
        '    a4Chk.Text = "Answer 4 XXXXXXXXXXXXXXXXXXXXXXXX"
        '    pnl.Controls.Add(qlabel)
        '    pnl.Controls.Add(a1Chk)
        '    pnl.Controls.Add(a2Chk)
        '    pnl.Controls.Add(a3Chk)
        '    pnl.Controls.Add(a4Chk)
        '    Me.Controls.Add(pnl)
        '    Me.Controls.Add(rootpnl)
        '    rootpnl.Controls.Add(pnl)
        'Next
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted


    End Sub

    Private Sub savBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savBtn.Click
        SaveFileDialog1.Filter = "HTML files (*.html)|*.html"
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub viewerMenu_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles viewerMenu.ItemClicked

    End Sub

    Private Sub prntBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prntBtn.Click
        WebBrowser1.Print()
    End Sub

    Private Sub SaveFileDialog1_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles SaveFileDialog1.Disposed

    End Sub

    Private Sub SaveFileDialog1_FileOk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Using webClient = New Net.WebClient()
            Dim bytes = webClient.DownloadData(WebBrowser1.Url.ToString)
            Dim fpath = SaveFileDialog1.FileName.ToString
            File.WriteAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fpath), bytes)
        End Using
        File.Delete(tmpdir + "tmptest.html")
        savestatus = True



    End Sub

    Private Sub xBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xBtn.Click
        If savestatus = False Then
            MsgBox("You have not saved the current test. If you close the viewer, the test will be lost!", MsgBoxStyle.OkCancel, "Warning")

        End If
        Me.Dispose()
        Me.Hide()

    End Sub

End Class