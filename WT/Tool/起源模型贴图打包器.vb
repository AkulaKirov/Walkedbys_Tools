
Public Class 起源模型贴图打包器

    Dim 贴图列表 As New List(Of String)
    Dim 文件夹列表 As New List(Of String)

    Private Sub 起源模型贴图打包器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件夹(TxtMaterials, TxtModels, TxtCopy)
        TxtMaterials.Text = 设置.元素("PackMaterial")
        TxtModels.Text = 设置.元素("PackModel")
        TxtCopy.Text = 设置.元素("PackCopy")
        文本框自动拖到最后(TxtList)
    End Sub

    Private Sub TxtMaterials_TextChanged(sender As Object, e As EventArgs) Handles TxtMaterials.TextChanged, TxtCopy.TextChanged, TxtModels.TextChanged
        If Not (TxtMaterials.Text.EndsWith("\materials\") OrElse TxtMaterials.Text.EndsWith("\materials")) Then TxtMaterials.Text = ""
        ButGo.Enabled = 文本框都有字(TxtMaterials, TxtModels, TxtCopy)
        ButList.Enabled = 文本框都有字(TxtModels)
    End Sub

    Private Sub 起源模型贴图打包器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("PackMaterial") = TxtMaterials.Text
        设置.元素("PackModel") = TxtModels.Text
        设置.元素("PackCopy") = TxtCopy.Text
    End Sub

    Private Sub ButList_Click(sender As Object, e As EventArgs) Handles ButList.Click
        TxtList.Text = "输出："
        贴图列表.Clear()
        文件夹列表.Clear()
        Dim i As String, models As String = TxtModels.Text
        Dim r As BinaryReader, tc As Integer, fc As Integer, n As Integer, s As String, n2 As Integer
        For Each i In Directory.GetFiles(models, "*.mdl", SearchOption.AllDirectories)
            If 文件可用(i) Then
                r = New BinaryReader(File.OpenRead(i))
                r.BaseStream.Position = 204
                tc += r.ReadInt32
                r.ReadInt32()
                fc += r.ReadInt32
                If tc > 32 Then tc = 32
                If fc > 32 Then fc = 32
                s = ""
                n = r.BaseStream.Length
                Do While True
                    r.BaseStream.Position = n - 1
                    n2 = r.ReadByte
                    If n2 = 0 Then
                        If s.Length > 0 Then
                            s = StrReverse(s.ToLower).Replace("/", "\")
                            If s.StartsWith("\") Then s = 去左(s, 1)
                            If 文件夹列表.Count < fc Then
                                文件夹列表.Add(追加斜杠(s))
                            Else
                                贴图列表.Add(s)
                            End If
                        End If
                        s = ""
                    Else
                        s += Chr(n2)
                    End If
                    If 文件夹列表.Count = fc AndAlso 贴图列表.Count = tc Then Exit Do
                    n -= 1
                    If n < 408 Then Exit Do
                Loop
                r.Close()
            Else
                TxtList.Text += vbCrLf + 去除(i, models) + " 不存在或者无法读取。"
            End If
        Next
        TxtList.Text += vbCrLf
        列表去重(文件夹列表)
        列表去重(贴图列表)
        TxtList.Text += "贴图文件夹列表：" + 括(文件夹列表.Count.ToString) + vbCrLf + 列表转文字(文件夹列表) + vbCrLf + vbCrLf
        TxtList.Text += "贴图 vmt 列表：" + 括(贴图列表.Count.ToString) + vbCrLf + 列表转文字(贴图列表)
    End Sub

    Private Sub ButGo_Click(sender As Object, e As EventArgs) Handles ButGo.Click
        ButList.PerformClick()
        If 贴图列表.Count < 1 OrElse 文件夹列表.Count < 1 Then Exit Sub
        Dim i As String, i2 As String, i3 As String, mats As String = TxtMaterials.Text
        Dim cp As String = TxtCopy.Text, s As String, s2 As String
        Const v As String = ".vmt", f As String = ".vtf"
        Dim ps As String() = {"$baseTexture", "$bumpmap", "$detail", "$lightwarptexture", "$envmap"}
        文件夹列表.Add("")
        Dim out As New List(Of String)
        For Each i In 文件夹列表
            For Each i2 In 贴图列表
                s = mats + i + i2 + v
                s2 = cp + i + i2 + v
                If 文件可用(s) Then
                    out.Add(i + i2 + v)
                    Directory.CreateDirectory(文件路径(s2))
                    File.Copy(s, s2, True)
                    s2 = 读文件(s2)
                    For Each i3 In ps
                        s = 读取VMT(s2, i3)
                        If s.Length > 0 AndAlso 文件存在(mats + s + f) Then
                            out.Add(s + f)
                            Directory.CreateDirectory(文件路径(cp + s))
                            File.Copy(mats + s + f, cp + s + f, True)
                        End If
                    Next
                End If
            Next
        Next
        列表去重(out)
        TxtList.Text += vbCrLf + vbCrLf + "实际输出：" + 括(out.Count.ToString) + vbCrLf + 列表转文字(out) + vbCrLf + "完成"
    End Sub

    Private Function 读取VMT(vmt As String, n As String) As String
        vmt = 正则去除(vmt.ToLower, "/\*([\s\S]*?)\*/")
        n = n.ToLower
        If vmt.Length < 3 Then Return ""
        If Not 包含(vmt, n) Then Return ""
        vmt = vmt.Replace(vbTab, " ")
        Dim f As List(Of String) = 分割(vmt, vbCrLf)
        For Each i As String In f
            i = Trim(i)
            If Not (i.StartsWith("//") OrElse i.StartsWith("--")) AndAlso 包含(i, n) Then
                Return Trim(去除(i, vbQuote, n, ".vtf").Replace("/", "\"))
            End If
        Next
        Return ""
    End Function

End Class