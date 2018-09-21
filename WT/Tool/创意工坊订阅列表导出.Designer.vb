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
        Me.ButHowToGetCookie = New System.Windows.Forms.Button()
        Me.LabLoginSecure = New System.Windows.Forms.Label()
        Me.LabSession = New System.Windows.Forms.Label()
        Me.TxtLoginSecure = New System.Windows.Forms.TextBox()
        Me.TxtSession = New System.Windows.Forms.TextBox()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.TxtMax = New System.Windows.Forms.NumericUpDown()
        Me.LabMax = New System.Windows.Forms.Label()
        Me.TxtStart = New System.Windows.Forms.NumericUpDown()
        Me.LabStart = New System.Windows.Forms.Label()
        Me.TxtOut = New System.Windows.Forms.TextBox()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.TxtLink = New System.Windows.Forms.TextBox()
        Me.LabLink = New System.Windows.Forms.Label()
        Me.GBsteamCookie.SuspendLayout()
        Me.Pn.SuspendLayout()
        CType(Me.TxtMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBsteamCookie
        '
        Me.GBsteamCookie.Controls.Add(Me.ButHowToGetCookie)
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
        'ButHowToGetCookie
        '
        Me.ButHowToGetCookie.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ButHowToGetCookie.Location = New System.Drawing.Point(16, 18)
        Me.ButHowToGetCookie.Name = "ButHowToGetCookie"
        Me.ButHowToGetCookie.Size = New System.Drawing.Size(28, 25)
        Me.ButHowToGetCookie.TabIndex = 64
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
        Me.Pn.Controls.Add(Me.TxtMax)
        Me.Pn.Controls.Add(Me.LabMax)
        Me.Pn.Controls.Add(Me.TxtStart)
        Me.Pn.Controls.Add(Me.LabStart)
        Me.Pn.Controls.Add(Me.TxtOut)
        Me.Pn.Controls.Add(Me.ButStart)
        Me.Pn.Controls.Add(Me.TxtLink)
        Me.Pn.Controls.Add(Me.LabLink)
        Me.Pn.Location = New System.Drawing.Point(3, 83)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(639, 339)
        Me.Pn.TabIndex = 67
        Me.Pn.Visible = False
        '
        'TxtMax
        '
        Me.TxtMax.Location = New System.Drawing.Point(251, 72)
        Me.TxtMax.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.TxtMax.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtMax.Name = "TxtMax"
        Me.TxtMax.Size = New System.Drawing.Size(84, 25)
        Me.TxtMax.TabIndex = 8
        Me.TxtMax.TabStop = False
        Me.TxtMax.Value = New Decimal(New Integer() {999, 0, 0, 0})
        '
        'LabMax
        '
        Me.LabMax.AutoSize = True
        Me.LabMax.Location = New System.Drawing.Point(171, 74)
        Me.LabMax.Name = "LabMax"
        Me.LabMax.Size = New System.Drawing.Size(74, 19)
        Me.LabMax.TabIndex = 7
        Me.LabMax.Text = "最多页数："
        '
        'TxtStart
        '
        Me.TxtStart.Location = New System.Drawing.Point(63, 72)
        Me.TxtStart.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.TxtStart.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtStart.Name = "TxtStart"
        Me.TxtStart.Size = New System.Drawing.Size(84, 25)
        Me.TxtStart.TabIndex = 6
        Me.TxtStart.TabStop = False
        Me.TxtStart.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabStart
        '
        Me.LabStart.AutoSize = True
        Me.LabStart.Location = New System.Drawing.Point(9, 74)
        Me.LabStart.Name = "LabStart"
        Me.LabStart.Size = New System.Drawing.Size(48, 19)
        Me.LabStart.TabIndex = 5
        Me.LabStart.Text = "开始："
        '
        'TxtOut
        '
        Me.TxtOut.Location = New System.Drawing.Point(13, 103)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ReadOnly = True
        Me.TxtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOut.Size = New System.Drawing.Size(617, 225)
        Me.TxtOut.TabIndex = 4
        Me.TxtOut.TabStop = False
        '
        'ButStart
        '
        Me.ButStart.Enabled = False
        Me.ButStart.Location = New System.Drawing.Point(491, 68)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(131, 28)
        Me.ButStart.TabIndex = 3
        Me.ButStart.TabStop = False
        Me.ButStart.Text = "开始生成列表"
        Me.ButStart.UseVisualStyleBackColor = True
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
        'LabLink
        '
        Me.LabLink.AutoSize = True
        Me.LabLink.Location = New System.Drawing.Point(9, 15)
        Me.LabLink.Name = "LabLink"
        Me.LabLink.Size = New System.Drawing.Size(243, 19)
        Me.LabLink.TabIndex = 0
        Me.LabLink.Text = "物品列表的网页链接（第一页的即可）："
        '
        '创意工坊订阅列表导出
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(645, 423)
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
        CType(Me.TxtMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtStart, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ButStart As Button
    Friend WithEvents TxtOut As TextBox
    Friend WithEvents LabStart As Label
    Friend WithEvents TxtStart As NumericUpDown
    Friend WithEvents LabMax As Label
    Friend WithEvents TxtMax As NumericUpDown
    Friend WithEvents ButHowToGetCookie As Button
End Class
