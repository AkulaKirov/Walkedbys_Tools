Module 设置保存

    Public Sets As New 简易CFG(程序文件目录() + "WalkedbySaves.cfg")
    Public TempF As String = 程序文件目录() + "WalkedbysTemps\"

    Public Sub 保存(节点 As String, 内容 As String)
        Sets.节点(节点) = 内容
    End Sub

    Public Function 读取(节点) As String
        Return Sets.节点(节点)
    End Function

End Module
