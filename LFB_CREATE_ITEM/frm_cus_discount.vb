Imports System.Data.SqlClient

Public Class frm_cus_discount
    Private Sub Frm_cus_discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data(DataGrid_Cus_discount)
    End Sub

    Sub get_data(datagrid)
        Try
            Dim sql As String
            sql = "SELECT  LFB_ITEM$_Customer.[Customer_Code] ,LFB_ITEM$_Customer.[Customer_Codess] ,LFB_ITEM$_Customer.[Customer_Name] FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer]"
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "Customer_Code")
            datagrid.DataSource = ds
            datagrid.DataMember = "Customer_Code"
            datagrid.Columns(0).Width = 150
            datagrid.Columns(1).Width = 465
            datagrid.Columns(2).Width = 465
            'customize(datagrid)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Dim select_1
    Private Sub DataGrid_Cus_discount_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_Cus_discount.CellClick
        Try
            With DataGrid_Cus_discount
                select_1 = DataGrid_Cus_discount.CurrentRow.Cells(0).Value
            End With
            get_data_discount(select_1)
            Me.Cursor = Cursors.WaitCursor
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub get_data_discount(select1)
        Try
            Dim sql As String
            sql = "SELECT * FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount] WHERE [Customer_Code] = '" & select1 & "'"
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "Customer_Code")
            data_cus_discount.DataGrid_Cus_discount.DataSource = ds
            data_cus_discount.DataGrid_Cus_discount.DataMember = "Customer_Code"

            data_cus_discount.DataGrid_Cus_discount.Columns(0).Width = 150
            data_cus_discount.DataGrid_Cus_discount.Columns(1).Width = 150
            data_cus_discount.DataGrid_Cus_discount.Columns(2).Width = 150
            data_cus_discount.DataGrid_Cus_discount.Columns(3).Width = 150
            data_cus_discount.DataGrid_Cus_discount.Columns(4).Width = 50
            data_cus_discount.DataGrid_Cus_discount.Columns(5).Width = 50
            data_cus_discount.DataGrid_Cus_discount.Columns(6).Width = 50
            data_cus_discount.DataGrid_Cus_discount.Columns(7).Width = 50
            data_cus_discount.DataGrid_Cus_discount.Columns(8).Width = 50
            data_cus_discount.DataGrid_Cus_discount.Columns(9).Width = 50
            data_cus_discount.DataGrid_Cus_discount.Columns(10).Width = 50
            data_cus_discount.DataGrid_Cus_discount.Columns(11).Width = 50
            data_cus_discount.DataGrid_Cus_discount.Columns(12).Width = 50
            'customize(datagrid)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged

    End Sub
End Class