
''' <summary>
''' 工具内使用的多线程工作简易操作类
''' </summary>
Public Class 工作

    Private 窗体 As Form, 日志控件 As TextBox, 线程 As Thread, 工作Panel As Panel, 要求SteamCookie As Boolean
    Private Delegate Sub 委托结束工作()
    Private 开始时间 As Date, 冷却中 As Boolean, 冷却时长 As Integer

    Public Sub New(工作Panel As Panel, Optional 要求steamCookie As Boolean = False, Optional 冷却时长 As Integer = 5)
        窗体 = 工作Panel.FindForm
        Me.工作Panel = 工作Panel
        Me.要求SteamCookie = 要求steamCookie
        Me.冷却时长 = 冷却时长
        日志控件 = 窗体.Controls("TxtLog")
        冷却中 = False
        AddHandler 窗体.FormClosing, Sub()
                                       If 工作Panel.Enabled = False Then
                                           结束()
                                       End If
                                   End Sub
    End Sub

    Public Sub 开始(线程内容 As ThreadStart)
        清空日志()
        中断线程(线程)
        If 要求SteamCookie Then
            If SteamCookie.填写正确 = False Then
                日志("你的 Steam Cookie 填写不正确，请去检查。")
                Exit Sub
            End If
        End If
        开始时间 = Now
        设置工作界面(False)
        日志("工作开始：" & 开始时间)
        线程 = New Thread(线程内容)
        线程.Start()
    End Sub

    Public Sub 日志(内容 As String)
        If IsNothing(日志控件) Then Exit Sub
        With 日志控件
            If .TextLength > 0 Then .Text += vbCrLf
            .Text += 内容
            .SelectionStart = .TextLength
            .ScrollToCaret()
        End With
    End Sub

    Public Sub 清空日志()
        If IsNothing(日志控件) Then Exit Sub
        日志控件.Text = ""
    End Sub

    Public Sub 结束()
        窗体.Invoke(New 委托结束工作(Sub()
                                 日志("工作结束：" & Now + vbCrLf + "用时：" & 时间差(Now, 开始时间, True))
                                 中断线程(线程)
                                 If 冷却时长 > 0 AndAlso 冷却中 = False Then
                                     Dim th As New Thread(Sub()
                                                              冷却中 = True
                                                              Thread.Sleep(冷却时长 * 1000)
                                                              冷却中 = False
                                                              设置工作界面(True)
                                                          End Sub)
                                     th.Start()
                                 Else
                                     设置工作界面(True)
                                 End If
                             End Sub))
    End Sub

    Private Sub 设置工作界面(启用 As Boolean)
        工作Panel.Enabled = 启用
        SteamCookie.设置按钮启用(启用)
    End Sub

End Class
