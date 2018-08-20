
Public Class 程序设置

    Private Sub 程序设置_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        对应CheckBox(CheckExit, "ExitAtMain")
        对应CheckBox(CheckUpdate, "NoUpdateAtMain")
        对应CheckBox(CheckHide, "HideWindowAtMin")
        对应CheckBox(CheckStartUP, "StartUP")
    End Sub

    Private Sub 对应CheckBox(c As CheckBox, 元素 As String)
        c.Checked = 设置.读取真假(元素)
        AddHandler c.CheckedChanged, Sub()
                                         设置.元素(元素) = c.Checked.ToString
                                     End Sub
        AddHandler Activated, Sub()
                                  c.Checked = 设置.读取真假(元素)
                              End Sub
    End Sub

    Private Sub LinkReport_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://s1.ax1x.com/2018/08/15/P2oz36.png")
    End Sub

    Private Sub CheckStartUP_CheckedChanged(sender As Object, e As EventArgs) Handles CheckStartUP.CheckedChanged
        Try
            Dim s As String = "C:\Users\" + 当前用户名 + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\走過去的工具箱.lnk"
            If CheckStartUP.Checked Then
                创建快捷方式(s, 程序文件目录 + "wt.exe")
            Else
                删除(s)
            End If
        Catch ex As Exception
            MsgBox("未能成功创建或删除开机启动用的快捷方式。" + vbCrLf + ex.Message, MsgBoxStyle.Critical, "创建文件出错啦")
        End Try
    End Sub

    Public Sub ButCreateSC_Click() Handles ButCreateSC.Click
        Try
            创建快捷方式(追加斜杠(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + "走過去的工具箱.lnk", 程序文件目录 + "wt.exe")
        Catch ex As Exception
            MsgBox("未能成功创建桌面快捷方式。" + vbCrLf + ex.Message, MsgBoxStyle.Critical, "创建文件出错啦")
        End Try
    End Sub

End Class