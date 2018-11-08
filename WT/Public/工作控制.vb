Module 工作控制

    Private 开始工作时间 As Date, 工作线程 As Thread, 工作Panel As Panel, 日志控件 As TextBox
    Delegate Sub 委托结束工作()

    ''' <summary>
    ''' 重新确定日志的控件 
    ''' </summary>
    Public Sub 重定日志控件()
        日志控件 = 最后窗体.Controls("TxtLog")
    End Sub

    ''' <summary>
    ''' 按下开始工作的按钮，冻结Panel，然后输出日志和记录开始时间
    ''' </summary>
    Public Sub 开始工作(p As Panel, 要求steamCookie As Boolean, 线程内容 As ThreadStart)
        重定日志控件()
        清空日志()
        工作Panel = p
        中断线程(工作线程)
        If 要求steamCookie Then
            If SteamCookie.填写正确 = False Then
                日志("你的 Steam Cookie 填写不正确，请去检查。")
                Exit Sub
            End If
        End If
        p.Enabled = False
        开始工作时间 = Now
        日志("工作开始：" & 开始工作时间)
        SteamCookie.设置按钮启用(False)
        工作线程 = New Thread(线程内容)
        工作线程.Start()
        AddHandler p.FindForm.FormClosing, Sub()
                                               If p.Enabled = False Then
                                                   结束工作()
                                               End If
                                           End Sub
    End Sub

    ''' <summary>
    ''' 结束工作，不再冻结Panel，输出所用的时间
    ''' </summary>
    Public Sub 结束工作()
        Dim t As New 委托结束工作(Sub()
                                日志("工作结束：" & Now + vbCrLf + "用时：" & 时间差(Now, 开始工作时间, True))
                                中断线程(工作线程)
                                工作Panel.Enabled = True
                                SteamCookie.设置按钮启用(True)
                            End Sub)
        工作Panel.FindForm.Invoke(t)
    End Sub

    Private Sub 清空日志()
        If IsNothing(日志控件) Then Exit Sub
        日志控件.Text = ""
    End Sub

    ''' <summary>
    ''' 在当前窗体的 TxtLog 控件里写一条日志
    ''' </summary>
    Public Sub 日志(s As String)
        Dim t As TextBox = 日志控件
        If IsNothing(t) Then Exit Sub
        With t
            If .TextLength > 0 Then .Text += vbCrLf
            .Text += s
            .SelectionStart = .TextLength
            .ScrollToCaret()
        End With
    End Sub

    ''' <summary>
    ''' 根据ComboBox的选项进行timer的启用调整，
    ''' 0 只在本工具运行的时候，
    ''' 1 本软件运行的时候，
    ''' 2 现在不记录
    ''' </summary>
    Public Function 后台定时器启用(c As ComboBox) As Boolean
        Dim i As Integer = c.SelectedIndex
        If i < 0 OrElse i > 2 Then i = 0
        Select Case i
            Case 0
                Return 最后窗体.Text = c.FindForm.Text
            Case 1
                Return True
        End Select
        Return False
    End Function

End Module
