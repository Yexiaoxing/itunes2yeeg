<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flashHolder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(flashHolder))
        Me._1gPlayer = New AxShockwaveFlashObjects.AxShockwaveFlash()
        CType(Me._1gPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_1gPlayer
        '
        Me._1gPlayer.Dock = System.Windows.Forms.DockStyle.Fill
        Me._1gPlayer.Enabled = True
        Me._1gPlayer.Location = New System.Drawing.Point(0, 0)
        Me._1gPlayer.Name = "_1gPlayer"
        Me._1gPlayer.OcxState = CType(resources.GetObject("_1gPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me._1gPlayer.Size = New System.Drawing.Size(304, 474)
        Me._1gPlayer.TabIndex = 7
        '
        'flashHolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 474)
        Me.Controls.Add(Me._1gPlayer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "flashHolder"
        Me.Text = "亦歌"
        CType(Me._1gPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _1gPlayer As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
