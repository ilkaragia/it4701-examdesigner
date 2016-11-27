<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(viewer))
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.viewerMenu = New System.Windows.Forms.ToolStrip
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.prntBtn = New System.Windows.Forms.ToolStripButton
        Me.savBtn = New System.Windows.Forms.ToolStripButton
        Me.xBtn = New System.Windows.Forms.ToolStripButton
        Me.viewerMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.AllowWebBrowserDrop = False
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 29)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(1011, 930)
        Me.WebBrowser1.TabIndex = 3
        Me.WebBrowser1.WebBrowserShortcutsEnabled = False
        '
        'viewerMenu
        '
        Me.viewerMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.prntBtn, Me.savBtn, Me.xBtn})
        Me.viewerMenu.Location = New System.Drawing.Point(0, 0)
        Me.viewerMenu.Name = "viewerMenu"
        Me.viewerMenu.Size = New System.Drawing.Size(1011, 25)
        Me.viewerMenu.TabIndex = 4
        Me.viewerMenu.Text = "ToolStrip1"
        '
        'SaveFileDialog1
        '
        '
        'prntBtn
        '
        Me.prntBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.prntBtn.Image = Global.ExamDesigner.My.Resources.Resources._2000px_Print_font_awesome_svg
        Me.prntBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.prntBtn.Name = "prntBtn"
        Me.prntBtn.Size = New System.Drawing.Size(23, 22)
        Me.prntBtn.Text = "Print Test"
        '
        'savBtn
        '
        Me.savBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.savBtn.Image = CType(resources.GetObject("savBtn.Image"), System.Drawing.Image)
        Me.savBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.savBtn.Name = "savBtn"
        Me.savBtn.Size = New System.Drawing.Size(23, 22)
        Me.savBtn.Text = "ToolStripButton1"
        Me.savBtn.ToolTipText = "Save Test"
        '
        'xBtn
        '
        Me.xBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.xBtn.Image = Global.ExamDesigner.My.Resources.Resources.DeleteRed
        Me.xBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.xBtn.Name = "xBtn"
        Me.xBtn.Size = New System.Drawing.Size(23, 22)
        Me.xBtn.Text = "Close"
        '
        'viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1012, 932)
        Me.Controls.Add(Me.viewerMenu)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Viewer"
        Me.TopMost = True
        Me.viewerMenu.ResumeLayout(False)
        Me.viewerMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents viewerMenu As System.Windows.Forms.ToolStrip
    Friend WithEvents prntBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents savBtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents xBtn As System.Windows.Forms.ToolStripButton
End Class
