Imports System.Data.SqlClient

Public Class data_excelfile
    Private Sub data_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'get_data(DataGrid_input)


        Me.Tab_main.BackColor = Color.Blue


    End Sub
    Sub get_data(datagrid)
        Try
            Dim sql As String
            sql = "SELECT * FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_PL]"
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "a")
            datagrid.DataSource = ds
            datagrid.DataMember = "a"
            'datagrid.Columns(0).Width = 150
            'datagrid.Columns(1).Width = 465
            'datagrid.Columns(2).Width = 465
            'customize(datagrid)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Sub customize(datagrid)
        For i = 0 To datagrid.Rows.Count - 1
            Dim r As DataGridViewRow = datagrid.Rows(i)
            r.Height = 500
        Next
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Try






        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DataGrid_PL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_bom_header.CellClick
        'MsgBox()
    End Sub



    Private Sub btn_excel_Click(sender As Object, e As EventArgs) Handles btn_excel.Click

        Dim nowstring = Now.ToString("yyyyMMdd_HHmm")

        setup_conf.gen_excel(DataGrid_bom_header, "D:\create_item\" + nowstring + "_Bom Header.xlsx")
        setup_conf.gen_excel(DataGrid_bom_line, "D:\create_item\" + nowstring + "_Bom Line.xlsx")
        setup_conf.gen_excel(DataGrid_Default_dimension, "D:\create_item\" + nowstring + "_Default_dimension.xlsx")
        setup_conf.gen_excel(DataGrid_Item_master, "D:\create_item\" + nowstring + "_Item_master.xlsx")
        setup_conf.gen_excel(DataGrid_Item_unit, "D:\create_item\" + nowstring + "_Item_unit.xlsx")



        MsgBox("Create File : Success !")
        Me.Cursor = Cursors.Default



    End Sub

End Class