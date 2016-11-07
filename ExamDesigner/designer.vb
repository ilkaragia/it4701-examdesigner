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