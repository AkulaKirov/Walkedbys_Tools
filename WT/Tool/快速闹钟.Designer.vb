<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 快速闹钟
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
        Me.components = New System.ComponentModel.Container()
        Me.LabNote = New System.Windows.Forms.Label()
        Me.LabWhen = New System.Windows.Forms.Label()
        Me.LabWhat = New System.Windows.Forms.Label()
        Me.TxtWhat = New System.Windows.Forms.TextBox()
        Me.ButStart = New System.Windows.Forms.Button()
        Me.TxtWhen = New System.Windows.Forms.NumericUpDown()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Ring = New System.Windows.Forms.Timer(Me.components)
        CType(Me.TxtWhen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabNote
        '
        Me.LabNote.AutoSize = True
        Me.LabNote.Location = New System.Drawing.Point(12, 9)
        Me.LabNote.Name = "LabNote"
        Me.LabNote.Size = New System.Drawing.Size(471, 20)
        Me.LabNote.TabIndex = 0
        Me.LabNote.Text = "注意：闹钟每次设置都只提醒一次，而且只在本软件开着的时候才能工作。"
        '
        'LabWhen
        '
        Me.LabWhen.AutoSize = True
        Me.LabWhen.Location = New System.Drawing.Point(223, 47)
        Me.LabWhen.Name = "LabWhen"
        Me.LabWhen.Size = New System.Drawing.Size(93, 20)
        Me.LabWhen.TabIndex = 1
        Me.LabWhen.Text = "分钟后提醒我"
        '
        'LabWhat
        '
        Me.LabWhat.AutoSize = True
        Me.LabWhat.Location = New System.Drawing.Point(12, 88)
        Me.LabWhat.Name = "LabWhat"
        Me.LabWhat.Size = New System.Drawing.Size(205, 20)
        Me.LabWhat.TabIndex = 3
        Me.LabWhat.Text = "提醒内容（为空时不弹气泡）："
        '
        'TxtWhat
        '
        Me.TxtWhat.Location = New System.Drawing.Point(223, 85)
        Me.TxtWhat.MaxLength = 20
        Me.TxtWhat.Name = "TxtWhat"
        Me.TxtWhat.Size = New System.Drawing.Size(275, 25)
        Me.TxtWhat.TabIndex = 4
        Me.TxtWhat.TabStop = False
        '
        'ButStart
        '
        Me.ButStart.Location = New System.Drawing.Point(131, 136)
        Me.ButStart.Name = "ButStart"
        Me.ButStart.Size = New System.Drawing.Size(208, 46)
        Me.ButStart.TabIndex = 5
        Me.ButStart.Text = "启动闹钟"
        Me.ButStart.UseVisualStyleBackColor = True
        '
        'TxtWhen
        '
        Me.TxtWhen.Location = New System.Drawing.Point(150, 45)
        Me.TxtWhen.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.TxtWhen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TxtWhen.Name = "TxtWhen"
        Me.TxtWhen.Size = New System.Drawing.Size(67, 25)
        Me.TxtWhen.TabIndex = 6
        Me.TxtWhen.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Ring
        '
        Me.Ring.Interval = 180
        '
        '快速闹钟
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(510, 226)
        Me.Controls.Add(Me.TxtWhen)
        Me.Controls.Add(Me.ButStart)
        Me.Controls.Add(Me.TxtWhat)
        Me.Controls.Add(Me.LabWhat)
        Me.Controls.Add(Me.LabWhen)
        Me.Controls.Add(Me.LabNote)
        Me.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "快速闹钟"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "快速闹钟"
        CType(Me.TxtWhen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabNote As Label
    Friend WithEvents LabWhen As Label
    Friend WithEvents LabWhat As Label
    Friend WithEvents TxtWhat As TextBox
    Friend WithEvents ButStart As Button
    Friend WithEvents TxtWhen As NumericUpDown
    Friend WithEvents Timer1 As Forms.Timer
    Friend WithEvents Ring As Forms.Timer
End Class
