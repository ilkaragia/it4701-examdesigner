Imports System.Data.SqlClient

Public Class insTopicForm
    Private myConn As SqlConnection
    Private myCmd, myCmd2 As SqlCommand
    Private myReader, myReader2 As SqlDataReader
    Private results, results2 As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        myConn = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "INSERT INTO topics (cid, name)VALUES ('" & results2 & "', '" & topicTextBox.Text & "')"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        MessageBox.Show("Topic inserted!", "Information")
        myConn.Close()
        designer.ReloadBtn.PerformClick()
        Me.Dispose()
        Me.Hide()
    End Sub

    Private Sub insTopicForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        categoryCombo.SelectedItem = Nothing
        topicTextBox.Text = ""
        topicTextBox.Enabled = False

        myConn = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "select name from categories"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myReader = myCmd.ExecuteReader()
        Do While myReader.Read()
            results = myReader.GetString(0)
            categoryCombo.Items.Add(results)
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categoryCombo.SelectedIndexChanged
        topicTextBox.ReadOnly = False
        topicTextBox.Enabled = True


        myConn = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")
        myCmd2 = myConn.CreateCommand
        myCmd2.CommandText = "select cid from categories where name= '" & categoryCombo.Text & "'"
        myConn.Open()
        myCmd2.ExecuteNonQuery()
        myReader2 = myCmd2.ExecuteReader()
        Do While myReader2.Read()
            results2 = myReader2.GetInt32(0)
            'MessageBox.Show("DEBUG: CID LOADED!")
        Loop
        
        myConn.Close()
    End Sub
End Class