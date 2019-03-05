Imports System.Data.SqlClient
Public Class data_PL
    Private Sub data_PL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data(DataGrid_PL)
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

            Dim sql As String
            sql = "SELECT * FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_PL]"
            sql &= "WHERE a Like '%" & txt_search.Text & "%' "
            sql &= "OR b Like '%" & txt_search.Text & "%' "
            sql &= "OR c Like '%" & txt_search.Text & "%' "
            sql &= "OR d Like '%" & txt_search.Text & "%' "
            sql &= "OR e Like '%" & txt_search.Text & "%' "
            sql &= "OR f Like '%" & txt_search.Text & "%' "
            sql &= "OR g Like '%" & txt_search.Text & "%' "
            sql &= "OR h Like '%" & txt_search.Text & "%' "
            sql &= "OR i Like '%" & txt_search.Text & "%' "
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "a")
            DataGrid_PL.DataSource = ds
            DataGrid_PL.DataMember = "a"





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub DataGrid_PL_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGrid_PL.CellClick
        'MsgBox()
    End Sub
End Class