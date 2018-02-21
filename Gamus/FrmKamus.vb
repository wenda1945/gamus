Public Class FrmKamus
    Dim dtEN As DataTable = New DataTable
    Dim dtIN As DataTable = New DataTable
    'Variable untuk Form Menu supaya bisa diakses
    Public myCaller As FrmMenu
    Private Sub FrmKamus_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        myCaller.Show()
    End Sub

    Private Sub FrmKamus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pathEN As String = Environment.CurrentDirectory + "\enV2.xml"
        DataSet1.ReadXml(pathEN)
        dtEN = DataSet1.Tables(0)
        Dim autoCompleteEN As AutoCompleteStringCollection = New AutoCompleteStringCollection
        For i = 0 To dtEN.Rows.Count - 1
            autoCompleteEN.Add(dtEN.Rows(i)("English").ToString())
        Next
        tbxInputEn.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbxInputEn.AutoCompleteCustomSource = autoCompleteEN
        tbxInputEn.AutoCompleteMode = AutoCompleteMode.Suggest

        Dim pathIN As String = Environment.CurrentDirectory + "\inV2.xml"
        DataSet1.ReadXml(pathIN)
        dtIN = DataSet1.Tables(0)
        Dim autoCompleteIN As AutoCompleteStringCollection = New AutoCompleteStringCollection
        For i = 0 To dtIN.Rows.Count - 1
            autoCompleteIN.Add(dtIN.Rows(i)("Indonesia").ToString())
        Next
        tbxInputIn.AutoCompleteSource = AutoCompleteSource.CustomSource
        tbxInputIn.AutoCompleteCustomSource = autoCompleteIN
        tbxInputIn.AutoCompleteMode = AutoCompleteMode.Suggest

    End Sub

    Private Sub tbxInputEn_TextChanged(sender As Object, e As EventArgs) Handles tbxInputEn.TextChanged
        Dim r As DataRow
        For Each r In dtEN.Rows
            If tbxInputEn.Text.ToLower = r.Item(0).ToString.ToLower Then
                tbxOutputIn.Text = r.Item(1).ToString
                Exit For
            End If
        Next
    End Sub

    Private Sub tbxInputIn_TextChanged(sender As Object, e As EventArgs) Handles tbxInputIn.TextChanged
        Dim r As DataRow
        For Each r In dtIN.Rows
            If tbxInputIn.Text.ToLower = r.Item(0).ToString.ToLower Then
                tbxOutputEn.Text = r.Item(1).ToString
                Exit For
            End If
        Next
    End Sub
End Class