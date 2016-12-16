<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insCategoryForm
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
        Me.CategoryLabel = New System.Windows.Forms.Label()
        Me.OKInsCatButton = New System.Windows.Forms.Button()
        Me.CancelInsCatButton = New System.Windows.Forms.Button()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CategoryLabel
        '
        Me.CategoryLabel.AutoSize = True
        Me.CategoryLabel.Location = New System.Drawing.Point(13, 19)
        Me.CategoryLabel.Name = "CategoryLabel"
        Me.CategoryLabel.Size = New System.Drawing.Size(83, 13)
        Me.CategoryLabel.TabIndex = 0
        Me.CategoryLabel.Text = "Category Name:"
        '
        'OKInsCatButton
        '
        Me.OKInsCatButton.Location = New System.Drawing.Point(166, 55)
        Me.OKInsCatButton.Name = "OKInsCatButton"
        Me.OKInsCatButton.Size = New System.Drawing.Size(62, 24)
        Me.OKInsCatButton.TabIndex = 2
        Me.OKInsCatButton.Text = "&OK"
        Me.OKInsCatButton.UseVisualStyleBackColor = True
        '
        'CancelInsCatButton
        '
        Me.CancelInsCatButton.Location = New System.Drawing.Point(234, 55)
        Me.CancelInsCatButton.Name = "CancelInsCatButton"
        Me.CancelInsCatButton.Size = New System.Drawing.Size(62, 24)
        Me.CancelInsCatButton.TabIndex = 3
        Me.CancelInsCatButton.Text = "&Cancel"
        Me.CancelInsCatButton.UseVisualStyleBackColor = True
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.Location = New System.Drawing.Point(101, 17)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(274, 20)
        Me.CategoryTextBox.TabIndex = 4
        '
        'insCategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 96)
        Me.ControlBox = False
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Me.CancelInsCatButton)
        Me.Controls.Add(Me.OKInsCatButton)
        Me.Controls.Add(Me.CategoryLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "insCategoryForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Category"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CategoryLabel As System.Windows.Forms.Label
    Friend WithEvents OKInsCatButton As System.Windows.Forms.Button
    Friend WithEvents CancelInsCatButton As System.Windows.Forms.Button
    Friend WithEvents CategoryTextBox As System.Windows.Forms.TextBox
End Class
