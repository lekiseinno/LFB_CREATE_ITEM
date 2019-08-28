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


            CrytalReport()

            '      Dim sql As String

            '      sql = "SELECT [Document_No]
            ',[No_]
            ',[Type]
            ',[PO]
            ',[width]
            ',[long]
            ',[work_inch]
            ',[cut]
            ',[cut_small]
            ',[F1]
            ',[F2]
            ',[F3]
            ',[F4]
            ',[F5]
            ',[F6]
            ',[F7]
            ',[F8]
            ',[Checkeds]
            ',[Trim]
            ',[Checked]
            ',[Paper Combination]
            ',[Lon]
            ',[PL]
            ',[special PL]
            ',[Net PL]
            ',[Net Unit Price]
            ',[Meth find discount]
            ',[Discount money]
            ',[price unit]
            ',[remark]
            ',[datecreate]
            ',[lastupdate] "
            '      sql &= "FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Document_line] "
            '      sql &= "WHERE [LFB_ITEM$].[dbo].[LFB_ITEM$_Document_line].[Document_No] = '" & select_1 & "' "
            '      Dim query As New SqlCommand(sql, connection)
            '      Dim dataadapter As New SqlDataAdapter(query)
            '      Dim ds As New DataSet()
            '      dataadapter.Fill(ds, "Type_ID")
            '      DataGridView2.DataSource = ds
            '      DataGridView2.DataMember = "Type_ID"

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
        'rpt.Load(directory & "\\myCrystalReport.rpt")
        'rpt.Load("E:\PSC_Project\PSC_JOB\PSC_JOB\" & istrreport)
        rpt.Load(directory & "\\" & istrreport)


        ''Dim con As New OdbcConnection("DSN=sample;UID=userid;PWD=password;")
        ''con.Open()

        '  rpt.DataSourceConnections.Item(connStr, "psc_job")
        ' rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, path)

        With crConnectionInfo
            .ServerName = "192.168.110.125"
            .UserID = "innovation"
            .Password = "Inno20i9"
        End With

        'This code works for both user tables and stored 
        'procedures. Set the CrTables to the Tables collection 
        'of the report 

        CrTables = rpt.Database.Tables

        'Loop through each table in the report and apply the 
        'LogonInfo information 

        For Each CrTable In CrTables

            crtableLogoninfo = CrTable.LogOnInfo
            crtableLogoninfo.ConnectionInfo = crConnectionInfo
            CrTable.ApplyLogOnInfo(crtableLogoninfo)

            'crTable.Location = crConnectionInfo.DatabaseName & ".dbo."
            'CrTable.Location.Substring(CrTable.Location.LastIndexOf(".") + 1)

            'crTable.Location = crConnectionInfo.DatabaseName & ".dbo." &crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1)
        Next

        'Set the viewer to the report object to be previewed. 



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





        'crParameterValues.Clear()
        'crParameterValues.Add(crParameterDiscreteValue)
        'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)



        'rpt.SetDataSource("psc_job")
        Me.CrystalReportViewer1.Refresh()
        Me.CrystalReportViewer1.ReportSource = rpt


    End Sub

End Class