Option Explicit On

Public Class Form1

    Dim UpdateClipboard As Boolean 'When true, update the clipboad with new data before refreshing

    Private Sub tmrCheckClipboard_Tick(sender As Object, e As EventArgs) Handles tmrCheckClipboard.Tick
        If Not txtCur.Text = Clipboard.GetText Then txtCur.Text = Clipboard.GetText
    End Sub

    Private Sub txtCur_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCur.KeyDown
        tmrCheckClipboard.Enabled = False 'reset the update time when a keypress happens
        tmrRestartCheckClipboard.Enabled = True 'Count down to reenable the clipboard checking timer
        UpdateClipboard = True 'Update the clipboard when keypresses stop or the box loses focus
    End Sub

    Private Sub txtCur_LostFocus(sender As Object, e As EventArgs) Handles txtCur.LostFocus
        'If the user has changed what's on the clipboard, update it before reenabling
        If UpdateClipboard Then
            If txtCur.Text = "" Then
                Clipboard.Clear()
            Else
                Clipboard.SetText(txtCur.Text)
            End If
            UpdateClipboard = False
        End If
    End Sub



    Private Sub txtCur_TextChanged(sender As Object, e As EventArgs) Handles txtCur.TextChanged
        'If the checker timer is disabled, update the clipboard.
        If tmrCheckClipboard.Enabled = False Then UpdateClipboard = True
        
    End Sub

    Private Sub tmrRestartCheckClipboard_Tick(sender As Object, e As EventArgs) Handles tmrRestartCheckClipboard.Tick
        'If the user has changed what's on the clipboard, update it before reenabling
        If UpdateClipboard Then
            If txtCur.Text = "" Then
                Clipboard.Clear()
            Else
                Clipboard.SetText(txtCur.Text)
            End If
            UpdateClipboard = False
        End If
        'Restart the Clipboard checker
        tmrCheckClipboard.Enabled = True
        tmrRestartCheckClipboard.Enabled = False
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
End Class
