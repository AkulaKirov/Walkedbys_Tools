
Public Class 网站监视器

    Dim mz As 模板组
    Delegate Sub 委托消息(s As String)
    Dim 更新过的 As New List(Of String)

    Public Sub 网站监视器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If 只做一次(3) = False Then Exit Sub
        ListWhen.SelectedIndex = 设置.读取数("HTTPwatchwhen")
        mz = New 模板组("网站监视", ListWebs, TxtName, ButNew, ButRM, ButREAD)
        新线程(AddressOf 后台监视)
    End Sub

    Private Sub ButNew_Click(sender As Object, e As EventArgs) Handles ButNew.Click
        Dim n As New 模板(TxtName.Text)
        TxtLast.Text = ""
        保存模板(n)
        mz.新增(n)
    End Sub

    Private Sub ButREAD_Click(sender As Object, e As EventArgs) Handles ButREAD.Click, ListWebs.SelectedIndexChanged
        GBweb.Text = ""
        ButSave.Enabled = False
        Dim n As 模板 = mz.读取当前项
        If IsNothing(n) Then Exit Sub
        GBweb.Text = n.名字
        With n
            TxtURL.Text = .元素("url")
            TxtUA.Text = .元素("ua")
            TxtOrigin.Text = .元素("origin")
            TxtCookie.Text = .元素("cookie")
            TxtReferer.Text = .元素("ref")
            TxtRegex.Text = .元素("regex")
            TxtLast.Text = .元素("last")
        End With
        ButSave.Enabled = True
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        Dim n As 模板 = mz.获得模板(GBweb.Text)
        If IsNothing(n) Then Exit Sub
        保存模板(n)
    End Sub

    Private Sub 保存模板(n As 模板)
        推送()
        If IsNothing(n) Then Exit Sub
        With n
            .元素("url") = TxtURL.Text
            .元素("ua") = TxtUA.Text
            .元素("origin") = TxtOrigin.Text
            .元素("cookie") = TxtCookie.Text
            .元素("ref") = TxtReferer.Text
            .元素("last") = TxtLast.Text
            .元素("regex") = TxtRegex.Text
        End With
    End Sub

    Private Sub 网站监视器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("HTTPwatchwhen") = ListWhen.SelectedIndex.ToString
    End Sub

    Sub 后台监视()
        Dim N As Integer = 0, c As Integer, mb As 模板, h As 简易HTTP, s As String, wt As 委托消息
        Do While True
            Thread.Sleep(1000 * 10)
            推送()
            If 后台定时器启用(ListWhen) Then
                c = ListWebs.Items.Count
                If c > 0 Then
                    mb = mz.获得模板(ListWebs.Items.Item(N))
                    If Not IsNothing(mb) Then
                        With mb
                            Try
                                h = New 简易HTTP(.元素("url"), "GET")
                                h.UA = .元素("ua")
                                h.Origin = .元素("origin")
                                h.Referer = .元素("ref")
                                h.Cookie = .元素("cookie")
                                s = h.获得回应
                                If .元素("regex").Length > 0 AndAlso 正确正则表达式(.元素("regex")) Then
                                    s = Regex.Match(s, .元素("regex")).ToString
                                End If
                            Catch ex As Exception
                                s = ex.Message
                            End Try
                            s = Trim(s.ToLower)
                            If .元素("last").Length > 0 Then
                                If s <> .元素("last") Then
                                    .元素("last") = s
                                    wt = New 委托消息(AddressOf 消息)
                                    Invoke(wt, .名字 + vbCrLf + "网站有变化！")
                                    If Not 在列表(更新过的, .名字) Then 更新过的.Add(.名字)
                                End If
                            Else
                                .元素("last") = s
                            End If
                            If Not IsNothing(mz.读取当前项) Then
                                If mz.读取当前项.名字 = .名字 Then 刷新最后回应()
                            End If
                        End With
                    End If
                    N += 1
                    If N >= c Then N = 0
                End If
            End If
            推送()
        Loop
    End Sub

    Private Sub ButChrome_Click(sender As Object, e As EventArgs) Handles ButChrome.Click
        TxtUA.Text = 浏览器UA.Chrome64
    End Sub

    Private Sub ButiPhone_Click(sender As Object, e As EventArgs) Handles ButiPhone.Click
        TxtUA.Text = 浏览器UA.iPhone7
    End Sub

    Private Sub ButIE_Click(sender As Object, e As EventArgs) Handles ButIE.Click
        TxtUA.Text = 浏览器UA.IE11
    End Sub

    Private Sub ButRM_Click(sender As Object, e As EventArgs) Handles ButRM.Click
        GBweb.Text = ""
        ButSave.Enabled = False
    End Sub

    Sub 刷新最后回应() Handles Me.Activated
        Dim n As 模板 = mz.读取当前项
        If IsNothing(n) Then Exit Sub
        TxtLast.Text = n.元素("last")
        推送()
    End Sub

    Sub 推送()
        Tag = ""
        For Each i As String In 更新过的
            If Not IsNothing(mz.获得模板(i)) Then
                Tag += " 网站有更新：" + i + vbCrLf
            End If
        Next
        Tag = 去右(Tag, 2)
    End Sub

End Class