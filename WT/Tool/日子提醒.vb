
Public Class 日子提醒

    Dim 日子正确 As Boolean = False

    Public Sub 日子提醒_Load() Handles MyBase.Load
        Dim i As Integer
        CBmonth.Items.Clear()
        CBday.Items.Clear()
        For i = 1 To 12
            CBmonth.Items.Add(i.ToString)
        Next
        For i = 1 To 31
            CBday.Items.Add(i.ToString)
        Next
        CBday.SelectedIndex = 0
        CBmonth.SelectedIndex = 0
        ListDates.Items.Clear()
        文字转列表(ListDates.Items, 读取("days"))
    End Sub

    Private Sub ButRM_Click(sender As Object, e As EventArgs) Handles ButRM.Click
        移除选中项(ListDates)
        保存("days", 列表转文字(ListDates.Items))
    End Sub

    Private Sub ListDates_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListDates.SelectedIndexChanged
        ButRM.Enabled = (ListDates.SelectedIndex >= 0)
    End Sub

    Private Sub ButADD_Click(sender As Object, e As EventArgs) Handles ButADD.Click
        Dim s As String = " " + 凑零(CBmonth.Text) + "-" + 凑零(CBday.Text) + " " + TxtJOB.Text
        If Not 在列表(ListDates.Items, s) Then ListDates.Items.Add(s)
        保存("days", 列表转文字(ListDates.Items))
        TxtJOB.Text = ""
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
        If ListDates.Items.Count < 1 Then Exit Sub
        For Each i As String In ListDates.Items
            Dim t As New Date(Year(Now), Val(Regex.Match(i, "[0-9]+-").ToString), Abs(Val(Regex.Match(i, "-[0-9]+").ToString)))
            If DateDiff(DateInterval.Day, Now.Date, t.Date) < 0 Then t = t.AddYears(1)
            Dim g As Integer = DateDiff(DateInterval.DayOfYear, Now.Date, t.Date)
            If g < 10 Then
                If g = 0 Then
                    推送("今天是：" + 去左(i, 6))
                ElseIf g = 1 Then
                    推送("明天就是：" + 去左(i, 6))
                Else
                    推送("还有 " + g.ToString + " 天就是：" + 去左(i, 6))
                End If
            End If
        Next
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
    End Sub

End Class