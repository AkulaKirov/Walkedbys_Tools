
Module 通用

    Friend 工具列表 As New List(Of 工具)
    Public Sets As New 简易CFG(程序文件目录() + "WalkedbySaves.cfg")
    Public TempF As String = 程序文件目录() + "WalkedbysTemps\"
    Public 图标 As Icon = My.Resources.ico
    Public 最后窗体 As Form = 启动器
    Public Delegate Sub 委托推送(m As String)
    Public 启动参数 As New List(Of String)

    Public Function ID工具(id As String) As 工具
        For Each t As 工具 In 工具列表
            If t.ID.ToLower = id.ToLower Then Return t
        Next
        Return Nothing
    End Function

    Public Sub 保存(节点 As String, 内容 As String)
        Sets.节点(节点) = 内容
    End Sub

    Public Function 读取(节点 As String) As String
        Return Sets.节点(节点)
    End Function

    Public Sub 推送(m As String)
        With 启动器.TxtUpdate
            If .TextLength > 1 Then .Text += vbCrLf
            .Text += m
        End With
    End Sub

    Public Sub 最小化隐藏(sender As Object, e As EventArgs)
        If sender.WindowState = FormWindowState.Minimized Then
            sender.WindowState = FormWindowState.Normal
            sender.Hide()
        End If
    End Sub

    Public Class 工具

        Public Property 名字 As String
        Public Property 简介 As String
        Public Property 窗体 As Form
        Public Property ID As String

        Public Sub New(name As String, win As Form, 内部id As String, description As String)
            名字 = name
            窗体 = win
            简介 = description
            ID = 内部id
            窗体.Icon = 图标
            窗体.ImeMode = ImeMode.Off
            窗体.ShowInTaskbar = False
            窗体.AutoScaleMode = AutoScaleMode.Dpi
            AddHandler 窗体.FormClosing, Sub(sender As Object, e As FormClosingEventArgs)
                                           e.Cancel = True
                                           窗体.Hide()
                                           启动器.Location = 窗体.Location
                                           启动器.WindowState = FormWindowState.Normal
                                           启动器.Show()
                                           启动器.Location = 窗体.Location
                                           最后窗体 = 启动器
                                       End Sub
            AddHandler 窗体.SizeChanged, AddressOf 最小化隐藏
        End Sub

        Public Sub 启动()
            启动器.Hide()
            窗体.Location = 启动器.Location
            窗体.Show()
            窗体.Location = 启动器.Location
            窗体.WindowState = FormWindowState.Normal
            最后窗体 = 窗体
        End Sub

        Public Overrides Function ToString() As String
            Return ID
        End Function

    End Class

End Module
