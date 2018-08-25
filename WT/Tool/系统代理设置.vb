
Public Class 系统代理设置

    Dim 注册表 As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", True)
    Dim mz As 模板组

    Private Sub 系统代理设置_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mz = New 模板组("Proxy", ListTemps, TxtTempName, ButAdd, ButRM, ButUSE)
        ButGetSystem.PerformClick()
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

    Private Sub ButCheckIP_Click(sender As Object, e As EventArgs) Handles ButCheckIP.Click
        Dim h As New 简易HTTP("https://ip.cn/index.php?")
        h.超时 = 5
        Dim s As String = h.获得回应()
        s = 提取(s, "result", "</p></div></div>").Replace("</p><p>", vbCrLf)
        If s.Length > 10 Then
            MsgBox(正则去除(s, "<.*?>", "<", ">", vbQuote))
        Else
            MsgBox("获取失败！" + vbCrLf + s, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub ButCheckGoogle_Click(sender As Object, e As EventArgs) Handles ButCheckGoogle.Click
        Dim h As New 简易HTTP("http://clients3.google.com/generate_204")
        h.超时 = 5
        Dim s As String = h.获得回应
        If s.Length = 0 Then
            MsgBox("测试成功！")
        Else
            MsgBox("测试失败！" + vbCrLf + s, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub 系统代理设置_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        TxtIP.Text = "本机IP："
        If NetworkInterface.GetIsNetworkAvailable Then
            For Each ip As IPAddress In Dns.GetHostEntry(Dns.GetHostName).AddressList
                TxtIP.Text += vbCrLf + ip.ToString
            Next
        End If
    End Sub

    Private Sub ButAdd_Click(sender As Object, e As EventArgs) Handles ButAdd.Click
        Dim s As String = TxtTempName.Text
        Dim t As New 模板(s)
        t.元素("pac") = TxtPAC.Text
        t.元素("server") = TxtProxy.Text
        mz.新增(t)
    End Sub

    Private Sub ButUSE_Click(sender As Object, e As EventArgs) Handles ButUSE.Click
        Dim t As 模板 = MZ.读取当前项
        TxtProxy.Text = t.元素("server")
        TxtPAC.Text = t.元素("pac")
    End Sub

    Private Sub ButCheckSystem_Click(sender As Object, e As EventArgs) Handles ButCheckSystem.Click
        Process.Start("C:\Windows\System32\inetcpl.cpl")
    End Sub

End Class
