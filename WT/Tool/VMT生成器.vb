
Public Class VMT生成器

    Dim 特殊列表 As New List(Of String), 特殊列表2 As New List(Of String), VMT文本 As String

    Private Sub VMT生成器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPath.Text = 设置.字符串("vmtPATH")
        TxtVMT.Text = 设置.字符串("vmtLAST")
        CheckSon.Checked = 设置.布林("vmtSON")
        文本框拖入文件夹(TxtPath)
    End Sub

    Private Sub TxtPath_TextChanged(sender As Object, e As EventArgs) Handles TxtPath.TextChanged
        Dim i As String = TxtPath.Text
        If i.Length < 1 Then Exit Sub
        i = 追加斜杠(i.ToLower.Replace("/", "\"))
        If 包含(i, "\materials\") AndAlso 文件夹存在(i) Then
            TxtPath.Text = i
        Else
            TxtPath.Text = ""
        End If
    End Sub

    Private Sub TxtVMT_TextChanged(sender As Object, e As EventArgs) Handles TxtVMT.TextChanged, TxtPath.TextChanged
        ButGen.Enabled = 文本框都有字(TxtVMT, TxtPath)
    End Sub

    Private Sub ListParms_DoubleClick(sender As Object, e As EventArgs) Handles ListParms.DoubleClick
        Dim i As Integer = ListParms.SelectedIndex
        If i < 0 Then Exit Sub
        Dim s As String = ListParms.Items.Item(i)
        s = s.Replace("\n", vbCrLf)
        Dim g As String = TxtVMT.Text
        i = TxtVMT.SelectionStart
        TxtVMT.Text = g.Insert(i, s + vbCrLf)
        TxtVMT.SelectionStart = i + s.Length + vbCrLf.Length
        TxtVMT.Focus()
    End Sub

    Private Sub VMT生成器_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        设置.字符串("vmtLAST") = TxtVMT.Text
        设置.布林("vmtSON") = CheckSon.Checked
        设置.字符串("vmtPATH") = TxtPath.Text
        If Watching.Enabled Then ButGen.PerformClick()
    End Sub

    Private Sub ButGen_Click(sender As Object, e As EventArgs) Handles ButGen.Click
        Dim i As Boolean = Watching.Enabled
        TxtVMT.Enabled = i
        ListParms.Enabled = i
        TxtPath.Enabled = i
        Watching.Enabled = Not i
        特殊列表.Clear()
        特殊列表2.Clear()
        If Not i Then
            TxtLog.Text = ""
            VMT文本 = TxtVMT.Text
            For Each m As Match In Regex.Matches(VMT文本, 引("%文件名%.{1,}"))
                特殊列表.Add(去除(m.ToString, 引号, "%文件名%"))
            Next
            For Each m As Match In Regex.Matches(VMT文本, 引("%路径%.{1,}"))
                特殊列表2.Add(去除(m.ToString, 引号, "%路径%\"))
            Next
        End If
        ButGen.Text = IIf(Not i, "停止监视与生成", "开始监视与生成")
        日志(IIf(Not i, "开始：", "结束：") + Now.ToString)
    End Sub

    Private Sub Watching_Tick(sender As Object, e As EventArgs) Handles Watching.Tick
        If Not Visible Then Exit Sub
        Watching.Enabled = False
        Dim path As String = 追加斜杠(TxtPath.Text)
        If Not 文件夹存在(path) Then
            日志("出错：文件夹已经被删除。 " & path)
            ButGen.PerformClick()
            Exit Sub
        End If
        Dim f() As String = Directory.GetFiles(path, "*?.vtf", IIf(CheckSon.Checked, SearchOption.AllDirectories, SearchOption.TopDirectoryOnly))
        If f.Count < 1 Then Exit Sub
        Dim i As String, s As String, m As String, t As String, t2 As String, ok As Boolean = True, tn As String
        path = 左(path, 1) + 提取(path.ToLower, 左(path, 1), "\materials\") + "\materials\"
        For Each i In f
            m = 去右(i, 4)
            ok = True
            For Each s In 特殊列表
                If m.EndsWith(s) Then
                    ok = False
                    Exit For
                End If
            Next
            For Each s In 特殊列表2
                If m.EndsWith("\" + s) Then
                    ok = False
                    Exit For
                End If
            Next
            If ok Then
                m += ".vmt"
                s = VMT文本
                If Not 文件存在(m) Then
                    tn = 正则去除(m, ".*materials\\", "\.vmt")
                    t2 = 去右(去除(tn, 文件名(tn)), 1)
                    If tn.Length > 0 Then
                        s = s.Replace("%文件名%", tn)
                        s = s.Replace("%路径%", t2)
                        For Each t In 特殊列表2
                            t2 = path + t + ".vtf"
                            If 文件存在(t2) = False Then
                                s = 正则去除(s, "\$.*" + Regex.Escape(t) + 引号)
                            End If
                        Next
                        For Each t In 特殊列表
                            t2 = path + tn + t + ".vtf"
                            If 文件存在(t2) = False Then
                                s = 正则去除(s, "\$.*" + Regex.Escape(t) + 引号)
                            End If
                        Next
                        写文件(m, 去多余回车(s))
                        日志("已生成：" + tn)
                    End If
                End If
            End If
        Next
        Watching.Enabled = True
    End Sub

End Class