
Public Class 临时工具
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim b As Image = 剪贴板.图片
        If Not IsNothing(b) Then b.Save("e:\1.jpg")
    End Sub
End Class