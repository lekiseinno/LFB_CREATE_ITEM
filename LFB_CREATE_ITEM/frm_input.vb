Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Linq.Expressions

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
    Dim discount As Integer
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
    Dim ww
    Dim grossweight As Double

    Private Sub frm_input_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' setup_conf.bom_header()

        txt_customer.Focus()

        txt_fn_find_inch_mm.Text = "มิล มิล"
        txt_lon.Text = "B"


        'txt_item_code.Hide()
        'txt_desc.Hide()
        ' txt_search_pl.Hide()

        get_item_customer()
        get_unit()
        txt_duedate.Format = DateTimePickerFormat.Custom
        txt_duedate.CustomFormat = "yyyy-MM-dd"
        txt_duedate.Value = Now()

        txt_paper_1.ReadOnly = True
        txt_paper_2.ReadOnly = True
        txt_paper_3.ReadOnly = True
        txt_paper_4.ReadOnly = True
        txt_paper_5.ReadOnly = True
        txt_sub_desc.Enabled = False

        txt_subsub_dscc.Visible = False


        'txt_wid_inch_to_mm.Visible = False
        'txt_long_inch_to_mm.Visible = False


        add_head_data_bom_header_0()
        add_head_data_bom_header_1()
        add_head_data_bom_line()
        add_head_data_defaut_dimension_sheet()
        add_head_data_item_master()
        add_head_data_Item_Unit_Of_Messure_Sheet()
    End Sub
    Sub get_unit()
        If txt_fn_find_inch_mm.Text = "" Then
            txt_pono.Enabled = False
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
            sql = "SELECT * FROM [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer] "
            Dim query As New SqlCommand(sql, connection)
            Dim dataadapter As New SqlDataAdapter(query)
            Dim dt As New DataTable
            Dim ds As New DataSet
            dataadapter.Fill(ds, "Customer_Code")
            dt = ds.Tables(0)
            Dim idataView As DataView
            idataView = New DataView(dt)
            idataView.Sort = "Customer_Name ASC"
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
            add_data_bom_header_0() 'OK
            add_data_bom_header_1() 'OK
            add_data_bom_line() 'OK
            add_data_defaut_dimension_sheet() 'OK
            add_data_Item_Unit_Of_Messure_Sheet() 'OK
            add_data_codetxt() 'OK
            add_data_item_master() 'OK
        End If
    End Sub



    Sub add_head_data_bom_header_0()
        data_excelfile.DataGrid_bom_header_0.ColumnCount = 4
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        row1 = New String() {"Production BOM Header", "99000771", "", ""}
        row2 = New String() {"", "", "", ""}
        row3 = New String() {"No.", "Description", "Unit of Measure Code", "Status"}
        data_excelfile.DataGrid_bom_header_0.Rows.Add(row1)
        data_excelfile.DataGrid_bom_header_0.Rows.Add(row2)
        data_excelfile.DataGrid_bom_header_0.Rows.Add(row3)
    End Sub
    Sub add_head_data_bom_header_1()
        data_excelfile.DataGrid_bom_header_1.ColumnCount = 4
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        row1 = New String() {"Production BOM Header", "99000771", "", ""}
        row2 = New String() {"", "", "", ""}
        row3 = New String() {"No.", "Description", "Unit of Measure Code", "Status"}
        data_excelfile.DataGrid_bom_header_1.Rows.Add(row1)
        data_excelfile.DataGrid_bom_header_1.Rows.Add(row2)
        data_excelfile.DataGrid_bom_header_1.Rows.Add(row3)
    End Sub
    Sub add_head_data_bom_line()
        data_excelfile.DataGrid_bom_line.ColumnCount = 20

        Dim row01 As String()
        Dim row02 As String()
        Dim row03 As String()

        row01 = New String() {"Production BOM Line", "99000772"}
        row02 = New String() {"", ""}
        row03 = New String() {"Production BOM No.", "Line No.", "Version Code", "Type", "No.", "Description", "Unit of Measure Code", "Quantity", "Position", "Position 2", "Position 3", "Production Lead Time", "Routing Link Code", "Scrap %", "Variant Code", "Comment", "Starting Date", "Ending Date", "Quantity per", "Ratio"}

        data_excelfile.DataGrid_bom_line.Rows.Add(row01)
        data_excelfile.DataGrid_bom_line.Rows.Add(row02)
        data_excelfile.DataGrid_bom_line.Rows.Add(row03)


    End Sub
    Sub add_head_data_defaut_dimension_sheet()
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()

        data_excelfile.DataGrid_Default_dimension.ColumnCount = 6

        row1 = New String() {"Production BOM Line", "352"}
        row2 = New String() {" ", " "}
        row3 = New String() {"Table ID", "No.", "Dimension Code", "Dimension Value Code", "Value Posting", "Table Name"}
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row1)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row2)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row3)
    End Sub
    Sub add_head_data_item_master()

        data_excelfile.DataGrid_Item_master.ColumnCount = 65
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        row1 = New String() {"Item", "27"}
        row2 = New String() {" ", " "}
        row3 = New String() {"No.", "Description", "Base Unit of Measure", "Price Unit Conversion", "Inventory Posting Group", "Costing Method", "Unit Cost", "Reorder Quantity", "Gross Weight", "Net Weight", "Blocked", "VAT Bus. Posting Gr. (Price)", "Gen. Prod. Posting Group", "VAT Prod. Posting Group", "Inventory Value Zero", "Minimum Order Quantity", "Maximum Order Quantity", "Safety Lead Time", "Replenishment System", "Sales Unit of Measure", "Purch. Unit of Measure", "Reordering Policy", "Include Inventory", "Manufacturing Policy", "Item Category Code", "Product Group Code", "Item Tracking Code", "Lot Nos.", "Lonn Code", "Grade Code", "Gram Code", "ผ่า", "ความกว้าง(นิ้ว)", "ความกว้าง(มม.)", "ความยาว(นิ้ว)", "ความยาว(มม.)", "ระยะทับเส้น (F1) (มม.)", "ระยะทับเส้น (F2) (มม.)", "ระยะทับเส้น (F3) (มม.)", "ระยะทับเส้น (F4) (มม.)", "ระยะทับเส้น (F5) (มม.)", "ระยะทับเส้น (F6) (มม.)", "ระยะทับเส้น (F7) (มม.)", "ระยะทับเส้น (F8) (มม.)", "น้ำหนัก/แผ่น", "พื้นที่/แผ่น", "Shipping Mark", "Drawing No.", "Drawing Rev.", "Plate No.", "ร่อยต่อ", "ประเภทบล็อคพิมพ์", "พื้นที่/กล่อง", "น้ำหนักกล่อง", "พื้นที่บล๊อคกล่อง (W)", "พื้นที่บล๊อคกล่อง (L)", "พื้นที่บล๊อคกล่อง (M2)", "M1", "M2", "M3", "M4", "M5", "Routing No.", "Production BOM No.", "Overhead Rate"}
        data_excelfile.DataGrid_Item_master.Rows.Add(row1)
        data_excelfile.DataGrid_Item_master.Rows.Add(row2)
        data_excelfile.DataGrid_Item_master.Rows.Add(row3)

    End Sub
    Sub add_head_data_Item_Unit_Of_Messure_Sheet()
        data_excelfile.DataGrid_Item_unit.ColumnCount = 7
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()

        row1 = New String() {"Item Unit of Measure", "5404"}
        row2 = New String() {" ", " "}
        row3 = New String() {"Item No.", "Code", "Qty. per Unit of Measure", "Length", "Width", "Code", "Weight"}
        data_excelfile.DataGrid_Item_unit.Rows.Add(row1)
        data_excelfile.DataGrid_Item_unit.Rows.Add(row2)
        data_excelfile.DataGrid_Item_unit.Rows.Add(row3)
    End Sub






    Sub add_data_bom_header_0()
        data_excelfile.DataGrid_bom_header_0.ColumnCount = 4
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        row1 = New String() {"Production BOM Header", "id", "", ""}
        row2 = New String() {"", "", "", ""}
        row3 = New String() {txt_item_code.Text, txt_desc.Text, "SHT", "0"}
        data_excelfile.DataGrid_bom_header_0.Rows.Add(row3)
    End Sub
    Sub add_data_bom_header_1()
        data_excelfile.DataGrid_bom_header_1.ColumnCount = 4
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        row1 = New String() {"Production BOM Header", "id", "", ""}
        row2 = New String() {"", "", "", ""}
        row3 = New String() {txt_item_code.Text, txt_desc.Text, "SHT", "1"}
        data_excelfile.DataGrid_bom_header_1.Rows.Add(row3)
    End Sub
    Sub add_data_bom_line()
        data_excelfile.DataGrid_bom_line.ColumnCount = 20

        Dim row01 As String()
        Dim row02 As String()
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


        'data_excelfile.DataGrid_bom_line.Rows.Add(row01)
        'data_excelfile.DataGrid_bom_line.Rows.Add(row02)

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
        Dim row3 As String()
        Dim row4 As String()
        Dim row5 As String()
        Dim row6 As String()
        Dim row7 As String()

        data_excelfile.DataGrid_Default_dimension.ColumnCount = 6

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

        row3 = New String() {"27", txt_item_code.Text, "COSTCENTER", "20102", "", ""}
        row4 = New String() {"27", txt_item_code.Text, "GRADE     ", GRADE, "", ""}
        row5 = New String() {"27", txt_item_code.Text, "GRAM      ", GRAM, "", ""}
        row6 = New String() {"27", txt_item_code.Text, "PPAGE     ", txt_width.Text, "", ""}
        row7 = New String() {"27", txt_item_code.Text, "PROFILE   ", txt_lon.Text, "", ""}

        data_excelfile.DataGrid_Default_dimension.Rows.Add(row3)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row4)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row5)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row6)
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row7)

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
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        ' row1 = New String() {"Item", " "}
        ' row2 = New String() {" ", " "}
        row3 = New String() {txt_item_code.Text, txt_desc.Text, "SHT", " ", FG1, "FIFO", " ", " ", (grossweight / 1000), (grossweight / 1000), "No", " ", FG1, "VAT7", "NO", "0", "0", " ", "Prod. Order", "2SHT", "SHT", "Lot-for-Lot", "Yes", "Make-to-Stock", FG1, "FGSH", "LOTALL", " ", txt_lon.Text, "", "", txt_cut.Text, "", txt_width.Text, "", txt_long.Text, txt_F1.Text, txt_F2.Text, txt_F3.Text, txt_F4.Text, txt_F5.Text, txt_F6.Text, txt_F7.Text, txt_F8.Text, (grossweight / 1000), area, "0", txt_note.Text, "0", "0", "", "", "", "", "", "", "", txt_paper_1.Text, txt_paper_2.Text, txt_paper_3.Text, txt_paper_4.Text, txt_paper_5.Text, "SHEETBOARDCORRUGATOR", txt_item_code.Text, "0"}
        ' data_excelfile.DataGrid_Item_master.Rows.Add(row1)
        ' data_excelfile.DataGrid_Item_master.Rows.Add(row2)
        data_excelfile.DataGrid_Item_master.Rows.Add(row3)
    End Sub
    Sub add_data_Item_Unit_Of_Messure_Sheet()


        If txt_cut.Text > 0 Then
            wei = (txt_cut_small.Text * txt_long.Text) / 1000000 * 10.765
        Else
            wei = 0
        End If


        data_excelfile.DataGrid_Item_unit.ColumnCount = 7
        Dim row1 As String()
        Dim row2 As String()
        Dim row3 As String()
        'row1 = New String() {"Item Unit of Measure", "5404"}
        'row2 = New String() {" ", " "}
        row3 = New String() {txt_item_code.Text, "SHT", "1", lonng, wid, unit_height, wei}
        'data_excelfile.DataGrid_Item_unit.Rows.Add(row1)
        'data_excelfile.DataGrid_Item_unit.Rows.Add(row2)
        data_excelfile.DataGrid_Item_unit.Rows.Add(row3)

    End Sub
    Sub add_data_input_print()
        data_input.DataGrid_input.ColumnCount = 37

        data_input.DataGrid_input.Columns(2).Visible = False

        data_input.DataGrid_input.Columns(0).Name = "Check"
        data_input.DataGrid_input.Columns(1).Name = "Check"
        data_input.DataGrid_input.Columns(2).Name = "#" '
        data_input.DataGrid_input.Columns(3).Name = "PO Number" '
        data_input.DataGrid_input.Columns(4).Name = " "
        data_input.DataGrid_input.Columns(5).Name = "width"
        data_input.DataGrid_input.Columns(6).Name = "workinch"
        data_input.DataGrid_input.Columns(7).Name = "cut"
        data_input.DataGrid_input.Columns(8).Name = "long"
        data_input.DataGrid_input.Columns(9).Name = "cut small"
        data_input.DataGrid_input.Columns(10).Name = "F1"
        data_input.DataGrid_input.Columns(11).Name = "F2"
        data_input.DataGrid_input.Columns(12).Name = "F3"
        data_input.DataGrid_input.Columns(13).Name = "F4"
        data_input.DataGrid_input.Columns(14).Name = "F5"
        data_input.DataGrid_input.Columns(15).Name = "F6"
        data_input.DataGrid_input.Columns(16).Name = "F7"
        data_input.DataGrid_input.Columns(17).Name = "F8"
        data_input.DataGrid_input.Columns(18).Name = "Check"
        data_input.DataGrid_input.Columns(19).Name = "chk_txt"
        data_input.DataGrid_input.Columns(20).Name = "Check"
        data_input.DataGrid_input.Columns(21).Name = "txt_search_pl"
        data_input.DataGrid_input.Columns(22).Name = "txt_lon"
        data_input.DataGrid_input.Columns(23).Name = "txt_count"
        data_input.DataGrid_input.Columns(24).Name = "txt_count_cut"
        data_input.DataGrid_input.Columns(25).Name = "txt_duedate"
        data_input.DataGrid_input.Columns(26).Name = "txt_pl"
        data_input.DataGrid_input.Columns(27).Name = "txt_pl_sp"
        data_input.DataGrid_input.Columns(28).Name = "txt_pl_net"
        data_input.DataGrid_input.Columns(29).Name = "txt_net_unit"
        data_input.DataGrid_input.Columns(30).Name = "txt_met"
        data_input.DataGrid_input.Columns(31).Name = "txt_meth"
        data_input.DataGrid_input.Columns(32).Name = "txt_meth2"
        data_input.DataGrid_input.Columns(33).Name = "txt_discount"
        data_input.DataGrid_input.Columns(34).Name = "txt_sumdiscount"
        data_input.DataGrid_input.Columns(35).Name = "txt_price"
        data_input.DataGrid_input.Columns(36).Name = "txt_note"




        Dim row As String()

        row = New String() {
                            False,
                            True,
                            "1",
                            txt_pono.Text,
                            "",
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









    Function get_m(minput)
        Dim m_m_m As String = ""
        If minput = "" Then m_m_m = "00"
        If minput = "A125" Then m_m_m = "A2"
        If minput = "A150" Then m_m_m = "A4"
        If minput = "A185" Then m_m_m = "A6"
        If minput = "A230" Then m_m_m = "A8"
        'If minput = "PA125" Then m_m_m = "A2"
        'If minput = "PA150" Then m_m_m = "A4"
        'If minput = "PA185" Then m_m_m = "A6"
        'If minput = "PA230" Then m_m_m = "A8"
        'If minput = "HA125" Then m_m_m = "A2"
        'If minput = "HA150" Then m_m_m = "A4"
        'If minput = "HA185" Then m_m_m = "A6"
        'If minput = "HA230" Then m_m_m = "A8"
        'If minput = "KA112" Then m_m_m = "AE"
        'If minput = "KA125" Then m_m_m = "A2"
        'If minput = "KA150" Then m_m_m = "A4"
        'If minput = "KA185" Then m_m_m = "A6"
        'If minput = "KA225" Then m_m_m = "AI"
        'If minput = "KA230" Then m_m_m = "A8"
        'If minput = "KA270" Then m_m_m = "BB"
        If minput = "A230" Then m_m_m = "A8"
        If minput = "A112" Then m_m_m = "AE"
        If minput = "A125" Then m_m_m = "A2"
        If minput = "A150" Then m_m_m = "A4"
        If minput = "A185" Then m_m_m = "A6"
        If minput = "A225" Then m_m_m = "AI"
        'If minput = "KN125" Then m_m_m = "A2"
        'If minput = "KN150" Then m_m_m = "A4"
        'If minput = "KN185" Then m_m_m = "A6"
        'If minput = "KN230" Then m_m_m = "A8"
        'If minput = "KU125" Then m_m_m = "U2"
        'If minput = "KU150" Then m_m_m = "U4"
        'If minput = "KU185" Then m_m_m = "U6"
        'If minput = "KU230" Then m_m_m = "U8"
        'If minput = "KAC125" Then m_m_m = "A2"
        'If minput = "KAC150" Then m_m_m = "A4"
        'If minput = "KAC185" Then m_m_m = "A6"
        'If minput = "KAC230" Then m_m_m = "A8"
        'If minput = "KH175" Then m_m_m = "KF"
        'If minput = "KH200" Then m_m_m = "KG"
        'If minput = "KH250" Then m_m_m = "K9"
        'If minput = "AU125" Then m_m_m = "U2"
        'If minput = "AU185" Then m_m_m = "U6"
        'If minput = "AU230" Then m_m_m = "U8"
        If minput = "I125" Then m_m_m = "I2"
        If minput = "I150" Then m_m_m = "I4"
        If minput = "I185" Then m_m_m = "I6"
        'If minput = "KQ125" Then m_m_m = "I2"
        'If minput = "KQ150" Then m_m_m = "I4"
        'If minput = "KQ185" Then m_m_m = "I6"
        'If minput = "PI125" Then m_m_m = "I2"
        'If minput = "PI150" Then m_m_m = "I4"
        'If minput = "PI185" Then m_m_m = "I6"
        'If minput = "CI125" Then m_m_m = "I2"
        'If minput = "CI150" Then m_m_m = "I4"
        'If minput = "CI185" Then m_m_m = "I6"
        'If minput = "TPI125" Then m_m_m = "I2"
        'If minput = "TPI150" Then m_m_m = "I4"
        'If minput = "TPI185" Then m_m_m = "I6"
        'If minput = "KI125" Then m_m_m = "I2"
        'If minput = "KI150" Then m_m_m = "I4"
        'If minput = "KI185" Then m_m_m = "I6"
        'If minput = "KD125" Then m_m_m = "D2"
        'If minput = "KD150" Then m_m_m = "D4"
        'If minput = "KD185" Then m_m_m = "D6"
        'If minput = "KD230" Then m_m_m = "D8"
        'If minput = "KJ125" Then m_m_m = "J2"
        'If minput = "KJ150" Then m_m_m = "J4"
        'If minput = "KJ185" Then m_m_m = "J6"
        'If minput = "KJ230" Then m_m_m = "J8"
        If (minput = "KL125" Or minput = "L125") Then m_m_m = "L2"
        If (minput = "KL150" Or minput = "L150") Then m_m_m = "L4"
        If (minput = "KL175" Or minput = "L175") Then m_m_m = "LF"
        If (minput = "KL205" Or minput = "L205") Then m_m_m = "L7"
        If (minput = "KL250" Or minput = "L205") Then m_m_m = "L9"
        'If minput = "KP175" Then m_m_m = "PF"
        'If minput = "KP230" Then m_m_m = "P8"
        'If minput = "KP250" Then m_m_m = "P9"
        'If minput = "KT125" Then m_m_m = "T2"
        'If minput = "KT140" Then m_m_m = "T3"
        'If minput = "KT150" Then m_m_m = "T4"
        'If minput = "KT175" Then m_m_m = "TF"
        'If minput = "KT185" Then m_m_m = "T6"
        'If minput = "KT200" Then m_m_m = "TG"
        'If minput = "KT250" Then m_m_m = "T9"
        'If minput = "KK125" Then m_m_m = "K2"
        'If minput = "KK150" Then m_m_m = "K4"
        'If minput = "KK185" Then m_m_m = "K6"
        'If minput = "KX125" Then m_m_m = "X2"
        'If minput = "KX150" Then m_m_m = "X4"
        'If minput = "MK125" Then m_m_m = "K2"
        'If minput = "MK150" Then m_m_m = "K4"
        'If minput = "MK185" Then m_m_m = "K6"
        If minput = "M100" Then m_m_m = "ME"
        If minput = "M105" Then m_m_m = "M0"
        If minput = "M107" Then m_m_m = "M0"
        If minput = "M110" Then m_m_m = "ML"
        If minput = "M115" Then m_m_m = "M1"
        If minput = "M120" Then m_m_m = "MM"
        If minput = "M125" Then m_m_m = "M2"
        If minput = "M127" Then m_m_m = "MK"
        If minput = "M150" Then m_m_m = "M4"
        If minput = "M185" Then m_m_m = "M6"
        If minput = "M190" Then m_m_m = "MN"
        'If minput = "CM105" Then m_m_m = "M0"
        'If minput = "CM107" Then m_m_m = "M0"
        'If minput = "CM115" Then m_m_m = "M1"
        'If minput = "CM125" Then m_m_m = "M2"
        'If minput = "CM150" Then m_m_m = "M4"
        'If minput = "CM185" Then m_m_m = "M6"
        'If minput = "CM127" Then m_m_m = "MK"
        'If minput = "CM100" Then m_m_m = "ME"
        'If minput = "CM110" Then m_m_m = "ML"
        'If minput = "CM120" Then m_m_m = "MM"
        'If minput = "CM190" Then m_m_m = "MN"
        'If minput = "CJ230" Then m_m_m = "X8"
        'If minput = "S150" Then m_m_m = "S4"
        'If minput = "S140" Then m_m_m = "S3"
        'If minput = "S170" Then m_m_m = "S5"
        'If minput = "KS140" Then m_m_m = "S3"
        'If minput = "KS150" Then m_m_m = "S4"
        'If minput = "KS170" Then m_m_m = "S5"
        'If minput = "KA260" Then m_m_m = "CL"
        'If minput = "TK125" Then m_m_m = "T2"
        'If minput = "TK180" Then m_m_m = "TO"
        'If minput = "TK210" Then m_m_m = "TP"
        'If minput = "MG056" Then m_m_m = "GA"
        'If minput = "SB060" Then m_m_m = "SB"
        'If minput = "NP170" Then m_m_m = "N5"
        'If minput = "NP200" Then m_m_m = "NG"
        'If minput = "NP210" Then m_m_m = "NP"
        'If minput = "NP220" Then m_m_m = "NH"
        'If minput = "NP280" Then m_m_m = "NJ"

        Return m_m_m

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
        get_discounts()
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
            SendKeys.Send("{TAB}")
            Concat_pl()
        End If
    End Sub
    Sub Concat_pl()
        txt_search_pl.Text = txt_paper_5.Text + txt_paper_4.Text + txt_paper_3.Text + txt_paper_2.Text + txt_paper_1.Text
    End Sub
    Private Sub txt_fn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_fn_find_inch_mm.SelectedIndexChanged
        If txt_fn_find_inch_mm.Text = "มิล มิล" Then
            txt_sub_desc.Enabled = False
            txt_customer.Enabled = True
            txt_pono.Enabled = True
            txt_width.Enabled = True
            txt_workinch.Enabled = True
            txt_cut.Enabled = True
            txt_long.Enabled = True
            txt_cut_small.Enabled = True

            txt_wid_inch_to_mm.Visible = False
            txt_long_inch_to_mm.Visible = False
        Else
            txt_sub_desc.Enabled = True
            txt_customer.Enabled = True
            txt_pono.Enabled = True
            txt_width.Enabled = True
            txt_workinch.Enabled = True
            txt_cut.Enabled = True
            txt_long.Enabled = True
            txt_cut_small.Enabled = True

            txt_wid_inch_to_mm.Visible = True
            txt_long_inch_to_mm.Visible = True
        End If
    End Sub
    Sub get_wid_lonng()
        If txt_fn_find_inch_mm.Text = "นิ้ว นิ้ว" Then


            'txt_wid_inch_to_mm.Visible = True
            'txt_long_inch_to_mm.Visible = True

            'txt_width.Visible = False
            'txt_long.Visible = False

            'lonng = Math.Round(CDbl(Val(txt_long.Text)) * 25.4)



            If txt_wid_inch_to_mm.Text = "36" Then wid = "0930"
            If txt_wid_inch_to_mm.Text = "38" Then wid = "0980"
            If txt_wid_inch_to_mm.Text = "40" Then wid = "1030"
            If txt_wid_inch_to_mm.Text = "42" Then wid = "1080"
            If txt_wid_inch_to_mm.Text = "44" Then wid = "1130"
            If txt_wid_inch_to_mm.Text = "46" Then wid = "1180"
            If txt_wid_inch_to_mm.Text = "48" Then wid = "1230"
            If txt_wid_inch_to_mm.Text = "50" Then wid = "1280"
            If txt_wid_inch_to_mm.Text = "52" Then wid = "1330"
            If txt_wid_inch_to_mm.Text = "54" Then wid = "1390"
            If txt_wid_inch_to_mm.Text = "56" Then wid = "1440"
            If txt_wid_inch_to_mm.Text = "58" Then wid = "1490"
            If txt_wid_inch_to_mm.Text = "60" Then wid = "1540"
            If txt_wid_inch_to_mm.Text = "62" Then wid = "1590"
            If txt_wid_inch_to_mm.Text = "64" Then wid = "1640"
            If txt_wid_inch_to_mm.Text = "66" Then wid = "1690"
            If txt_wid_inch_to_mm.Text = "68" Then wid = "1740"
            If txt_wid_inch_to_mm.Text = "70" Then wid = "1790"
            If txt_wid_inch_to_mm.Text = "72" Then wid = "1850"
            If txt_wid_inch_to_mm.Text = "74" Then wid = "1900"
            If txt_wid_inch_to_mm.Text = "76" Then wid = "1950"
            If txt_wid_inch_to_mm.Text = "78" Then wid = "2000"
            If txt_wid_inch_to_mm.Text = "80" Then wid = "2050"
            If txt_wid_inch_to_mm.Text = "82" Then wid = "2100"
            If txt_wid_inch_to_mm.Text = "84" Then wid = "2150"
            If txt_wid_inch_to_mm.Text = "86" Then wid = "2200"


            'lonng = (Val(txt_long_inch_to_mm.Text + sub_item_desc) * 25.4)
            Dim tmp_lonng = Math.Round(Val(txt_long_inch_to_mm.Text) * 25.4)

            If tmp_lonng.ToString.Length = 3 Then
                lonng = "0" & Math.Round(Val(txt_long_inch_to_mm.Text) * 25.4)
            ElseIf tmp_lonng.ToString.Length = 4 Then
                lonng = Math.Round(Val(txt_long_inch_to_mm.Text) * 25.4)
            End If





            '********************************
            '********************************
            '********************************
            '********************************
            '********************************


            txt_long.Text = lonng
            txt_width.Text = wid





        ElseIf txt_fn_find_inch_mm.Text = "มิล มิล" Then


            lonng = txt_long.Text
            wid = txt_width.Text


        End If
    End Sub
    Sub add_zero_long()
        If txt_long.TextLength = 1 Then
            txt_long.Text = "000" & txt_long.Text
        ElseIf txt_long.TextLength = 2 Then
            txt_long.Text = "00" & txt_long.Text
        ElseIf txt_long.TextLength = 3 Then
            txt_long.Text = "0" & txt_long.Text
        End If
    End Sub
    Sub add_zero_wid()
        If txt_width.TextLength = 1 Then
            txt_width.Text = "000" & txt_width.Text
        ElseIf txt_width.TextLength = 2 Then
            txt_width.Text = "00" & txt_width.Text
        ElseIf txt_width.TextLength = 3 Then
            txt_width.Text = "0" & txt_width.Text
        End If
    End Sub
    Private Sub txt_width_LostFocus(sender As Object, e As EventArgs) Handles txt_width.LostFocus
        get_wid_lonng()
        add_zero_wid()
        gen_item_code()
        gen_item_des()
    End Sub
    Private Sub txt_long_LostFocus(sender As Object, e As EventArgs) Handles txt_long.LostFocus
        get_wid_lonng()
        add_zero_long()
        gen_item_code()
        gen_item_des()
    End Sub
    Private Sub txt_wid_inch_to_mm_LostFocus(sender As Object, e As EventArgs) Handles txt_wid_inch_to_mm.LostFocus
        get_wid_lonng()
        gen_item_code()
        gen_item_des()
    End Sub
    Private Sub txt_long_inch_to_mm_LostFocus(sender As Object, e As EventArgs) Handles txt_long_inch_to_mm.LostFocus
        get_wid_lonng()
        gen_item_code()
        gen_item_des()
    End Sub
    Private Sub Txt_width_TextChanged(sender As Object, e As EventArgs) Handles txt_width.TextChanged
        get_wid_lonng()
        gen_item_code()
        gen_item_des()
    End Sub
    Private Sub Txt_long_TextChanged(sender As Object, e As EventArgs) Handles txt_long.TextChanged
        get_wid_lonng()
        gen_item_code()
        gen_item_des()
    End Sub
    Private Sub txt_stampline_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_stampline.SelectedIndexChanged
        gen_item_code()
    End Sub
    Private Sub txt_stampline_LostFocus(sender As Object, e As EventArgs) Handles txt_stampline.LostFocus
        gen_item_code()
    End Sub

    Dim sub_item_desc
    Private Sub txt_sub_desc_TextChanged(sender As Object, e As EventArgs) Handles txt_sub_desc.TextChanged
        gen_item_des()

        If txt_sub_desc.Text = "1/2" Then
            sub_item_desc = 0.5
        ElseIf txt_sub_desc.Text = "1/3" Then
            sub_item_desc = 0.33
        ElseIf txt_sub_desc.Text = "1/4" Then
            sub_item_desc = 0.25
        ElseIf txt_sub_desc.Text = "1/5" Then
            sub_item_desc = 0.2
        ElseIf txt_sub_desc.Text = "1/6" Then
            sub_item_desc = 0.167
        ElseIf txt_sub_desc.Text = "1/7" Then
            sub_item_desc = 0.142
        ElseIf txt_sub_desc.Text = "1/8" Then
            sub_item_desc = 0.125
        End If



    End Sub
    Private Sub txt_sub_desc_LostFocus(sender As Object, e As EventArgs) Handles txt_sub_desc.LostFocus
        If txt_sub_desc.Text IsNot Nothing Then
            gen_item_des()

            Dim strarr() As String
            strarr = txt_sub_desc.Text.Split("/")
            txt_subsub_dscc.Text = (strarr(0) / strarr(1))

            get_wid_lonng()
        Else
            txt_sub_desc.Text = "1/1"
        End If




    End Sub
    Sub gen_item_code()
        txt_item_code.Text = get_lons(txt_lon.Text) + get_m(txt_paper_5.Text) & get_m(txt_paper_4.Text) & get_m(txt_paper_3.Text) & get_m(txt_paper_2.Text) & get_m(txt_paper_1.Text) + wid + lonng + txt_stampline.Text
    End Sub
    Sub gen_item_des()
        txt_desc.Text = txt_width.Text + " x " + txt_long.Text + " " + txt_sub_desc.Text + " " + txt_paper_5.Text + paper_4 + paper_3 + paper_2 + paper_1 + " " + txt_lon.Text
    End Sub
    Function get_lons(lon)
        Dim lon_name As String = ""
        If lon = "BC" Then
            lon_name = "D"
        End If
        If lon = "AB" Then
            lon_name = "X"
        End If
        If lon = "A" Then
            lon_name = "A"
        End If
        If lon = "B" Then
            lon_name = "B"
        End If
        If lon = "C" Then
            lon_name = "C"
        End If
        If lon = "E" Then
            lon_name = "E"
        End If
        Return lon_name
    End Function
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
                discount = myreader.Item("Discount").ToString
            End If
            connection.Close()

            txt_discount.Text = discount & " %"

            gen_item_code()
            gen_item_des()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Dim tz As Double
    Dim c_width As Double
    Dim c_long As Double
    Dim PL As Double
    Dim m
    Dim cut As Integer
    Dim cutcut As Integer
    Dim Trim As Integer
    Dim mw
    Dim mww
    Dim S
    Dim DK
    Dim HK
    Sub get_price_mm()
        c_width = CDbl(Val(txt_width.Text))
        c_long = CDbl(Val(txt_long.Text))
        PL = CDbl(Val(txt_pl.Text))
        tz = (((c_width * c_long) / 1000000) * 10.76)

        If txt_fn_find_inch_mm.Text = "มิล มิล" Then

            'txt_pl_sp
            If txt_pl_sp.Text IsNot Nothing Then
                Dim xx = (((c_width * c_long) / 1000000) * 10.76 * CDbl(Val(txt_pl_sp.Text)))
                txt_price.Text = Math.Round((xx - (xx * discount / 100)), 2)
            End If

            'net
            If txt_pl_net.Text IsNot Nothing Then
                Dim xx = (((c_width * c_long) / 1000000) * 10.76 * CDbl(Val(txt_pl_net.Text)))
                ' MsgBox(xx)
                txt_price.Text = Math.Round(xx, 2)

            End If


            If txt_pl.Text IsNot Nothing Then
                Dim xx = (((c_width * c_long) / 1000000) * 10.76 * CDbl(Val(txt_pl.Text)))
                txt_price.Text = Math.Round((xx - (xx * discount / 100)), 2)
            End If


        End If

        If txt_fn_find_inch_mm.Text = "นิ้ว นิ้ว" Then



            'txt_pl_sp
            If txt_pl_sp.Text IsNot Nothing Then
                Dim xx = ((((txt_wid_inch_to_mm.Text * 25.4) * (txt_long_inch_to_mm.Text * 25.4)) / 1000000) * 10.76 * CDbl(Val(txt_pl_sp.Text)))
                txt_price.Text = Math.Round((xx - (xx * discount / 100)), 2)
            End If

            'net
            If txt_pl_net.Text IsNot Nothing Then
                Dim xx = ((((txt_wid_inch_to_mm.Text * 25.4) * (txt_long_inch_to_mm.Text * 25.4)) / 1000000) * 10.76 * CDbl(Val(txt_pl_net.Text)))
                ' MsgBox(xx)
                txt_price.Text = Math.Round(xx, 2)
            End If


            If txt_pl.Text IsNot Nothing Then
                Dim xx = (((txt_wid_inch_to_mm.Text * 25.4) * (((txt_long_inch_to_mm.Text + sub_item_desc) * 25.4) / 1000000) * 10.76 * CDbl(Val(txt_pl.Text))))
                txt_price.Text = Math.Round((xx - (xx * discount / 100)), 2)
            End If


        End If
    End Sub
    Private Sub txt_pl_TextChanged(sender As Object, e As EventArgs) Handles txt_pl.TextChanged
        get_price_mm()
    End Sub
    Private Sub txt_paper_5_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_5.LostFocus
        txt_paper_5.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txt_paper_4_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_4.LostFocus
        txt_paper_4.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txt_paper_3_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_3.LostFocus
        txt_paper_3.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txt_paper_2_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_2.LostFocus
        txt_paper_2.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txt_paper_1_LostFocus(sender As Object, e As EventArgs) Handles txt_paper_1.LostFocus
        txt_paper_1.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub txt_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_customer.SelectedIndexChanged
        lb_cuscode.Text = txt_customer.SelectedValue.ToString()

        get_discounts()
    End Sub
    Private Sub txt_count_TextChanged(sender As Object, e As EventArgs) Handles txt_count.TextChanged
        Dim x_final As Integer = 26
        Dim txet_cut_small = txt_cut_small.Text
        If txt_cut_small.Text = Nothing Then
            txet_cut_small = 0
        End If

        'Dim x1 = (Integer.Parse(txt_cut_small.Text) * 1) + x_final
        'Dim x2 = (Integer.Parse(txt_cut_small.Text) * 2) + x_final
        'Dim x3 = (Integer.Parse(txt_cut_small.Text) * 3) + x_final
        'Dim x4 = (Integer.Parse(txt_cut_small.Text) * 4) + x_final
        'Dim x5 = (Integer.Parse(txt_cut_small.Text) * 5) + x_final

        Dim x1 = (Integer.Parse(txet_cut_small) * 1) + x_final
        Dim x2 = (Integer.Parse(txet_cut_small) * 2) + x_final
        Dim x3 = (Integer.Parse(txet_cut_small) * 3) + x_final
        Dim x4 = (Integer.Parse(txet_cut_small) * 4) + x_final
        Dim x5 = (Integer.Parse(txet_cut_small) * 5) + x_final

        Dim y1 = (Integer.Parse(txt_width.Text) * 1) + x_final
        Dim y2 = (Integer.Parse(txt_width.Text) * 2) + x_final
        Dim y3 = (Integer.Parse(txt_width.Text) * 3) + x_final
        Dim y4 = (Integer.Parse(txt_width.Text) * 4) + x_final
        Dim y5 = (Integer.Parse(txt_width.Text) * 5) + x_final

        If x5 < 2200 Or x5 < 2161 Then 'x5
            cut = 5
        ElseIf x5 >= 2200 And x4 <= 2200 Then 'x4
            cut = 4
        ElseIf x5 >= 2200 And x4 >= 2200 And x3 <= 2200 Then 'x3
            cut = 3
        ElseIf x5 >= 2200 And x4 >= 2200 And x3 >= 2200 And x2 <= 2200 Then 'x2 
            cut = 2
        Else 'x1
            cut = 1
        End If

        If x5 < 2200 Then
            m = x5
        Else
            If x4 < 2200 Then
                m = x4
            Else
                If x3 < 2200 Then
                    m = x3
                Else
                    If x2 < 2200 Then
                        m = x2
                    Else
                        m = x1
                    End If
                End If
            End If
        End If

        If y1 > 870 Then
            HK = y1
        ElseIf y2 > 870 Then
            HK = y2
        ElseIf y3 > 870 Then
            HK = y3
        ElseIf y4 > 870 Then
            HK = y3
        ElseIf y5 > 870 Then
            HK = y5
        End If

        If m < 931 Then
            m = 930
        Else
            If m < 981 Then
                m = 980
            Else
                If m < 1031 Then
                    m = 1030
                Else
                    If m < 1081 Then
                        m = 1080
                    Else
                        If m < 1131 Then
                            m = 1130
                        Else
                            If m < 1181 Then
                                m = 1180
                            Else
                                If m < 1231 Then
                                    m = 1230
                                Else
                                    If m < 1281 Then
                                        m = 1280
                                    Else
                                        If m < 1331 Then
                                            m = 1330
                                        Else
                                            If m < 1391 Then
                                                m = 1390
                                            Else
                                                If m < 1441 Then
                                                    m = 1440
                                                Else
                                                    If m < 1491 Then
                                                        m = 1490
                                                    Else
                                                        If m < 1541 Then
                                                            m = 1540
                                                        Else
                                                            If m < 1591 Then
                                                                m = 1590
                                                            Else
                                                                If m < 1641 Then
                                                                    m = 1640
                                                                Else
                                                                    If m < 1691 Then
                                                                        m = 1690
                                                                    Else
                                                                        If m < 1741 Then
                                                                            m = 1740
                                                                        Else
                                                                            If m < 1791 Then
                                                                                m = 1790
                                                                            Else
                                                                                If m < 1851 Then
                                                                                    m = 1850
                                                                                Else
                                                                                    If m < 1901 Then
                                                                                        m = 1900
                                                                                    Else
                                                                                        If m < 1951 Then
                                                                                            m = 1950
                                                                                        Else
                                                                                            If m < 2001 Then
                                                                                                m = 2000
                                                                                            Else
                                                                                                If m < 2051 Then
                                                                                                    m = 2050
                                                                                                Else
                                                                                                    If m < 2101 Then
                                                                                                        m = 2100
                                                                                                    Else
                                                                                                        If m < 2151 Then
                                                                                                            m = 2150
                                                                                                        Else
                                                                                                            If m < 2201 Then
                                                                                                                m = 2200
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

        If mw < 931 Then
            mw = 930
        Else
            If mw < 981 Then
                mw = 980
            Else
                If mw < 1031 Then
                    mw = 1030
                Else
                    If mw < 1081 Then
                        mw = 1080
                    Else
                        If mw < 1131 Then
                            mw = 1130
                        Else
                            If mw < 1181 Then
                                mw = 1180
                            Else
                                If mw < 1231 Then
                                    mw = 1230
                                Else
                                    If mw < 1281 Then
                                        mw = 1280
                                    Else
                                        If mw < 1331 Then
                                            mw = 1330
                                        Else
                                            If mw < 1391 Then
                                                mw = 1390
                                            Else
                                                If mw < 1441 Then
                                                    mw = 1440
                                                Else
                                                    If mw < 1491 Then
                                                        mw = 1490
                                                    Else
                                                        If mw < 1541 Then
                                                            mw = 1540
                                                        Else
                                                            If mw < 1591 Then
                                                                mw = 1590
                                                            Else
                                                                If mw < 1641 Then
                                                                    mw = 1640
                                                                Else
                                                                    If mw < 1691 Then
                                                                        mw = 1690
                                                                    Else
                                                                        If mw < 1741 Then
                                                                            mw = 1740
                                                                        Else
                                                                            If mw < 1791 Then
                                                                                mw = 1790
                                                                            Else
                                                                                If mw < 1841 Then
                                                                                    mw = 1840
                                                                                Else
                                                                                    If mw < 1891 Then
                                                                                        mw = 1890
                                                                                    Else
                                                                                        If mw < 1941 Then
                                                                                            mw = 1940
                                                                                        Else
                                                                                            If mw < 1991 Then
                                                                                                mw = 1990
                                                                                            Else
                                                                                                If mw < 2041 Then
                                                                                                    mw = 2040
                                                                                                Else
                                                                                                    If mw < 2091 Then
                                                                                                        mw = 2090
                                                                                                    Else
                                                                                                        If mw < 2141 Then
                                                                                                            mw = 2140
                                                                                                        Else
                                                                                                            If mw < 2191 Then
                                                                                                                mw = 2190
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If



        txt_count_cut.Text = txt_count.Text
        txt_cut.Text = cut



        Label37.Text = "x1=" & x1 & " | x2=" & x2 & " | x3=" & x3 & " | x4=" & x4 & " | x5=" & x5

        TextBox1.Text = m & " | " & x1 & " " & x2 & " " & x3 & " " & x4 & " " & x5
        TextBox2.Text = HK & " | " & y1 & " " & y2 & " " & y3 & " " & y4 & " " & y5

        'If txt_fn_find_inch_mm.Text = "นิ้ว นิ้ว" Then
        '    txt_trim.Text = Math.Ceiling((m - (wid * cut)) / 2)
        'End If

        'If txt_fn_find_inch_mm.Text = "มิล มิล" Then
        '    txt_trim.Text = Math.Ceiling((m - (wid * cut)) / 2)
        'End If

        txt_trim.Text = Math.Ceiling((m - (wid * cut)) / 2)

        get_discounts()
        get_price_mm()
        get_net_pl()
        get_mminch()



        get_price_sp()



        'txt_price.Text = Math.Round((CDbl(Val(txt_price.Text)) - ((CDbl(Val(txt_price.Text)) * CDbl(Val(txt_discount.Text))) / 100)), 2)

    End Sub

    Sub get_price_sp()
        connection.Close()
        connection.Open()
        sql5 = "
                        SELECT  * 
                        FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_SpecialPrice]
                        WHERE   [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_SpecialPrice].[Customer_Code] =   '" + lb_cuscode.Text + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_SpecialPrice].[GradeGram]     =   '" + txt_search_pl.Text + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_SpecialPrice].[Lon]           =   '" + txt_lon.Text + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_SpecialPrice].[width]         =   '" + txt_width.Text + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_SpecialPrice].[long]          =   '" + txt_long.Text + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_SpecialPrice].[Meth_Start]    >   '" + txt_met.Text + "'
                        AND     [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_SpecialPrice].[Meth_End]      <   '" + txt_met.Text + "'
                        "
        Dim sqlcmd5 As New SqlCommand(sql5, setup_conf.connection)
        Dim myreader5 As SqlDataReader
        myreader5 = sqlcmd5.ExecuteReader()
        myreader5.Read()
        If myreader5.HasRows Then
            'desc_bom_Line5 = myreader5.Item("d").ToString
            'sqmx5 = myreader5.Item("e").ToString
            txt_pl_sp.Text = myreader5.Item("Price").ToString
        End If
        'Qty5 = Math.Round((sqm * sqmx5) / 1000, 5)

    End Sub
    Sub get_discounts()

        connection.Close()
        connection.Open()
        Dim sql1 As String

        Dim text_lon As String = txt_lon.Text

        If txt_met.Text > 0 Then
            sql1 = "
                    SELECT  [" & text_lon & "]
                    FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount] 
                    WHERE   [Customer_Code] =   '" & lb_cuscode.Text & "'
                    AND     [MeterStart]    <   '" & txt_met.Text & "'
                    AND     [MeterEnd]      >   '" & txt_met.Text & "'
                    "
        Else
            sql1 = "
                SELECT  [" & text_lon & "]
                FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_Discount] 
                WHERE   [Customer_Code] =   '" & lb_cuscode.Text & "'
                "
        End If







        TextBox3.Text = sql1
        Dim sqlcmd1 As New SqlCommand(sql1, setup_conf.connection)
        Dim myreader1 As SqlDataReader
        myreader1 = sqlcmd1.ExecuteReader()
        myreader1.Read()
        If myreader1.HasRows Then
            discount = myreader1.Item(text_lon).ToString
        End If
        connection.Close()
        txt_discount.Text = discount & " %"
    End Sub
    Private Sub txt_count_cut_TextChanged(sender As Object, e As EventArgs) Handles txt_count_cut.TextChanged
        find_met()
    End Sub
    Private Sub txt_pl_net_TextChanged(sender As Object, e As EventArgs) Handles txt_pl_net.TextChanged
        If txt_pl_net.Text = "" Then
            txt_discount.Text = discount & " %"
            get_price_mm()
        Else
            txt_discount.Text = ""
            Dim xx = (((c_width * c_long) / 1000000) * 10.765 * CDbl(Val(txt_pl_net.Text)))
            txt_price.Text = Math.Round(xx, 2)
        End If
    End Sub
    Sub get_mminch()

        'If txt_fn_find_inch_mm.Text = "นิ้ว นิ้ว" Then
        '    Label41.Text = m
        '    Label42.Text = mw
        'ElseIf txt_fn_find_inch_mm.Text = "มิล มิล" Then

        'ElseIf txt_fn_find_inch_mm.Text = "มิล นิ้ว" Then

        'ElseIf txt_fn_find_inch_mm.Text = "นิ้ว มิล" Then

        'End If
    End Sub
    Sub find_met()
        S = Math.Round(HK / CDbl(Val(wid)), 0)
        DK = Math.Ceiling((CDbl(Val(lonng)) * CDbl(Val(txt_count_cut.Text)) / 1000))

        txt_met.Text = Math.Round(DK / S)

        ''287.5
        'Dim tp As Single = (DK / S)

        'Dim first As Int32 = Fix(tp) '287
        'Dim second As Int32 = Int((tp - first) * 10) '5

        'Dim TPs As String = first & "." & second
        'Dim dbl As Double = CDbl(TPs)
        'Dim third As Double = Int((tp - dbl) * 100)
        'TPs = first & "." & second & third


        'Dim ssss

        'If second >= 5 Then
        '    ssss = first + 1
        'ElseIf second < 5 Then
        '    ssss = first
        'End If




        'txt_met.Text = ssss


    End Sub
    Sub get_net_pl()

        Try

            connection.Close()
            connection.Open()
            Dim sql1 As String
            Dim netpl = 0
            Dim colmn As String



            If txt_met.Text > 1 And txt_met.Text < 249 Then
                colmn = "1"
            ElseIf txt_met.Text > 250 And txt_met.Text < 499 Then
                colmn = "250"
            ElseIf txt_met.Text > 500 And txt_met.Text < 999 Then
                colmn = "500"
            ElseIf txt_met.Text > 1000 And txt_met.Text < 1999 Then
                colmn = "1000"
            ElseIf txt_met.Text > 2000 And txt_met.Text < 2999 Then
                colmn = "2000"
            ElseIf txt_met.Text > 3000 And txt_met.Text < 3999 Then
                colmn = "3000"
            ElseIf txt_met.Text > 4000 And txt_met.Text < 4999 Then
                colmn = "4000"
            ElseIf txt_met.Text > 5000 And txt_met.Text < 9999 Then
                colmn = "5000"
            ElseIf txt_met.Text > 10000 And txt_met.Text < 19999 Then
                colmn = "10000"
            ElseIf txt_met.Text > 20000 Then
                colmn = "20000"
            End If



            sql1 = "
                SELECT  [" & colmn & "] as 'Net_PL'
                FROM    [LFB_ITEM$].[dbo].[LFB_ITEM$_Customer_NetPrice]
                WHERE   [Customer_Code] =   '" & lb_cuscode.Text & "'
                AND     [Item_Code]     =   '" & txt_search_pl.Text & "'
                "

            TextBox4.Text = sql1


            Dim sqlcmd1 As New SqlCommand(sql1, setup_conf.connection)
            Dim myreader1 As SqlDataReader
            myreader1 = sqlcmd1.ExecuteReader()
            myreader1.Read()
            If myreader1.HasRows Then
                netpl = myreader1.Item("Net_PL").ToString
            End If
            connection.Close()
            txt_pl_net.Text = netpl
        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub
    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim idocnumber As String = ""
        idocnumber = SaveHead()
        txtdocnumber.Text = idocnumber

        If txtdocnumber.Text <> "" Then
            Savedetail(idocnumber)
            MsgBox("บันทึกสำเร็จ")
            MsgBox("Docnumber = " & idocnumber)

        End If
    End Sub
    Function IgenDocno() As String

        Dim idocnumber As String = ""


        Dim isqlupdate As String = ""
        Dim isqlcomman As String = ""
        Dim istringcomman As String = ""
        Dim imonth As String = ""
        Dim iyear As String = ""

        imonth = Microsoft.VisualBasic.DateAndTime.Month(Now).ToString
        iyear = Microsoft.VisualBasic.DateAndTime.Year(Now).ToString.Substring(2)

        If imonth.Length < 2 Then
            imonth = "0" + imonth
        End If


        idocnumber = GenerateDocNumber()

        'isqlcomman = "INSERT INTO LFB_ITEM$_Document_head ([Document_No]) VALUES ('" & idocnumber & "')"

        'isqlupdate = "Select Document_No from LFB_ITEM$_Document_head ORDER BY Date DESC"


        'connection.Close()
        'connection.Open()

        'Dim query As New SqlCommand(isqlcomman, connection)



        'Try
        '    query.ExecuteNonQuery()

        'Catch ex As Exception

        '    MsgBox("มีข้อผิดพลาดในการ Run Document_No")

        'End Try
        'query = Nothing



        'Dim objCmdupdate As SqlCommand

        'objCmdupdate = New SqlCommand(isqlupdate, connection)


        'Try
        '    idocnumber = objCmdupdate.ExecuteScalar()

        'Catch ex As Exception

        '    MsgBox("มีข้อผิดพลาดในการเรียก Document_No")

        'End Try




        'query = Nothing
        'objCmdupdate = Nothing
        'connection.Close()


        Return idocnumber
    End Function
    Function GenerateDocNumber() As String

        Dim strSeqNo = String.Empty
        Dim strPrefix = "doc" ' Prefix : IN-
        Dim intLength = 3 ' Length : IN-XXX
        Dim intYear = DateTime.Now.Year
        Dim intMonth = DateTime.Now.Month
        Dim intSequence = 0

        '     Dim connection = New SqlConnection()
        Dim objCmd = New SqlCommand()
        Dim strSQL = String.Empty


        connection.Close()
        connection.Open()



        '*** Get current sequence
        strSQL = "SELECT Sequence FROM GenerateDocNo WHERE Year = " & intYear & " AND Month = " & intMonth & " "
        objCmd = New SqlCommand(strSQL, connection)
        Dim dr As SqlDataReader = objCmd.ExecuteReader()
        If dr.HasRows Then
            dr.Read()
            intSequence = Convert.ToInt32(dr("Sequence"))
        End If
        dr.Close()

        '*** Insert new month (when new month)
        If intSequence = 0 Then
            intSequence = 1
            strSQL = "INSERT INTO GenerateDocNo (Year, Month, Sequence) VALUES (" & intYear & "," & intMonth & "," & intSequence & ");  "
            objCmd = New SqlCommand(strSQL, connection)
            objCmd.ExecuteNonQuery()
        End If

        '*** Update new sequence
        strSQL = "UPDATE GenerateDocNo SET  Sequence = Sequence + 1 WHERE Year = " & intYear & " AND Month = " & intMonth & "  "
        objCmd = New SqlCommand(strSQL, connection)
        objCmd.ExecuteNonQuery()

        '*** Display sequence
        strSeqNo = String.Format("{0}-{1}{2}-{3}", strPrefix, intYear.ToString.Substring(2),
                                 intMonth.ToString().PadLeft(2, "0"), intSequence.ToString().PadLeft(intLength, "0"))

        connection.Close()
        ' connection = Nothing

        Return strSeqNo
    End Function
    Function SaveHead() As String

        Dim isqlcomman As String = ""
        Dim isqldel As String = ""

        Dim idocnumber As String = ""
        Dim icustno As String = ""

        Dim objCmd = New SqlCommand()



        icustno = lb_cuscode.Text


        If txtdocnumber.Text = "" Then

            idocnumber = IgenDocno()

            isqlcomman = "INSERT INTO LFB_ITEM$_Document_head " &
           "( [Document_No]" &
           ",[Customre_Code]" &
           ",[Date])" &
            " VALUES ('" & idocnumber & "','" & icustno & "','" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"

        Else
            idocnumber = txtdocnumber.Text

            isqlcomman = " UPDATE LFB_ITEM$_Document_head " &
       "SET [Customre_Code] = '" & icustno & "'" &
      ",[Date] = '" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'" &
       "WHERE [Document_No] = '" & idocnumber & "'"
        End If

        '  connection = New SqlConnection(connetionLocal)
        connection.Open()

        objCmd = New SqlCommand(isqlcomman, connection)

        Try

            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ไม่สามารถบันทึกได้")

            Return ""
            Exit Function

        End Try
        objCmd = Nothing


        objCmd = Nothing
        connection.Close()


        Return idocnumber

    End Function
    Private Sub Savedetail(ByVal idocnumber As String)

        Dim ino As String = ""
        Dim itype As String = ""

        Dim iPO As String = ""
        Dim iwidth As String = ""
        Dim ilong As String = ""
        Dim iwork_inch As String = ""
        Dim icut As String = ""
        Dim icut_small As String = ""
        Dim iF1 As String = ""
        Dim iF2 As String = ""
        Dim iF3 As String = ""
        Dim iF4 As String = ""
        Dim iF5 As String = ""
        Dim iF6 As String = ""
        Dim iF7 As String = ""
        Dim iF8 As String = ""
        Dim iCheckeds As String = ""
        Dim iTrim As String = ""
        Dim iChecked As String = ""
        Dim iPaperCombination As String = ""
        Dim iLon As String = ""
        Dim iPL As String = ""
        Dim ispecialPL As String = ""
        Dim iNetPL As String = ""
        Dim iNetUnitPrice As String = ""
        Dim iMethfinddiscount As String = ""
        Dim iDiscountmoney As String = ""
        Dim ipriceunit As String = ""
        Dim iremark As String = ""
        Dim idatecreate As Date
        Dim ilastupdate As Date








        connection.Close()
        connection.Open()


        Dim isqldel As String = ""
        Dim isqlcount As String = ""
        Dim isqlcomman As String = ""


        Dim objCmd = New SqlCommand()


        If txtdocnumber.Text <> "" Then

            isqldel = "Delete LFB_ITEM$_Document_line Where [Document_No] = '" & idocnumber & "'"
            objCmd = New SqlCommand(isqldel, connection)

            Try
                objCmd.ExecuteNonQuery()

            Catch ex As Exception

                MsgBox("มีข้อผิดพลาดในการลบ LFB_ITEM$_Document_line")

            End Try

            objCmd = Nothing

        End If




        For i As Integer = 0 To data_input.DataGrid_input.RowCount - 1
            With data_input.DataGrid_input


                If .Rows(0).Cells(2).Value = "" Then
                    MsgBox("ไม่พบรายการายละเอียดสินค้า")
                    Exit Sub
                End If

                If .Rows(i).Cells(2).Value = "" Then
                    Exit For
                Else

                    ino = i
                    itype = .Rows(i).Cells(3).Value
                    iPO = .Rows(i).Cells(4).Value
                    iwidth = .Rows(i).Cells(5).Value
                    ilong = .Rows(i).Cells(6).Value
                    iwork_inch = .Rows(i).Cells(7).Value
                    icut = .Rows(i).Cells(8).Value
                    icut_small = .Rows(i).Cells(9).Value
                    iF1 = .Rows(i).Cells(10).Value
                    iF2 = .Rows(i).Cells(11).Value
                    iF3 = .Rows(i).Cells(12).Value
                    iF4 = .Rows(i).Cells(13).Value
                    iF5 = .Rows(i).Cells(14).Value
                    iF6 = .Rows(i).Cells(15).Value
                    iF7 = .Rows(i).Cells(16).Value
                    iF8 = .Rows(i).Cells(17).Value
                    iCheckeds = .Rows(i).Cells(18).Value
                    iTrim = .Rows(i).Cells(19).Value
                    iChecked = .Rows(i).Cells(20).Value
                    iPaperCombination = .Rows(i).Cells(21).Value
                    iLon = .Rows(i).Cells(22).Value
                    iPL = .Rows(i).Cells(23).Value
                    ispecialPL = .Rows(i).Cells(24).Value
                    iNetPL = .Rows(i).Cells(25).Value
                    iNetUnitPrice = .Rows(i).Cells(26).Value
                    iMethfinddiscount = .Rows(i).Cells(27).Value
                    iDiscountmoney = .Rows(i).Cells(28).Value
                    ipriceunit = .Rows(i).Cells(29).Value
                    iremark = .Rows(i).Cells(30).Value




                    isqlcomman = "INSERT INTO [dbo].[LFB_ITEM$_Document_line]" &
           "([Document_No]" &
           ",[No_]" &
           ",[Type]" &
           ",[PO]" &
           ",[width]" &
           ",[long]" &
           ",[work_inch]" &
          " ,[cut]" &
           ",[cut_small]" &
           ",[F1]" &
          ",[F2]" &
           ",[F3]" &
           ",[F4]" &
           ",[F5]" &
           ",[F6]" &
           ",[F7]" &
           ",[F8]" &
           ",[Checkeds]" &
           ",[Trim]" &
           ",[Checked]" &
           ",[Paper Combination]" &
           ",[Lon]" &
           ",[PL]" &
           ",[special PL]" &
           ",[Net PL]" &
           ",[Net Unit Price]" &
           ",[Meth find discount]" &
           ",[Discount money]" &
           ",[price unit]" &
           ",[remark]" &
           ",[datecreate]" &
           ",[lastupdate]) " &
            " VALUES (" &
           "'" & idocnumber & "'," &
           "'" & ino & "'," &
            "'" & itype & "'," &
           "'" & iPO & "'," &
            "'" & iwidth & "'," &
            "'" & ilong & "'," &
          "'" & iwork_inch & "'," &
           "'" & icut & "'," &
            "'" & icut_small & "'," &
            "'" & iF1 & "'," &
            "'" & iF2 & "'," &
            "'" & iF3 & "'," &
            "'" & iF4 & "'," &
            "'" & iF5 & "'," &
            "'" & iF6 & "'," &
            "'" & iF7 & "'," &
            "'" & iF8 & "'," &
            "'" & iCheckeds & "'," &
            "'" & iTrim & "'," &
            "'" & iChecked & "'," &
            "'" & iPaperCombination & "'," &
            "'" & iLon & "'," &
            "'" & iPL & "'," &
            "'" & ispecialPL & "'," &
            "'" & iNetPL & "'," &
            "'" & iNetUnitPrice & "'," &
            "'" & iMethfinddiscount & "'," &
            "'" & iDiscountmoney & "'," &
            "'" & ipriceunit & "'," &
            "'" & iremark & "'," &
            "'" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "'," &
            "'" & Now.ToString("yyyy-MM-dd HH:mm:ss") & "')"

                End If


                objCmd = New SqlCommand(isqlcomman, connection)

                Try
                    objCmd.ExecuteNonQuery()

                Catch ex As Exception

                    MsgBox("มีข้อผิดพลาดในการบันทึก LFB_ITEM$_Document_line")

                End Try




            End With
        Next



        objCmd = Nothing
        connection.Close()


    End Sub
    Private Sub Btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        frm_input_Load(e, e)
        MsgBox("Clear Complete", vbInformation, "")
        Refresh()
    End Sub

    Private Sub Btn_add_price_manual_Click(sender As Object, e As EventArgs) Handles btn_add_price_manual.Click
        Try
            txt_price.Text = (txt_price.Text + 0.01)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Btn_del_price_manual_Click(sender As Object, e As EventArgs) Handles btn_del_price_manual.Click
        Try
            txt_price.Text = (txt_price.Text - 0.01)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class