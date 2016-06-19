Public Class frmCat

    Public Sub frmCat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To frmSearchSheet.MaxCat
            cbxCat.Items.Add(i & ":" & frmSearchSheet.txCtItem(i))
        Next i
        cbxCat.SelectedIndex = 0
        btnCancel.Enabled = False
    End Sub

    Private Sub btnSetNewCat_Click(sender As Object, e As EventArgs) Handles btnSetNewCat.Click
        If Trim(txtNewCat.Text) = "" Then Exit Sub
        frmSearchSheet.MaxCat += 1
        frmSearchSheet.txCtItem(frmSearchSheet.MaxCat) = Trim(txtNewCat.Text)
        cbxCat.Items.Add(frmSearchSheet.MaxCat & ":" & frmSearchSheet.txCtItem(frmSearchSheet.MaxCat))
        txtNewCat.Text = ""
        cbxCat.SelectedIndex = frmSearchSheet.MaxCat
        txtNewCat.Enabled = False
        btnSetNewCat.Enabled = False
        btnCancel.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cbxCat.Items.Remove(frmSearchSheet.MaxCat & ":" & frmSearchSheet.txCtItem(frmSearchSheet.MaxCat))
        frmSearchSheet.MaxCat -= 1
        txtNewCat.Enabled = True
        btnSetNewCat.Enabled = True
        btnCancel.Enabled = False
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        Dim i As Integer = 0
        Dim n As Integer = FreeFile()
        FileOpen(n, "c:\honyaku\CatList.txt", OpenMode.Output)
        For i = 0 To frmSearchSheet.MaxCat
            Print(n, Str(i) + "," + frmSearchSheet.txCtItem(i) + vbCrLf)
        Next i
        FileClose(n)
        honyaku.cbxCat.Items.Clear()
        frmSearchSheet.LoadCategory()
        Me.Hide()
    End Sub
End Class