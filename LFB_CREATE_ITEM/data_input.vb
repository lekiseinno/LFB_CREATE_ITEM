Public Class data_input

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click

        Me.Cursor = Cursors.WaitCursor

        Dim nowstring = Now.ToString("yyyyMMdd_HHmm")

        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header, "D:\create_item\" + nowstring + "_Bom Header.xlsx")
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

        setup_conf.gen_excel(data_excelfile.DataGrid_bom_header, "D:\create_item\" + nowstring + "_Bom Header.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_bom_line, "D:\create_item\" + nowstring + "_Bom Line.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Default_dimension, "D:\create_item\" + nowstring + "_Default_dimension.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_master, "D:\create_item\" + nowstring + "_Item_master.csv")
        setup_conf.gen_excel(data_excelfile.DataGrid_Item_unit, "D:\create_item\" + nowstring + "_Item_unit.csv")

        setup_conf.gen_txt()


        MsgBox("Create File : Success !")
        Me.Cursor = Cursors.Default
    End Sub

    Private bitmap As Bitmap

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGrid_input.Width, Me.DataGrid_input.Height)
        DataGrid_input.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGrid_input.Width, Me.DataGrid_input.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintDocument1.DefaultPageSettings.Landscape = True
        PrintDocument1.Print()
    End Sub
End Class