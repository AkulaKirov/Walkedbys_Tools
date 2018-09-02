
Public Class 随机生成器

    Private Sub 随机生成器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtLen.Value = 设置.读取数("RandomLength", 100)
        ListObj.SelectedIndex = 设置.读取数("RandomOBJ", 0)
    End Sub

    Private Sub 随机生成器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("RandomLength") = TxtLen.Value.ToString
        设置.元素("RandomOBJ") = ListObj.SelectedIndex.ToString
    End Sub

    Private Sub ButGen_Click(sender As Object, e As EventArgs) Handles ButGen.Click
        Dim l As Integer = TxtLen.Value
        If l < 1 Then l = 1
        If l > 10000 Then l = 10000
        Dim out As String = "", i As Integer
        Select Case ListObj.Text
            Case "中文句子"
                Do Until out.Length > l
                    out += 随机.汉字(随机.整数(20, 2)) + 随机.多选一("，", "。", "？", "！", "……")
                    If out.Length > l Then Exit Do
                Loop
            Case "英文句子"
                out += 随机.小写字母(1).ToUpper
                Do Until out.Length > l
                    If 是当中一个(右(Trim(out), 1), ".", "?", "!") Then out += 随机.小写字母(1).ToUpper
                    out += 随机.小写字母(随机.整数(8, 2)) + 随机.多选一(",", ".", "?", "!", "", "", "", "", "") + " "
                Loop
            Case "数字"
                out = 随机.数字(l)
            Case "小写字母"
                out = 随机.小写字母(l)
            Case "大写字母"
                out = 随机.小写字母(l).ToUpper
            Case "汉字"
                out = 随机.汉字(l)
            Case "数字+大小写字母"
                For i = 1 To l
                    out += 随机.多选一(随机.数字(1), 随机.小写字母(1), 随机.小写字母(1).ToUpper)
                Next
            Case "汉字+数字+大小写字母"
                For i = 1 To l
                    out += 随机.多选一(随机.数字(1), 随机.小写字母(1), 随机.小写字母(1).ToUpper, 随机.汉字(1))
                Next
            Case "CDKEY"
                Do Until out.Length > l
                    For i = 1 To 3
                        For i2 As Integer = 1 To 5
                            out += 随机.多选一(随机.小写字母(1).ToUpper, 随机.数字(1))
                        Next
                        If i < 3 Then out += "-"
                    Next
                    out += vbCrLf
                Loop
        End Select
        TxtOut.Text = out
    End Sub

    Private Sub TxtOut_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtOut.KeyUp
        If e.Control AndAlso e.KeyCode = Keys.A Then
            TxtOut.SelectAll()
        End If
    End Sub

End Class