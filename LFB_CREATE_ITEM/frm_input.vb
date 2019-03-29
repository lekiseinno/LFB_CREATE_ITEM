Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class frm_input

    Dim paper_4 As String = ""
    Dim paper_3 As String = ""
    Dim paper_2 As String = ""
    Dim paper_1 As String = ""

    Dim wid As String = ""
    Dim lonng As String = ""

    Dim cut_total

    Dim F1 As Integer
    Dim F2 As Integer
    Dim F3 As Integer
    Dim F4 As Integer
    Dim F5 As Integer
    Dim F6 As Integer
    Dim F7 As Integer
    Dim F8 As Integer
    Dim find_discount As Integer
    Dim BA As Double
    Dim unit_height As Double

    Dim sql5 As String
    Dim sql4 As String
    Dim sql3 As String
    Dim sql2 As String
    Dim sql1 As String
    Dim desc_bom_Line5 As String
    Dim desc_bom_Line4 As String
    Dim desc_bom_Line3 As String
    Dim desc_bom_Line2 As String
    Dim desc_bom_Line1 As String

    Dim FG1 As String
    Dim GRAM As String
    Dim GRADE As String
    Dim wei As Double

    Dim grossweight As Double

    Private Sub frm_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_item_code.Hide()
        txt_desc.Hide()
        txt_search_pl.Hide()
        get_item_customer()
        get_unit()
        txt_duedate.Format = DateTimePickerFormat.Custom
        txt_duedate.CustomFormat = "yyyy-MM-dd"

        txt_paper_1.ReadOnly = True
        txt_paper_2.ReadOnly = True
        txt_paper_3.ReadOnly = True
        txt_paper_4.ReadOnly = True
        txt_paper_5.ReadOnly = True
        txt_sub_desc.Enabled = False

    End Sub
    Sub get_unit()
        If txt_fn_find_inch_mm.Text = "" Then
            txt_customer.Enabled = False
            txt_pono.Enabled = False
            txt_type.Enabled = False
            txt_width.Enabled = False
            txt_workinch.Enabled = False
            txt_cut.Enabled = False
            txt_long.Enabled = False
            txt_cut_small.Enabled = False
        End If
    End Sub


    Sub get_item_customer()
        Try

            Dim sql As String
            sql = "SELECT * FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer]"

            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim dt As New DataTable
            Dim ds As New DataSet

            dataadapter.Fill(ds, "a")

            dt = ds.Tables(0)

            Dim idataView As DataView

            idataView = New DataView(dt)
            idataView.Sort = "Customer_Code ASC"
            dt = idataView.ToTable
            Dim dr As DataRow = dt.NewRow
            dr("Customer_Name") = ""
            dt.Rows.InsertAt(dr, 0)

            With txt_customer
                .DataSource = dt
                .DisplayMember = "Customer_Name"
                .ValueMember = "Customer_Code"
            End With

            dt = Nothing
            ds = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If txt_item_code.Text.Length <> 20 Then
            MsgBox("Please check some field to input data!")
        Else
            add_data_input_print() 'OK
            add_data_bom_header() 'OK
            add_data_bom_line() 'OK
            add_data_defaut_dimension_sheet() 'OK
            add_data_Item_Unit_Of_Messure_Sheet() 'OK
            add_data_codetxt() 'OK
            add_data_item_master() 'OK
        End If

    End Sub





    Sub add_data_bom_header()
        data_excelfile.DataGrid_bom_header.ColumnCount = 4
        data_excelfile.DataGrid_bom_header.Columns(0).Name = "No."
        data_excelfile.DataGrid_bom_header.Columns(1).Name = "Description"
        data_excelfile.DataGrid_bom_header.Columns(2).Name = "Unit of Measure Code"
        data_excelfile.DataGrid_bom_header.Columns(3).Name = "Status"
        Dim row As String()
        row = New String() {txt_item_code.Text, txt_desc.Text, "SHT", "0"}
        data_excelfile.DataGrid_bom_header.Rows.Add(row)
    End Sub
    Sub add_data_bom_line()
        data_excelfile.DataGrid_bom_line.ColumnCount = 20
        data_excelfile.DataGrid_bom_line.Columns(0).Name = "Production BOM No."
        data_excelfile.DataGrid_bom_line.Columns(1).Name = "Line No."
        data_excelfile.DataGrid_bom_line.Columns(2).Name = "Version Code"
        data_excelfile.DataGrid_bom_line.Columns(3).Name = "Type"
        data_excelfile.DataGrid_bom_line.Columns(4).Name = "No."
        data_excelfile.DataGrid_bom_line.Columns(5).Name = "Description"
        data_excelfile.DataGrid_bom_line.Columns(6).Name = "Unit of Measure Code"
        data_excelfile.DataGrid_bom_line.Columns(7).Name = "Quantity"
        data_excelfile.DataGrid_bom_line.Columns(8).Name = "Position"
        data_excelfile.DataGrid_bom_line.Columns(9).Name = "Position 2"
        data_excelfile.DataGrid_bom_line.Columns(10).Name = "Position 3"
        data_excelfile.DataGrid_bom_line.Columns(11).Name = "Production Lead Time"
        data_excelfile.DataGrid_bom_line.Columns(12).Name = "Routing Link Code"
        data_excelfile.DataGrid_bom_line.Columns(13).Name = "Scrap %"
        data_excelfile.DataGrid_bom_line.Columns(14).Name = "Variant Code"
        data_excelfile.DataGrid_bom_line.Columns(15).Name = "Comment"
        data_excelfile.DataGrid_bom_line.Columns(16).Name = "Starting Date"
        data_excelfile.DataGrid_bom_line.Columns(17).Name = "Ending Date"
        data_excelfile.DataGrid_bom_line.Columns(18).Name = "Quantity per"
        data_excelfile.DataGrid_bom_line.Columns(19).Name = "Ratio"

        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        Dim row4 As String()
        Dim row5 As String()
        Dim row6 As String()
        Dim row7 As String()

        Dim Qty5 As Double
        Dim Qty4 As Double
        Dim Qty3 As Double
        Dim Qty2 As Double
        Dim Qty1 As Double

        Dim item_13 As Double = CDbl(Val(wid))
        Dim item_17 As Double = CDbl(Val(lonng))

        'w
        Dim sqm As Double = (item_13 * item_17 / 1000000)
        'x
        Dim sqmx5 As Double
        Dim sqmx4 As Double
        Dim sqmx3 As Double
        Dim sqmx2 As Double
        Dim sqmx1 As Double



        row1 = New String() {txt_item_code.Text, "10000", " ", "item", txt_item_code.Text, "กาวแป้งสูตรsingle ", "KG", " ", " ", " ", " ", " ", "  ", "7", " ", " ", " ", " ", "Qty", " "}
        row2 = New String() {txt_item_code.Text, "20000", " ", "item", txt_item_code.Text, "กาวแผ่น          ", "KG", " ", " ", " ", " ", " ", "  ", "7", " ", " ", " ", " ", "Qty", " "}


        If txt_paper_5.Text <> "" Then
            connection.Close()
            connection.Open()
            sql5 = "
                        SELECT * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]  =    '" + get_m(txt_paper_5.Text) + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                        "
            Dim sqlcmd5 As New SqlCommand(sql5, setup_conf.connection)
            Dim myreader5 As SqlDataReader
            myreader5 = sqlcmd5.ExecuteReader()
            myreader5.Read()
            If myreader5.HasRows Then
                desc_bom_Line5 = myreader5.Item("d").ToString
                sqmx5 = myreader5.Item("e").ToString
            End If
            Qty5 = Math.Round((sqm * sqmx5) / 1000, 5)
        End If

        If txt_paper_4.Text <> "" Then

            connection.Close()
            connection.Open()
            sql4 = "
                    SELECT * 
                    FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                    WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]   =    '" + get_m(txt_paper_4.Text) + "'
                    AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                    "
            Dim sqlcmd4 As New SqlCommand(sql4, setup_conf.connection)
            Dim myreader4 As SqlDataReader
            myreader4 = sqlcmd4.ExecuteReader()
            myreader4.Read()
            If myreader4.HasRows Then
                desc_bom_Line4 = myreader4.Item("d").ToString
                sqmx4 = myreader4.Item("e").ToString
            End If
            Qty4 = Math.Round(((sqm * sqmx4) / 1000) * 1.3, 5)
        End If

        If txt_paper_3.Text <> "" Then
            connection.Close()
            connection.Open()
            sql3 = "
                    SELECT * 
                    FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                    WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]   =    '" + get_m(txt_paper_3.Text) + "'
                    AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                    "
            Dim sqlcmd3 As New SqlCommand(sql3, setup_conf.connection)
            Dim myreader3 As SqlDataReader
            myreader3 = sqlcmd3.ExecuteReader()
            myreader3.Read()
            If myreader3.HasRows Then
                desc_bom_Line3 = myreader3.Item("d").ToString
                sqmx3 = myreader3.Item("e").ToString
            End If
            Qty3 = Math.Round((sqm * sqmx3) / 1000, 5)
        End If

        If txt_paper_2.Text <> "" Then
            connection.Close()
            connection.Open()
            sql2 = "
                    SELECT * 
                    FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                    WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]   =    '" + get_m(txt_paper_2.Text) + "'
                    AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                    "
            Dim sqlcmd2 As New SqlCommand(sql2, setup_conf.connection)
            Dim myreader2 As SqlDataReader
            myreader2 = sqlcmd2.ExecuteReader()
            myreader2.Read()
            If myreader2.HasRows Then
                desc_bom_Line2 = myreader2.Item("d").ToString
                sqmx2 = myreader2.Item("e").ToString
            End If
            Qty2 = Math.Round(((sqm * sqmx2) / 1000) * 1.4, 5)
        End If

        If txt_paper_1.Text <> "" Then
            connection.Close()
            connection.Open()
            sql1 = "
                    SELECT * 
                    FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                    WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]  =   '" + get_m(txt_paper_1.Text) + "'
                    AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                    "
            '  MsgBox(sql1)
            Dim sqlcmd1 As New SqlCommand(sql1, setup_conf.connection)
            Dim myreader1 As SqlDataReader
            myreader1 = sqlcmd1.ExecuteReader()
            myreader1.Read()
            If myreader1.HasRows Then
                desc_bom_Line1 = myreader1.Item("d").ToString
                sqmx1 = myreader1.Item("e").ToString
            End If
            Qty1 = Math.Round((sqm * sqmx1) / 1000, 5)
        End If



        If txt_lon.Text = "A" Or txt_lon.Text = "C" Then
            row3 = New String() {txt_item_code.Text, "30000", " ", "item", txt_item_code.Text, desc_bom_Line5, "KG", " ", " ", " ", " ", " ", "M5", "7", " ", " ", " ", " ", Qty5, " "}
            row6 = New String() {txt_item_code.Text, "40000", " ", "item", txt_item_code.Text, desc_bom_Line2, "KG", " ", " ", " ", " ", " ", "M2", "7", " ", " ", " ", " ", Qty2, " "}
            row7 = New String() {txt_item_code.Text, "50000", " ", "item", txt_item_code.Text, desc_bom_Line1, "KG", " ", " ", " ", " ", " ", "M1", "7", " ", " ", " ", " ", Qty1, " "}

            data_excelfile.DataGrid_bom_line.Rows.Add(row1)
            data_excelfile.DataGrid_bom_line.Rows.Add(row2)
            data_excelfile.DataGrid_bom_line.Rows.Add(row3)
            data_excelfile.DataGrid_bom_line.Rows.Add(row6)
            data_excelfile.DataGrid_bom_line.Rows.Add(row7)
        End If

        If txt_lon.Text = "B" Or txt_lon.Text = "E" Then
            row3 = New String() {txt_item_code.Text, "30000", " ", "item", txt_item_code.Text, desc_bom_Line5, "KG", " ", " ", " ", " ", " ", "M5", "7", " ", " ", " ", " ", Qty5, " "}
            row4 = New String() {txt_item_code.Text, "40000", " ", "item", txt_item_code.Text, desc_bom_Line4, "KG", " ", " ", " ", " ", " ", "M4", "7", " ", " ", " ", " ", Qty4, " "}
            row5 = New String() {txt_item_code.Text, "50000", " ", "item", txt_item_code.Text, desc_bom_Line3, "KG", " ", " ", " ", " ", " ", "M3", "7", " ", " ", " ", " ", Qty3, " "}

            data_excelfile.DataGrid_bom_line.Rows.Add(row1)
            data_excelfile.DataGrid_bom_line.Rows.Add(row2)
            data_excelfile.DataGrid_bom_line.Rows.Add(row3)
            data_excelfile.DataGrid_bom_line.Rows.Add(row4)
            data_excelfile.DataGrid_bom_line.Rows.Add(row5)
        End If

        If txt_lon.Text = "AB" Or txt_lon.Text = "BC" Then
            row3 = New String() {txt_item_code.Text, "30000", " ", "item", txt_item_code.Text, desc_bom_Line5, "KG", " ", " ", " ", " ", " ", "M5", "7", " ", " ", " ", " ", Qty5, " "}
            row4 = New String() {txt_item_code.Text, "40000", " ", "item", txt_item_code.Text, desc_bom_Line4, "KG", " ", " ", " ", " ", " ", "M4", "7", " ", " ", " ", " ", Qty4, " "}
            row5 = New String() {txt_item_code.Text, "50000", " ", "item", txt_item_code.Text, desc_bom_Line3, "KG", " ", " ", " ", " ", " ", "M3", "7", " ", " ", " ", " ", Qty3, " "}
            row6 = New String() {txt_item_code.Text, "60000", " ", "item", txt_item_code.Text, desc_bom_Line2, "KG", " ", " ", " ", " ", " ", "M2", "7", " ", " ", " ", " ", Qty2, " "}
            row7 = New String() {txt_item_code.Text, "70000", " ", "item", txt_item_code.Text, desc_bom_Line1, "KG", " ", " ", " ", " ", " ", "M1", "7", " ", " ", " ", " ", Qty1, " "}

            data_excelfile.DataGrid_bom_line.Rows.Add(row1)
            data_excelfile.DataGrid_bom_line.Rows.Add(row2)
            data_excelfile.DataGrid_bom_line.Rows.Add(row3)
            data_excelfile.DataGrid_bom_line.Rows.Add(row4)
            data_excelfile.DataGrid_bom_line.Rows.Add(row5)
            data_excelfile.DataGrid_bom_line.Rows.Add(row6)
            data_excelfile.DataGrid_bom_line.Rows.Add(row7)
        End If





    End Sub






    Sub add_data_defaut_dimension_sheet()
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        Dim row4 As String()
        Dim row5 As String()
        'data_excelfile.DataGrid_Default_dimension.ColumnCount = 6
        'data_excelfile.DataGrid_Default_dimension.Columns(0).Name = "Table ID"
        'data_excelfile.DataGrid_Default_dimension.Columns(1).Name = "No."
        'data_excelfile.DataGrid_Default_dimension.Columns(2).Name = "Dimension Code"
        'data_excelfile.DataGrid_Default_dimension.Columns(3).Name = "Dimension Value Code"
        'data_excelfile.DataGrid_Default_dimension.Columns(4).Name = "Value Posting"
        'data_excelfile.DataGrid_Default_dimension.Columns(5).Name = "Table Name"

        'row1 = New String() {"27", txt_item_code.Text, "COSTCENTER", "20102", "", ""}
        'row2 = New String() {"27", txt_item_code.Text, "GRADE", ""}
        'row3 = New String() {"27", txt_item_code.Text, "GRAM", ""}
        'row4 = New String() {"27", txt_item_code.Text, "PPAGE", txt_width.Text}
        'row5 = New String() {"27", txt_item_code.Text, "PROFILE", txt_lon.Text}
        'data_excelfile.DataGrid_Default_dimension.Rows.Add(row1)
        'data_excelfile.DataGrid_Default_dimension.Rows.Add(row2)
        'data_excelfile.DataGrid_Default_dimension.Rows.Add(row3)
        'data_excelfile.DataGrid_Default_dimension.Rows.Add(row4)
        'data_excelfile.DataGrid_Default_dimension.Rows.Add(row5)


        data_excelfile.DataGrid_Default_dimension.ColumnCount = 6
        data_excelfile.DataGrid_Default_dimension.Columns(0).Name = "Table ID"
        data_excelfile.DataGrid_Default_dimension.Columns(1).Name = "No."
        data_excelfile.DataGrid_Default_dimension.Columns(2).Name = "Dimension Code"
        data_excelfile.DataGrid_Default_dimension.Columns(3).Name = "Dimension Value Code"
        data_excelfile.DataGrid_Default_dimension.Columns(4).Name = "Value Posting"
        data_excelfile.DataGrid_Default_dimension.Columns(5).Name = "Table Name"

        connection.Close()
        connection.Open()
        sql5 = "
                        SELECT * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]  =   '" + get_m(txt_paper_5.Text) + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                        "
        Dim sqlcmd5 As New SqlCommand(sql5, setup_conf.connection)
        Dim myreader5 As SqlDataReader
        myreader5 = sqlcmd5.ExecuteReader()
        myreader5.Read()
        If myreader5.HasRows Then
            GRAM = myreader5.Item("e").ToString
            GRADE = myreader5.Item("f").ToString
        End If

        row1 = New String() {"27", txt_item_code.Text, "COSTCENTER", "20102", "", ""}
        row2 = New String() {"27", txt_item_code.Text, "GRADE     ", GRADE, "", ""}
        row3 = New String() {"27", txt_item_code.Text, "GRAM      ", GRAM, "", ""}
        row4 = New String() {"27", txt_item_code.Text, "PPAGE     ", txt_width.Text, "", ""}
        row5 = New String() {"27", txt_item_code.Text, "PROFILE   ", txt_lon.Text, "", ""}
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row1)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row2)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row3)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row4)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row5)
    End Sub
    Sub add_data_item_master()


        Dim area = Math.Round((txt_cut_small.Text * txt_long.Text) / 1000000 * 10.765, 5)


        connection.Close()
        connection.Open()
        sql5 = "
                        SELECT * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]  =   '" + get_m(txt_paper_5.Text) + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                        "
        Dim sqlcmd5 As New SqlCommand(sql5, setup_conf.connection)
        Dim myreader5 As SqlDataReader
        myreader5 = sqlcmd5.ExecuteReader()
        myreader5.Read()
        If myreader5.HasRows Then
            grossweight += (myreader5.Item("e").ToString() / 10.765)
        End If
        connection.Close()
        connection.Open()
        sql4 = "
                        SELECT * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]  =   '" + get_m(txt_paper_4.Text) + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                        "
        Dim sqlcmd4 As New SqlCommand(sql4, setup_conf.connection)
        Dim myreader4 As SqlDataReader
        myreader4 = sqlcmd4.ExecuteReader()
        myreader4.Read()
        If myreader4.HasRows Then
            grossweight += (myreader4.Item("e").ToString() / 10.765)
        End If

        connection.Close()
        connection.Open()
        sql3 = "
                        SELECT * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]  =   '" + get_m(txt_paper_3.Text) + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                        "
        Dim sqlcmd3 As New SqlCommand(sql3, setup_conf.connection)
        Dim myreader3 As SqlDataReader
        myreader3 = sqlcmd3.ExecuteReader()
        myreader3.Read()
        If myreader3.HasRows Then
            grossweight += (myreader3.Item("e").ToString() / 10.765)
        End If

        connection.Close()
        connection.Open()
        sql2 = "
                        SELECT * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]  =   '" + get_m(txt_paper_2.Text) + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                        "
        Dim sqlcmd2 As New SqlCommand(sql2, setup_conf.connection)
        Dim myreader2 As SqlDataReader
        myreader2 = sqlcmd2.ExecuteReader()
        myreader2.Read()
        If myreader2.HasRows Then
            grossweight += (myreader2.Item("e").ToString() / 10.765)
        End If

        connection.Close()
        connection.Open()
        sql1 = "
                        SELECT * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[b]  =   '" + get_m(txt_paper_1.Text) + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_FORMULAS_BOM].[h]  =   '" + lonng + "'
                        "
        Dim sqlcmd1 As New SqlCommand(sql1, setup_conf.connection)
        Dim myreader1 As SqlDataReader
        myreader1 = sqlcmd1.ExecuteReader()
        myreader1.Read()
        If myreader1.HasRows Then
            grossweight += (myreader1.Item("e").ToString() / 10.765)
        End If



        If txt_exe.Checked Then
            FG1 = "FG1-EXE"
        Else
            FG1 = "FG1-SHT"
        End If
        data_excelfile.DataGrid_Item_master.ColumnCount = 65
        data_excelfile.DataGrid_Item_master.Columns(0).Name = "No."
        data_excelfile.DataGrid_Item_master.Columns(1).Name = "Description"
        data_excelfile.DataGrid_Item_master.Columns(2).Name = "Base Unit of Measure"
        data_excelfile.DataGrid_Item_master.Columns(3).Name = "Price Unit Conversion"
        data_excelfile.DataGrid_Item_master.Columns(4).Name = "Inventory Posting Group"
        data_excelfile.DataGrid_Item_master.Columns(5).Name = "Costing Method"
        data_excelfile.DataGrid_Item_master.Columns(6).Name = "Unit Cost"
        data_excelfile.DataGrid_Item_master.Columns(7).Name = "Reorder Quantity"
        data_excelfile.DataGrid_Item_master.Columns(8).Name = "Gross Weight"
        data_excelfile.DataGrid_Item_master.Columns(9).Name = "Net Weight"
        data_excelfile.DataGrid_Item_master.Columns(10).Name = "Blocked"
        data_excelfile.DataGrid_Item_master.Columns(11).Name = "VAT Bus. Posting Gr. (Price)"
        data_excelfile.DataGrid_Item_master.Columns(12).Name = "Gen. Prod. Posting Group"
        data_excelfile.DataGrid_Item_master.Columns(13).Name = "VAT Prod. Posting Group"
        data_excelfile.DataGrid_Item_master.Columns(14).Name = "Inventory Value Zero"
        data_excelfile.DataGrid_Item_master.Columns(15).Name = "Minimum Order Quantity"
        data_excelfile.DataGrid_Item_master.Columns(16).Name = "Maximum Order Quantity"
        data_excelfile.DataGrid_Item_master.Columns(17).Name = "Safety Lead Time"
        data_excelfile.DataGrid_Item_master.Columns(18).Name = "Replenishment System"
        data_excelfile.DataGrid_Item_master.Columns(19).Name = "Sales Unit of Measure"
        data_excelfile.DataGrid_Item_master.Columns(20).Name = "Purch. Unit of Measure"
        data_excelfile.DataGrid_Item_master.Columns(21).Name = "Reordering Policy"
        data_excelfile.DataGrid_Item_master.Columns(22).Name = "Include Inventory"
        data_excelfile.DataGrid_Item_master.Columns(23).Name = "Manufacturing Policy"
        data_excelfile.DataGrid_Item_master.Columns(24).Name = "Item Category Code"
        data_excelfile.DataGrid_Item_master.Columns(25).Name = "Product Group Code"
        data_excelfile.DataGrid_Item_master.Columns(26).Name = "Item Tracking Code"
        data_excelfile.DataGrid_Item_master.Columns(27).Name = "Lot Nos."
        data_excelfile.DataGrid_Item_master.Columns(28).Name = "Lonn Code"
        data_excelfile.DataGrid_Item_master.Columns(29).Name = "Grade Code"
        data_excelfile.DataGrid_Item_master.Columns(30).Name = "Gram Code"
        data_excelfile.DataGrid_Item_master.Columns(31).Name = "ผ่า"
        data_excelfile.DataGrid_Item_master.Columns(32).Name = "ความกว้าง(นิ้ว)"
        data_excelfile.DataGrid_Item_master.Columns(33).Name = "ความกว้าง(มม.)"
        data_excelfile.DataGrid_Item_master.Columns(34).Name = "ความยาว(นิ้ว)"
        data_excelfile.DataGrid_Item_master.Columns(35).Name = "ความยาว(มม.)"
        data_excelfile.DataGrid_Item_master.Columns(36).Name = "ระยะทับเส้น (F1) (มม.)"
        data_excelfile.DataGrid_Item_master.Columns(37).Name = "ระยะทับเส้น (F2) (มม.)"
        data_excelfile.DataGrid_Item_master.Columns(38).Name = "ระยะทับเส้น (F3) (มม.)"
        data_excelfile.DataGrid_Item_master.Columns(39).Name = "ระยะทับเส้น (F4) (มม.)"
        data_excelfile.DataGrid_Item_master.Columns(40).Name = "ระยะทับเส้น (F5) (มม.)"
        data_excelfile.DataGrid_Item_master.Columns(41).Name = "ระยะทับเส้น (F6) (มม.)"
        data_excelfile.DataGrid_Item_master.Columns(42).Name = "ระยะทับเส้น (F7) (มม.)"
        data_excelfile.DataGrid_Item_master.Columns(43).Name = "ระยะทับเส้น (F8) (มม.)"
        data_excelfile.DataGrid_Item_master.Columns(44).Name = "น้ำหนัก/แผ่น"
        data_excelfile.DataGrid_Item_master.Columns(45).Name = "พื้นที่/แผ่น"
        data_excelfile.DataGrid_Item_master.Columns(46).Name = "Shipping Mark"
        data_excelfile.DataGrid_Item_master.Columns(47).Name = "Drawing No."
        data_excelfile.DataGrid_Item_master.Columns(48).Name = "Drawing Rev."
        data_excelfile.DataGrid_Item_master.Columns(49).Name = "Plate No."
        data_excelfile.DataGrid_Item_master.Columns(50).Name = "ร่อยต่อ"
        data_excelfile.DataGrid_Item_master.Columns(51).Name = "ประเภทบล็อคพิมพ์"
        data_excelfile.DataGrid_Item_master.Columns(52).Name = "พื้นที่/กล่อง"
        data_excelfile.DataGrid_Item_master.Columns(53).Name = "น้ำหนักกล่อง"
        data_excelfile.DataGrid_Item_master.Columns(54).Name = "พื้นที่บล๊อคกล่อง (W)"
        data_excelfile.DataGrid_Item_master.Columns(55).Name = "พื้นที่บล๊อคกล่อง (L)"
        data_excelfile.DataGrid_Item_master.Columns(56).Name = "พื้นที่บล๊อคกล่อง (M2)"
        data_excelfile.DataGrid_Item_master.Columns(57).Name = "M1"
        data_excelfile.DataGrid_Item_master.Columns(58).Name = "M2"
        data_excelfile.DataGrid_Item_master.Columns(59).Name = "M3"
        data_excelfile.DataGrid_Item_master.Columns(60).Name = "M4"
        data_excelfile.DataGrid_Item_master.Columns(61).Name = "M5"
        data_excelfile.DataGrid_Item_master.Columns(62).Name = "Routing No."
        data_excelfile.DataGrid_Item_master.Columns(63).Name = "Production BOM No."
        data_excelfile.DataGrid_Item_master.Columns(64).Name = "Overhead Rate"
        Dim row As String()
        row = New String() {txt_item_code.Text, txt_desc.Text, "SHT", " ", FG1, "FIFO", " ", " ", (grossweight / 1000), (grossweight / 1000), "No", " ", FG1, "VAT7", "NO", "0", "0", " ", "Prod. Order", "2SHT", "SHT", "Lot-for-Lot", "Yes", "Make-to-Stock", FG1, "FGSH", "LOTALL", " ", txt_lon.Text, "", "", txt_cut.Text, "", txt_width.Text, "", txt_long.Text, txt_F1.Text, txt_F2.Text, txt_F3.Text, txt_F4.Text, txt_F5.Text, txt_F6.Text, txt_F7.Text, txt_F8.Text, (grossweight / 1000), area, "0", txt_note.Text, "0", "0", "", "", "", "", "", "", "", txt_paper_1.Text, txt_paper_2.Text, txt_paper_3.Text, txt_paper_4.Text, txt_paper_5.Text, "SHEETBOARDCORRUGATOR", txt_item_code.Text, "0"}
        data_excelfile.DataGrid_Item_master.Rows.Add(row)
    End Sub
    Sub add_data_Item_Unit_Of_Messure_Sheet()


        If txt_cut.Text > 0 Then
            wei = (txt_cut_small.Text * txt_long.Text) / 1000000 * 10.765
        Else
            wei = 0
        End If


        data_excelfile.DataGrid_Item_unit.ColumnCount = 7
        data_excelfile.DataGrid_Item_unit.Columns(0).Name = "Item No."
        data_excelfile.DataGrid_Item_unit.Columns(1).Name = "Code"
        data_excelfile.DataGrid_Item_unit.Columns(2).Name = "Qty. per Unit of Measure"
        data_excelfile.DataGrid_Item_unit.Columns(3).Name = "Length"
        data_excelfile.DataGrid_Item_unit.Columns(4).Name = "Width"
        data_excelfile.DataGrid_Item_unit.Columns(5).Name = "Height"
        data_excelfile.DataGrid_Item_unit.Columns(6).Name = "Weight"
        Dim row As String()
        row = New String() {txt_item_code.Text, "SHT", "1", lonng, wid, unit_height, wei}
        data_excelfile.DataGrid_Item_unit.Rows.Add(row)

    End Sub
    Sub add_data_input_print()
        data_input.DataGrid_input.ColumnCount = 37

        data_input.DataGrid_input.Columns(0).Name = "Chk1"
        data_input.DataGrid_input.Columns(1).Name = "Chk2"
        data_input.DataGrid_input.Columns(2).Name = "No."
        data_input.DataGrid_input.Columns(3).Name = "Type"
        data_input.DataGrid_input.Columns(4).Name = "PO"
        data_input.DataGrid_input.Columns(5).Name = "กว้าง"
        data_input.DataGrid_input.Columns(6).Name = "หน้าเดินงาน นิ้ว"
        data_input.DataGrid_input.Columns(7).Name = "ผ่า"
        data_input.DataGrid_input.Columns(8).Name = "ยาว"
        data_input.DataGrid_input.Columns(9).Name = "หน้าผ่าเล็ก"
        data_input.DataGrid_input.Columns(10).Name = "F1"
        data_input.DataGrid_input.Columns(11).Name = "F2"
        data_input.DataGrid_input.Columns(12).Name = "F3"
        data_input.DataGrid_input.Columns(13).Name = "F4"
        data_input.DataGrid_input.Columns(14).Name = "F5"
        data_input.DataGrid_input.Columns(15).Name = "F6"
        data_input.DataGrid_input.Columns(16).Name = "F7"
        data_input.DataGrid_input.Columns(17).Name = "F8"
        data_input.DataGrid_input.Columns(18).Name = "CHECKED"
        data_input.DataGrid_input.Columns(19).Name = "Trim"
        data_input.DataGrid_input.Columns(20).Name = "CHECKED"
        data_input.DataGrid_input.Columns(21).Name = "Paper Combination/สั่งผลิต"
        data_input.DataGrid_input.Columns(22).Name = "ลอน"
        data_input.DataGrid_input.Columns(23).Name = "จำนวนเต็ม"
        data_input.DataGrid_input.Columns(24).Name = "จำนวนแผ่นเล็ก"
        data_input.DataGrid_input.Columns(25).Name = "Due ส่งของ"
        data_input.DataGrid_input.Columns(26).Name = "P/L"
        data_input.DataGrid_input.Columns(27).Name = "@special P/ L"
        data_input.DataGrid_input.Columns(28).Name = "@NET P/ L"
        data_input.DataGrid_input.Columns(29).Name = "@NET unit Price "
        data_input.DataGrid_input.Columns(30).Name = "เมตรรวมหาส่วนลด"
        data_input.DataGrid_input.Columns(31).Name = "เมตรรวม เดินงานพ่วง"
        data_input.DataGrid_input.Columns(32).Name = "เมตรรวมหาส่วนลด "
        data_input.DataGrid_input.Columns(33).Name = "Discount"
        data_input.DataGrid_input.Columns(34).Name = "ส่วนลดเงินสด"
        data_input.DataGrid_input.Columns(35).Name = "ราคาต่อแผ่น "
        data_input.DataGrid_input.Columns(36).Name = "หมายเหตุ"


        'data_input.DataGrid_input.Columns(0).Width = 175
        'data_input.DataGrid_input.Columns(1).Width = 400
        'data_input.DataGrid_input.Columns(2).Width = 150
        'data_input.DataGrid_input.Columns(3).Width = 150

        Dim row As String()

        row = New String() {
                            False,
                            True,
                            "1",
                            txt_type.Text,
                            txt_pono.Text,
                            txt_width.Text,
                            txt_workinch.Text,
                            txt_cut.Text,
                            txt_long.Text,
                            txt_cut_small.Text,
                            txt_F1.Text,
                            txt_F2.Text,
                            txt_F3.Text,
                            txt_F4.Text,
                            txt_F5.Text,
                            txt_F6.Text,
                            txt_F7.Text,
                            txt_F8.Text,
                            chk_checked.Text,
                            txt_chk_txt.Text,
                            chk_checked.Text,
                            txt_search_pl.Text,
                            txt_lon.Text,
                            txt_count.Text,
                            txt_count_cut.Text,
                            txt_duedate.Value,
                            txt_pl.Text,
                            txt_pl_sp.Text,
                            txt_pl_net.Text,
                            txt_net_unit.Text,
                            txt_met.Text,
                            txt_meth.Text,
                            txt_meth2.Text,
                            txt_discount.Text,
                            txt_sumdiscount.Text,
                            txt_price.Text,
                            txt_note.Text
                            }
        data_input.DataGrid_input.Rows.Add(row)
    End Sub
    Sub add_data_codetxt()
        data_excelfile.DataGrid_codetxt.ColumnCount = 1
        data_excelfile.DataGrid_codetxt.Columns(0).Name = "No."
        Dim row As String()
        row = New String() {txt_item_code.Text}
        data_excelfile.DataGrid_codetxt.Rows.Add(row)
    End Sub
    Function get_m(m)
        Dim mm As String = ""
        If m = "" Then mm = "00"
        If m = "A125" Then mm = "A2"
        If m = "A150" Then mm = "A4"
        If m = "A185" Then mm = "A6"
        If m = "A230" Then mm = "A8"
        If m = "PA125" Then mm = "A2"
        If m = "PA150" Then mm = "A4"
        If m = "PA185" Then mm = "A6"
        If m = "PA230" Then mm = "A8"
        If m = "HA125" Then mm = "A2"
        If m = "HA150" Then mm = "A4"
        If m = "HA185" Then mm = "A6"
        If m = "HA230" Then mm = "A8"
        If m = "KA112" Then mm = "AE"
        If m = "KA125" Then mm = "A2"
        If m = "KA150" Then mm = "A4"
        If m = "KA185" Then mm = "A6"
        If m = "KA225" Then mm = "AI"
        If m = "KA230" Then mm = "A8"
        If m = "KA270" Then mm = "BB"
        If m = "A230" Then mm = "A8"
        If m = "A112" Then mm = "AE"
        If m = "A125" Then mm = "A2"
        If m = "A150" Then mm = "A4"
        If m = "A185" Then mm = "A6"
        If m = "A225" Then mm = "AI"
        If m = "KN125" Then mm = "A2"
        If m = "KN150" Then mm = "A4"
        If m = "KN185" Then mm = "A6"
        If m = "KN230" Then mm = "A8"
        If m = "KU125" Then mm = "U2"
        If m = "KU150" Then mm = "U4"
        If m = "KU185" Then mm = "U6"
        If m = "KU230" Then mm = "U8"
        If m = "KAC125" Then mm = "A2"
        If m = "KAC150" Then mm = "A4"
        If m = "KAC185" Then mm = "A6"
        If m = "KAC230" Then mm = "A8"
        If m = "KH175" Then mm = "KF"
        If m = "KH200" Then mm = "KG"
        If m = "KH250" Then mm = "K9"
        If m = "AU125" Then mm = "U2"
        If m = "AU185" Then mm = "U6"
        If m = "AU230" Then mm = "U8"
        If m = "I125" Then mm = "I2"
        If m = "I150" Then mm = "I4"
        If m = "I185" Then mm = "I6"
        If m = "KQ125" Then mm = "I2"
        If m = "KQ150" Then mm = "I4"
        If m = "KQ185" Then mm = "I6"
        If m = "PI125" Then mm = "I2"
        If m = "PI150" Then mm = "I4"
        If m = "PI185" Then mm = "I6"
        If m = "CI125" Then mm = "I2"
        If m = "CI150" Then mm = "I4"
        If m = "CI185" Then mm = "I6"
        If m = "TPI125" Then mm = "I2"
        If m = "TPI150" Then mm = "I4"
        If m = "TPI185" Then mm = "I6"
        If m = "KI125" Then mm = "I2"
        If m = "KI150" Then mm = "I4"
        If m = "KI185" Then mm = "I6"
        If m = "KD125" Then mm = "D2"
        If m = "KD150" Then mm = "D4"
        If m = "KD185" Then mm = "D6"
        If m = "KD230" Then mm = "D8"
        If m = "KJ125" Then mm = "J2"
        If m = "KJ150" Then mm = "J4"
        If m = "KJ185" Then mm = "J6"
        If m = "KJ230" Then mm = "J8"
        If m = "KL125" Then mm = "L2"
        If m = "KL150" Then mm = "L4"
        If m = "KL175" Then mm = "LF"
        If m = "KL205" Then mm = "L7"
        If m = "KL250" Then mm = "L9"
        If m = "KP175" Then mm = "PF"
        If m = "KP230" Then mm = "P8"
        If m = "KP250" Then mm = "P9"
        If m = "KT125" Then mm = "T2"
        If m = "KT140" Then mm = "T3"
        If m = "KT150" Then mm = "T4"
        If m = "KT175" Then mm = "TF"
        If m = "KT185" Then mm = "T6"
        If m = "KT200" Then mm = "TG"
        If m = "KT250" Then mm = "T9"
        If m = "KK125" Then mm = "K2"
        If m = "KK150" Then mm = "K4"
        If m = "KK185" Then mm = "K6"
        If m = "KX125" Then mm = "X2"
        If m = "KX150" Then mm = "X4"
        If m = "MK125" Then mm = "K2"
        If m = "MK150" Then mm = "K4"
        If m = "MK185" Then mm = "K6"
        If m = "M100" Then mm = "ME"
        If m = "M105" Then mm = "M0"
        If m = "M107" Then mm = "M0"
        If m = "M110" Then mm = "ML"
        If m = "M115" Then mm = "M1"
        If m = "M120" Then mm = "MM"
        If m = "M125" Then mm = "M2"
        If m = "M127" Then mm = "MK"
        If m = "M150" Then mm = "M4"
        If m = "M185" Then mm = "M6"
        If m = "M190" Then mm = "MN"
        If m = "CM105" Then mm = "M0"
        If m = "CM107" Then mm = "M0"
        If m = "CM115" Then mm = "M1"
        If m = "CM125" Then mm = "M2"
        If m = "CM150" Then mm = "M4"
        If m = "CM185" Then mm = "M6"
        If m = "CM127" Then mm = "MK"
        If m = "CM100" Then mm = "ME"
        If m = "CM110" Then mm = "ML"
        If m = "CM120" Then mm = "MM"
        If m = "CM190" Then mm = "MN"
        If m = "CJ230" Then mm = "X8"
        If m = "S150" Then mm = "S4"
        If m = "S140" Then mm = "S3"
        If m = "S170" Then mm = "S5"
        If m = "KS140" Then mm = "S3"
        If m = "KS150" Then mm = "S4"
        If m = "KS170" Then mm = "S5"
        If m = "KA260" Then mm = "CL"
        If m = "TK125" Then mm = "T2"
        If m = "TK180" Then mm = "TO"
        If m = "TK210" Then mm = "TP"
        If m = "MG056" Then mm = "GA"
        If m = "SB060" Then mm = "SB"
        If m = "NP170" Then mm = "N5"
        If m = "NP200" Then mm = "NG"
        If m = "NP210" Then mm = "NP"
        If m = "NP220" Then mm = "NH"
        If m = "NP280" Then mm = "NJ"

        Return mm

    End Function

    Sub set_field()

        txt_paper_1.ReadOnly = False
        txt_paper_2.ReadOnly = False
        txt_paper_3.ReadOnly = False
        txt_paper_4.ReadOnly = False
        txt_paper_5.ReadOnly = False


        If txt_lon.Text = "A" Then
            txt_paper_5.Enabled = True
            txt_paper_4.Enabled = False
            txt_paper_3.Enabled = False
            txt_paper_2.Enabled = True
            txt_paper_1.Enabled = True
            BA = 0
            unit_height = 5.0

        ElseIf txt_lon.Text = "C" Then
            txt_paper_5.Enabled = True
            txt_paper_4.Enabled = False
            txt_paper_3.Enabled = False
            txt_paper_2.Enabled = True
            txt_paper_1.Enabled = True
            BA = 24
            unit_height = 3.8


        ElseIf txt_lon.Text = "B" Then
            txt_paper_5.Enabled = True
            txt_paper_4.Enabled = True
            txt_paper_3.Enabled = True
            txt_paper_2.Enabled = False
            txt_paper_1.Enabled = False
            BA = 24
            unit_height = 2.7

        ElseIf txt_lon.Text = "E" Then
            txt_paper_5.Enabled = True
            txt_paper_4.Enabled = True
            txt_paper_3.Enabled = True
            txt_paper_2.Enabled = False
            txt_paper_1.Enabled = False
            BA = 28
            unit_height = 1.15

        ElseIf txt_lon.Text = "AB" Then
            txt_paper_5.Enabled = True
            txt_paper_4.Enabled = True
            txt_paper_3.Enabled = True
            txt_paper_2.Enabled = True
            txt_paper_1.Enabled = True
            BA = 0
            unit_height = 7.7

        ElseIf txt_lon.Text = "BC" Then
            txt_paper_5.Enabled = True
            txt_paper_4.Enabled = True
            txt_paper_3.Enabled = True
            txt_paper_2.Enabled = True
            txt_paper_1.Enabled = True
            BA = 24
            unit_height = 6.5

        End If

        txt_paper_5.Text = ""
        txt_paper_4.Text = ""
        txt_paper_3.Text = ""
        txt_paper_2.Text = ""
        txt_paper_1.Text = ""
        txt_search_pl.Text = ""

        txt_paper_5.Focus()
    End Sub





    Private Sub txt_F1_TextChanged(sender As Object, e As EventArgs) Handles txt_F1.TextChanged
        F1 = txt_F1.Text
        get_cut_small()
    End Sub
    Private Sub txt_F2_TextChanged(sender As Object, e As EventArgs) Handles txt_F2.TextChanged
        F2 = txt_F2.Text
        get_cut_small()
    End Sub
    Private Sub txt_F3_TextChanged(sender As Object, e As EventArgs) Handles txt_F3.TextChanged
        F3 = txt_F3.Text
        get_cut_small()
    End Sub
    Private Sub txt_F4_TextChanged(sender As Object, e As EventArgs) Handles txt_F4.TextChanged
        F4 = txt_F4.Text
        get_cut_small()
    End Sub
    Private Sub txt_F5_TextChanged(sender As Object, e As EventArgs) Handles txt_F5.TextChanged
        F5 = txt_F5.Text
        get_cut_small()
    End Sub
    Private Sub txt_F6_TextChanged(sender As Object, e As EventArgs) Handles txt_F6.TextChanged
        F6 = txt_F6.Text
        get_cut_small()
    End Sub
    Private Sub txt_F7_TextChanged(sender As Object, e As EventArgs) Handles txt_F7.TextChanged
        F7 = txt_F7.Text
        get_cut_small()
    End Sub
    Private Sub txt_F8_TextChanged(sender As Object, e As EventArgs) Handles txt_F8.TextChanged
        F8 = txt_F8.Text
        get_cut_small()
    End Sub
    Sub get_cut_small()
        cut_total = (F1 + F2 + F3 + F4 + F5 + F6 + F7 + F8)
        txt_cut_small.Text = cut_total
    End Sub
    Private Sub txt_search_pl_TextChanged(sender As Object, e As EventArgs) Handles txt_search_pl.TextChanged
        Try
            If txt_search_pl.Text.Length > 11 Then
                connection.Close()
                connection.Open()
                Dim sql As String
                sql = "
                        SELECT * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_PL]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_PL].[b]   LIKE    '%" + txt_search_pl.Text + "%'
                        "
                Dim sqlcmd As New SqlCommand(sql, setup_conf.connection)
                Dim myreader As SqlDataReader
                myreader = sqlcmd.ExecuteReader()
                myreader.Read()
                If myreader.HasRows Then
                    txt_pl.Text = myreader.Item("i").ToString
                End If
                connection.Close()

                If txt_paper_4.Text <> "" Then
                    paper_4 = "/" + txt_paper_4.Text
                End If
                If txt_paper_3.Text <> "" Then
                    paper_3 = "/" + txt_paper_3.Text
                End If
                If txt_paper_2.Text <> "" Then
                    paper_2 = "/" + txt_paper_2.Text
                End If
                If txt_paper_1.Text <> "" Then
                    paper_1 = "/" + txt_paper_1.Text
                End If


                gen_item_code()
                gen_item_des()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txt_lon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_lon.SelectedIndexChanged
        set_field()
        gen_item_code()
    End Sub
    Private Sub txt_lon_TextChanged(sender As Object, e As EventArgs) Handles txt_lon.TextChanged
        set_field()
        gen_item_code()
    End Sub
    Private Sub txt_paper_5_TextChanged(sender As Object, e As EventArgs) Handles txt_paper_5.TextChanged
        If txt_paper_5.Text.Length = 4 Then
            SendKeys.Send("{TAB}")
            Concat_pl()
        End If
    End Sub
    Private Sub txt_paper_4_TextChanged(sender As Object, e As EventArgs) Handles txt_paper_4.TextChanged
        If txt_paper_4.Text.Length = 4 Then
            SendKeys.Send("{TAB}")
            Concat_pl()
        End If
    End Sub
    Private Sub txt_paper_3_TextChanged(sender As Object, e As EventArgs) Handles txt_paper_3.TextChanged
        If txt_paper_3.Text.Length = 4 Then
            SendKeys.Send("{TAB}")
            Concat_pl()
        End If
    End Sub
    Private Sub txt_paper_2_TextChanged(sender As Object, e As EventArgs) Handles txt_paper_2.TextChanged
        If txt_paper_2.Text.Length = 4 Then
            SendKeys.Send("{TAB}")
            Concat_pl()
        End If
    End Sub
    Private Sub txt_paper_1_TextChanged(sender As Object, e As EventArgs) Handles txt_paper_1.TextChanged
        If txt_paper_1.Text.Length = 4 Then
            Concat_pl()
        End If
    End Sub
    Sub Concat_pl()
        txt_search_pl.Text = txt_paper_5.Text + txt_paper_4.Text + txt_paper_3.Text + txt_paper_2.Text + txt_paper_1.Text
    End Sub
    Private Sub txt_width_TextChanged(sender As Object, e As EventArgs) Handles txt_width.TextChanged
        If txt_fn_find_inch_mm.Text = "นิ้ว" Then
            If txt_width.Text = "36" Then wid = "0930"
            If txt_width.Text = "38" Then wid = "0980"
            If txt_width.Text = "40" Then wid = "1030"
            If txt_width.Text = "42" Then wid = "1080"
            If txt_width.Text = "44" Then wid = "1130"
            If txt_width.Text = "46" Then wid = "1180"
            If txt_width.Text = "48" Then wid = "1230"
            If txt_width.Text = "50" Then wid = "1280"
            If txt_width.Text = "52" Then wid = "1330"
            If txt_width.Text = "54" Then wid = "1390"
            If txt_width.Text = "56" Then wid = "1440"
            If txt_width.Text = "58" Then wid = "1490"
            If txt_width.Text = "60" Then wid = "1540"
            If txt_width.Text = "62" Then wid = "1590"
            If txt_width.Text = "64" Then wid = "1640"
            If txt_width.Text = "66" Then wid = "1690"
            If txt_width.Text = "68" Then wid = "1740"
            If txt_width.Text = "70" Then wid = "1790"
            If txt_width.Text = "72" Then wid = "1850"
            If txt_width.Text = "74" Then wid = "1900"
            If txt_width.Text = "76" Then wid = "1950"
            If txt_width.Text = "78" Then wid = "2000"
            If txt_width.Text = "80" Then wid = "2050"
            If txt_width.Text = "82" Then wid = "2100"
            If txt_width.Text = "84" Then wid = "2150"
            If txt_width.Text = "86" Then wid = "2200"
        Else
            wid = txt_width.Text
        End If
    End Sub
    Private Sub txt_long_TextChanged(sender As Object, e As EventArgs) Handles txt_long.TextChanged


        If txt_fn_find_inch_mm.Text = "นิ้ว" Then
            If txt_long.Text = "36" Then lonng = "0930"
            If txt_long.Text = "38" Then lonng = "0980"
            If txt_long.Text = "40" Then lonng = "1030"
            If txt_long.Text = "42" Then lonng = "1080"
            If txt_long.Text = "44" Then lonng = "1130"
            If txt_long.Text = "46" Then lonng = "1180"
            If txt_long.Text = "48" Then lonng = "1230"
            If txt_long.Text = "50" Then lonng = "1280"
            If txt_long.Text = "52" Then lonng = "1330"
            If txt_long.Text = "54" Then lonng = "1390"
            If txt_long.Text = "56" Then lonng = "1440"
            If txt_long.Text = "58" Then lonng = "1490"
            If txt_long.Text = "60" Then lonng = "1540"
            If txt_long.Text = "62" Then lonng = "1590"
            If txt_long.Text = "64" Then lonng = "1640"
            If txt_long.Text = "66" Then lonng = "1690"
            If txt_long.Text = "68" Then lonng = "1740"
            If txt_long.Text = "70" Then lonng = "1790"
            If txt_long.Text = "72" Then lonng = "1850"
            If txt_long.Text = "74" Then lonng = "1900"
            If txt_long.Text = "76" Then lonng = "1950"
            If txt_long.Text = "78" Then lonng = "2000"
            If txt_long.Text = "80" Then lonng = "2050"
            If txt_long.Text = "82" Then lonng = "2100"
            If txt_long.Text = "84" Then lonng = "2150"
            If txt_long.Text = "86" Then lonng = "2200"
        Else
            lonng = txt_long.Text
        End If


        gen_item_code()
        gen_item_des()
    End Sub
    Private Sub txt_width_LostFocus(sender As Object, e As EventArgs) Handles txt_width.LostFocus
        If txt_fn_find_inch_mm.Text = "มิล" Then
            If txt_width.Text.Length = 1 Then
                txt_width.Text = "000" + txt_width.Text
            End If
            If txt_width.Text.Length = 2 Then
                txt_width.Text = "00" + txt_width.Text
            End If
            If txt_width.Text.Length = 3 Then
                txt_width.Text = "0" + txt_width.Text
            End If
            gen_item_code()
            gen_item_des()
        Else
            gen_item_code()
            gen_item_des()
        End If
    End Sub
    Private Sub txt_fn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_fn_find_inch_mm.SelectedIndexChanged

        If txt_fn_find_inch_mm.Text = "มิล" Then
            txt_sub_desc.Enabled = False

            txt_customer.Enabled = True
            txt_pono.Enabled = True
            txt_type.Enabled = True
            txt_width.Enabled = True
            txt_workinch.Enabled = True
            txt_cut.Enabled = True
            txt_long.Enabled = True
            txt_cut_small.Enabled = True
        Else
            txt_sub_desc.Enabled = True

            txt_customer.Enabled = True
            txt_pono.Enabled = True
            txt_type.Enabled = True
            txt_width.Enabled = True
            txt_workinch.Enabled = True
            txt_cut.Enabled = True
            txt_long.Enabled = True
            txt_cut_small.Enabled = True
        End If

    End Sub
    Private Sub txt_paper_5_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_5.LostFocus
        txt_paper_5.Text = txt_paper_5.Text.ToUpper()
    End Sub
    Private Sub txt_paper_4_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_4.LostFocus
        txt_paper_4.Text = txt_paper_4.Text.ToUpper()
    End Sub
    Private Sub txt_paper_3_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_3.LostFocus
        txt_paper_3.Text = txt_paper_3.Text.ToUpper()
    End Sub
    Private Sub txt_paper_2_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_2.LostFocus
        txt_paper_2.Text = txt_paper_2.Text.ToUpper()
    End Sub
    Private Sub txt_paper_1_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_1.LostFocus
        txt_paper_1.Text = txt_paper_1.Text.ToUpper()
    End Sub
    Private Sub txt_long_LostFocus(sender As Object, e As EventArgs) Handles txt_long.LostFocus
        gen_item_code()
        gen_item_des()
    End Sub
    Private Sub txt_stampline_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_stampline.SelectedIndexChanged
        gen_item_code()
    End Sub
    Private Sub txt_stampline_LostFocus(sender As Object, e As EventArgs) Handles txt_stampline.LostFocus
        gen_item_code()
    End Sub
    Private Sub txt_sub_desc_TextChanged(sender As Object, e As EventArgs) Handles txt_sub_desc.TextChanged
        gen_item_des()
    End Sub
    Private Sub txt_sub_desc_LostFocus(sender As Object, e As EventArgs) Handles txt_sub_desc.LostFocus
        gen_item_des()
    End Sub
    Sub gen_item_code()
        txt_item_code.Text = txt_lon.Text + get_m(txt_paper_5.Text) & get_m(txt_paper_4.Text) & get_m(txt_paper_3.Text) & get_m(txt_paper_2.Text) & get_m(txt_paper_1.Text) + wid + lonng + txt_stampline.Text
    End Sub
    Sub gen_item_des()
        txt_desc.Text = txt_width.Text + " x " + txt_long.Text + " " + txt_sub_desc.Text + " " + txt_paper_5.Text + paper_4 + paper_3 + paper_2 + paper_1 + " " + txt_lon.Text
    End Sub
    Private Sub txt_meth2_TextChanged(sender As Object, e As EventArgs) Handles txt_meth2.TextChanged
        Try
            connection.Close()
            connection.Open()
            Dim sql As String
            sql = "
                        SELECT  * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount].[Customer_Code]     LIKE    '%" + txt_customer.SelectedValue + "%'
                        AND     (
                                [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount].[MeterStart]        >       '" + txt_meth2.Text + "'
                                AND
                                [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount].[MeterEnd]          <       '" + txt_meth2.Text + "'
                                )
                        "
            Dim sqlcmd As New SqlCommand(sql, setup_conf.connection)
            Dim myreader As SqlDataReader
            myreader = sqlcmd.ExecuteReader()
            myreader.Read()
            If myreader.HasRows Then
                find_discount = myreader.Item("Discount").ToString
            End If
            connection.Close()

            txt_discount.Text = find_discount

            gen_item_code()
            gen_item_des()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Sub get_price_mm()

        Dim tz As Double

        Dim c_width As Double
        Dim c_long As Double
        Dim PL As Double

        c_width = CDbl(Val(txt_width.Text))
        c_long = CDbl(Val(txt_long.Text))

        PL = CDbl(Val(txt_pl.Text))

        tz = (((c_width * c_long) / 1000000) * 10.76)

        txt_price.Text = Math.Round((tz * PL), 2)
    End Sub
    Sub get_meter_discount()
        Dim HS As Double

        txt_met.Text = ((txt_long.Text * txt_count_cut.Text) / 1000) / HS
    End Sub
    Private Sub txt_pl_TextChanged(sender As Object, e As EventArgs) Handles txt_pl.TextChanged
        get_price_mm()
        ' get_meter_discount()
    End Sub

    Private Sub txt_cut_small_TextChanged(sender As Object, e As EventArgs) Handles txt_cut_small.TextChanged
        If txt_cut_small.Text <> "" Then

            Dim cut
            Dim x5 = (Integer.Parse(txt_cut_small.Text) * 5) + 26
            Dim x4 = (Integer.Parse(txt_cut_small.Text) * 4) + 26
            Dim x3 = (Integer.Parse(txt_cut_small.Text) * 3) + 26
            Dim x2 = (Integer.Parse(txt_cut_small.Text) * 2) + 26
            Dim x1 = (Integer.Parse(txt_cut_small.Text) * 1) + 26

            If x5 <= 2200 Then
                cut = 5
            ElseIf x5 >= 2200 And x4 <= 2200 Then
                cut = 4
            ElseIf x5 >= 2200 And x4 >= 2200 And x3 <= 2200 Then
                cut = 3
            ElseIf x5 >= 2200 And x4 >= 2200 And x3 >= 2200 And x2 <= 2200 Then
                cut = 2
            Else
                cut = 1
            End If

            txt_cut.Text = cut
        End If
    End Sub

End Class