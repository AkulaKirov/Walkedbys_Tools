﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class B站图床
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
        Me.LabDoit = New System.Windows.Forms.Label()
        Me.ButCopy = New System.Windows.Forms.Button()
        Me.ButPaste = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.ButRetry = New System.Windows.Forms.Button()
        Me.CheckAuto = New System.Windows.Forms.CheckBox()
        Me.LabBed = New System.Windows.Forms.Label()
        Me.ListBed = New System.Windows.Forms.ComboBox()
        Me.LinkSource = New System.Windows.Forms.LinkLabel()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabDoit
        '
        Me.LabDoit.AutoSize = True
        Me.LabDoit.Location = New System.Drawing.Point(8, 9)
        Me.LabDoit.Name = "LabDoit"
        Me.LabDoit.Size = New System.Drawing.Size(282, 19)
        Me.LabDoit.TabIndex = 0
        Me.LabDoit.Text = "请把图片拖入到这里或者粘贴图片直接上传图片"
        '
        'ButCopy
        '
        Me.ButCopy.Enabled = False
        Me.ButCopy.Location = New System.Drawing.Point(112, 304)
        Me.ButCopy.Name = "ButCopy"
        Me.ButCopy.Size = New System.Drawing.Size(96, 34)
        Me.ButCopy.TabIndex = 1
        Me.ButCopy.TabStop = False
        Me.ButCopy.Text = "复制链接"
        Me.ButCopy.UseVisualStyleBackColor = True
        '
        'ButPaste
        '
        Me.ButPaste.Location = New System.Drawing.Point(214, 304)
        Me.ButPaste.Name = "ButPaste"
        Me.ButPaste.Size = New System.Drawing.Size(99, 34)
        Me.ButPaste.TabIndex = 2
        Me.ButPaste.TabStop = False
        Me.ButPaste.Text = "粘贴图片"
        Me.ButPaste.UseVisualStyleBackColor = True
        '
        'PicBox
        '
        Me.PicBox.Location = New System.Drawing.Point(12, 47)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(600, 251)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicBox.TabIndex = 3
        Me.PicBox.TabStop = False
        '
        'ButRetry
        '
        Me.ButRetry.Enabled = False
        Me.ButRetry.Location = New System.Drawing.Point(10, 304)
        Me.ButRetry.Name = "ButRetry"
        Me.ButRetry.Size = New System.Drawing.Size(96, 34)
        Me.ButRetry.TabIndex = 4
        Me.ButRetry.TabStop = False
        Me.ButRetry.Text = "重试上传"
        Me.ButRetry.UseVisualStyleBackColor = True
        '
        'CheckAuto
        '
        Me.CheckAuto.AutoSize = True
        Me.CheckAuto.Location = New System.Drawing.Point(319, 311)
        Me.CheckAuto.Name = "CheckAuto"
        Me.CheckAuto.Size = New System.Drawing.Size(210, 23)
        Me.CheckAuto.TabIndex = 5
        Me.CheckAuto.TabStop = False
        Me.CheckAuto.Text = "上传完成自动复制链接到剪贴板"
        Me.CheckAuto.UseVisualStyleBackColor = True
        '
        'LabBed
        '
        Me.LabBed.AutoSize = True
        Me.LabBed.Location = New System.Drawing.Point(12, 353)
        Me.LabBed.Name = "LabBed"
        Me.LabBed.Size = New System.Drawing.Size(48, 19)
        Me.LabBed.TabIndex = 6
        Me.LabBed.Text = "图床："
        '
        'ListBed
        '
        Me.ListBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ListBed.FormattingEnabled = True
        Me.ListBed.Items.AddRange(New Object() {"bilibili", "搜狐", "sm.ms"})
        Me.ListBed.Location = New System.Drawing.Point(66, 350)
        Me.ListBed.Name = "ListBed"
        Me.ListBed.Size = New System.Drawing.Size(121, 27)
        Me.ListBed.TabIndex = 7
        '
        'LinkSource
        '
        Me.LinkSource.AutoSize = True
        Me.LinkSource.Location = New System.Drawing.Point(193, 353)
        Me.LinkSource.Name = "LinkSource"
        Me.LinkSource.Size = New System.Drawing.Size(100, 19)
        Me.LinkSource.TabIndex = 8
        Me.LinkSource.TabStop = True
        Me.LinkSource.Text = "查看图床源网站"
        '
        'B站图床
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(626, 381)
        Me.Controls.Add(Me.LinkSource)
        Me.Controls.Add(Me.ListBed)
        Me.Controls.Add(Me.LabBed)
        Me.Controls.Add(Me.CheckAuto)
        Me.Controls.Add(Me.ButRetry)
        Me.Controls.Add(Me.ButPaste)
        Me.Controls.Add(Me.ButCopy)
        Me.Controls.Add(Me.LabDoit)
        Me.Controls.Add(Me.PicBox)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "B站图床"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "图床"
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabDoit As Label
    Friend WithEvents ButCopy As Button
    Friend WithEvents ButPaste As Button
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents ButRetry As Button
    Friend WithEvents CheckAuto As CheckBox
    Friend WithEvents LabBed As Label
    Friend WithEvents ListBed As ComboBox
    Friend WithEvents LinkSource As LinkLabel
End Class
