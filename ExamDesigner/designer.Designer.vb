<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class designer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Root Folder")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Child")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Parent", New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewTopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteTopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.questionListView = New System.Windows.Forms.ListView
        Me.qid = New System.Windows.Forms.ColumnHeader
        Me.Question = New System.Windows.Forms.ColumnHeader
        Me.Answer1 = New System.Windows.Forms.ColumnHeader
        Me.Answer2 = New System.Windows.Forms.ColumnHeader
        Me.Answer3 = New System.Windows.Forms.ColumnHeader
        Me.Answer4 = New System.Windows.Forms.ColumnHeader
        Me.Level = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.childclicked = New System.Windows.Forms.Label
        Me.multiTopList = New System.Windows.Forms.ListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.sNONEbtn = New System.Windows.Forms.Button
        Me.SAVEbtn = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.sALLbtn = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.anyCHK = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.GENbtn = New System.Windows.Forms.Button
        Me.RANDOMIZEchkbox = New System.Windows.Forms.CheckBox
        Me.LEVELtrackbar = New System.Windows.Forms.TrackBar
        Me.Label5 = New System.Windows.Forms.Label
        Me.numQbox = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.multiCatList = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ReloadBtn = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteCategoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewTopicToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditTopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteTopicToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.QuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewQuestionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.EditQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteQuestionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.LEVELtrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.NewTopicToolStripMenuItem, Me.DeleteCategoryToolStripMenuItem, Me.DeleteTopicToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(159, 92)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EditToolStripMenuItem.Text = "New Category"
        '
        'NewTopicToolStripMenuItem
        '
        Me.NewTopicToolStripMenuItem.Name = "NewTopicToolStripMenuItem"
        Me.NewTopicToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NewTopicToolStripMenuItem.Text = "New Topic"
        '
        'DeleteCategoryToolStripMenuItem
        '
        Me.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem"
        Me.DeleteCategoryToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DeleteCategoryToolStripMenuItem.Text = "Delete Category"
        '
        'DeleteTopicToolStripMenuItem
        '
        Me.DeleteTopicToolStripMenuItem.Name = "DeleteTopicToolStripMenuItem"
        Me.DeleteTopicToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DeleteTopicToolStripMenuItem.Text = "Delete Topic"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(122, 339)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(109, 29)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "New Topic"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(6, 406)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 28)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Delete Category"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 338)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "New Category"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Location = New System.Drawing.Point(6, 45)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Root Folder"
        TreeNode2.Name = "Node5"
        TreeNode2.Text = "Child"
        TreeNode3.Name = "Node1"
        TreeNode3.Text = "Parent"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode3})
        Me.TreeView1.Size = New System.Drawing.Size(226, 288)
        Me.TreeView1.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(124, 406)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 28)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Delete Topic"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Button10)
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.questionListView)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.TreeView1)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 451)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Repository Manager"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(806, 338)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(709, 339)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total questions:"
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.Location = New System.Drawing.Point(124, 373)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(106, 27)
        Me.Button10.TabIndex = 14
        Me.Button10.Text = "Edit Topic"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Location = New System.Drawing.Point(7, 373)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(109, 27)
        Me.Button9.TabIndex = 13
        Me.Button9.Text = "Edit Category"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'questionListView
        '
        Me.questionListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.questionListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.qid, Me.Question, Me.Answer1, Me.Answer2, Me.Answer3, Me.Answer4, Me.Level})
        Me.questionListView.ContextMenuStrip = Me.ContextMenuStrip2
        Me.questionListView.GridLines = True
        Me.questionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.questionListView.HideSelection = False
        Me.questionListView.Location = New System.Drawing.Point(258, 44)
        Me.questionListView.MultiSelect = False
        Me.questionListView.Name = "questionListView"
        Me.questionListView.Size = New System.Drawing.Size(561, 288)
        Me.questionListView.TabIndex = 4
        Me.questionListView.UseCompatibleStateImageBehavior = False
        Me.questionListView.View = System.Windows.Forms.View.Details
        '
        'qid
        '
        Me.qid.Text = "ID"
        Me.qid.Width = 32
        '
        'Question
        '
        Me.Question.Text = "Question"
        Me.Question.Width = 240
        '
        'Answer1
        '
        Me.Answer1.Text = "Answer1"
        '
        'Answer2
        '
        Me.Answer2.Text = "Answer2"
        '
        'Answer3
        '
        Me.Answer3.Text = "Answer3"
        '
        'Answer4
        '
        Me.Answer4.Text = "Answer4"
        '
        'Level
        '
        Me.Level.Text = "Level"
        Me.Level.Width = 48
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewQuestionToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeleteQuestionToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(159, 70)
        '
        'NewQuestionToolStripMenuItem
        '
        Me.NewQuestionToolStripMenuItem.Name = "NewQuestionToolStripMenuItem"
        Me.NewQuestionToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NewQuestionToolStripMenuItem.Text = "New Question"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripMenuItem1.Text = "Edit Question"
        '
        'DeleteQuestionToolStripMenuItem
        '
        Me.DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem"
        Me.DeleteQuestionToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DeleteQuestionToolStripMenuItem.Text = "Delete Question"
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(493, 339)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 28)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Delete Question"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(381, 339)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(106, 28)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Edit Question"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(258, 339)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(117, 28)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "New Question"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(255, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Questions View"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Repository View"
        '
        'childclicked
        '
        Me.childclicked.AutoSize = True
        Me.childclicked.BackColor = System.Drawing.SystemColors.Info
        Me.childclicked.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.childclicked.Location = New System.Drawing.Point(1168, 523)
        Me.childclicked.Name = "childclicked"
        Me.childclicked.Size = New System.Drawing.Size(21, 15)
        Me.childclicked.TabIndex = 9
        Me.childclicked.Text = "    "
        '
        'multiTopList
        '
        Me.multiTopList.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.multiTopList.FormattingEnabled = True
        Me.multiTopList.Location = New System.Drawing.Point(331, 87)
        Me.multiTopList.Name = "multiTopList"
        Me.multiTopList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.multiTopList.Size = New System.Drawing.Size(314, 212)
        Me.multiTopList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.sNONEbtn)
        Me.GroupBox2.Controls.Add(Me.SAVEbtn)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.multiTopList)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.sALLbtn)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.multiCatList)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(875, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 450)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Test Manager"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(632, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(502, 322)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Questions in Topic(s):"
        '
        'sNONEbtn
        '
        Me.sNONEbtn.Enabled = False
        Me.sNONEbtn.Location = New System.Drawing.Point(382, 302)
        Me.sNONEbtn.Name = "sNONEbtn"
        Me.sNONEbtn.Size = New System.Drawing.Size(45, 24)
        Me.sNONEbtn.TabIndex = 8
        Me.sNONEbtn.Text = "&None"
        Me.sNONEbtn.UseVisualStyleBackColor = True
        '
        'SAVEbtn
        '
        Me.SAVEbtn.Enabled = False
        Me.SAVEbtn.Location = New System.Drawing.Point(433, 301)
        Me.SAVEbtn.Name = "SAVEbtn"
        Me.SAVEbtn.Size = New System.Drawing.Size(45, 24)
        Me.SAVEbtn.TabIndex = 7
        Me.SAVEbtn.Text = "&Save"
        Me.SAVEbtn.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(328, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Topics Filter"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(632, 302)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "0"
        '
        'sALLbtn
        '
        Me.sALLbtn.Enabled = False
        Me.sALLbtn.Location = New System.Drawing.Point(331, 302)
        Me.sALLbtn.Name = "sALLbtn"
        Me.sALLbtn.Size = New System.Drawing.Size(45, 24)
        Me.sALLbtn.TabIndex = 3
        Me.sALLbtn.Text = "&All"
        Me.sALLbtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(524, 302)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Selected Topics:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Categories Filter"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(303, 301)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(193, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Total Categories:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.anyCHK)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.GENbtn)
        Me.GroupBox5.Controls.Add(Me.RANDOMIZEchkbox)
        Me.GroupBox5.Controls.Add(Me.LEVELtrackbar)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.numQbox)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(9, 349)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(636, 72)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Complexity"
        '
        'anyCHK
        '
        Me.anyCHK.AutoSize = True
        Me.anyCHK.Location = New System.Drawing.Point(373, 28)
        Me.anyCHK.Name = "anyCHK"
        Me.anyCHK.Size = New System.Drawing.Size(73, 17)
        Me.anyCHK.TabIndex = 10
        Me.anyCHK.Text = "An&y Level"
        Me.ToolTip1.SetToolTip(Me.anyCHK, "Selects all levels.")
        Me.anyCHK.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(294, 57)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "1"
        '
        'GENbtn
        '
        Me.GENbtn.Enabled = False
        Me.GENbtn.Location = New System.Drawing.Point(545, 23)
        Me.GENbtn.Name = "GENbtn"
        Me.GENbtn.Size = New System.Drawing.Size(76, 26)
        Me.GENbtn.TabIndex = 6
        Me.GENbtn.Text = "&Generate"
        Me.ToolTip1.SetToolTip(Me.GENbtn, "Creates the test and loads it in the Viewer window.")
        Me.GENbtn.UseVisualStyleBackColor = True
        '
        'RANDOMIZEchkbox
        '
        Me.RANDOMIZEchkbox.AutoSize = True
        Me.RANDOMIZEchkbox.Location = New System.Drawing.Point(460, 29)
        Me.RANDOMIZEchkbox.Name = "RANDOMIZEchkbox"
        Me.RANDOMIZEchkbox.Size = New System.Drawing.Size(79, 17)
        Me.RANDOMIZEchkbox.TabIndex = 5
        Me.RANDOMIZEchkbox.Text = "&Randomize"
        Me.ToolTip1.SetToolTip(Me.RANDOMIZEchkbox, "Adds an additional level of difficulty by randomizing the order of the questions." & _
                "")
        Me.RANDOMIZEchkbox.UseVisualStyleBackColor = True
        '
        'LEVELtrackbar
        '
        Me.LEVELtrackbar.Location = New System.Drawing.Point(226, 25)
        Me.LEVELtrackbar.Maximum = 3
        Me.LEVELtrackbar.Name = "LEVELtrackbar"
        Me.LEVELtrackbar.Size = New System.Drawing.Size(138, 45)
        Me.LEVELtrackbar.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "&Level:"
        Me.ToolTip1.SetToolTip(Me.Label5, "Sets the difficulty level:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 1=Easy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 2=Intermeditate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 3 =Advance" & _
                "d" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 4=Expert")
        '
        'numQbox
        '
        Me.numQbox.Location = New System.Drawing.Point(119, 25)
        Me.numQbox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numQbox.Name = "numQbox"
        Me.numQbox.Size = New System.Drawing.Size(49, 20)
        Me.numQbox.TabIndex = 1
        Me.numQbox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "&Number of questions:"
        Me.ToolTip1.SetToolTip(Me.Label4, "Sets the number of questions to be loaded into the test.")
        '
        'multiCatList
        '
        Me.multiCatList.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.multiCatList.FormattingEnabled = True
        Me.multiCatList.Location = New System.Drawing.Point(9, 84)
        Me.multiCatList.Name = "multiCatList"
        Me.multiCatList.Size = New System.Drawing.Size(307, 212)
        Me.multiCatList.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(9, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(636, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Hint: To create a new test, [1] select a category, [2] one or more topics and [3]" & _
            " complexity parameters. Press the Generate button to view and print the test. Ho" & _
            "ver on each option for more info."
        '
        'ReloadBtn
        '
        Me.ReloadBtn.Location = New System.Drawing.Point(875, 518)
        Me.ReloadBtn.Name = "ReloadBtn"
        Me.ReloadBtn.Size = New System.Drawing.Size(27, 22)
        Me.ReloadBtn.TabIndex = 17
        Me.ReloadBtn.Text = "R"
        Me.ReloadBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.TopicToolStripMenuItem, Me.QuestionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1547, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaintenanceToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.MaintenanceToolStripMenuItem.Text = "Maintenance"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCategoryToolStripMenuItem, Me.EditCategoryToolStripMenuItem, Me.DeleteCategoryToolStripMenuItem1})
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'NewCategoryToolStripMenuItem
        '
        Me.NewCategoryToolStripMenuItem.Name = "NewCategoryToolStripMenuItem"
        Me.NewCategoryToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NewCategoryToolStripMenuItem.Text = "New Category"
        '
        'EditCategoryToolStripMenuItem
        '
        Me.EditCategoryToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.EditCategoryToolStripMenuItem.Enabled = False
        Me.EditCategoryToolStripMenuItem.Name = "EditCategoryToolStripMenuItem"
        Me.EditCategoryToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EditCategoryToolStripMenuItem.Text = "Edit Category"
        '
        'DeleteCategoryToolStripMenuItem1
        '
        Me.DeleteCategoryToolStripMenuItem1.Enabled = False
        Me.DeleteCategoryToolStripMenuItem1.Name = "DeleteCategoryToolStripMenuItem1"
        Me.DeleteCategoryToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.DeleteCategoryToolStripMenuItem1.Text = "Delete Category"
        '
        'TopicToolStripMenuItem
        '
        Me.TopicToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTopicToolStripMenuItem1, Me.EditTopicToolStripMenuItem, Me.DeleteTopicToolStripMenuItem1})
        Me.TopicToolStripMenuItem.Name = "TopicToolStripMenuItem"
        Me.TopicToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.TopicToolStripMenuItem.Text = "Topic"
        '
        'NewTopicToolStripMenuItem1
        '
        Me.NewTopicToolStripMenuItem1.Name = "NewTopicToolStripMenuItem1"
        Me.NewTopicToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.NewTopicToolStripMenuItem1.Text = "New Topic"
        '
        'EditTopicToolStripMenuItem
        '
        Me.EditTopicToolStripMenuItem.Enabled = False
        Me.EditTopicToolStripMenuItem.Name = "EditTopicToolStripMenuItem"
        Me.EditTopicToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.EditTopicToolStripMenuItem.Text = "Edit Topic"
        '
        'DeleteTopicToolStripMenuItem1
        '
        Me.DeleteTopicToolStripMenuItem1.Enabled = False
        Me.DeleteTopicToolStripMenuItem1.Name = "DeleteTopicToolStripMenuItem1"
        Me.DeleteTopicToolStripMenuItem1.Size = New System.Drawing.Size(137, 22)
        Me.DeleteTopicToolStripMenuItem1.Text = "DeleteTopic"
        '
        'QuestionToolStripMenuItem
        '
        Me.QuestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewQuestionToolStripMenuItem1, Me.EditQuestionToolStripMenuItem, Me.DeleteQuestionToolStripMenuItem1})
        Me.QuestionToolStripMenuItem.Name = "QuestionToolStripMenuItem"
        Me.QuestionToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.QuestionToolStripMenuItem.Text = "Question"
        '
        'NewQuestionToolStripMenuItem1
        '
        Me.NewQuestionToolStripMenuItem1.Name = "NewQuestionToolStripMenuItem1"
        Me.NewQuestionToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.NewQuestionToolStripMenuItem1.Text = "New Question"
        '
        'EditQuestionToolStripMenuItem
        '
        Me.EditQuestionToolStripMenuItem.Enabled = False
        Me.EditQuestionToolStripMenuItem.Name = "EditQuestionToolStripMenuItem"
        Me.EditQuestionToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EditQuestionToolStripMenuItem.Text = "Edit Question"
        '
        'DeleteQuestionToolStripMenuItem1
        '
        Me.DeleteQuestionToolStripMenuItem1.Enabled = False
        Me.DeleteQuestionToolStripMenuItem1.Name = "DeleteQuestionToolStripMenuItem1"
        Me.DeleteQuestionToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.DeleteQuestionToolStripMenuItem1.Text = "Delete Question"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(908, 520)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(254, 20)
        Me.TextBox1.TabIndex = 9
        '
        'designer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 493)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ReloadBtn)
        Me.Controls.Add(Me.childclicked)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "designer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExamDesigner"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.LEVELtrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents questionListView As System.Windows.Forms.ListView
    Friend WithEvents Question As System.Windows.Forms.ColumnHeader
    Friend WithEvents Answer1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Answer2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Answer3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Answer4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numQbox As System.Windows.Forms.NumericUpDown
    Friend WithEvents RANDOMIZEchkbox As System.Windows.Forms.CheckBox
    Friend WithEvents LEVELtrackbar As System.Windows.Forms.TrackBar
    Friend WithEvents GENbtn As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents childclicked As System.Windows.Forms.Label
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents multiCatList As System.Windows.Forms.ListBox
    Friend WithEvents multiTopList As System.Windows.Forms.ListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Level As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ReloadBtn As System.Windows.Forms.Button
    Friend WithEvents sALLbtn As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents SAVEbtn As System.Windows.Forms.Button
    Friend WithEvents sNONEbtn As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents qid As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteCategoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTopicToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditTopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTopicToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewQuestionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteQuestionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents anyCHK As System.Windows.Forms.CheckBox




End Class
