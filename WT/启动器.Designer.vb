<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 启动器
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(启动器))
        Me.GBfavorites = New System.Windows.Forms.GroupBox()
        Me.GBallTools = New System.Windows.Forms.GroupBox()
        Me.ListTools = New System.Windows.Forms.ListBox()
        Me.TxtToolDes = New System.Windows.Forms.TextBox()
        Me.ButOpenTool = New System.Windows.Forms.Button()
        Me.ButAddToFavor = New System.Windows.Forms.Button()
        Me.GBallTools.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBfavorites
        '
        Me.GBfavorites.Location = New System.Drawing.Point(12, 12)
        Me.GBfavorites.Name = "GBfavorites"
        Me.GBfavorites.Size = New System.Drawing.Size(706, 117)
        Me.GBfavorites.TabIndex = 0
        Me.GBfavorites.TabStop = False
        Me.GBfavorites.Text = "工具收藏夹"
        '
        'GBallTools
        '
        Me.GBallTools.Controls.Add(Me.ButAddToFavor)
        Me.GBallTools.Controls.Add(Me.ButOpenTool)
        Me.GBallTools.Controls.Add(Me.TxtToolDes)
        Me.GBallTools.Controls.Add(Me.ListTools)
        Me.GBallTools.Location = New System.Drawing.Point(12, 135)
        Me.GBallTools.Name = "GBallTools"
        Me.GBallTools.Size = New System.Drawing.Size(337, 235)
        Me.GBallTools.TabIndex = 1
        Me.GBallTools.TabStop = False
        Me.GBallTools.Text = "全部工具"
        '
        'ListTools
        '
        Me.ListTools.FormattingEnabled = True
        Me.ListTools.ItemHeight = 17
        Me.ListTools.Location = New System.Drawing.Point(11, 23)
        Me.ListTools.Name = "ListTools"
        Me.ListTools.ScrollAlwaysVisible = True
        Me.ListTools.Size = New System.Drawing.Size(145, 208)
        Me.ListTools.TabIndex = 0
        Me.ListTools.TabStop = False
        '
        'TxtToolDes
        '
        Me.TxtToolDes.Location = New System.Drawing.Point(162, 22)
        Me.TxtToolDes.Multiline = True
        Me.TxtToolDes.Name = "TxtToolDes"
        Me.TxtToolDes.ReadOnly = True
        Me.TxtToolDes.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtToolDes.Size = New System.Drawing.Size(169, 166)
        Me.TxtToolDes.TabIndex = 1
        Me.TxtToolDes.TabStop = False
        Me.TxtToolDes.Text = "请从左边的列表里选择一个工具"
        '
        'ButOpenTool
        '
        Me.ButOpenTool.Enabled = False
        Me.ButOpenTool.Location = New System.Drawing.Point(162, 192)
        Me.ButOpenTool.Name = "ButOpenTool"
        Me.ButOpenTool.Size = New System.Drawing.Size(71, 39)
        Me.ButOpenTool.TabIndex = 2
        Me.ButOpenTool.TabStop = False
        Me.ButOpenTool.Text = "开启"
        Me.ButOpenTool.UseVisualStyleBackColor = True
        '
        'ButAddToFavor
        '
        Me.ButAddToFavor.Enabled = False
        Me.ButAddToFavor.Location = New System.Drawing.Point(239, 192)
        Me.ButAddToFavor.Name = "ButAddToFavor"
        Me.ButAddToFavor.Size = New System.Drawing.Size(92, 39)
        Me.ButAddToFavor.TabIndex = 3
        Me.ButAddToFavor.TabStop = False
        Me.ButAddToFavor.Text = "收藏"
        Me.ButAddToFavor.UseVisualStyleBackColor = True
        '
        '启动器
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(730, 381)
        Me.Controls.Add(Me.GBallTools)
        Me.Controls.Add(Me.GBfavorites)
        Me.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "启动器"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "走過去的工具箱"
        Me.GBallTools.ResumeLayout(False)
        Me.GBallTools.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GBfavorites As GroupBox
    Friend WithEvents GBallTools As GroupBox
    Friend WithEvents ListTools As ListBox
    Friend WithEvents TxtToolDes As TextBox
    Friend WithEvents ButOpenTool As Button
    Friend WithEvents ButAddToFavor As Button
End Class
