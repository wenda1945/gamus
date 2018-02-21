Public Class FrmMenu
    Dim objFrmKamus As FrmKamus
    Dim objFrmGame As FrmGame
    Private Sub btnKamus_Click(sender As Object, e As EventArgs) Handles btnKamus.Click
        objFrmKamus = New FrmKamus
        objFrmKamus.myCaller = Me
        objFrmKamus.Show()
        Me.Hide()

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Dim result As Integer = MessageBox.Show("Yakin ingin Keluar?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click
        objFrmGame = New FrmGame
        objFrmGame.myCaller = Me
        objFrmGame.Show()
        Me.Hide()
    End Sub
End Class
