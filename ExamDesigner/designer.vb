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
    Friend categoriesSelected As String
    Friend childClickedName As String

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        insCategoryForm.Show()
    End Sub

    Private Sub NewTopicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTopicToolStripMenuItem.Click
        insTopicForm.Show()
    End Sub

    Private Sub NewQuestionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewQuestionToolStripMenuItem.Click
        insQuestionForm.Show()
    End Sub

    Private Sub NewTopicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTopicButton.Click
        insTopicForm.Show()
    End Sub

    Private Sub NewQuestionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewQuestionButton.Click
        insQuestionForm.Show()
    End Sub

    Private Sub NewCategoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCategoryButton.Click
        insCategoryForm.Show()
    End Sub

    Private Sub GenerateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateButton.Click
        viewer.Cursor = Cursors.WaitCursor

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "DELETE FROM finalq"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        myReader.Close()
        myConn.Close()

        Dim i As Integer
        Dim finalresults(4)
        results = ""
        myFilteredCmd = myConn.CreateCommand

        If RandomizeCheckBox.Checked = True And AnyLvlCheckBox.Enabled = True Then
            myFilteredCmd.CommandText = "SELECT TOP " & numOfQuestNumBox.Value & " txt,opta,optb,optc,optd FROM questions WHERE tid in(select tid from topics where name in(SELECT txt FROM tmpq)) ORDER BY newid()"
        ElseIf RandomizeCheckBox.Checked = True And AnyLvlCheckBox.Enabled = False Then
            myFilteredCmd.CommandText = "SELECT TOP " & numOfQuestNumBox.Value & " txt,opta,optb,optc,optd FROM questions WHERE tid in(select tid from topics where name in(SELECT txt FROM tmpq)) AND level=" & LevelTrackBar.Value + 1 & " ORDER BY newid()"
        ElseIf RandomizeCheckBox.Checked = False And AnyLvlCheckBox.Enabled = True Then
            myFilteredCmd.CommandText = "SELECT TOP " & numOfQuestNumBox.Value & " txt,opta,optb,optc,optd FROM questions WHERE tid in(select tid from topics where name in(SELECT txt FROM tmpq))"
        ElseIf RandomizeCheckBox.Checked = False And AnyLvlCheckBox.Enabled = False Then
            myFilteredCmd.CommandText = "SELECT TOP " & numOfQuestNumBox.Value & " txt,opta,optb,optc,optd FROM questions WHERE tid in(select tid from topics where name in(SELECT txt FROM tmpq)) AND level=" & LevelTrackBar.Value + 1 & ""
        End If
        myConn.Open()
        myFilteredCmd.ExecuteNonQuery()
        myReader = myFilteredCmd.ExecuteReader()
        myFinalCmd = myConn2.CreateCommand

        Do While myReader.Read()
            myFinalCmd.CommandText = "INSERT INTO finalq (txt,opta,optb,optc,optd)VALUES ("
            For i = 0 To 4
                results = myReader.GetString(i)
                finalresults(i) = results
                If i <= 3 Then
                    myFinalCmd.CommandText += "'" & finalresults(i) & "',"
                Else
                    myFinalCmd.CommandText += "'" & finalresults(i) & "'"
                End If
            Next
            myFinalCmd.CommandText += ")"
            myConn2.Open()
            myFinalCmd.ExecuteNonQuery()
            myConn2.Close()
        Loop
        myConn2.Close()
        myReader.Close()
        myConn.Close()
        viewer.Cursor = Cursors.Arrow
        viewer.Show()
    End Sub
    Private Sub designer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SelectedTopValueLabel.Text = "0"
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
            MultiCategListBox.Items.Add(parentrow.Item(0))
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
            QuestionListView.Items.Add(listviewitem)
            'qListView child population
            For i = 1 To 6
                listviewsubitem = New ListViewItem(parentrow.Item(i).ToString)
                listviewitem.SubItems.Add(listviewsubitem.Text)
                'questionListView.Items.Item(0).SubItems.Add(parentrow.Item(i).ToString)
            Next
        Next
        TotalQuestValueLabel.Text = QuestionListView.Items.Count.ToString
        TotalCategValueLabel.Text = MultiCategListBox.Items.Count.ToString
        'If questionListView.Items.Count = 0 Then
        'Button7.Enabled = False
        'Else
        'Button7.Enabled = True
        'End If
    End Sub
    Private Sub TreeView1_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseClick
        childClickedName = e.Node.Tag

        If Not childClickedName = "" Then
            EditCategoryButton.Enabled = True
            EditTopicButton.Enabled = True
            DeleteCategoryButton.Enabled = True
            DeleteTopicButton.Enabled = True
            EditCategoryToolStripMenuItem.Enabled = True
            DeleteCategoryToolStripMenuItem1.Enabled = True
            EditTopicToolStripMenuItem.Enabled = True
            DeleteTopicToolStripMenuItem1.Enabled = True
        End If

    End Sub

    Private Sub DeleteCategoryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteCategoryButton.Click
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "DELETE FROM categories WHERE name=('" & childClickedName & "')"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        MessageBox.Show("The selected category will be deleted! In case of topics and questions inside the category, they will become orphaned upon deletion. First, delete the corresponding questions and topics.", "Warning")
        myConn.Close()
        Reload()
    End Sub

    Private Sub questionListView_ItemSelectionChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles QuestionListView.ItemSelectionChanged
        EditQuestionButton.Enabled = True
        DeleteQuestionButton.Enabled = True
    End Sub

    Private Sub DeleteQuestionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteQuestionButton.Click
        Dim sItem As String
        sItem = QuestionListView.Items(QuestionListView.FocusedItem.Index).SubItems(0).Text()
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "DELETE FROM questions WHERE qid =('" & sItem & "')"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        MessageBox.Show("The selected question will be deleted.", "Warning")
        myConn.Close()
        Reload()
    End Sub
    Private Sub MultiCategListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiCategListBox.SelectedIndexChanged
        ' OTAN DEN DIALEGO TIPOTE NA MIN KSEKINAEI QUERY
        If MultiCategListBox.SelectedItems.Count <> 0 Then
            MultiTopListBox.Items.Clear()
            myFilteredCmd = myConn.CreateCommand
            myFilteredCmd.CommandText = "SELECT name FROM topics WHERE cid in(select cid from categories where name='" & MultiCategListBox.SelectedItem.ToString & "')"
            myConn.Open()
            myFilteredCmd.ExecuteNonQuery()
            myReader = myFilteredCmd.ExecuteReader()
            Do While myReader.Read()
                results = myReader.GetString(0)
                MultiTopListBox.Items.Add(results)
            Loop
            myReader.Close()
            myConn.Close()
            SelectAllButton.Enabled = True
            SelectNoneButton.Enabled = True
            SaveButton.Enabled = True
        End If
    End Sub

    Private Sub multiTopList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MultiTopListBox.SelectedIndexChanged
        SelectedTopValueLabel.Text = MultiTopListBox.SelectedItems.Count.ToString
    End Sub

    Private Sub DeleteTopicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteTopicButton.Click
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "DELETE FROM topics WHERE name=('" & childClickedName & "')"
        myConn.Open()
        myCmd.ExecuteNonQuery()
        MessageBox.Show("The selected topic will be deleted! In case of questions inside the category, they will become orphaned upon deletion. First, delete the corresponding questions.", "Warning")
        myConn.Close()
        Reload()
    End Sub

    Friend Sub Reload()
        Me.Controls.Clear()
        InitializeComponent()
        Dim e As New EventArgs()
        designer_Load(e, e)
    End Sub

    Private Sub SelectAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectAllButton.Click
        Dim i As Integer
        For i = 0 To MultiTopListBox.Items.Count - 1
            MultiTopListBox.SetSelected(i, True)
        Next
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        Dim listItem As String
        Dim i As Integer = 0

        categoriesSelected = " "
        SelectedTopValueLabel.Text = MultiTopListBox.SelectedItems.Count.ToString    '<= LABEL FOR SELECTED TOPICS COUNT
        Dim arraySelectedTOPS(MultiTopListBox.SelectedItems.Count)     '<= STORE EACH SELECTED TOPIC IN AN ARRAY
        'Dim LISTselectedTOPS As New List(Of String)()               '<= DOKIMI KAI ME LISTA

        If MultiTopListBox.SelectedItems.Count = 0 Then
            categoriesSelected = " "
            arraySelectedTOPS(0) = " "
            'LISTselectedTOPS.Clear()
        End If
        For Each selecteditem As Object In MultiTopListBox.SelectedItems
            If MultiTopListBox.SelectedItems.Count = 1 Then
                listItem = selecteditem.ToString
                categoriesSelected = listItem
                arraySelectedTOPS(i) = listItem
                'LISTselectedTOPS.Add(listItem)
            ElseIf MultiTopListBox.SelectedItems.Count > 1 Then
                listItem = selecteditem.ToString
                arraySelectedTOPS(i) = listItem
                categoriesSelected += listItem + " "
                'LISTselectedTOPS.Add(listItem)
            End If
            i += 1
        Next
        If categoriesSelected = " " Then
            MsgBox("You have not selected any topic", , "Information")
        Else
            MsgBox("You have selected the following topics:'" & categoriesSelected & "'", , "Information")

            For i = 0 To MultiTopListBox.SelectedItems.Count - 1
                'DEBUG: MsgBox(arraySelectedTOPS(i))
            Next
            myCmd = myConn.CreateCommand
            myCmd.CommandText = "DELETE FROM tmpq"
            myConn.Open()
            myCmd.ExecuteNonQuery()
            myReader.Close()
            myConn.Close()
            For i = 0 To MultiTopListBox.SelectedItems.Count - 1
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
            QuestsInTopsValueLabel.Text = results
            numOfQuestNumBox.Maximum = results
            myReader.Close()
            myConn.Close()
            GenerateButton.Enabled = True
        End If
    End Sub

    Private Sub SelectNoneButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectNoneButton.Click
        Dim i As Integer
        For i = 0 To MultiTopListBox.Items.Count - 1
            MultiTopListBox.SetSelected(i, False)
        Next
    End Sub

    Private Sub LevelTrackBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelTrackBar.Scroll
        Label16.Text = LevelTrackBar.Value + 1.ToString
    End Sub

    Private Sub QuestionListView_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles QuestionListView.SelectedIndexChanged

        If QuestionListView.SelectedIndices.Count = 0 Then
            EditQuestionButton.Enabled = False
            DeleteQuestionButton.Enabled = False
        Else
            EditQuestionButton.Enabled = True
            DeleteQuestionButton.Enabled = True
            EditQuestionToolStripMenuItem.Enabled = True
            DeleteQuestionToolStripMenuItem1.Enabled = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
        End
    End Sub

    Private Sub NewCategoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewCategoryToolStripMenuItem.Click
        insCategoryForm.Show()
    End Sub

    Private Sub NewTopicToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTopicToolStripMenuItem1.Click
        insTopicForm.Show()
    End Sub

    Private Sub NewQuestionToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewQuestionToolStripMenuItem1.Click
        insQuestionForm.Show()
    End Sub

    Private Sub AnyLvlCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnyLvlCheckBox.CheckedChanged
        If LevelTrackBar.Enabled = True Then
            LevelTrackBar.Enabled = False
        Else
            LevelTrackBar.Enabled = True
        End If
    End Sub
End Class
