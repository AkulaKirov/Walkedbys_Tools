
Imports System.ComponentModel

Public Class 系统代理设置

    Dim 注册表 As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", True)
    Dim 模板 As New List(Of String)

    Private Sub 系统代理设置_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ButGetSystem.PerformClick()
        文字转列表(模板, 读取("ProxyTemps"))
        For Each i As String In 模板
            Dim t As String = 去右(Regex.Match(i, ".+___").ToString, 3)
            If t.Length > 0 Then ListTemps.Items.Add(t)
        Next
    End Sub

    Private Sub ButGetSystem_Click(sender As Object, e As EventArgs) Handles ButGetSystem.Click
        TxtPAC.Text = 注册表.GetValue("AutoConfigURL", "")
        If 注册表.GetValue("ProxyEnable", "0") = "1" Then
            TxtProxy.Text = 注册表.GetValue("ProxyServer", "")
        Else
            TxtProxy.Text = ""
        End If
    End Sub

    Private Sub ButApply_Click(sender As Object, e As EventArgs) Handles ButApply.Click
        注册表.SetValue("AutoConfigURL", TxtPAC.Text, RegistryValueKind.String)
        Dim s As String = TxtProxy.Text
        注册表.SetValue("ProxyEnable", IIf(s.Length > 0, "1", "0"), RegistryValueKind.DWord)
        If s.Length > 0 Then 注册表.SetValue("ProxyServer", s, RegistryValueKind.String)
    End Sub

    Private Sub TxtTempName_TextChanged(sender As Object, e As EventArgs) Handles TxtTempName.TextChanged
        ButAdd.Enabled = (TxtTempName.TextLength > 0 AndAlso Not 在列表(ListTemps.Items, TxtTempName.Text))
    End Sub

    Private Sub ButAdd_Click(sender As Object, e As EventArgs) Handles ButAdd.Click
        Dim s As String = TxtTempName.Text + "___"
        Dim m As New 简易CFG
        m.节点("pac") = TxtPAC.Text
        m.节点("proxy") = TxtProxy.Text
        模板.Add(Regex.Escape(s + m.全文本))
        ListTemps.Items.Add(TxtTempName.Text)
        TxtTempName.Text = ""
        ListTemps.SelectedIndex = ListTemps.Items.Count - 1
    End Sub

    Private Sub ButUSE_Click(sender As Object, e As EventArgs) Handles ButUSE.Click
        Dim s As String = ListTemps.Text
        For Each i As String In 模板
            If i.StartsWith(s + "___") Then
                Dim m As New 简易CFG
                m.全文本 = Regex.Unescape(i)
                TxtPAC.Text = m.节点("pac")
                TxtProxy.Text = m.节点("proxy")
                Exit For
            End If
        Next
    End Sub

    Private Sub ListTemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListTemps.SelectedIndexChanged
        Dim i As Integer = ListTemps.SelectedIndex
        ButUSE.Enabled = (i >= 0)
        ButRM.Enabled = ButUSE.Enabled
    End Sub

    Private Sub ButRM_Click(sender As Object, e As EventArgs) Handles ButRM.Click
        Dim s As String = ListTemps.Text
        Dim i As String = ""
        For Each i In 模板
            If i.StartsWith(s + "___") Then Exit For
        Next
        模板.Remove(i)
        移除选中项(ListTemps)
    End Sub

    Private Sub 系统代理设置_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        保存("ProxyTemps", 列表转文字(模板))
    End Sub

End Class