
Public Class 临时工具


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As String = "C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\addons\half-life_sweps\lua\weapons\"
        'Dim s As String, f As New List(Of String)
        For Each i As String In Directory.GetFiles("C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\garrysmod\addons\half-life_sweps\lua\weapons\", "weapon_hl1_*.lua", SearchOption.TopDirectoryOnly)
            File.Copy(i, i.Replace("weapon_hl1_", "weapon_"), True)
        Next
    End Sub

End Class
