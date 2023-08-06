Imports MySql.Data.MySqlClient
Imports System.IO

Public Class ProductInq




    Private Sub ProductInq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection()
        productinq()
        Autocomplete()

    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        If TextBox1.Text = "🔍Search Barcode" Then



            TextBox1.Text = ""
            TextBox1.ForeColor = Color.Black


        End If

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then



            TextBox1.Text = "🔍Search Barcode"
            TextBox1.ForeColor = Color.Silver


        End If
    End Sub

    Sub productinq()

        Connection()
        DataGridView1.Rows.Clear()
        Dim i As Integer


        cn.Open()

        cm = New MySqlCommand("Select*From product", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1

            DataGridView1.Rows.Add(i, dr.Item("Barcode").ToString, dr.Item("Description").ToString, dr.Item("Status").ToString + "mg", dr.Item("Category"), dr.Item("Price").ToString, dr.Item("Stock").ToString)


        End While
        dr.Close()
        cn.Close()





    End Sub
    Sub Autocomplete()
        cn.Open()
        cm = New MySqlCommand("Select * from product", cn)
        Dim ds As New DataSet
        Dim da As New MySqlDataAdapter(cm)
        da.Fill(ds, "Barcode")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            col.Add(ds.Tables(0).Rows(i)("Barcode").ToString)

        Next
        cn.Close()
        TextBox1.AutoCompleteSource = AutoCompleteSource.CustomSource
        TextBox1.AutoCompleteCustomSource = col
        TextBox1.AutoCompleteMode = AutoCompleteMode.Suggest










    End Sub

    Sub search()

        Connection()
        DataGridView1.Rows.Clear()
        Dim i As Integer


        cn.Open()

        cm = New MySqlCommand("Select*From product where Barcode = '" & TextBox1.Text & "'", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1

            DataGridView1.Rows.Add(i, dr.Item("Barcode").ToString, dr.Item("Description").ToString, dr.Item("Status").ToString, dr.Item("Category"), dr.Item("Price").ToString, dr.Item("Stock").ToString)


        End While
        dr.Close()
        cn.Close()


    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        Dim C As String = DataGridView1.Columns(e.ColumnIndex).Name
        Try


            If C = "Cart" Then
                With frmQty

                    cn.Open()
                    cm = New MySqlCommand("Select*from `product` where Description Like'" & DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
            dr = cm.ExecuteReader
                    While dr.Read


                        .Desc.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                        .tbformula.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                        .Categ.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                        .tbprice.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
                        .tbStock.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString


                    End While
                    dr.Close()
                    cn.Close()


                    .ShowDialog()
                End With


            End If





        Catch ex As Exception

        End Try





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        search()
    End Sub
End Class