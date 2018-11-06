<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Steam批量好友留言
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
        Me.GBsteamCookie = New System.Windows.Forms.GroupBox()
        Me.ButHowToGetCookie = New System.Windows.Forms.Button()
        Me.LabLoginSecure = New System.Windows.Forms.Label()
        Me.LabSession = New System.Windows.Forms.Label()
        Me.TxtLoginSecure = New System.Windows.Forms.TextBox()
        Me.TxtSession = New System.Windows.Forms.TextBox()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.ButUndo = New System.Windows.Forms.Button()
        Me.TxtSay = New System.Windows.Forms.TextBox()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.LabSay = New System.Windows.Forms.Label()
        Me.TxtWork = New System.Windows.Forms.TextBox()
        Me.LabFriends = New System.Windows.Forms.Label()
        Me.ListFriends = New System.Windows.Forms.ListBox()
        Me.ButGetFriends = New System.Windows.Forms.Button()
        Me.TxtLOG = New System.Windows.Forms.TextBox()
        Me.ButSTOP = New System.Windows.Forms.Button()
        Me.ButReSend = New System.Windows.Forms.Button()
        Me.GBsteamCookie.SuspendLayout()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBsteamCookie
        '
        Me.GBsteamCookie.Controls.Add(Me.ButHowToGetCookie)
        Me.GBsteamCookie.Controls.Add(Me.LabLoginSecure)
        Me.GBsteamCookie.Controls.Add(Me.LabSession)
        Me.GBsteamCookie.Controls.Add(Me.TxtLoginSecure)
        Me.GBsteamCookie.Controls.Add(Me.TxtSession)
        Me.GBsteamCookie.Location = New System.Drawing.Point(12, 3)
        Me.GBsteamCookie.Name = "GBsteamCookie"
        Me.GBsteamCookie.Size = New System.Drawing.Size(647, 77)
        Me.GBsteamCookie.TabIndex = 66
        Me.GBsteamCookie.TabStop = False
        Me.GBsteamCookie.Text = "Steam Cookie"
        '
        'ButHowToGetCookie
        '
        Me.ButHowToGetCookie.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButHowToGetCookie.Location = New System.Drawing.Point(17, 18)
        Me.ButHowToGetCookie.Name = "ButHowToGetCookie"
        Me.ButHowToGetCookie.Size = New System.Drawing.Size(28, 25)
        Me.ButHowToGetCookie.TabIndex = 66
        Me.ButHowToGetCookie.TabStop = False
        Me.ButHowToGetCookie.Text = "？"
        Me.ButHowToGetCookie.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButHowToGetCookie.UseVisualStyleBackColor = True
        '
        'LabLoginSecure
        '
        Me.LabLoginSecure.AutoSize = True
        Me.LabLoginSecure.Location = New System.Drawing.Point(6, 46)
        Me.LabLoginSecure.Name = "LabLoginSecure"
        Me.LabLoginSecure.Size = New System.Drawing.Size(132, 19)
        Me.LabLoginSecure.TabIndex = 1
        Me.LabLoginSecure.Text = "steamLoginSecure="
        '
        'LabSession
        '
        Me.LabSession.AutoSize = True
        Me.LabSession.Location = New System.Drawing.Point(64, 18)
        Me.LabSession.Name = "LabSession"
        Me.LabSession.Size = New System.Drawing.Size(74, 19)
        Me.LabSession.TabIndex = 0
        Me.LabSession.Text = "sessionid="
        '
        'TxtLoginSecure
        '
        Me.TxtLoginSecure.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtLoginSecure.Location = New System.Drawing.Point(155, 43)
        Me.TxtLoginSecure.MaxLength = 63
        Me.TxtLoginSecure.Name = "TxtLoginSecure"
        Me.TxtLoginSecure.Size = New System.Drawing.Size(478, 22)
        Me.TxtLoginSecure.TabIndex = 63
        Me.TxtLoginSecure.TabStop = False
        Me.TxtLoginSecure.UseSystemPasswordChar = True
        '
        'TxtSession
        '
        Me.TxtSession.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtSession.Location = New System.Drawing.Point(155, 15)
        Me.TxtSession.MaxLength = 24
        Me.TxtSession.Name = "TxtSession"
        Me.TxtSession.Size = New System.Drawing.Size(478, 22)
        Me.TxtSession.TabIndex = 2
        Me.TxtSession.TabStop = False
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.ButReSend)
        Me.Pn.Controls.Add(Me.ButUndo)
        Me.Pn.Controls.Add(Me.TxtSay)
        Me.Pn.Controls.Add(Me.ButStart)
        Me.Pn.Controls.Add(Me.LabSay)
        Me.Pn.Controls.Add(Me.TxtWork)
        Me.Pn.Controls.Add(Me.LabFriends)
        Me.Pn.Controls.Add(Me.ListFriends)
        Me.Pn.Controls.Add(Me.ButGetFriends)
        Me.Pn.Location = New System.Drawing.Point(12, 86)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(989, 307)
        Me.Pn.TabIndex = 67
        Me.Pn.Visible = False
        '
        'ButUndo
        '
        Me.ButUndo.Location = New System.Drawing.Point(162, 265)
        Me.ButUndo.Name = "ButUndo"
        Me.ButUndo.Size = New System.Drawing.Size(186, 32)
        Me.ButUndo.TabIndex = 68
        Me.ButUndo.Text = "撤回本次发出的留言"
        Me.ButUndo.UseVisualStyleBackColor = True
        '
        'TxtSay
        '
        Me.TxtSay.Location = New System.Drawing.Point(496, 32)
        Me.TxtSay.MaxLength = 800
        Me.TxtSay.Multiline = True
        Me.TxtSay.Name = "TxtSay"
        Me.TxtSay.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtSay.Size = New System.Drawing.Size(482, 227)
        Me.TxtSay.TabIndex = 6
        Me.TxtSay.WordWrap = False
        '
        'ButStart
        '
        Me.ButStart.Location = New System.Drawing.Point(10, 265)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(146, 32)
        Me.ButStart.TabIndex = 7
        Me.ButStart.Text = "批量发出留言"
        Me.ButStart.UseVisualStyleBackColor = True
        '
        'LabSay
        '
        Me.LabSay.AutoSize = True
        Me.LabSay.Location = New System.Drawing.Point(492, 10)
        Me.LabSay.Name = "LabSay"
        Me.LabSay.Size = New System.Drawing.Size(74, 19)
        Me.LabSay.TabIndex = 5
        Me.LabSay.Text = "留言内容："
        '
        'TxtWork
        '
        Me.TxtWork.Location = New System.Drawing.Point(174, 82)
        Me.TxtWork.Multiline = True
        Me.TxtWork.Name = "TxtWork"
        Me.TxtWork.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtWork.Size = New System.Drawing.Size(318, 177)
        Me.TxtWork.TabIndex = 4
        Me.TxtWork.WordWrap = False
        '
        'LabFriends
        '
        Me.LabFriends.AutoSize = True
        Me.LabFriends.Location = New System.Drawing.Point(174, 3)
        Me.LabFriends.Name = "LabFriends"
        Me.LabFriends.Size = New System.Drawing.Size(312, 76)
        Me.LabFriends.TabIndex = 3
        Me.LabFriends.Text = "双击好友列表里的人就可以添加到工作列表。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "如果要留言的人不是好友，请自行弄来他的64位ID。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "格式必须正确 [765611xxxxxxxxxxx]" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "工作列表" &
    "："
        '
        'ListFriends
        '
        Me.ListFriends.FormattingEnabled = True
        Me.ListFriends.ItemHeight = 19
        Me.ListFriends.Location = New System.Drawing.Point(3, 41)
        Me.ListFriends.Name = "ListFriends"
        Me.ListFriends.Size = New System.Drawing.Size(165, 213)
        Me.ListFriends.TabIndex = 2
        '
        'ButGetFriends
        '
        Me.ButGetFriends.Location = New System.Drawing.Point(3, 3)
        Me.ButGetFriends.Name = "ButGetFriends"
        Me.ButGetFriends.Size = New System.Drawing.Size(165, 32)
        Me.ButGetFriends.TabIndex = 0
        Me.ButGetFriends.Text = "获得好友列表"
        Me.ButGetFriends.UseVisualStyleBackColor = True
        '
        'TxtLOG
        '
        Me.TxtLOG.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLOG.Location = New System.Drawing.Point(0, 399)
        Me.TxtLOG.Multiline = True
        Me.TxtLOG.Name = "TxtLOG"
        Me.TxtLOG.ReadOnly = True
        Me.TxtLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLOG.Size = New System.Drawing.Size(1013, 180)
        Me.TxtLOG.TabIndex = 1
        Me.TxtLOG.WordWrap = False
        '
        'ButSTOP
        '
        Me.ButSTOP.Enabled = False
        Me.ButSTOP.Location = New System.Drawing.Point(871, 41)
        Me.ButSTOP.Name = "ButSTOP"
        Me.ButSTOP.Size = New System.Drawing.Size(130, 35)
        Me.ButSTOP.TabIndex = 68
        Me.ButSTOP.Text = "结束工作"
        Me.ButSTOP.UseVisualStyleBackColor = True
        '
        'ButReSend
        '
        Me.ButReSend.Location = New System.Drawing.Point(354, 265)
        Me.ButReSend.Name = "ButReSend"
        Me.ButReSend.Size = New System.Drawing.Size(186, 32)
        Me.ButReSend.TabIndex = 69
        Me.ButReSend.Text = "重试发生失败的留言"
        Me.ButReSend.UseVisualStyleBackColor = True
        '
        'Steam批量好友留言
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1013, 579)
        Me.Controls.Add(Me.ButSTOP)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.GBsteamCookie)
        Me.Controls.Add(Me.TxtLOG)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Steam批量好友留言"
        Me.Text = "Steam批量好友留言"
        Me.GBsteamCookie.ResumeLayout(False)
        Me.GBsteamCookie.PerformLayout()
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBsteamCookie As GroupBox
    Friend WithEvents ButHowToGetCookie As Button
    Friend WithEvents LabLoginSecure As Label
    Friend WithEvents LabSession As Label
    Friend WithEvents TxtLoginSecure As TextBox
    Friend WithEvents TxtSession As TextBox
    Friend WithEvents Pn As Panel
    Friend WithEvents ButGetFriends As Button
    Friend WithEvents TxtLOG As TextBox
    Friend WithEvents ListFriends As ListBox
    Friend WithEvents LabFriends As Label
    Friend WithEvents TxtWork As TextBox
    Friend WithEvents LabSay As Label
    Friend WithEvents TxtSay As TextBox
    Friend WithEvents ButStart As Button
    Friend WithEvents ButUndo As Button
    Friend WithEvents ButSTOP As Button
    Friend WithEvents ButReSend As Button
End Class
