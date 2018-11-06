﻿
Public Class 文件筛选

    Private Sub 文件筛选_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件夹(TxtFA, TxtFB, TxtFC)
        TxtFA.Text = 设置.字符串("FileSelectA")
        TxtFB.Text = 设置.字符串("FileSelectB")
        TxtFC.Text = 设置.字符串("FileSelectC")
    End Sub

    Private Sub 文件筛选_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.字符串("FileSelectA") = TxtFA.Text
        设置.字符串("FileSelectB") = TxtFB.Text
        设置.字符串("FileSelectC") = TxtFC.Text
    End Sub

    Private Sub TxtFA_TextChanged(sender As Object, e As EventArgs) Handles TxtFA.TextChanged, TxtFB.TextChanged, TxtFC.TextChanged
        Pn.Enabled = (TxtFA.TextLength > 3 AndAlso TxtFB.TextLength > 3 AndAlso TxtFC.TextLength > 3 AndAlso TxtFA.Text <> TxtFB.Text AndAlso TxtFC.Text <> TxtFB.Text AndAlso TxtFC.Text <> TxtFA.Text)
    End Sub

    Private Sub ButAtoC_Click(sender As Object, e As EventArgs) Handles ButAtoC.Click
        LabDone.Visible = False
        AtoC(追加斜杠(TxtFA.Text), 追加斜杠(TxtFB.Text), 追加斜杠(TxtFC.Text))
    End Sub

    Private Sub ButBtoC_Click(sender As Object, e As EventArgs) Handles ButBtoC.Click
        LabDone.Visible = False
        AtoC(追加斜杠(TxtFB.Text), 追加斜杠(TxtFA.Text), 追加斜杠(TxtFC.Text))
    End Sub

    Private Sub ButAB2_Click(sender As Object, e As EventArgs) Handles ButAB2.Click
        LabDone.Visible = False
        ButAtoC.PerformClick()
        ButBtoC.PerformClick()
    End Sub

    Private Sub ButAB_Click(sender As Object, e As EventArgs) Handles ButAB.Click
        LabDone.Visible = False
        AtoC(追加斜杠(TxtFA.Text), 追加斜杠(TxtFB.Text), 追加斜杠(TxtFC.Text), True)
        AtoC(追加斜杠(TxtFB.Text), 追加斜杠(TxtFA.Text), 追加斜杠(TxtFC.Text), True)
    End Sub

    Function 获取文件夹(f As String) As String()
        Return Directory.GetDirectories(f, "*", SearchOption.AllDirectories)
    End Function

    Function 获取文件(f As String) As String()
        Return Directory.GetFiles(f, "*", SearchOption.AllDirectories)
    End Function

    Sub AtoC(a As String, b As String, c As String, Optional ys As Boolean = False)
        Dim i As String, j As String
        For Each i In 获取文件(a)
            j = 相对路径(i, a)
            If 文件存在(b + j) = ys Then
                Try
                    Directory.CreateDirectory(文件路径(c + j))
                    My.Computer.FileSystem.CopyFile(i, c + j, True)
                Catch ex As Exception
                End Try
            End If
        Next
        For Each i In 获取文件夹(a)
            j = 相对路径(i, a)
            If 文件夹存在(b + j) = ys Then
                Try
                    Directory.CreateDirectory(c + j)
                Catch ex As Exception
                End Try
            End If
        Next
        LabDone.Visible = True
    End Sub

    Function 相对路径(a As String, b As String) As String
        Return 去除(a, b)
    End Function

End Class