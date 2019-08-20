Public Class frm_print
    Private Sub Frm_print_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PrintDialog1.Document = PrintDocument1 'PrintDialog associate with PrintDocument.

        PrintPreviewDialog1.Document = PrintDocument1 'PrintPreviewDialog associate with PrintDocument.
        PrintPreviewDialog1.ShowDialog() 'open the print preview

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
            Me.Close()
        End If

    End Sub


    'open the print preview on PrintPreview Button click


End Class