Public Class 临时工具

    Dim ps As String = "effects\confetti\confetti
effects\fly001
effects\ghost
effects\sc_softglow
effects\wispy_smoke_add
effects\plasma1
effects\largesmoke
effects\smokelit2\smoke2lit
effects\bubbles\bubble
vgui\white
effects\god_ray
effects\heart
effects\cig_smoke_add
effects\smoke\smokelit_nofade_add
effects\tp_sparkle2
particle\pebble1\particle_pebble_1
particle\flamethrowerfire\flamethrowerfire102
effects\sc_softglow_translucent
effects\debris\nutsnbolts
effects\holo_glow
particle\white_square
effects\sc_softglow2
effects\electro_beam
effects\spark
effects\glowdrip_add
particle\drink\drink_goop3
effects\softglow
particle\particle_glow_01
particle\particle_crescent
particle\particle_swirl_04
effects\splash_ring1
effects\rocketrailsmoke
effects\particle_glow_05_basic
effects\animatedspirit01\animated_spirit01_bright
effects\tp_spark
effects\spotlight_single_add
effects\spotlight_single_wide_add
effects\particle_glow_05
effects\lightningbolt
particle\blood1\blood_goop3
effects\knife01
effects\skull002_add
effects\skull002_eyeglow_add
effects\cig_smoke"

    Dim ms As New List(Of String)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each i As String In Directory.GetFiles("D:\Steam\steamapps\common\Team Fortress 2\tf\tf2_misc_dir\particles")
            Dim b As Byte() = 读文件(i, True)
            For Each j As String In 分割(ps, vbCrLf)
                If 寻找字节位置(b, 文字转字节(j)).Count > 0 Then
                    PRT(文件名(i, True), j)
                End If
            Next
        Next
        PRT("over")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not IsNothing(Forms.Clipboard.GetText) Then
            Dim s As String = Forms.Clipboard.GetText
            If s.Length > 0 Then
                If Not 在列表(ms, s) Then
                    ms.Add(s)
                End If
            End If
        End If
        RTB1.Text = 列表转文字(ms)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        写文件("e:\f.txt", RTB1.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ms.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tf As String = "D:\Steam\steamapps\common\Team Fortress 2\tf\tf2_misc_dir\materials\"
        For Each i As String In 分割(ps, vbCrLf)
            Dim n As String = tf + i + ".vmt"
            If 文件存在(n) Then
                Dim s As String
                s = "E:\New folder\" + i + ".vmt"
                Directory.CreateDirectory(文件路径(s))
                File.Copy(n, "E:\New folder\" + i + ".vmt", True)
                s = 读文件(n)
                PRT(s)
                s = Trim(Regex.Match(s, """\$basetexture"".*?"".*?""").ToString)
                s = 提取(Trim(去左(s, 14)), vbQuote, vbQuote)
                n = tf + s + ".vtf"
                If 文件存在(n) Then
                    File.Copy(n, "E:\New folder\" + s + ".vtf", True)
                End If
            End If
        Next
    End Sub

End Class