<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 系统代理设置
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
        Me.TxtPAC = New System.Windows.Forms.TextBox()
        Me.ButGetSystem = New System.Windows.Forms.Button()
        Me.ButApply = New System.Windows.Forms.Button()
        Me.TxtProxy = New System.Windows.Forms.TextBox()
        Me.LabPAC = New System.Windows.Forms.Label()
        Me.LabProxy = New System.Windows.Forms.Label()
        Me.ButCheckIP = New System.Windows.Forms.Button()
        Me.TxtIP = New System.Windows.Forms.TextBox()
        Me.ButCheckSystem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtPAC
        '
        Me.TxtPAC.Location = New System.Drawing.Point(66, 10)
        Me.TxtPAC.MaxLength = 500
        Me.TxtPAC.Name = "TxtPAC"
        Me.TxtPAC.Size = New System.Drawing.Size(417, 25)
        Me.TxtPAC.TabIndex = 1
        Me.TxtPAC.TabStop = False
        '
        'ButGetSystem
        '
        Me.ButGetSystem.Location = New System.Drawing.Point(489, 10)
        Me.ButGetSystem.Name = "ButGetSystem"
        Me.ButGetSystem.Size = New System.Drawing.Size(180, 25)
        Me.ButGetSystem.TabIndex = 2
        Me.ButGetSystem.TabStop = False
        Me.ButGetSystem.Text = "读取当前系统代理设置"
        Me.ButGetSystem.UseVisualStyleBackColor = True
        '
        'ButApply
        '
        Me.ButApply.Location = New System.Drawing.Point(489, 41)
        Me.ButApply.Name = "ButApply"
        Me.ButApply.Size = New System.Drawing.Size(180, 25)
        Me.ButApply.TabIndex = 4
        Me.ButApply.TabStop = False
        Me.ButApply.Text = "应用该代理设置"
        Me.ButApply.UseVisualStyleBackColor = True
        '
        'TxtProxy
        '
        Me.TxtProxy.Location = New System.Drawing.Point(105, 41)
        Me.TxtProxy.MaxLength = 500
        Me.TxtProxy.Name = "TxtProxy"
        Me.TxtProxy.Size = New System.Drawing.Size(378, 25)
        Me.TxtProxy.TabIndex = 5
        Me.TxtProxy.TabStop = False
        '
        'LabPAC
        '
        Me.LabPAC.AutoSize = True
        Me.LabPAC.Location = New System.Drawing.Point(12, 10)
        Me.LabPAC.Name = "LabPAC"
        Me.LabPAC.Size = New System.Drawing.Size(48, 19)
        Me.LabPAC.TabIndex = 11
        Me.LabPAC.Text = "PAC："
        '
        'LabProxy
        '
        Me.LabProxy.AutoSize = True
        Me.LabProxy.Location = New System.Drawing.Point(12, 44)
        Me.LabProxy.Name = "LabProxy"
        Me.LabProxy.Size = New System.Drawing.Size(87, 19)
        Me.LabProxy.TabIndex = 12
        Me.LabProxy.Text = "代理服务器："
        '
        'ButCheckIP
        '
        Me.ButCheckIP.Location = New System.Drawing.Point(384, 116)
        Me.ButCheckIP.Name = "ButCheckIP"
        Me.ButCheckIP.Size = New System.Drawing.Size(289, 36)
        Me.ButCheckIP.TabIndex = 14
        Me.ButCheckIP.TabStop = False
        Me.ButCheckIP.Text = "联网获取公网IP (ip.cn)"
        Me.ButCheckIP.UseVisualStyleBackColor = True
        '
        'TxtIP
        '
        Me.TxtIP.Location = New System.Drawing.Point(12, 72)
        Me.TxtIP.Multiline = True
        Me.TxtIP.Name = "TxtIP"
        Me.TxtIP.ReadOnly = True
        Me.TxtIP.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtIP.Size = New System.Drawing.Size(366, 251)
        Me.TxtIP.TabIndex = 15
        Me.TxtIP.TabStop = False
        Me.TxtIP.Text = "本地IP："
        '
        'ButCheckSystem
        '
        Me.ButCheckSystem.Location = New System.Drawing.Point(384, 72)
        Me.ButCheckSystem.Name = "ButCheckSystem"
        Me.ButCheckSystem.Size = New System.Drawing.Size(289, 38)
        Me.ButCheckSystem.TabIndex = 18
        Me.ButCheckSystem.TabStop = False
        Me.ButCheckSystem.Text = "打开系统的 Internet 设置"
        Me.ButCheckSystem.UseVisualStyleBackColor = True
        '
        '系统代理设置
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(682, 334)
        Me.Controls.Add(Me.ButCheckSystem)
        Me.Controls.Add(Me.TxtIP)
        Me.Controls.Add(Me.ButCheckIP)
        Me.Controls.Add(Me.LabProxy)
        Me.Controls.Add(Me.LabPAC)
        Me.Controls.Add(Me.TxtProxy)
        Me.Controls.Add(Me.ButApply)
        Me.Controls.Add(Me.ButGetSystem)
        Me.Controls.Add(Me.TxtPAC)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.Name = "系统代理设置"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "系统代理设置"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPAC As TextBox
    Friend WithEvents ButGetSystem As Button
    Friend WithEvents ButApply As Button
    Friend WithEvents TxtProxy As TextBox
    Friend WithEvents LabPAC As Label
    Friend WithEvents LabProxy As Label
    Friend WithEvents ButCheckIP As Button
    Friend WithEvents TxtIP As TextBox
    Friend WithEvents ButCheckSystem As Button
End Class
