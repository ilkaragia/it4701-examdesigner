Public Class designer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insCategoryForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        insTopicForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        insQuestionForm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Διαγραφή από τη βάση του επιλεγμένου category
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Διαγραφή από τη βάση του επιλεγμένου topic
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'Διαγραφή της επιλεγμένης ερώτησης από τη βάση
    End Sub
    
     Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sALLbtn.Click
        Dim i As Integer
        For i = 0 To multiTopList.Items.Count - 1
            multiTopList.SetSelected(i, True)
        Next
    End Sub
'Επιλογή όλων των ερωτήσεων του Topic

    Private Sub Button11_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SAVEbtn.Click
        Dim listItem As String
        Dim i As Integer = 0

        TextBox1.Text = " "
        Label13.Text = multiTopList.SelectedItems.Count.ToString    '<= LABEL FOR SELECTED TOPICS COUNT
        Dim arraySelectedTOPS(multiTopList.SelectedItems.Count)     '<= STORE EACH SELECTED TOPIC IN AN ARRAY
        'Dim LISTselectedTOPS As New List(Of String)()               '<= DOKIMI KAI ME LISTA

        If multiTopList.SelectedItems.Count = 0 Then
            TextBox1.Text = " "
            arraySelectedTOPS(0) = " "
            'LISTselectedTOPS.Clear()
        End If
        For Each selecteditem As Object In multiTopList.SelectedItems
            If multiTopList.SelectedItems.Count = 1 Then
                listItem = selecteditem.ToString
                TextBox1.Text = listItem
                arraySelectedTOPS(i) = listItem
                'LISTselectedTOPS.Add(listItem)
            ElseIf multiTopList.SelectedItems.Count > 1 Then
                listItem = selecteditem.ToString
                arraySelectedTOPS(i) = listItem
                TextBox1.Text += listItem + " "
                'LISTselectedTOPS.Add(listItem)
            End If
            i += 1
        Next
        If TextBox1.Text = " " Then
            MsgBox("You have not selected any topic", , "Information")
        Else
            MsgBox("You have selected the following topics:'" & TextBox1.Text & "'", , "Information")

            For i = 0 To multiTopList.SelectedItems.Count - 1
                'DEBUG: MsgBox(arraySelectedTOPS(i))
            Next
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "DELETE FROM tmpq"
            myConn.Open()
            myCmd.ExecuteNonQuery()
            myReader.Close()
            myConn.Close()
            For i = 0 To multiTopList.SelectedItems.Count - 1
                myCmd.CommandText = "INSERT INTO tmpq (txt)VALUES ('" & arraySelectedTOPS(i) & "')"
                myConn.Open()
                myCmd.ExecuteNonQuery()
                myReader.Close()
                myConn.Close()
            Next
            myFilteredCmd = myConn.CreateCommand
            myFilteredCmd.CommandText = "SELECT COUNT(*) FROM questions WHERE tid in(select tid from topics where name in(SELECT txt FROM tmpq))"
            myConn.Open()
            myFilteredCmd.ExecuteNonQuery()
            myReader = myFilteredCmd.ExecuteReader()
            myReader.Read()
            results = myReader.GetInt32(0)
            'DEBUG:  MsgBox("DEBUG: COUNT OF QUESTIONS IN THE SELECTED TOPICS: " + results)
            Label8.Text = results
            numQbox.Maximum = results
            myReader.Close()
            myConn.Close()
            GENbtn.Enabled = True
        End If
    End Sub
            'Αποθήκευση των ερωτησεων
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sNONEbtn.Click
        Dim i As Integer
        For i = 0 To multiTopList.Items.Count - 1
            multiTopList.SetSelected(i, False)
        Next
    End Sub
    
    Private Sub NewTopicToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTopicToolStripMenuItem1.Click
        insTopicForm.Show()
    End Sub

    Private Sub NewCategoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCategoryToolStripMenuItem.Click
        insCategoryForm.Show()
    End Sub

    Private Sub NewQuestionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewQuestionToolStripMenuItem1.Click
        insQuestionForm.Show()
    End Sub

End Class
