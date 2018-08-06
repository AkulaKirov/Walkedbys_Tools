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
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.TabPackGMA = New System.Windows.Forms.TabPage()
        Me.GBgma = New System.Windows.Forms.GroupBox()
        Me.ButGoPublish = New System.Windows.Forms.Button()
        Me.CBtags = New System.Windows.Forms.CheckedListBox()
        Me.ButGMA = New System.Windows.Forms.Button()
        Me.CBtype = New System.Windows.Forms.ComboBox()
        Me.Txtname = New System.Windows.Forms.TextBox()
        Me.LabTAGs = New System.Windows.Forms.Label()
        Me.LabGMAtype = New System.Windows.Forms.Label()
        Me.LabGMAname = New System.Windows.Forms.Label()
        Me.LabNO = New System.Windows.Forms.Label()
        Me.LabPath = New System.Windows.Forms.Label()
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.TabPublish = New System.Windows.Forms.TabPage()
        Me.ButUpdateJPG = New System.Windows.Forms.Button()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.PicThumb = New System.Windows.Forms.PictureBox()
        Me.LabUpdate = New System.Windows.Forms.Label()
        Me.TxtJPGfile = New System.Windows.Forms.TextBox()
        Me.ButUpdateGMA = New System.Windows.Forms.Button()
        Me.LabJpgfile = New System.Windows.Forms.Label()
        Me.ButPublish = New System.Windows.Forms.Button()
        Me.TxtGMAfile = New System.Windows.Forms.TextBox()
        Me.LabGMAfile = New System.Windows.Forms.Label()
        Me.LabGMOD = New System.Windows.Forms.Label()
        Me.TxtGMod = New System.Windows.Forms.TextBox()
        Me.ButGoSteam = New System.Windows.Forms.Button()
        Me.Tabs.SuspendLayout()
        Me.TabPackGMA.SuspendLayout()
        Me.GBgma.SuspendLayout()
        Me.TabPublish.SuspendLayout()
        CType(Me.PicThumb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.TabPackGMA)
        Me.Tabs.Controls.Add(Me.TabPublish)
        Me.Tabs.Enabled = False
        Me.Tabs.Location = New System.Drawing.Point(0, 36)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(531, 363)
        Me.Tabs.TabIndex = 0
        Me.Tabs.TabStop = False
        '
        'TabPackGMA
        '
        Me.TabPackGMA.Controls.Add(Me.GBgma)
        Me.TabPackGMA.Controls.Add(Me.LabNO)
        Me.TabPackGMA.Controls.Add(Me.LabPath)
        Me.TabPackGMA.Controls.Add(Me.TxtPath)
        Me.TabPackGMA.Location = New System.Drawing.Point(4, 26)
        Me.TabPackGMA.Name = "TabPackGMA"
        Me.TabPackGMA.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPackGMA.Size = New System.Drawing.Size(523, 333)
        Me.TabPackGMA.TabIndex = 0
        Me.TabPackGMA.Text = "打包GMA"
        Me.TabPackGMA.UseVisualStyleBackColor = True
        '
        'GBgma
        '
        Me.GBgma.Controls.Add(Me.ButGoPublish)
        Me.GBgma.Controls.Add(Me.CBtags)
        Me.GBgma.Controls.Add(Me.ButGMA)
        Me.GBgma.Controls.Add(Me.CBtype)
        Me.GBgma.Controls.Add(Me.Txtname)
        Me.GBgma.Controls.Add(Me.LabTAGs)
        Me.GBgma.Controls.Add(Me.LabGMAtype)
        Me.GBgma.Controls.Add(Me.LabGMAname)
        Me.GBgma.Enabled = False
        Me.GBgma.Location = New System.Drawing.Point(11, 57)
        Me.GBgma.Name = "GBgma"
        Me.GBgma.Size = New System.Drawing.Size(494, 272)
        Me.GBgma.TabIndex = 3
        Me.GBgma.TabStop = False
        Me.GBgma.Text = "打包选项"
        '
        'ButGoPublish
        '
        Me.ButGoPublish.Location = New System.Drawing.Point(289, 61)
        Me.ButGoPublish.Name = "ButGoPublish"
        Me.ButGoPublish.Size = New System.Drawing.Size(182, 33)
        Me.ButGoPublish.TabIndex = 9
        Me.ButGoPublish.TabStop = False
        Me.ButGoPublish.Text = "去发布到 Workshop"
        Me.ButGoPublish.UseVisualStyleBackColor = True
        '
        'CBtags
        '
        Me.CBtags.FormattingEnabled = True
        Me.CBtags.Items.AddRange(New Object() {"fun", "roleplay", "scenic", "movie", "realism", "cartoon", "water", "comic", "build"})
        Me.CBtags.Location = New System.Drawing.Point(53, 87)
        Me.CBtags.Name = "CBtags"
        Me.CBtags.Size = New System.Drawing.Size(129, 175)
        Me.CBtags.TabIndex = 8
        '
        'ButGMA
        '
        Me.ButGMA.Enabled = False
        Me.ButGMA.Location = New System.Drawing.Point(289, 22)
        Me.ButGMA.Name = "ButGMA"
        Me.ButGMA.Size = New System.Drawing.Size(182, 33)
        Me.ButGMA.TabIndex = 7
        Me.ButGMA.TabStop = False
        Me.ButGMA.Text = "生成GMA文件"
        Me.ButGMA.UseVisualStyleBackColor = True
        '
        'CBtype
        '
        Me.CBtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBtype.FormattingEnabled = True
        Me.CBtype.Items.AddRange(New Object() {"servercontent", "gamemode", "map", "weapon", "vehicle", "npc", "tool", "effects", "model"})
        Me.CBtype.Location = New System.Drawing.Point(53, 55)
        Me.CBtype.Name = "CBtype"
        Me.CBtype.Size = New System.Drawing.Size(215, 25)
        Me.CBtype.TabIndex = 4
        Me.CBtype.TabStop = False
        '
        'Txtname
        '
        Me.Txtname.Location = New System.Drawing.Point(53, 27)
        Me.Txtname.MaxLength = 50
        Me.Txtname.Name = "Txtname"
        Me.Txtname.Size = New System.Drawing.Size(215, 24)
        Me.Txtname.TabIndex = 3
        Me.Txtname.TabStop = False
        '
        'LabTAGs
        '
        Me.LabTAGs.AutoSize = True
        Me.LabTAGs.Location = New System.Drawing.Point(6, 87)
        Me.LabTAGs.Name = "LabTAGs"
        Me.LabTAGs.Size = New System.Drawing.Size(47, 17)
        Me.LabTAGs.TabIndex = 2
        Me.LabTAGs.Text = "标签："
        '
        'LabGMAtype
        '
        Me.LabGMAtype.AutoSize = True
        Me.LabGMAtype.Location = New System.Drawing.Point(6, 58)
        Me.LabGMAtype.Name = "LabGMAtype"
        Me.LabGMAtype.Size = New System.Drawing.Size(47, 17)
        Me.LabGMAtype.TabIndex = 1
        Me.LabGMAtype.Text = "类型："
        '
        'LabGMAname
        '
        Me.LabGMAname.AutoSize = True
        Me.LabGMAname.Location = New System.Drawing.Point(6, 30)
        Me.LabGMAname.Name = "LabGMAname"
        Me.LabGMAname.Size = New System.Drawing.Size(47, 17)
        Me.LabGMAname.TabIndex = 0
        Me.LabGMAname.Text = "名字："
        '
        'LabNO
        '
        Me.LabNO.AutoSize = True
        Me.LabNO.Location = New System.Drawing.Point(8, 37)
        Me.LabNO.Name = "LabNO"
        Me.LabNO.Size = New System.Drawing.Size(404, 17)
        Me.LabNO.TabIndex = 2
        Me.LabNO.Text = "addon.json 将由本程序生成，请勿自己手动编写，被覆盖不要怪我。"
        '
        'LabPath
        '
        Me.LabPath.AutoSize = True
        Me.LabPath.Location = New System.Drawing.Point(8, 13)
        Me.LabPath.Name = "LabPath"
        Me.LabPath.Size = New System.Drawing.Size(125, 17)
        Me.LabPath.TabIndex = 1
        Me.LabPath.Text = "你的模组的文件夹："
        '
        'TxtPath
        '
        Me.TxtPath.Location = New System.Drawing.Point(137, 10)
        Me.TxtPath.MaxLength = 500
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(368, 24)
        Me.TxtPath.TabIndex = 0
        Me.TxtPath.TabStop = False
        '
        'TabPublish
        '
        Me.TabPublish.Controls.Add(Me.ButGoSteam)
        Me.TabPublish.Controls.Add(Me.ButUpdateJPG)
        Me.TabPublish.Controls.Add(Me.TxtID)
        Me.TabPublish.Controls.Add(Me.PicThumb)
        Me.TabPublish.Controls.Add(Me.LabUpdate)
        Me.TabPublish.Controls.Add(Me.TxtJPGfile)
        Me.TabPublish.Controls.Add(Me.ButUpdateGMA)
        Me.TabPublish.Controls.Add(Me.LabJpgfile)
        Me.TabPublish.Controls.Add(Me.ButPublish)
        Me.TabPublish.Controls.Add(Me.TxtGMAfile)
        Me.TabPublish.Controls.Add(Me.LabGMAfile)
        Me.TabPublish.Location = New System.Drawing.Point(4, 26)
        Me.TabPublish.Name = "TabPublish"
        Me.TabPublish.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPublish.Size = New System.Drawing.Size(523, 333)
        Me.TabPublish.TabIndex = 1
        Me.TabPublish.Text = "发布到 Workshop"
        Me.TabPublish.UseVisualStyleBackColor = True
        '
        'ButUpdateJPG
        '
        Me.ButUpdateJPG.Enabled = False
        Me.ButUpdateJPG.Location = New System.Drawing.Point(11, 205)
        Me.ButUpdateJPG.Name = "ButUpdateJPG"
        Me.ButUpdateJPG.Size = New System.Drawing.Size(281, 39)
        Me.ButUpdateJPG.TabIndex = 11
        Me.ButUpdateJPG.TabStop = False
        Me.ButUpdateJPG.Text = "更新 JPG 封面到 Workshop"
        Me.ButUpdateJPG.UseVisualStyleBackColor = True
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(130, 130)
        Me.TxtID.MaxLength = 300
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(162, 24)
        Me.TxtID.TabIndex = 10
        Me.TxtID.TabStop = False
        '
        'PicThumb
        '
        Me.PicThumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicThumb.Location = New System.Drawing.Point(298, 80)
        Me.PicThumb.Name = "PicThumb"
        Me.PicThumb.Size = New System.Drawing.Size(200, 200)
        Me.PicThumb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicThumb.TabIndex = 6
        Me.PicThumb.TabStop = False
        '
        'LabUpdate
        '
        Me.LabUpdate.AutoSize = True
        Me.LabUpdate.Location = New System.Drawing.Point(11, 133)
        Me.LabUpdate.Name = "LabUpdate"
        Me.LabUpdate.Size = New System.Drawing.Size(113, 17)
        Me.LabUpdate.TabIndex = 9
        Me.LabUpdate.Text = "要更新的作品ID："
        '
        'TxtJPGfile
        '
        Me.TxtJPGfile.Location = New System.Drawing.Point(97, 50)
        Me.TxtJPGfile.MaxLength = 500
        Me.TxtJPGfile.Name = "TxtJPGfile"
        Me.TxtJPGfile.Size = New System.Drawing.Size(401, 24)
        Me.TxtJPGfile.TabIndex = 5
        Me.TxtJPGfile.TabStop = False
        '
        'ButUpdateGMA
        '
        Me.ButUpdateGMA.Enabled = False
        Me.ButUpdateGMA.Location = New System.Drawing.Point(11, 160)
        Me.ButUpdateGMA.Name = "ButUpdateGMA"
        Me.ButUpdateGMA.Size = New System.Drawing.Size(281, 39)
        Me.ButUpdateGMA.TabIndex = 8
        Me.ButUpdateGMA.TabStop = False
        Me.ButUpdateGMA.Text = "更新 GMA 文件到 Workshop"
        Me.ButUpdateGMA.UseVisualStyleBackColor = True
        '
        'LabJpgfile
        '
        Me.LabJpgfile.AutoSize = True
        Me.LabJpgfile.Location = New System.Drawing.Point(8, 53)
        Me.LabJpgfile.Name = "LabJpgfile"
        Me.LabJpgfile.Size = New System.Drawing.Size(86, 17)
        Me.LabJpgfile.TabIndex = 4
        Me.LabJpgfile.Text = "封面图文件："
        '
        'ButPublish
        '
        Me.ButPublish.Enabled = False
        Me.ButPublish.Location = New System.Drawing.Point(11, 80)
        Me.ButPublish.Name = "ButPublish"
        Me.ButPublish.Size = New System.Drawing.Size(281, 39)
        Me.ButPublish.TabIndex = 7
        Me.ButPublish.TabStop = False
        Me.ButPublish.Text = "发布新 Addon 到 Workshop"
        Me.ButPublish.UseVisualStyleBackColor = True
        '
        'TxtGMAfile
        '
        Me.TxtGMAfile.Location = New System.Drawing.Point(97, 16)
        Me.TxtGMAfile.MaxLength = 500
        Me.TxtGMAfile.Name = "TxtGMAfile"
        Me.TxtGMAfile.Size = New System.Drawing.Size(401, 24)
        Me.TxtGMAfile.TabIndex = 3
        Me.TxtGMAfile.TabStop = False
        '
        'LabGMAfile
        '
        Me.LabGMAfile.AutoSize = True
        Me.LabGMAfile.Location = New System.Drawing.Point(8, 19)
        Me.LabGMAfile.Name = "LabGMAfile"
        Me.LabGMAfile.Size = New System.Drawing.Size(83, 17)
        Me.LabGMAfile.TabIndex = 2
        Me.LabGMAfile.Text = "GMA 文件："
        '
        'LabGMOD
        '
        Me.LabGMOD.AutoSize = True
        Me.LabGMOD.Location = New System.Drawing.Point(3, 9)
        Me.LabGMOD.Name = "LabGMOD"
        Me.LabGMOD.Size = New System.Drawing.Size(183, 17)
        Me.LabGMOD.TabIndex = 4
        Me.LabGMOD.Text = "你的 Garry's Mod 游戏目录："
        '
        'TxtGMod
        '
        Me.TxtGMod.Location = New System.Drawing.Point(192, 6)
        Me.TxtGMod.MaxLength = 500
        Me.TxtGMod.Name = "TxtGMod"
        Me.TxtGMod.Size = New System.Drawing.Size(310, 24)
        Me.TxtGMod.TabIndex = 5
        Me.TxtGMod.TabStop = False
        '
        'ButGoSteam
        '
        Me.ButGoSteam.Location = New System.Drawing.Point(11, 250)
        Me.ButGoSteam.Name = "ButGoSteam"
        Me.ButGoSteam.Size = New System.Drawing.Size(281, 39)
        Me.ButGoSteam.TabIndex = 12
        Me.ButGoSteam.TabStop = False
        Me.ButGoSteam.Text = "查看我的 Workshop"
        Me.ButGoSteam.UseVisualStyleBackColor = True
        '
        'GM模组发布器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(534, 404)
        Me.Controls.Add(Me.TxtGMod)
        Me.Controls.Add(Me.LabGMOD)
        Me.Controls.Add(Me.Tabs)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.Name = "GM模组发布器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Garry's Mod 模组发布器"
        Me.Tabs.ResumeLayout(False)
        Me.TabPackGMA.ResumeLayout(False)
        Me.TabPackGMA.PerformLayout()
        Me.GBgma.ResumeLayout(False)
        Me.GBgma.PerformLayout()
        Me.TabPublish.ResumeLayout(False)
        Me.TabPublish.PerformLayout()
        CType(Me.PicThumb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tabs As TabControl
    Friend WithEvents TabPackGMA As TabPage
    Friend WithEvents TabPublish As TabPage
    Friend WithEvents TxtPath As TextBox
    Friend WithEvents LabPath As Label
    Friend WithEvents LabNO As Label
    Friend WithEvents GBgma As GroupBox
    Friend WithEvents LabGMAname As Label
    Friend WithEvents LabGMAtype As Label
    Friend WithEvents LabTAGs As Label
    Friend WithEvents Txtname As TextBox
    Friend WithEvents CBtype As ComboBox
    Friend WithEvents ButGMA As Button
    Friend WithEvents LabGMOD As Label
    Friend WithEvents TxtGMod As TextBox
    Friend WithEvents CBtags As CheckedListBox
    Friend WithEvents ButGoPublish As Button
    Friend WithEvents LabGMAfile As Label
    Friend WithEvents TxtGMAfile As TextBox
    Friend WithEvents LabJpgfile As Label
    Friend WithEvents TxtJPGfile As TextBox
    Friend WithEvents PicThumb As PictureBox
    Friend WithEvents ButUpdateJPG As Button
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LabUpdate As Label
    Friend WithEvents ButUpdateGMA As Button
    Friend WithEvents ButPublish As Button
    Friend WithEvents ButGoSteam As Button
End Class
