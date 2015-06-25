<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtUL = New System.Windows.Forms.TextBox()
        Me.txtUR = New System.Windows.Forms.TextBox()
        Me.txtLL = New System.Windows.Forms.TextBox()
        Me.txtLR = New System.Windows.Forms.TextBox()
        Me.txtCur = New System.Windows.Forms.TextBox()
        Me.lstHistory = New System.Windows.Forms.ListBox()
        Me.tmrCheckClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRestartCheckClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromULToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromLLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromLRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnotherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToLLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToLRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearULToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearURToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearLLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearLRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UCASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.mnuStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLength = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.txtLL.WordWrap = False
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
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.CopyToolStripMenuItem, Me.ClearToolStripMenuItem, Me.FunctionToolStripMenuItem, Me.mnuStatus, Me.mnuLength})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(461, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FromULToolStripMenuItem, Me.FromURToolStripMenuItem, Me.FromLLToolStripMenuItem, Me.FromLRToolStripMenuItem, Me.ToolStripMenuItem1, Me.AnotherToolStripMenuItem, Me.ToURToolStripMenuItem, Me.ToLLToolStripMenuItem, Me.ToLRToolStripMenuItem})
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'FromULToolStripMenuItem
        '
        Me.FromULToolStripMenuItem.Name = "FromULToolStripMenuItem"
        Me.FromULToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.FromULToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FromULToolStripMenuItem.Text = "&A - From UL"
        '
        'FromURToolStripMenuItem
        '
        Me.FromURToolStripMenuItem.Name = "FromURToolStripMenuItem"
        Me.FromURToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.FromURToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FromURToolStripMenuItem.Text = "&S - From UR"
        '
        'FromLLToolStripMenuItem
        '
        Me.FromLLToolStripMenuItem.Name = "FromLLToolStripMenuItem"
        Me.FromLLToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.FromLLToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FromLLToolStripMenuItem.Text = "&D - From LL"
        '
        'FromLRToolStripMenuItem
        '
        Me.FromLRToolStripMenuItem.Name = "FromLRToolStripMenuItem"
        Me.FromLRToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.FromLRToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.FromLRToolStripMenuItem.Text = "&F - From LR"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(172, 6)
        '
        'AnotherToolStripMenuItem
        '
        Me.AnotherToolStripMenuItem.Name = "AnotherToolStripMenuItem"
        Me.AnotherToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.AnotherToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.AnotherToolStripMenuItem.Text = "&Z - To UL"
        '
        'ToURToolStripMenuItem
        '
        Me.ToURToolStripMenuItem.Name = "ToURToolStripMenuItem"
        Me.ToURToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.ToURToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.ToURToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ToURToolStripMenuItem.Text = "&X - To UR"
        '
        'ToLLToolStripMenuItem
        '
        Me.ToLLToolStripMenuItem.Name = "ToLLToolStripMenuItem"
        Me.ToLLToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.ToLLToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ToLLToolStripMenuItem.Text = "&C - To LL"
        '
        'ToLRToolStripMenuItem
        '
        Me.ToLRToolStripMenuItem.Name = "ToLRToolStripMenuItem"
        Me.ToLRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ToLRToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.ToLRToolStripMenuItem.Text = "&V - To LR"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearULToolStripMenuItem, Me.ClearURToolStripMenuItem, Me.ClearLLToolStripMenuItem, Me.ClearLRToolStripMenuItem})
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ClearToolStripMenuItem.Text = "C&lear"
        '
        'ClearULToolStripMenuItem
        '
        Me.ClearULToolStripMenuItem.Name = "ClearULToolStripMenuItem"
        Me.ClearULToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ClearULToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ClearULToolStripMenuItem.Text = "&Z - Clear UL"
        '
        'ClearURToolStripMenuItem
        '
        Me.ClearURToolStripMenuItem.Name = "ClearURToolStripMenuItem"
        Me.ClearURToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F2), System.Windows.Forms.Keys)
        Me.ClearURToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ClearURToolStripMenuItem.Text = "&X - Clear UR"
        '
        'ClearLLToolStripMenuItem
        '
        Me.ClearLLToolStripMenuItem.Name = "ClearLLToolStripMenuItem"
        Me.ClearLLToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F3), System.Windows.Forms.Keys)
        Me.ClearLLToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ClearLLToolStripMenuItem.Text = "&Y - Clear LL"
        '
        'ClearLRToolStripMenuItem
        '
        Me.ClearLRToolStripMenuItem.Name = "ClearLRToolStripMenuItem"
        Me.ClearLRToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ClearLRToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ClearLRToolStripMenuItem.Text = "&V - Clear LR"
        '
        'FunctionToolStripMenuItem
        '
        Me.FunctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F1ToolStripMenuItem, Me.F2ToolStripMenuItem, Me.F3ToolStripMenuItem, Me.F4ToolStripMenuItem})
        Me.FunctionToolStripMenuItem.Name = "FunctionToolStripMenuItem"
        Me.FunctionToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.FunctionToolStripMenuItem.Text = "&Function"
        '
        'F1ToolStripMenuItem
        '
        Me.F1ToolStripMenuItem.CheckOnClick = True
        Me.F1ToolStripMenuItem.Name = "F1ToolStripMenuItem"
        Me.F1ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D1), System.Windows.Forms.Keys)
        Me.F1ToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.F1ToolStripMenuItem.Text = "Trim Spaces"
        '
        'F2ToolStripMenuItem
        '
        Me.F2ToolStripMenuItem.CheckOnClick = True
        Me.F2ToolStripMenuItem.Name = "F2ToolStripMenuItem"
        Me.F2ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D2), System.Windows.Forms.Keys)
        Me.F2ToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.F2ToolStripMenuItem.Text = "0000xxxxxx -> xxxxxx"
        '
        'F3ToolStripMenuItem
        '
        Me.F3ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UCASEToolStripMenuItem, Me.LCaseToolStripMenuItem, Me.PCaseToolStripMenuItem})
        Me.F3ToolStripMenuItem.Name = "F3ToolStripMenuItem"
        Me.F3ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D3), System.Windows.Forms.Keys)
        Me.F3ToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.F3ToolStripMenuItem.Text = "CASE <-> case <-> Case"
        '
        'UCASEToolStripMenuItem
        '
        Me.UCASEToolStripMenuItem.Name = "UCASEToolStripMenuItem"
        Me.UCASEToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UCASEToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.UCASEToolStripMenuItem.Text = "&UPPER CASE"
        '
        'LCaseToolStripMenuItem
        '
        Me.LCaseToolStripMenuItem.Name = "LCaseToolStripMenuItem"
        Me.LCaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LCaseToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.LCaseToolStripMenuItem.Text = "&lower case"
        '
        'PCaseToolStripMenuItem
        '
        Me.PCaseToolStripMenuItem.Name = "PCaseToolStripMenuItem"
        Me.PCaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PCaseToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.PCaseToolStripMenuItem.Text = "&Proper Case"
        '
        'F4ToolStripMenuItem
        '
        Me.F4ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.ToolStripTextBox2})
        Me.F4ToolStripMenuItem.Name = "F4ToolStripMenuItem"
        Me.F4ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.F4ToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.F4ToolStripMenuItem.Text = "Replace Chrs"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox1.Text = "Find These Chars"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBox2.Text = "Replace With These"
        '
        'mnuStatus
        '
        Me.mnuStatus.Name = "mnuStatus"
        Me.mnuStatus.Size = New System.Drawing.Size(51, 20)
        Me.mnuStatus.Text = "Status"
        '
        'mnuLength
        '
        Me.mnuLength.Name = "mnuLength"
        Me.mnuLength.Size = New System.Drawing.Size(52, 20)
        Me.mnuLength.Text = "C= L="
        '
        'frmMain
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Clipboard Manager"
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
    Friend WithEvents mnuLength As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FromULToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FromURToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FromLLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FromLRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnotherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToURToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToLLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToLRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearULToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearURToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearLLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearLRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents F1ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents F2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents F3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents F4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStatus As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UCASEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PCaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox

End Class
