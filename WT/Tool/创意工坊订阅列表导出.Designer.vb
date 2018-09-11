<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 创意工坊订阅列表导出
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GBsteamCookie = New System.Windows.Forms.GroupBox()
        Me.LabLoginSecure = New System.Windows.Forms.Label()
        Me.LabSession = New System.Windows.Forms.Label()
        Me.TxtLoginSecure = New System.Windows.Forms.TextBox()
        Me.TxtSession = New System.Windows.Forms.TextBox()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.LabLink = New System.Windows.Forms.Label()
        Me.TxtLink = New System.Windows.Forms.TextBox()
        Me.LabWarn = New System.Windows.Forms.Label()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.TxtOut = New System.Windows.Forms.TextBox()
        Me.GBsteamCookie.SuspendLayout()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBsteamCookie
        '
        Me.GBsteamCookie.Controls.Add(Me.LabLoginSecure)
        Me.GBsteamCookie.Controls.Add(Me.LabSession)
        Me.GBsteamCookie.Controls.Add(Me.TxtLoginSecure)
        Me.GBsteamCookie.Controls.Add(Me.TxtSession)
        Me.GBsteamCookie.Location = New System.Drawing.Point(3, 0)
        Me.GBsteamCookie.Name = "GBsteamCookie"
        Me.GBsteamCookie.Size = New System.Drawing.Size(639, 77)
        Me.GBsteamCookie.TabIndex = 66
        Me.GBsteamCookie.TabStop = False
        Me.GBsteamCookie.Text = "Steam Cookie"
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
        Me.TxtLoginSecure.Location = New System.Drawing.Point(143, 43)
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
        Me.TxtSession.Location = New System.Drawing.Point(144, 15)
        Me.TxtSession.MaxLength = 24
        Me.TxtSession.Name = "TxtSession"
        Me.TxtSession.Size = New System.Drawing.Size(478, 22)
        Me.TxtSession.TabIndex = 2
        Me.TxtSession.TabStop = False
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.TxtOut)
        Me.Pn.Controls.Add(Me.ButStart)
        Me.Pn.Controls.Add(Me.LabWarn)
        Me.Pn.Controls.Add(Me.TxtLink)
        Me.Pn.Controls.Add(Me.LabLink)
        Me.Pn.Location = New System.Drawing.Point(3, 83)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(639, 306)
        Me.Pn.TabIndex = 67
        Me.Pn.Visible = False
        '
        'LabLink
        '
        Me.LabLink.AutoSize = True
        Me.LabLink.Location = New System.Drawing.Point(9, 15)
        Me.LabLink.Name = "LabLink"
        Me.LabLink.Size = New System.Drawing.Size(243, 19)
        Me.LabLink.TabIndex = 0
        Me.LabLink.Text = "物品列表的网页链接（第一页的即可）："
        '
        'TxtLink
        '
        Me.TxtLink.Location = New System.Drawing.Point(13, 37)
        Me.TxtLink.MaxLength = 1000
        Me.TxtLink.Name = "TxtLink"
        Me.TxtLink.Size = New System.Drawing.Size(609, 25)
        Me.TxtLink.TabIndex = 1
        Me.TxtLink.TabStop = False
        '
        'LabWarn
        '
        Me.LabWarn.AutoSize = True
        Me.LabWarn.Location = New System.Drawing.Point(9, 75)
        Me.LabWarn.Name = "LabWarn"
        Me.LabWarn.Size = New System.Drawing.Size(428, 19)
        Me.LabWarn.TabIndex = 2
        Me.LabWarn.Text = "警告：不要故意玩我，因为我会每页读取30个物品，读取直到最后一页。"
        '
        'ButStart
        '
        Me.ButStart.Enabled = False
        Me.ButStart.Location = New System.Drawing.Point(443, 68)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(147, 28)
        Me.ButStart.TabIndex = 3
        Me.ButStart.TabStop = False
        Me.ButStart.Text = "开始生成列表"
        Me.ButStart.UseVisualStyleBackColor = True
        '
        'TxtOut
        '
        Me.TxtOut.Location = New System.Drawing.Point(13, 107)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ReadOnly = True
        Me.TxtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOut.Size = New System.Drawing.Size(617, 196)
        Me.TxtOut.TabIndex = 4
        Me.TxtOut.TabStop = False
        '
        '创意工坊订阅列表导出
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(645, 401)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.GBsteamCookie)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "创意工坊订阅列表导出"
        Me.Text = "Steam Workshop 物品列表导出"
        Me.GBsteamCookie.ResumeLayout(False)
        Me.GBsteamCookie.PerformLayout()
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBsteamCookie As GroupBox
    Friend WithEvents LabLoginSecure As Label
    Friend WithEvents LabSession As Label
    Friend WithEvents TxtLoginSecure As TextBox
    Friend WithEvents TxtSession As TextBox
    Friend WithEvents Pn As Panel
    Friend WithEvents LabLink As Label
    Friend WithEvents TxtLink As TextBox
    Friend WithEvents LabWarn As Label
    Friend WithEvents ButStart As Button
    Friend WithEvents TxtOut As TextBox
End Class
