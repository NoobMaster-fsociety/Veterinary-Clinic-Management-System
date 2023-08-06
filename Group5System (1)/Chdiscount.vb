Imports MySql.Data.MySqlClient
Imports System.IO



Public Class Chdiscount
    Private Sub Button1_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub cmbdiscount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdiscount.SelectedIndexChanged
        Try



            cn.Open()
            cm = New MySqlCommand("select Discount from tbldis where Discount_Name ='" & cmbdiscount.Text & "'", cn)
            dr = cm.ExecuteReader
            While dr.Read()

                If dr.HasRows Then
                    txtdiscount.Text = dr.Item("Discount").ToString

                End If

            End While



            dr.Close()
            cn.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    Private Sub Chdiscount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If cmbdiscount.Text = "" Then Return
        Dim discount As Double
        Dim netsubtotal As Double
        Dim Total As Double
        Dim subTotal As Double
        Dim Tax As Double


        With Cashier

            cn.Open()

            cm = New MySqlCommand("Select*From addtocart", cn)
            dr = cm.ExecuteReader
            While dr.Read


                subTotal += CDbl(dr.Item("Total").ToString)
                Tax = subTotal * 0.12
                Total = subTotal + Tax
                discount = Val(txtdiscount.Text) / 100
                netsubtotal = subTotal * discount

                .btndis.Text = Format(netsubtotal, "₱#,##0.00")
                Total = subTotal - netsubtotal + Tax
                .tbTotal.Text = Format(Total, "₱#,##0.00")




                .tbSubtotal.Text = Format(subTotal, "₱#,##0.00")
                .tbTotal.Text = Format(Total, "₱#,##0.00")
                .screen.Text = Format(Total, "₱#,##0.00")
                .tbVAT.Text = Format(Tax, "₱#,##0.00")
                .Label8.Text = Str(Total)
                .Label11.Text = Str(netsubtotal)


            End While
            dr.Close()
            cn.Close()




        End With



        Me.Dispose()
        txtdiscount.Clear()


    End Sub


End Class