<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 有没有少Steam好友
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
        Me.ButGetSteamCookie = New System.Windows.Forms.Button()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.CheckAuto = New System.Windows.Forms.CheckBox()
        Me.ButGetFriends = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.ButCheckSteam = New System.Windows.Forms.Button()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButGetSteamCookie
        '
        Me.ButGetSteamCookie.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButGetSteamCookie.Location = New System.Drawing.Point(0, 0)
        Me.ButGetSteamCookie.Name = "ButGetSteamCookie"
        Me.ButGetSteamCookie.Size = New System.Drawing.Size(628, 39)
        Me.ButGetSteamCookie.TabIndex = 70
        Me.ButGetSteamCookie.Text = "填写 Steam Cookie"
        Me.ButGetSteamCookie.UseVisualStyleBackColor = True
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.CheckAuto)
        Me.Pn.Controls.Add(Me.ButGetFriends)
        Me.Pn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn.Location = New System.Drawing.Point(0, 39)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(628, 54)
        Me.Pn.TabIndex = 71
        '
        'CheckAuto
        '
        Me.CheckAuto.AutoSize = True
        Me.CheckAuto.Location = New System.Drawing.Point(205, 12)
        Me.CheckAuto.Name = "CheckAuto"
        Me.CheckAuto.Size = New System.Drawing.Size(171, 23)
        Me.CheckAuto.TabIndex = 1
        Me.CheckAuto.Text = "开启软件时自动检查一次"
        Me.CheckAuto.UseVisualStyleBackColor = True
        '
        'ButGetFriends
        '
        Me.ButGetFriends.Location = New System.Drawing.Point(3, 6)
        Me.ButGetFriends.Name = "ButGetFriends"
        Me.ButGetFriends.Size = New System.Drawing.Size(196, 33)
        Me.ButGetFriends.TabIndex = 0
        Me.ButGetFriends.Text = "检查我的好友列表"
        Me.ButGetFriends.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TxtLog.Location = New System.Drawing.Point(0, 93)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(628, 352)
        Me.TxtLog.TabIndex = 72
        Me.TxtLog.TabStop = False
        Me.TxtLog.WordWrap = False
        '
        'ButCheckSteam
        '
        Me.ButCheckSteam.Location = New System.Drawing.Point(351, 396)
        Me.ButCheckSteam.Name = "ButCheckSteam"
        Me.ButCheckSteam.Size = New System.Drawing.Size(243, 37)
        Me.ButCheckSteam.TabIndex = 73
        Me.ButCheckSteam.Text = "查看："
        Me.ButCheckSteam.UseVisualStyleBackColor = True
        Me.ButCheckSteam.Visible = False
        '
        '有没有少Steam好友
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(628, 445)
        Me.Controls.Add(Me.ButCheckSteam)
        Me.Controls.Add(Me.TxtLog)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.ButGetSteamCookie)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "有没有少Steam好友"
        Me.Text = "有没有少Steam好友"
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButGetSteamCookie As Button
    Friend WithEvents Pn As Panel
    Friend WithEvents ButGetFriends As Button
    Friend WithEvents CheckAuto As CheckBox
    Friend WithEvents Timer1 As Forms.Timer
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents ButCheckSteam As Button
End Class
