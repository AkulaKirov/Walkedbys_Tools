
Public Class 工具

    Public Property 名字 As String
    Public Property 简介 As String
    Public Property 窗体 As Form
    Public Property ID As String

    Public Sub New(name As String, win As Form, 内部id As String, description As String)
        名字 = name
        窗体 = win
        简介 = description
        ID = 内部id
        窗体.Icon = 图标
        AddHandler 窗体.FormClosing, Sub(sender As Object, e As FormClosingEventArgs)
                                       e.Cancel = True
                                       窗体.Hide()
                                       启动器.Location = 窗体.Location
                                       启动器.WindowState = FormWindowState.Normal
                                       启动器.Show()
                                       启动器.Location = 窗体.Location
                                       最后窗体 = 启动器
                                   End Sub
    End Sub

    Public Sub 启动()
        启动器.Hide()
        窗体.Location = 启动器.Location
        窗体.Show()
        窗体.Location = 启动器.Location
        窗体.WindowState = FormWindowState.Normal
        最后窗体 = 窗体
    End Sub

    Public Overrides Function ToString() As String
        Return ID
    End Function

End Class
