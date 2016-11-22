Imports System.Data.SqlClient

Public Class insQuestionForm
    Private myConn As SqlConnection
    Private myCmd1, myCmd2, myCmd3, sqlGetCID, sqlGetTID As SqlCommand
    Private myReader, myReader2 As SqlDataReader
    Private results, results2 As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Hide()
    End Sub

    Private Sub insQuestionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Reset all controls
        categoryCombo1.SelectedItem = Nothing
        topicsCombo.SelectedItem = Nothing
        levelCombo.SelectedItem = Nothing
        topicsCombo.Enabled = False
        levelCombo.Enabled = False
        qRichTxtBox.Enabled = False
        o1RichTxtBox.Enabled = False
        o2RichTxtBox.Enabled = False
        o3RichTxtBox.Enabled = False
        o4RichTxtBox.Enabled = False
        qRichTxtBox.Text = ""
        o1RichTxtBox.Text = ""
        o2RichTxtBox.Text = ""
        o3RichTxtBox.Text = ""
        o4RichTxtBox.Text = ""
        'Insert question to db
        myConn = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")
        myCmd1 = myConn.CreateCommand
        myCmd1.CommandText = "SELECT name FROM categories order by cid"
        myConn.Open()
        myCmd1.ExecuteNonQuery()
        myReader = myCmd1.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(0)
            categoryCombo1.Items.Add(results)
        Loop
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKbutton.Click
        Dim selectedCID, selectedTID As Integer
        myCmd3 = myConn.CreateCommand
        sqlGetCID = myConn.CreateCommand
        sqlGetTID = myConn.CreateCommand
        sqlGetCID.CommandText = " SELECT cid FROM categories WHERE name = '" & categoryCombo1.Text & "'"
        sqlGetTID.CommandText = " SELECT tid FROM topics WHERE name = '" & topicsCombo.Text & "'"
        myConn.Open()
        sqlGetCID.ExecuteNonQuery()
        sqlGetTID.ExecuteNonQuery()
        myReader = sqlGetCID.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetInt32(0)
            selectedCID = results
        Loop
        myReader.Close()
        myReader = sqlGetTID.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetInt32(0)
            selectedTID = results
        Loop
        myReader.Close()
        myCmd3.CommandText = "INSERT INTO questions (tid,cid,level,txt,opta,optb,optc,optd)VALUES ('" & selectedTID & "','" & selectedCID & "','" & Convert.ToInt32(levelCombo.SelectedItem.ToString) & "','" & qRichTxtBox.Text & "','" & o1RichTxtBox.Text & "','" & o2RichTxtBox.Text & "','" & o3RichTxtBox.Text & "','" & o4RichTxtBox.Text & "')"
        myCmd3.ExecuteNonQuery()
        MessageBox.Show("Question inserted!")
        myConn.Close()
        designer.ReloadBtn.PerformClick()
        Me.Dispose()
        Me.Hide()
    End Sub

    Private Sub categoryCombo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categoryCombo1.SelectedIndexChanged
        If topicsCombo.Enabled = False Then
            topicsCombo.Enabled = True
        End If
        topicsCombo.Items.Clear()
        myCmd2 = myConn.CreateCommand
        myCmd2.CommandText = "SELECT name FROM topics where cid  in (select cid from categories where name='" & categoryCombo1.SelectedItem.ToString & "')"
        myConn.Open()
        myCmd2.ExecuteNonQuery()
        myReader2 = myCmd2.ExecuteReader()
        Do While myReader2.Read()
            results2 = myReader2.GetString(0)
            topicsCombo.Items.Add(results2)
        Loop
        myReader.Close()
        myConn.Close()
        topicsCombo.SelectedIndex = 0

    End Sub

    Private Sub topicsCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles topicsCombo.SelectedIndexChanged
        If levelCombo.Enabled = False Then
            levelCombo.Enabled = True
        End If
    End Sub

    Private Sub levelCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles levelCombo.SelectedIndexChanged
        qRichTxtBox.Enabled = True
    End Sub

    Private Sub qRichTxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qRichTxtBox.TextChanged
        o1RichTxtBox.Enabled = True
    End Sub

    Private Sub o1RichTxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o1RichTxtBox.TextChanged
        o2RichTxtBox.Enabled = True
    End Sub

    Private Sub o2RichTxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o2RichTxtBox.TextChanged
        o3RichTxtBox.Enabled = True
    End Sub

    Private Sub o3RichTxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o3RichTxtBox.TextChanged
        o4RichTxtBox.Enabled = True
    End Sub

    Private Sub o4RichTxtBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles o4RichTxtBox.TextChanged
        OKbutton.Enabled = True
    End Sub
End Class