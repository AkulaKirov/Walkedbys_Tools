
Public Class 输入法辅助框

    Public 已经展示 As Boolean = False

    Private Sub 输入法辅助框_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListWhen.SelectedIndex = Val(设置.字符串("IMEwhen"))
        临时输入框.Show()
        临时输入框.Focus()
    End Sub

    Private Sub 输入法辅助框_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("IMEwhen") = ListWhen.SelectedIndex.ToString
    End Sub

    Private Sub Worker_Tick(sender As Object, e As EventArgs) Handles Worker.Tick
        If 后台定时器启用(ListWhen) = False Then Exit Sub
        If 已经展示 Then Exit Sub
        Dim ctrl As Boolean = False
        For i As Integer = 118 To 119
            If Input.Keyboard.IsKeyDown(i) Then
                ctrl = True
                Exit For
            End If
        Next
        If ctrl = False Then Exit Sub
        If Not Input.Keyboard.IsKeyDown(150) Then Exit Sub
        With 临时输入框
            .Show()
            .TopMost = True
            Dim x As Integer = 鼠标X - 20
            Dim y As Integer = 鼠标Y - 40
            If x < 0 Then x = 0
            If y < 0 Then y = 0
            .Left = x
            .Top = y
            .Show()
            .Focus()
            已经展示 = True
        End With
    End Sub

End Class