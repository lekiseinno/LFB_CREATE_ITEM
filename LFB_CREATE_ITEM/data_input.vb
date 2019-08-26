Public Class data_input

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click

        Me.Cursor = Cursors.WaitCursor

        Dim nowstring = Now.ToString("yyyyMMdd_HHmm")

        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header_0, "D:\create_item\" + nowstring + "_Bom Header_0.xlsx")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header_1, "D:\create_item\" + nowstring + "_Bom Header_1.xlsx")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_line, "D:\create_item\" + nowstring + "_Bom Line.xlsx")
        setup_conf.gen_excel(data_excelfile.DataGrid_Default_dimension, "D:\create_item\" + nowstring + "_Default_dimension.xlsx")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_master, "D:\create_item\" + nowstring + "_Item_master.xlsx")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_unit, "D:\create_item\" + nowstring + "_Item_unit.xlsx")

        setup_conf.gen_txt()

        MsgBox("Create File : Success !")

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub btn_to_excel_Click(sender As Object, e As EventArgs) Handles btn_to_excel.Click
        data_excelfile.TopLevel = False
        data_excelfile.FormBorderStyle = FormBorderStyle.None
        data_excelfile.Visible = False
        frm_master.panel_datagrid.Controls.Add(data_excelfile)
        data_excelfile.Show()
        Me.Hide()
    End Sub



    Private Sub btn_csv_Click(sender As Object, e As EventArgs) Handles btn_csv.Click
        Me.Cursor = Cursors.WaitCursor

        Dim nowstring = Now.ToString("yyyyMMdd_HHmm")

        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header_0, "D:\create_item\" + nowstring + "_Bom Header_0.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header_1, "D:\create_item\" + nowstring + "_Bom Header_1.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_line, "D:\create_item\" + nowstring + "_Bom Line.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Default_dimension, "D:\create_item\" + nowstring + "_Default_dimension.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_master, "D:\create_item\" + nowstring + "_Item_master.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_unit, "D:\create_item\" + nowstring + "_Item_unit.csv")

        setup_conf.gen_txt()


        MsgBox("Create File : Success !")
        Me.Cursor = Cursors.Default
    End Sub

    Private bitmap As Bitmap

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        Dim bm As New Bitmap(Me.DataGrid_input.Width, Me.DataGrid_input.Height)
        DataGrid_input.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGrid_input.Width, Me.DataGrid_input.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click


        PrintDialog1.Document = PrintDocument1
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub




    Private Sub Txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        If txt_search.Text = "" Then
            For i As Integer = 0 To DataGrid_input.RowCount - 1
                DataGrid_input.Rows(i).Visible = True
            Next
        Else
            For i As Integer = 0 To DataGrid_input.RowCount - 1
                If DataGrid_input.Rows(i).Cells(0).Value IsNot Nothing Then
                    For j As Integer = 0 To DataGrid_input.ColumnCount - 1
                        If DataGrid_input.Rows(i).Cells(j).Value IsNot Nothing Then
                            If DataGrid_input.Columns(j) IsNot Nothing Then
                                If DataGrid_input.Rows(i).Cells(j).Value.ToString Like "*" & txt_search.Text & "*" Then
                                    DataGrid_input.Rows(i).Visible = True
                                    'TextBox1.Text &= "DT = [" & i & "][" & j & "] [" & Trim(DataGrid_input.Rows(i).Cells(j).Value.ToString) & "] txt_search = [" & Trim(txt_search.Text) & "] " & vbCrLf
                                    Exit For
                                Else
                                    DataGrid_input.Rows(i).Visible = False
                                End If
                            End If
                        End If
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage_1(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGrid_input.Width, Me.DataGrid_input.Height)
        DataGrid_input.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGrid_input.Width, Me.DataGrid_input.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub DataGrid_input_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_input.CellContentClick

        If e.ColumnIndex = 1 Then
            MsgBox(DataGrid_input.Item(e.ColumnIndex, e.RowIndex).Value.ToString())
        End If
    End Sub

    Private Sub Data_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class