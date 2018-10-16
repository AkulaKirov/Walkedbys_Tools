
Public Class 临时工具

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As New 简易HTTP("http://img.tv.sohu.com/ndfs/uploadPhoto.do?appid=100114&allowGif=1&needCompress=false&isSupportHttps=true", "POST")
        Dim m As New 简易MultiPartFormData(h)
        m.新文件("file", "e:\a.jpg", "image/jpeg")
        m.结束()
        Dp(m.数据预览)
        Dp(h.获得回应)
    End Sub

End Class