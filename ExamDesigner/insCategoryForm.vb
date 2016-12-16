Imports System.Data.SqlClient

Public Class insCategoryForm

    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String
    Private Sub CancelInsCatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelInsCatButton.Click
        Me.Hide()
    End Sub

    Private Sub OKInsCatButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKInsCatButton.Click

        myConn = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "INSERT INTO categories (name)VALUES ('" & CategoryTextBox.Text & "')"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        MessageBox.Show("Category inserted!", "Information")
        myConn.Close()
        designer.Reload()
        Me.Dispose()
        Me.Hide()
    End Sub

    Private Sub insCategoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CategoryTextBox.Text = ""
    End Sub
End Class