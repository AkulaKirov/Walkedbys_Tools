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
        Me.Pn = New System.Windows.Forms.Panel()
        Me.TxtMax = New System.Windows.Forms.NumericUpDown()
        Me.LabMax = New System.Windows.Forms.Label()
        Me.TxtStart = New System.Windows.Forms.NumericUpDown()
        Me.LabStart = New System.Windows.Forms.Label()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.TxtLink = New System.Windows.Forms.TextBox()
        Me.LabLink = New System.Windows.Forms.Label()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.ButGetSteamCookie = New System.Windows.Forms.Button()
        Me.Pn.SuspendLayout()
        CType(Me.TxtMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.TxtMax)
        Me.Pn.Controls.Add(Me.LabMax)
        Me.Pn.Controls.Add(Me.TxtStart)
        Me.Pn.Controls.Add(Me.LabStart)
        Me.Pn.Controls.Add(Me.ButStart)
        Me.Pn.Controls.Add(Me.TxtLink)
        Me.Pn.Controls.Add(Me.LabLink)
        Me.Pn.Location = New System.Drawing.Point(0, 42)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(639, 116)
        Me.Pn.TabIndex = 67
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
        'ButStart
        '
        Me.ButStart.Enabled = False
        Me.ButStart.Location = New System.Drawing.Point(491, 68)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(131, 28)
        Me.ButStart.TabIndex = 3
        Me.ButStart.TabStop = False
        Me.ButStart.Text = "导出列表"
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
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLog.Location = New System.Drawing.Point(0, 164)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(645, 542)
        Me.TxtLog.TabIndex = 4
        Me.TxtLog.TabStop = False
        '
        'ButGetSteamCookie
        '
        Me.ButGetSteamCookie.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButGetSteamCookie.Location = New System.Drawing.Point(0, 0)
        Me.ButGetSteamCookie.Name = "ButGetSteamCookie"
        Me.ButGetSteamCookie.Size = New System.Drawing.Size(645, 36)
        Me.ButGetSteamCookie.TabIndex = 70
        Me.ButGetSteamCookie.Text = "填写 Steam Cookie"
        Me.ButGetSteamCookie.UseVisualStyleBackColor = True
        '
        '创意工坊订阅列表导出
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(645, 706)
        Me.Controls.Add(Me.ButGetSteamCookie)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.TxtLog)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "创意工坊订阅列表导出"
        Me.Text = "Steam Workshop 物品列表导出"
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        CType(Me.TxtMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pn As Panel
    Friend WithEvents LabLink As Label
    Friend WithEvents TxtLink As TextBox
    Friend WithEvents ButStart As Button
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents LabStart As Label
    Friend WithEvents TxtStart As NumericUpDown
    Friend WithEvents LabMax As Label
    Friend WithEvents TxtMax As NumericUpDown
    Friend WithEvents ButGetSteamCookie As Button
End Class
