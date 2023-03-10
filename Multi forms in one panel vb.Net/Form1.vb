Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        menu1.TopLevel = False
        Panel1.Controls.Clear()
        Panel1.Controls.Add(menu1)
        menu1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        menu3.TopLevel = False
        Panel1.Controls.Clear()
        Panel1.Controls.Add(menu3)
        menu3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        menu2.TopLevel = False
        Panel1.Controls.Clear()
        Panel1.Controls.Add(menu2)
        menu2.Show()
    End Sub
End Class
