
Public Class 临时工具

    Private Sub Button1_Click() Handles Button1.Click
        Dim r As New BinaryReader(File.OpenRead(程序文件目录 + "a.c"))
        Txt.Text = 读取字符串到零(r)
        r.Close()
    End Sub

End Class
