<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class honyaku
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
        Me.txtRecNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJapan = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChina = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtImageFileName = New System.Windows.Forms.TextBox()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.rtxtImJp = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectImage = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnTuika = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtxtImCh = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rtxtImEn = New System.Windows.Forms.RichTextBox()
        Me.cbxCat = New System.Windows.Forms.ComboBox()
        Me.btnSearchSheet = New System.Windows.Forms.Button()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtRecNo
        '
        Me.txtRecNo.Location = New System.Drawing.Point(68, 8)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.Size = New System.Drawing.Size(77, 19)
        Me.txtRecNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "登録番号"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "日本語"
        '
        'txtJapan
        '
        Me.txtJapan.Location = New System.Drawing.Point(70, 85)
        Me.txtJapan.Name = "txtJapan"
        Me.txtJapan.Size = New System.Drawing.Size(187, 19)
        Me.txtJapan.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "中国語"
        '
        'txtChina
        '
        Me.txtChina.Location = New System.Drawing.Point(70, 110)
        Me.txtChina.Name = "txtChina"
        Me.txtChina.Size = New System.Drawing.Size(187, 19)
        Me.txtChina.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "英語"
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(70, 135)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(187, 19)
        Me.txtEnglish.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "画像ﾌｧｲﾙ"
        '
        'txtImageFileName
        '
        Me.txtImageFileName.Location = New System.Drawing.Point(68, 160)
        Me.txtImageFileName.Name = "txtImageFileName"
        Me.txtImageFileName.Size = New System.Drawing.Size(189, 19)
        Me.txtImageFileName.TabIndex = 8
        '
        'picPhoto
        '
        Me.picPhoto.Location = New System.Drawing.Point(15, 185)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(242, 151)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 10
        Me.picPhoto.TabStop = False
        '
        'rtxtImJp
        '
        Me.rtxtImJp.Location = New System.Drawing.Point(269, 24)
        Me.rtxtImJp.Name = "rtxtImJp"
        Me.rtxtImJp.Size = New System.Drawing.Size(384, 89)
        Me.rtxtImJp.TabIndex = 11
        Me.rtxtImJp.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(268, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 12)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "意味(日本語)"
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(161, 8)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(44, 38)
        Me.btnDown.TabIndex = 13
        Me.btnDown.Text = "<"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(211, 8)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(44, 38)
        Me.btnUp.TabIndex = 14
        Me.btnUp.Text = ">"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnSelectImage
        '
        Me.btnSelectImage.Location = New System.Drawing.Point(15, 342)
        Me.btnSelectImage.Name = "btnSelectImage"
        Me.btnSelectImage.Size = New System.Drawing.Size(240, 23)
        Me.btnSelectImage.TabIndex = 15
        Me.btnSelectImage.Text = "画像ファイル検索"
        Me.btnSelectImage.UseVisualStyleBackColor = True
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(268, 342)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(192, 24)
        Me.btnSet.TabIndex = 16
        Me.btnSet.Text = "登録"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnTuika
        '
        Me.btnTuika.Location = New System.Drawing.Point(68, 29)
        Me.btnTuika.Name = "btnTuika"
        Me.btnTuika.Size = New System.Drawing.Size(77, 19)
        Me.btnTuika.TabIndex = 17
        Me.btnTuika.Text = "追加"
        Me.btnTuika.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 12)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "カテゴリー"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(168, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(87, 19)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "カテゴリー追加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(267, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 12)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "意味(中国語)"
        '
        'rtxtImCh
        '
        Me.rtxtImCh.Location = New System.Drawing.Point(269, 140)
        Me.rtxtImCh.Name = "rtxtImCh"
        Me.rtxtImCh.Size = New System.Drawing.Size(384, 89)
        Me.rtxtImCh.TabIndex = 21
        Me.rtxtImCh.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(268, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 12)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "意味(英語)"
        '
        'rtxtImEn
        '
        Me.rtxtImEn.Location = New System.Drawing.Point(270, 250)
        Me.rtxtImEn.Name = "rtxtImEn"
        Me.rtxtImEn.Size = New System.Drawing.Size(384, 89)
        Me.rtxtImEn.TabIndex = 23
        Me.rtxtImEn.Text = ""
        '
        'cbxCat
        '
        Me.cbxCat.FormattingEnabled = True
        Me.cbxCat.Location = New System.Drawing.Point(70, 59)
        Me.cbxCat.Name = "cbxCat"
        Me.cbxCat.Size = New System.Drawing.Size(94, 20)
        Me.cbxCat.TabIndex = 25
        '
        'btnSearchSheet
        '
        Me.btnSearchSheet.Location = New System.Drawing.Point(518, 342)
        Me.btnSearchSheet.Name = "btnSearchSheet"
        Me.btnSearchSheet.Size = New System.Drawing.Size(136, 25)
        Me.btnSearchSheet.TabIndex = 26
        Me.btnSearchSheet.Text = "検索シートへ戻る"
        Me.btnSearchSheet.UseVisualStyleBackColor = True
        '
        'honyaku
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 372)
        Me.Controls.Add(Me.btnSearchSheet)
        Me.Controls.Add(Me.cbxCat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rtxtImEn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rtxtImCh)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnTuika)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.btnSelectImage)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rtxtImJp)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtImageFileName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtChina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtJapan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRecNo)
        Me.Name = "honyaku"
        Me.Text = "登録シート"
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtRecNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJapan As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChina As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEnglish As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtImageFileName As System.Windows.Forms.TextBox
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents rtxtImJp As System.Windows.Forms.RichTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnSelectImage As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnTuika As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rtxtImCh As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rtxtImEn As System.Windows.Forms.RichTextBox
    Friend WithEvents cbxCat As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearchSheet As System.Windows.Forms.Button

End Class
