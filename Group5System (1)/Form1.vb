Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection()
        Label2.Hide()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Me.Pbar.Value = Pbar.Value + 1
        If Pbar.Value >= 100 Then

            Timer1.Stop()
            Me.Hide()
            Accessfrm.ShowDialog()

        End If
        If Pbar.Value >= 70 Then


            Label2.Show()

        End If


    End Sub
End Class
