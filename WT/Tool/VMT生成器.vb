Imports System.ComponentModel

Public Class VMT生成器

    Dim 模板 As New List(Of String)

    Private Sub VMT生成器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPath.Text = 读取("vmtPATH")
        TxtVMT.Text = 读取("vmtLAST")
        文字转列表(模板, 读取("vmtTEMPs"))
        Dim i As String
        If 模板.Count > 0 Then
            For Each i In 模板
                i = 去右(Regex.Match(i, ".+___").ToString, 3)
                CBtemplete.Items.Add(i)
            Next
            CBtemplete.SelectedIndex = CBtemplete.Items.Count - 1
        End If
        文本框拖入文件(TxtPath)
        文本框全选(Me)
    End Sub

    Private Sub TxtPath_TextChanged(sender As Object, e As EventArgs) Handles TxtPath.TextChanged
        GBvmt.Enabled = False
        Dim i As String = TxtPath.Text
        If i.Length < 1 Then Exit Sub
        i = 追加斜杠(i.ToLower.Replace("/", "\"))
        If 包含(i, "\materials\") AndAlso 文件夹存在(i) Then
            TxtPath.Text = i
            保存("vmtPATH", i)
            GBvmt.Enabled = True
        Else
            TxtPath.Text = ""
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

    Private Sub TxtTempName_TextChanged(sender As Object, e As EventArgs) Handles TxtTempName.TextChanged, ButDEL.Click, TxtVMT.TextChanged
        Dim i As String = Trim(TxtTempName.Text)
        ButADD.Enabled = (i.Length > 0 AndAlso Not 在列表(CBtemplete.Items, i) AndAlso TxtVMT.TextLength > 10)
        ButGen.Enabled = (TxtVMT.TextLength > 10)
    End Sub

    Private Sub ButADD_Click(sender As Object, e As EventArgs) Handles ButADD.Click
        Dim i As String = Trim(TxtTempName.Text)
        CBtemplete.Items.Add(i)
        i += "___" + Regex.Escape(TxtVMT.Text)
        模板.Add(i)
        TxtTempName.Text = ""
        CBtemplete.SelectedIndex = CBtemplete.Items.Count - 1
    End Sub

    Private Sub VMT生成器_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        保存("vmtTEMPs", 列表转文字(模板))
        保存("vmtLAST", TxtVMT.Text)
    End Sub

    Private Sub CBtemplete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBtemplete.SelectedIndexChanged
        Dim i As Integer = CBtemplete.SelectedIndex
        ButUSE.Enabled = (i > -1)
        ButDEL.Enabled = ButUSE.Enabled
    End Sub

    Private Sub ButUSE_Click(sender As Object, e As EventArgs) Handles ButUSE.Click
        Dim s As String = CBtemplete.Text
        For Each i As String In 模板
            If i.StartsWith(s + "___") Then
                TxtVMT.Text = Regex.Unescape(去左(i, s.Length + 3))
                Exit For
            End If
        Next
    End Sub

    Private Sub ButDEL_Click(sender As Object, e As EventArgs) Handles ButDEL.Click
        Dim s As String = CBtemplete.Text, i As String = ""
        For Each i In 模板
            If i.StartsWith(s + "___") Then Exit For
        Next
        模板.Remove(i)
        移除一项(CBtemplete, CBtemplete.SelectedIndex)
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
        Dim f() As String = Directory.GetFiles(TxtPath.Text, "*.vtf", SearchOption.TopDirectoryOnly)
        If f.Count < 1 Then Exit Sub
        Dim i As String
        For Each i In f
            Dim m As New 文件(i.ToLower.Replace(".vtf", ".vmt"))
            If Not m.存在 Then
                Dim s As String = TxtVMT.Text, t As String = 正则去除(m.地址, ".*materials\\", "\.vmt")
                s = s.Replace("%文件名%", t)
                m.写(s)
                TxtLOG.Text += vbCrLf + "已生成：" + t
            End If
        Next
    End Sub

    Private Sub TxtLOG_TextChanged(sender As Object, e As EventArgs) Handles TxtLOG.TextChanged
        TxtLOG.SelectionStart = TxtLOG.TextLength
        TxtLOG.ScrollToCaret()
    End Sub

End Class