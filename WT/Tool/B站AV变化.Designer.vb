<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class B站AV变化
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
        Me.Updater = New System.Windows.Forms.Timer(Me.components)
        Me.CheckMovies = New System.Windows.Forms.CheckBox()
        Me.LabComp = New System.Windows.Forms.Label()
        Me.TxtAV = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Updater
        '
        Me.Updater.Interval = 500
        '
        'CheckMovies
        '
        Me.CheckMovies.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckMovies.AutoSize = True
        Me.CheckMovies.Location = New System.Drawing.Point(12, 416)
        Me.CheckMovies.Name = "CheckMovies"
        Me.CheckMovies.Size = New System.Drawing.Size(211, 23)
        Me.CheckMovies.TabIndex = 0
        Me.CheckMovies.TabStop = False
        Me.CheckMovies.Text = "不显示av数较小的分区（美观）"
        Me.CheckMovies.UseVisualStyleBackColor = True
        '
        'LabComp
        '
        Me.LabComp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabComp.AutoSize = True
        Me.LabComp.Location = New System.Drawing.Point(318, 416)
        Me.LabComp.Name = "LabComp"
        Me.LabComp.Size = New System.Drawing.Size(61, 19)
        Me.LabComp.TabIndex = 1
        Me.LabComp.Text = "对比数："
        '
        'TxtAV
        '
        Me.TxtAV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtAV.Location = New System.Drawing.Point(385, 413)
        Me.TxtAV.MaxLength = 100
        Me.TxtAV.Name = "TxtAV"
        Me.TxtAV.Size = New System.Drawing.Size(135, 25)
        Me.TxtAV.TabIndex = 2
        Me.TxtAV.TabStop = False
        '
        'B站AV变化
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(786, 451)
        Me.Controls.Add(Me.TxtAV)
        Me.Controls.Add(Me.LabComp)
        Me.Controls.Add(Me.CheckMovies)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "B站AV变化"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "B站实时各分区最大AV数"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Updater As Forms.Timer
    Friend WithEvents CheckMovies As CheckBox
    Friend WithEvents LabComp As Label
    Friend WithEvents TxtAV As TextBox
End Class
