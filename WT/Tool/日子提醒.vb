
Public Class 日子提醒

    Dim 日子正确 As Boolean = False

    Public Sub 日子提醒_Load() Handles MyBase.Load
        If 只做一次(2) = False Then Exit Sub
        Dim i As Integer
        For i = 1 To 12
            CBmonth.Items.Add(i.ToString)
        Next
        For i = 1 To 31
            CBday.Items.Add(i.ToString)
        Next
        For i = 3 To 60
            CBremind.Items.Add(i.ToString)
        Next
        i = 设置.数字("Remindtime")
        If i < 3 OrElse i > 60 Then i = 7
        CBremind.SelectedIndex = i
        CBday.SelectedIndex = 0
        CBmonth.SelectedIndex = 0
        ListDates.Items.Clear()
        文字转列表(ListDates.Items, 设置.字符串("days"))
        提醒好日子()
        CheckPop.Checked = 设置.布林("RemindTimePop")
    End Sub

    Private Sub ButRM_Click(sender As Object, e As EventArgs) Handles ButRM.Click
        移除选中项(ListDates)
        设置.保存元素("days", 列表转文字(ListDates.Items))
        提醒好日子()
    End Sub

    Private Sub ListDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDates.SelectedIndexChanged
        ButRM.Enabled = (ListDates.SelectedIndex >= 0)
    End Sub

    Private Sub ButADD_Click(sender As Object, e As EventArgs) Handles ButADD.Click
        Dim s As String = " " + 凑零(CBmonth.Text) + "-" + 凑零(CBday.Text) + IIf(CheckCN.Checked, "n ", "  ") + TxtJOB.Text
        If Not 在列表(ListDates.Items, s) Then ListDates.Items.Add(s)
        For i As Integer = 0 To ListDates.Items.Count - 1
            If ListDates.Items.Item(i) = s Then
                ListDates.SelectedIndex = i
                Exit For
            End If
        Next
        设置.保存元素("days", 列表转文字(ListDates.Items))
        TxtJOB.Text = ""
        提醒好日子()
    End Sub

    Private Sub TxtJOB_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtJOB.KeyUp
        If ButADD.Enabled AndAlso e.KeyCode = Keys.Enter Then
            ButADD.PerformClick()
        End If
    End Sub

    Function 凑零(i As String) As String
        If i.Length < 2 Then Return "0" + i
        Return i
    End Function

    Public Sub 提醒好日子()
        Tag = ""
        If ListDates.Items.Count < 1 Then Exit Sub
        Dim ls As New ListBox, i As String, g As Integer, f As String
        For Each i In ListDates.Items
            Dim t As New Date(Year(Now), Val(Regex.Match(i, "[0-9]+-").ToString), Abs(Val(Regex.Match(i, "-[0-9]+").ToString)))
            Dim cp As Date = Now.Date
            If i(6) = "n" Then cp = 公历转农历(cp)
            If DateDiff(DateInterval.Day, cp, t.Date) < 0 Then t = t.AddYears(1)
            g = DateDiff(DateInterval.DayOfYear, cp, t.Date)
            ls.Sorted = True
            ls.Visible = False
            If g <= Val(只要数字(CBremind.SelectedItem.ToString)) Then
                f = 去左(i, 7)
                ls.Items.Add(凑零(g) & " " & f)
            End If
        Next
        For Each i In ls.Items
            g = Val(左(i, 2))
            f = 去左(i, 3)
            If g = 0 Then
                推送("今天是：" + f)
            ElseIf g = 1 Then
                推送("明天就是：" + f)
            Else
                推送("还有 " + g.ToString + " 天就是：" + f)
            End If
        Next
        ls.Dispose()
    End Sub

    Private Sub CBday_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBday.SelectedIndexChanged, CBmonth.SelectedIndexChanged, TxtJOB.TextChanged
        日子正确 = True
        Dim d As Integer = Val(CBday.Text)
        Dim m As Integer = Val(CBmonth.Text)
        Select Case d
            Case 31
                If Not 是当中一个(m, 1, 3, 5, 7, 8, 10, 12) Then 日子正确 = False
            Case > 28
                If m = 2 Then 日子正确 = False
        End Select
        ButADD.Enabled = (TxtJOB.TextLength > 0 AndAlso 日子正确)
        提醒好日子()
    End Sub

    Private Sub CBremind_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBremind.SelectedIndexChanged
        设置.保存元素("Remindtime", CBremind.SelectedIndex.ToString)
        提醒好日子()
    End Sub

    Private Sub 推送(s As String)
        非空字符串(Tag)
        If Tag.ToString.Length > 0 Then Tag += vbCrLf
        Tag += s
        If 设置.布林("RemindTimePop") = False AndAlso 只做一次(1) Then 消息(s)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim s As Integer = Val(非空字符串(Timer1.Tag))
        If s <> Today.Day Then
            Timer1.Tag = Today.Day.ToString
            提醒好日子()
        End If
    End Sub

    Private Sub CheckPop_CheckedChanged(sender As Object, e As EventArgs) Handles CheckPop.CheckedChanged
        设置.字符串("RemindTimePop") = CheckPop.Checked.ToString
    End Sub

End Class
