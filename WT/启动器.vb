
Public Class 启动器

    Friend 工具列表 As New List(Of 工具)
    Friend 工具收藏 As New List(Of 工具)
    Friend 收藏按纽 As New List(Of Button)
    Dim Th更新 As New Thread(AddressOf 检查更新)
    Dim 版本 As Single = My.Application.Info.Version.Major + (My.Application.Info.Version.Minor / 10)

    Private Sub 启动器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.ico
        Text = "走過去的工具箱 内部测试版 " + 版本.ToString
        线程越界()
        Directory.CreateDirectory(TempF)
        Sets.读取本地文件()
        工具列表.Add(New 工具("文件夹创建器", 文件夹创建器, "MKDIR", "输入一个路径，就能新建好你要的文件夹。"))
        工具列表.Add(New 工具("B站图床", B站图床, "BilibiliPic", "把20MB以下的图片无损放到B站服务器还行。"))
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
        Next
        PRT(工具收藏.Count)
        For i = 0 To 工具收藏.Count - 1
            If 工具收藏.Count < 1 Then Exit For
            b = 收藏按纽.Item(i)
            t = 工具收藏.Item(i)
            b.Text = t.名字
            b.Tag = t.ID
            b.Visible = True
        Next
        GBfavorites.Text = "工具收藏夹" + 括(工具收藏.Count.ToString + "/8")
        Th更新.Start()
    End Sub

    Private Sub 启动器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        中断线程(Th更新)
        Sets.保存本地文件()
        删除文件夹(TempF)
    End Sub

    Public Function ID工具(id As String) As 工具
        For Each t As 工具 In 工具列表
            If t.ID = id Then Return t
        Next
        Return Nothing
    End Function

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
        Dim h As New 简易HTTP("" + "?" + 随机.小写字母)
        Dim t As String = h.获得回应
        Dim out As String = ""
        If t.StartsWith("这是一个检查更新版本用的") Then
            out = "检查更新失败：" + vbCrLf + t
        Else
            Dim s As New 简易CFG
            s.全文本 = t
            If 版本 >= Val(s.节点("version")) Then
                out = "你已经是最新版本。" + vbCrLf
            Else
                out = "看起来有新的版本。" + vbCrLf
            End If
            out += "最新版本：" + s.节点("version") + vbCrLf + "更新记录：" + s.节点("log")
        End If
        TxtUpdate.Text = out
    End Sub

End Class