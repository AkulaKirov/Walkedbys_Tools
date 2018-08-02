<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VMT生成器
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
        Me.TxtPath = New System.Windows.Forms.TextBox()
        Me.LabPath = New System.Windows.Forms.Label()
        Me.TxtVMT = New System.Windows.Forms.TextBox()
        Me.GBvmt = New System.Windows.Forms.GroupBox()
        Me.TxtTempName = New System.Windows.Forms.TextBox()
        Me.ButUSE = New System.Windows.Forms.Button()
        Me.ButDEL = New System.Windows.Forms.Button()
        Me.ButADD = New System.Windows.Forms.Button()
        Me.CBtemplete = New System.Windows.Forms.ComboBox()
        Me.ListParms = New System.Windows.Forms.ListBox()
        Me.ButGen = New System.Windows.Forms.Button()
        Me.Watching = New System.Windows.Forms.Timer(Me.components)
        Me.TxtLOG = New System.Windows.Forms.TextBox()
        Me.GBvmt.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPath
        '
        Me.TxtPath.AllowDrop = True
        Me.TxtPath.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtPath.Location = New System.Drawing.Point(12, 31)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(685, 22)
        Me.TxtPath.TabIndex = 0
        Me.TxtPath.TabStop = False
        '
        'LabPath
        '
        Me.LabPath.AutoSize = True
        Me.LabPath.Location = New System.Drawing.Point(12, 9)
        Me.LabPath.Name = "LabPath"
        Me.LabPath.Size = New System.Drawing.Size(319, 19)
        Me.LabPath.TabIndex = 1
        Me.LabPath.Text = "贴图文件夹（必须是 materials 文件夹的子文件夹）："
        '
        'TxtVMT
        '
        Me.TxtVMT.HideSelection = False
        Me.TxtVMT.Location = New System.Drawing.Point(6, 24)
        Me.TxtVMT.Multiline = True
        Me.TxtVMT.Name = "TxtVMT"
        Me.TxtVMT.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtVMT.Size = New System.Drawing.Size(270, 227)
        Me.TxtVMT.TabIndex = 2
        Me.TxtVMT.TabStop = False
        '
        'GBvmt
        '
        Me.GBvmt.Controls.Add(Me.TxtTempName)
        Me.GBvmt.Controls.Add(Me.ButUSE)
        Me.GBvmt.Controls.Add(Me.ButDEL)
        Me.GBvmt.Controls.Add(Me.ButADD)
        Me.GBvmt.Controls.Add(Me.CBtemplete)
        Me.GBvmt.Controls.Add(Me.ListParms)
        Me.GBvmt.Controls.Add(Me.TxtVMT)
        Me.GBvmt.Enabled = False
        Me.GBvmt.Location = New System.Drawing.Point(12, 59)
        Me.GBvmt.Name = "GBvmt"
        Me.GBvmt.Size = New System.Drawing.Size(685, 257)
        Me.GBvmt.TabIndex = 3
        Me.GBvmt.TabStop = False
        Me.GBvmt.Text = "VMT选项"
        '
        'TxtTempName
        '
        Me.TxtTempName.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtTempName.Location = New System.Drawing.Point(491, 66)
        Me.TxtTempName.MaxLength = 10
        Me.TxtTempName.Name = "TxtTempName"
        Me.TxtTempName.Size = New System.Drawing.Size(91, 22)
        Me.TxtTempName.TabIndex = 8
        Me.TxtTempName.TabStop = False
        '
        'ButUSE
        '
        Me.ButUSE.Enabled = False
        Me.ButUSE.Location = New System.Drawing.Point(491, 98)
        Me.ButUSE.Name = "ButUSE"
        Me.ButUSE.Size = New System.Drawing.Size(91, 36)
        Me.ButUSE.TabIndex = 7
        Me.ButUSE.TabStop = False
        Me.ButUSE.Text = "使用此模板"
        Me.ButUSE.UseVisualStyleBackColor = True
        '
        'ButDEL
        '
        Me.ButDEL.Enabled = False
        Me.ButDEL.Location = New System.Drawing.Point(582, 98)
        Me.ButDEL.Name = "ButDEL"
        Me.ButDEL.Size = New System.Drawing.Size(91, 36)
        Me.ButDEL.TabIndex = 6
        Me.ButDEL.TabStop = False
        Me.ButDEL.Text = "删除此模板"
        Me.ButDEL.UseVisualStyleBackColor = True
        '
        'ButADD
        '
        Me.ButADD.Enabled = False
        Me.ButADD.Location = New System.Drawing.Point(582, 57)
        Me.ButADD.Name = "ButADD"
        Me.ButADD.Size = New System.Drawing.Size(91, 36)
        Me.ButADD.TabIndex = 5
        Me.ButADD.TabStop = False
        Me.ButADD.Text = "新增为模板"
        Me.ButADD.UseVisualStyleBackColor = True
        '
        'CBtemplete
        '
        Me.CBtemplete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBtemplete.FormattingEnabled = True
        Me.CBtemplete.Location = New System.Drawing.Point(491, 24)
        Me.CBtemplete.Name = "CBtemplete"
        Me.CBtemplete.Size = New System.Drawing.Size(182, 27)
        Me.CBtemplete.TabIndex = 4
        Me.CBtemplete.TabStop = False
        '
        'ListParms
        '
        Me.ListParms.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.ListParms.FormattingEnabled = True
        Me.ListParms.ItemHeight = 16
        Me.ListParms.Items.AddRange(New Object() {"VertexlitGeneric \n{\n\n}", "UnlitGeneric \n{\n\n}", "LightmappedGeneric \n{\n\n}", "$basetexture ""%文件名%""", "$bumpmap ""%文件名%_normal""", "$halflambert 1", "$alphatest 1", "$nocull 1", "$translucent 1", "$model 1", "$envmap env_cubemap", "$nodecal 1", "$nofog 1", "$surfaceprop brick", "$surfaceprop metal", "$surfaceprop wood", "$surfaceprop grass", "$surfaceprop flesh", "$surfaceprop rubber"})
        Me.ListParms.Location = New System.Drawing.Point(282, 24)
        Me.ListParms.Name = "ListParms"
        Me.ListParms.Size = New System.Drawing.Size(199, 212)
        Me.ListParms.TabIndex = 3
        Me.ListParms.TabStop = False
        '
        'ButGen
        '
        Me.ButGen.Enabled = False
        Me.ButGen.Location = New System.Drawing.Point(12, 327)
        Me.ButGen.Name = "ButGen"
        Me.ButGen.Size = New System.Drawing.Size(148, 48)
        Me.ButGen.TabIndex = 11
        Me.ButGen.TabStop = False
        Me.ButGen.Text = "开始监视与生成"
        Me.ButGen.UseVisualStyleBackColor = True
        '
        'Watching
        '
        Me.Watching.Interval = 300
        '
        'TxtLOG
        '
        Me.TxtLOG.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtLOG.Location = New System.Drawing.Point(166, 322)
        Me.TxtLOG.Multiline = True
        Me.TxtLOG.Name = "TxtLOG"
        Me.TxtLOG.ReadOnly = True
        Me.TxtLOG.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLOG.Size = New System.Drawing.Size(531, 61)
        Me.TxtLOG.TabIndex = 12
        Me.TxtLOG.TabStop = False
        '
        'VMT生成器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(709, 387)
        Me.Controls.Add(Me.TxtLOG)
        Me.Controls.Add(Me.ButGen)
        Me.Controls.Add(Me.GBvmt)
        Me.Controls.Add(Me.LabPath)
        Me.Controls.Add(Me.TxtPath)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "VMT生成器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "监视式VMT生成器"
        Me.GBvmt.ResumeLayout(False)
        Me.GBvmt.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPath As TextBox
    Friend WithEvents LabPath As Label
    Friend WithEvents TxtVMT As TextBox
    Friend WithEvents GBvmt As GroupBox
    Friend WithEvents ListParms As ListBox
    Friend WithEvents CBtemplete As ComboBox
    Friend WithEvents ButADD As Button
    Friend WithEvents ButDEL As Button
    Friend WithEvents ButUSE As Button
    Friend WithEvents TxtTempName As TextBox
    Friend WithEvents ButGen As Button
    Friend WithEvents Watching As Windows.Forms.Timer
    Friend WithEvents TxtLOG As TextBox
End Class
