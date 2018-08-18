
Public Class 文件筛选

    Private Sub 文件筛选_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件夹(TxtFA, TxtFB, TxtFC)
        TxtFA.Text = 设置.元素("FileSelectA")
        TxtFB.Text = 设置.元素("FileSelectB")
        TxtFC.Text = 设置.元素("FileSelectC")
    End Sub

    Private Sub 文件筛选_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("FileSelectA") = TxtFA.Text
        设置.元素("FileSelectB") = TxtFB.Text
        设置.元素("FileSelectC") = TxtFC.Text
    End Sub

    Private Sub TxtFA_TextChanged(sender As Object, e As EventArgs) Handles TxtFA.TextChanged, TxtFB.TextChanged, TxtFC.TextChanged
        Pn.Enabled = (TxtFA.TextLength > 3 AndAlso TxtFB.TextLength > 3 AndAlso TxtFC.TextLength > 3)
    End Sub

    Private Sub ButAtoC_Click(sender As Object, e As EventArgs) Handles ButAtoC.Click
        AtoC(追加斜杠(TxtFA.Text), 追加斜杠(TxtFB.Text), 追加斜杠(TxtFC.Text))
    End Sub

    Private Sub ButBtoC_Click(sender As Object, e As EventArgs) Handles ButBtoC.Click
        AtoC(追加斜杠(TxtFB.Text), 追加斜杠(TxtFA.Text), 追加斜杠(TxtFC.Text))
    End Sub

    Private Sub ButAB2_Click(sender As Object, e As EventArgs) Handles ButAB2.Click
        ButAtoC.PerformClick()
        ButBtoC.PerformClick()
    End Sub

    Private Sub ButAB_Click(sender As Object, e As EventArgs) Handles ButAB.Click
        AtoC(追加斜杠(TxtFA.Text), 追加斜杠(TxtFB.Text), 追加斜杠(TxtFC.Text), True)
        AtoC(追加斜杠(TxtFB.Text), 追加斜杠(TxtFA.Text), 追加斜杠(TxtFC.Text), True)
    End Sub

    Function 获得文件夹(f As String) As String()
        Return Directory.GetDirectories(f, "*", SearchOption.AllDirectories)
    End Function

    Function 获得文件(f As String) As String()
        Return Directory.GetFiles(f, "*", SearchOption.AllDirectories)
    End Function

    Sub AtoC(a As String, b As String, c As String, Optional ys As Boolean = False)
        Dim i As String, j As String
        For Each i In 获得文件(a)
            j = 相对路径(i, a)
            If 文件存在(b + j) = ys Then
                Directory.CreateDirectory(文件路径(c + j))
                My.Computer.FileSystem.CopyFile(i, c + j, True)
            End If
        Next
        For Each i In 获得文件夹(a)
            j = 相对路径(i, a)
            If 文件夹存在(b + j) = ys Then
                Directory.CreateDirectory(c + j)
            End If
        Next
    End Sub

    Function 相对路径(a As String, b As String) As String
        Return 去除(a, b)
    End Function

End Class