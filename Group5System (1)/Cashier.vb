Imports MySql.Data.MySqlClient
Imports System.IO


Public Class Cashier
    Dim invoice As String
    Dim i As Integer
    Private Sub Cashier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Enabled = True
        lblinvoice.Text = Date.Now.ToString("yyyMMdd000") & Val(txtadd.Text)
        Button2.Enabled = False
        Cart()
        QTY()
        Adminform.discount()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
        lbldate.Text = Date.Now.ToString("dddd, MMM dd,yyyy ")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Dispose()
        Accessfrm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProductInq.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click



        Dim i As Integer

        Button5.Enabled = False
        If Integer.TryParse(txtadd.Text, i) Then
            i += 1
            txtadd.Text = i.ToString()
            lblinvoice.Text = Date.Now.ToString("yyyMMdd000") & Val(txtadd.Text)
        End If

        If txtadd.Text = "0" Then

            Button2.Enabled = False


        Else

            Button2.Enabled = True

        End If



    End Sub

    Sub Cart()
        Connection()
        DGVcart.Rows.Clear()
        Dim i As Integer
        Dim subTotal As Double
        Dim Tax As Double
        Dim Total As Double

        cn.Open()

        cm = New MySqlCommand("Select*From addtocart", cn)
        dr = cm.ExecuteReader
        While dr.Read

            i += 1
            subTotal += CDbl(dr.Item("Total").ToString)
            Tax = subTotal * 0.12
            Total = subTotal + Tax


            DGVcart.Rows.Add(i, dr.Item("Invoiceno."), dr.Item("Description").ToString, dr.Item("Formula").ToString, dr.Item("Price").ToString, dr.Item("Quantity").ToString, dr.Item("Total").ToString)

            tbSubtotal.Text = Format(subTotal, "₱#,##0.00")
            tbTotal.Text = Format(Total, "₱#,##0.00")
            screen.Text = Format(Total, "₱#,##0.00")
            tbVAT.Text = Format(Tax, "₱#,##0.00")
            Label8.Text = Str(Total)
            Label9.Text = Str(Tax)


        End While
        dr.Close()
        cn.Close()














    End Sub
    Sub QTY()


        Try

            cn.Open()
            cm = New MySqlCommand("Select count(*) from  addtocart", cn)
            TextBox1.Text = Str(cm.ExecuteScalar)
            cn.Close()
        Catch ex As Exception
            cn.Close()
        End Try


    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Chdiscount.ShowDialog()
    End Sub

    Private Sub DGVcart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVcart.CellContentClick
        Dim Del As String = DGVcart.Columns(e.ColumnIndex).Name


        If Del = "Delete" Then

            cn.Open()
            cm = New MySqlCommand("DELETE FROM `addtocart` WHERE Description like '" & DGVcart.Rows(e.RowIndex).Cells(2).Value.ToString & "'", cn)
            cm.ExecuteNonQuery()



            cn.Close()
            MsgBox(" Product Removed From The cart", vbInformation)
            TextBox1.Text = "0"
            Cart()
        End If





    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Settle.txttotal.Text = tbTotal.Text

        Settle.ShowDialog()
    End Sub


End Class