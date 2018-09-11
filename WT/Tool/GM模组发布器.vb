
Public Class GM模组发布器

    Const JSON As String = "{""title"": ""标题"",""type"":""类型"", ""tags"":[ ""标签1"",""标签2""],""ignore"":[""*.psd"",""*.vcproj"",""*.svn*""]}"
    Dim log As String = 缓存目录 + "gmodlog.txt"
    Dim tgma As String = 缓存目录 + "t.gma"
    Dim GMODbin As String = ""
    Dim 上次更新日期 As Date

    Private Sub GM模组发布器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件夹(TxtPath, TxtGMod)
        文本框拖入文件(TxtJPGfile)
        TxtPath.Text = 设置.元素("GMApath")
        CBtype.SelectedIndex = Val(设置.元素("GMAtype"))
        TxtGMod.Text = 设置.元素("GMODpath")
        CBtags.SetItemChecked(Val(设置.元素("GMAtag1")), True)
        CBtags.SetItemChecked(Val(设置.元素("GMAtag2")), True)
        Txtname.Text = 设置.元素("GMAname")
        TxtJPGfile.Text = 设置.元素("GMAjpg")
        文字转列表(ListAddons.Items, 设置.读取字符串("GMODaddons"))
        上次更新日期 = 设置.读取日期("GMAtime")
        Dim i As Integer = 设置.读取数("GMAw", 0)
        If i < 0 Then i = 0
        If ListAddons.Items.Count > i Then ListAddons.SelectedIndex = i
        删除(tgma, log)
    End Sub

    Private Sub TxtPath_TextChanged(sender As Object, e As EventArgs) Handles TxtPath.TextChanged
        Dim s As String = TxtPath.Text
        Dim b As Boolean = s.Length > 3
        If b Then Txtname.Text = 文件夹名(TxtPath.Text)
        GBjson.Visible = b
    End Sub

    Private Sub Txtname_TextChanged(sender As Object, e As EventArgs) Handles Txtname.TextChanged, CBtype.SelectedIndexChanged, CBtags.MouseUp, TxtJPGfile.TextChanged, TxtPath.TextChanged, MyBase.Load
        Dim nam As Boolean = (Trim(Txtname.Text).Length > 0 AndAlso CBtype.Text.Length > 0 AndAlso CBtags.CheckedItems.Count = 2 AndAlso GBjson.Visible)
        Dim s As String = TxtJPGfile.Text
        Dim jp As Boolean = (s.Length > 5 AndAlso 文件可用(s))
        Dim up As Boolean = (ListAddons.SelectedIndex > -1 AndAlso ListAddons.SelectedItem.ToString.Length > 8)
        ButNew.Enabled = (nam AndAlso jp)
        ButUpdateGMA.Enabled = (up AndAlso nam)
        ButUpdateJPG.Enabled = (up AndAlso jp)
        ButUpdateALL.Enabled = (nam AndAlso jp AndAlso up)
        With PicThumb
            If jp Then
                .Image = 读文件为图片(s)
            Else
                .Image = Nothing
            End If
        End With
    End Sub

    Private Sub GM模组发布器_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        设置.保存元素("GMApath", TxtPath.Text)
        设置.保存元素("GMAtype", CBtype.SelectedIndex.ToString)
        设置.保存元素("GMODpath", TxtGMod.Text)
        If CBtags.CheckedItems.Count = 2 Then
            设置.保存元素("GMAtag1", CBtags.CheckedIndices.Item(0))
            设置.保存元素("GMAtag2", CBtags.CheckedIndices.Item(1))
        End If
        设置.保存元素("GMAname", Txtname.Text)
        设置.保存元素("GMAjpg", TxtJPGfile.Text)
        设置.保存元素("GMODaddons", 列表转文字(ListAddons.Items))
        设置.元素("GMAtime") = 上次更新日期.ToString
        设置.元素("GMAw") = ListAddons.SelectedIndex
        删除(tgma, log)
    End Sub

    Private Sub TxtGMod_TextChanged(sender As Object, e As EventArgs) Handles TxtGMod.TextChanged
        Dim i As String = Trim(TxtGMod.Text)
        If 文件夹存在(i) Then
            i = 追加斜杠(i) + "bin\"
            If 文件存在(i + "gmad.exe") AndAlso 文件存在(i + "gmpublish.exe") Then
                Pn.Visible = True
                GMODbin = i
            Else
                Pn.Visible = False
                GMODbin = ""
            End If
        End If
    End Sub

    Private Sub TxtJPGfile_TextChanged(sender As Object, e As EventArgs) Handles TxtJPGfile.TextChanged
        Dim m As String = TxtJPGfile.Text
        If 文件后缀(m) <> "jpg" Then TxtJPGfile.Text = ""
    End Sub

    Private Sub ButNew_Click(sender As Object, e As EventArgs) Handles ButNew.Click
        If 生成GMA() Then
            Shell("cmd.exe /c " + 左(GMODbin, 2) + " & " + 引(GMODbin + "gmpublish.exe") + " create -icon " + 引(TxtJPGfile.Text) + " -addon " + 引(tgma) + " & pause ", AppWinStyle.NormalFocus, True)
            删除(tgma, log)
        End If
    End Sub

    Private Sub ButGetList_Click(sender As Object, e As EventArgs) Handles ButGetList.Click
        ListAddons.Items.Clear()
        Shell("cmd.exe /c " + 左(GMODbin, 2) + " & " + 引(GMODbin + "gmpublish.exe") + " list > " + 引(log), AppWinStyle.NormalFocus, True)
        Dim s As String = 读文件(log)
        If 全部包含(s, "Getting published files..", "Done.") Then
            s = 提取(s, "Getting published files..", "Done.")
            For Each m As String In 分割(s, vbCrLf)
                If m.Length > 5 Then
                    m = 去左(m, 1)
                    m = Regex.Replace(m, "	[0-9].*?B	", "    ")
                    m = Regex.Replace(m, "    " + 引号, "    ")
                    m = 去右(m, 1)
                    Dim c As Integer = Trim(Regex.Match(m, "[0-9].*? ").ToString).Length
                    If c < 10 Then
                        m = Space(10 - c) + m
                    End If
                    ListAddons.Items.Add(m)
                End If
            Next
        End If
        上次更新日期 = Now
        If ListAddons.Items.Count > 0 Then ListAddons.SelectedIndex = 0
    End Sub

    Private Sub ListAddons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListAddons.SelectedIndexChanged
        LabCount.Text = "共计：" & ListAddons.Items.Count & "  上次更新日期时间：" & 上次更新日期
    End Sub

    Private Sub ButUpdateGMA_Click(sender As Object, e As EventArgs) Handles ButUpdateGMA.Click
        If 生成GMA() Then
            Shell("cmd.exe /c " + 左(GMODbin, 2) + " & " + 引(GMODbin + "gmpublish.exe") + " update -id " + Regex.Match(Trim(ListAddons.SelectedItem.ToString), "[0-9].*? ").ToString + " -addon " + 引(tgma) + " & pause", AppWinStyle.NormalFocus, True)
            删除(tgma, log)
        End If
    End Sub

    Private Sub ButUpdateJPG_Click(sender As Object, e As EventArgs) Handles ButUpdateJPG.Click
        Shell("cmd.exe /c " + 左(GMODbin, 2) + " & " + 引(GMODbin + "gmpublish.exe") + " update -id " + Regex.Match(Trim(ListAddons.SelectedItem.ToString), "[0-9].*? ").ToString + " -icon " + 引(TxtJPGfile.Text) + " & pause", AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub ButUpdateALL_Click(sender As Object, e As EventArgs) Handles ButUpdateALL.Click
        If 生成GMA() Then
            Shell("cmd.exe /c " + 左(GMODbin, 2) + " & " + 引(GMODbin + "gmpublish.exe") + " update -id " + Regex.Match(Trim(ListAddons.SelectedItem.ToString), "[0-9].*? ").ToString + " -addon " + 引(tgma) + " -icon " + 引(TxtJPGfile.Text) + " & pause", AppWinStyle.NormalFocus, True)
        End If
    End Sub

    Public Function 生成GMA() As Boolean
        Dim sy As String = TxtPath.Text, s As String = JSON, i As String
        删除(tgma, log)
        For Each i In Directory.GetFiles(sy, "*", SearchOption.AllDirectories)
            文件重命名(i, i.ToLower)
        Next
        For Each i In Directory.GetDirectories(sy, "*", SearchOption.AllDirectories)
            文件重命名(i, i.ToLower)
        Next
        s = s.Replace("标题", Txtname.Text)
        s = s.Replace("类型", CBtype.Text)
        s = s.Replace("标签1", CBtags.CheckedItems.Item(0))
        s = s.Replace("标签2", CBtags.CheckedItems.Item(1))
        写文件(追加斜杠(TxtPath.Text) + "addon.json", s)
        文件重命名(sy, sy.ToLower)
        Dim sc As String = "cmd.exe /c " + 左(GMODbin, 2) + " & " + 引(GMODbin + "gmad.exe") + " create -folder " + 引(去右(sy, 1)) + " -out " + 引(tgma) + " > " + 引(log)
        Shell(sc, AppWinStyle.NormalFocus, True)
        If 文件可用(tgma) Then
            Return True
        Else
            s = 读文件(log)
            Dim m As Integer = Regex.Match(s, "\[([\s\S]*)\]").Index
            s = "大致错误信息： " + vbCrLf + 左(去左(s, m - 30), 800)
            MsgBox(s, MsgBoxStyle.Critical, "GMA 文件生成失败！")
            Return False
        End If
    End Function

End Class