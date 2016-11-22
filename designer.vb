Imports System.Data.SqlClient

Public Class designer
    'Public arraySelectedTOPS() As String
    Public filteredSelectedListItems As Array
    Public catselected, topselected As Integer
    Public myConn As SqlConnection = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")
    Public myConn2 As SqlConnection = New SqlConnection("Initial Catalog=exams; Data Source=5.172.194.44;User Id=sa;Password=ad0ps3!@#")
    Public myCmd, myCmd2, myFilteredCmd, myFinalCmd, myClearFinalCmd As SqlCommand
    Public myReader, myReader9 As SqlDataReader
    Public results As String

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        insCategoryForm.Show()
    End Sub

    Private Sub NewTopicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTopicToolStripMenuItem.Click
        insTopicForm.Show()
    End Sub

    Private Sub NewQuestionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewQuestionToolStripMenuItem.Click
        insQuestionForm.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        insTopicForm.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        insQuestionForm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        insCategoryForm.Show()
    End Sub

    
    Private Sub designer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label13.Text = "0"
        Dim treeDataSet As DataSet
        Dim categoriesTA As New SqlClient.SqlDataAdapter("SELECT name,cid from categories", myConn)
        Dim topicsTA As New SqlClient.SqlDataAdapter("SELECT name,cid FROM topics where cid in (select cid from categories)", myConn)
        Dim questionsTA As New SqlClient.SqlDataAdapter("SELECT qid,txt,opta,optb,optc,optd,level from questions where tid in(select tid from topics)", myConn)
        treeDataSet = New DataSet()
        myConn.Open()
        categoriesTA.Fill(treeDataSet, "categories")
        topicsTA.Fill(treeDataSet, "topics")
        questionsTA.Fill(treeDataSet, "questions")
        myConn.Close()
        treeDataSet.Relations.Add("topics2cats", treeDataSet.Tables(0).Columns("cid"), treeDataSet.Tables(1).Columns("cid"))
        'treeDataSet.Relations.Add("questions2topics", treeDataSet.Tables(1).Columns("tid"), treeDataSet.Tables(2).Columns("tid"))
        TreeView1.Nodes.Clear()

        Dim i, n As Integer
        n = 0
        Dim parentrow As DataRow
        Dim ParentTable As DataTable
        Dim qlistDTable As DataTable
        ParentTable = treeDataSet.Tables(0)
        qlistDTable = treeDataSet.Tables(2)
        'TeeView & MultiLists population
        TreeView1.Nodes.Add("My Repository")
        For Each parentrow In ParentTable.Rows
            Dim parentnode As TreeNode
            parentnode = New TreeNode("Category: " + parentrow.Item(0))
            'parentnode.Tag = "Category"
            parentnode.Tag = parentrow.Item(0)
            TreeView1.Nodes.Add(parentnode)
            multiCatList.Items.Add(parentrow.Item(0))
            'childs population
            Dim childrow As DataRow
            Dim childnode As TreeNode
            childnode = New TreeNode()
            For Each childrow In parentrow.GetChildRows("topics2cats")
                childnode = parentnode.Nodes.Add("Topic: " + childrow(0))
                childnode.Tag = childrow("name")
                'childnode.Tag = "Topic"
                'multiTopList.Items.Add(childnode.Text)
            Next childrow
        Next parentrow
        'qListView population
        Dim listviewsubitem As ListViewItem
        For Each parentrow In qlistDTable.Rows
            Dim listviewitem As ListViewItem
            listviewitem = New ListViewItem(parentrow.Item(0).ToString)
            questionListView.Items.Add(listviewitem)
            'qListView child population
            For i = 1 To 6
                listviewsubitem = New ListViewItem(parentrow.Item(i).ToString)
                listviewitem.SubItems.Add(listviewsubitem.Text)
                'questionListView.Items.Item(0).SubItems.Add(parentrow.Item(i).ToString)
            Next
        Next
        Label9.Text = questionListView.Items.Count.ToString
        Label11.Text = multiCatList.Items.Count.ToString
        'If questionListView.Items.Count = 0 Then
        'Button7.Enabled = False
        'Else
        'Button7.Enabled = True
        'End If
    End Sub
    

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "DELETE FROM categories WHERE name=('" & childclicked.Text & "')"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        MessageBox.Show("The selected category will be deleted! In case of topics and questions inside the category, they will become orphaned upon deletion. First, delete the corresponding questions and topics.", "Warning")
        myConn.Close()
        Me.Controls.Clear()
        InitializeComponent()
        designer_Load(e, e)
    End Sub




    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim sItem As String
        sItem = questionListView.Items(questionListView.FocusedItem.Index).SubItems(0).Text()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "DELETE FROM questions WHERE qid =('" & sItem & "')"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        MessageBox.Show("The selected question will be deleted.", "Warning")
        myConn.Close()
        Me.Controls.Clear()
        InitializeComponent()
        designer_Load(e, e)
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiCatList.SelectedIndexChanged
        ' OTAN DEN DIALEGO TIPOTE NA MIN KSEKINAEI QUERY
        If multiCatList.SelectedItems.Count <> 0 Then
            multiTopList.Items.Clear()
            myFilteredCmd = myConn.CreateCommand
            myFilteredCmd.CommandText = "SELECT name FROM topics WHERE cid in(select cid from categories where name='" & multiCatList.SelectedItem.ToString & "')"
            myConn.Open()
            myFilteredCmd.ExecuteNonQuery()
            myReader = myFilteredCmd.ExecuteReader()
            Do While myReader.Read()
                results = myReader.GetString(0)
                multiTopList.Items.Add(results)
            Loop
            myReader.Close()
            myConn.Close()
            sALLbtn.Enabled = True
            sNONEbtn.Enabled = True
            SAVEbtn.Enabled = True
        End If
    End Sub

    Private Sub multiTopList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multiTopList.SelectedIndexChanged
        Label13.Text = multiTopList.SelectedItems.Count.ToString
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "DELETE FROM topics WHERE name=('" & childclicked.Text & "')"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        MessageBox.Show("The selected topic will be deleted! In case of questions inside the category, they will become orphaned upon deletion. First, delete the corresponding questions.", "Warning")
        myConn.Close()
        Me.Controls.Clear()
        InitializeComponent()
        designer_Load(e, e)
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReloadBtn.Click
        Me.Controls.Clear()
        InitializeComponent()
        designer_Load(e, e)
    End Sub
    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sALLbtn.Click
        Dim i As Integer
        For i = 0 To multiTopList.Items.Count - 1
            multiTopList.SetSelected(i, True)
        Next
    End Sub
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

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sNONEbtn.Click
        Dim i As Integer
        For i = 0 To multiTopList.Items.Count - 1
            multiTopList.SetSelected(i, False)
        Next
    End Sub

    Private Sub LEVELtrackbar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEVELtrackbar.Scroll
        Label16.Text = LEVELtrackbar.Value + 1.ToString
    End Sub

    Private Sub numQbox_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numQbox.ValueChanged
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
      
    End Sub

    

   

    

    Private Sub questionListView_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles questionListView.LostFocus

    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

   


    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
     


    End Sub

    
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        aboutForm.Show()

    End Sub

    Private Sub AboutToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub DsdsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        aboutForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub

    

    

    Private Sub NewCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCategoryToolStripMenuItem.Click
        insCategoryForm.Show()

    End Sub

    Private Sub DeleteCategoryToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCategoryToolStripMenuItem1.Click

    End Sub

    Private Sub NewTopicToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTopicToolStripMenuItem1.Click
        insTopicForm.Show()

    End Sub

    

    Private Sub NewQuestionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewQuestionToolStripMenuItem1.Click
        insQuestionForm.Show()

    End Sub


    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles anyCHK.CheckedChanged
        If LEVELtrackbar.Enabled = True Then
            LEVELtrackbar.Enabled = False
        Else
            LEVELtrackbar.Enabled = True
        End If
    End Sub
End Class
