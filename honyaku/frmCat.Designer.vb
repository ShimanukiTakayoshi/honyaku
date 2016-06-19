<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCat
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbxCat = New System.Windows.Forms.ComboBox()
        Me.txtNewCat = New System.Windows.Forms.TextBox()
        Me.btnSetNewCat = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxCat
        '
        Me.cbxCat.FormattingEnabled = True
        Me.cbxCat.Location = New System.Drawing.Point(32, 42)
        Me.cbxCat.Name = "cbxCat"
        Me.cbxCat.Size = New System.Drawing.Size(94, 20)
        Me.cbxCat.TabIndex = 26
        '
        'txtNewCat
        '
        Me.txtNewCat.Location = New System.Drawing.Point(32, 92)
        Me.txtNewCat.Name = "txtNewCat"
        Me.txtNewCat.Size = New System.Drawing.Size(124, 19)
        Me.txtNewCat.TabIndex = 27
        '
        'btnSetNewCat
        '
        Me.btnSetNewCat.Location = New System.Drawing.Point(186, 93)
        Me.btnSetNewCat.Name = "btnSetNewCat"
        Me.btnSetNewCat.Size = New System.Drawing.Size(67, 18)
        Me.btnSetNewCat.TabIndex = 28
        Me.btnSetNewCat.Text = "SET"
        Me.btnSetNewCat.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(38, 150)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(117, 29)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(38, 206)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(116, 23)
        Me.btnEnd.TabIndex = 30
        Me.btnEnd.Text = "End"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmCat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 267)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSetNewCat)
        Me.Controls.Add(Me.txtNewCat)
        Me.Controls.Add(Me.cbxCat)
        Me.Name = "frmCat"
        Me.Text = "frmCat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxCat As System.Windows.Forms.ComboBox
    Friend WithEvents txtNewCat As System.Windows.Forms.TextBox
    Friend WithEvents btnSetNewCat As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnEnd As System.Windows.Forms.Button
End Class
