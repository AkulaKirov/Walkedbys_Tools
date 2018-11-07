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
        Me.Pn = New System.Windows.Forms.Panel()
        Me.TxtInput = New System.Windows.Forms.TextBox()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.LabInput = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LabID = New System.Windows.Forms.Label()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.ButGetSteamCookie = New System.Windows.Forms.Button()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.TxtInput)
        Me.Pn.Controls.Add(Me.ButStart)
        Me.Pn.Controls.Add(Me.LabInput)
        Me.Pn.Controls.Add(Me.TxtID)
        Me.Pn.Controls.Add(Me.LabID)
        Me.Pn.Location = New System.Drawing.Point(4, 42)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(639, 231)
        Me.Pn.TabIndex = 67
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
        'ButStart
        '
        Me.ButStart.Location = New System.Drawing.Point(408, 10)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(150, 37)
        Me.ButStart.TabIndex = 4
        Me.ButStart.Text = "点我导入"
        Me.ButStart.UseVisualStyleBackColor = True
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
        Me.TxtID.Location = New System.Drawing.Point(113, 7)
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
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLog.Location = New System.Drawing.Point(0, 279)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(643, 187)
        Me.TxtLog.TabIndex = 6
        Me.TxtLog.TabStop = False
        '
        'ButGetSteamCookie
        '
        Me.ButGetSteamCookie.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButGetSteamCookie.Location = New System.Drawing.Point(0, 0)
        Me.ButGetSteamCookie.Name = "ButGetSteamCookie"
        Me.ButGetSteamCookie.Size = New System.Drawing.Size(643, 36)
        Me.ButGetSteamCookie.TabIndex = 68
        Me.ButGetSteamCookie.Text = "填写 Steam Cookie"
        Me.ButGetSteamCookie.UseVisualStyleBackColor = True
        '
        '创意工坊合集物品批量添加
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(643, 466)
        Me.Controls.Add(Me.ButGetSteamCookie)
        Me.Controls.Add(Me.TxtLog)
        Me.Controls.Add(Me.Pn)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "创意工坊合集物品批量添加"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "创意工坊合集物品批量添加"
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Pn As Panel
    Friend WithEvents LabID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LabInput As Label
    Friend WithEvents TxtInput As TextBox
    Friend WithEvents ButStart As Button
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents ButGetSteamCookie As Button
End Class
