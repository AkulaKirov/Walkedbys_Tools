
Public Class VMT生成器

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
        设置.保存元素("vmtLAST", TxtVMT.Text)
        设置.保存元素("vmtSON", CheckSon.Checked)
        设置.保存元素("vmtPATH", TxtPath.Text)
    End Sub

    Private Sub ButGen_Click(sender As Object, e As EventArgs) Handles ButGen.Click
        TxtLog.Text = ""
        Dim i As Boolean = Watching.Enabled
        TxtVMT.Enabled = i
        ListParms.Enabled = i
        TxtPath.Enabled = i
        Watching.Enabled = Not i
        ButGen.Text = IIf(Not i, "停止监视与生成", "开始监视与生成")
        TxtLog.Text += vbCrLf + IIf(Not i, "开始：", "结束：") + Now.ToString
    End Sub

    Private Sub Watching_Tick(sender As Object, e As EventArgs) Handles Watching.Tick
        If Not Visible Then Exit Sub
        If Not 文件夹存在(TxtPath.Text) Then
            TxtLog.Text += vbCrLf + "出错：文件夹已经被删除。"
            ButGen.PerformClick()
            Exit Sub
        End If
        Dim f() As String = Directory.GetFiles(TxtPath.Text, "*.vtf", IIf(CheckSon.Checked, SearchOption.AllDirectories, SearchOption.TopDirectoryOnly))
        If f.Count < 1 Then Exit Sub
        Dim i As String
        For Each i In f
            Dim m As String = i.ToLower.Replace(".vtf", ".vmt")
            If Not 文件存在(m) Then
                Dim s As String = TxtVMT.Text, t As String = 正则去除(m, ".*materials\\", "\.vmt"), t2 As String = 去右(去除(t, 文件名(t)), 1)
                Dp(t2)
                If t.Length > 0 Then
                    s = s.Replace("%文件名%", t)
                    s = s.Replace("%路径%", t2)
                    写文件(m, s)
                    TxtLog.Text += vbCrLf + "已生成：" + t
                End If
            End If
        Next
    End Sub

End Class