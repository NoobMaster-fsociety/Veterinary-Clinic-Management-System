Imports MySql.Data.MySqlClient
Imports System.IO


Public Class frmQty
    Dim Duplicate As Boolean
    Dim Total As Double
    Dim sdate As Date = Date.Now
    Dim Stock As Integer

    Private Sub frmQty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        invoice.Text = Cashier.lblinvoice.Text
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub
    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown


        Try
            Connection()
            If e.KeyCode = Keys.Escape Then

                Me.Dispose()



            ElseIf e.KeyCode = Keys.Enter Then

                If txtQty.Text = String.Empty Or txtQty.Text = "0" Then Return


                If CInt(txtQty.Text) > CInt(tbStock.Text) Then

                    MsgBox("Sorry Invalid Quantity", vbCritical)
                    txtQty.Clear()

                ElseIf CInt(tbStock.Text) >= CInt(txtQty.Text) Then

                    Stock = CInt(tbStock.Text) - CInt(txtQty.Text)
                    computestock()


                    cn.Open()
                    cm = New MySqlCommand("SELECT * FROM `addtocart` WHERE Description  ='" & Desc.Text & "'", cn)
                    dr = cm.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then

                        Duplicate = True

                        dr.Close()
                        cn.Close()

                    Else
                        Duplicate = False
                        dr.Close()
                        cn.Close()

                    End If
                    dr.Close()
                    cn.Close()


                    If Duplicate = True Then
                        cn.Open()
                        cm = New MySqlCommand("Update addtocart set  Quantity = Quantity + @Quantity where Description ='" & Desc.Text & "'", cn)
                        cm.Parameters.AddWithValue("@Quantity", txtQty.Text)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        cn.Open()
                        cm = New MySqlCommand("Update addtocart set Total = Quantity * Price", cn)
                        cm.ExecuteNonQuery()
                        cn.Close()

                        MsgBox("Cart Updated")
                        txtQty.Clear()
                        Me.Dispose()
                        Cashier.Cart()


                    Else
                        Total = Val(tbprice.Text) * Val(txtQty.Text)

                        cn.Open()
                        cm = New MySqlCommand("INSERT INTO addtocart (`Invoiceno.`,`Description`, `Category`, `Formula`, `Price`, `Quantity`, `Total`, `Stock`, `tdate`) VALUES ('" & Cashier.lblinvoice.Text & "','" & Desc.Text & "','" & Categ.Text & "','" & tbformula.Text &
                                      "','" & tbprice.Text & "','" & txtQty.Text & "','" & Total & "','" & tbStock.Text & "',@tdate)", cn)
                        With cm


                            .Parameters.AddWithValue("@tdate", sdate)
                            .ExecuteNonQuery()

                        End With


                        cn.Close()

                        MsgBox("Added To Cart", vbInformation)
                        txtQty.Clear()
                        Cashier.Cart()
                        Cashier.QTY()
                        Me.Dispose()
                    End If




                End If








            End If


        Catch ex As Exception

            MsgBox(ex.Message)

        End Try





    End Sub

    Sub computestock()


        cn.Open()
        cm = New MySqlCommand("UPDATE `Product` SET Price=@Price,Stock=@Stock where Description=@Description", cn)
        With cm


            .Parameters.AddWithValue("@Price", tbprice.Text)
            .Parameters.AddWithValue("@Stock", Stock)
            .Parameters.AddWithValue("@Description", Desc.Text)



            .ExecuteNonQuery()
        End With
        cn.Close()


    End Sub


End Class