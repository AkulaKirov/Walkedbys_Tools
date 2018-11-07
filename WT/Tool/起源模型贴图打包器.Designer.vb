<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 起源模型贴图打包器
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
        Me.LabModels = New System.Windows.Forms.Label()
        Me.TxtModels = New System.Windows.Forms.TextBox()
        Me.LabMaterials = New System.Windows.Forms.Label()
        Me.TxtMaterials = New System.Windows.Forms.TextBox()
        Me.LabCopy = New System.Windows.Forms.Label()
        Me.TxtCopy = New System.Windows.Forms.TextBox()
        Me.ButGo = New System.Windows.Forms.Button()
        Me.ButList = New System.Windows.Forms.Button()
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabModels
        '
        Me.LabModels.AutoSize = True
        Me.LabModels.Location = New System.Drawing.Point(12, 9)
        Me.LabModels.Name = "LabModels"
        Me.LabModels.Size = New System.Drawing.Size(100, 19)
        Me.LabModels.TabIndex = 0
        Me.LabModels.Text = "模型的文件夹："
        '
        'TxtModels
        '
        Me.TxtModels.Location = New System.Drawing.Point(118, 6)
        Me.TxtModels.MaxLength = 300
        Me.TxtModels.Name = "TxtModels"
        Me.TxtModels.Size = New System.Drawing.Size(578, 25)
        Me.TxtModels.TabIndex = 1
        Me.TxtModels.TabStop = False
        '
        'LabMaterials
        '
        Me.LabMaterials.AutoSize = True
        Me.LabMaterials.Location = New System.Drawing.Point(12, 46)
        Me.LabMaterials.Name = "LabMaterials"
        Me.LabMaterials.Size = New System.Drawing.Size(121, 19)
        Me.LabMaterials.TabIndex = 2
        Me.LabMaterials.Text = "Materials 文件夹："
        '
        'TxtMaterials
        '
        Me.TxtMaterials.Location = New System.Drawing.Point(139, 46)
        Me.TxtMaterials.MaxLength = 300
        Me.TxtMaterials.Name = "TxtMaterials"
        Me.TxtMaterials.Size = New System.Drawing.Size(557, 25)
        Me.TxtMaterials.TabIndex = 3
        Me.TxtMaterials.TabStop = False
        '
        'LabCopy
        '
        Me.LabCopy.AutoSize = True
        Me.LabCopy.Location = New System.Drawing.Point(12, 88)
        Me.LabCopy.Name = "LabCopy"
        Me.LabCopy.Size = New System.Drawing.Size(152, 19)
        Me.LabCopy.TabIndex = 4
        Me.LabCopy.Text = "复制贴图到这个文件夹："
        '
        'TxtCopy
        '
        Me.TxtCopy.Location = New System.Drawing.Point(170, 88)
        Me.TxtCopy.MaxLength = 300
        Me.TxtCopy.Name = "TxtCopy"
        Me.TxtCopy.Size = New System.Drawing.Size(526, 25)
        Me.TxtCopy.TabIndex = 5
        Me.TxtCopy.TabStop = False
        '
        'ButGo
        '
        Me.ButGo.Enabled = False
        Me.ButGo.Location = New System.Drawing.Point(12, 124)
        Me.ButGo.Name = "ButGo"
        Me.ButGo.Size = New System.Drawing.Size(126, 46)
        Me.ButGo.TabIndex = 6
        Me.ButGo.TabStop = False
        Me.ButGo.Text = "点我打包"
        Me.ButGo.UseVisualStyleBackColor = True
        '
        'ButList
        '
        Me.ButList.Enabled = False
        Me.ButList.Location = New System.Drawing.Point(144, 124)
        Me.ButList.Name = "ButList"
        Me.ButList.Size = New System.Drawing.Size(188, 46)
        Me.ButList.TabIndex = 7
        Me.ButList.TabStop = False
        Me.ButList.Text = "仅输出模型用的贴图列表"
        Me.ButList.UseVisualStyleBackColor = True
        '
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLog.Location = New System.Drawing.Point(0, 185)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(708, 190)
        Me.TxtLog.TabIndex = 8
        Me.TxtLog.TabStop = False
        '
        '起源模型贴图打包器
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(708, 375)
        Me.Controls.Add(Me.TxtLog)
        Me.Controls.Add(Me.ButList)
        Me.Controls.Add(Me.ButGo)
        Me.Controls.Add(Me.TxtCopy)
        Me.Controls.Add(Me.LabCopy)
        Me.Controls.Add(Me.TxtMaterials)
        Me.Controls.Add(Me.LabMaterials)
        Me.Controls.Add(Me.TxtModels)
        Me.Controls.Add(Me.LabModels)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.MaximizeBox = False
        Me.Name = "起源模型贴图打包器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "起源模型贴图打包器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabModels As Label
    Friend WithEvents TxtModels As TextBox
    Friend WithEvents LabMaterials As Label
    Friend WithEvents TxtMaterials As TextBox
    Friend WithEvents LabCopy As Label
    Friend WithEvents TxtCopy As TextBox
    Friend WithEvents ButGo As Button
    Friend WithEvents ButList As Button
    Friend WithEvents TxtLog As TextBox
End Class
