Option Explicit On

Public Class frmMain

    Dim UpdateClipboard As Boolean 'When true, update the clipboad with new data before refreshing

    Private Sub tmrCheckClipboard_Tick(sender As Object, e As EventArgs) Handles tmrCheckClipboard.Tick
        'If the filtered clipboard doesn't equal the displayed clipboard, update.
        If Not txtCur.Text = ApplyFilter(Clipboard.GetText, , False) Then
            txtCur.Text = ApplyFilter(Clipboard.GetText)
            addHistory(txtCur.Text)
        End If

    End Sub

    Private Sub txtCur_Click(sender As Object, e As EventArgs) Handles txtCur.Click
        UpdateLengthMenu()
    End Sub

    Private Sub UpdateLengthMenu()
        'Update the text of the length menu
        mnuLength.Text = "C=" & txtCur.SelectionStart & " L=" & Len(txtCur.Text)
    End Sub

    Private Sub txtCur_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCur.KeyDown
        tmrCheckClipboard.Enabled = False 'reset the update time when a keypress happens
        tmrRestartCheckClipboard.Enabled = False 'toggle the restart timer.
        tmrRestartCheckClipboard.Enabled = True 'Count down to reenable the clipboard checking timer
        UpdateClipboard = True 'Update the clipboard when keypresses stop or the box loses focus

    End Sub

    Private Sub txtCur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCur.KeyPress
        'tmrCheckClipboard.Enabled = False 'reset the update time when a keypress happens
        'tmrRestartCheckClipboard.Enabled = True 'Count down to reenable the clipboard checking timer
        'UpdateClipboard = True 'Update the clipboard when keypresses stop or the box loses focus
    End Sub

    Private Sub txtCur_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCur.KeyUp
        UpdateLengthMenu()
    End Sub

    Private Sub UpdateStatusMenu()
        Dim NewStatus As String = ""

        If F1ToolStripMenuItem.Checked Then
            'Trim Spaces
            NewStatus = NewStatus & "_;"
        End If

        If F2ToolStripMenuItem.Checked Then
            'Leading Zeros
            NewStatus = NewStatus & "0;"
        End If

        If UCASEToolStripMenuItem.Checked Then
            'Upper
            NewStatus = NewStatus & "U;"
        End If

        If LCaseToolStripMenuItem.Checked Then
            'Lower
            NewStatus = NewStatus & "l;"
        End If

        If PCaseToolStripMenuItem.Checked Then
            'Proper
            NewStatus = NewStatus & "P;"
        End If

        If F4ToolStripMenuItem.Checked Then
            'Replace Characters
            NewStatus = NewStatus & "R;"
        End If

        'Update the status, if changed
        If mnuStatus.Text <> NewStatus Then mnuStatus.Text = NewStatus
    End Sub

    Private Sub txtCur_LostFocus(sender As Object, e As EventArgs) Handles txtCur.LostFocus
        'If the user has changed what's on the clipboard, update it before reenabling
        DoUpdateClipboard(txtCur.Text)

    End Sub

    Private Sub DoUpdateClipboard(NewText As String)
        If UpdateClipboard Then
            If NewText = "" Then
                Clipboard.Clear()
            Else
                If NewText <> Clipboard.GetText Then
                    'Update the clipboard if it's changed
                    Clipboard.SetText(NewText)
                    txtCur.Text = NewText
                    addHistory(NewText)
                End If

            End If
            UpdateClipboard = False
        End If
    End Sub

    Private Sub txtCur_TextChanged(sender As Object, e As EventArgs) Handles txtCur.TextChanged
        'If the checker timer is disabled, update the clipboard.
        If tmrCheckClipboard.Enabled = False Then UpdateClipboard = True
        UpdateLengthMenu()

    End Sub

    Private Sub tmrRestartCheckClipboard_Tick(sender As Object, e As EventArgs) Handles tmrRestartCheckClipboard.Tick
        'If the user has changed what's on the clipboard, update it before reenabling
        DoUpdateClipboard(txtCur.Text)
        'Restart the Clipboard checker
        tmrCheckClipboard.Enabled = True
        tmrRestartCheckClipboard.Enabled = False
    End Sub

    Private Sub FilterClipboard()
        'Apply filters to the current clipboard data

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        UpdateClipboard = False
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Hold the size of the form less the title bar
        Dim MeHeight As Integer = Me.Height - SystemInformation.CaptionHeight - MenuStrip1.Height
        Dim MeWidth As Integer = Me.Width - SystemInformation.Border3DSize.Width

        'When the form resizes, change the size of the boxes
        With txtUL
            .Width = MeWidth / 2
            .Height = MeHeight / 3
            .Left = 0
            .Top = MenuStrip1.Height
        End With
        With txtUR
            .Width = MeWidth / 2
            .Height = MeHeight / 3
            .Left = MeWidth / 2
            .Top = MenuStrip1.Height
        End With
        With txtLL
            .Width = MeWidth / 2
            .Height = MeHeight / 3
            .Left = 0
            .Top = MeHeight / 3 + MenuStrip1.Height
        End With
        With txtLR
            .Width = MeWidth / 2
            .Height = MeHeight / 3
            .Left = MeWidth / 2
            .Top = MeHeight / 3 + MenuStrip1.Height
        End With
        With lstHistory
            .Width = MeWidth / 2
            .Height = MeHeight / 3
            .Left = 0
            .Top = MeHeight / 3 * 2 + MenuStrip1.Height
        End With
        With txtCur
            .Width = MeWidth / 2
            .Height = MeHeight / 3
            .Left = MeWidth / 2
            .Top = MeHeight / 3 * 2 + MenuStrip1.Height
        End With
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AnotherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnotherToolStripMenuItem.Click
        txtUL.Text = txtCur.Text
    End Sub

    Private Sub F1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F1ToolStripMenuItem.Click
        'Trim the spaces from each end of the text
        txtCur.Text = ApplyFilter(txtCur.Text)


    End Sub
    Private Function ApplyFilter(CurText As String, Optional FilterType As String = "", Optional UpdateClipboardAfter As Boolean = True) As String
        tmrCheckClipboard.Enabled = False 'Stop checking the clipboard during the filter stage

        If F1ToolStripMenuItem.Checked Then
            'Trim the spaces from each end of the text
            If CurText <> Trim(CurText) Then
                UpdateClipboard = True
                CurText = Trim(CurText)
            End If
        End If

        If F2ToolStripMenuItem.Checked Then
            'If the menu item is checked, remove the leading zeros if applicable
            If Len(CurText) = 10 Then
                If Mid(CurText, 1, 4) = "0000" Then
                    '0000xxxxxx -> xxxxxx
                    UpdateClipboard = True
                    CurText = Mid(CurText, 5, 6)
                End If
                If Mid(CurText, 1, 3) = "000" Then
                    '000xxxxxxx -> xxxxxxx
                    UpdateClipboard = True
                    CurText = Mid(CurText, 4, 6)
                End If
            End If
        End If

        If UCASEToolStripMenuItem.Checked Then
            'Convert to all upper case
            CurText = UCase(CurText)
        End If

        If LCaseToolStripMenuItem.Checked Then
            'Convert to all lower case
            CurText = LCase(CurText)
        End If

        If PCaseToolStripMenuItem.Checked Then
            'Convert to all Proper Case, if length is greater than 0
            Dim NewText As String = CurText
            If Len(NewText) > 0 Then
                'First make everything lower
                NewText = LCase(NewText)
                'Make the first character uppercase
                Mid(NewText, 1, 1) = UCase(Mid(NewText, 1, 1))
                'Then make everything following a space upper
                Dim n As Integer
                n = 0 'Start at the beginning
                Do Until n >= Len(NewText) 'Exit if it gets to the end
                    'Find the next space
                    n = InStr(n + 1, NewText, " ")
                    If n = 0 Then Exit Do 'Exit if it doesn't find anything 
                    'Capitalize the next character, if there is one
                    If n < Len(NewText) Then
                        Mid(NewText, n + 1, 1) = UCase(Mid(NewText, n + 1, 1))
                    End If
                Loop
            End If
            If NewText <> CurText Then
                'If there have been changes, update.
                UpdateClipboard = True
                CurText = NewText
            End If
        End If

        ApplyFilter = CurText 'Return the filtered text 
        If UpdateClipboard Then
            If UpdateClipboardAfter Then
                DoUpdateClipboard(CurText) 'Unless specifically disabled, update the clipboad with the next text
            End If
        End If
        UpdateStatusMenu()
        tmrCheckClipboard.Enabled = True
    End Function

    Private Sub F2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F2ToolStripMenuItem.Click
        'Remove leading zeros for account numbers
        txtCur.Text = ApplyFilter(txtCur.Text)
    End Sub

    Private Sub UCASEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UCASEToolStripMenuItem.Click
        'Toggle Convert to all Upper Case
        With UCASEToolStripMenuItem
            If .Checked Then
                .Checked = False
                F3ToolStripMenuItem.Checked = False
            Else
                .Checked = True
                F3ToolStripMenuItem.Checked = True
                PCaseToolStripMenuItem.Checked = False
                LCaseToolStripMenuItem.Checked = False
            End If
        End With
        txtCur.Text = ApplyFilter(txtCur.Text)
    End Sub

    Private Sub LCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LCaseToolStripMenuItem.Click
        'Toggle Convert to all Upper Case
        With LCASEToolStripMenuItem
            If .Checked Then
                .Checked = False
                F3ToolStripMenuItem.Checked = False
            Else
                .Checked = True
                F3ToolStripMenuItem.Checked = True
                UCASEToolStripMenuItem.Checked = False
                PCaseToolStripMenuItem.Checked = False
            End If
        End With
        txtCur.Text = ApplyFilter(txtCur.Text)
    End Sub

    Private Sub PCaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PCaseToolStripMenuItem.Click
        'Toggle Convert to all Upper Case
        With PCaseToolStripMenuItem
            If .Checked Then
                .Checked = False
                F3ToolStripMenuItem.Checked = False
            Else
                .Checked = True
                F3ToolStripMenuItem.Checked = True
                UCASEToolStripMenuItem.Checked = False
                LCaseToolStripMenuItem.Checked = False
            End If
        End With
        txtCur.Text = ApplyFilter(txtCur.Text)
    End Sub

    Private Sub mnuStatus_Click(sender As Object, e As EventArgs) Handles mnuStatus.Click
        'Uncheck all filters
        F1ToolStripMenuItem.Checked = False
        F2ToolStripMenuItem.Checked = False
        F3ToolStripMenuItem.Checked = False
        F4ToolStripMenuItem.Checked = False
        UCASEToolStripMenuItem.Checked = False
        LCaseToolStripMenuItem.Checked = False
        PCaseToolStripMenuItem.Checked = False

        UpdateStatusMenu()

    End Sub


    Private Sub FromULToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromULToolStripMenuItem.Click
        'Copy from Upper Left box to the clipboard
        UpdateClipboard = True
        ApplyFilter(txtUL.Text)
    End Sub

    Private Sub FromURToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromURToolStripMenuItem.Click
        'Copy from Upper Right box to the clipboard
        UpdateClipboard = True
        ApplyFilter(txtUR.Text)
    End Sub

    Private Sub FromLLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromLLToolStripMenuItem.Click
        'Copy from Lower Left box to the clipboard
        UpdateClipboard = True
        ApplyFilter(txtLL.Text)
    End Sub

    Private Sub FromLRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromLRToolStripMenuItem.Click
        'Copy from Lower Right box to the clipboard
        UpdateClipboard = True
        ApplyFilter(txtLR.Text)
    End Sub

    Private Sub ToURToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToURToolStripMenuItem.Click
        'Replace Upper right box with the current clipboard text
        txtUR.Text = txtCur.Text
    End Sub

    Private Sub ToLLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToLLToolStripMenuItem.Click
        'Replace Lower Left box with the current clipboard text
        txtLL.Text = txtCur.Text
    End Sub

    Private Sub ToLRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToLRToolStripMenuItem.Click
        'Replace Lower right box with the current clipboard text
        txtLR.Text = txtCur.Text
    End Sub

    Private Sub ClearULToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearULToolStripMenuItem.Click
        'Clear the upper left box
        txtUL.Text = ""
    End Sub

    Private Sub ClearURToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearURToolStripMenuItem.Click
        'Clear the upper left box
        txtUR.Text = ""
    End Sub

    Private Sub ClearLLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearLLToolStripMenuItem.Click
        'Clear the upper left box
        txtLL.Text = ""
    End Sub

    Private Sub ClearLRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearLRToolStripMenuItem.Click
        'Clear the upper left box
        txtLR.Text = ""
    End Sub

    Private Sub addHistory(NewHist As String)
        'Add the NewHist to the history list. 
        'If duplicate, move it to the top
        'Replace vbCrLf with | for the display

        Dim NewDisplay As String 'Holds the data to display in the list.

        Debug.Print("addHistory" & TimeOfDay)

        NewDisplay = Replace(NewHist, vbCrLf, "|")

        'The item is already in History. Remove it so it's not a dup when it moves to the top
        If lstHistoryActual.Items.Contains(NewHist) Then
            lstHistory.Items.Remove(NewDisplay)
            lstHistoryActual.Items.Remove(NewHist)
        End If

        lstHistory.Items.Insert(0, NewDisplay)
        lstHistoryActual.Items.Insert(0, NewHist)
    End Sub

    Private Sub AddToHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToHistoryToolStripMenuItem.Click
        addHistory(txtCur.Text)
    End Sub

    Private Sub lstHistory_DoubleClick(sender As Object, e As EventArgs) Handles lstHistory.DoubleClick
        'When the user double clicks on a displayed history item, add the actual data to the clipboard
        UpdateClipboard = True
        DoUpdateClipboard(lstHistoryActual.Items.Item(lstHistory.SelectedIndex))
    End Sub

    Private Sub CheckClipboard1000msToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckClipboardIntervalToolStripMenuItem.Click

    End Sub



    Private Sub ToolStripTextBox3_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox3.TextChanged
        On Error GoTo errh
        'Set the interval for the clipboard check timer
        If (ToolStripTextBox3.Text <> "") Then
            tmrCheckClipboard.Interval = CType(ToolStripTextBox3.Text, Double)
        End If
        CheckClipboardIntervalToolStripMenuItem.Text = "Check Clipboard Interval (" & tmrCheckClipboard.Interval.ToString & "ms)"

        Exit Sub
errh:
        Debug.Print("ToolStripTextBox3_TextChanged " & Err.Number.ToString & " " & Err.Description)
        'Invalid non numeric entry or overflow in the text box. Just exit w/o updating
        If Err.Number = 13 Or Err.Number = 6 Then Exit Sub
        Stop
        Resume
    End Sub

    Private Sub ToolStripTextBox4_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox4.TextChanged
        On Error GoTo errh
        'Set the interval for the restart clipboard check timer
        If (ToolStripTextBox3.Text <> "") Then
            tmrRestartCheckClipboard.Interval = CType(ToolStripTextBox4.Text, Double)
        End If
        PauseUpdatesToolStripMenuItem.Text = "Pause Updates Interval (" & tmrRestartCheckClipboard.Interval.ToString & "ms)"

        Exit Sub
errh:
        Debug.Print("ToolStripTextBox4_TextChanged " & Err.Number.ToString & " " & Err.Description)
        'Invalid, non numeric entry in the text box. Just exit w/o updating
        If Err.Number = 13 Or Err.Number = 6 Then Exit Sub
        Stop
        Resume
    End Sub
End Class

