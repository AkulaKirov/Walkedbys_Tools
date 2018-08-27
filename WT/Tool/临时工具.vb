
Public Class 临时工具

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GMA("e:\a.gma")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GMA("e:\b.gma")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GMA("e:\c.gma")
    End Sub

    Sub GMA(sf As String)
        Dim r As New BinaryReader(File.OpenRead(sf))
        PRT("开始")
        PRT("识别", 字符转字符串(r.ReadChars(4)))
        PRT("版本", r.ReadByte)
        PRT("用户ID", r.ReadUInt64)
        PRT("时间戳", UNIX时间恢复(r.ReadUInt64))
        PRT("无意义的一个字节：", r.ReadByte())
        PRT("名字：", 读取字符串到零(r))
        PRT("简介：", 读取字符串到零(r))
        PRT("作者：", 读取字符串到零(r))
        PRT("版本：", r.ReadInt32)
        Do While True
            Dim i As Integer = r.ReadUInt32
            If i = 0 Then Exit Do
            PRT("文件：", i)
            PRT("文件名：", 读取字符串到零(r))
            PRT("文件大小：", r.ReadInt64)
            PRT("文件CRC校验：", r.ReadUInt32)
        Loop
        r.Close()
        PRT("over==")
    End Sub

    Private Sub 临时工具_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        启动器.Nico.Visible = False
        End
    End Sub


End Class