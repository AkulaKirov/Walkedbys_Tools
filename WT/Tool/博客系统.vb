
Public Class 博客系统

    Dim 附件目录 As String = 程序文件目录 + "blog\"
    Dim 图片目录 As String = 附件目录 + "images\"
    Dim 文章目录 As String = 附件目录 + "posts\"
    Dim 生成目录 As String = 程序文件目录 + "public\"

    Private Sub 博客系统_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Directory.CreateDirectory(文章目录)
        Directory.CreateDirectory(图片目录)
        TxtWebDescription.Text = 设置.元素("BlogDescription")
        TxtWebTitle.Text = 设置.元素("BlogTitle")
        TxtHead.Text = 设置.元素("BlogHead")
        TxtFriendsLink.Text = 设置.元素("BlogLinks")
        生成固定HEAD()
    End Sub

    Private Sub 博客系统_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("BlogDescription") = TxtWebDescription.Text
        设置.元素("BlogTitle") = TxtWebTitle.Text
        设置.元素("BlogHead") = TxtHead.Text
        设置.元素("BlogLinks") = TxtFriendsLink.Text
    End Sub

    Private Sub TxtWebTitle_TextChanged(sender As Object, e As EventArgs) Handles TxtHead.TextChanged, TxtWebTitle.TextChanged, TxtWebDescription.TextChanged
        生成固定HEAD()
    End Sub

    Sub 生成固定HEAD()
        Dim s As String = My.Resources.博客HTMLhead
        s = s.Replace("标题", TxtWebTitle.Text)
        s = s.Replace("简介", TxtWebDescription.Text) + IIf(TxtHead.TextLength > 0, vbCrLf, "") + TxtHead.Text
        s += vbCrLf + "</head>"
        With TxtHeadLocked
            .Text = s
            .SelectionStart = s.Length
            .ScrollToCaret()
        End With
    End Sub

    Private Sub ButRefreshPostList_Click(sender As Object, e As EventArgs) Handles ButRefreshPostList.Click
        Directory.CreateDirectory(文章目录)
        With ListPosts
            .Items.Clear()
            For Each i As String In Directory.GetFiles(文章目录, "*.htm", SearchOption.AllDirectories)
                i = 去除(i, 文章目录, ".htm")
                If i.Length > 0 Then ListPosts.Items.Add(i)
            Next
            If .Items.Count > 0 Then .SelectedIndex = 0
        End With
    End Sub

    Private Sub Tabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Tabs.SelectedIndexChanged
        If Tabs.SelectedIndex = 2 Then ButRefreshPostList.PerformClick()
    End Sub

    Private Sub ButCheckPosts_Click(sender As Object, e As EventArgs) Handles ButCheckPosts.Click
        Directory.CreateDirectory(文章目录)
        Process.Start(文章目录)
    End Sub

    Private Sub TxtNewPost_TextChanged(sender As Object, e As EventArgs) Handles TxtNewPost.TextChanged
        ButNewPost.Enabled = False
        Dim s As String = TxtNewPost.Text
        If s.Length < 1 Then Exit Sub
        Dim f As String = 文章目录 + s + ".htm"
        If 文件存在(f) Then Exit Sub
        ButNewPost.Enabled = True
    End Sub

    Private Sub ButNewPost_Click(sender As Object, e As EventArgs) Handles ButNewPost.Click
        Dim f As String = 文章目录 + TxtNewPost.Text + ".htm"
        Dim s As String = My.Resources.博客HTML文章模板
        s = s.Replace("date", Today.ToShortDateString)
        s = s.Replace("title", TxtNewPost.Text)
        写文件(f, s)
        ButRefreshPostList.PerformClick()
    End Sub

    Private Sub 博客系统_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ButRefreshPostList.PerformClick()
    End Sub

    Private Sub ButGenerate_Click(sender As Object, e As EventArgs) Handles ButGenerate.Click
        Directory.CreateDirectory(生成目录)
        Dim html As String = TxtHeadLocked.Text, s As String = My.Resources.博客HTML_1, i As Integer
        Dim title As String = TxtWebTitle.Text, t As String = "", n As String, j As String = TxtFriendsLink.Text
        n = 附件目录 + "maincss.css"
        If Not 文件存在(n) Then 写文件(n, My.Resources.压缩CSS)
        If j.Length > 3 Then
            For Each n In 分割(j, vbCrLf)
                i = InStr(n, "：")
                If i > 0 Then
                    t += "<a href=" + 引(去左(n, i)) + " class=""headerlink"">" + 左(n, i - 1) + "</a>" + vbCrLf
                End If
            Next
        End If
        s = s.Replace("博客标题", title).Replace("超链接", t)
        html += s
        PRT(html)
    End Sub

End Class