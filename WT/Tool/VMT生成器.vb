
Public Class VMT生成器

    Dim mz As 模板组

    Private Sub VMT生成器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPath.Text = 设置.元素("vmtPATH")
        TxtVMT.Text = 设置.元素("vmtLAST")
        TxtSkip.Text = 设置.元素("vmtSKIP")
        mz = New 模板组("VMTG", ListTemps, TxtTempName, ButADD, ButDEL)
        CheckSon.Checked = 设置.读取真假("vmtSON")
        文本框拖入文件夹(TxtPath)
    End Sub

    Private Sub TxtPath_TextChanged(sender As Object, e As EventArgs) Handles TxtPath.TextChanged
        Dim i As String = TxtPath.Text
        If i.Length < 1 Then Exit Sub
        i = 追加斜杠(i.ToLower.Replace("/", "\"))
        If 包含(i, "\materials\") AndAlso 文件夹存在(i) Then
            TxtPath.Text = i
            设置.保存元素("vmtPATH", i)
            GBvmt.Enabled = True
        Else
            TxtPath.Text = ""
            GBvmt.Enabled = False
        End If
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

    Private Sub TxtTempName_TextChanged(sender As Object, e As EventArgs) Handles TxtTempName.TextChanged, ButDEL.Click, TxtVMT.TextChanged, TxtSkip.TextChanged, TxtPath.TextChanged
        Dim i As String = Trim(TxtTempName.Text)
        ButADD.Enabled = (i.Length > 0 AndAlso Not 在列表(ListTemps.Items, i) AndAlso TxtVMT.TextLength > 10)
        ButGen.Enabled = (TxtVMT.TextLength > 10 AndAlso 正确正则表达式(TxtSkip.Text) AndAlso TxtPath.TextLength > 10)
    End Sub

    Private Sub VMT生成器_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        设置.保存元素("vmtLAST", TxtVMT.Text)
        设置.保存元素("vmtSKIP", TxtSkip.Text)
        设置.保存元素("vmtSON", CheckSon.Checked)
    End Sub

    Private Sub CBtemplete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTemps.SelectedIndexChanged
        Dim i As Integer = ListTemps.SelectedIndex
        If i < 0 Then Exit Sub
        Dim n As 模板 = mz.读取当前项
        TxtVMT.Text = n.元素("pars")
    End Sub

    Private Sub ButGen_Click(sender As Object, e As EventArgs) Handles ButGen.Click
        Dim i As Boolean = Watching.Enabled
        Watching.Enabled = Not i
        TxtPath.Enabled = i
        GBvmt.Enabled = i
        ButGen.Text = IIf(Not i, "停止监视与生成", "开始监视与生成")
        TxtLOG.Text += vbCrLf + IIf(Not i, "开始：", "结束：") + Now.ToString
    End Sub

    Private Sub Watching_Tick(sender As Object, e As EventArgs) Handles Watching.Tick
        If Not Visible Then Exit Sub
        If Not 文件夹存在(TxtPath.Text) Then
            TxtLOG.Text += vbCrLf + "出错：文件夹已经被删除。"
            ButGen.PerformClick()
            Exit Sub
        End If
        Dim f() As String = Directory.GetFiles(TxtPath.Text, "*.vtf", IIf(CheckSon.Checked, SearchOption.AllDirectories, SearchOption.TopDirectoryOnly))
        If f.Count < 1 Then Exit Sub
        Dim i As String
        For Each i In f
            Dim m As String = i.ToLower.Replace(".vtf", ".vmt")
            If Not 文件存在(m) Then
                Dim s As String = TxtVMT.Text, t As String = 正则去除(m, ".*materials\\", "\.vmt")
                If t.Length > 0 Then
                    Dim sw As String = TxtSkip.Text
                    If (sw.Length > 0 AndAlso Not Regex.IsMatch(t, sw)) OrElse (sw.Length < 1) Then
                        s = s.Replace("%文件名%", t)
                        写文件(m, s)
                        TxtLOG.Text += vbCrLf + "已生成：" + t
                    End If
                End If
            End If
        Next
    End Sub

    Private Sub TxtLOG_TextChanged(sender As Object, e As EventArgs) Handles TxtLOG.TextChanged
        TxtLOG.SelectionStart = TxtLOG.TextLength
        TxtLOG.ScrollToCaret()
    End Sub

    Private Sub ButADD_Click(sender As Object, e As EventArgs) Handles ButADD.Click
        Dim n As New 模板(TxtTempName.Text)
        n.元素("pars") = TxtVMT.Text
        mz.新增(n)
    End Sub

End Class