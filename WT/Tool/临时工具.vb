
Public Class 临时工具

    Dim ck As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As New 简易HTTP("https://m.weibo.cn/api/container/getIndex?sudaref=login.sina.com.cn&containerid=1076035977985000&since_id=4297235569830932")
        h.Referer = "https://m.weibo.cn/p/1005055977985000?sudaref=login.sina.com.cn"
        h.Origin = "https://m.weibo.cn"
        h.Cookie = ck
        Dp(h.获得回应)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim h As New 简易HTTP("https://m.weibo.cn/profile/delMyblog", "POST")
        h.Referer = "https://m.weibo.cn/detail/4299253046095124"
        h.Cookie = ck
        h.设置头("MWeibo-Pwa", "1")
        h.UA = 浏览器UA.iPhone7
        h.写入("mid=4299253046095124&st=fa139c")
        Dp(h.获得回应)
    End Sub

End Class
