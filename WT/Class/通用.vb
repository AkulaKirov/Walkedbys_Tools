
Module 通用

    Friend 工具列表 As New List(Of 工具)
    Public Sets As New 简易CFG(程序文件目录() + "WalkedbySaves.cfg")
    Public TempF As String = 程序文件目录() + "WalkedbysTemps\"
    Public 图标 As Icon = My.Resources.ico
    Public 最后窗体 As Form = 启动器
    Public Delegate Sub 委托推送(m As String)
    Public 启动参数 As New List(Of String)

    Public Function ID工具(id As String) As 工具
        For Each t As 工具 In 工具列表
            If t.ID.ToLower = id.ToLower Then Return t
        Next
        Return Nothing
    End Function

    Public Sub 保存(节点 As String, 内容 As String)
        Sets.节点(节点) = 内容
    End Sub

    Public Function 读取(节点 As String) As String
        Return Sets.节点(节点)
    End Function

    Public Sub 推送(m As String)
        With 启动器.TxtUpdate
            If .TextLength > 1 Then .Text += vbCrLf
            .Text += m
        End With
    End Sub

End Module
