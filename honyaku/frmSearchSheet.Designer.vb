<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchSheet
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
        Me.cbxSrcCat = New System.Windows.Forms.ComboBox()
        Me.btnReg = New System.Windows.Forms.Button()
        Me.dgvSrcList = New System.Windows.Forms.DataGridView()
        Me.btnSrcStart = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rtxtImEn = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtxtImCh = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtxtImJp = New System.Windows.Forms.RichTextBox()
        Me.picPhoto = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEnglish = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtChina = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtJapan = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRecNo = New System.Windows.Forms.TextBox()
        Me.txtCt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKeyWord = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        CType(Me.dgvSrcList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbxSrcCat
        '
        Me.cbxSrcCat.FormattingEnabled = True
        Me.cbxSrcCat.Location = New System.Drawing.Point(56, 12)
        Me.cbxSrcCat.Name = "cbxSrcCat"
        Me.cbxSrcCat.Size = New System.Drawing.Size(83, 20)
        Me.cbxSrcCat.TabIndex = 0
        '
        'btnReg
        '
        Me.btnReg.Location = New System.Drawing.Point(650, 14)
        Me.btnReg.Name = "btnReg"
        Me.btnReg.Size = New System.Drawing.Size(192, 19)
        Me.btnReg.TabIndex = 1
        Me.btnReg.Text = "新規登録/登録内容変更"
        Me.btnReg.UseVisualStyleBackColor = True
        '
        'dgvSrcList
        '
        Me.dgvSrcList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSrcList.Location = New System.Drawing.Point(14, 39)
        Me.dgvSrcList.Name = "dgvSrcList"
        Me.dgvSrcList.RowTemplate.Height = 21
        Me.dgvSrcList.Size = New System.Drawing.Size(829, 241)
        Me.dgvSrcList.TabIndex = 2
        '
        'btnSrcStart
        '
        Me.btnSrcStart.Location = New System.Drawing.Point(519, 13)
        Me.btnSrcStart.Name = "btnSrcStart"
        Me.btnSrcStart.Size = New System.Drawing.Size(91, 19)
        Me.btnSrcStart.TabIndex = 3
        Me.btnSrcStart.Text = "検索開始"
        Me.btnSrcStart.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(279, 525)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 12)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "意味(英語)"
        '
        'rtxtImEn
        '
        Me.rtxtImEn.Location = New System.Drawing.Point(281, 540)
        Me.rtxtImEn.Name = "rtxtImEn"
        Me.rtxtImEn.Size = New System.Drawing.Size(546, 97)
        Me.rtxtImEn.TabIndex = 47
        Me.rtxtImEn.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 402)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 12)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "意味(中国語)"
        '
        'rtxtImCh
        '
        Me.rtxtImCh.Location = New System.Drawing.Point(283, 420)
        Me.rtxtImCh.Name = "rtxtImCh"
        Me.rtxtImCh.Size = New System.Drawing.Size(546, 97)
        Me.rtxtImCh.TabIndex = 45
        Me.rtxtImCh.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 12)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "カテゴリー"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(282, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 12)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "意味(日本語)"
        '
        'rtxtImJp
        '
        Me.rtxtImJp.Location = New System.Drawing.Point(283, 300)
        Me.rtxtImJp.Name = "rtxtImJp"
        Me.rtxtImJp.Size = New System.Drawing.Size(546, 97)
        Me.rtxtImJp.TabIndex = 37
        Me.rtxtImJp.Text = ""
        '
        'picPhoto
        '
        Me.picPhoto.Location = New System.Drawing.Point(19, 426)
        Me.picPhoto.Name = "picPhoto"
        Me.picPhoto.Size = New System.Drawing.Size(130, 63)
        Me.picPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picPhoto.TabIndex = 36
        Me.picPhoto.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "英語"
        '
        'txtEnglish
        '
        Me.txtEnglish.Location = New System.Drawing.Point(74, 392)
        Me.txtEnglish.Name = "txtEnglish"
        Me.txtEnglish.Size = New System.Drawing.Size(187, 19)
        Me.txtEnglish.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 370)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 12)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "中国語"
        '
        'txtChina
        '
        Me.txtChina.Location = New System.Drawing.Point(74, 367)
        Me.txtChina.Name = "txtChina"
        Me.txtChina.Size = New System.Drawing.Size(187, 19)
        Me.txtChina.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 345)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "日本語"
        '
        'txtJapan
        '
        Me.txtJapan.Location = New System.Drawing.Point(74, 342)
        Me.txtJapan.Name = "txtJapan"
        Me.txtJapan.Size = New System.Drawing.Size(187, 19)
        Me.txtJapan.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "登録番号"
        '
        'txtRecNo
        '
        Me.txtRecNo.Location = New System.Drawing.Point(72, 293)
        Me.txtRecNo.Name = "txtRecNo"
        Me.txtRecNo.Size = New System.Drawing.Size(77, 19)
        Me.txtRecNo.TabIndex = 26
        '
        'txtCt
        '
        Me.txtCt.Location = New System.Drawing.Point(72, 317)
        Me.txtCt.Name = "txtCt"
        Me.txtCt.Size = New System.Drawing.Size(77, 19)
        Me.txtCt.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 12)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "カテゴリ"
        '
        'txtKeyWord
        '
        Me.txtKeyWord.Location = New System.Drawing.Point(256, 13)
        Me.txtKeyWord.Name = "txtKeyWord"
        Me.txtKeyWord.Size = New System.Drawing.Size(246, 19)
        Me.txtKeyWord.TabIndex = 58
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(173, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 12)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "検索キーワード"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 498)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(156, 19)
        Me.TextBox1.TabIndex = 60
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(36, 522)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(154, 19)
        Me.TextBox2.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 591)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 26)
        Me.Button1.TabIndex = 62
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(35, 545)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(154, 19)
        Me.TextBox3.TabIndex = 63
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(168, 431)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(35, 19)
        Me.TextBox4.TabIndex = 64
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(215, 432)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(34, 19)
        Me.TextBox5.TabIndex = 65
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(208, 596)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 20)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(168, 459)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(36, 19)
        Me.TextBox6.TabIndex = 67
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(213, 462)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(36, 19)
        Me.TextBox7.TabIndex = 68
        '
        'frmSearchSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 645)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtKeyWord)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rtxtImEn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.rtxtImCh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rtxtImJp)
        Me.Controls.Add(Me.picPhoto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEnglish)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtChina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtJapan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRecNo)
        Me.Controls.Add(Me.btnSrcStart)
        Me.Controls.Add(Me.dgvSrcList)
        Me.Controls.Add(Me.btnReg)
        Me.Controls.Add(Me.cbxSrcCat)
        Me.Name = "frmSearchSheet"
        Me.Text = "frmSearchSheet"
        CType(Me.dgvSrcList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxSrcCat As System.Windows.Forms.ComboBox
    Friend WithEvents btnReg As System.Windows.Forms.Button
    Friend WithEvents dgvSrcList As System.Windows.Forms.DataGridView
    Friend WithEvents btnSrcStart As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rtxtImEn As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rtxtImCh As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rtxtImJp As System.Windows.Forms.RichTextBox
    Friend WithEvents picPhoto As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEnglish As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtChina As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtJapan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRecNo As System.Windows.Forms.TextBox
    Friend WithEvents txtCt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtKeyWord As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
