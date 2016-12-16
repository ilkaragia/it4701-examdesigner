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
        Me.components = New System.ComponentModel.Container()
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Root Folder")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Child")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Parent", New System.Windows.Forms.TreeNode() {TreeNode5})
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTopicButton = New System.Windows.Forms.Button()
        Me.DeleteCategoryButton = New System.Windows.Forms.Button()
        Me.NewCategoryButton = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.DeleteTopicButton = New System.Windows.Forms.Button()
        Me.ReposManagGroupBox = New System.Windows.Forms.GroupBox()
        Me.TotalQuestValueLabel = New System.Windows.Forms.Label()
        Me.TotalQuestLabel = New System.Windows.Forms.Label()
        Me.EditTopicButton = New System.Windows.Forms.Button()
        Me.EditCategoryButton = New System.Windows.Forms.Button()
        Me.QuestionListView = New System.Windows.Forms.ListView()
        Me.qid = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Question = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Answer1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Answer2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Answer3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Answer4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Level = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteQuestionButton = New System.Windows.Forms.Button()
        Me.EditQuestionButton = New System.Windows.Forms.Button()
        Me.NewQuestionButton = New System.Windows.Forms.Button()
        Me.QuestionsViewLabel = New System.Windows.Forms.Label()
        Me.RepositoryViewLabel = New System.Windows.Forms.Label()
        Me.MultiTopListBox = New System.Windows.Forms.ListBox()
        Me.TextManagerGroupBox = New System.Windows.Forms.GroupBox()
        Me.QuestsInTopsValueLabel = New System.Windows.Forms.Label()
        Me.QuestsInTopsLabel = New System.Windows.Forms.Label()
        Me.SelectNoneButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.TopicsFilterLabel = New System.Windows.Forms.Label()
        Me.SelectedTopValueLabel = New System.Windows.Forms.Label()
        Me.SelectAllButton = New System.Windows.Forms.Button()
        Me.SelectedTopLabel = New System.Windows.Forms.Label()
        Me.CategoriesFilterLabel = New System.Windows.Forms.Label()
        Me.TotalCategValueLabel = New System.Windows.Forms.Label()
        Me.TotalCategLabel = New System.Windows.Forms.Label()
        Me.ComplexityGroupBox = New System.Windows.Forms.GroupBox()
        Me.AnyLvlCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.RandomizeCheckBox = New System.Windows.Forms.CheckBox()
        Me.LevelTrackBar = New System.Windows.Forms.TrackBar()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.numOfQuestNumBox = New System.Windows.Forms.NumericUpDown()
        Me.NumOfQuestLabel = New System.Windows.Forms.Label()
        Me.MultiCategListBox = New System.Windows.Forms.ListBox()
        Me.HintLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCategoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTopicToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTopicToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewQuestionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteQuestionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ReposManagGroupBox.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TextManagerGroupBox.SuspendLayout()
        Me.ComplexityGroupBox.SuspendLayout()
        CType(Me.LevelTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOfQuestNumBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
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
        'NewTopicButton
        '
        Me.NewTopicButton.Location = New System.Drawing.Point(122, 339)
        Me.NewTopicButton.Name = "NewTopicButton"
        Me.NewTopicButton.Size = New System.Drawing.Size(109, 29)
        Me.NewTopicButton.TabIndex = 3
        Me.NewTopicButton.Text = "New Topic"
        Me.NewTopicButton.UseVisualStyleBackColor = True
        '
        'DeleteCategoryButton
        '
        Me.DeleteCategoryButton.Enabled = False
        Me.DeleteCategoryButton.Location = New System.Drawing.Point(6, 406)
        Me.DeleteCategoryButton.Name = "DeleteCategoryButton"
        Me.DeleteCategoryButton.Size = New System.Drawing.Size(109, 28)
        Me.DeleteCategoryButton.TabIndex = 5
        Me.DeleteCategoryButton.Text = "Delete Category"
        Me.DeleteCategoryButton.UseVisualStyleBackColor = True
        '
        'NewCategoryButton
        '
        Me.NewCategoryButton.Location = New System.Drawing.Point(6, 338)
        Me.NewCategoryButton.Name = "NewCategoryButton"
        Me.NewCategoryButton.Size = New System.Drawing.Size(111, 29)
        Me.NewCategoryButton.TabIndex = 2
        Me.NewCategoryButton.Text = "New Category"
        Me.NewCategoryButton.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TreeView1.Location = New System.Drawing.Point(6, 45)
        Me.TreeView1.Name = "TreeView1"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "Root Folder"
        TreeNode5.Name = "Node5"
        TreeNode5.Text = "Child"
        TreeNode6.Name = "Node1"
        TreeNode6.Text = "Parent"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode6})
        Me.TreeView1.Size = New System.Drawing.Size(226, 288)
        Me.TreeView1.TabIndex = 1
        '
        'DeleteTopicButton
        '
        Me.DeleteTopicButton.Enabled = False
        Me.DeleteTopicButton.Location = New System.Drawing.Point(124, 406)
        Me.DeleteTopicButton.Name = "DeleteTopicButton"
        Me.DeleteTopicButton.Size = New System.Drawing.Size(108, 28)
        Me.DeleteTopicButton.TabIndex = 6
        Me.DeleteTopicButton.Text = "Delete Topic"
        Me.DeleteTopicButton.UseVisualStyleBackColor = True
        '
        'ReposManagGroupBox
        '
        Me.ReposManagGroupBox.Controls.Add(Me.TotalQuestValueLabel)
        Me.ReposManagGroupBox.Controls.Add(Me.TotalQuestLabel)
        Me.ReposManagGroupBox.Controls.Add(Me.EditTopicButton)
        Me.ReposManagGroupBox.Controls.Add(Me.EditCategoryButton)
        Me.ReposManagGroupBox.Controls.Add(Me.QuestionListView)
        Me.ReposManagGroupBox.Controls.Add(Me.DeleteQuestionButton)
        Me.ReposManagGroupBox.Controls.Add(Me.EditQuestionButton)
        Me.ReposManagGroupBox.Controls.Add(Me.TreeView1)
        Me.ReposManagGroupBox.Controls.Add(Me.NewQuestionButton)
        Me.ReposManagGroupBox.Controls.Add(Me.QuestionsViewLabel)
        Me.ReposManagGroupBox.Controls.Add(Me.RepositoryViewLabel)
        Me.ReposManagGroupBox.Controls.Add(Me.DeleteTopicButton)
        Me.ReposManagGroupBox.Controls.Add(Me.NewTopicButton)
        Me.ReposManagGroupBox.Controls.Add(Me.DeleteCategoryButton)
        Me.ReposManagGroupBox.Controls.Add(Me.NewCategoryButton)
        Me.ReposManagGroupBox.Location = New System.Drawing.Point(12, 27)
        Me.ReposManagGroupBox.Name = "ReposManagGroupBox"
        Me.ReposManagGroupBox.Size = New System.Drawing.Size(847, 451)
        Me.ReposManagGroupBox.TabIndex = 7
        Me.ReposManagGroupBox.TabStop = False
        Me.ReposManagGroupBox.Text = "Repository Manager"
        '
        'TotalQuestValueLabel
        '
        Me.TotalQuestValueLabel.AutoSize = True
        Me.TotalQuestValueLabel.Location = New System.Drawing.Point(806, 338)
        Me.TotalQuestValueLabel.Name = "TotalQuestValueLabel"
        Me.TotalQuestValueLabel.Size = New System.Drawing.Size(13, 13)
        Me.TotalQuestValueLabel.TabIndex = 16
        Me.TotalQuestValueLabel.Text = "0"
        '
        'TotalQuestLabel
        '
        Me.TotalQuestLabel.AutoSize = True
        Me.TotalQuestLabel.Location = New System.Drawing.Point(709, 339)
        Me.TotalQuestLabel.Name = "TotalQuestLabel"
        Me.TotalQuestLabel.Size = New System.Drawing.Size(82, 13)
        Me.TotalQuestLabel.TabIndex = 15
        Me.TotalQuestLabel.Text = "Total questions:"
        '
        'EditTopicButton
        '
        Me.EditTopicButton.Enabled = False
        Me.EditTopicButton.Location = New System.Drawing.Point(124, 373)
        Me.EditTopicButton.Name = "EditTopicButton"
        Me.EditTopicButton.Size = New System.Drawing.Size(106, 27)
        Me.EditTopicButton.TabIndex = 14
        Me.EditTopicButton.Text = "Edit Topic"
        Me.EditTopicButton.UseVisualStyleBackColor = True
        '
        'EditCategoryButton
        '
        Me.EditCategoryButton.Enabled = False
        Me.EditCategoryButton.Location = New System.Drawing.Point(7, 373)
        Me.EditCategoryButton.Name = "EditCategoryButton"
        Me.EditCategoryButton.Size = New System.Drawing.Size(109, 27)
        Me.EditCategoryButton.TabIndex = 13
        Me.EditCategoryButton.Text = "Edit Category"
        Me.EditCategoryButton.UseVisualStyleBackColor = True
        '
        'QuestionListView
        '
        Me.QuestionListView.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.QuestionListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.qid, Me.Question, Me.Answer1, Me.Answer2, Me.Answer3, Me.Answer4, Me.Level})
        Me.QuestionListView.ContextMenuStrip = Me.ContextMenuStrip2
        Me.QuestionListView.GridLines = True
        Me.QuestionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.QuestionListView.HideSelection = False
        Me.QuestionListView.Location = New System.Drawing.Point(258, 44)
        Me.QuestionListView.MultiSelect = False
        Me.QuestionListView.Name = "QuestionListView"
        Me.QuestionListView.Size = New System.Drawing.Size(561, 288)
        Me.QuestionListView.TabIndex = 4
        Me.QuestionListView.UseCompatibleStateImageBehavior = False
        Me.QuestionListView.View = System.Windows.Forms.View.Details
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
        'DeleteQuestionButton
        '
        Me.DeleteQuestionButton.Enabled = False
        Me.DeleteQuestionButton.Location = New System.Drawing.Point(493, 339)
        Me.DeleteQuestionButton.Name = "DeleteQuestionButton"
        Me.DeleteQuestionButton.Size = New System.Drawing.Size(104, 28)
        Me.DeleteQuestionButton.TabIndex = 12
        Me.DeleteQuestionButton.Text = "Delete Question"
        Me.DeleteQuestionButton.UseVisualStyleBackColor = True
        '
        'EditQuestionButton
        '
        Me.EditQuestionButton.Enabled = False
        Me.EditQuestionButton.Location = New System.Drawing.Point(381, 339)
        Me.EditQuestionButton.Name = "EditQuestionButton"
        Me.EditQuestionButton.Size = New System.Drawing.Size(106, 28)
        Me.EditQuestionButton.TabIndex = 11
        Me.EditQuestionButton.Text = "Edit Question"
        Me.EditQuestionButton.UseVisualStyleBackColor = True
        '
        'NewQuestionButton
        '
        Me.NewQuestionButton.Location = New System.Drawing.Point(258, 339)
        Me.NewQuestionButton.Name = "NewQuestionButton"
        Me.NewQuestionButton.Size = New System.Drawing.Size(117, 28)
        Me.NewQuestionButton.TabIndex = 10
        Me.NewQuestionButton.Text = "New Question"
        Me.NewQuestionButton.UseVisualStyleBackColor = True
        '
        'QuestionsViewLabel
        '
        Me.QuestionsViewLabel.AutoSize = True
        Me.QuestionsViewLabel.Location = New System.Drawing.Point(255, 28)
        Me.QuestionsViewLabel.Name = "QuestionsViewLabel"
        Me.QuestionsViewLabel.Size = New System.Drawing.Size(80, 13)
        Me.QuestionsViewLabel.TabIndex = 9
        Me.QuestionsViewLabel.Text = "Questions View"
        '
        'RepositoryViewLabel
        '
        Me.RepositoryViewLabel.AutoSize = True
        Me.RepositoryViewLabel.Location = New System.Drawing.Point(6, 28)
        Me.RepositoryViewLabel.Name = "RepositoryViewLabel"
        Me.RepositoryViewLabel.Size = New System.Drawing.Size(83, 13)
        Me.RepositoryViewLabel.TabIndex = 7
        Me.RepositoryViewLabel.Text = "Repository View"
        '
        'MultiTopListBox
        '
        Me.MultiTopListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MultiTopListBox.FormattingEnabled = True
        Me.MultiTopListBox.Location = New System.Drawing.Point(331, 87)
        Me.MultiTopListBox.Name = "MultiTopListBox"
        Me.MultiTopListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.MultiTopListBox.Size = New System.Drawing.Size(314, 212)
        Me.MultiTopListBox.TabIndex = 0
        '
        'TextManagerGroupBox
        '
        Me.TextManagerGroupBox.Controls.Add(Me.QuestsInTopsValueLabel)
        Me.TextManagerGroupBox.Controls.Add(Me.QuestsInTopsLabel)
        Me.TextManagerGroupBox.Controls.Add(Me.SelectNoneButton)
        Me.TextManagerGroupBox.Controls.Add(Me.SaveButton)
        Me.TextManagerGroupBox.Controls.Add(Me.TopicsFilterLabel)
        Me.TextManagerGroupBox.Controls.Add(Me.MultiTopListBox)
        Me.TextManagerGroupBox.Controls.Add(Me.SelectedTopValueLabel)
        Me.TextManagerGroupBox.Controls.Add(Me.SelectAllButton)
        Me.TextManagerGroupBox.Controls.Add(Me.SelectedTopLabel)
        Me.TextManagerGroupBox.Controls.Add(Me.CategoriesFilterLabel)
        Me.TextManagerGroupBox.Controls.Add(Me.TotalCategValueLabel)
        Me.TextManagerGroupBox.Controls.Add(Me.TotalCategLabel)
        Me.TextManagerGroupBox.Controls.Add(Me.ComplexityGroupBox)
        Me.TextManagerGroupBox.Controls.Add(Me.MultiCategListBox)
        Me.TextManagerGroupBox.Controls.Add(Me.HintLabel)
        Me.TextManagerGroupBox.Location = New System.Drawing.Point(875, 28)
        Me.TextManagerGroupBox.Name = "TextManagerGroupBox"
        Me.TextManagerGroupBox.Size = New System.Drawing.Size(660, 450)
        Me.TextManagerGroupBox.TabIndex = 8
        Me.TextManagerGroupBox.TabStop = False
        Me.TextManagerGroupBox.Text = "Test Manager"
        '
        'QuestsInTopsValueLabel
        '
        Me.QuestsInTopsValueLabel.AutoSize = True
        Me.QuestsInTopsValueLabel.Location = New System.Drawing.Point(632, 322)
        Me.QuestsInTopsValueLabel.Name = "QuestsInTopsValueLabel"
        Me.QuestsInTopsValueLabel.Size = New System.Drawing.Size(13, 13)
        Me.QuestsInTopsValueLabel.TabIndex = 10
        Me.QuestsInTopsValueLabel.Text = "0"
        '
        'QuestsInTopsLabel
        '
        Me.QuestsInTopsLabel.AutoSize = True
        Me.QuestsInTopsLabel.Location = New System.Drawing.Point(502, 322)
        Me.QuestsInTopsLabel.Name = "QuestsInTopsLabel"
        Me.QuestsInTopsLabel.Size = New System.Drawing.Size(109, 13)
        Me.QuestsInTopsLabel.TabIndex = 9
        Me.QuestsInTopsLabel.Text = "Questions in Topic(s):"
        '
        'SelectNoneButton
        '
        Me.SelectNoneButton.Enabled = False
        Me.SelectNoneButton.Location = New System.Drawing.Point(382, 302)
        Me.SelectNoneButton.Name = "SelectNoneButton"
        Me.SelectNoneButton.Size = New System.Drawing.Size(45, 24)
        Me.SelectNoneButton.TabIndex = 8
        Me.SelectNoneButton.Text = "&None"
        Me.SelectNoneButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Enabled = False
        Me.SaveButton.Location = New System.Drawing.Point(433, 301)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(45, 24)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'TopicsFilterLabel
        '
        Me.TopicsFilterLabel.AutoSize = True
        Me.TopicsFilterLabel.Location = New System.Drawing.Point(328, 68)
        Me.TopicsFilterLabel.Name = "TopicsFilterLabel"
        Me.TopicsFilterLabel.Size = New System.Drawing.Size(64, 13)
        Me.TopicsFilterLabel.TabIndex = 6
        Me.TopicsFilterLabel.Text = "Topics Filter"
        '
        'SelectedTopValueLabel
        '
        Me.SelectedTopValueLabel.AutoSize = True
        Me.SelectedTopValueLabel.Location = New System.Drawing.Point(632, 302)
        Me.SelectedTopValueLabel.Name = "SelectedTopValueLabel"
        Me.SelectedTopValueLabel.Size = New System.Drawing.Size(13, 13)
        Me.SelectedTopValueLabel.TabIndex = 2
        Me.SelectedTopValueLabel.Text = "0"
        '
        'SelectAllButton
        '
        Me.SelectAllButton.Enabled = False
        Me.SelectAllButton.Location = New System.Drawing.Point(331, 302)
        Me.SelectAllButton.Name = "SelectAllButton"
        Me.SelectAllButton.Size = New System.Drawing.Size(45, 24)
        Me.SelectAllButton.TabIndex = 3
        Me.SelectAllButton.Text = "&All"
        Me.SelectAllButton.UseVisualStyleBackColor = True
        '
        'SelectedTopLabel
        '
        Me.SelectedTopLabel.AutoSize = True
        Me.SelectedTopLabel.Location = New System.Drawing.Point(524, 302)
        Me.SelectedTopLabel.Name = "SelectedTopLabel"
        Me.SelectedTopLabel.Size = New System.Drawing.Size(87, 13)
        Me.SelectedTopLabel.TabIndex = 1
        Me.SelectedTopLabel.Text = "Selected Topics:"
        '
        'CategoriesFilterLabel
        '
        Me.CategoriesFilterLabel.AutoSize = True
        Me.CategoriesFilterLabel.Location = New System.Drawing.Point(6, 68)
        Me.CategoriesFilterLabel.Name = "CategoriesFilterLabel"
        Me.CategoriesFilterLabel.Size = New System.Drawing.Size(82, 13)
        Me.CategoriesFilterLabel.TabIndex = 5
        Me.CategoriesFilterLabel.Text = "Categories Filter"
        '
        'TotalCategValueLabel
        '
        Me.TotalCategValueLabel.AutoSize = True
        Me.TotalCategValueLabel.Location = New System.Drawing.Point(303, 301)
        Me.TotalCategValueLabel.Name = "TotalCategValueLabel"
        Me.TotalCategValueLabel.Size = New System.Drawing.Size(13, 13)
        Me.TotalCategValueLabel.TabIndex = 2
        Me.TotalCategValueLabel.Text = "0"
        '
        'TotalCategLabel
        '
        Me.TotalCategLabel.AutoSize = True
        Me.TotalCategLabel.Location = New System.Drawing.Point(193, 301)
        Me.TotalCategLabel.Name = "TotalCategLabel"
        Me.TotalCategLabel.Size = New System.Drawing.Size(87, 13)
        Me.TotalCategLabel.TabIndex = 1
        Me.TotalCategLabel.Text = "Total Categories:"
        '
        'ComplexityGroupBox
        '
        Me.ComplexityGroupBox.Controls.Add(Me.AnyLvlCheckBox)
        Me.ComplexityGroupBox.Controls.Add(Me.Label16)
        Me.ComplexityGroupBox.Controls.Add(Me.GenerateButton)
        Me.ComplexityGroupBox.Controls.Add(Me.RandomizeCheckBox)
        Me.ComplexityGroupBox.Controls.Add(Me.LevelTrackBar)
        Me.ComplexityGroupBox.Controls.Add(Me.LevelLabel)
        Me.ComplexityGroupBox.Controls.Add(Me.numOfQuestNumBox)
        Me.ComplexityGroupBox.Controls.Add(Me.NumOfQuestLabel)
        Me.ComplexityGroupBox.Location = New System.Drawing.Point(9, 349)
        Me.ComplexityGroupBox.Name = "ComplexityGroupBox"
        Me.ComplexityGroupBox.Size = New System.Drawing.Size(636, 72)
        Me.ComplexityGroupBox.TabIndex = 3
        Me.ComplexityGroupBox.TabStop = False
        Me.ComplexityGroupBox.Text = "Complexity"
        '
        'AnyLvlCheckBox
        '
        Me.AnyLvlCheckBox.AutoSize = True
        Me.AnyLvlCheckBox.Location = New System.Drawing.Point(373, 28)
        Me.AnyLvlCheckBox.Name = "AnyLvlCheckBox"
        Me.AnyLvlCheckBox.Size = New System.Drawing.Size(73, 17)
        Me.AnyLvlCheckBox.TabIndex = 10
        Me.AnyLvlCheckBox.Text = "An&y Level"
        Me.ToolTip1.SetToolTip(Me.AnyLvlCheckBox, "Selects all levels.")
        Me.AnyLvlCheckBox.UseVisualStyleBackColor = True
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
        'GenerateButton
        '
        Me.GenerateButton.Enabled = False
        Me.GenerateButton.Location = New System.Drawing.Point(545, 23)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(76, 26)
        Me.GenerateButton.TabIndex = 6
        Me.GenerateButton.Text = "&Generate"
        Me.ToolTip1.SetToolTip(Me.GenerateButton, "Creates the test and loads it in the Viewer window.")
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'RandomizeCheckBox
        '
        Me.RandomizeCheckBox.AutoSize = True
        Me.RandomizeCheckBox.Location = New System.Drawing.Point(460, 29)
        Me.RandomizeCheckBox.Name = "RandomizeCheckBox"
        Me.RandomizeCheckBox.Size = New System.Drawing.Size(79, 17)
        Me.RandomizeCheckBox.TabIndex = 5
        Me.RandomizeCheckBox.Text = "&Randomize"
        Me.ToolTip1.SetToolTip(Me.RandomizeCheckBox, "Adds an additional level of difficulty by randomizing the order of the questions." & _
        "")
        Me.RandomizeCheckBox.UseVisualStyleBackColor = True
        '
        'LevelTrackBar
        '
        Me.LevelTrackBar.Location = New System.Drawing.Point(226, 25)
        Me.LevelTrackBar.Maximum = 3
        Me.LevelTrackBar.Name = "LevelTrackBar"
        Me.LevelTrackBar.Size = New System.Drawing.Size(138, 45)
        Me.LevelTrackBar.TabIndex = 3
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(184, 29)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(36, 13)
        Me.LevelLabel.TabIndex = 2
        Me.LevelLabel.Text = "&Level:"
        Me.ToolTip1.SetToolTip(Me.LevelLabel, "Sets the difficulty level:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 1=Easy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 2=Intermeditate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 3 =Advance" & _
        "d" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Level 4=Expert")
        '
        'numOfQuestNumBox
        '
        Me.numOfQuestNumBox.Location = New System.Drawing.Point(119, 25)
        Me.numOfQuestNumBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numOfQuestNumBox.Name = "numOfQuestNumBox"
        Me.numOfQuestNumBox.Size = New System.Drawing.Size(49, 20)
        Me.numOfQuestNumBox.TabIndex = 1
        Me.numOfQuestNumBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumOfQuestLabel
        '
        Me.NumOfQuestLabel.AutoSize = True
        Me.NumOfQuestLabel.Location = New System.Drawing.Point(6, 30)
        Me.NumOfQuestLabel.Name = "NumOfQuestLabel"
        Me.NumOfQuestLabel.Size = New System.Drawing.Size(107, 13)
        Me.NumOfQuestLabel.TabIndex = 0
        Me.NumOfQuestLabel.Text = "&Number of questions:"
        Me.ToolTip1.SetToolTip(Me.NumOfQuestLabel, "Sets the number of questions to be loaded into the test.")
        '
        'MultiCategListBox
        '
        Me.MultiCategListBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MultiCategListBox.FormattingEnabled = True
        Me.MultiCategListBox.Location = New System.Drawing.Point(9, 84)
        Me.MultiCategListBox.Name = "MultiCategListBox"
        Me.MultiCategListBox.Size = New System.Drawing.Size(307, 212)
        Me.MultiCategListBox.TabIndex = 0
        '
        'HintLabel
        '
        Me.HintLabel.BackColor = System.Drawing.SystemColors.Info
        Me.HintLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HintLabel.Location = New System.Drawing.Point(9, 27)
        Me.HintLabel.Name = "HintLabel"
        Me.HintLabel.Size = New System.Drawing.Size(636, 31)
        Me.HintLabel.TabIndex = 1
        Me.HintLabel.Text = "Hint: To create a new test, [1] select a category, [2] one or more topics and [3]" & _
    " complexity parameters. Press the Generate button to view and print the test. Ho" & _
    "ver on each option for more info."
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.TopicToolStripMenuItem, Me.QuestionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1547, 24)
        Me.MenuStrip.TabIndex = 18
        Me.MenuStrip.Text = "MenuStrip1"
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
        'designer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 493)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.ReposManagGroupBox)
        Me.Controls.Add(Me.TextManagerGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "designer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExamDesigner"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ReposManagGroupBox.ResumeLayout(False)
        Me.ReposManagGroupBox.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TextManagerGroupBox.ResumeLayout(False)
        Me.TextManagerGroupBox.PerformLayout()
        Me.ComplexityGroupBox.ResumeLayout(False)
        Me.ComplexityGroupBox.PerformLayout()
        CType(Me.LevelTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOfQuestNumBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTopicButton As System.Windows.Forms.Button
    Friend WithEvents DeleteCategoryButton As System.Windows.Forms.Button
    Friend WithEvents NewCategoryButton As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents DeleteTopicButton As System.Windows.Forms.Button
    Friend WithEvents ReposManagGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents QuestionsViewLabel As System.Windows.Forms.Label
    Friend WithEvents RepositoryViewLabel As System.Windows.Forms.Label
    Friend WithEvents DeleteQuestionButton As System.Windows.Forms.Button
    Friend WithEvents EditQuestionButton As System.Windows.Forms.Button
    Friend WithEvents NewQuestionButton As System.Windows.Forms.Button
    Friend WithEvents TextManagerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HintLabel As System.Windows.Forms.Label
    Friend WithEvents QuestionListView As System.Windows.Forms.ListView
    Friend WithEvents Question As System.Windows.Forms.ColumnHeader
    Friend WithEvents Answer1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ComplexityGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NumOfQuestLabel As System.Windows.Forms.Label
    Friend WithEvents Answer2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Answer3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Answer4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LevelLabel As System.Windows.Forms.Label
    Friend WithEvents numOfQuestNumBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents RandomizeCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents LevelTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents GenerateButton As System.Windows.Forms.Button
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EditTopicButton As System.Windows.Forms.Button
    Friend WithEvents EditCategoryButton As System.Windows.Forms.Button
    Friend WithEvents MultiCategListBox As System.Windows.Forms.ListBox
    Friend WithEvents MultiTopListBox As System.Windows.Forms.ListBox
    Friend WithEvents TotalQuestValueLabel As System.Windows.Forms.Label
    Friend WithEvents TotalQuestLabel As System.Windows.Forms.Label
    Friend WithEvents Level As System.Windows.Forms.ColumnHeader
    Friend WithEvents SelectedTopValueLabel As System.Windows.Forms.Label
    Friend WithEvents SelectedTopLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCategValueLabel As System.Windows.Forms.Label
    Friend WithEvents TotalCategLabel As System.Windows.Forms.Label
    Friend WithEvents SelectAllButton As System.Windows.Forms.Button
    Friend WithEvents CategoriesFilterLabel As System.Windows.Forms.Label
    Friend WithEvents TopicsFilterLabel As System.Windows.Forms.Label
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents SelectNoneButton As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents qid As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
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
    Friend WithEvents QuestsInTopsValueLabel As System.Windows.Forms.Label
    Friend WithEvents QuestsInTopsLabel As System.Windows.Forms.Label
    Friend WithEvents AnyLvlCheckBox As System.Windows.Forms.CheckBox




End Class
