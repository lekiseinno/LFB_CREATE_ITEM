Public Class data_item

    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click
        Dim nowstring = Now.ToString("yyyyMMdd_HHmm")

        setup_conf.gen_excel(DataGrid_item, "D:\create_item\" + nowstring + "_item.xlsx")



        MsgBox("Create File : Success !")
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Data_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

