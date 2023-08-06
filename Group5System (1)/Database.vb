Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Module Database

    Public cn As MySqlConnection
    Public cm As MySqlCommand
    Public dr As MySqlDataReader
    Public User As String
    Public Password As String
    Public status As String = "Paid"
    Public invoice As String


    Sub Connection()



        cn = New MySqlConnection
        With cn
            .ConnectionString = "server=localhost;database=veterinary system;user id=MMresto;password=database; "

        End With

    End Sub

    Private cnn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\programming\Visual Studio 2010\Group5System\Group5System\bin\Debug\database.accdb")

    Public Sub Connect()
        If cnn.State = ConnectionState.Closed Then cnn.Open()

    End Sub

    Public Function InsertUpdateDelete(ByVal sql As String) As Boolean
        Connect()
        Dim cmd As New OleDbCommand(sql, cnn)
        Return cmd.ExecuteNonQuery() > 0
    End Function

    Public Function IsConfirm(ByVal message As String) As Boolean
        Return MessageBox.Show(message, "Confirm ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes
    End Function

    Public Function QueryAsDataTable(ByVal sql As String) As DataTable
        Dim da As New OleDbDataAdapter(sql, cnn)
        Dim ds As New DataSet
        da.Fill(ds, "result")
        Return ds.Tables("result")
    End Function





End Module