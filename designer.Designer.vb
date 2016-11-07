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
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteTopicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.editTopicButton = New System.Windows.Forms.Button()
        Me.editCategoryButton = New System.Windows.Forms.Button()
        Me.questionListView = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.multiTopList = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GENbtn = New System.Windows.Forms.Button()
        Me.RANDOMIZEchkbox = New System.Windows.Forms.CheckBox()
        Me.LEVELtrackbar = New System.Windows.Forms.TrackBar()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numQbox = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.multiCatList = New System.Windows.Forms.ListBox()
        Me.AsasasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GfgfgfgfgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.DeleteQuestionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.NewTopicToolStripMenuItem, Me.DeleteCategoryToolStripMenuItem, Me.DeleteTopicToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(159, 92)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripMenuItem1.Text = "New Caegory"
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
        Me.Button3.Location = New System.Drawing.Point(9, 408)
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
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(124, 408)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 28)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Delete Topic"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.editTopicButton)
        Me.GroupBox1.Controls.Add(Me.editCategoryButton)
        Me.GroupBox1.Controls.Add(Me.questionListView)
        Me.GroupBox1.Controls.Add(Me.Button7)
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
        Me.GroupBox1.Size = New System.Drawing.Size(847, 449)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Repository Manager"
        '
        'editTopicButton
        '
        Me.editTopicButton.Location = New System.Drawing.Point(124, 374)
        Me.editTopicButton.Name = "editTopicButton"
        Me.editTopicButton.Size = New System.Drawing.Size(108, 28)
        Me.editTopicButton.TabIndex = 14
        Me.editTopicButton.Text = "Edit Topic"
        Me.editTopicButton.UseVisualStyleBackColor = True
        '
        'editCategoryButton
        '
        Me.editCategoryButton.Location = New System.Drawing.Point(9, 374)
        Me.editCategoryButton.Name = "editCategoryButton"
        Me.editCategoryButton.Size = New System.Drawing.Size(108, 28)
        Me.editCategoryButton.TabIndex = 13
        Me.editCategoryButton.Text = "Edit Category"
        Me.editCategoryButton.UseVisualStyleBackColor = True
        '
        'questionListView
        '
        Me.questionListView.Activation = System.Windows.Forms.ItemActivation.OneClick
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
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewQuestionToolStripMenuItem, Me.DeleteQuestionToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(159, 48)
        '
        'NewQuestionToolStripMenuItem
        '
        Me.NewQuestionToolStripMenuItem.Name = "NewQuestionToolStripMenuItem"
        Me.NewQuestionToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.NewQuestionToolStripMenuItem.Text = "New Question"
        '
        'DeleteQuestionToolStripMenuItem
        '
        Me.DeleteQuestionToolStripMenuItem.Name = "DeleteQuestionToolStripMenuItem"
        Me.DeleteQuestionToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.DeleteQuestionToolStripMenuItem.Text = "Delete Question"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(381, 338)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(104, 28)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "Delete Question"
        Me.Button7.UseVisualStyleBackColor = True
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
        'multiTopList
        '
        Me.multiTopList.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.multiTopList.FormattingEnabled = True
        Me.multiTopList.Location = New System.Drawing.Point(340, 42)
        Me.multiTopList.Name = "multiTopList"
        Me.multiTopList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.multiTopList.Size = New System.Drawing.Size(314, 212)
        Me.multiTopList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.multiTopList)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.multiCatList)
        Me.GroupBox2.Location = New System.Drawing.Point(875, 28)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(660, 349)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Test Manager"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(337, 23)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Topics Filter"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(15, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 13)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "Categories Filter"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GENbtn)
        Me.GroupBox5.Controls.Add(Me.RANDOMIZEchkbox)
        Me.GroupBox5.Controls.Add(Me.LEVELtrackbar)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.numQbox)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Location = New System.Drawing.Point(18, 260)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(636, 72)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Complexity"
        '
        'GENbtn
        '
        Me.GENbtn.Enabled = False
        Me.GENbtn.Location = New System.Drawing.Point(545, 23)
        Me.GENbtn.Name = "GENbtn"
        Me.GENbtn.Size = New System.Drawing.Size(76, 26)
        Me.GENbtn.TabIndex = 6
        Me.GENbtn.Text = "&Generate"
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
        Me.RANDOMIZEchkbox.UseVisualStyleBackColor = True
        '
        'LEVELtrackbar
        '
        Me.LEVELtrackbar.Location = New System.Drawing.Point(226, 25)
        Me.LEVELtrackbar.Maximum = 3
        Me.LEVELtrackbar.Name = "LEVELtrackbar"
        Me.LEVELtrackbar.Size = New System.Drawing.Size(213, 45)
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
        '
        'multiCatList
        '
        Me.multiCatList.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.multiCatList.FormattingEnabled = True
        Me.multiCatList.Location = New System.Drawing.Point(18, 39)
        Me.multiCatList.Name = "multiCatList"
        Me.multiCatList.Size = New System.Drawing.Size(307, 212)
        Me.multiCatList.TabIndex = 0
        '
        'AsasasToolStripMenuItem
        '
        Me.AsasasToolStripMenuItem.Name = "AsasasToolStripMenuItem"
        Me.AsasasToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AsasasToolStripMenuItem.Text = "asasas"
        '
        'GfgfgfgfgToolStripMenuItem
        '
        Me.GfgfgfgfgToolStripMenuItem.Name = "GfgfgfgfgToolStripMenuItem"
        Me.GfgfgfgfgToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.GfgfgfgfgToolStripMenuItem.Text = "gfgfgfgfg"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.TopicToolStripMenuItem, Me.QuestionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1547, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
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
        Me.EditCategoryToolStripMenuItem.Name = "EditCategoryToolStripMenuItem"
        Me.EditCategoryToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.EditCategoryToolStripMenuItem.Text = "Edit Category"
        '
        'DeleteCategoryToolStripMenuItem1
        '
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
        Me.NewTopicToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NewTopicToolStripMenuItem1.Text = "New Topic"
        '
        'EditTopicToolStripMenuItem
        '
        Me.EditTopicToolStripMenuItem.Name = "EditTopicToolStripMenuItem"
        Me.EditTopicToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditTopicToolStripMenuItem.Text = "Edit Topic"
        '
        'DeleteTopicToolStripMenuItem1
        '
        Me.DeleteTopicToolStripMenuItem1.Name = "DeleteTopicToolStripMenuItem1"
        Me.DeleteTopicToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.DeleteTopicToolStripMenuItem1.Text = "Delete Topic"
        '
        'QuestionToolStripMenuItem
        '
        Me.QuestionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewQuestionToolStripMenuItem1, Me.DeleteQuestionToolStripMenuItem1})
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
        'DeleteQuestionToolStripMenuItem1
        '
        Me.DeleteQuestionToolStripMenuItem1.Name = "DeleteQuestionToolStripMenuItem1"
        Me.DeleteQuestionToolStripMenuItem1.Size = New System.Drawing.Size(158, 22)
        Me.DeleteQuestionToolStripMenuItem1.Text = "Delete Question"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'designer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1547, 481)
        Me.Controls.Add(Me.MenuStrip1)
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
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteQuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents questionListView As System.Windows.Forms.ListView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents numQbox As System.Windows.Forms.NumericUpDown
    Friend WithEvents RANDOMIZEchkbox As System.Windows.Forms.CheckBox
    Friend WithEvents LEVELtrackbar As System.Windows.Forms.TrackBar
    Friend WithEvents GENbtn As System.Windows.Forms.Button

    Friend WithEvents CategoriesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents multiCatList As System.Windows.Forms.ListBox
    Friend WithEvents multiTopList As System.Windows.Forms.ListBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label



    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub designer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents AsasasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GfgfgfgfgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteCategoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTopicToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteTopicToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuestionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewQuestionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteQuestionToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents editTopicButton As System.Windows.Forms.Button
    Friend WithEvents editCategoryButton As System.Windows.Forms.Button
    Friend WithEvents EditCategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditTopicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
