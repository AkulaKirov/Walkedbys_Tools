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
        Me.components = New System.ComponentModel.Container()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.ButReSend = New System.Windows.Forms.Button()
        Me.ButUndo = New System.Windows.Forms.Button()
        Me.TxtSay = New System.Windows.Forms.TextBox()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.LabSay = New System.Windows.Forms.Label()
        Me.TxtWork = New System.Windows.Forms.TextBox()
        Me.LabFriends = New System.Windows.Forms.Label()
        Me.ListFriends = New System.Windows.Forms.ListBox()
        Me.ButGetFriends = New System.Windows.Forms.Button()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.ShowCount = New System.Windows.Forms.Timer(Me.components)
        Me.ButGetSteamCookie = New System.Windows.Forms.Button()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Pn.Location = New System.Drawing.Point(12, 45)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(989, 307)
        Me.Pn.TabIndex = 67
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
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLog.Location = New System.Drawing.Point(0, 366)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(1013, 180)
        Me.TxtLog.TabIndex = 1
        Me.TxtLog.WordWrap = False
        '
        'ShowCount
        '
        Me.ShowCount.Enabled = True
        '
        'ButGetSteamCookie
        '
        Me.ButGetSteamCookie.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButGetSteamCookie.Location = New System.Drawing.Point(0, 0)
        Me.ButGetSteamCookie.Name = "ButGetSteamCookie"
        Me.ButGetSteamCookie.Size = New System.Drawing.Size(1013, 39)
        Me.ButGetSteamCookie.TabIndex = 69
        Me.ButGetSteamCookie.Text = "填写 Steam Cookie"
        Me.ButGetSteamCookie.UseVisualStyleBackColor = True
        '
        'Steam批量好友留言
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1013, 546)
        Me.Controls.Add(Me.ButGetSteamCookie)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.TxtLog)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Steam批量好友留言"
        Me.Text = "Steam批量好友留言"
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pn As Panel
    Friend WithEvents ButGetFriends As Button
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents ListFriends As ListBox
    Friend WithEvents LabFriends As Label
    Friend WithEvents TxtWork As TextBox
    Friend WithEvents LabSay As Label
    Friend WithEvents TxtSay As TextBox
    Friend WithEvents ButStart As Button
    Friend WithEvents ButUndo As Button
    Friend WithEvents ButReSend As Button
    Friend WithEvents ShowCount As Forms.Timer
    Friend WithEvents ButGetSteamCookie As Button
End Class
