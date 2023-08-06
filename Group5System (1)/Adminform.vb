Imports MySql.Data.MySqlClient
Imports System.IO




Public Class Adminform
    Dim sdate As Date = Date.Now

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectTab(1)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ERegistration.btnupdate.Enabled = False
        ERegistration.ShowDialog()
    End Sub


    Sub loadRecords()
        Connection()

        DataGridView1.Rows.Clear()
        Dim i As Integer


        cn.Open()

        cm = New MySqlCommand("Select*From employeedata", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1

            DataGridView1.Rows.Add(i, dr.Item("EmployeeID").ToString, dr.Item("FirstName").ToString, dr.Item("Middle Name").ToString, dr.Item("Last Name").ToString, dr.Item("Birthdate").ToString, dr.Item("Gender").ToString, dr.Item("Address").ToString, dr.Item("Status").ToString, dr.Item("Position").ToString)


        End While
        dr.Close()
        cn.Close()

        For i = 0 To DataGridView1.Rows.Count - 1


        Next
       


    End Sub






    Private Sub Adminform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadRecords()
        loadproduct()
        loaddiscount()
        Connection()
        Autocomplete1()
        Autocomplete2()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Dispose()
        Accessfrm.ShowDialog()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim edit As String = DataGridView1.Columns(e.ColumnIndex).Name

        If edit = "ColEdit" Then
            With ERegistration
                .tbdate.Show()
                cn.Open()
                cm = New MySqlCommand("Select image from `employeedata` where `EmployeeID` like'" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
                    Dim Array(CInt(len)) As Byte
                    dr.GetBytes(0, 0, Array, 0, CInt(len))
                    Dim ms As New MemoryStream(Array)
                    Dim bitmap As New System.Drawing.Bitmap(ms)
                    .browse.Image = bitmap

                    .empnum.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                    .tbFrstN.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                    .tblMI.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                    .tblstN.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                    .tbdate.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                    .cmbSex.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
                    .tbAddress.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
                    .Mstatus.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
                    .tbpos.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString


                End While
                dr.Close()
                cn.Close()


                .btnsave.Enabled = False
                .btnupdate.Enabled = True

                .DD.Hide()
                .MM.Hide()
                .yy.Hide()
                .tbFrstN.Enabled = False
                .tblMI.Enabled = False
                .tblstN.Enabled = False
                .cmbSex.Enabled = False
                .tbdate.Enabled = False


                .ShowDialog()
            End With
        ElseIf edit = "ColDel" Then
            If MsgBox("Delete This Record?", vbYesNo) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("Delete From `employeedata` where `EmployeeID` like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()



                cn.Close()
                cn.Open()
                cm = New MySqlCommand("Delete From `loginform` where `EmployeeID` like '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                cm.ExecuteNonQuery()


                MsgBox("Record HAs been Deleted Succesfully", vbInformation)
                loadproduct()


            End If






        End If

    End Sub
    Sub loadproduct()


        dgvproduct.Rows.Clear()
        Dim i As Integer


        cn.Open()

        cm = New MySqlCommand("Select*From product", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1

            dgvproduct.Rows.Add(i, dr.Item("PID"), dr.Item("Barcode").ToString, dr.Item("Description").ToString, dr.Item("Status").ToString, dr.Item("Category").ToString, dr.Item("Price").ToString, dr.Item("Stock").ToString)


        End While
        dr.Close()
        cn.Close()






    End Sub
    Sub discount()


        Chdiscount.cmbdiscount.Items.Clear()

        cn.Open()
        cm = New MySqlCommand("Select * from tbldis", cn)
        dr = cm.ExecuteReader
        While dr.Read

            Chdiscount.cmbdiscount.Items.Add(dr.Item("Discount_Name").ToString)



        End While



        dr.Close()
        cn.Close()


    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Create_Product.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(0)
        loadproduct()
    End Sub

    Private Sub dgvproduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvproduct.CellContentClick
        Connection()
        Dim edit As String = dgvproduct.Columns(e.ColumnIndex).Name

        If edit = "Edit" Then
            With Create_Product
                cn.Open()
                cm = New MySqlCommand("Select Description from `product` where `PID` like'" & dgvproduct.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                While dr.Read
                    .TextBox1.Text = dgvproduct.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtProductID.Text = dgvproduct.Rows(e.RowIndex).Cells(2).Value.ToString
                    .txtdescription.Text = dgvproduct.Rows(e.RowIndex).Cells(3).Value.ToString
                    .cmbCategory.Text = dgvproduct.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtPrice.Text = dgvproduct.Rows(e.RowIndex).Cells(6).Value.ToString
                    .txtstock.Text = dgvproduct.Rows(e.RowIndex).Cells(7).Value.ToString
                    .txtformulation.Text = dgvproduct.Rows(e.RowIndex).Cells(4).Value.ToString

                End While
                dr.Close()
                cn.Close()



                .btnsave.Enabled = False
                .btnupdate.Enabled = True


                .ShowDialog()
            End With
        ElseIf edit = "delete" Then



            With productremove
                cn.Open()
                cm = New MySqlCommand("Select Description from `product` where `PID` like'" & dgvproduct.Rows(e.RowIndex).Cells(1).Value.ToString & "'", cn)
                dr = cm.ExecuteReader
                While dr.Read

                    .TextBox1.Text = dgvproduct.Rows(e.RowIndex).Cells(1).Value.ToString
                    .txtdescription.Text = dgvproduct.Rows(e.RowIndex).Cells(2).Value.ToString
                    .cmbCategory.Text = dgvproduct.Rows(e.RowIndex).Cells(3).Value.ToString
                    .txtPrice.Text = dgvproduct.Rows(e.RowIndex).Cells(4).Value.ToString
                    .txtstock.Text = dgvproduct.Rows(e.RowIndex).Cells(5).Value.ToString
                    .txtProductID.Text = " 2021000" + .TextBox1.Text
                End While
                dr.Close()
                cn.Close()



                .ShowDialog()
            End With




        End If


    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click

        Try
            If MsgBox("Save This New Discount", vbYesNo + vbQuestion) = vbYes Then
                cn.Open()
                cm = New MySqlCommand("INSERT INTO `tbldis`(`Discount_Name`, `Discount`, `tdate`) VALUES('" & txtDisName.Text & "', '" & txtDIS.Text & "', '" & sdate & "')", cn)


                cm.ExecuteNonQuery()

                cn.Close()

                MsgBox("Discount Has Been Save")
                txtDisName.Clear()
                txtDIS.Clear()
                txtDisName.Focus()
                loaddiscount()
            End If


        Catch ex As Exception

            cn.Close()
            MsgBox(ex.Message, vbCritical)


        End Try


    End Sub

    Sub loaddiscount()
        DgvDis.Rows.Clear()
        Dim i As Integer


        cn.Open()

        cm = New MySqlCommand("Select*From tblDis", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1

            DgvDis.Rows.Add(i, dr.Item("Discount_Name"), dr.Item("Discount").ToString + "%", dr.Item("tdate").ToString)


        End While
        dr.Close()
        cn.Close()

        For i = 0 To DgvDis.Rows.Count - 1

            Dim r As DataGridViewRow = DgvDis.Rows(i)
            r.Height = 30

        Next
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "🔍Search Product" Then



            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black


        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then



            TextBox1.Text = "🔍Search Product"
            TextBox1.ForeColor = Color.Silver


        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        search()
        TextBox1.Clear()
    End Sub
    Sub search()

        Connection()
        dgvproduct.Rows.Clear()
        Dim i As Integer


        cn.Open()

        cm = New MySqlCommand("Select*From product where Description = '" & TextBox1.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1

            dgvproduct.Rows.Add(i, dr.Item("PID"), dr.Item("Barcode").ToString, dr.Item("Description").ToString, dr.Item("Status").ToString, dr.Item("Category").ToString, dr.Item("Price").ToString, dr.Item("Stock").ToString)


        End While
        dr.Close()
        cn.Close()


    End Sub
    Sub searchemp()

        Connection()
        DataGridView1.Rows.Clear()
        Dim i As Integer


        cn.Open()

        cm = New MySqlCommand("Select*From employeedata where FirstName = '" & TextBox2.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1

            DataGridView1.Rows.Add(i, dr.Item("EmployeeID").ToString, dr.Item("FirstName").ToString, dr.Item("Middle Name").ToString, dr.Item("Last Name").ToString, dr.Item("Birthdate").ToString, dr.Item("Gender").ToString, dr.Item("Address").ToString, dr.Item("Status").ToString, dr.Item("Position").ToString)


        End While
        dr.Close()
        cn.Close()


    End Sub

    Sub Autocomplete1()
        cn.Open()
        cm = New MySqlCommand("Select * from product", cn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "Product")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Description").ToString)

        Next
        cn.Close()
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox1.AutoCompleteCustomSource = col
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest










    End Sub
    Sub Autocomplete2()
        cn.Open()
        cm = New MySqlCommand("Select * from employeedata", cn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "FirstName")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("FirstName").ToString)

        Next
        cn.Close()
        TextBox2.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox2.AutoCompleteCustomSource = col
        TextBox2.AutoCompleteMode = AutoCompleteMode.Suggest










    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        If TextBox2.Text = "🔍Search Employee" Then



            TextBox2.Text = ""
            TextBox2.ForeColor = Color.Black


        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then



            TextBox2.Text = "🔍Search Employee"
            TextBox2.ForeColor = Color.Silver


        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        searchemp()
        TextBox2.Clear()
    End Sub
End Class