Public Class 快速闹钟

    Dim WantTime As Date, rings As Integer = 0

    Private Sub 快速闹钟_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtWhen.Value = 设置.数字("ClockWhen", 10)
        TxtWhat.Text = 设置.字符串("ClockText")
    End Sub

    Private Sub 快速闹钟_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("ClockText") = TxtWhat.Text
        设置.字符串("ClockWhen") = TxtWhen.Value.ToString
    End Sub

    Private Sub ButStart_Click() Handles ButStart.Click
        Dim b As Boolean = Not Timer1.Enabled
        If Not b Then
            ButStart.Text = "启动闹钟"
        Else
            WantTime = Now.AddMinutes(TxtWhen.Value)
            Timer1_Tick()
        End If
        Timer1.Enabled = b
        TxtWhen.Enabled = Not b
        TxtWhat.Enabled = Not b
    End Sub

    Private Sub Timer1_Tick() Handles Timer1.Tick
        Dim i As Integer = DateDiff(DateInterval.Second, Now, WantTime)
        ButStart.Text = "还有 " & FormatNumber(i / 60, 1) & " 分钟"
        If i < 3 Then
            ButStart_Click()
            rings = 0
            Ring.Enabled = True
            If TxtWhat.TextLength > 0 Then
                消息(TxtWhat.Text)
            End If
        End If
    End Sub

    Private Sub Ring_Tick(sender As Object, e As EventArgs) Handles Ring.Tick
        Beep()
        rings += 1
        Ring.Interval() = 随机.整数(150, 400)
        If rings >= 10 Then Ring.Enabled = False
    End Sub

End Class