
Module 通用

    Friend 工具列表 As New List(Of 工具)
    Friend 工具收藏 As New List(Of 工具)
    Friend 版本 As String = 版本号(My.Application.Info.Version)
    Friend 设置 As New 简易XML("WT", "")
    Friend 缓存目录 As String = 程序文件目录() + "WalkedbysTemps\"
    Friend 图标 As Icon = My.Resources.ico
    Friend 最后窗体 As Form = 启动器
    Friend 启动参数 As New List(Of String)
    Friend 多线程 As New List(Of Thread)
    Private 只做一次列表 As New List(Of Integer)
    Friend 开始时间 As Date

    ''' <summary>
    ''' 开启一个新的线程并自动运行，并且会在程序结束的时候自动结束进程
    ''' </summary>
    Public Sub 新线程(start As ThreadStart)
        Dim n As New Thread(start)
        多线程.Add(n)
        n.Start()
    End Sub

    ''' <summary>
    ''' 只在第一次访问的时候返回true，然后一直是false
    ''' </summary>
    Public Function 只做一次(i As Integer) As Boolean
        If 在列表(只做一次列表, i) Then
            Return False
        Else
            只做一次列表.Add(i)
            Return True
        End If
    End Function

    ''' <summary>
    ''' 添加一个新的工具
    ''' </summary>
    Public Sub 新工具(名字 As String, 窗体 As Form, ID As String, 简介 As String, Optional 预加载 As Boolean = False)
        工具列表.Add(New 工具(名字, 窗体, ID, 简介, 预加载))
    End Sub

    ''' <summary>
    ''' 弹出一个报错框并结束程序
    ''' </summary>
    Public Sub 报错退出(s As String)
        MsgBox(s, MsgBoxStyle.Exclamation, "出错！走過去的工具箱 v" + 版本.ToString)
        Try
            启动器.Nico.Visible = False
            删除(缓存目录)
        Catch ex As Exception
        End Try
        End
    End Sub

    ''' <summary>
    ''' 通过名字或者ID来获得对应的工具
    ''' </summary>
    Public Function 名字工具(名字 As String) As 工具
        For Each t As 工具 In 工具列表
            If 包含(t.名字, 名字) OrElse 包含(t.ID.ToLower, 名字.ToLower) OrElse 包含(t.窗体.Name, 名字) Then Return t
        Next
        Return Nothing
    End Function

    ''' <summary>
    ''' 在任务栏的图标弹出一个框框
    ''' </summary>
    Public Sub 消息(s As String, Optional 警告 As Boolean = False)
        With 启动器.Nico
            .BalloonTipIcon = IIf(警告, ToolTipIcon.Warning, ToolTipIcon.Info)
            .BalloonTipText = 左(s, 30)
            .BalloonTipTitle = IIf(警告, "警告：", "通知：")
            .ShowBalloonTip(100)
        End With
    End Sub

    ''' <summary>
    ''' 隐藏或者显示到前台
    ''' </summary>
    Public Sub 最小化隐藏(sender As Form, e As EventArgs)
        Select Case sender.WindowState
            Case FormWindowState.Minimized
                If 设置.读取真假("HideWindowAtMin") Then 隐藏到后台(sender)
            Case FormWindowState.Normal
                显示到前台(sender)
        End Select
    End Sub

    ''' <summary>
    ''' 把窗体隐藏并且不显示在任务栏里
    ''' </summary>
    Public Sub 隐藏到后台(sender As Form)
        With sender
            .ShowInTaskbar = False
            .Hide()
        End With
    End Sub

    ''' <summary>
    ''' 显示到前台和任务栏
    ''' </summary>
    Public Sub 显示到前台(sender As Form)
        With sender
            .ShowInTaskbar = True
            .TopMost = True
            .Show()
            .WindowState = FormWindowState.Normal
            .TopMost = False
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
                Return (最后窗体.Text = c.FindForm.Text)
            Case 1
                Return True
        End Select
        Return False
    End Function

    ''' <summary>
    ''' 把窗体和控件的配色调整到和启动器一样的配色
    ''' </summary>
    Public Sub 配色(c As Control)
        Dim bc As Color = 启动器.BackColor
        Dim fc As Color = 启动器.ForeColor
        c.BackColor = bc
        c.ForeColor = fc
        c.TabStop = False
        If c.HasChildren Then
            For Each i As Control In c.Controls
                配色(i)
            Next
        End If
    End Sub

    ''' <summary>
    ''' 确认这个groupbox里的steamcookie是否填写正确
    ''' </summary>
    Private Function 检测steamCookie() As Boolean
        Dim s As String = Trim(设置.元素("SteamSession"))
        If s.Length = 24 Then
            s = Trim(设置.元素("SteamLoginSecure"))
            If s.Length = 63 Then
                If Regex.IsMatch(s, "765611[0-9]{11}%.{2}%.+") Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function

    ''' <summary>
    ''' 需要一个标准的steamcookie填写groupbox，然后在修改cookie的时候会呼唤起方法
    ''' </summary>
    Public Sub 填写steamCookie(g As GroupBox, Optional 方法 As ThreadStart = Nothing)
        g.Tag = False
        Dim t As TextBox = g.Controls("TxtSession")
        AddHandler t.TextChanged, Sub()
                                      设置.元素("SteamSession") = Trim(t.Text)
                                      g.Tag = 检测steamCookie()
                                      If Not IsNothing(方法) Then
                                          方法.Invoke
                                      End If
                                  End Sub
        Dim t2 As TextBox = g.Controls("TxtLoginSecure")
        AddHandler t2.TextChanged, Sub()
                                       设置.元素("SteamLoginSecure") = Trim(t2.Text)
                                       g.Tag = 检测steamCookie()
                                       If Not IsNothing(方法) Then
                                           方法.Invoke
                                       End If
                                   End Sub
        Dim b As Button = g.Controls("ButHowToGetCookie")
        AddHandler b.Click, Sub()
                                Process.Start("https://s1.ax1x.com/2018/09/20/inFtrq.png")
                            End Sub
        t2.Text = 设置.元素("SteamLoginSecure")
        t.Text = 设置.元素("SteamSession")
    End Sub

    ''' <summary>
    ''' 输出steamcookie的完整形式
    ''' </summary>
    Public Function 输出steamCookie() As String
        If 检测steamCookie() Then
            Return "steamLoginSecure=" + 设置.元素("SteamLoginSecure") + "; sessionid=" + 设置.元素("SteamSession")
        Else
            Return ""
        End If
    End Function

    Public Class 工具

        Public Property 名字 As String
        Public Property 简介 As String
        Public Property 窗体 As Form
        Public Property ID As String
        Public Property 启动过了 As Boolean

        Public Sub New(name As String, win As Form, 内部id As String, description As String, 预加载 As Boolean)
            名字 = name
            窗体 = win
            启动过了 = False
            简介 = description
            ID = 内部id
            With 窗体
                AddHandler .Activated, Sub()
                                           启动过了 = True
                                           配色(窗体)
                                       End Sub
                .Icon = 图标
                .ImeMode = 启动器.ImeMode
                .Font = 启动器.Font
                .ShowInTaskbar = True
                .MaximizeBox = False
                .AutoScaleMode = AutoScaleMode.Dpi
                If 预加载 Then
                    .StartPosition = FormStartPosition.Manual
                    .ShowInTaskbar = False
                    .Top = My.Computer.Screen.Bounds.Height + 100
                    .Show()
                    .Hide()
                End If
                AddHandler .FormClosing, Sub(sender As Object, e As FormClosingEventArgs)
                                             e.Cancel = True
                                             .Hide()
                                             .ShowInTaskbar = False
                                             启动器.Location = .Location
                                             启动器.WindowState = FormWindowState.Normal
                                             启动器.Show()
                                             启动器.Location = .Location
                                             最后窗体 = 启动器
                                             最后窗体.ShowInTaskbar = True
                                         End Sub
                AddHandler .SizeChanged, AddressOf 最小化隐藏
            End With
        End Sub

        Public Sub 启动()
            最后窗体.Hide()
            显示到前台(窗体)
            窗体.Location = 最后窗体.Location
            最后窗体 = 窗体
        End Sub

        Public Overrides Function ToString() As String
            Return ID
        End Function

        Public ReadOnly Property 推送 As String
            Get
                If IsNothing(窗体.Tag) Then Return ""
                Return 非空字符串(窗体.Tag.ToString)
            End Get
        End Property

    End Class

    Public Class 模板组

        Dim n As String, g As New List(Of 模板)
        Dim 列表 As ComboBox, 文本框 As TextBox, 新增按纽 As Button, 移除按纽 As Button

        Public Sub New(名字 As String, 列表控件 As ComboBox, 文本控件 As TextBox, 新增 As Button, 移除 As Button)
            n = "模板组___" + 名字
            Dim x As New 简易XML(n, 设置.元素(n))
            列表 = 列表控件
            文本框 = 文本控件
            文本框.MaxLength = 10
            新增按纽 = 新增
            移除按纽 = 移除
            新增按纽.Enabled = False
            移除按纽.Enabled = False
            AddHandler 列表.SelectedIndexChanged, AddressOf 刷新
            AddHandler 文本框.TextChanged, AddressOf 刷新
            AddHandler 移除按纽.Click, Sub()
                                       移除列表选中项()
                                       刷新()
                                   End Sub
            AddHandler 移除按纽.FindForm.FormClosing, AddressOf 保存
            Dim f As List(Of String) = 分割(设置.元素(n + "列表"), vbCrLf)
            Dim t As 模板
            If f.Count > 0 Then
                For Each i As String In f
                    If i.Length > 0 Then
                        t = New 模板(i)
                        t.读取(x.元素(i))
                        g.Add(t)
                    End If
                Next
            End If
            列表.Items.Clear()
            If g.Count > 0 Then
                For Each t In g
                    列表.Items.Add(t.名字)
                Next
            End If
        End Sub

        Public Sub 刷新()
            Dim name As String = Trim(文本框.Text)
            新增按纽.Enabled = (name.Length > 0 AndAlso name.Length < 11 AndAlso Not 在列表(列表.Items, name))
            Dim i As Integer = 列表.SelectedIndex
            Dim b As Boolean = (i > -1)
            移除按纽.Enabled = b
        End Sub

        Public Sub 新增(s As 模板)
            g.Add(s)
            列表.Items.Add(s.名字)
            列表.SelectedItem = s.名字
            文本框.Text = ""
            刷新()
            保存()
        End Sub

        Public Function 读取当前项() As 模板
            If 列表.SelectedIndex < 0 Then Return Nothing
            Dim i As String = 列表.SelectedItem.ToString
            If i.Length < 1 OrElse g.Count < 1 Then Return Nothing
            Return 获得模板(i)
        End Function

        Public Sub 移除列表选中项()
            If 列表.SelectedIndex < 0 Then Exit Sub
            If g.Count < 1 Then Exit Sub
            Dim t As 模板 = 读取当前项()
            移除选中项(列表)
            g.Remove(t)
            刷新()
            保存()
        End Sub

        Public Overrides Function ToString() As String
            Dim s As String = ""
            If g.Count > 0 Then
                For Each t As 模板 In g
                    s += t.ToString
                Next
            End If
            Return s
        End Function

        Public Sub 保存()
            设置.元素(n + "列表") = 列表转文字(列表.Items)
            设置.元素(n) = ToString()
        End Sub

        Public ReadOnly Property 模板列表 As List(Of 模板)
            Get
                Return g
            End Get
        End Property

        Public Function 获得模板(name As String) As 模板
            Dim t As 模板
            For Each t In g
                If t.名字 = name Then
                    Return t
                End If
            Next
            Return Nothing
        End Function

    End Class

    Public Class 模板

        Dim n As 简易XML
        Public Property 名字 As String

        Public Sub New(name As String)
            名字 = name
            n = New 简易XML(名字)
        End Sub

        Public Sub 读取(s As String)
            n.全文本 = s
        End Sub

        Public Property 元素(name As String) As String
            Get
                Return n.元素(name)
            End Get
            Set(value As String)
                n.元素(name) = value
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return n.ToString
        End Function

        Public Function 读取真假(name As String) As Boolean
            Return n.读取真假(name)
        End Function

        Public Function 读取数(name As String) As Double
            Return n.读取数(name)
        End Function

    End Class

End Module
