<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SMD骨骼修整器
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
        Me.LabInput = New System.Windows.Forms.Label()
        Me.TxtSMD = New System.Windows.Forms.TextBox()
        Me.GBwork = New System.Windows.Forms.GroupBox()
        Me.LabLog = New System.Windows.Forms.Label()
        Me.ButDoLog = New System.Windows.Forms.Button()
        Me.TxtLOG = New System.Windows.Forms.TextBox()
        Me.ButRenameMaterial = New System.Windows.Forms.Button()
        Me.TxtRenameMaterial = New System.Windows.Forms.TextBox()
        Me.ListOtherMaterial = New System.Windows.Forms.ListBox()
        Me.LabOtherMaterial = New System.Windows.Forms.Label()
        Me.ListMaterial = New System.Windows.Forms.ListBox()
        Me.ButRenameF = New System.Windows.Forms.Button()
        Me.LabBones = New System.Windows.Forms.Label()
        Me.ListOtherBones = New System.Windows.Forms.ListBox()
        Me.ButDEL = New System.Windows.Forms.Button()
        Me.ButRename = New System.Windows.Forms.Button()
        Me.TxtRename = New System.Windows.Forms.TextBox()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.ListBones = New System.Windows.Forms.ListBox()
        Me.LabBoneInfo = New System.Windows.Forms.Label()
        Me.ButGoRead = New System.Windows.Forms.Button()
        Me.Always = New System.Windows.Forms.Timer(Me.components)
        Me.LabNote = New System.Windows.Forms.Label()
        Me.ButClearOtherTexture = New System.Windows.Forms.Button()
        Me.GBwork.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabInput
        '
        Me.LabInput.AutoSize = True
        Me.LabInput.Location = New System.Drawing.Point(12, 30)
        Me.LabInput.Name = "LabInput"
        Me.LabInput.Size = New System.Drawing.Size(105, 19)
        Me.LabInput.TabIndex = 0
        Me.LabInput.Text = "要操作的SMD："
        '
        'TxtSMD
        '
        Me.TxtSMD.Location = New System.Drawing.Point(123, 30)
        Me.TxtSMD.MaxLength = 500
        Me.TxtSMD.Name = "TxtSMD"
        Me.TxtSMD.Size = New System.Drawing.Size(567, 25)
        Me.TxtSMD.TabIndex = 1
        Me.TxtSMD.TabStop = False
        '
        'GBwork
        '
        Me.GBwork.Controls.Add(Me.ButClearOtherTexture)
        Me.GBwork.Controls.Add(Me.LabLog)
        Me.GBwork.Controls.Add(Me.ButDoLog)
        Me.GBwork.Controls.Add(Me.TxtLOG)
        Me.GBwork.Controls.Add(Me.ButRenameMaterial)
        Me.GBwork.Controls.Add(Me.TxtRenameMaterial)
        Me.GBwork.Controls.Add(Me.ListOtherMaterial)
        Me.GBwork.Controls.Add(Me.LabOtherMaterial)
        Me.GBwork.Controls.Add(Me.ListMaterial)
        Me.GBwork.Controls.Add(Me.ButRenameF)
        Me.GBwork.Controls.Add(Me.LabBones)
        Me.GBwork.Controls.Add(Me.ListOtherBones)
        Me.GBwork.Controls.Add(Me.ButDEL)
        Me.GBwork.Controls.Add(Me.ButRename)
        Me.GBwork.Controls.Add(Me.TxtRename)
        Me.GBwork.Controls.Add(Me.ButSave)
        Me.GBwork.Controls.Add(Me.ListBones)
        Me.GBwork.Controls.Add(Me.LabBoneInfo)
        Me.GBwork.Location = New System.Drawing.Point(12, 64)
        Me.GBwork.Name = "GBwork"
        Me.GBwork.Size = New System.Drawing.Size(791, 554)
        Me.GBwork.TabIndex = 2
        Me.GBwork.TabStop = False
        Me.GBwork.Text = "操作区"
        Me.GBwork.Visible = False
        '
        'LabLog
        '
        Me.LabLog.AutoSize = True
        Me.LabLog.Location = New System.Drawing.Point(551, 220)
        Me.LabLog.Name = "LabLog"
        Me.LabLog.Size = New System.Drawing.Size(74, 19)
        Me.LabLog.TabIndex = 17
        Me.LabLog.Text = "操作记录："
        '
        'ButDoLog
        '
        Me.ButDoLog.Enabled = False
        Me.ButDoLog.Location = New System.Drawing.Point(653, 207)
        Me.ButDoLog.Name = "ButDoLog"
        Me.ButDoLog.Size = New System.Drawing.Size(121, 34)
        Me.ButDoLog.TabIndex = 16
        Me.ButDoLog.TabStop = False
        Me.ButDoLog.Text = "执行以下操作"
        Me.ButDoLog.UseVisualStyleBackColor = True
        '
        'TxtLOG
        '
        Me.TxtLOG.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtLOG.Location = New System.Drawing.Point(521, 242)
        Me.TxtLOG.Multiline = True
        Me.TxtLOG.Name = "TxtLOG"
        Me.TxtLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLOG.Size = New System.Drawing.Size(253, 137)
        Me.TxtLOG.TabIndex = 15
        Me.TxtLOG.WordWrap = False
        '
        'ButRenameMaterial
        '
        Me.ButRenameMaterial.Enabled = False
        Me.ButRenameMaterial.Location = New System.Drawing.Point(258, 438)
        Me.ButRenameMaterial.Name = "ButRenameMaterial"
        Me.ButRenameMaterial.Size = New System.Drawing.Size(122, 25)
        Me.ButRenameMaterial.TabIndex = 14
        Me.ButRenameMaterial.TabStop = False
        Me.ButRenameMaterial.Text = "重命名贴图"
        Me.ButRenameMaterial.UseVisualStyleBackColor = True
        '
        'TxtRenameMaterial
        '
        Me.TxtRenameMaterial.Location = New System.Drawing.Point(258, 407)
        Me.TxtRenameMaterial.MaxLength = 100
        Me.TxtRenameMaterial.Name = "TxtRenameMaterial"
        Me.TxtRenameMaterial.Size = New System.Drawing.Size(243, 25)
        Me.TxtRenameMaterial.TabIndex = 13
        Me.TxtRenameMaterial.TabStop = False
        '
        'ListOtherMaterial
        '
        Me.ListOtherMaterial.AllowDrop = True
        Me.ListOtherMaterial.FormattingEnabled = True
        Me.ListOtherMaterial.ItemHeight = 19
        Me.ListOtherMaterial.Location = New System.Drawing.Point(521, 411)
        Me.ListOtherMaterial.Name = "ListOtherMaterial"
        Me.ListOtherMaterial.Size = New System.Drawing.Size(253, 137)
        Me.ListOtherMaterial.TabIndex = 12
        Me.ListOtherMaterial.TabStop = False
        '
        'LabOtherMaterial
        '
        Me.LabOtherMaterial.AutoSize = True
        Me.LabOtherMaterial.Location = New System.Drawing.Point(527, 389)
        Me.LabOtherMaterial.Name = "LabOtherMaterial"
        Me.LabOtherMaterial.Size = New System.Drawing.Size(224, 19)
        Me.LabOtherMaterial.TabIndex = 11
        Me.LabOtherMaterial.Text = "↓可以把其他文件拖入到待选贴图列表"
        '
        'ListMaterial
        '
        Me.ListMaterial.AllowDrop = True
        Me.ListMaterial.FormattingEnabled = True
        Me.ListMaterial.ItemHeight = 19
        Me.ListMaterial.Location = New System.Drawing.Point(8, 395)
        Me.ListMaterial.Name = "ListMaterial"
        Me.ListMaterial.Size = New System.Drawing.Size(244, 137)
        Me.ListMaterial.Sorted = True
        Me.ListMaterial.TabIndex = 10
        Me.ListMaterial.TabStop = False
        '
        'ButRenameF
        '
        Me.ButRenameF.Location = New System.Drawing.Point(643, 150)
        Me.ButRenameF.Name = "ButRenameF"
        Me.ButRenameF.Size = New System.Drawing.Size(131, 51)
        Me.ButRenameF.TabIndex = 9
        Me.ButRenameF.TabStop = False
        Me.ButRenameF.Text = "全部骨骼重命名为jointX"
        Me.ButRenameF.UseVisualStyleBackColor = True
        '
        'LabBones
        '
        Me.LabBones.AutoSize = True
        Me.LabBones.Location = New System.Drawing.Point(258, 220)
        Me.LabBones.Name = "LabBones"
        Me.LabBones.Size = New System.Drawing.Size(276, 19)
        Me.LabBones.TabIndex = 8
        Me.LabBones.Text = "↓可以把其他的smd文件拖入这里读取骨骼列表"
        '
        'ListOtherBones
        '
        Me.ListOtherBones.AllowDrop = True
        Me.ListOtherBones.FormattingEnabled = True
        Me.ListOtherBones.ItemHeight = 19
        Me.ListOtherBones.Location = New System.Drawing.Point(258, 242)
        Me.ListOtherBones.Name = "ListOtherBones"
        Me.ListOtherBones.Size = New System.Drawing.Size(253, 137)
        Me.ListOtherBones.TabIndex = 7
        Me.ListOtherBones.TabStop = False
        '
        'ButDEL
        '
        Me.ButDEL.Location = New System.Drawing.Point(258, 181)
        Me.ButDEL.Name = "ButDEL"
        Me.ButDEL.Size = New System.Drawing.Size(371, 34)
        Me.ButDEL.TabIndex = 6
        Me.ButDEL.TabStop = False
        Me.ButDEL.Text = "删除（其附属的部分会转移到它的父骨骼上）"
        Me.ButDEL.UseVisualStyleBackColor = True
        '
        'ButRename
        '
        Me.ButRename.Enabled = False
        Me.ButRename.Location = New System.Drawing.Point(507, 150)
        Me.ButRename.Name = "ButRename"
        Me.ButRename.Size = New System.Drawing.Size(122, 25)
        Me.ButRename.TabIndex = 4
        Me.ButRename.TabStop = False
        Me.ButRename.Text = "重命名骨骼"
        Me.ButRename.UseVisualStyleBackColor = True
        '
        'TxtRename
        '
        Me.TxtRename.Location = New System.Drawing.Point(258, 150)
        Me.TxtRename.MaxLength = 100
        Me.TxtRename.Name = "TxtRename"
        Me.TxtRename.Size = New System.Drawing.Size(243, 25)
        Me.TxtRename.TabIndex = 3
        Me.TxtRename.TabStop = False
        '
        'ButSave
        '
        Me.ButSave.Location = New System.Drawing.Point(684, 14)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(101, 36)
        Me.ButSave.TabIndex = 2
        Me.ButSave.TabStop = False
        Me.ButSave.Text = "保存文件"
        Me.ButSave.UseVisualStyleBackColor = True
        '
        'ListBones
        '
        Me.ListBones.FormattingEnabled = True
        Me.ListBones.ItemHeight = 19
        Me.ListBones.Location = New System.Drawing.Point(8, 24)
        Me.ListBones.Name = "ListBones"
        Me.ListBones.Size = New System.Drawing.Size(244, 365)
        Me.ListBones.TabIndex = 1
        Me.ListBones.TabStop = False
        '
        'LabBoneInfo
        '
        Me.LabBoneInfo.AutoSize = True
        Me.LabBoneInfo.Location = New System.Drawing.Point(258, 24)
        Me.LabBoneInfo.Name = "LabBoneInfo"
        Me.LabBoneInfo.Size = New System.Drawing.Size(61, 19)
        Me.LabBoneInfo.TabIndex = 5
        Me.LabBoneInfo.Text = "骨骼信息"
        '
        'ButGoRead
        '
        Me.ButGoRead.Location = New System.Drawing.Point(696, 31)
        Me.ButGoRead.Name = "ButGoRead"
        Me.ButGoRead.Size = New System.Drawing.Size(107, 27)
        Me.ButGoRead.TabIndex = 3
        Me.ButGoRead.TabStop = False
        Me.ButGoRead.Text = "读取此文件"
        Me.ButGoRead.UseVisualStyleBackColor = True
        '
        'Always
        '
        Me.Always.Enabled = True
        Me.Always.Interval = 20
        '
        'LabNote
        '
        Me.LabNote.AutoSize = True
        Me.LabNote.Location = New System.Drawing.Point(12, 8)
        Me.LabNote.Name = "LabNote"
        Me.LabNote.Size = New System.Drawing.Size(499, 19)
        Me.LabNote.TabIndex = 4
        Me.LabNote.Text = "注意：本工具不稳定性略强，建议不要用了（ 很可能对SMD产生的是破坏而不是修整"
        '
        'ButClearOtherTexture
        '
        Me.ButClearOtherTexture.Enabled = False
        Me.ButClearOtherTexture.Location = New System.Drawing.Point(393, 523)
        Me.ButClearOtherTexture.Name = "ButClearOtherTexture"
        Me.ButClearOtherTexture.Size = New System.Drawing.Size(122, 25)
        Me.ButClearOtherTexture.TabIndex = 18
        Me.ButClearOtherTexture.TabStop = False
        Me.ButClearOtherTexture.Text = "清空待选贴图"
        Me.ButClearOtherTexture.UseVisualStyleBackColor = True
        '
        'SMD骨骼修整器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(815, 630)
        Me.Controls.Add(Me.LabNote)
        Me.Controls.Add(Me.ButGoRead)
        Me.Controls.Add(Me.GBwork)
        Me.Controls.Add(Me.TxtSMD)
        Me.Controls.Add(Me.LabInput)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "SMD骨骼修整器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SMD骨骼修整器"
        Me.GBwork.ResumeLayout(False)
        Me.GBwork.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabInput As Label
    Friend WithEvents TxtSMD As TextBox
    Friend WithEvents GBwork As GroupBox
    Friend WithEvents ListBones As ListBox
    Friend WithEvents ButGoRead As Button
    Friend WithEvents ButSave As Button
    Friend WithEvents TxtRename As TextBox
    Friend WithEvents ButRename As Button
    Friend WithEvents LabBoneInfo As Label
    Friend WithEvents Always As Forms.Timer
    Friend WithEvents ButDEL As Button
    Friend WithEvents LabBones As Label
    Friend WithEvents ListOtherBones As ListBox
    Friend WithEvents ButRenameF As Button
    Friend WithEvents ListMaterial As ListBox
    Friend WithEvents LabOtherMaterial As Label
    Friend WithEvents ListOtherMaterial As ListBox
    Friend WithEvents ButRenameMaterial As Button
    Friend WithEvents TxtRenameMaterial As TextBox
    Friend WithEvents TxtLOG As TextBox
    Friend WithEvents ButDoLog As Button
    Friend WithEvents LabLog As Label
    Friend WithEvents LabNote As Label
    Friend WithEvents ButClearOtherTexture As Button
End Class
