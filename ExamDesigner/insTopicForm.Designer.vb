<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insTopicForm
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
        Me.InsertTopicLabel = New System.Windows.Forms.Label()
        Me.TopicTextBox = New System.Windows.Forms.TextBox()
        Me.OKInsTopicButton = New System.Windows.Forms.Button()
        Me.CancelInsTopicButton = New System.Windows.Forms.Button()
        Me.SelectCategoryLabel = New System.Windows.Forms.Label()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'InsertTopicLabel
        '
        Me.InsertTopicLabel.AutoSize = True
        Me.InsertTopicLabel.Location = New System.Drawing.Point(33, 61)
        Me.InsertTopicLabel.Name = "InsertTopicLabel"
        Me.InsertTopicLabel.Size = New System.Drawing.Size(66, 13)
        Me.InsertTopicLabel.TabIndex = 0
        Me.InsertTopicLabel.Text = "Insert Topic:"
        '
        'TopicTextBox
        '
        Me.TopicTextBox.Location = New System.Drawing.Point(109, 58)
        Me.TopicTextBox.Name = "TopicTextBox"
        Me.TopicTextBox.ReadOnly = True
        Me.TopicTextBox.Size = New System.Drawing.Size(250, 20)
        Me.TopicTextBox.TabIndex = 1
        '
        'OKInsTopicButton
        '
        Me.OKInsTopicButton.Location = New System.Drawing.Point(155, 94)
        Me.OKInsTopicButton.Name = "OKInsTopicButton"
        Me.OKInsTopicButton.Size = New System.Drawing.Size(71, 24)
        Me.OKInsTopicButton.TabIndex = 2
        Me.OKInsTopicButton.Text = "&OK"
        Me.OKInsTopicButton.UseVisualStyleBackColor = True
        '
        'CancelInsTopicButton
        '
        Me.CancelInsTopicButton.Location = New System.Drawing.Point(232, 94)
        Me.CancelInsTopicButton.Name = "CancelInsTopicButton"
        Me.CancelInsTopicButton.Size = New System.Drawing.Size(68, 24)
        Me.CancelInsTopicButton.TabIndex = 3
        Me.CancelInsTopicButton.Text = "&Cancel"
        Me.CancelInsTopicButton.UseVisualStyleBackColor = True
        '
        'SelectCategoryLabel
        '
        Me.SelectCategoryLabel.AutoSize = True
        Me.SelectCategoryLabel.Location = New System.Drawing.Point(14, 17)
        Me.SelectCategoryLabel.Name = "SelectCategoryLabel"
        Me.SelectCategoryLabel.Size = New System.Drawing.Size(85, 13)
        Me.SelectCategoryLabel.TabIndex = 4
        Me.SelectCategoryLabel.Text = "Select Category:"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Location = New System.Drawing.Point(109, 15)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(250, 21)
        Me.CategoryComboBox.TabIndex = 5
        '
        'insTopicForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 136)
        Me.ControlBox = False
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.SelectCategoryLabel)
        Me.Controls.Add(Me.CancelInsTopicButton)
        Me.Controls.Add(Me.OKInsTopicButton)
        Me.Controls.Add(Me.TopicTextBox)
        Me.Controls.Add(Me.InsertTopicLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "insTopicForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Topic"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InsertTopicLabel As System.Windows.Forms.Label
    Friend WithEvents TopicTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OKInsTopicButton As System.Windows.Forms.Button
    Friend WithEvents CancelInsTopicButton As System.Windows.Forms.Button
    Private WithEvents SelectCategoryLabel As System.Windows.Forms.Label
    Friend WithEvents CategoryComboBox As System.Windows.Forms.ComboBox
End Class
