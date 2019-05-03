Public Class frm_item
    Dim item_vat As String '1
    Dim item_lon As String '1
    Dim item_M1 As String  '2
    Dim item_M2 As String  '2
    Dim item_M3 As String  '2
    Dim item_M4 As String  '2
    Dim item_M5 As String  '2
    Dim item_width As String '4 
    Dim item_longs As String '4


    Private Sub frm_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        item_vat = "V" '1
        item_lon = "L" '1
        item_M1 = "M1" '2
        item_M2 = "M2" '2
        item_M3 = "M3" '2
        item_M4 = "M4" '2
        item_M5 = "M5" '2
        item_width = "WIDT" '4 
        item_longs = "LONG" '4


        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs

        cus_item_vat(vat_selected)
        cus_item_lon(lon_selected)
        cus_item_m(M1)
        cus_item_m(M2)
        cus_item_m(M3)
        cus_item_m(M4)
        cus_item_m(M5)



    End Sub

    Sub cus_item_vat(comboname)
        comboname.DisplayMember = "Text"
        comboname.ValueMember = "Value"
        Dim item_V As New DataTable
        item_V.Columns.Add("Text", GetType(String))
        item_V.Columns.Add("Value", GetType(String))
        item_V.Rows.Add(" ", "V")
        item_V.Rows.Add("VAT", "A")
        item_V.Rows.Add("NO VAT", "B")
        item_V.Rows.Add("Example", "E")
        comboname.DataSource = item_V
    End Sub



    Sub cus_item_lon(comboname)
        comboname.DisplayMember = "Text"
        comboname.ValueMember = "Value"
        Dim item_L As New DataTable
        item_L.Columns.Add("Text", GetType(String))
        item_L.Columns.Add("Value", GetType(String))
        item_L.Rows.Add(" ", "L")
        item_L.Rows.Add("A", "A")
        item_L.Rows.Add("B", "B")
        item_L.Rows.Add("C", "C")
        item_L.Rows.Add("AB", "X")
        item_L.Rows.Add("AC", "Y")
        item_L.Rows.Add("BC", "D")
        item_L.Rows.Add("CC", "Z")
        item_L.Rows.Add("EC", "F")
        item_L.Rows.Add("CC", "Z")
        item_L.Rows.Add("CC", "Z")
        comboname.DataSource = item_L
    End Sub


    Sub cus_item_m(comboname)
        comboname.DisplayMember = "Text"
        comboname.ValueMember = "Value"
        Dim item_M As New DataTable
        item_M.Columns.Add("Text", GetType(String))
        item_M.Columns.Add("Value", GetType(String))
        item_M.Rows.Add("", "00")
        item_M.Rows.Add("A125", "A2")
        item_M.Rows.Add("A150", "A4")
        item_M.Rows.Add("A185", "A6")
        item_M.Rows.Add("A230", "A8")
        item_M.Rows.Add("PA125", "A2")
        item_M.Rows.Add("PA150", "A4")
        item_M.Rows.Add("PA185", "A6")
        item_M.Rows.Add("PA230", "A8")
        item_M.Rows.Add("HA125", "A2")
        item_M.Rows.Add("HA150", "A4")
        item_M.Rows.Add("HA185", "A6")
        item_M.Rows.Add("HA230", "A8")
        item_M.Rows.Add("KA112", "AE")
        item_M.Rows.Add("KA125", "A2")
        item_M.Rows.Add("KA150", "A4")
        item_M.Rows.Add("KA185", "A6")
        item_M.Rows.Add("KA225", "AI")
        item_M.Rows.Add("KA230", "A8")
        item_M.Rows.Add("KA270", "BB")
        item_M.Rows.Add("A230", "A8")
        item_M.Rows.Add("A112", "AE")
        item_M.Rows.Add("A125", "A2")
        item_M.Rows.Add("A150", "A4")
        item_M.Rows.Add("A185", "A6")
        item_M.Rows.Add("A225", "AI")
        item_M.Rows.Add("KN125", "A2")
        item_M.Rows.Add("KN150", "A4")
        item_M.Rows.Add("KN185", "A6")
        item_M.Rows.Add("KN230", "A8")
        item_M.Rows.Add("KU125", "U2")
        item_M.Rows.Add("KU150", "U4")
        item_M.Rows.Add("KU185", "U6")
        item_M.Rows.Add("KU230", "U8")
        item_M.Rows.Add("KAC125", "A2")
        item_M.Rows.Add("KAC150", "A4")
        item_M.Rows.Add("KAC185", "A6")
        item_M.Rows.Add("KAC230", "A8")
        item_M.Rows.Add("KH175", "KF")
        item_M.Rows.Add("KH200", "KG")
        item_M.Rows.Add("KH250", "K9")
        item_M.Rows.Add("AU125", "U2")
        item_M.Rows.Add("AU185", "U6")
        item_M.Rows.Add("AU230", "U8")
        item_M.Rows.Add("I125", "I2")
        item_M.Rows.Add("I150", "I4")
        item_M.Rows.Add("I185", "I6")
        item_M.Rows.Add("KQ125", "I2")
        item_M.Rows.Add("KQ150", "I4")
        item_M.Rows.Add("KQ185", "I6")
        item_M.Rows.Add("PI125", "I2")
        item_M.Rows.Add("PI150", "I4")
        item_M.Rows.Add("PI185", "I6")
        item_M.Rows.Add("CI125", "I2")
        item_M.Rows.Add("CI150", "I4")
        item_M.Rows.Add("CI185", "I6")
        item_M.Rows.Add("TPI125", "I2")
        item_M.Rows.Add("TPI150", "I4")
        item_M.Rows.Add("TPI185", "I6")
        item_M.Rows.Add("KI125", "I2")
        item_M.Rows.Add("KI150", "I4")
        item_M.Rows.Add("KI185", "I6")
        item_M.Rows.Add("KD125", "D2")
        item_M.Rows.Add("KD150", "D4")
        item_M.Rows.Add("KD185", "D6")
        item_M.Rows.Add("KD230", "D8")
        item_M.Rows.Add("KJ125", "J2")
        item_M.Rows.Add("KJ150", "J4")
        item_M.Rows.Add("KJ185", "J6")
        item_M.Rows.Add("KJ230", "J8")
        item_M.Rows.Add("KL125", "L2")
        item_M.Rows.Add("KL150", "L4")
        item_M.Rows.Add("KL175", "LF")
        item_M.Rows.Add("KL205", "L7")
        item_M.Rows.Add("KL250", "L9")
        item_M.Rows.Add("KP175", "PF")
        item_M.Rows.Add("KP230", "P8")
        item_M.Rows.Add("KP250", "P9")
        item_M.Rows.Add("KT125", "T2")
        item_M.Rows.Add("KT140", "T3")
        item_M.Rows.Add("KT150", "T4")
        item_M.Rows.Add("KT175", "TF")
        item_M.Rows.Add("KT185", "T6")
        item_M.Rows.Add("KT200", "TG")
        item_M.Rows.Add("KT250", "T9")
        item_M.Rows.Add("KK125", "K2")
        item_M.Rows.Add("KK150", "K4")
        item_M.Rows.Add("KK185", "K6")
        item_M.Rows.Add("KX125", "X2")
        item_M.Rows.Add("KX150", "X4")
        item_M.Rows.Add("MK125", "K2")
        item_M.Rows.Add("MK150", "K4")
        item_M.Rows.Add("MK185", "K6")
        item_M.Rows.Add("M100", "ME")
        item_M.Rows.Add("M105", "M0")
        item_M.Rows.Add("M107", "M0")
        item_M.Rows.Add("M110", "ML")
        item_M.Rows.Add("M115", "M1")
        item_M.Rows.Add("M120", "MM")
        item_M.Rows.Add("M125", "M2")
        item_M.Rows.Add("M127", "MK")
        item_M.Rows.Add("M150", "M4")
        item_M.Rows.Add("M185", "M6")
        item_M.Rows.Add("M190", "MN")
        item_M.Rows.Add("CM105", "M0")
        item_M.Rows.Add("CM107", "M0")
        item_M.Rows.Add("CM115", "M1")
        item_M.Rows.Add("CM125", "M2")
        item_M.Rows.Add("CM150", "M4")
        item_M.Rows.Add("CM185", "M6")
        item_M.Rows.Add("CM127", "MK")
        item_M.Rows.Add("CM100", "ME")
        item_M.Rows.Add("CM110", "ML")
        item_M.Rows.Add("CM120", "MM")
        item_M.Rows.Add("CM190", "MN")
        item_M.Rows.Add("CJ230", "X8")
        item_M.Rows.Add("S150", "S4")
        item_M.Rows.Add("S140", "S3")
        item_M.Rows.Add("S170", "S5")
        item_M.Rows.Add("KS140", "S3")
        item_M.Rows.Add("KS150", "S4")
        item_M.Rows.Add("KS170", "S5")
        item_M.Rows.Add("KA260", "CL")
        item_M.Rows.Add("TK125", "T2")
        item_M.Rows.Add("TK180", "TO")
        item_M.Rows.Add("TK210", "TP")
        item_M.Rows.Add("MG056", "GA")
        item_M.Rows.Add("SB060", "SB")
        item_M.Rows.Add("NP170", "N5")
        item_M.Rows.Add("NP200", "NG")
        item_M.Rows.Add("NP210", "NP")
        item_M.Rows.Add("NP220", "NH")
        item_M.Rows.Add("NP280", "NJ")
        comboname.DataSource = item_M
    End Sub



    Private Sub vat_selected_SelectedIndexChanged(sender As Object, e As EventArgs) Handles vat_selected.SelectedIndexChanged
        item_vat = vat_selected.SelectedValue.ToString()
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub
    Private Sub lon_selected_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lon_selected.SelectedIndexChanged
        item_lon = lon_selected.SelectedValue.ToString()
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub
    Private Sub M1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles M1.SelectedIndexChanged
        item_M1 = M1.SelectedValue.ToString()
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub
    Private Sub M2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles M2.SelectedIndexChanged
        item_M2 = M2.SelectedValue.ToString()
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub
    Private Sub M3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles M3.SelectedIndexChanged
        item_M3 = M3.SelectedValue.ToString()
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub
    Private Sub M4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles M4.SelectedIndexChanged
        item_M4 = M4.SelectedValue.ToString()
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub
    Private Sub M5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles M5.SelectedIndexChanged
        item_M5 = M5.SelectedValue.ToString()
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub
    Private Sub txt_width_TextChanged(sender As Object, e As EventArgs) Handles txt_width.TextChanged
        item_width = txt_width.Text
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub
    Private Sub txt_long_TextChanged(sender As Object, e As EventArgs) Handles txt_long.TextChanged
        item_longs = txt_long.Text
        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub

    Private Sub btn_add_datagrid_item_Click(sender As Object, e As EventArgs) Handles btn_add_datagrid_item.Click

        add_row_item("no", item_vat, item_M5, item_M4, item_M3, item_M2, item_M1, item_lon, item_width, item_longs, txt_itemcode.Text)
    End Sub


    Sub add_row_item(grad, item_vat, item_M5, item_M4, item_M3, item_M2, item_M1, item_lon, item_width, item_longs, txt_itemcode)
        data_item.DataGrid_item.ColumnCount = 12
        data_item.DataGrid_item.Columns(0).Name = "Grade"
        data_item.DataGrid_item.Columns(1).Name = "VAT"
        data_item.DataGrid_item.Columns(2).Name = "M5"
        data_item.DataGrid_item.Columns(3).Name = "M4"
        data_item.DataGrid_item.Columns(4).Name = "M3"
        data_item.DataGrid_item.Columns(5).Name = "M2"
        data_item.DataGrid_item.Columns(6).Name = "M1"
        data_item.DataGrid_item.Columns(7).Name = "Lon"
        data_item.DataGrid_item.Columns(8).Name = "Width"
        data_item.DataGrid_item.Columns(9).Name = "Long"
        data_item.DataGrid_item.Columns(10).Name = "Code"
        data_item.DataGrid_item.Columns(11).Name = "Description"


        data_item.DataGrid_item.Columns(0).Width = 50
        data_item.DataGrid_item.Columns(1).Width = 100
        data_item.DataGrid_item.Columns(2).Width = 100
        data_item.DataGrid_item.Columns(3).Width = 50
        data_item.DataGrid_item.Columns(4).Width = 50
        data_item.DataGrid_item.Columns(5).Width = 50
        data_item.DataGrid_item.Columns(6).Width = 50
        data_item.DataGrid_item.Columns(7).Width = 50
        data_item.DataGrid_item.Columns(8).Width = 100
        data_item.DataGrid_item.Columns(9).Width = 100
        data_item.DataGrid_item.Columns(10).Width = 200
        data_item.DataGrid_item.Columns(11).Width = 200


        Dim row As String()

        row = New String() {grad, item_vat, item_M5, item_M4, item_M3, item_M2, item_M1, item_lon, item_width, item_longs, txt_itemcode}
        data_item.DataGrid_item.Rows.Add(row)
    End Sub

    'Private Sub M1_TextChanged(sender As Object, e As EventArgs) Handles M1.TextChanged
    '    item_M1 = M1.Text
    '    txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    'End Sub

    'Private Sub M2_TextChanged(sender As Object, e As EventArgs) Handles M2.TextChanged
    '    item_M2 = M2.Text
    '    txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    'End Sub

    'Private Sub M3_TextChanged(sender As Object, e As EventArgs) Handles M3.TextChanged
    '    item_vat = M3.Text
    '    txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    'End Sub

    'Private Sub M4_TextChanged(sender As Object, e As EventArgs) Handles M4.TextChanged
    '    item_vat = M4.Text
    '    txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    'End Sub

    'Private Sub M5_TextChanged(sender As Object, e As EventArgs) Handles M5.TextChanged
    '    item_vat = M5.Text
    '    txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    'End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click


        item_vat = "V" '1
        item_lon = "L" '1
        item_M1 = "M1" '2
        item_M2 = "M2" '2
        item_M3 = "M3" '2
        item_M4 = "M4" '2
        item_M5 = "M5" '2
        item_width = "WIDT" '4 
        item_longs = "LONG" '4


        txt_itemcode.Text = item_vat & item_lon & item_M1 & item_M2 & item_M3 & item_M4 & item_M5 & item_width & item_longs
    End Sub

    Private Sub txt_itemcode_TextChanged(sender As Object, e As EventArgs) Handles txt_itemcode.TextChanged

    End Sub
End Class