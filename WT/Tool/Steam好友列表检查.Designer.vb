<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Steam好友列表检查
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
        Me.LabNote = New System.Windows.Forms.Label()
        Me.TxtID64 = New System.Windows.Forms.TextBox()
        Me.ButCheck = New System.Windows.Forms.Button()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.ButClear = New System.Windows.Forms.Button()
        Me.CheckAuto = New System.Windows.Forms.CheckBox()
        Me.LabID = New System.Windows.Forms.LinkLabel()
        Me.LabAutoCheck = New System.Windows.Forms.Label()
        Me.ButSearch = New System.Windows.Forms.Button()
        Me.Pn = New System.Windows.Forms.Panel()
        Me.Pn.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabNote
        '
        Me.LabNote.AutoSize = True
        Me.LabNote.Location = New System.Drawing.Point(3, 9)
        Me.LabNote.Name = "LabNote"
        Me.LabNote.Size = New System.Drawing.Size(264, 19)
        Me.LabNote.TabIndex = 1
        Me.LabNote.Text = "请记得开放你的 Steam 好友列表查看权限。"
        '
        'TxtID64
        '
        Me.TxtID64.Location = New System.Drawing.Point(147, 34)
        Me.TxtID64.MaxLength = 200
        Me.TxtID64.Name = "TxtID64"
        Me.TxtID64.Size = New System.Drawing.Size(313, 25)
        Me.TxtID64.TabIndex = 2
        Me.TxtID64.TabStop = False
        '
        'ButCheck
        '
        Me.ButCheck.Enabled = False
        Me.ButCheck.Location = New System.Drawing.Point(466, 4)
        Me.ButCheck.Name = "ButCheck"
        Me.ButCheck.Size = New System.Drawing.Size(92, 28)
        Me.ButCheck.TabIndex = 0
        Me.ButCheck.TabStop = False
        Me.ButCheck.Text = "点我检查"
        Me.ButCheck.UseVisualStyleBackColor = True
        '
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLog.Location = New System.Drawing.Point(0, 112)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(570, 250)
        Me.TxtLog.TabIndex = 1
        Me.TxtLog.TabStop = False
        '
        'ButClear
        '
        Me.ButClear.Location = New System.Drawing.Point(466, 34)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(92, 28)
        Me.ButClear.TabIndex = 2
        Me.ButClear.TabStop = False
        Me.ButClear.Text = "清空日志"
        Me.ButClear.UseVisualStyleBackColor = True
        '
        'CheckAuto
        '
        Me.CheckAuto.AutoSize = True
        Me.CheckAuto.Location = New System.Drawing.Point(7, 67)
        Me.CheckAuto.Name = "CheckAuto"
        Me.CheckAuto.Size = New System.Drawing.Size(171, 23)
        Me.CheckAuto.TabIndex = 3
        Me.CheckAuto.TabStop = False
        Me.CheckAuto.Text = "软件开启时自动检查一次"
        Me.CheckAuto.UseVisualStyleBackColor = True
        '
        'LabID
        '
        Me.LabID.AutoSize = True
        Me.LabID.Location = New System.Drawing.Point(3, 37)
        Me.LabID.Name = "LabID"
        Me.LabID.Size = New System.Drawing.Size(138, 19)
        Me.LabID.TabIndex = 4
        Me.LabID.TabStop = True
        Me.LabID.Text = "你的 Steam 64位ID："
        '
        'LabAutoCheck
        '
        Me.LabAutoCheck.AutoSize = True
        Me.LabAutoCheck.Location = New System.Drawing.Point(234, 68)
        Me.LabAutoCheck.Name = "LabAutoCheck"
        Me.LabAutoCheck.Size = New System.Drawing.Size(204, 19)
        Me.LabAutoCheck.TabIndex = 5
        Me.LabAutoCheck.Text = "本次自动检查没有发现好友减少。"
        '
        'ButSearch
        '
        Me.ButSearch.Location = New System.Drawing.Point(134, 313)
        Me.ButSearch.Name = "ButSearch"
        Me.ButSearch.Size = New System.Drawing.Size(291, 27)
        Me.ButSearch.TabIndex = 6
        Me.ButSearch.Text = "查询："
        Me.ButSearch.UseVisualStyleBackColor = True
        Me.ButSearch.Visible = False
        '
        'Pn
        '
        Me.Pn.Controls.Add(Me.LabNote)
        Me.Pn.Controls.Add(Me.TxtID64)
        Me.Pn.Controls.Add(Me.LabAutoCheck)
        Me.Pn.Controls.Add(Me.ButCheck)
        Me.Pn.Controls.Add(Me.LabID)
        Me.Pn.Controls.Add(Me.ButClear)
        Me.Pn.Controls.Add(Me.CheckAuto)
        Me.Pn.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pn.Location = New System.Drawing.Point(0, 0)
        Me.Pn.Name = "Pn"
        Me.Pn.Size = New System.Drawing.Size(570, 106)
        Me.Pn.TabIndex = 7
        '
        'Steam好友列表检查
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(570, 362)
        Me.Controls.Add(Me.Pn)
        Me.Controls.Add(Me.ButSearch)
        Me.Controls.Add(Me.TxtLog)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Steam好友列表检查"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "有没有少Steam好友"
        Me.Pn.ResumeLayout(False)
        Me.Pn.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabNote As Label
    Friend WithEvents TxtID64 As TextBox
    Friend WithEvents ButCheck As Button
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents ButClear As Button
    Friend WithEvents CheckAuto As CheckBox
    Friend WithEvents LabID As LinkLabel
    Friend WithEvents LabAutoCheck As Label
    Friend WithEvents ButSearch As Button
    Friend WithEvents Pn As Panel
End Class
