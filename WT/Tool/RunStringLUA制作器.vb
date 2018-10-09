
Public Class RunStringLUA制作器

    Dim LUA As String

    Private Sub RunStringLUA制作器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtLUA_TextChanged(sender, e)
    End Sub

    Sub RP(n As String, Optional 替换 As String = " ")
        LUA = LUA.Replace(n, 替换)
    End Sub

    Sub RPc(ParamArray n() As String)
        For Each i As String In n
            LUA = LUA.Replace(i + " ", i)
            LUA = LUA.Replace(" " + i, i)
        Next
    End Sub

    Private Sub ButDo_Click(sender As Object, e As EventArgs) Handles ButDo.Click
        LUA = 正则去除(LUA, "\-\-.*", "//.*")
        LUA = 正则去除(LUA, "\-\-\[\[([\s\S]*?)\]\]")
        RPc("(", ")", "=", "<", ">", "+", "-", "*", ",", "..")
        Dim AddCS As Boolean = 包含(LUA, "AddCSLuaFile()")
        RP("AddCSLuaFile()")
        Dim s As String = "utf8.char(", i As Integer, f As String = ""
        Dim r As Integer = 随机.整数(1, 40)
        Dim n(r) As String, nc(r) As Integer, g1 As Integer, g2 As Integer, g3 As Integer
        For i = 0 To r
            n(i) = Mid("zxcvbnmasdfghjklqwertyuiopQWERTYUIOPASDFGHJKLZXCVBNM", i + 1, 1)
            nc(i) = 随机.整数(9, 100)
            f += "local " + n(i) + "=" + nc(i).ToString + " "
        Next
        For i = 0 To LUA.Length - 1
            g1 = 随机.整数(0, r)
            g3 = AscW(LUA(i))
            Select Case 随机.整数(0, 2)
                Case 0
                    s += (g3 - nc(g1)).ToString + "+" + n(g1)
                Case 1
                    s += n(g1) + "-" + (nc(g1) - g3).ToString
                Case 2
                    g2 = 随机.整数(73, 241)
                    s += (g3 + g2).ToString + "-" + g2.ToString
            End Select
            s += ","
            If i Mod 80 = 0 AndAlso i > 70 AndAlso i <> LUA.Length - 1 Then
                s = 去右(s, 1) + ")..utf8.char("
            End If
        Next
        s = s.Replace("--", "+")
        s = 去右(s, 1) + ")"
        s = "RunString(" + s + ")"
        LUA = IIf(AddCS, "AddCSLuaFile()", "") + f + s
        TxtLUA.Text = Trim(LUA)
    End Sub

    Private Sub TxtLUA_TextChanged(sender As Object, e As EventArgs) Handles TxtLUA.TextChanged
        With TxtLUA
            Dim i As Integer = .TextLength
            ButDo.Enabled = (i > 0 AndAlso i <= .MaxLength)
            ButCopy.Enabled = (i > 0)
            LUA = 回车规范(TxtLUA.Text)
            LabLen.Text = "长度：" & i & "/" & .MaxLength
        End With
    End Sub

    Private Sub TxtLUA_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtLUA.KeyUp
        If e.Control AndAlso e.KeyCode = Keys.A Then TxtLUA.SelectAll()
    End Sub

    Private Sub ButCopy_Click(sender As Object, e As EventArgs) Handles ButCopy.Click
        剪贴板.文本 = TxtLUA.Text
    End Sub

    Private Sub RunStringLUA制作器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        TxtLUA.Text = ""
    End Sub

End Class