
Public Class 临时输入框

    Private Sub TxtIN_TextChanged(sender As Object, e As EventArgs) Handles TxtIN.TextChanged
        Text = "按回车结束，字数：" + TxtIN.TextLength.ToString + "/" + TxtIN.MaxLength.ToString
    End Sub

    Private Sub 临时输入框_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = 13 Then
            Dim s As String = 去回车(TxtIN.Text)
            TxtIN.Text = ""
            输入法辅助框.已经展示 = False
            Top = -500
            Hide()
            SendKeys.Send(s)
        ElseIf e.KeyCode = Keys.Escape Then
            TxtIN.Text = ""
            输入法辅助框.已经展示 = False
            Top = -500
            Hide()
        End If
    End Sub

    Private Sub 临时输入框_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        输入法辅助框.已经展示 = False
        Top = -500
        Hide()
    End Sub

End Class