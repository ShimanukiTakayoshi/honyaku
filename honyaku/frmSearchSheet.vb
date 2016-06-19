'検索シート処理
Public Class frmSearchSheet
    Public noCt(99999) As Integer                      '登録データ・カテゴリー番号
    Public txCtItem(99999) As String                   '登録データ・カテゴリー項目
    Public txJp(99999) As String                       '登録データ・日本語
    Public txCh(99999) As String                       '登録データ・中国語
    Public txEn(99999) As String                       '登録データ・英語
    Public txImJp(99999) As String                     '登録データ・日本語意味
    Public txImCh(99999) As String                     '登録データ・中国語意味
    Public txImEn(99999) As String                     '登録データ・英語意味
    Public MaxItem As Integer = 0                   '最大登録番号
    Public NowItem As Integer = 0                   '現在選択登録番号
    Public MaxCat As Integer = 0                    '最大登録カテゴリー番号
    Public ImageFileName As String                  '画像ファイル名
    Public NewItemWorkingFlag As Boolean = False    '新規登録作業中フラグ

    Dim noReg(1, 99999) As Integer                     '検索用テンポラリー変数・登録番号
    Dim noCtS(1, 99999) As Integer                     '検索用テンポラリー変数・カテゴリー
    Dim txJpS(1, 99999) As String                      '検索用テンポラリー変数・日本語
    Dim txChS(1, 99999) As String                      '検索用テンポラリー変数・中国語
    Dim txEnS(1, 99999) As String                      '検索用テンポラリー変数・英語
    Dim txImJpS(1, 99999) As String                    '検索用テンポラリー変数・日本語意味
    Dim txImChS(1, 99999) As String                    '検索用テンポラリー変数・中国語意味
    Dim txImEnS(1, 99999) As String                    '検索用テンポラリー変数・英語意味
    Dim ScMax As Integer = 0                        '検索結果項目数
    Public ReadCounter As Integer
    Public TestImage As String = "c:\honyaku\pic\NowPrinting.jpg"

    Private Sub frmSearchSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '検索画面表示処理＆初期設定
        LoadCategory()              'カテゴリー設定ファイル読み込み
        LoadData()                  '辞書データ読み込み
        PutOut()                    '選択データ表示
        SaveData()                  '辞書データ保存
        'カテゴリーコンボボックス設定
        cbxSrcCat.Items.Add("ALL")
        For i As Integer = 0 To MaxCat
            cbxSrcCat.Items.Add(i & ":" & txCtItem(i))
        Next i
        cbxSrcCat.SelectedIndex = 0
        '一覧表初期設定
        ListUpInit()
        '一覧表表示
        SearchLiblary()
    End Sub

    Private Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnReg.Click
        '登録シート表示
        NowItem = 0
        Me.Hide()
        honyaku.Show()
    End Sub

    Private Sub ListUpInit()
        '検索結果一覧表初期設定
        dgvSrcList.Font = New Font(dgvSrcList.Font.Name, 10)
        dgvSrcList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvSrcList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvSrcList.Columns.Add("0", "No.")
        dgvSrcList.Columns.Add("1", "ｶﾃｺﾞﾘ")
        dgvSrcList.Columns.Add("2", "日本語")
        dgvSrcList.Columns.Add("3", "中国語")
        dgvSrcList.Columns.Add("4", "意味")
        'dgvSrcList.Columns.Add("5", "日本語意味")
        'dgvSrcList.Columns.Add("6", "中国語意味")
        'dgvSrcList.Columns.Add("7", "英語意味")
        'dgvSrcList.Columns.Add("8", "画像")
        dgvSrcList.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvSrcList.Columns(0).Width = 50
        dgvSrcList.Columns(1).Width = 50
        dgvSrcList.Columns(2).Width = 120
        dgvSrcList.Columns(3).Width = 120
        dgvSrcList.Columns(4).Width = 250
        'dgvSrcList.Columns(5).Width = 150
        'dgvSrcList.Columns(6).Width = 150
        'dgvSrcList.Columns(7).Width = 150
        'dgvSrcList.Columns(8).Width = 80
        dgvSrcList.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvSrcList.RowHeadersVisible = False
    End Sub

    Private Sub ListUp()
        '検索結果表示
        'データグリッドコントロール設定
        With dgvSrcList
            '列数が>0なら表示されていると判断し、一旦消去(表示速度には影響なし)
            If .Rows.Count > 0 Then
                .Columns.Clear()                          'コレクションを空にします(行・列削除)
                .DataSource = Nothing                     'DataSource に既定値を設定
                .DefaultCellStyle = Nothing               'セルスタイルを初期値に設定
                .RowHeadersDefaultCellStyle = Nothing     '行ヘッダーを初期値に設定
                .RowHeadersVisible = True                 '行ヘッダーを表示
                'フォントの高さ＋9 (フォントサイズ 9 の場合、12+9= 21 となる
                .RowTemplate.Height = 21                  'デフォルトの行の高さを設定(表示後では有効にならない)
                .ColumnHeadersDefaultCellStyle = Nothing  '列ヘッダーを初期値に設定
                .ColumnHeadersVisible = True              '列ヘッダーを表示
                .ColumnHeadersHeight = 23                 '列ヘッダーの高さを既定値に設定
                .TopLeftHeaderCell = Nothing              '左端上端のヘッダーを初期値に設定
                '奇数行に適用される既定のセルスタイルを初期値に設定   
                .AlternatingRowsDefaultCellStyle = Nothing
                'セルの境界線スタイルを初期値(一重線の境界線)に設定
                .AdvancedCellBorderStyle.All = DataGridViewAdvancedCellBorderStyle.Single
                .GridColor = SystemColors.ControlDark     'セルを区切るグリッド線の色を初期値に設定
                .Refresh()                                '再描画
            End If
        End With
        '一覧表初期設定
        ListUpInit()
        '検索結果表示
        For i As Integer = 0 To ScMax
            dgvSrcList.Rows.Add(Str(noReg(0, i)))
            dgvSrcList.Item(1, i).Value = Str(noCtS(0, i))
            dgvSrcList.Item(2, i).Value = txJpS(0, i)
            dgvSrcList.Item(3, i).Value = txChS(0, i)
            'dgvSrcList.Item(4, i).Value = txEnS(0, i)
            dgvSrcList.Item(4, i).Value = txImJpS(0, i)
            'dgvSrcList.Item(6, i).Value = txImChS(0, i)
            'dgvSrcList.Item(7, i).Value = txImEnS(0, i)
            'dgvSrcList.Item(8, i).Value = Image.FromFile(TestImage)
        Next
    End Sub

    Private Sub btnSrcStart_Click(sender As Object, e As EventArgs) Handles btnSrcStart.Click
        '辞書検索
        SearchLiblary()
    End Sub

    Private Sub SearchLiblary()
        '辞書検索
        'カテゴリー検索
        Dim Sc As Integer = 0
        If cbxSrcCat.SelectedIndex <> 0 Then
            'カテゴリー選択"ALL"以外の処理
            For i As Integer = 0 To MaxItem
                '検索結果をテンポラリー変数へ代入
                If cbxSrcCat.SelectedIndex = noCt(i) + 1 Then
                    noReg(0, Sc) = i
                    noCtS(0, Sc) = noCt(i)
                    txJpS(0, Sc) = txJp(i)
                    txChS(0, Sc) = txCh(i)
                    txEnS(0, Sc) = txEn(i)
                    txImJpS(0, Sc) = txImJp(i)
                    txImChS(0, Sc) = txImCh(i)
                    txImEnS(0, Sc) = txImEn(i)
                    Sc += 1
                End If
            Next
            ScMax = Sc - 1
        Else
            'カテゴリー選択"ALL"の処理(全登録項目を検索結果テンポラリー変数へ代入)
            For i As Integer = 0 To MaxItem
                noReg(0, i) = i
                noCtS(0, i) = noCt(i)
                txJpS(0, i) = txJp(i)
                txChS(0, i) = txCh(i)
                txEnS(0, i) = txEn(i)
                txImJpS(0, i) = txImJp(i)
                txImChS(0, i) = txImCh(i)
                txImEnS(0, i) = txImEn(i)
            Next
            ScMax = MaxItem
        End If
        'キーワード検索開始
        If Trim(txtKeyWord.Text) <> "" Then
            Dim SearchFlug(99999) As Boolean       'キーワード検索結果判定フラグ
            Dim noRegTmp(1, 99999) As Integer      'キーワード検索結果テンポラリー変数・登録番号
            Dim noCtSTmp(1, 99999) As Integer      'キーワード検索結果テンポラリー変数・カテゴリー
            Dim txJpSTmp(1, 99999) As String       'キーワード検索結果テンポラリー変数・日本語
            Dim txChSTmp(1, 99999) As String       'キーワード検索結果テンポラリー変数・中国語
            Dim txEnSTmp(1, 99999) As String       'キーワード検索結果テンポラリー変数・英語
            Dim txImJpSTmp(1, 99999) As String     'キーワード検索結果テンポラリー変数・日本語意味
            Dim txImChSTmp(1, 99999) As String     'キーワード検索結果テンポラリー変数・中国語意味
            Dim txImEnSTmp(1, 99999) As String     'キーワード検索結果テンポラリー変数・英語意味
            Dim ScTmp As Integer = 0            'キーワード検索結果テンポラリー変数・該当項目数
            Dim KeyWord As String = Trim(txtKeyWord.Text)   '検索キーワード
            'キーワードチェック
            For i As Integer = 0 To ScMax
                If SearchFlug(i) = False Then SearchFlug(i) = ChkKeyWord(txJpS(0, i), KeyWord)
                If SearchFlug(i) = False Then SearchFlug(i) = ChkKeyWord(txChS(0, i), KeyWord)
                If SearchFlug(i) = False Then SearchFlug(i) = ChkKeyWord(txEnS(0, i), KeyWord)
                If SearchFlug(i) = False Then SearchFlug(i) = ChkKeyWord(txImJpS(0, i), KeyWord)
                If SearchFlug(i) = False Then SearchFlug(i) = ChkKeyWord(txImChS(0, i), KeyWord)
                If SearchFlug(i) = False Then SearchFlug(i) = ChkKeyWord(txImEnS(0, i), KeyWord)
            Next
            'キーワードが含まれる登録アイテムを０～連番でテンポラリーに保存
            For i As Integer = 0 To ScMax
                If SearchFlug(i) = True Then
                    noRegTmp(0, ScTmp) = noReg(0, i)
                    noCtSTmp(0, ScTmp) = noCtS(0, i)
                    txJpSTmp(0, ScTmp) = txJpS(0, i)
                    txChSTmp(0, ScTmp) = txChS(0, i)
                    txEnSTmp(0, ScTmp) = txEnS(0, i)
                    txImJpSTmp(0, ScTmp) = txImJpS(0, i)
                    txImChSTmp(0, ScTmp) = txImChS(0, i)
                    txImEnSTmp(0, ScTmp) = txImEnS(0, i)
                    ScTmp += 1
                End If
            Next
            ScTmp -= 1
            '検索結果を出力変数へ
            For i As Integer = 0 To ScTmp
                noReg(0, i) = noRegTmp(0, i)
                noCtS(0, i) = noCtSTmp(0, i)
                txJpS(0, i) = txJpSTmp(0, i)
                txChS(0, i) = txChSTmp(0, i)
                txEnS(0, i) = txEnSTmp(0, i)
                txImJpS(0, i) = txImJpSTmp(0, i)
                txImChS(0, i) = txImChSTmp(0, i)
                txImEnS(0, i) = txImEnSTmp(0, i)
            Next
            ScMax = ScTmp
        End If
        '検索結果表示
        ListUp()
    End Sub

    Private Sub dgvSrcList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSrcList.CellClick
        '一覧表よりクリックされた項目の内容を表示
        Dim x As Integer = CInt(dgvSrcList.CurrentRow.Cells(0).Value)
        txtRecNo.Text = CStr(x)
        txtCt.Text = CStr(noCt(x))
        txtJapan.Text = txJp(x)
        txtChina.Text = txCh(x)
        txtEnglish.Text = txEn(x)
        rtxtImJp.Text = txImJp(x)
        rtxtImCh.Text = txImCh(x)
        rtxtImEn.Text = txImEn(x)
        If Microsoft.VisualBasic.FileIO.FileSystem.FileExists("c:\honyaku\pic\" + Trim(Str(x)) + ".jpg") Then
            picPhoto.ImageLocation = "c:\honyaku\pic\" + Trim(Str(x)) + ".jpg"
        Else
            picPhoto.ImageLocation = "c:\honyaku\pic\NowPrinting.jpg"
        End If
    End Sub

    Public Function ChkKeyWord(Document As String, KeyWord As String) As Boolean
        'キーワードが含まれるか確認
        Dim s1 As String = CngZenkaku(CngOhmoji(Trim(Document)))
        Dim s2 As String = CngZenkaku(CngOhmoji(Trim(KeyWord)))
        'Dim s1 As String = Trim(Document)
        'Dim s2 As String = Trim(KeyWord)
        ChkKeyWord = False
        If Len(s1) < Len(s2) Then Exit Function
        For i As Integer = 1 To Len(s1) - Len(s2)
            If Mid(s1, i, Len(s2)) = s2 Then ChkKeyWord = True
        Next
    End Function

    Public Function CngOhmoji(x As String) As String
        '文字列を大文字に変換する
        CngOhmoji = StrConv(x, Microsoft.VisualBasic.VbStrConv.Uppercase, &H411)
    End Function

    Public Function CngZenkaku(x As String) As String
        '半角を全角に変換する
        CngZenkaku = StrConv(x, Microsoft.VisualBasic.VbStrConv.Wide, &H411)
    End Function

    Public Sub LoadCategory()
        'カテゴリーファイル読み込み
        Dim CtNo As Integer
        Dim CtNm As String = ""
        Dim n As Integer = FreeFile()
        FileOpen(n, "c:\honyaku\CatList.txt", OpenMode.Input)
        Do While Not EOF(n)
            Input(n, CtNo)
            Input(n, CtNm)
            honyaku.cbxCat.Items.Add(CtNo & ":" & CtNm)
            txCtItem(CtNo) = CtNm
        Loop
        MaxCat = CtNo
        FileClose(n)
    End Sub

    Public Sub LoadData()
        Dim Reader As New IO.StreamReader("c:\honyaku\HonyakuData.txt", System.Text.Encoding.GetEncoding("Unicode"))
        Dim Items() As String                'CSVの各項目を表す配列
        Dim Line As String = Reader.ReadLine 'CSVの一行
        Dim i As Integer = 0
        ReadingInfo.Show()
        Do Until IsNothing(Line)
            Line = Line.Replace("""", "")   '["] を省く
            Line = Line.Replace(" ", "")    '半角スペースを省く
            Line = Line.Replace("　", "")   '全角スペースを省く
            Line = Line.Replace("   ", "")  'TABを省く
            Line = Line.Replace(Chr(9), "") 'TABを省く
            Items = Line.Split(CChar(","))  '一行を, (カンマ)で区切って項目ごとに分解
            noCt(i) = CInt(Val(Items(0)))
            txJp(i) = Trim(Items(1))
            txCh(i) = Trim(Items(2))
            'txEn(i) = Trim(Items(3))
            txImJp(i) = Trim(Items(3))
            txImCh(i) = Trim(Items(4))
            'txImEn(i) = Trim(Items(6))
            Line = Reader.ReadLine                    '次の行を読み込む。
            i += 1
            ReadCounter = i
        Loop
        MaxItem = i - 1
        Reader.Close()
        'ReadingInfo.Hide()
    End Sub

    Public Sub SaveData()
        Dim Writer As New IO.StreamWriter("c:\honyaku\HonyakuDataABC.txt", False, System.Text.Encoding.Unicode)
        For i As Integer = 0 To MaxItem
            Writer.WriteLine(Str(noCt(i)) + "," + txJp(i) + "," + txCh(i) + "," + txEn(i) + "," + txImJp(i) + "," + txImCh(i) + "," + txImEn(i))
        Next i
        Writer.Close()
    End Sub

    Public Sub PutOut()
        '選択項目表示
        txtRecNo.Text = CStr(NowItem)
        honyaku.cbxCat.SelectedIndex = noCt(NowItem)
        txtJapan.Text = txJp(NowItem)
        txtChina.Text = txCh(NowItem)
        txtEnglish.Text = txEn(NowItem)
        rtxtImJp.Text = txImJp(NowItem)
        rtxtImCh.Text = txImCh(NowItem)
        rtxtImEn.Text = txImEn(NowItem)
        If Microsoft.VisualBasic.FileIO.FileSystem.FileExists("c:\honyaku\pic\" + Trim(Str(NowItem)) + ".jpg") = False Then
            picPhoto.ImageLocation = "c:\honyaku\pic\NowPrinting.jpg"

        ElseIf NewItemWorkingFlag Then
            picPhoto.ImageLocation = ImageFileName
        Else
            picPhoto.ImageLocation = "c:\honyaku\pic\" + Trim(Str(NowItem)) + ".jpg"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '文字列を大文字に変換する
        TextBox2.Text = StrConv(TextBox1.Text, Microsoft.VisualBasic.VbStrConv.Uppercase, &H411)
        '全角を半角に変換する
        TextBox3.Text = StrConv(TextBox2.Text, Microsoft.VisualBasic.VbStrConv.Wide, &H411)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox4.Text = Mid(txtJapan.Text, 1, 1)
        TextBox5.Text = Mid(txtJapan.Text, 2, 1)
        TextBox6.Text = CStr(Asc(Mid(txtJapan.Text, 1, 1)))
        TextBox7.Text = CStr(Asc(Mid(txtJapan.Text, 2, 1)))

    End Sub
End Class