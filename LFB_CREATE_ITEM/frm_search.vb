Imports System.Data.SqlClient

Public Class frm_search
    Private Sub frm_search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data(data_search_cus)
        customize(data_search_cus)
    End Sub

    Sub get_data(datagrid)
        Try
            Dim sql As String
            sql = "
                    SELECT      LFB_ITEM$_Customer.[Customer_Code],
                                LFB_ITEM$_Customer.[Customer_Name]
                    FROM        [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer]
                    WHERE       (
                                [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer].[Customer_Code]  LIKE    '%" & txt_search.Text & "%'
                                OR
                                [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer].[Customer_Name]  LIKE    '%" & txt_search.Text & "%'
                                )
                    "
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "Customer_Code")
            datagrid.DataSource = ds
            datagrid.DataMember = "Customer_Code"
            datagrid.Columns(0).Width = 90
            datagrid.Columns(1).Width = 374
            'customize(datagrid)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Sub customize(datagrid)
        For i = 0 To datagrid.Rows.Count - 1
            Dim r As DataGridViewRow = datagrid.Rows(i)
            r.Height = 35
        Next
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        get_data(data_search_cus)
        customize(data_search_cus)
    End Sub


    Private Sub data_search_cus_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles data_search_cus.CellContentDoubleClick

        Dim select_1
        Dim select_2
        With data_search_cus
            select_1 = data_search_cus.CurrentRow.Cells(0).Value
            select_2 = data_search_cus.CurrentRow.Cells(1).Value
        End With


        frm_input.lb_cuscode.Text = select_1
        frm_input.txt_customers.Text = select_2
        'txt_ID.Text = select_1
        'txt_name_cus.Text = select_2


        'MsgBox(select_1)
        'MsgBox(select_2)
        Me.Close()
    End Sub


End Class