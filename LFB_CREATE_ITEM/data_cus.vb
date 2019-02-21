Imports System.Data.SqlClient

Public Class data_cus
    Private Sub data_cus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data(DataGrid_Cus)
        ' customize(DataGrid_Cus)
    End Sub

    Sub get_data(datagrid)
        Try
            Dim sql As String
            sql = "
                    SELECT   LFB_ITEM$_Customer.[Customer_Code] ,
                             LFB_ITEM$_Customer.[Customer_Codess] ,
                             LFB_ITEM$_Customer.[Customer_Name]
                    FROM     LFB_ITEM$_Customer
                    "
            Dim query As New SqlCommand(sql, setup_conf.connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "Customer_Code")
            datagrid.DataSource = ds
            datagrid.DataMember = "Customer_Code"
            datagrid.Columns(0).Width = 150
            datagrid.Columns(1).Width = 465
            datagrid.Columns(2).Width = 465
            customize(datagrid)
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
End Class