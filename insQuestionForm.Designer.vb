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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.qRichTxtBox = New System.Windows.Forms.RichTextBox()
        Me.OKbutton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.o1RichTxtBox = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.o2RichTxtBox = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.o3RichTxtBox = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.o4RichTxtBox = New System.Windows.Forms.RichTextBox()
        Me.categoryCombo1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.topicsCombo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.levelCombo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Queston Text:"
        '
        'qRichTxtBox
        '
        Me.qRichTxtBox.Enabled = False
        Me.qRichTxtBox.Location = New System.Drawing.Point(15, 80)
        Me.qRichTxtBox.Name = "qRichTxtBox"
        Me.qRichTxtBox.Size = New System.Drawing.Size(651, 104)
        Me.qRichTxtBox.TabIndex = 1
        Me.qRichTxtBox.Text = ""
        '
        'OKbutton
        '
        Me.OKbutton.Enabled = False
        Me.OKbutton.Location = New System.Drawing.Point(500, 454)
        Me.OKbutton.Name = "OKbutton"
        Me.OKbutton.Size = New System.Drawing.Size(80, 31)
        Me.OKbutton.TabIndex = 2
        Me.OKbutton.Text = "&OK"
        Me.OKbutton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(585, 454)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(80, 31)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Answer 1"
        '
        'o1RichTxtBox
        '
        Me.o1RichTxtBox.Enabled = False
        Me.o1RichTxtBox.Location = New System.Drawing.Point(15, 214)
        Me.o1RichTxtBox.Name = "o1RichTxtBox"
        Me.o1RichTxtBox.Size = New System.Drawing.Size(650, 30)
        Me.o1RichTxtBox.TabIndex = 6
        Me.o1RichTxtBox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Answer 2"
        '
        'o2RichTxtBox
        '
        Me.o2RichTxtBox.Enabled = False
        Me.o2RichTxtBox.Location = New System.Drawing.Point(15, 283)
        Me.o2RichTxtBox.Name = "o2RichTxtBox"
        Me.o2RichTxtBox.Size = New System.Drawing.Size(650, 30)
        Me.o2RichTxtBox.TabIndex = 8
        Me.o2RichTxtBox.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Answer 3"
        '
        'o3RichTxtBox
        '
        Me.o3RichTxtBox.Enabled = False
        Me.o3RichTxtBox.Location = New System.Drawing.Point(15, 347)
        Me.o3RichTxtBox.Name = "o3RichTxtBox"
        Me.o3RichTxtBox.Size = New System.Drawing.Size(650, 30)
        Me.o3RichTxtBox.TabIndex = 10
        Me.o3RichTxtBox.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Answer 4"
        '
        'o4RichTxtBox
        '
        Me.o4RichTxtBox.Enabled = False
        Me.o4RichTxtBox.Location = New System.Drawing.Point(15, 408)
        Me.o4RichTxtBox.Name = "o4RichTxtBox"
        Me.o4RichTxtBox.Size = New System.Drawing.Size(650, 30)
        Me.o4RichTxtBox.TabIndex = 12
        Me.o4RichTxtBox.Text = ""
        '
        'categoryCombo1
        '
        Me.categoryCombo1.FormattingEnabled = True
        Me.categoryCombo1.Location = New System.Drawing.Point(12, 29)
        Me.categoryCombo1.Name = "categoryCombo1"
        Me.categoryCombo1.Size = New System.Drawing.Size(181, 21)
        Me.categoryCombo1.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Category:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(209, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Topic:"
        '
        'topicsCombo
        '
        Me.topicsCombo.Enabled = False
        Me.topicsCombo.FormattingEnabled = True
        Me.topicsCombo.Location = New System.Drawing.Point(212, 29)
        Me.topicsCombo.Name = "topicsCombo"
        Me.topicsCombo.Size = New System.Drawing.Size(181, 21)
        Me.topicsCombo.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Level:"
        '
        'levelCombo
        '
        Me.levelCombo.Enabled = False
        Me.levelCombo.FormattingEnabled = True
        Me.levelCombo.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.levelCombo.Location = New System.Drawing.Point(414, 29)
        Me.levelCombo.Name = "levelCombo"
        Me.levelCombo.Size = New System.Drawing.Size(53, 21)
        Me.levelCombo.TabIndex = 18
        '
        'insQuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.levelCombo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.topicsCombo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.categoryCombo1)
        Me.Controls.Add(Me.o4RichTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.o3RichTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.o2RichTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.o1RichTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKbutton)
        Me.Controls.Add(Me.qRichTxtBox)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents qRichTxtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents OKbutton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents o1RichTxtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents o2RichTxtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents o3RichTxtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents o4RichTxtBox As System.Windows.Forms.RichTextBox
    Friend WithEvents categoryCombo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents topicsCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents levelCombo As System.Windows.Forms.ComboBox
End Class
