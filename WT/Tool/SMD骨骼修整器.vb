
Public Class SMD骨骼修整器

    Dim smd As SMD文件
    Dim smd文件 As String = ""

    Private Sub SMD骨骼修整器_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        文本框拖入文件(TxtSMD)
        TxtSMD.Text = 设置.元素("SMDfile")
        文字转列表(ListOtherBones.Items, 设置.元素("SMDbones"))
        文字转列表(ListOtherMaterial.Items, 设置.元素("SMDmaterials"))
        TxtLOG.Text = 设置.元素("SMDlog")
    End Sub

    Private Sub TxtSMD_TextChanged(sender As Object, e As EventArgs) Handles TxtSMD.TextChanged
        Dim s As String = TxtSMD.Text
        If 文件后缀(s) <> "smd" Then
            TxtSMD.Text = ""
            ButGoRead.Enabled = False
        Else
            ButGoRead.Enabled = True
        End If
    End Sub

    Private Sub SMD骨骼修整器_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        设置.元素("SMDfile") = TxtSMD.Text
        设置.元素("SMDbones") = 列表转文字(ListOtherBones.Items)
        设置.元素("SMDmaterials") = 列表转文字(ListOtherMaterial.Items)
        设置.元素("SMDlog") = TxtLOG.Text
    End Sub

    Private Sub ListBones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBones.SelectedIndexChanged
        If IsNothing(ListBones.SelectedItem) Then Exit Sub
        Dim n As SMD骨骼 = smd.名字骨骼(ListBones.SelectedItem.ToString)
        LabBoneInfo.Text = n.名字 + vbCrLf
        LabBoneInfo.Text += n.ToString + vbCrLf + "位置：" + n.位置.ToString + "  方向：" + n.方向.ToString + vbCrLf
        If Not IsNothing(n.父骨骼) Then
            LabBoneInfo.Text += "父骨骼：" + n.父骨骼.名字
            ButDEL.Enabled = True
        Else
            LabBoneInfo.Text += "（根骨骼）"
            ButDEL.Enabled = False
        End If
        TxtRename.Text = n.名字
    End Sub

    Private Function 获得当前骨骼() As SMD骨骼
        If IsNothing(ListBones.SelectedItem) Then
            Return Nothing
        Else
            Return smd.名字骨骼(ListBones.SelectedItem.ToString)
        End If
    End Function

    Private Sub ButGoRead_Click(sender As Object, e As EventArgs) Handles ButGoRead.Click
        ListBones.Items.Clear()
        ListMaterial.Items.Clear()
        GBwork.Visible = False
        Dim s As String = TxtSMD.Text
        smd文件 = s
        GBwork.Text = "操作区 " + s
        smd = New SMD文件(读文件(s))
        For Each n As SMD骨骼 In smd.骨骼组
            ListBones.Items.Add(n.名字)
        Next
        For Each b As String In smd.贴图列表
            ListMaterial.Items.Add(b)
        Next
    End Sub

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles ButSave.Click
        Dim n As Date = Now
        写文件(smd文件, smd.ToString)
        LabBoneInfo.Text = IIf(文件可用(smd文件), "保存已完成", "文件可能不可用") + " 用时：" + FormatNumber(Abs(DateDiff(DateInterval.Minute, Now, n)), 1)
    End Sub

    Private Sub ButRename_Click(sender As Object, e As EventArgs) Handles ButRename.Click
        Dim n As SMD骨骼 = 获得当前骨骼()
        Dim s As String = n.名字
        n.名字 = TxtRename.Text
        Dim i As Integer = ListBones.SelectedIndex
        ListBones.Items.Item(i) = TxtRename.Text
        新增操作记录("rename " + 引(s) + "2" + 引(n.名字))
    End Sub

    Private Sub TxtRename_TextChanged(sender As Object, e As EventArgs) Handles TxtRename.TextChanged
        ButRename.Enabled = (TxtRename.TextLength > 0 AndAlso Not 在列表(ListBones.Items, TxtRename.Text))
    End Sub

    Private Sub Always_Tick(sender As Object, e As EventArgs) Handles Always.Tick
        If ListBones.Items.Count > 0 Then
            GBwork.Visible = True
            If ListBones.SelectedIndex < 0 Then ListBones.SelectedIndex = 0
        Else
            GBwork.Visible = False
        End If
    End Sub

    Private Sub ButDEL_Click(sender As Object, e As EventArgs) Handles ButDEL.Click
        Dim n As SMD骨骼 = 获得当前骨骼()
        Dim np As SMD骨骼 = n.父骨骼
        For Each ni As SMD骨骼 In n.获得子骨骼
            ni.父骨骼 = np
            ni.位置 = ni.位置 + n.位置
            ni.方向 = ni.方向 + n.方向
        Next
        For Each t As SMD面 In smd.面组
            For Each p As SMD点 In t.点
                If p.主骨骼 = n Then p.主骨骼 = np
                If p.附加骨骼数量 > 0 Then
                    For Each x As SMD点权重 In p.权重
                        If x.骨骼 = n Then x.骨骼 = np
                    Next
                End If
            Next
        Next
        新增操作记录("delete " + 引(n.名字))
        smd.骨骼组.Remove(n)
        Dim i As Integer = ListBones.SelectedIndex
        ListBones.Items.RemoveAt(i)
    End Sub

    Private Sub ListOtherBones_DragEnter(sender As Object, e As Forms.DragEventArgs) Handles ListOtherBones.DragEnter, ListOtherMaterial.DragEnter
        e.Effect = Forms.DragDropEffects.Link
    End Sub

    Private Sub ListOtherBones_DragDrop(sender As Object, e As Forms.DragEventArgs) Handles ListOtherBones.DragDrop
        ListOtherBones.Items.Clear()
        Dim s As String = ""
        For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
            If 文件后缀(m) = "smd" Then
                s = m
                Exit For
            End If
        Next
        If s.Length < 4 Then Exit Sub
        Dim n As New SMD文件(读文件(s), True)
        For Each b As SMD骨骼 In n.骨骼组
            ListOtherBones.Items.Add(b.名字)
        Next
    End Sub

    Private Sub ListOtherBones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListOtherBones.SelectedIndexChanged
        If Not IsNothing(ListOtherBones.SelectedItem) Then TxtRename.Text = ListOtherBones.SelectedItem.ToString
    End Sub

    Private Sub ButRenameF_Click(sender As Object, e As EventArgs) Handles ButRenameF.Click
        Dim i As Integer
        For i = 0 To ListBones.Items.Count - 1
            ListBones.SelectedIndex = i
            TxtRename.Text = "joint" & i
            ButRename.PerformClick()
        Next
    End Sub

    Private Sub ListOtherMaterial_DragDrop(sender As Object, e As Forms.DragEventArgs) Handles ListOtherMaterial.DragDrop
        Dim s As String = ""
        For Each m As String In e.Data.GetData(Forms.DataFormats.FileDrop)
            m = 文件名(m, False)
            If Not 在列表(ListOtherMaterial.Items, m) Then ListOtherMaterial.Items.Add(m)
        Next
    End Sub

    Private Sub ButRenameMaterial_Click(sender As Object, e As EventArgs) Handles ButRenameMaterial.Click
        Dim s As String = TxtRenameMaterial.Text
        Dim n As String = ListMaterial.SelectedItem.ToString
        For Each f As SMD面 In smd.面组
            If f.贴图名 = n Then
                f.贴图名 = s
            End If
        Next
        ListMaterial.Items.Remove(n)
        ListMaterial.Items.Add(s)
        ListMaterial.SelectedItem = s
    End Sub

    Private Sub TxtRenameMaterial_TextChanged(sender As Object, e As EventArgs) Handles TxtRenameMaterial.TextChanged
        ButRenameMaterial.Enabled = (TxtRenameMaterial.TextLength > 0 AndAlso Not IsNothing(ListMaterial.SelectedItem))
    End Sub

    Private Sub ListMaterial_SelectedIndexChanged(sender As ListBox, e As EventArgs) Handles ListMaterial.SelectedIndexChanged, ListOtherMaterial.SelectedIndexChanged
        If Not IsNothing(sender.SelectedItem) Then TxtRenameMaterial.Text = sender.SelectedItem.ToString
    End Sub

    Private Sub 新增操作记录(s As String)
        If TxtLOG.Enabled = False Then Exit Sub
        TxtLOG.Text += IIf(TxtLOG.TextLength > 0, vbCrLf, "") + s
    End Sub

    Private Sub ButDoLog_Click(sender As Object, e As EventArgs) Handles ButDoLog.Click
        TxtLOG.Enabled = False
        Dim s As String = TxtLOG.Text, n1 As String, n2 As String
        For Each i As String In 分割(s, vbCrLf)
            If i.StartsWith("rename ") Then
                n1 = 提取(i, vbQuote, vbQuote)
                n2 = 提取(i, "2" + vbQuote, vbQuote)
                If n1.Length > 0 AndAlso 在列表(ListBones.Items, n1) AndAlso n2.Length > 0 AndAlso Not 在列表(ListBones.Items, n2) Then
                    ListBones.SelectedItem = n1
                    TxtRename.Text = n2
                    ButRename.PerformClick()
                End If
            ElseIf i.StartsWith("delete ") Then
                n1 = 提取(i, vbQuote, vbQuote)
                If n1.Length > 0 AndAlso 在列表(ListBones.Items, n1) Then
                    ListBones.SelectedItem = n1
                    ButDEL.PerformClick()
                End If
            End If
        Next
        TxtLOG.Enabled = True
    End Sub

    Private Sub TxtLOG_TextChanged(sender As Object, e As EventArgs) Handles TxtLOG.TextChanged
        ButDoLog.Enabled = (TxtLOG.TextLength > 0)
    End Sub

End Class
