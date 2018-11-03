
Public Class GM模组发布器

    Const JSON As String = "{""title"": ""标题"",""type"":""类型"", ""tags"":[ ""标签1"",""标签2""],""ignore"":[""*.psd"",""*.vcproj"",""*.svn*""]}"
    Dim log As String = 缓存目录 + "gmodlog.txt"
    Dim bat As String = 缓存目录 + "xg.bat"
    Dim tgma As String = 缓存目录 + "t.gma"
    Dim 上次更新日期 As Date
    Dim 冷却 As Integer = 0

    Private Sub GM模组发布器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件夹(TxtPath, TxtGMod)
        文本框拖入文件(TxtJPGfile)
        TxtPath.Text = 设置.字符串("GMApath")
        CBtype.SelectedIndex = Val(设置.字符串("GMAtype"))
        TxtGMod.Text = 设置.字符串("GMODpath")
        CBtags.SetItemChecked(Val(设置.字符串("GMAtag1")), True)
        CBtags.SetItemChecked(Val(设置.字符串("GMAtag2")), True)
        Txtname.Text = 设置.字符串("GMAname")
        TxtJPGfile.Text = 设置.字符串("GMAjpg")
        文字转列表(ListAddons.Items, 设置.字符串("GMODaddons"))
        上次更新日期 = 设置.日期("GMAtime")
        Dim i As Integer = 设置.数字("GMAw", 0)
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
        设置.字符串("GMAtime") = 上次更新日期.ToString
        设置.字符串("GMAw") = ListAddons.SelectedIndex
        删除(tgma, log, bat)
    End Sub

    Private Sub TxtGMod_TextChanged(sender As Object, e As EventArgs) Handles TxtGMod.TextChanged
        Dim i As String = Trim(TxtGMod.Text)
        If 文件夹存在(i) Then
            i = 追加斜杠(i) + "bin\"
            If 文件存在(i + "gmad.exe") AndAlso 文件存在(i + "gmpublish.exe") Then
                Pn.Visible = True
            Else
                Pn.Visible = False
            End If
        End If
    End Sub

    Private Sub TxtJPGfile_TextChanged(sender As Object, e As EventArgs) Handles TxtJPGfile.TextChanged
        Dim m As String = TxtJPGfile.Text
        If 文件后缀(m) <> "jpg" Then TxtJPGfile.Text = ""
    End Sub

    Private Sub ButGetList_Click(sender As Object, e As EventArgs) Handles ButGetList.Click
        ListAddons.Items.Clear()
        Shell("cmd.exe /c " + 左(TxtGMod.Text, 2) + " & " + 引(TxtGMod.Text + "bin\gmpublish.exe") + " list > " + 引(log), AppWinStyle.NormalFocus, True)
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
        If ListAddons.Items.Count > 0 Then
            ListAddons.SelectedIndex = 0
        End If
        Txtname_TextChanged(sender, e)
    End Sub

    Private Sub ButNew_Click(sender As Object, e As EventArgs) Handles ButNew.Click
        运行BAT(生成gma, 发布新素材)
    End Sub

    Private Sub ListAddons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListAddons.SelectedIndexChanged
        LabCount.Text = "共计：" & ListAddons.Items.Count & "  上次更新日期时间：" & 上次更新日期
    End Sub

    Private Sub ButUpdateGMA_Click(sender As Object, e As EventArgs) Handles ButUpdateGMA.Click
        运行BAT(生成gma, 更新素材GMA)
    End Sub

    Private Sub ButUpdateJPG_Click(sender As Object, e As EventArgs) Handles ButUpdateJPG.Click
        运行BAT(更新素材JPG)
    End Sub

    Private Sub ButUpdateALL_Click(sender As Object, e As EventArgs) Handles ButUpdateALL.Click
        运行BAT(生成gma, 更新素材)
    End Sub

    Sub 运行BAT(ParamArray l() As String)
        CoolD_Tick()
        CoolD.Enabled = True
        Dim sy As String = TxtGMod.Text + "bin\"
        Dim s As String = 左(sy, 2) + vbCrLf + "cd " + 引(sy) + vbCrLf
        For Each m As String In l
            s += m + vbCrLf
        Next
        s += "pause"
        写文件(bat, s, Encoding.Default)
        Shell(bat, AppWinStyle.NormalFocus, True)
    End Sub

    Function 生成gma() As String
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
        Return "gmad.exe create -folder " + 引(去右(TxtPath.Text, 1)) + " -out " + 引(tgma)
    End Function

    Function 发布新素材() As String
        Return "gmpublish.exe create -icon " + 引(TxtJPGfile.Text) + " -addon " + 引(tgma)
    End Function

    Function 更新素材JPG() As String
        Return "gmpublish.exe update -id " + Regex.Match(Trim(ListAddons.SelectedItem.ToString), "[0-9].*? ").ToString + " -icon " + 引(TxtJPGfile.Text)
    End Function

    Function 更新素材GMA() As String
        Return "gmpublish.exe update -id " + Regex.Match(Trim(ListAddons.SelectedItem.ToString), "[0-9].*? ").ToString + " -addon " + 引(tgma)
    End Function

    Function 更新素材() As String
        Return "gmpublish.exe update -id " + Regex.Match(Trim(ListAddons.SelectedItem.ToString), "[0-9].*? ").ToString + " -addon " + 引(tgma) + " -icon " + 引(TxtJPGfile.Text)
    End Function

    Private Sub CoolD_Tick() Handles CoolD.Tick
        TxtGMod.Enabled = False
        Pn.Enabled = False
        冷却 += CoolD.Interval
        If 冷却 > 2 * 1000 Then
            CoolD.Enabled = False
            冷却 = 0
            TxtGMod.Enabled = True
            Pn.Enabled = True
        End If
    End Sub

End Class
