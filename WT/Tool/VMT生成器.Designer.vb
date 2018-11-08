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
        Me.CheckSon = New System.Windows.Forms.CheckBox()
        Me.ListParms = New System.Windows.Forms.ListBox()
        Me.ButGen = New System.Windows.Forms.Button()
        Me.Watching = New System.Windows.Forms.Timer(Me.components)
        Me.TxtLog = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtPath
        '
        Me.TxtPath.AllowDrop = True
        Me.TxtPath.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtPath.Location = New System.Drawing.Point(12, 31)
        Me.TxtPath.Name = "TxtPath"
        Me.TxtPath.Size = New System.Drawing.Size(821, 22)
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
        Me.TxtVMT.Location = New System.Drawing.Point(12, 59)
        Me.TxtVMT.Multiline = True
        Me.TxtVMT.Name = "TxtVMT"
        Me.TxtVMT.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtVMT.Size = New System.Drawing.Size(276, 300)
        Me.TxtVMT.TabIndex = 2
        Me.TxtVMT.TabStop = False
        '
        'CheckSon
        '
        Me.CheckSon.AutoSize = True
        Me.CheckSon.Location = New System.Drawing.Point(478, 5)
        Me.CheckSon.Name = "CheckSon"
        Me.CheckSon.Size = New System.Drawing.Size(158, 23)
        Me.CheckSon.TabIndex = 9
        Me.CheckSon.TabStop = False
        Me.CheckSon.Text = "扫描子文件夹内的贴图"
        Me.CheckSon.UseVisualStyleBackColor = True
        '
        'ListParms
        '
        Me.ListParms.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.ListParms.FormattingEnabled = True
        Me.ListParms.ItemHeight = 16
        Me.ListParms.Items.AddRange(New Object() {"VertexlitGeneric \n{\n\n}", "UnlitGeneric \n{\n\n}", "LightmappedGeneric \n{\n\n}", "$basetexture ""%文件名%""", "$bumpmap ""%文件名%_normal""", "$bumpmap ""%文件名%_n""", "$decal  1 \n$decalscale  0.25", "$halflambert 1", "$alphatest 1", "$nocull 1", "$translucent 1", "$model 1", "$envmap env_cubemap", "$nodecal 1", "$nofog 1", "$surfaceprop brick", "$surfaceprop metal", "$surfaceprop wood", "$surfaceprop grass", "$surfaceprop flesh", "$surfaceprop rubber", "Proxies\n {\n AnimatedTexture\n {\n animatedtexturevar $basetexture\n animatedtex" &
                "tureframenumvar $frame\n animatedtextureframerate 25\n }\n }", "$phong 1\n$phongboost 1\n$PhongFresnelRanges ""[0 0.5 1]""\n$PhongExponent 5\n$ligh" &
                "twarptexture ""%路径%\shader""", "$rimlight 1\n$rimlightexponent 2\n$rimlightboost .2"})
        Me.ListParms.Location = New System.Drawing.Point(294, 59)
        Me.ListParms.Name = "ListParms"
        Me.ListParms.Size = New System.Drawing.Size(307, 292)
        Me.ListParms.TabIndex = 3
        Me.ListParms.TabStop = False
        '
        'ButGen
        '
        Me.ButGen.Font = New System.Drawing.Font("微软雅黑", 10.0!)
        Me.ButGen.Location = New System.Drawing.Point(607, 59)
        Me.ButGen.Name = "ButGen"
        Me.ButGen.Size = New System.Drawing.Size(226, 73)
        Me.ButGen.TabIndex = 11
        Me.ButGen.TabStop = False
        Me.ButGen.Text = "开始监视与生成VMT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(只在本工具运行的时候监视)"
        Me.ButGen.UseVisualStyleBackColor = True
        '
        'Watching
        '
        Me.Watching.Interval = 300
        '
        'TxtLog
        '
        Me.TxtLog.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TxtLog.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.TxtLog.Location = New System.Drawing.Point(0, 369)
        Me.TxtLog.Multiline = True
        Me.TxtLog.Name = "TxtLog"
        Me.TxtLog.ReadOnly = True
        Me.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtLog.Size = New System.Drawing.Size(845, 157)
        Me.TxtLog.TabIndex = 12
        Me.TxtLog.TabStop = False
        '
        'VMT生成器
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(845, 526)
        Me.Controls.Add(Me.CheckSon)
        Me.Controls.Add(Me.TxtLog)
        Me.Controls.Add(Me.ListParms)
        Me.Controls.Add(Me.ButGen)
        Me.Controls.Add(Me.TxtVMT)
        Me.Controls.Add(Me.LabPath)
        Me.Controls.Add(Me.TxtPath)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "VMT生成器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "监视式 VMT 生成器"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPath As TextBox
    Friend WithEvents LabPath As Label
    Friend WithEvents TxtVMT As TextBox
    Friend WithEvents ListParms As ListBox
    Friend WithEvents ButGen As Button
    Friend WithEvents Watching As System.Windows.Forms.Timer
    Friend WithEvents TxtLog As TextBox
    Friend WithEvents CheckSon As CheckBox
End Class
