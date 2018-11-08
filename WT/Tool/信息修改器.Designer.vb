<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 信息修改器
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
        Me.ListT = New System.Windows.Forms.ListBox()
        Me.TxtInfo = New System.Windows.Forms.TextBox()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.ButRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListT
        '
        Me.ListT.FormattingEnabled = True
        Me.ListT.ItemHeight = 19
        Me.ListT.Location = New System.Drawing.Point(12, 12)
        Me.ListT.Name = "ListT"
        Me.ListT.Size = New System.Drawing.Size(214, 346)
        Me.ListT.Sorted = True
        Me.ListT.TabIndex = 0
        '
        'TxtInfo
        '
        Me.TxtInfo.Location = New System.Drawing.Point(232, 12)
        Me.TxtInfo.MaxLength = 52767
        Me.TxtInfo.Multiline = True
        Me.TxtInfo.Name = "TxtInfo"
        Me.TxtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtInfo.Size = New System.Drawing.Size(571, 346)
        Me.TxtInfo.TabIndex = 1
        Me.TxtInfo.TabStop = False
        Me.TxtInfo.WordWrap = False
        '
        'ButSave
        '
        Me.ButSave.Location = New System.Drawing.Point(10, 364)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(132, 33)
        Me.ButSave.TabIndex = 3
        Me.ButSave.TabStop = False
        Me.ButSave.Text = "保存该项修改"
        Me.ButSave.UseVisualStyleBackColor = True
        '
        'ButRefresh
        '
        Me.ButRefresh.Location = New System.Drawing.Point(148, 364)
        Me.ButRefresh.Name = "ButRefresh"
        Me.ButRefresh.Size = New System.Drawing.Size(125, 33)
        Me.ButRefresh.TabIndex = 4
        Me.ButRefresh.TabStop = False
        Me.ButRefresh.Text = "刷新"
        Me.ButRefresh.UseVisualStyleBackColor = True
        '
        '信息修改器
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(814, 406)
        Me.Controls.Add(Me.ButRefresh)
        Me.Controls.Add(Me.ButSave)
        Me.Controls.Add(Me.TxtInfo)
        Me.Controls.Add(Me.ListT)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "信息修改器"
        Me.Text = "信息修改器（一般人不应该打开这个）"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListT As ListBox
    Friend WithEvents TxtInfo As TextBox
    Friend WithEvents ButSave As Button
    Friend WithEvents ButRefresh As Button
End Class
