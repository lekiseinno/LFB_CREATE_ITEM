Imports System.Data.SqlClient

Public Class frm_listdata
    Private Sub Frm_listdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data(DataGridView1)
    End Sub

    Sub get_data(datagrid)
        Try
            Dim sql As String
            sql = "SELECT [Document_No],[Customre_Code],[Date] FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Document_head]"
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

    Dim select_1
    Dim select_2
    Dim select_3

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            With DataGridView1
                select_1 = DataGridView1.CurrentRow.Cells(0).Value
            End With


            Dim sql As String

            sql = "SELECT [Document_No]
      ,[No_]
      ,[Type]
      ,[PO]
      ,[width]
      ,[long]
      ,[work_inch]
      ,[cut]
      ,[cut_small]
      ,[F1]
      ,[F2]
      ,[F3]
      ,[F4]
      ,[F5]
      ,[F6]
      ,[F7]
      ,[F8]
      ,[Checkeds]
      ,[Trim]
      ,[Checked]
      ,[Paper Combination]
      ,[Lon]
      ,[PL]
      ,[special PL]
      ,[Net PL]
      ,[Net Unit Price]
      ,[Meth find discount]
      ,[Discount money]
      ,[price unit]
      ,[remark]
      ,[datecreate]
      ,[lastupdate] "
            sql &= "FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Document_line] "
            sql &= "WHERE [LFB_ITEM$].[dbo].[LFB_ITEM$_Document_line].[Document_No] = '" & select_1 & "' "
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "Type_ID")
            DataGridView2.DataSource = ds
            DataGridView2.DataMember = "Type_ID"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class