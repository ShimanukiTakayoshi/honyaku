Public Class ReadingInfo

    Private Sub ReadingInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtReadCnt.Text = Str(frmSearchSheet.ReadCounter)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtReadCnt.Text = Str(frmSearchSheet.ReadCounter)

    End Sub
End Class