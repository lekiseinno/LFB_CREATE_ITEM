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
End Class