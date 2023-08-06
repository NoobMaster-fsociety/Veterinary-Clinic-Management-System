Public Class test

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer

        If Integer.TryParse(txtadd.Text, i) Then
            i += 1
            txtadd.Text = i.ToString()
            Label1.Text = Date.Now.ToString("yyymmdd0000") & Val(txtadd.Text)
        End If
    End Sub

    Private Sub test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = Date.Now.ToString("yyymmdd0000") & Val(txtadd.Text)

    End Sub
End Class