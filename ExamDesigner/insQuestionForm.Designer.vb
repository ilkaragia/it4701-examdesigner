<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insQuestionForm
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
        Me.QuestionTextLabel = New System.Windows.Forms.Label()
        Me.QuestionRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.OKInsQuestButton = New System.Windows.Forms.Button()
        Me.CancelInsQuestButton = New System.Windows.Forms.Button()
        Me.Answer1Label = New System.Windows.Forms.Label()
        Me.Answer1RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Answer2Label = New System.Windows.Forms.Label()
        Me.Answer2RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Answer3Label = New System.Windows.Forms.Label()
        Me.Answer3RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Answer4Label = New System.Windows.Forms.Label()
        Me.Answer4RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.QuesCategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.TopicLabel = New System.Windows.Forms.Label()
        Me.TopicComboBox = New System.Windows.Forms.ComboBox()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.LevelComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'QuestionTextLabel
        '
        Me.QuestionTextLabel.AutoSize = True
        Me.QuestionTextLabel.Location = New System.Drawing.Point(12, 64)
        Me.QuestionTextLabel.Name = "QuestionTextLabel"
        Me.QuestionTextLabel.Size = New System.Drawing.Size(74, 13)
        Me.QuestionTextLabel.TabIndex = 0
        Me.QuestionTextLabel.Text = "Queston Text:"
        '
        'QuestionRichTextBox
        '
        Me.QuestionRichTextBox.Enabled = False
        Me.QuestionRichTextBox.Location = New System.Drawing.Point(15, 80)
        Me.QuestionRichTextBox.Name = "QuestionRichTextBox"
        Me.QuestionRichTextBox.Size = New System.Drawing.Size(651, 104)
        Me.QuestionRichTextBox.TabIndex = 1
        Me.QuestionRichTextBox.Text = ""
        '
        'OKInsQuestButton
        '
        Me.OKInsQuestButton.Enabled = False
        Me.OKInsQuestButton.Location = New System.Drawing.Point(500, 454)
        Me.OKInsQuestButton.Name = "OKInsQuestButton"
        Me.OKInsQuestButton.Size = New System.Drawing.Size(80, 31)
        Me.OKInsQuestButton.TabIndex = 2
        Me.OKInsQuestButton.Text = "&OK"
        Me.OKInsQuestButton.UseVisualStyleBackColor = True
        '
        'CancelInsQuestButton
        '
        Me.CancelInsQuestButton.Location = New System.Drawing.Point(585, 454)
        Me.CancelInsQuestButton.Name = "CancelInsQuestButton"
        Me.CancelInsQuestButton.Size = New System.Drawing.Size(80, 31)
        Me.CancelInsQuestButton.TabIndex = 3
        Me.CancelInsQuestButton.Text = "&Cancel"
        Me.CancelInsQuestButton.UseVisualStyleBackColor = True
        '
        'Answer1Label
        '
        Me.Answer1Label.AutoSize = True
        Me.Answer1Label.Location = New System.Drawing.Point(12, 198)
        Me.Answer1Label.Name = "Answer1Label"
        Me.Answer1Label.Size = New System.Drawing.Size(51, 13)
        Me.Answer1Label.TabIndex = 5
        Me.Answer1Label.Text = "Answer 1"
        '
        'Answer1RichTextBox
        '
        Me.Answer1RichTextBox.Enabled = False
        Me.Answer1RichTextBox.Location = New System.Drawing.Point(15, 214)
        Me.Answer1RichTextBox.Name = "Answer1RichTextBox"
        Me.Answer1RichTextBox.Size = New System.Drawing.Size(650, 30)
        Me.Answer1RichTextBox.TabIndex = 6
        Me.Answer1RichTextBox.Text = ""
        '
        'Answer2Label
        '
        Me.Answer2Label.AutoSize = True
        Me.Answer2Label.Location = New System.Drawing.Point(12, 267)
        Me.Answer2Label.Name = "Answer2Label"
        Me.Answer2Label.Size = New System.Drawing.Size(51, 13)
        Me.Answer2Label.TabIndex = 7
        Me.Answer2Label.Text = "Answer 2"
        '
        'Answer2RichTextBox
        '
        Me.Answer2RichTextBox.Enabled = False
        Me.Answer2RichTextBox.Location = New System.Drawing.Point(15, 283)
        Me.Answer2RichTextBox.Name = "Answer2RichTextBox"
        Me.Answer2RichTextBox.Size = New System.Drawing.Size(650, 30)
        Me.Answer2RichTextBox.TabIndex = 8
        Me.Answer2RichTextBox.Text = ""
        '
        'Answer3Label
        '
        Me.Answer3Label.AutoSize = True
        Me.Answer3Label.Location = New System.Drawing.Point(12, 331)
        Me.Answer3Label.Name = "Answer3Label"
        Me.Answer3Label.Size = New System.Drawing.Size(51, 13)
        Me.Answer3Label.TabIndex = 9
        Me.Answer3Label.Text = "Answer 3"
        '
        'Answer3RichTextBox
        '
        Me.Answer3RichTextBox.Enabled = False
        Me.Answer3RichTextBox.Location = New System.Drawing.Point(15, 347)
        Me.Answer3RichTextBox.Name = "Answer3RichTextBox"
        Me.Answer3RichTextBox.Size = New System.Drawing.Size(650, 30)
        Me.Answer3RichTextBox.TabIndex = 10
        Me.Answer3RichTextBox.Text = ""
        '
        'Answer4Label
        '
        Me.Answer4Label.AutoSize = True
        Me.Answer4Label.Location = New System.Drawing.Point(12, 392)
        Me.Answer4Label.Name = "Answer4Label"
        Me.Answer4Label.Size = New System.Drawing.Size(51, 13)
        Me.Answer4Label.TabIndex = 11
        Me.Answer4Label.Text = "Answer 4"
        '
        'Answer4RichTextBox
        '
        Me.Answer4RichTextBox.Enabled = False
        Me.Answer4RichTextBox.Location = New System.Drawing.Point(15, 408)
        Me.Answer4RichTextBox.Name = "Answer4RichTextBox"
        Me.Answer4RichTextBox.Size = New System.Drawing.Size(650, 30)
        Me.Answer4RichTextBox.TabIndex = 12
        Me.Answer4RichTextBox.Text = ""
        '
        'QuesCategoryComboBox
        '
        Me.QuesCategoryComboBox.FormattingEnabled = True
        Me.QuesCategoryComboBox.Location = New System.Drawing.Point(12, 29)
        Me.QuesCategoryComboBox.Name = "QuesCategoryComboBox"
        Me.QuesCategoryComboBox.Size = New System.Drawing.Size(181, 21)
        Me.QuesCategoryComboBox.TabIndex = 13
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Location = New System.Drawing.Point(12, 13)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(52, 13)
        Me.CategoryLabel.TabIndex = 14
        Me.CategoryLabel.Text = "Category:"
        '
        'TopicLabel
        '
        Me.TopicLabel.AutoSize = True
        Me.TopicLabel.Location = New System.Drawing.Point(209, 13)
        Me.TopicLabel.Name = "TopicLabel"
        Me.TopicLabel.Size = New System.Drawing.Size(37, 13)
        Me.TopicLabel.TabIndex = 15
        Me.TopicLabel.Text = "Topic:"
        '
        'TopicComboBox
        '
        Me.TopicComboBox.Enabled = False
        Me.TopicComboBox.FormattingEnabled = True
        Me.TopicComboBox.Location = New System.Drawing.Point(212, 29)
        Me.TopicComboBox.Name = "TopicComboBox"
        Me.TopicComboBox.Size = New System.Drawing.Size(181, 21)
        Me.TopicComboBox.TabIndex = 16
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(411, 13)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(36, 13)
        Me.LevelLabel.TabIndex = 17
        Me.LevelLabel.Text = "Level:"
        '
        'LevelComboBox
        '
        Me.LevelComboBox.Enabled = False
        Me.LevelComboBox.FormattingEnabled = True
        Me.LevelComboBox.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.LevelComboBox.Location = New System.Drawing.Point(414, 29)
        Me.LevelComboBox.Name = "LevelComboBox"
        Me.LevelComboBox.Size = New System.Drawing.Size(53, 21)
        Me.LevelComboBox.TabIndex = 18
        '
        'insQuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.LevelComboBox)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.TopicComboBox)
        Me.Controls.Add(Me.TopicLabel)
        Me.Controls.Add(Me.CategoryLabel)
        Me.Controls.Add(Me.QuesCategoryComboBox)
        Me.Controls.Add(Me.Answer4RichTextBox)
        Me.Controls.Add(Me.Answer4Label)
        Me.Controls.Add(Me.Answer3RichTextBox)
        Me.Controls.Add(Me.Answer3Label)
        Me.Controls.Add(Me.Answer2RichTextBox)
        Me.Controls.Add(Me.Answer2Label)
        Me.Controls.Add(Me.Answer1RichTextBox)
        Me.Controls.Add(Me.Answer1Label)
        Me.Controls.Add(Me.CancelInsQuestButton)
        Me.Controls.Add(Me.OKInsQuestButton)
        Me.Controls.Add(Me.QuestionRichTextBox)
        Me.Controls.Add(Me.QuestionTextLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "insQuestionForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert New Question"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QuestionTextLabel As System.Windows.Forms.Label
    Friend WithEvents QuestionRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents OKInsQuestButton As System.Windows.Forms.Button
    Friend WithEvents CancelInsQuestButton As System.Windows.Forms.Button
    Friend WithEvents Answer1Label As System.Windows.Forms.Label
    Friend WithEvents Answer1RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Answer2Label As System.Windows.Forms.Label
    Friend WithEvents Answer2RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Answer3Label As System.Windows.Forms.Label
    Friend WithEvents Answer3RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Answer4Label As System.Windows.Forms.Label
    Friend WithEvents Answer4RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents QuesCategoryComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CategoryLabel As System.Windows.Forms.Label
    Friend WithEvents TopicLabel As System.Windows.Forms.Label
    Friend WithEvents TopicComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents LevelLabel As System.Windows.Forms.Label
    Friend WithEvents LevelComboBox As System.Windows.Forms.ComboBox
End Class
