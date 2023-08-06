Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Settle
    Dim sdate As Date = Date.Now
    Private Sub Settle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTotalA.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57
            Case 8
            Case 13
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles tbTotalA.KeyDown
        Dim Bayaran As Double
        Dim Bayad As Double
        Dim Sukli As Double

        Try

            Connection()
            If e.KeyCode = Keys.Escape Then

                Me.Dispose()





            ElseIf e.KeyCode = Keys.Enter Then


                If Val(Cashier.Label8.Text) <= Val(tbTotalA.Text) Then

                    cn.Open()
                    cm = New MySqlCommand("INSERT INTO `tblsalepayment`(`Invoiceno.`, `Quantity`, `Total`, `Disc`, `Tax`, `status`, `tdate`) VALUES (@Invoiceno., @Quantity,'" & Cashier.Label8.Text & "',@Disc,@Tax, @status,@tdate)", cn)
                    With cm
                        .Parameters.AddWithValue("@Invoiceno.", Cashier.lblinvoice.Text)
                        .Parameters.AddWithValue("@Quantity", Cashier.TextBox1.Text)

                        .Parameters.AddWithValue("@Disc", Cashier.Label11.Text)
                        .Parameters.AddWithValue("@Tax", Cashier.Label9.Text)
                        .Parameters.AddWithValue("@status", "Paid")
                        .Parameters.AddWithValue("@tdate", Cashier.lbldate.Text + " " + Cashier.lblTime.Text)
                        .ExecuteNonQuery()
                    End With
                    cn.Close()
                    MsgBox("Payment Has Been Made", vbInformation)

                    Bayaran = CDbl(Cashier.Label8.Text)
                    Bayad = CDbl(tbTotalA.Text)
                    Sukli = Bayad - Bayaran


                    btnchange.Text = Format(Sukli, "₱#,##0.00")
                    If MsgBox("Do you want to proceed a new transaction?", vbYesNo + vbQuestion) = MsgBoxResult.Yes Then

                        cn.Open()
                        cm = New MySqlCommand("DELETE FROM `addtocart` where 1", cn)
                        cm.ExecuteNonQuery()


                        MsgBox("Cashier is now Open", MsgBoxStyle.Information)
                        With Cashier
                            .DGVcart.Rows.Clear()
                            .Button5.Enabled = True
                            .Button2.Enabled = False
                            .TextBox1.Text = "0"
                            .tbSubtotal.Text = "0.00"
                            .tbTotal.Text = "0.00"
                            .tbVAT.Text = "0.00"
                            .btndis.Text = "0.00"

                        End With



                        Me.Dispose()


                    End If


                Else

                    MsgBox("Invalid Amount!", MsgBoxStyle.Critical)


                End If
            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

    End Sub


End Class