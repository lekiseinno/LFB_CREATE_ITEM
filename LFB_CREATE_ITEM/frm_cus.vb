Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class frm_cus
    Private Sub btn_browse_file_Click(sender As Object, e As EventArgs) Handles btn_browse_file.Click


        Dim strFolderPath As String = Application.StartupPath + "/myFile/"

        Dim dlg As New OpenFileDialog()
        dlg.Multiselect = False
        dlg.Filter = "Excel Files (*.csv , *.xls , *.xlsx) |*.csv;*.xls;*.xlsx;*.xlsm | All files (*.*)|*.*"



        If dlg.ShowDialog() = DialogResult.OK Then
            '*** Create Folder
            If Not Directory.Exists(strFolderPath) Then
                Directory.CreateDirectory(strFolderPath)
            End If

            '*** Save File
            Dim filePath As String = dlg.FileName
            Dim fileName As String = Path.GetFileName(filePath)
            'MsgBox(filePath)
            txt_pathfile.Text = filePath

            set_data_on_grid(data_cus.DataGrid_Cus, filePath)
        End If

    End Sub



    Sub set_data_on_grid(datagrid, filePath)
        Dim MyConnection As OleDbConnection
        Dim DtSet As DataSet
        Dim MyCommand As OleDbDataAdapter



        'OK
        'MyConnection = New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & filePath & "';Extended Properties='Excel 8.0;HDR=YES;IMEX=1;';")
        MyConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=Excel 12.0;")



        MyCommand = New OleDbDataAdapter("select * from [Sheet1$]", MyConnection)
        MyCommand.TableMappings.Add("Table", "Net-informations.com")
        DtSet = New DataSet
        MyCommand.Fill(DtSet)
        datagrid.DataSource = DtSet.Tables(0)
        MyConnection.Close()
    End Sub


End Class