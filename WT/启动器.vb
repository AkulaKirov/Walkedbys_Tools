
Public Class 启动器

    Friend 工具收藏 As New List(Of 工具)
    Friend 收藏按纽 As New List(Of Button)
    Dim Th更新 As New Thread(AddressOf 检查更新)
    Dim 关于链接 As New List(Of LinkLabel)
    Dim 版本 As Single = My.Application.Info.Version.Major + (My.Application.Info.Version.Minor / 10)
    Dim 检查更新过了 As String = ""

    Private Sub 启动器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        随机.刷新()
        Icon = 图标
        Text = "走過去的工具箱 内部测试版 " + 版本.ToString
        线程越界()
        Directory.CreateDirectory(TempF)
        Sets.读取本地文件()
        工具列表.Add(New 工具("文件夹创建器", 文件夹创建器, "MKDIR", "输入一个路径，就能新建好你要的文件夹。"))
        工具列表.Add(New 工具("B站图床", B站图床, "BilibiliPic", "把20MB以下的图片无损放到B站服务器还行。"))
        工具列表.Add(New 工具("日子提醒器", 日子提醒, "DayReminder", "可以拿来提醒生日或者重要的啥日子。"))
        Dim t As 工具
        For Each t In 工具列表
            ListTools.Items.Add(t.名字)
        Next
        Dim b As Button, i As Integer
        For i = 1 To 8
            b = New Button
            GBfavorites.Controls.Add(b)
            收藏按纽.Add(b)
            With b
                .Visible = False
                .Width = 150
                .Height = 32
                .Left = IIf(i > 4, IIf(i - 4 > 1, (i - 5) * 160 + 10, 10), IIf(i > 1, (i - 1) * 160 + 10, 10))
                .Top = IIf(i > 4, 70, 20)
                AddHandler .Click, Sub()
                                       ID工具(.Tag).启动()
                                   End Sub
            End With
        Next
        Dim mc As New List(Of String)
        文字转列表(mc, 读取("FAVOR"))
        For Each g As String In mc
            t = ID工具(g)
            If Not IsNothing(t) Then 工具收藏.Add(t)
            If 工具收藏.Count >= 8 Then Exit For
        Next
        For i = 0 To 工具收藏.Count - 1
            If 工具收藏.Count < 1 Then Exit For
            b = 收藏按纽.Item(i)
            t = 工具收藏.Item(i)
            b.Text = t.名字
            b.Tag = t.ID
            b.Visible = True
        Next
        GBfavorites.Text = "工具收藏夹" + 括(工具收藏.Count.ToString + "/8")
        新增关于链接("博客", "https://walkedby.com/")
        新增关于链接("源码", "https://github.com/gordonwalkedby/Walkedbys_Tools")
        新增关于链接("下载最新版", "https://github.com/gordonwalkedby/Walkedbys_Tools/releases")
        新增关于链接("请我喝可乐", "https://walkedby.com/donateme/")
        Refresh()
    End Sub

    Private Sub 启动器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        中断线程(Th更新)
        Sets.保存本地文件()
        删除文件夹(TempF)
    End Sub

    Sub 检查推送()
        TxtUpdate.Text = ""
        日子提醒.日子提醒_Load()
        日子提醒.提醒好日子()
        If 检查更新过了.Length < 1 Then
            Th更新.Start()
        Else
            推送(检查更新过了)
        End If
    End Sub

    Private Sub ListTools_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTools.SelectedIndexChanged
        Dim i As Integer = ListTools.SelectedIndex
        If i < 0 Then Exit Sub
        Dim t As 工具 = 工具列表.Item(i)
        TxtToolDes.Text = t.名字 + vbCrLf + IIf(在列表(工具收藏, t), "【已收藏】" + vbCrLf, "") + "简介：" + vbCrLf + t.简介
        ButOpenTool.Enabled = True
        With ButAddToFavor
            If 在列表(工具收藏, t) Then
                .Enabled = True
                .Text = "取消收藏"
            Else
                .Enabled = (工具收藏.Count < 8)
                .Text = "收藏"
            End If
        End With
    End Sub

    Private Sub ButOpenTool_Click(sender As Object, e As EventArgs) Handles ButOpenTool.Click
        Dim t As 工具 = 工具列表.Item(ListTools.SelectedIndex)
        t.启动()
    End Sub

    Private Sub ButAddToFavor_Click(sender As Object, e As EventArgs) Handles ButAddToFavor.Click
        Dim t As 工具 = 工具列表.Item(ListTools.SelectedIndex)
        If Not 在列表(工具收藏, t) Then
            If 工具收藏.Count < 8 Then 工具收藏.Add(t)
        Else
            工具收藏.Remove(t)
        End If
        Dim i As Integer = 0
        For i = 0 To 7
            收藏按纽.Item(i).Visible = False
        Next
        If 工具收藏.Count > 0 Then
            For i = 0 To 工具收藏.Count - 1
                Dim b As Button = 收藏按纽.Item(i)
                t = 工具收藏.Item(i)
                b.Text = t.名字
                b.Tag = t.ID
                b.Visible = True
            Next
        End If
        保存("FAVOR", 列表转文字(工具收藏))
        ListTools_SelectedIndexChanged(sender, e)
        GBfavorites.Text = "工具收藏夹" + 括(工具收藏.Count.ToString + "/8")
    End Sub

    Sub 检查更新()
        Dim h As New 简易HTTP("https://raw.githubusercontent.com/gordonwalkedby/Walkedbys_Tools/master/WT/updater.cfg?" + 随机.文字)
        Dim t As String = h.获得回应
        Dim out As String = ""
        If t.StartsWith("这是一个检查更新版本用的") Then
            Dim s As New 简易CFG
            s.全文本 = t
            If 版本 < Val(s.节点("ver")) Then
                检查更新过了 = "软件有新版本：" + s.节点("ver")
            End If
        End If
        Dim wt As New 委托推送(AddressOf 推送)
        Invoke(wt, 检查更新过了)
    End Sub

    Sub 新增关于链接(文字 As String, 链接 As String)
        Dim m As New LinkLabel
        GBabout.Controls.Add(m)
        With m
            .Top = LabAbout.Bottom + 5
            If 关于链接.Count = 0 Then
                .Left = 6
            Else
                .Left = 关于链接.Last.Right + 6
            End If
            .Width = 100
            .Height = 100
            .Text = 文字
            .Visible = True
            .AutoSize = True
            AddHandler .LinkClicked, Sub(sender As Object, e As LinkLabelLinkClickedEventArgs)
                                         Process.Start(链接)
                                     End Sub
        End With
        关于链接.Add(m)
    End Sub

    Private Sub GBabout_Paint(sender As Object, e As PaintEventArgs) Handles GBabout.Paint
        Dim i As Image = My.Resources.LogoPng
        Dim b As Single = 0.4
        With GBabout
            e.Graphics.DrawImage(i, .Width - i.Width * b, .Height - i.Height * b, i.Width * b, i.Height * b)
        End With
    End Sub

    Private Sub 启动器_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        检查推送()
    End Sub

End Class
