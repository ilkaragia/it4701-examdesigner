Public Class insQuestionForm

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Hide()
    End Sub

    Private Sub categoryCombo1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles categoryCombo1.SelectedIndexChanged
        If topicsCombo.Enabled = False Then
            topicsCombo.Enabled = True
        End If
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