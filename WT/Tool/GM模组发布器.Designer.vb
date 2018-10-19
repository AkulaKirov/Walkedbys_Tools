<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GM模组发布器
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabGMOD = New System.Windows.Forms.Label()
        Me.TxtGMod = New System.Windows.Forms.TextBox()
        Me.LabJpgfile = New System.Windows.Forms.Label()
        Me.TxtJPGfile = New System.Windows.Forms.TextBox()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.LabPath = New System.Windows.Forms.Label()
        Me.LabNO = New System.Windows.Forms.Label()
        Me.GBjson = New System.Windows.Forms.GroupBox()
        Me.LabGMAname = New System.Windows.Forms.Label()
        Me.LabGMAtype = New System.Windows.Forms.Label()
        Me.CBtags = New System.Windows.Forms.CheckedListBox()
        Me.LabTAGs = New System.Windows.Forms.Label()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.CBtype = New System.Windows.Forms.ComboBox()
        Me.ButNew = New System.Windows.Forms.Button()
        Me.GBupdate = New System.Windows.Forms.GroupBox()
        Me.ButUpdateALL = New System.Windows.Forms.Button()
        Me.ButUpdateJPG = New System.Windows.Forms.Button()
        Me.ButUpdateGMA = New System.Windows.Forms.Button()
        Me.LabCount = New System.Windows.Forms.Label()
        Me.ButGetList = New System.Windows.Forms.Button()
        Me.ListAddons = New System.Windows.Forms.ComboBox()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.PicThumb = New System.Windows.Forms.PictureBox()
        Me.CoolD = New System.Windows.Forms.Timer(Me.components)
        Me.GBjson.SuspendLayout()
        Me.GBupdate.SuspendLayout()
        Me.Pn.SuspendLayout()
        CType(Me.PicThumb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabGMOD
        '
        Me.LabGMOD.AutoSize = True
        Me.LabGMOD.Location = New System.Drawing.Point(3, 9)
        Me.LabGMOD.Name = "LabGMOD"
        Me.LabGMOD.Size = New System.Drawing.Size(184, 19)
        Me.LabGMOD.TabIndex = 4
        Me.LabGMOD.Text = "你的 Garry's Mod 游戏目录："
        '
        'TxtGMod
        '
        Me.TxtGMod.Location = New System.Drawing.Point(192, 6)
        Me.TxtGMod.MaxLength = 500
        Me.TxtGMod.Name = "TxtGMod"
        Me.TxtGMod.Size = New System.Drawing.Size(391, 24)
        Me.TxtGMod.TabIndex = 5
        Me.TxtGMod.TabStop = False
        '
        'LabJpgfile
        '
        Me.LabJpgfile.AutoSize = True
        Me.LabJpgfile.Location = New System.Drawing.Point(3, 65)
        Me.LabJpgfile.Name = "LabJpgfile"
        Me.LabJpgfile.Size = New System.Drawing.Size(88, 19)
        Me.LabJpgfile.TabIndex = 4
        Me.LabJpgfile.Text = "封面图 JPG："
        '
        'TxtJPGfile
        '
        Me.TxtJPGfile.Location = New System.Drawing.Point(96, 65)
        Me.TxtJPGfile.MaxLength = 500
        Me.TxtJPGfile.Name = "TxtJPGfile"
        Me.TxtJPGfile.Size = New System.Drawing.Size(469, 24)
        Me.TxtJPGfile.TabIndex = 5
        Me.TxtJPGfile.TabStop = False
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(144, 33)
        Me.TxtPath.MaxLength = 500
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(421, 24)
        Me.TxtPath.TabIndex = 0
        Me.TxtPath.TabStop = False
        '
        'LabPath
        '
        Me.LabPath.AutoSize = True
        Me.LabPath.Location = New System.Drawing.Point(3, 36)
        Me.LabPath.Name = "LabPath"
        Me.LabPath.Size = New System.Drawing.Size(136, 19)
        Me.LabPath.TabIndex = 1
        Me.LabPath.Text = "你的 Addon 文件夹："
        '
        'LabNO
        '
        Me.LabNO.AutoSize = True
        Me.LabNO.Location = New System.Drawing.Point(3, 4)
        Me.LabNO.Name = "LabNO"
        Me.LabNO.Size = New System.Drawing.Size(497, 19)
        Me.LabNO.TabIndex = 2
        Me.LabNO.Text = "addon.json 以及 GMA 文件将由本程序生成，请勿自己手动制作，被覆盖不要怪我。"
        '
        'GBjson
        '
        Me.GBjson.Controls.Add(Me.LabGMAname)
        Me.GBjson.Controls.Add(Me.LabGMAtype)
        Me.GBjson.Controls.Add(Me.CBtags)
        Me.GBjson.Controls.Add(Me.LabTAGs)
        Me.GBjson.Controls.Add(Me.Txtname)
        Me.GBjson.Controls.Add(Me.CBtype)
        Me.GBjson.Location = New System.Drawing.Point(4, 95)
        Me.GBjson.Name = "GBjson"
        Me.GBjson.Size = New System.Drawing.Size(209, 275)
        Me.GBjson.TabIndex = 11
        Me.GBjson.TabStop = False
        Me.GBjson.Text = "addon.json 信息"
        Me.GBjson.Visible = False
        '
        'LabGMAname
        '
        Me.LabGMAname.AutoSize = True
        Me.LabGMAname.Location = New System.Drawing.Point(4, 26)
        Me.LabGMAname.Name = "LabGMAname"
        Me.LabGMAname.Size = New System.Drawing.Size(48, 19)
        Me.LabGMAname.TabIndex = 0
        Me.LabGMAname.Text = "名字："
        '
        'LabGMAtype
        '
        Me.LabGMAtype.AutoSize = True
        Me.LabGMAtype.Location = New System.Drawing.Point(4, 56)
        Me.LabGMAtype.Name = "LabGMAtype"
        Me.LabGMAtype.Size = New System.Drawing.Size(48, 19)
        Me.LabGMAtype.TabIndex = 1
        Me.LabGMAtype.Text = "类型："
        '
        'CBtags
        '
        Me.CBtags.FormattingEnabled = True
        Me.CBtags.Items.AddRange(New Object() {"fun", "roleplay", "scenic", "movie", "realism", "cartoon", "water", "comic", "build"})
        Me.CBtags.Location = New System.Drawing.Point(62, 88)
        Me.CBtags.Name = "CBtags"
        Me.CBtags.Size = New System.Drawing.Size(129, 175)
        Me.CBtags.TabIndex = 8
        '
        'LabTAGs
        '
        Me.LabTAGs.AutoSize = True
        Me.LabTAGs.Location = New System.Drawing.Point(4, 88)
        Me.LabTAGs.Name = "LabTAGs"
        Me.LabTAGs.Size = New System.Drawing.Size(48, 19)
        Me.LabTAGs.TabIndex = 2
        Me.LabTAGs.Text = "标签："
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(62, 23)
        Me.Txtname.MaxLength = 50
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(129, 24)
        Me.Txtname.TabIndex = 3
        Me.Txtname.TabStop = False
        '
        'CBtype
        '
        Me.CBtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBtype.FormattingEnabled = True
        Me.CBtype.Items.AddRange(New Object() {"servercontent", "gamemode", "map", "weapon", "vehicle", "npc", "tool", "effects", "model"})
        Me.CBtype.Location = New System.Drawing.Point(62, 53)
        Me.CBtype.Name = "CBtype"
        Me.CBtype.Size = New System.Drawing.Size(129, 27)
        Me.CBtype.TabIndex = 4
        Me.CBtype.TabStop = False
        '
        'ButNew
        '
        Me.ButNew.Enabled = False
        Me.ButNew.Location = New System.Drawing.Point(219, 100)
        Me.ButNew.Name = "ButNew"
        Me.ButNew.Size = New System.Drawing.Size(280, 42)
        Me.ButNew.TabIndex = 12
        Me.ButNew.TabStop = False
        Me.ButNew.Text = "发布新 Addon"
        Me.ButNew.UseVisualStyleBackColor = True
        '
        'GBupdate
        '
        Me.GBupdate.Controls.Add(Me.ButUpdateALL)
        Me.GBupdate.Controls.Add(Me.ButUpdateJPG)
        Me.GBupdate.Controls.Add(Me.ButUpdateGMA)
        Me.GBupdate.Controls.Add(Me.LabCount)
        Me.GBupdate.Controls.Add(Me.ButGetList)
        Me.GBupdate.Controls.Add(Me.ListAddons)
        Me.GBupdate.Location = New System.Drawing.Point(219, 151)
        Me.GBupdate.Name = "GBupdate"
        Me.GBupdate.Size = New System.Drawing.Size(346, 219)
        Me.GBupdate.TabIndex = 14
        Me.GBupdate.TabStop = False
        Me.GBupdate.Text = "更新"
        '
        'ButUpdateALL
        '
        Me.ButUpdateALL.Enabled = False
        Me.ButUpdateALL.Location = New System.Drawing.Point(6, 158)
        Me.ButUpdateALL.Name = "ButUpdateALL"
        Me.ButUpdateALL.Size = New System.Drawing.Size(334, 37)
        Me.ButUpdateALL.TabIndex = 18
        Me.ButUpdateALL.TabStop = False
        Me.ButUpdateALL.Text = "文件本体和封面图一起更新"
        Me.ButUpdateALL.UseVisualStyleBackColor = True
        '
        'ButUpdateJPG
        '
        Me.ButUpdateJPG.Enabled = False
        Me.ButUpdateJPG.Location = New System.Drawing.Point(174, 115)
        Me.ButUpdateJPG.Name = "ButUpdateJPG"
        Me.ButUpdateJPG.Size = New System.Drawing.Size(166, 37)
        Me.ButUpdateJPG.TabIndex = 17
        Me.ButUpdateJPG.TabStop = False
        Me.ButUpdateJPG.Text = "更新封面图"
        Me.ButUpdateJPG.UseVisualStyleBackColor = True
        '
        'ButUpdateGMA
        '
        Me.ButUpdateGMA.Enabled = False
        Me.ButUpdateGMA.Location = New System.Drawing.Point(6, 115)
        Me.ButUpdateGMA.Name = "ButUpdateGMA"
        Me.ButUpdateGMA.Size = New System.Drawing.Size(166, 37)
        Me.ButUpdateGMA.TabIndex = 16
        Me.ButUpdateGMA.TabStop = False
        Me.ButUpdateGMA.Text = "更新文件本体"
        Me.ButUpdateGMA.UseVisualStyleBackColor = True
        '
        'LabCount
        '
        Me.LabCount.AutoSize = True
        Me.LabCount.Location = New System.Drawing.Point(9, 60)
        Me.LabCount.Name = "LabCount"
        Me.LabCount.Size = New System.Drawing.Size(56, 19)
        Me.LabCount.TabIndex = 15
        Me.LabCount.Text = "共计：0"
        '
        'ButGetList
        '
        Me.ButGetList.Location = New System.Drawing.Point(6, 19)
        Me.ButGetList.Name = "ButGetList"
        Me.ButGetList.Size = New System.Drawing.Size(334, 33)
        Me.ButGetList.TabIndex = 14
        Me.ButGetList.TabStop = False
        Me.ButGetList.Text = "刷新我的 Addons 列表"
        Me.ButGetList.UseVisualStyleBackColor = True
        '
        'ListAddons
        '
        Me.ListAddons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListAddons.Font = New System.Drawing.Font("Microsoft YaHei UI", 8.0!)
        Me.ListAddons.FormattingEnabled = True
        Me.ListAddons.Location = New System.Drawing.Point(6, 80)
        Me.ListAddons.Name = "ListAddons"
        Me.ListAddons.Size = New System.Drawing.Size(334, 24)
        Me.ListAddons.Sorted = True
        Me.ListAddons.TabIndex = 13
        Me.ListAddons.TabStop = False
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.PicThumb)
        Me.Pn.Controls.Add(Me.GBupdate)
        Me.Pn.Controls.Add(Me.ButNew)
        Me.Pn.Controls.Add(Me.GBjson)
        Me.Pn.Controls.Add(Me.LabNO)
        Me.Pn.Controls.Add(Me.LabPath)
        Me.Pn.Controls.Add(Me.TxtPath)
        Me.Pn.Controls.Add(Me.TxtJPGfile)
        Me.Pn.Controls.Add(Me.LabJpgfile)
        Me.Pn.Location = New System.Drawing.Point(6, 36)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(577, 387)
        Me.Pn.TabIndex = 6
        Me.Pn.Visible = False
        '
        'PicThumb
        '
        Me.PicThumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicThumb.Location = New System.Drawing.Point(505, 95)
        Me.PicThumb.Name = "PicThumb"
        Me.PicThumb.Size = New System.Drawing.Size(60, 60)
        Me.PicThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicThumb.TabIndex = 15
        Me.PicThumb.TabStop = False
        '
        'CoolD
        '
        Me.CoolD.Interval = 50
        '
        'GM模组发布器
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(595, 428)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.TxtGMod)
        Me.Controls.Add(Me.LabGMOD)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.Name = "GM模组发布器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Garry's Mod 模组发布器"
        Me.GBjson.ResumeLayout(False)
        Me.GBjson.PerformLayout()
        Me.GBupdate.ResumeLayout(False)
        Me.GBupdate.PerformLayout()
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        CType(Me.PicThumb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabGMOD As Label
    Friend WithEvents TxtGMod As TextBox
    Friend WithEvents LabJpgfile As Label
    Friend WithEvents TxtJPGfile As TextBox
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents LabPath As Label
    Friend WithEvents LabNO As Label
    Friend WithEvents GBjson As GroupBox
    Friend WithEvents LabGMAname As Label
    Friend WithEvents LabGMAtype As Label
    Friend WithEvents CBtags As CheckedListBox
    Friend WithEvents LabTAGs As Label
    Friend WithEvents Txtname As TextBox
    Friend WithEvents CBtype As ComboBox
    Friend WithEvents ButNew As Button
    Friend WithEvents GBupdate As GroupBox
    Friend WithEvents LabCount As Label
    Friend WithEvents ButGetList As Button
    Friend WithEvents ListAddons As ComboBox
    Friend WithEvents Pn As Panel
    Friend WithEvents PicThumb As PictureBox
    Friend WithEvents ButUpdateJPG As Button
    Friend WithEvents ButUpdateGMA As Button
    Friend WithEvents ButUpdateALL As Button
    Friend WithEvents CoolD As Forms.Timer
End Class