<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtUL = New System.Windows.Forms.TextBox()
        Me.txtUR = New System.Windows.Forms.TextBox()
        Me.txtLL = New System.Windows.Forms.TextBox()
        Me.txtLR = New System.Windows.Forms.TextBox()
        Me.txtCur = New System.Windows.Forms.TextBox()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.tmrCheckClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRestartCheckClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUL
        '
        Me.txtUL.Location = New System.Drawing.Point(12, 38)
        Me.txtUL.Multiline = True
        Me.txtUL.Name = "txtUL"
        Me.txtUL.Size = New System.Drawing.Size(114, 20)
        Me.txtUL.TabIndex = 0
        '
        'txtUR
        '
        Me.txtUR.Location = New System.Drawing.Point(166, 38)
        Me.txtUR.Multiline = True
        Me.txtUR.Name = "txtUR"
        Me.txtUR.Size = New System.Drawing.Size(114, 20)
        Me.txtUR.TabIndex = 1
        '
        'txtLL
        '
        Me.txtLL.Location = New System.Drawing.Point(12, 64)
        Me.txtLL.Multiline = True
        Me.txtLL.Name = "txtLL"
        Me.txtLL.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtLL.Size = New System.Drawing.Size(114, 20)
        Me.txtLL.TabIndex = 2
        '
        'txtLR
        '
        Me.txtLR.Location = New System.Drawing.Point(166, 64)
        Me.txtLR.Multiline = True
        Me.txtLR.Name = "txtLR"
        Me.txtLR.Size = New System.Drawing.Size(114, 20)
        Me.txtLR.TabIndex = 3
        '
        'txtCur
        '
        Me.txtCur.Location = New System.Drawing.Point(166, 119)
        Me.txtCur.Multiline = True
        Me.txtCur.Name = "txtCur"
        Me.txtCur.Size = New System.Drawing.Size(114, 108)
        Me.txtCur.TabIndex = 4
        '
        'lstHistory
        '
        Me.lstHistory.FormattingEnabled = True
        Me.lstHistory.Location = New System.Drawing.Point(12, 119)
        Me.lstHistory.Name = "lstHistory"
        Me.lstHistory.Size = New System.Drawing.Size(114, 108)
        Me.lstHistory.TabIndex = 5
        '
        'tmrCheckClipboard
        '
        Me.tmrCheckClipboard.Enabled = True
        Me.tmrCheckClipboard.Interval = 1000
        '
        'tmrRestartCheckClipboard
        '
        Me.tmrRestartCheckClipboard.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.ClearToolStripMenuItem, Me.FunctionToolStripMenuItem, Me.LToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(461, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'FunctionToolStripMenuItem
        '
        Me.FunctionToolStripMenuItem.Name = "FunctionToolStripMenuItem"
        Me.FunctionToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.FunctionToolStripMenuItem.Text = "Function"
        '
        'LToolStripMenuItem
        '
        Me.LToolStripMenuItem.Name = "LToolStripMenuItem"
        Me.LToolStripMenuItem.Size = New System.Drawing.Size(33, 20)
        Me.LToolStripMenuItem.Text = "L="
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 355)
        Me.Controls.Add(Me.lstHistory)
        Me.Controls.Add(Me.txtCur)
        Me.Controls.Add(Me.txtLR)
        Me.Controls.Add(Me.txtLL)
        Me.Controls.Add(Me.txtUR)
        Me.Controls.Add(Me.txtUL)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUL As System.Windows.Forms.TextBox
    Friend WithEvents txtUR As System.Windows.Forms.TextBox
    Friend WithEvents txtLL As System.Windows.Forms.TextBox
    Friend WithEvents txtLR As System.Windows.Forms.TextBox
    Friend WithEvents txtCur As System.Windows.Forms.TextBox
    Friend WithEvents lstHistory As System.Windows.Forms.ListBox
    Friend WithEvents tmrCheckClipboard As System.Windows.Forms.Timer
    Friend WithEvents tmrRestartCheckClipboard As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FunctionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
