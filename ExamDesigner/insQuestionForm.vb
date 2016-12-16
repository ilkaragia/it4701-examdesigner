Imports System.Data.SqlClient

Public Class insQuestionForm
    Private myConn As SqlConnection
    Private myCmd1, myCmd2, myCmd3, sqlGetCID, sqlGetTID As SqlCommand
    Private myReader, myReader2 As SqlDataReader
    Private results, results2 As String
    Private Sub CancelInsQuestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelInsQuestButton.Click
        Me.Hide()
    End Sub

    Private Sub insQuestionForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Reset all controls
        QuesCategoryComboBox.SelectedItem = Nothing
        TopicComboBox.SelectedItem = Nothing
        LevelComboBox.SelectedItem = Nothing
        TopicComboBox.Enabled = False
        LevelComboBox.Enabled = False
        QuestionRichTextBox.Enabled = False
        Answer1RichTextBox.Enabled = False
        Answer2RichTextBox.Enabled = False
        Answer3RichTextBox.Enabled = False
        Answer4RichTextBox.Enabled = False
        QuestionRichTextBox.Text = ""
        Answer1RichTextBox.Text = ""
        Answer2RichTextBox.Text = ""
        Answer3RichTextBox.Text = ""
        Answer4RichTextBox.Text = ""
        'Insert question to db
        myConn = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")
        myCmd1 = myConn.CreateCommand
        myCmd1.CommandText = "SELECT name FROM categories order by cid"
        myConn.Open()
        myCmd1.ExecuteNonQuery()
        myReader = myCmd1.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(0)
            QuesCategoryComboBox.Items.Add(results)
        Loop
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub OKInsQuestButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKInsQuestButton.Click
        Dim selectedCID, selectedTID As Integer
        myCmd3 = myConn.CreateCommand
        sqlGetCID = myConn.CreateCommand
        sqlGetTID = myConn.CreateCommand
        sqlGetCID.CommandText = " SELECT cid FROM categories WHERE name = '" & QuesCategoryComboBox.Text & "'"
        sqlGetTID.CommandText = " SELECT tid FROM topics WHERE name = '" & TopicComboBox.Text & "'"
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
        myCmd3.CommandText = "INSERT INTO questions (tid,cid,level,txt,opta,optb,optc,optd)VALUES ('" & selectedTID & "','" & selectedCID & "','" & Convert.ToInt32(LevelComboBox.SelectedItem.ToString) & "','" & QuestionRichTextBox.Text & "','" & Answer1RichTextBox.Text & "','" & Answer2RichTextBox.Text & "','" & Answer3RichTextBox.Text & "','" & Answer4RichTextBox.Text & "')"
        myCmd3.ExecuteNonQuery()
        MessageBox.Show("Question inserted!")
        myConn.Close()
        designer.Reload()
        Me.Dispose()
        Me.Hide()
    End Sub

    Private Sub QuesCategoryComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuesCategoryComboBox.SelectedIndexChanged
        If TopicComboBox.Enabled = False Then
            TopicComboBox.Enabled = True
        End If
        TopicComboBox.Items.Clear()
        myCmd2 = myConn.CreateCommand
        myCmd2.CommandText = "SELECT name FROM topics where cid  in (select cid from categories where name='" & QuesCategoryComboBox.SelectedItem.ToString & "')"
        myConn.Open()
        myCmd2.ExecuteNonQuery()
        myReader2 = myCmd2.ExecuteReader()
        Do While myReader2.Read()
            results2 = myReader2.GetString(0)
            TopicComboBox.Items.Add(results2)
        Loop
        myReader.Close()
        myConn.Close()
        TopicComboBox.SelectedIndex = 0

    End Sub

    Private Sub TopicComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TopicComboBox.SelectedIndexChanged
        If LevelComboBox.Enabled = False Then
            LevelComboBox.Enabled = True
        End If
    End Sub

    Private Sub LevelComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelComboBox.SelectedIndexChanged
        QuestionRichTextBox.Enabled = True
    End Sub

    Private Sub QuestionRichTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuestionRichTextBox.TextChanged
        Answer1RichTextBox.Enabled = True
    End Sub

    Private Sub Answer1RichTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer1RichTextBox.TextChanged
        Answer2RichTextBox.Enabled = True
    End Sub

    Private Sub Answer2RichTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer2RichTextBox.TextChanged
        Answer3RichTextBox.Enabled = True
    End Sub

    Private Sub Answer3RichTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer3RichTextBox.TextChanged
        Answer4RichTextBox.Enabled = True
    End Sub

    Private Sub Answer4RichTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Answer4RichTextBox.TextChanged
        OKInsQuestButton.Enabled = True
    End Sub
End Class