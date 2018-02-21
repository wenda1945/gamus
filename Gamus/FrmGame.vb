Public Class FrmGame

    'Variable untuk Form Menu supaya bisa diakses
    Public myCaller As FrmMenu
    Private Sub FrmGame_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        myCaller.Show()
    End Sub
End Class