
Module 通用

    Friend 工具列表 As New List(Of 工具)
    Friend 版本 As String = 版本号(My.Application.Info.Version)
    Friend 设置 As WBC文件
    Friend 缓存目录 As String = 程序文件目录() + "WalkedbysTemps\"
    Friend 备份目录 As String = 追加斜杠(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)) + "wt_save_backup\"
    Friend 图标 As Icon = My.Resources.ico
    Friend 最后窗体 As Form = 启动器
    Friend 启动参数 As New List(Of String)
    Friend 多线程 As New List(Of Thread)
    Friend 开发中 As Boolean = 程序运行中("devenv")
    Private 只做一次列表 As New List(Of UInteger)

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
    Public Function 只做一次(i As UInteger) As Boolean
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
    Public Sub 新工具(名字 As String, 窗体 As Form, id As String, 简介 As String, Optional 预加载 As Boolean = False)
        工具列表.Add(New 工具(名字, 窗体, id, 简介, 预加载))
    End Sub

    ''' <summary>
    ''' 弹出一个报错框并结束程序
    ''' </summary>
    Public Sub 报错退出(s As String)
        MsgBox(s, MsgBoxStyle.Critical, "出错！走過去的工具箱 v" + 版本.ToString)
        Try
            启动器.Nico.Visible = False
            If Process.GetProcessesByName("wt").Count = 1 Then 删除(缓存目录)
        Catch ex As Exception
            Dp("报错退出失败：", ex.Message)
        End Try
        End
    End Sub

    ''' <summary>
    ''' 通过名字或者ID来获取对应的工具
    ''' </summary>
    Public Function 名字工具(名字 As String) As 工具
        名字 = Trim(名字)
        If 名字.Length < 1 Then Return Nothing
        For Each t As 工具 In 工具列表
            If 包含(t.名字, 名字) OrElse 包含(t.ID.ToLower, 名字.ToLower) OrElse 包含(t.窗体.Name, 名字) Then Return t
        Next
        Return Nothing
    End Function

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

    ''' <summary>
    ''' 在任务栏的图标弹出一个框框
    ''' </summary>
    Public Sub 消息气泡(s As String, Optional 警告 As Boolean = False)
        With 启动器.Nico
            .BalloonTipIcon = IIf(警告, ToolTipIcon.Warning, ToolTipIcon.Info)
            .BalloonTipText = 左(s, 30)
            .BalloonTipTitle = IIf(警告, "警告：", "通知：")
            .ShowBalloonTip(10000)
        End With
    End Sub

    ''' <summary>
    ''' 隐藏或者显示到前台
    ''' </summary>
    Public Sub 最小化隐藏(sender As Form, e As EventArgs)
        Select Case sender.WindowState
            Case FormWindowState.Minimized
                If 设置.布林("HideWindowAtMin") Then 隐藏到后台(sender)
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
    ''' 把窗体和控件的配色调整到和启动器一样的配色
    ''' </summary>
    Public Sub 配色(c As Control)
        Dim bc As Color = 启动器.BackColor
        Dim fc As Color = 启动器.ForeColor
        c.BackColor = bc
        c.ForeColor = fc
        c.TabStop = False
        If 控件类型(c) = "button" Then
            Dim b As Button = c
            b.FlatStyle = FlatStyle.System
        End If
        If c.HasChildren Then
            For Each i As Control In c.Controls
                配色(i)
            Next
        End If
    End Sub

    Public Class 工具

        Public Property 名字 As String
        Public Property 简介 As String
        Public Property 窗体 As Form
        Public Property 启动过了 As Boolean
        Public Property ID As String

        Public Sub New(name As String, win As Form, 内部id As String, description As String, 预加载 As Boolean)
            名字 = name
            窗体 = win
            ID = 内部id
            启动过了 = False
            简介 = description
            控件DPI修正(窗体)
            With 窗体
                AddHandler .Activated, Sub()
                                           启动过了 = True
                                           配色(窗体)
                                       End Sub
                .Icon = 图标
                .ImeMode = 启动器.ImeMode
                .Font = 启动器.Font
                .ShowInTaskbar = True
                .KeyPreview = True
                .MaximizeBox = False
                .AutoScaleMode = AutoScaleMode.None
                .FormBorderStyle = FormBorderStyle.Fixed3D
                .StartPosition = FormStartPosition.Manual
                If 预加载 Then
                    .Top = -4399
                    .Show()
                    .Hide()
                End If
                AddHandler .FormClosing, Sub(sender As Object, e As FormClosingEventArgs)
                                             e.Cancel = True
                                             .Hide()
                                             启动器.Location = .Location
                                             启动器.WindowState = FormWindowState.Normal
                                             启动器.Show()
                                             启动器.Location = .Location
                                             最后窗体 = 启动器
                                             启动器.切换蜜汁语句()
                                         End Sub
                AddHandler .SizeChanged, AddressOf 最小化隐藏
                CtrlW关闭(窗体)
            End With
        End Sub

        Public Sub 启动()
            If 最后窗体.Text = 窗体.Text Then Exit Sub
            If 最后窗体.Text <> 启动器.Text Then
                最后窗体.Close()
            End If
            显示到前台(窗体)
            启动器.Hide()
            窗体.Location = 最后窗体.Location
            最后窗体 = 窗体
        End Sub

        Public Property 推送 As String
            Set(内容 As String)
                窗体.Tag = 内容

            End Set
            Get
                If IsNothing(窗体.Tag) Then Return ""
                Return 非空字符串(窗体.Tag.ToString)
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return ID
        End Function

    End Class

    ''' <summary>
    ''' 给最后窗体的 txtlog 控件追加日志
    ''' </summary>
    Public Sub 日志(内容 As String)
        Dim txtlog As TextBox = 最后窗体.Controls("TxtLog")
        If IsNothing(txtlog) Then Exit Sub
        With txtlog
            If .TextLength > 0 Then .Text += vbCrLf
            .Text += 内容
            .SelectionStart = .TextLength
            .ScrollToCaret()
        End With
    End Sub

End Module
