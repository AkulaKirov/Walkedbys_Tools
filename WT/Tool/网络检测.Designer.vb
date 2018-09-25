<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 网络检测
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
        Me.ButStart = New System.Windows.Forms.Button()
        Me.LabOut = New System.Windows.Forms.Label()
        Me.TimerOut = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ButStart
        '
        Me.ButStart.Location = New System.Drawing.Point(482, 12)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(155, 40)
        Me.ButStart.TabIndex = 0
        Me.ButStart.TabStop = False
        Me.ButStart.Text = "开始检测"
        Me.ButStart.UseVisualStyleBackColor = True
        '
        'LabOut
        '
        Me.LabOut.AutoSize = True
        Me.LabOut.Location = New System.Drawing.Point(12, 19)
        Me.LabOut.Name = "LabOut"
        Me.LabOut.Size = New System.Drawing.Size(87, 19)
        Me.LabOut.TabIndex = 1
        Me.LabOut.Text = "测试尚未开始"
        '
        'TimerOut
        '
        Me.TimerOut.Interval = 300
        '
        '网络检测
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(649, 286)
        Me.Controls.Add(Me.LabOut)
        Me.Controls.Add(Me.ButStart)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "网络检测"
        Me.Text = "网络检测"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButStart As Button
    Friend WithEvents LabOut As Label
    Friend WithEvents TimerOut As Forms.Timer
End Class
