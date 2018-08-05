
Public Class 工作管理器

    Dim lastUp As Long
    Dim lastDown As Long

    Private Sub Watching_Tick(sender As Object, e As EventArgs) Handles Watching.Tick
        If Not Visible Then Exit Sub
        Dim ps() As Process = Process.GetProcesses
        Dim p As Process, s As String = "", t As String = "", fs As New List(Of String)
        With ListProcesses
            For Each p In ps
                Dim ok As Boolean = True
                s = p.ProcessName.ToLower
                If ok AndAlso Not 在列表(.Items, s) Then
                    .Items.Add(s)
                End If
            Next
            For Each s In .Items
                If Not 程序运行中(s) Then
                    fs.Add(s)
                End If
            Next
            For Each s In fs
                .Items.Remove(s)
            Next
        End With
        With My.Computer.Info
            Dim i As Long = 字节单位转换(.AvailablePhysicalMemory), j As Long = 字节单位转换(.TotalPhysicalMemory)
            i = j - i
            s = "已用物理内存：" + i.ToString + "/" + j.ToString + " MB" + vbCrLf
            BarMemory.Maximum = j
            BarMemory.Value = i
            GBmemory.Text = s
        End With
        If NetworkInterface.GetIsNetworkAvailable Then
            Dim n As NetworkInterface
            Dim alldown As Long = 0, allup As Long = 0
            For Each n In NetworkInterface.GetAllNetworkInterfaces
                alldown += n.GetIPStatistics.BytesReceived
                allup += n.GetIPStatistics.BytesSent
            Next
            If lastDown > 0 Then LabNetwok.Text = "下载：" + 字节单位转换((alldown - lastDown),, "k").ToString + "KB/s" + vbCrLf + "上传：" + 字节单位转换((allup - lastUp),, "k").ToString + "KB/s"
            lastDown = alldown
            lastUp = allup
        Else
            LabNetwok.Text = "你电脑没有网络。"
        End If
    End Sub

    Private Sub ListProcesses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListProcesses.SelectedIndexChanged, ButRefresh.Click
        ButKill.Enabled = False
        ButRefresh.Enabled = False
        Dim out As String = ""
        With ListProcesses
            Dim i As Integer = .SelectedIndex
            If i < 0 Then
                out += "没有选中进程。"
            Else
                ButKill.Enabled = True
                ButRefresh.Enabled = True
                Dim s As String = .Items.Item(i)
                Dim ps As Process() = Process.GetProcessesByName(s)
                If ps.Count < 1 Then
                    out += "进程已被关闭。"
                Else
                    Dim p As Process = ps.First
                    out += "进程名：" + s + vbCrLf + "同名进程数：" + ps.Count.ToString + vbCrLf
                    Dim m As Long = 0
                    For Each p In ps
                        m += p.PagedMemorySize64
                    Next
                    out += "总占用内存：" + Int(字节单位转换(m)).ToString + " MB"
                End If
            End If
        End With
        LabInfo.Text = out
    End Sub

    Private Sub ButKill_Click(sender As Object, e As EventArgs) Handles ButKill.Click
        Dim i As Integer
        With ListProcesses
            i = .SelectedIndex
            If i > -1 Then
                Shell("cmd.exe /c taskkill /im " + 引(.Items.Item(i) + ".exe") + " /f ")
            End If
        End With
    End Sub

End Class
