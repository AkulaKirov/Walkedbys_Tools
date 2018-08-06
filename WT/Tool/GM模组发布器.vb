
Public Class GM模组发布器

    Const JSON As String = "{""title"": ""标题"",""type"":""类型"", ""tags"":[ ""标签1"",""标签2""],""ignore"":[""*.psd"",""*.vcproj"",""*.svn*""]}"

    Private Sub GM模组发布器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件夹(TxtPath, TxtGMod)
        文本框拖入文件(TxtGMAfile, TxtJPGfile)
        TxtPath.Text = 读取("GMApath")
        CBtype.SelectedIndex = Val(读取("GMAtype"))
        TxtGMod.Text = 读取("GMODpath")
        CBtags.SetItemChecked(Val(读取("GMAtag1")), True)
        CBtags.SetItemChecked(Val(读取("GMAtag2")), True)
        Txtname.Text = 读取("GMAname")
        TxtJPGfile.Text = 读取("GMAjpg")
        TxtGMAfile.Text = 读取("GMAfile")
    End Sub

    Private Sub TxtPath_TextChanged(sender As Object, e As EventArgs) Handles TxtPath.TextChanged
        GBgma.Enabled = 文件夹存在(TxtPath.Text)
    End Sub

    Private Sub Txtname_TextChanged(sender As Object, e As EventArgs) Handles Txtname.TextChanged, CBtype.SelectedIndexChanged, CBtags.MouseUp
        ButGMA.Enabled = (Trim(Txtname.Text).Length > 0 AndAlso CBtype.Text.Length > 0 AndAlso CBtags.CheckedItems.Count = 2)
    End Sub

    Private Sub GM模组发布器_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        保存("GMApath", TxtPath.Text)
        保存("GMAtype", CBtype.SelectedIndex.ToString)
        保存("GMODpath", TxtGMod.Text)
        If CBtags.CheckedItems.Count > 1 Then
            保存("GMAtag1", CBtags.CheckedIndices.Item(0))
            保存("GMAtag2", CBtags.CheckedIndices.Item(1))
        End If
        保存("GMAname", Txtname.Text)
        保存("GMAjpg", TxtJPGfile.Text)
        保存("GMAfile", TxtGMAfile.Text)
    End Sub

    Private Sub ButGMA_Click(sender As Object, e As EventArgs) Handles ButGMA.Click
        Dim s As String = JSON
        s = s.Replace("标题", Txtname.Text)
        s = s.Replace("类型", CBtype.Text)
        s = s.Replace("标签1", CBtags.CheckedItems.Item(0))
        s = s.Replace("标签2", CBtags.CheckedItems.Item(1))
        文件x(追加斜杠(TxtPath.Text) + "addon.json").写(s)
        Shell("cmd.exe /c " + 左(TxtGMod.Text, 2) + " & " + 引(追加斜杠(TxtGMod.Text) + "bin\gmad.exe") + " " + 引(TxtPath.Text) + " & pause", AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub TxtGMod_TextChanged(sender As Object, e As EventArgs) Handles TxtGMod.TextChanged
        Tabs.Enabled = False
        Dim i As String = Trim(TxtGMod.Text)
        If 文件夹存在(i) Then
            i = 追加斜杠(i) + "bin\"
            If 文件x(i + "gmad.exe").存在 AndAlso 文件x(i + "gmpublish.exe").存在 Then
                Tabs.Enabled = True
            End If
        End If
    End Sub

    Private Sub ButGoPublish_Click(sender As Object, e As EventArgs) Handles ButGoPublish.Click
        Tabs.SelectedIndex = 1
        TxtGMAfile.Text = 去右(追加斜杠(TxtPath.Text), 1) + ".gma"
    End Sub

    Private Sub TxtGMAfile_TextChanged(sender As Object, e As EventArgs) Handles TxtGMAfile.TextChanged, TxtJPGfile.TextChanged, TxtID.TextChanged
        If 文件x(TxtGMAfile.Text).后缀 <> "gma" Then TxtGMAfile.Text = ""
        TxtID.Text = 只要数字(TxtID.Text)
        ButPublish.Enabled = (TxtGMAfile.TextLength > 5 AndAlso TxtJPGfile.TextLength > 5)
        ButUpdateGMA.Enabled = (TxtGMAfile.TextLength > 5 AndAlso TxtID.TextLength > 5)
        ButUpdateJPG.Enabled = (TxtJPGfile.TextLength > 5 AndAlso TxtID.TextLength > 5)
    End Sub

    Private Sub TxtJPGfile_TextChanged(sender As Object, e As EventArgs) Handles TxtJPGfile.TextChanged
        Dim m As 文件 = 文件x(TxtJPGfile.Text)
        If m.后缀 <> "jpg" Then
            TxtJPGfile.Text = ""
        Else
            PicThumb.Image = m.转图片
        End If
    End Sub

    Private Sub ButPublish_Click(sender As Object, e As EventArgs) Handles ButPublish.Click
        Shell("cmd.exe /c " + 左(TxtGMod.Text, 2) + " & " + 引(追加斜杠(TxtGMod.Text) + "bin\gmpublish.exe") + " create -icon " + 引(TxtJPGfile.Text) + " -addon " + 引(TxtGMAfile.Text) + " & pause", AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub ButUpdateGMA_Click(sender As Object, e As EventArgs) Handles ButUpdateGMA.Click
        Shell("cmd.exe /c " + 左(TxtGMod.Text, 2) + " & " + 引(追加斜杠(TxtGMod.Text) + "bin\gmpublish.exe") + " update -id " + TxtID.Text + " -icon " + 引(TxtJPGfile.Text) + " & pause", AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub ButUpdateJPG_Click(sender As Object, e As EventArgs) Handles ButUpdateJPG.Click
        Shell("cmd.exe /c " + 左(TxtGMod.Text, 2) + " & " + 引(追加斜杠(TxtGMod.Text) + "bin\gmpublish.exe") + " update -id " + TxtID.Text + " -addon " + 引(TxtGMAfile.Text) + " & pause", AppWinStyle.NormalFocus, True)
    End Sub

    Private Sub ButGoSteam_Click(sender As Object, e As EventArgs) Handles ButGoSteam.Click
        Dim s As String = "https://steamcommunity.com/my/myworkshopfiles?appid=4000"
        If 程序运行中("steamwebhelper") Then
            Dim f As New ProcessStartInfo
            f.FileName = "steam://openurl/" + s
            f.WindowStyle = ProcessWindowStyle.Maximized
            Process.Start(f)
        Else
            Process.Start(s)
        End If
    End Sub

End Class