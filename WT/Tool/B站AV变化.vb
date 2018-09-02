
Public Class B站AV变化

    Private 分区s As List(Of 分区)
    Public pid As Integer = 0

    Private Sub B站AV变化_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        分区s = New List(Of 分区)
        新区("动画", 1)
        新区("番剧", 13)
        新区("音乐", 3)
        新区("舞蹈", 129)
        新区("游戏", 4)
        新区("科技", 36)
        新区("生活", 160)
        新区("鬼畜", 119)
        新区("时尚", 155)
        新区("广告", 165)
        新区("娱乐", 5)
        新区("影视", 181)
        新区("国创", 168)
        新区("电影", 23)
        新区("TV剧", 11)
        新区("纪录片", 177)
        Dim i As Integer = 分区s.Count - 1, l As Label, p As ProgressBar, q As 分区
        i = 0
        For Each q In 分区s
            l = New Label
            With l
                .Name = "lab" + q.名字
                .Text = q.名字
                .Size = New Drawing.Size(1, 1)
                .AutoSize = True
                .Top = 9 + i * 25
                .Left = 10
            End With
            Controls.Add(l)
            p = New ProgressBar
            With p
                .Name = "bar" + q.名字
                .Top = l.Top
                .Left = 140
                .Width = Width - .Left - 30
                .Height = l.Height
                .Maximum = 1000
                .Minimum = 0
                .Value = 0
            End With
            Controls.Add(p)
            i += 1
        Next
        CheckMovies.Checked = 设置.读取真假("bilibiliavcheckmovies")
        新线程(AddressOf 更新)
        Updater.Enabled = True
    End Sub

    Sub 更新()
        Thread.Sleep(2 * 1000)
        Do While True
            If 最后窗体.Text = Text Then
                For Each n As 分区 In 分区s
                    If 略过分区(n) = False Then n.获得最大av()
                    Thread.Sleep(4 * 1000)
                Next
            End If
        Loop
    End Sub

    Sub 新区(name As String, rid As Integer)
        分区s.Add(New 分区(name, rid))
    End Sub

    Private Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
        If 最后窗体.Text <> Text Then Exit Sub
        Dim big As Long = 0, small As Long = 0, n As 分区
        For Each n In 分区s
            If 略过分区(n) = False AndAlso n.最大AV > 1000 Then
                Dim s As String = TxtAV.Text
                If s.Length > 0 Then
                    s =( Val(s) - n.最大AV).ToString
                Else
                    s = n.最大AV.ToString
                End If
                n.文本.Text = n.名字 + " " + 括(s)
                small = n.最大AV
            End If
            n.文本.Visible = Not 略过分区(n)
            n.滚动条.Visible = n.文本.Visible
        Next
        If small > 1000 Then
            For Each n In 分区s
                If 略过分区(n) = False AndAlso n.最大AV > 1000 Then
                    If n.最大AV > big Then big = n.最大AV
                    If n.最大AV < small Then small = n.最大AV
                End If
            Next
            Dim c As Long = big - small
            If c < 1 Then c = big
            For Each n In 分区s
                If 略过分区(n) = False AndAlso n.最大AV > 1000 Then n.滚动条.Value = (n.最大AV - small) / c * 800 + 100
            Next
        End If
    End Sub

    Function 略过分区(s As 分区) As Boolean
        If CheckMovies.Checked Then
            If 是当中一个(s.名字, "电影", "TV剧", "纪录片", "国创") Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Sub B站AV变化_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("bilibiliavcheckmovies") = CheckMovies.Checked.ToString
    End Sub

    Private Sub CheckMovies_CheckedChanged(sender As Object, e As EventArgs) Handles CheckMovies.CheckedChanged
        Updater_Tick(sender, e)
    End Sub

    Private Sub TxtAV_TextChanged(sender As Object, e As EventArgs) Handles TxtAV.TextChanged
        TxtAV.Text = 左(只要数字(TxtAV.Text), 10)
    End Sub

End Class

Public Class 分区

    Public Property 名字 As String
    Public Property 最大AV As Long
    Private rid As Integer

    Public Sub New(name As String, rid As Integer)
        名字 = name
        Me.rid = rid
        最大AV = 0
    End Sub

    Public Sub 获得最大av()
        Dim h As New 简易HTTP("https://api.bilibili.com/x/web-interface/newlist?callback=jqueryCallback_bili_" + 随机.数字(16) + "&jsonp=jsonp&ps=10&rid=" + rid.ToString + "&_=" + UNIX时间(Now).ToString + 随机.数字(3))
        h.Referer = "https://www.bilibili.com/"
        h.Host = "api.bilibili.com"
        Dim s As String = h.获得回应
        If s.Length > 1000 Then
            s = 去除(s, 引号)
            Dim g2 As Long, g As Long, c As Integer = 0
            For Each m As Match In Regex.Matches(s, "aid:[0-9]+,")
                g = Val(只要数字(m.ToString))
                If g > 1000 Then
                    g2 += g
                    c += 1
                End If
            Next
            g2 = g2 / c
            If g2 > 最大AV Then
                最大AV = g2
            End If
        End If
    End Sub

    Public ReadOnly Property 滚动条 As ProgressBar
        Get
            Return B站AV变化.Controls("bar" + 名字)
        End Get
    End Property

    Public ReadOnly Property 文本 As Label
        Get
            Return B站AV变化.Controls("lab" + 名字)
        End Get
    End Property

End Class
