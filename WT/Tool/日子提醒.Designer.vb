<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 日子提醒
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
        Me.ListDates = New System.Windows.Forms.ListBox()
        Me.LabMD = New System.Windows.Forms.Label()
        Me.CBmonth = New System.Windows.Forms.ComboBox()
        Me.CBday = New System.Windows.Forms.ComboBox()
        Me.ButRM = New System.Windows.Forms.Button()
        Me.LabJOB = New System.Windows.Forms.Label()
        Me.TxtJOB = New System.Windows.Forms.TextBox()
        Me.ButADD = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListDates
        '
        Me.ListDates.FormattingEnabled = True
        Me.ListDates.ItemHeight = 19
        Me.ListDates.Location = New System.Drawing.Point(12, 12)
        Me.ListDates.Name = "ListDates"
        Me.ListDates.ScrollAlwaysVisible = True
        Me.ListDates.Size = New System.Drawing.Size(489, 213)
        Me.ListDates.Sorted = True
        Me.ListDates.TabIndex = 0
        Me.ListDates.TabStop = False
        '
        'LabMD
        '
        Me.LabMD.AutoSize = True
        Me.LabMD.Location = New System.Drawing.Point(12, 239)
        Me.LabMD.Name = "LabMD"
        Me.LabMD.Size = New System.Drawing.Size(48, 19)
        Me.LabMD.TabIndex = 1
        Me.LabMD.Text = "月日："
        '
        'CBmonth
        '
        Me.CBmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBmonth.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.CBmonth.FormattingEnabled = True
        Me.CBmonth.Location = New System.Drawing.Point(66, 236)
        Me.CBmonth.Name = "CBmonth"
        Me.CBmonth.Size = New System.Drawing.Size(42, 24)
        Me.CBmonth.TabIndex = 2
        Me.CBmonth.TabStop = False
        '
        'CBday
        '
        Me.CBday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBday.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.CBday.FormattingEnabled = True
        Me.CBday.Location = New System.Drawing.Point(114, 236)
        Me.CBday.Name = "CBday"
        Me.CBday.Size = New System.Drawing.Size(52, 24)
        Me.CBday.TabIndex = 3
        Me.CBday.TabStop = False
        '
        'ButRM
        '
        Me.ButRM.Enabled = False
        Me.ButRM.Location = New System.Drawing.Point(404, 236)
        Me.ButRM.Name = "ButRM"
        Me.ButRM.Size = New System.Drawing.Size(97, 27)
        Me.ButRM.TabIndex = 4
        Me.ButRM.TabStop = False
        Me.ButRM.Text = "移除选中项"
        Me.ButRM.UseVisualStyleBackColor = True
        '
        'LabJOB
        '
        Me.LabJOB.AutoSize = True
        Me.LabJOB.Location = New System.Drawing.Point(12, 279)
        Me.LabJOB.Name = "LabJOB"
        Me.LabJOB.Size = New System.Drawing.Size(48, 19)
        Me.LabJOB.TabIndex = 5
        Me.LabJOB.Text = "事情："
        '
        'TxtJOB
        '
        Me.TxtJOB.Location = New System.Drawing.Point(66, 276)
        Me.TxtJOB.MaxLength = 50
        Me.TxtJOB.Name = "TxtJOB"
        Me.TxtJOB.Size = New System.Drawing.Size(435, 25)
        Me.TxtJOB.TabIndex = 6
        Me.TxtJOB.TabStop = False
        '
        'ButADD
        '
        Me.ButADD.Enabled = False
        Me.ButADD.Location = New System.Drawing.Point(404, 307)
        Me.ButADD.Name = "ButADD"
        Me.ButADD.Size = New System.Drawing.Size(97, 27)
        Me.ButADD.TabIndex = 7
        Me.ButADD.TabStop = False
        Me.ButADD.Text = "添加事件"
        Me.ButADD.UseVisualStyleBackColor = True
        '
        '日子提醒
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(509, 348)
        Me.Controls.Add(Me.ButADD)
        Me.Controls.Add(Me.TxtJOB)
        Me.Controls.Add(Me.LabJOB)
        Me.Controls.Add(Me.ButRM)
        Me.Controls.Add(Me.CBday)
        Me.Controls.Add(Me.CBmonth)
        Me.Controls.Add(Me.LabMD)
        Me.Controls.Add(Me.ListDates)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "日子提醒"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "日子提醒器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListDates As ListBox
    Friend WithEvents LabMD As Label
    Friend WithEvents CBmonth As ComboBox
    Friend WithEvents CBday As ComboBox
    Friend WithEvents ButRM As Button
    Friend WithEvents LabJOB As Label
    Friend WithEvents TxtJOB As TextBox
    Friend WithEvents ButADD As Button
End Class
