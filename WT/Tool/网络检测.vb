
Public Class 网络检测

    Dim 测试列表 As List(Of 测试)

    Private Sub 网络检测_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        测试列表 = New List(Of 测试)
        新测试("腾讯", "https://im.qq.com/")
        新测试("bilibili", "https://www.bilibili.com/")
        新测试("百度", "https://www.baidu.com/")
        新测试("网易云音乐", "https://music.163.com/")
        新测试("微软", "https://www.microsoft.com")
        新测试("Google", "http://clients3.google.com/generate_204", 1, False)
        新测试("Steam社区", "https://steamcommunity.com")
        新测试("YouTube", "https://www.youtube.com/")
        新测试("Twitter", "https://twitter.com/")
        新测试("维基百科", "https://zh.wikipedia.org/wiki/Wikipedia:%E9%A6%96%E9%A1%B5")
        新测试("Cloudflare", "https://www.cloudflare.com/")
        ButStart.BringToFront()
    End Sub

    Sub 新测试(名字 As String, url As String, Optional 长度 As Integer = 3000, Optional 超过 As Boolean = True)
        测试列表.Add(New 测试(名字, url, 长度, 超过))
    End Sub

    Private Sub ButStart_Click(sender As Object, e As EventArgs) Handles ButStart.Click
        Dim st As String = "开始检测", i As 测试
        With ButStart
            If .Text = st Then
                For Each i In 测试列表
                    i.开始()
                Next
                TimerOut.Enabled = True
                LabOut.Text = ""

                .Text = "停止检测"
            Else
                TimerOut.Enabled = False
                For Each i In 测试列表
                    i.停止()
                Next
                .Text = st
            End If
        End With
    End Sub

    Private Sub 网络检测_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If TimerOut.Enabled Then ButStart.PerformClick()
    End Sub

    Private Sub TimerOut_Tick(sender As Object, e As EventArgs) Handles TimerOut.Tick
        If Visible = False Then Exit Sub
        Dim g As String = "    ", g2 As String = g + g + g
        Dim i As 测试, out As String = "网站" + g + "连续成功次数" + g + "连续超时次数" + g + "用时" + vbCrLf
        For Each i In 测试列表
            out += i.Name + g2 + i.连续成功次数.ToString + g2 + g + i.连续超时次数.ToString + g2 + g2 + i.用时信息
            out += vbCrLf
        Next
        LabOut.Text = out
    End Sub

End Class

Class 测试

    Public Property Name As String
    Public Property URL As String
    Public Property 线程 As Thread
    Public Property 连续成功次数 As Integer
    Public Property 连续超时次数 As Integer
    Public Property 要求超过 As Boolean
    Public Property 要求长度 As Integer
    Public Property 用时 As Integer
    Public Property 用时信息 As String

    Public Sub New(名字 As String, url As String, Optional 长度 As Integer = 3000, Optional 超过 As Boolean = True)
        Name = 名字
        Me.URL = url
        要求超过 = 超过
        要求长度 = 长度
        用时 = -1
    End Sub

    Public Sub 开始()
        清零()
        线程 = New Thread(Sub()
                            Thread.Sleep(随机.整数(4, 0) * 1000)
                            Dim sta As Double
                            Do While True
                                Dim h As New 简易HTTP(URL)
                                h.超时 = 5
                                h.Referer = URL
                                h.Host = (New Uri(URL)).Host
                                sta = DateAndTime.Timer
                                Dim s As String = h.获取回应(False)
                                用时信息 = s
                                Dim i As Integer = s.Length
                                用时 = (DateAndTime.Timer - sta) * 1000
                                If 要求超过 Then
                                    刷新(i > 要求长度)
                                Else
                                    刷新(i < 要求长度)
                                End If
                                Thread.Sleep(5000)
                            Loop
                        End Sub)
        线程.Start()
    End Sub

    Public Sub 清零()
        连续成功次数 = 0
        连续超时次数 = 0
        用时 = -1
        用时信息 = ""
    End Sub

    Private Sub 刷新(成功 As Boolean)
        If 成功 Then
            连续成功次数 += 1
            连续超时次数 = 0
            用时信息 = 用时.ToString + "ms"
        Else
            连续超时次数 += 1
            用时 = -1
            连续成功次数 = 0
        End If
    End Sub

    Public Sub 停止()
        中断线程(线程)
        清零()
    End Sub

End Class
