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
        Me.CheckClipboardIntervalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.PauseUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.AddToHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClipboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UCASEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PCaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.FindTheseCharactersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceFindToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReplaceWithTheseCharactersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReplaceWithToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.LookupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LookupEnabledToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResultsToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToToolStripComboBox = New System.Windows.Forms.ToolStripComboBox()
        Me.LookupFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LookupFileNameToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.BrowseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStatus = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLength = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstHistoryActual = New System.Windows.Forms.ListBox()
        Me.ReloadFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CbMdbDataSet1 = New CBM.CBMdbDataSet()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.CbMdbDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lstHistory.Items.AddRange(New Object() {" ", "  "})
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
        Me.MenuStrip1.Size = New System.Drawing.Size(549, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckClipboardIntervalToolStripMenuItem, Me.PauseUpdatesToolStripMenuItem, Me.AddToHistoryToolStripMenuItem, Me.SaveSettingsToolStripMenuItem, Me.LoadSettingsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'CheckClipboardIntervalToolStripMenuItem
        '
        Me.CheckClipboardIntervalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox3})
        Me.CheckClipboardIntervalToolStripMenuItem.Name = "CheckClipboardIntervalToolStripMenuItem"
        Me.CheckClipboardIntervalToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.CheckClipboardIntervalToolStripMenuItem.Text = "Check Clipboard Interval (1000ms)"
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 23)
        '
        'PauseUpdatesToolStripMenuItem
        '
        Me.PauseUpdatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox4})
        Me.PauseUpdatesToolStripMenuItem.Name = "PauseUpdatesToolStripMenuItem"
        Me.PauseUpdatesToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.PauseUpdatesToolStripMenuItem.Text = "Pause Updates Interval (1000ms)"
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 23)
        '
        'AddToHistoryToolStripMenuItem
        '
        Me.AddToHistoryToolStripMenuItem.Name = "AddToHistoryToolStripMenuItem"
        Me.AddToHistoryToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.AddToHistoryToolStripMenuItem.Text = "Add to History"
        '
        'SaveSettingsToolStripMenuItem
        '
        Me.SaveSettingsToolStripMenuItem.Name = "SaveSettingsToolStripMenuItem"
        Me.SaveSettingsToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.SaveSettingsToolStripMenuItem.Text = "Save Settings"
        '
        'LoadSettingsToolStripMenuItem
        '
        Me.LoadSettingsToolStripMenuItem.Name = "LoadSettingsToolStripMenuItem"
        Me.LoadSettingsToolStripMenuItem.Size = New System.Drawing.Size(255, 22)
        Me.LoadSettingsToolStripMenuItem.Text = "Load Settings"
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
        Me.ClearToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearULToolStripMenuItem, Me.ClearURToolStripMenuItem, Me.ClearLLToolStripMenuItem, Me.ClearLRToolStripMenuItem, Me.ToolStripMenuItem5, Me.ClipboardToolStripMenuItem})
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
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(180, 6)
        '
        'ClipboardToolStripMenuItem
        '
        Me.ClipboardToolStripMenuItem.Name = "ClipboardToolStripMenuItem"
        Me.ClipboardToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F5), System.Windows.Forms.Keys)
        Me.ClipboardToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ClipboardToolStripMenuItem.Text = "&Clipboard"
        '
        'FunctionToolStripMenuItem
        '
        Me.FunctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.F1ToolStripMenuItem, Me.F2ToolStripMenuItem, Me.F3ToolStripMenuItem, Me.F4ToolStripMenuItem, Me.LookupToolStripMenuItem})
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
        Me.F4ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnabledToolStripMenuItem, Me.ToolStripMenuItem3, Me.FindTheseCharactersToolStripMenuItem, Me.ReplaceFindToolStripTextBox, Me.ToolStripMenuItem2, Me.ReplaceWithTheseCharactersToolStripMenuItem, Me.ReplaceWithToolStripTextBox})
        Me.F4ToolStripMenuItem.Name = "F4ToolStripMenuItem"
        Me.F4ToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.F4ToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.F4ToolStripMenuItem.Text = "Replace Chrs"
        '
        'EnabledToolStripMenuItem
        '
        Me.EnabledToolStripMenuItem.CheckOnClick = True
        Me.EnabledToolStripMenuItem.Name = "EnabledToolStripMenuItem"
        Me.EnabledToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D4), System.Windows.Forms.Keys)
        Me.EnabledToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.EnabledToolStripMenuItem.Text = "Execute!"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(160, 6)
        '
        'FindTheseCharactersToolStripMenuItem
        '
        Me.FindTheseCharactersToolStripMenuItem.Name = "FindTheseCharactersToolStripMenuItem"
        Me.FindTheseCharactersToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.FindTheseCharactersToolStripMenuItem.Text = "Find this"
        '
        'ReplaceFindToolStripTextBox
        '
        Me.ReplaceFindToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReplaceFindToolStripTextBox.Name = "ReplaceFindToolStripTextBox"
        Me.ReplaceFindToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(160, 6)
        '
        'ReplaceWithTheseCharactersToolStripMenuItem
        '
        Me.ReplaceWithTheseCharactersToolStripMenuItem.Name = "ReplaceWithTheseCharactersToolStripMenuItem"
        Me.ReplaceWithTheseCharactersToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ReplaceWithTheseCharactersToolStripMenuItem.Text = "Replace with this"
        '
        'ReplaceWithToolStripTextBox
        '
        Me.ReplaceWithToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ReplaceWithToolStripTextBox.Name = "ReplaceWithToolStripTextBox"
        Me.ReplaceWithToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'LookupToolStripMenuItem
        '
        Me.LookupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LookupEnabledToolStripMenuItem, Me.ToolStripMenuItem4, Me.ResultsToToolStripMenuItem, Me.LookupFileToolStripMenuItem})
        Me.LookupToolStripMenuItem.Name = "LookupToolStripMenuItem"
        Me.LookupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.LookupToolStripMenuItem.Size = New System.Drawing.Size(244, 22)
        Me.LookupToolStripMenuItem.Text = "Lookup"
        '
        'LookupEnabledToolStripMenuItem
        '
        Me.LookupEnabledToolStripMenuItem.CheckOnClick = True
        Me.LookupEnabledToolStripMenuItem.Name = "LookupEnabledToolStripMenuItem"
        Me.LookupEnabledToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D5), System.Windows.Forms.Keys)
        Me.LookupEnabledToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.LookupEnabledToolStripMenuItem.Text = "Enabled"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(153, 6)
        '
        'ResultsToToolStripMenuItem
        '
        Me.ResultsToToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultsToToolStripComboBox})
        Me.ResultsToToolStripMenuItem.Name = "ResultsToToolStripMenuItem"
        Me.ResultsToToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ResultsToToolStripMenuItem.Text = "Results to"
        '
        'ResultsToToolStripComboBox
        '
        Me.ResultsToToolStripComboBox.Items.AddRange(New Object() {"Upper Left", "Upper Right", "Lower Left", "Lower Right"})
        Me.ResultsToToolStripComboBox.Name = "ResultsToToolStripComboBox"
        Me.ResultsToToolStripComboBox.Size = New System.Drawing.Size(121, 23)
        Me.ResultsToToolStripComboBox.Text = "Lower Left"
        '
        'LookupFileToolStripMenuItem
        '
        Me.LookupFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LookupFileNameToolStripTextBox, Me.BrowseToolStripMenuItem, Me.ReloadFileToolStripMenuItem})
        Me.LookupFileToolStripMenuItem.Name = "LookupFileToolStripMenuItem"
        Me.LookupFileToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.LookupFileToolStripMenuItem.Text = "Lookup File"
        '
        'LookupFileNameToolStripTextBox
        '
        Me.LookupFileNameToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LookupFileNameToolStripTextBox.Name = "LookupFileNameToolStripTextBox"
        Me.LookupFileNameToolStripTextBox.Size = New System.Drawing.Size(100, 23)
        '
        'BrowseToolStripMenuItem
        '
        Me.BrowseToolStripMenuItem.Name = "BrowseToolStripMenuItem"
        Me.BrowseToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.BrowseToolStripMenuItem.Text = "Browse"
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
        'lstHistoryActual
        '
        Me.lstHistoryActual.FormattingEnabled = True
        Me.lstHistoryActual.Items.AddRange(New Object() {" ", "  "})
        Me.lstHistoryActual.Location = New System.Drawing.Point(12, 233)
        Me.lstHistoryActual.Name = "lstHistoryActual"
        Me.lstHistoryActual.Size = New System.Drawing.Size(114, 108)
        Me.lstHistoryActual.TabIndex = 7
        Me.lstHistoryActual.Visible = False
        '
        'ReloadFileToolStripMenuItem
        '
        Me.ReloadFileToolStripMenuItem.Name = "ReloadFileToolStripMenuItem"
        Me.ReloadFileToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ReloadFileToolStripMenuItem.Text = "Reload File"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 251)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 47)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CbMdbDataSet1
        '
        Me.CbMdbDataSet1.DataSetName = "CBMdbDataSet"
        Me.CbMdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 419)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstHistoryActual)
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
        CType(Me.CbMdbDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ReplaceFindToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ReplaceWithToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents EnabledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FindTheseCharactersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReplaceWithTheseCharactersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckClipboardIntervalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PauseUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstHistoryActual As System.Windows.Forms.ListBox
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents LookupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsToToolStripComboBox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents LookupEnabledToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SaveSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LookupFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LookupFileNameToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BrowseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClipboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CbMdbDataSet1 As CBM.CBMdbDataSet

End Class
