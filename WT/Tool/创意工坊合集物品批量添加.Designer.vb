<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 创意工坊合集物品批量添加
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
        Me.TxtOut = New System.Windows.Forms.TextBox()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.LabInput = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LabID = New System.Windows.Forms.Label()
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
        Me.GBsteamCookie.Location = New System.Drawing.Point(1, 0)
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
        Me.TxtSession.Location = New System.Drawing.Point(143, 15)
        Me.TxtSession.MaxLength = 24
        Me.TxtSession.Name = "TxtSession"
        Me.TxtSession.Size = New System.Drawing.Size(478, 22)
        Me.TxtSession.TabIndex = 2
        Me.TxtSession.TabStop = False
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.ButStart)
        Me.Pn.Controls.Add(Me.TxtInput)
        Me.Pn.Controls.Add(Me.LabInput)
        Me.Pn.Controls.Add(Me.TxtID)
        Me.Pn.Controls.Add(Me.LabID)
        Me.Pn.Location = New System.Drawing.Point(1, 83)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(639, 231)
        Me.Pn.TabIndex = 67
        Me.Pn.Visible = False
        '
        'TxtOut
        '
        Me.TxtOut.Location = New System.Drawing.Point(11, 320)
        Me.TxtOut.Multiline = True
        Me.TxtOut.Name = "TxtOut"
        Me.TxtOut.ReadOnly = True
        Me.TxtOut.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtOut.Size = New System.Drawing.Size(619, 100)
        Me.TxtOut.TabIndex = 6
        Me.TxtOut.TabStop = False
        Me.TxtOut.Text = "请注意：" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "先记得把合集创建好" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "而不要合集的创建工作都没彻底完成就来这里添加" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "否则会出BUG" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ButStart
        '
        Me.ButStart.Enabled = False
        Me.ButStart.Location = New System.Drawing.Point(514, 3)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(116, 37)
        Me.ButStart.TabIndex = 4
        Me.ButStart.Text = "导入"
        Me.ButStart.UseVisualStyleBackColor = True
        '
        'TxtInput
        '
        Me.TxtInput.Location = New System.Drawing.Point(10, 66)
        Me.TxtInput.MaxLength = 3000
        Me.TxtInput.Multiline = True
        Me.TxtInput.Name = "TxtInput"
        Me.TxtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtInput.Size = New System.Drawing.Size(620, 151)
        Me.TxtInput.TabIndex = 3
        Me.TxtInput.TabStop = False
        '
        'LabInput
        '
        Me.LabInput.AutoSize = True
        Me.LabInput.Location = New System.Drawing.Point(6, 44)
        Me.LabInput.Name = "LabInput"
        Me.LabInput.Size = New System.Drawing.Size(386, 19)
        Me.LabInput.TabIndex = 2
        Me.LabInput.Text = "要导入的物品列表（仅支持我的物品列表导出工具导出的列表）："
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(113, 10)
        Me.TxtID.MaxLength = 100
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(156, 25)
        Me.TxtID.TabIndex = 1
        Me.TxtID.TabStop = False
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(6, 10)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(101, 19)
        Me.LabID.TabIndex = 0
        Me.LabID.Text = "你的合集的ID："
        '
        '创意工坊合集物品批量添加
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(643, 434)
        Me.Controls.Add(Me.TxtOut)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.GBsteamCookie)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "创意工坊合集物品批量添加"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "创意工坊合集物品批量添加"
        Me.GBsteamCookie.ResumeLayout(False)
        Me.GBsteamCookie.PerformLayout()
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GBsteamCookie As GroupBox
    Friend WithEvents LabLoginSecure As Label
    Friend WithEvents LabSession As Label
    Friend WithEvents TxtLoginSecure As TextBox
    Friend WithEvents TxtSession As TextBox
    Friend WithEvents Pn As Panel
    Friend WithEvents LabID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LabInput As Label
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents ButStart As Button
    Friend WithEvents TxtOut As TextBox
End Class
