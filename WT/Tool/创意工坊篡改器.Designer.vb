<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 创意工坊篡改器
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
        Me.Pn = New System.Windows.Forms.Panel()
        Me.ButGoBrowser = New System.Windows.Forms.Button()
        Me.ButGo = New System.Windows.Forms.Button()
        Me.TxtDes = New System.Windows.Forms.TextBox()
        Me.LabDes = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.LabTitle = New System.Windows.Forms.Label()
        Me.ListLanguage = New System.Windows.Forms.ComboBox()
        Me.LabLanguage = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LabID = New System.Windows.Forms.Label()
        Me.LabInfo = New System.Windows.Forms.Label()
        Me.ButGetSteamCookie = New System.Windows.Forms.Button()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.ButGoBrowser)
        Me.Pn.Controls.Add(Me.ButGo)
        Me.Pn.Controls.Add(Me.TxtDes)
        Me.Pn.Controls.Add(Me.LabDes)
        Me.Pn.Controls.Add(Me.TxtTitle)
        Me.Pn.Controls.Add(Me.LabTitle)
        Me.Pn.Controls.Add(Me.ListLanguage)
        Me.Pn.Controls.Add(Me.LabLanguage)
        Me.Pn.Controls.Add(Me.TxtID)
        Me.Pn.Controls.Add(Me.LabID)
        Me.Pn.Location = New System.Drawing.Point(11, 99)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(639, 306)
        Me.Pn.TabIndex = 64
        '
        'ButGoBrowser
        '
        Me.ButGoBrowser.Enabled = False
        Me.ButGoBrowser.Location = New System.Drawing.Point(458, 261)
        Me.ButGoBrowser.Name = "ButGoBrowser"
        Me.ButGoBrowser.Size = New System.Drawing.Size(163, 33)
        Me.ButGoBrowser.TabIndex = 73
        Me.ButGoBrowser.TabStop = False
        Me.ButGoBrowser.Text = "去浏览器检查看看"
        Me.ButGoBrowser.UseVisualStyleBackColor = True
        '
        'ButGo
        '
        Me.ButGo.Enabled = False
        Me.ButGo.Location = New System.Drawing.Point(285, 261)
        Me.ButGo.Name = "ButGo"
        Me.ButGo.Size = New System.Drawing.Size(167, 33)
        Me.ButGo.TabIndex = 71
        Me.ButGo.TabStop = False
        Me.ButGo.Text = "发送修改请求"
        Me.ButGo.UseVisualStyleBackColor = True
        '
        'TxtDes
        '
        Me.TxtDes.Location = New System.Drawing.Point(93, 88)
        Me.TxtDes.MaxLength = 2000
        Me.TxtDes.Multiline = True
        Me.TxtDes.Name = "TxtDes"
        Me.TxtDes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtDes.Size = New System.Drawing.Size(528, 167)
        Me.TxtDes.TabIndex = 70
        Me.TxtDes.TabStop = False
        '
        'LabDes
        '
        Me.LabDes.AutoSize = True
        Me.LabDes.Location = New System.Drawing.Point(13, 88)
        Me.LabDes.Name = "LabDes"
        Me.LabDes.Size = New System.Drawing.Size(74, 19)
        Me.LabDes.TabIndex = 69
        Me.LabDes.Text = "物品简介："
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(93, 49)
        Me.TxtTitle.MaxLength = 100
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(528, 25)
        Me.TxtTitle.TabIndex = 68
        Me.TxtTitle.TabStop = False
        '
        'LabTitle
        '
        Me.LabTitle.AutoSize = True
        Me.LabTitle.Location = New System.Drawing.Point(13, 49)
        Me.LabTitle.Name = "LabTitle"
        Me.LabTitle.Size = New System.Drawing.Size(74, 19)
        Me.LabTitle.TabIndex = 67
        Me.LabTitle.Text = "物品标题："
        '
        'ListLanguage
        '
        Me.ListLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListLanguage.FormattingEnabled = True
        Me.ListLanguage.Items.AddRange(New Object() {"0英语", "1德语", "2法语", "3意大利语", "4韩语", "5西班牙语", "6简体中文", "7繁体中文", "8俄语", "9泰语", "10日语", "11葡萄牙语", "12波兰语", "13丹麦语", "14荷兰语", "15芬兰语", "16挪威语", "17瑞典语", "18匈牙利语", "19捷克语", "20罗马尼亚语", "21土耳其语", "22葡萄牙语-巴西", "23保加利亚语", "24希腊语", "26乌克兰语"})
        Me.ListLanguage.Location = New System.Drawing.Point(360, 10)
        Me.ListLanguage.Name = "ListLanguage"
        Me.ListLanguage.Size = New System.Drawing.Size(191, 27)
        Me.ListLanguage.TabIndex = 66
        Me.ListLanguage.TabStop = False
        '
        'LabLanguage
        '
        Me.LabLanguage.AutoSize = True
        Me.LabLanguage.Location = New System.Drawing.Point(306, 15)
        Me.LabLanguage.Name = "LabLanguage"
        Me.LabLanguage.Size = New System.Drawing.Size(48, 19)
        Me.LabLanguage.TabIndex = 65
        Me.LabLanguage.Text = "语言："
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(107, 12)
        Me.TxtID.MaxLength = 13
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(173, 25)
        Me.TxtID.TabIndex = 10
        Me.TxtID.TabStop = False
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(13, 12)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(88, 19)
        Me.LabID.TabIndex = 0
        Me.LabID.Text = "物品数字ID："
        '
        'LabInfo
        '
        Me.LabInfo.AutoSize = True
        Me.LabInfo.Location = New System.Drawing.Point(12, 39)
        Me.LabInfo.Name = "LabInfo"
        Me.LabInfo.Size = New System.Drawing.Size(490, 57)
        Me.LabInfo.TabIndex = 0
        Me.LabInfo.Text = "本工具是用来强行修改 Steam Workshop 物品简介的，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "包括因为 Steam 方面的 BUG，物品的贡献者也可以修改物品信息。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "请谨慎使用本工具，不" &
    "提供备份保存等功能。完成修改后请自行去浏览器检查情况。"
        '
        'ButGetSteamCookie
        '
        Me.ButGetSteamCookie.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButGetSteamCookie.Location = New System.Drawing.Point(0, 0)
        Me.ButGetSteamCookie.Name = "ButGetSteamCookie"
        Me.ButGetSteamCookie.Size = New System.Drawing.Size(662, 36)
        Me.ButGetSteamCookie.TabIndex = 69
        Me.ButGetSteamCookie.Text = "填写 Steam Cookie"
        Me.ButGetSteamCookie.UseVisualStyleBackColor = True
        '
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLog.Location = New System.Drawing.Point(0, 418)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(662, 148)
        Me.TxtLog.TabIndex = 70
        '
        '创意工坊篡改器
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(662, 566)
        Me.Controls.Add(Me.TxtLog)
        Me.Controls.Add(Me.ButGetSteamCookie)
        Me.Controls.Add(Me.LabInfo)
        Me.Controls.Add(Me.Pn)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "创意工坊篡改器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Steam Workshop 物品信息篡改器"
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pn As Panel
    Friend WithEvents LabInfo As Label
    Friend WithEvents LabID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LabLanguage As Label
    Friend WithEvents ListLanguage As ComboBox
    Friend WithEvents LabTitle As Label
    Friend WithEvents TxtTitle As TextBox
    Friend WithEvents TxtDes As TextBox
    Friend WithEvents LabDes As Label
    Friend WithEvents ButGo As Button
    Friend WithEvents ButGoBrowser As Button
    Friend WithEvents ButGetSteamCookie As Button
    Friend WithEvents TxtLog As TextBox
End Class
