Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System
Imports System.Windows.Forms
Public Class frm_input
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        'add_row_bom_head("no", "no", "no", "0")
        'add_row_bom_line("no", "no", "no", "0", "0", "0", "0", "0", "0", "0", "no", "no", "no", "0", "0", "0", "0", "0", "0", "0")
        'add_row_Dimension("no", "no", "no", "no", "no", "no")
        'add_row_item_master("no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no", "no")
        'add_row_Item_Unit("no", "no", "no", "no", "no", "no", "no")
    End Sub

    Sub add_row_bom_head(no, description, unit, sta)
        data_excelfile.DataGrid_bom_header.ColumnCount = 4
        data_excelfile.DataGrid_bom_header.Columns(0).Name = "No."
        data_excelfile.DataGrid_bom_header.Columns(1).Name = "Description"
        data_excelfile.DataGrid_bom_header.Columns(2).Name = "Unit of measure code"
        data_excelfile.DataGrid_bom_header.Columns(3).Name = "Status"


        data_excelfile.DataGrid_bom_header.Columns(0).Width = 175
        data_excelfile.DataGrid_bom_header.Columns(1).Width = 400
        data_excelfile.DataGrid_bom_header.Columns(2).Width = 150
        data_excelfile.DataGrid_bom_header.Columns(3).Width = 150

        Dim row As String()

        row = New String() {no, description, unit, sta}
        data_excelfile.DataGrid_bom_header.Rows.Add(row)
    End Sub

    Sub add_row_bom_line(Production_BOM_No, Line_No, Version_Code, Type, No, description, unit, Quantity, Position1, Position2, Position3, Production_Lead_Time, Routing_Link_Code, Scrap, Variant_Code, Comment, Starting_Date, Ending_Date, Quantity_per, Ratio)
        data_excelfile.DataGrid_bom_line.ColumnCount = 20
        data_excelfile.DataGrid_bom_line.Columns(0).Name = "Production BOM No"
        data_excelfile.DataGrid_bom_line.Columns(1).Name = "Line No"
        data_excelfile.DataGrid_bom_line.Columns(2).Name = "Version Code"
        data_excelfile.DataGrid_bom_line.Columns(3).Name = "Type"
        data_excelfile.DataGrid_bom_line.Columns(4).Name = "No"
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


        data_excelfile.DataGrid_bom_line.Columns(0).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(1).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(2).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(3).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(4).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(5).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(6).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(7).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(8).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(9).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(10).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(11).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(12).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(13).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(14).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(15).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(16).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(17).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(18).Width = 150
        data_excelfile.DataGrid_bom_line.Columns(19).Width = 150


        Dim row As String()

        row = New String() {Production_BOM_No, Line_No, Version_Code, Type, No, description, unit, Quantity, Position1, Position2, Position3, Production_Lead_Time, Routing_Link_Code, Scrap, Variant_Code, Comment, Starting_Date, Ending_Date, Quantity_per, Ratio}
        data_excelfile.DataGrid_bom_line.Rows.Add(row)
    End Sub


    Sub add_row_Dimension(table_ID, No, Dimension_Code, Dimension_Value_Code, Value_Posting, Table_Name)
        data_excelfile.DataGrid_Default_dimension.ColumnCount = 6
        data_excelfile.DataGrid_Default_dimension.Columns(0).Name = "Table ID"
        data_excelfile.DataGrid_Default_dimension.Columns(1).Name = "No."
        data_excelfile.DataGrid_Default_dimension.Columns(2).Name = "Dimension Code"
        data_excelfile.DataGrid_Default_dimension.Columns(3).Name = "Dimension Value Code"
        data_excelfile.DataGrid_Default_dimension.Columns(0).Name = "Value Posting"
        data_excelfile.DataGrid_Default_dimension.Columns(1).Name = "Table Name"


        data_excelfile.DataGrid_Default_dimension.Columns(0).Width = 175
        data_excelfile.DataGrid_Default_dimension.Columns(1).Width = 400
        data_excelfile.DataGrid_Default_dimension.Columns(2).Width = 150
        data_excelfile.DataGrid_Default_dimension.Columns(3).Width = 150
        data_excelfile.DataGrid_Default_dimension.Columns(4).Width = 150
        data_excelfile.DataGrid_Default_dimension.Columns(5).Width = 150

        Dim row As String()

        row = New String() {table_ID, No, Dimension_Code, Dimension_Value_Code, Value_Posting, Table_Name}
        data_excelfile.DataGrid_Default_dimension.Rows.Add(row)
    End Sub


    Sub add_row_item_master(No, Description, Base_Unit_of_Measure, Price_Unit_Conversion, Inventory_Posting_Group, Costing_Method, Unit_Cost, Reorder_Quantity, Gross_Weight, Net_Weight, Blocked, VAT_Bus_Posting_Gr_Price, Gen_Prod_Posting_Group, VAT_Prod_Posting_Group, Inventory_Value_Zero, Minimum_Order_Quantity, Maximum_Order_Quantity, Safety_Lead_Time, Replenishment_System, Sales_Unit_of_Measure, Purch_Unit_of_Measure, Reordering_Policy, Include_Inventory, Manufacturing_Policy, Item_Category_Code, Product_Group_Code, Item_Trackiผ่าng_Code, Lot_Nos, Lonn_Code, Grade_Code, Gram_Code, cut, widthinch, widthmm, lengthinch, lengthmm, F1_mm, F2_mm, F3_mm, F4_mm, F5_mm, F6_mm, F7_mm, F8_mm, weight_sheet, area_sheet, Shipping_Mark, Drawing_No, Drawing_Rev, Plate_No, roytor, typeblock, area_box, weightbox, areabox_W, areabox_L, areabox_M2, M1, M2, M3, M4, M5, Routing_No, Production_BOM_No, Overhead_Rate)
        data_excelfile.DataGrid_Item_master.ColumnCount = 65
        data_excelfile.DataGrid_Item_master.Columns(0).Name = "No"
        data_excelfile.DataGrid_Item_master.Columns(1).Name = "Descriptio"
        data_excelfile.DataGrid_Item_master.Columns(2).Name = "Base Unit of Measur"
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
        data_excelfile.DataGrid_Item_master.Columns(58).Name = "M1"
        data_excelfile.DataGrid_Item_master.Columns(59).Name = "M1"
        data_excelfile.DataGrid_Item_master.Columns(60).Name = "M1"
        data_excelfile.DataGrid_Item_master.Columns(61).Name = "M1"
        data_excelfile.DataGrid_Item_master.Columns(62).Name = "Routing No."
        data_excelfile.DataGrid_Item_master.Columns(63).Name = "Production BOM No."
        data_excelfile.DataGrid_Item_master.Columns(64).Name = "Overhead Rate"




        Dim row As String()

        row = New String() {No, Description, Base_Unit_of_Measure, Price_Unit_Conversion, Inventory_Posting_Group, Costing_Method, Unit_Cost, Reorder_Quantity, Gross_Weight, Net_Weight, Blocked, VAT_Bus_Posting_Gr_Price, Gen_Prod_Posting_Group, VAT_Prod_Posting_Group, Inventory_Value_Zero, Minimum_Order_Quantity, Maximum_Order_Quantity, Safety_Lead_Time, Replenishment_System, Sales_Unit_of_Measure, Purch_Unit_of_Measure, Reordering_Policy, Include_Inventory, Manufacturing_Policy, Item_Category_Code, Product_Group_Code, Item_Trackiผ่าng_Code, Lot_Nos, Lonn_Code, Grade_Code, Gram_Code, cut, widthinch, widthmm, lengthinch, lengthmm, F1_mm, F2_mm, F3_mm, F4_mm, F5_mm, F6_mm, F7_mm, F8_mm, weight_sheet, area_sheet, Shipping_Mark, Drawing_No, Drawing_Rev, Plate_No, roytor, typeblock, area_box, weightbox, areabox_W, areabox_L, areabox_M2, M1, M2, M3, M4, M5, Routing_No, Production_BOM_No, Overhead_Rate}
        data_excelfile.DataGrid_Item_master.Rows.Add(row)
    End Sub


    Sub add_row_Item_Unit(no, Code, Qty, Length, Width, Height, Weight)
        data_excelfile.DataGrid_Item_unit.ColumnCount = 7
        data_excelfile.DataGrid_Item_unit.Columns(0).Name = "Item No."
        data_excelfile.DataGrid_Item_unit.Columns(1).Name = "Code"
        data_excelfile.DataGrid_Item_unit.Columns(2).Name = "Qty. per Unit of Measure"
        data_excelfile.DataGrid_Item_unit.Columns(3).Name = "Length"
        data_excelfile.DataGrid_Item_unit.Columns(4).Name = "Width"
        data_excelfile.DataGrid_Item_unit.Columns(5).Name = "Height"
        data_excelfile.DataGrid_Item_unit.Columns(6).Name = "Weight"


        data_excelfile.DataGrid_Item_unit.Columns(0).Width = 175
        data_excelfile.DataGrid_Item_unit.Columns(1).Width = 400
        data_excelfile.DataGrid_Item_unit.Columns(2).Width = 150
        data_excelfile.DataGrid_Item_unit.Columns(3).Width = 150
        data_excelfile.DataGrid_Item_unit.Columns(4).Width = 150
        data_excelfile.DataGrid_Item_unit.Columns(2).Width = 150
        data_excelfile.DataGrid_Item_unit.Columns(6).Width = 150

        Dim row As String()

        row = New String() {no, Code, Qty, Length, Width, Height, Weight}
        data_excelfile.DataGrid_Item_unit.Rows.Add(row)
    End Sub

End Class