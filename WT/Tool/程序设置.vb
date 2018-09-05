
Public Class 程序设置

    Private Sub 程序设置_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        对应CheckBox(CheckExit, "ExitAtMain")
        对应CheckBox(CheckUpdate, "NoUpdateAtMain")
        对应CheckBox(CheckHide, "HideWindowAtMin")
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

    Public Sub ButCreateSC_Click() Handles ButCreateSC.Click
        Try
            创建快捷方式(追加斜杠(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)) + 中英文快捷方式名(), 程序文件目录 + "wt.exe")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "创建桌面快捷方式出错啦")
        End Try
    End Sub

    Public Function 中英文快捷方式名() As String
        If 包含(My.Computer.Info.InstalledUICulture.Name.ToLower, "cn") Then
            Return "走過去的工具箱.lnk"
        Else
            Return "Walkedby's Tools.lnk"
        End If
    End Function

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        Dim n As MsgBoxResult
        n = MsgBox("你确定要卸载本软件吗？
很高兴你打开了我（然后又选择把我卸掉）。
卸载会删掉程序本体，留存的信息，
还有快捷方式（如果你没重命名的话）。
程序本体有几率自删失败，还请同志你亲自动手 。", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "你确定吗？")
        If n <> MsgBoxResult.Ok Then Exit Sub
        启动器.Nico.Visible = False
        Dim s As String = 追加斜杠(Environment.GetFolderPath(Environment.SpecialFolder.Desktop))
        删除(s + "走過去的工具箱.lnk", s + "Walkedby's Tools.lnk", TempF, 程序文件目录() + "wt_save.xml", 程序文件目录() + "wt_save.wbxml")
        s = "C:\Users\" + 当前用户名 + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\"
        删除(s + "走過去的工具箱.lnk", s + "Walkedby's Tools.lnk")
        Shell("cmd.exe /c c: & taskkill /im wt.exe /f & timeout 1 & del /f /q " + 引(程序文件目录 + "wt.exe") + "  & echo Finished uninstall. & pause", AppWinStyle.NormalFocus)
    End Sub

End Class