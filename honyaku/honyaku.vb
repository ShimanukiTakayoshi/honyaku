'登録処理
Public Class honyaku

    Public Sub RegSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '登録フォーム呼び出し処理
        txtImageFileName.Text = ""
        PutOutT()
    End Sub

    Public Sub PutOutT()
        '登録画面内容表示
        txtRecNo.Text = CStr(frmSearchSheet.NowItem)
        cbxCat.SelectedIndex = frmSearchSheet.noCt(frmSearchSheet.NowItem)
        txtJapan.Text = frmSearchSheet.txJp(frmSearchSheet.NowItem)
        txtChina.Text = frmSearchSheet.txCh(frmSearchSheet.NowItem)
        txtEnglish.Text = frmSearchSheet.txEn(frmSearchSheet.NowItem)
        rtxtImJp.Text = frmSearchSheet.txImJp(frmSearchSheet.NowItem)
        rtxtImCh.Text = frmSearchSheet.txImCh(frmSearchSheet.NowItem)
        rtxtImEn.Text = frmSearchSheet.txImEn(frmSearchSheet.NowItem)
        '画像＆画像ファイル名表示
        If frmSearchSheet.NewItemWorkingFlag Then
            '新規登録時処理（デフォルトの「NOW PRINTING」設定）
            picPhoto.ImageLocation = frmSearchSheet.ImageFileName
            txtImageFileName.Text = frmSearchSheet.ImageFileName
        ElseIf Microsoft.VisualBasic.FileIO.FileSystem.FileExists("c:\honyaku\pic\" + Trim(Str(frmSearchSheet.NowItem)) + ".jpg") Then
            '通常の現在登録番号の画像＆画像ファイル名表示
            picPhoto.ImageLocation = "c:\honyaku\pic\" + Trim(Str(frmSearchSheet.NowItem)) + ".jpg"
            txtImageFileName.Text = "c:\honyaku\pic\" + Trim(Str(frmSearchSheet.NowItem)) + ".jpg"
        Else
            '画像ファイルが登録されていない場案｢NowPrinting｣表示
            picPhoto.ImageLocation = "c:\honyaku\pic\NowPrinting.jpg"
            txtImageFileName.Text = ""
        End If
    End Sub

    Public Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        '登録番号デクリメント処理
        If frmSearchSheet.NowItem > 0 Then
            frmSearchSheet.NowItem -= 1
            PutOutT()
        End If
    End Sub

    Public Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        '登録番号インクリメント処理
        If frmSearchSheet.MaxItem > frmSearchSheet.NowItem Then
            frmSearchSheet.NowItem += 1
            PutOutT()
        End If
    End Sub

    Public Sub btnSelectImage_Click(sender As Object, e As EventArgs) Handles btnSelectImage.Click
        '画像ファイル検索処理
        frmSearchSheet.ImageFileName = CStr(OpenFileDialog1.ShowDialog)
        frmSearchSheet.ImageFileName = OpenFileDialog1.FileName
        txtImageFileName.Text = frmSearchSheet.ImageFileName
        picPhoto.ImageLocation = frmSearchSheet.ImageFileName
    End Sub

    Public Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        '登録処理
        Dim fn0 As String '保存先画像ﾌｧｲﾙ名
        Dim fn1 As String '保存元画像ﾌｧｲﾙ名
        '新規登録の場合は最大登録数を＋１する
        If frmSearchSheet.NewItemWorkingFlag Then frmSearchSheet.MaxItem += 1
        '登録内容を各変数へ設定
        frmSearchSheet.noCt(frmSearchSheet.NowItem) = cbxCat.SelectedIndex
        frmSearchSheet.txJp(frmSearchSheet.NowItem) = Trim(txtJapan.Text)
        frmSearchSheet.txCh(frmSearchSheet.NowItem) = Trim(txtChina.Text)
        frmSearchSheet.txEn(frmSearchSheet.NowItem) = Trim(txtEnglish.Text)
        frmSearchSheet.txImJp(frmSearchSheet.NowItem) = Trim(rtxtImJp.Text)
        frmSearchSheet.txImCh(frmSearchSheet.NowItem) = Trim(rtxtImCh.Text)
        frmSearchSheet.txImEn(frmSearchSheet.NowItem) = Trim(rtxtImEn.Text)
        '画像ファイル登録処理
        fn0 = "c:\honyaku\pic\" + Trim(Str(frmSearchSheet.NowItem)) + ".jpg"
        fn1 = Trim(txtImageFileName.Text)
        If Microsoft.VisualBasic.FileIO.FileSystem.FileExists(fn0) Then
            '画像ﾌｧｲﾙ変更処理
            If fn0 <> fn1 Then
                Microsoft.VisualBasic.FileIO.FileSystem.DeleteFile(fn0)
                If fn1 = "" Then
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyFile("c:\honyaku\pic\NowPrinting.jpg", fn0)
                Else
                    Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(fn1, fn0)
                End If
            End If
        ElseIf Microsoft.VisualBasic.FileIO.FileSystem.FileExists(Trim(txtImageFileName.Text)) Then
            Microsoft.VisualBasic.FileIO.FileSystem.CopyFile(fn1, fn0)
        End If
        '新規登録時の各ボタンのロック解除
        btnTuika.Enabled = True
        btnUp.Enabled = True
        btnDown.Enabled = True
        txtImageFileName.Text = fn0
        '新規登録フラグ解除
        frmSearchSheet.NewItemWorkingFlag = False
        '再表示
        PutOutT()
        '登録内容保存
        frmSearchSheet.SaveData()
    End Sub

    Public Sub btnTuika_Click(sender As Object, e As EventArgs) Handles btnTuika.Click
        '新規登録前処理
        '新規登録作業中はこの処理をしない
        If frmSearchSheet.NewItemWorkingFlag = False Then
            '各ボタン操作規制
            btnTuika.Enabled = False
            btnUp.Enabled = False
            btnDown.Enabled = False
            '新規登録フラグを立てる
            frmSearchSheet.NewItemWorkingFlag = True
            '新規登録番号設定
            frmSearchSheet.NowItem = (frmSearchSheet.MaxItem) + 1
            txtRecNo.Text = CStr(frmSearchSheet.NowItem)
            '各登録内容を空白＆デフォルトに設定
            cbxCat.SelectedIndex = 0
            frmSearchSheet.txCh(frmSearchSheet.NowItem) = ""
            frmSearchSheet.txJp(frmSearchSheet.NowItem) = ""
            frmSearchSheet.txCh(frmSearchSheet.NowItem) = ""
            frmSearchSheet.txEn(frmSearchSheet.NowItem) = ""
            frmSearchSheet.txImJp(frmSearchSheet.NowItem) = ""
            frmSearchSheet.txImCh(frmSearchSheet.NowItem) = ""
            frmSearchSheet.txImEn(frmSearchSheet.NowItem) = ""
            frmSearchSheet.ImageFileName = "c:\honyaku\pic\nowprinting.jpg"
            '表示処理
            PutOutT()
        End If
    End Sub

    Private Sub btnSearchSheet_Click(sender As Object, e As EventArgs) Handles btnSearchSheet.Click
        '検索画面へ戻る処理
        '各ボタン規制解除
        btnTuika.Enabled = True
        btnUp.Enabled = True
        btnDown.Enabled = True
        '新規登録フラグ解除
        frmSearchSheet.NewItemWorkingFlag = False
        '各設定をデフォルトに設定
        frmSearchSheet.NowItem = 0
        txtRecNo.Text = CStr(frmSearchSheet.NowItem)
        cbxCat.SelectedIndex = 0
        '再表示
        PutOutT()
        '登録画面を閉じる
        Me.Hide()
        '検索画面を表示する
        frmSearchSheet.Show()
    End Sub

End Class
