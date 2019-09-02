Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frm_listdata
    Private Sub Frm_listdata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_data(DataGridView1)
    End Sub

    Sub get_data(datagrid)
        Try
            Dim sql As String
            sql = "SELECT TOP 100 [Document_No],[Customre_Code],[Date] FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Document_head] ORDER BY Date DESC"
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "a")
            datagrid.DataSource = ds
            datagrid.DataMember = "a"

            datagrid.Columns.Item(0).Width = 100
            datagrid.Columns.Item(1).Width = 100
            datagrid.Columns.Item(2).Width = 80
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Sub get_data_filter(datagrid, filter)
        Try
            Dim sql As String
            sql = "SELECT TOP 10 [Document_No],[Customre_Code],[Date] FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Document_head] "
            sql &= "WHERE   (
                                [Document_No] LIKE '%" & filter & "%'   
                                OR
                                [Customre_Code] LIKE '%" & filter & "%'
                            )"
            sql &= "ORDER BY Date DESC"
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim ds As New DataSet()
            dataadapter.Fill(ds, "a")
            datagrid.DataSource = ds
            datagrid.DataMember = "a"


            datagrid.Columns.Item(0).Width = 100
            datagrid.Columns.Item(1).Width = 100
            datagrid.Columns.Item(2).Width = 80
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Dim select_1

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            With DataGridView1
                select_1 = DataGridView1.CurrentRow.Cells(0).Value
            End With
            Me.Cursor = Cursors.WaitCursor
            CrytalReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            With DataGridView1
                select_1 = DataGridView1.CurrentRow.Cells(0).Value
            End With
            Me.Cursor = Cursors.WaitCursor
            CrytalReport()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub CrytalReport()

        Dim crtableLogoninfos As New TableLogOnInfos()
        Dim crtableLogoninfo As New TableLogOnInfo()
        Dim crConnectionInfo As New ConnectionInfo()

        Dim CrTables As CrystalDecisions.CrystalReports.Engine.Tables
        Dim CrTable As CrystalDecisions.CrystalReports.Engine.Table

        Dim istrreport As String = ""


        istrreport = "lisdata.rpt"

        Dim rpt As New ReportDocument()
        Dim directory As String = My.Application.Info.DirectoryPath
        rpt.Load(directory & "\\" & istrreport)


        With crConnectionInfo
            .ServerName = "192.168.110.125"
            .UserID = "innovation"
            .Password = "Inno20i9"
        End With

        CrTables = rpt.Database.Tables


        For Each CrTable In CrTables

            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)

        Next




        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue



        If select_1 <> "" Then

            crParameterDiscreteValue.Value = select_1
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields()
            crParameterFieldDefinition = crParameterFieldDefinitions.Item("idocnumber")
            crParameterValues = crParameterFieldDefinition.CurrentValues

            crParameterValues.Clear()
            crParameterValues.Add(crParameterDiscreteValue)
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

        End If

        Me.CrystalReportViewer1.Refresh()
        Me.CrystalReportViewer1.ReportSource = rpt

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Txt_search_doc_TextChanged(sender As Object, e As EventArgs) Handles txt_search_doc.TextChanged
        If txt_search_doc.Text <> "" Then
            get_data_filter(DataGridView1, txt_search_doc.Text)
        Else
            get_data(DataGridView1)
        End If
    End Sub


End Class