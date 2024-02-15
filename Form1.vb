Public Class Form1
    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click

        If txtFirstnum.Text = "" Or txtSecondnum.Text = "" Then
            MessageBox.Show("Please complete the entry first.")
        Else
            Try
                Dim firstnum As Integer
                Dim secondnum As Integer

                firstnum = txtFirstnum.Text
                secondnum = txtSecondnum.Text

                lblResult.Text = firstnum / secondnum

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        End If




    End Sub
End Class
