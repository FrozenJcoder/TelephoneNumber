Public Class Form1
    Dim number As Double
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                number = Convert.ToDouble(TextBox1.Text)
            Catch ex As Exception
                MessageBox.Show("Give only numbers")
            End Try

            If TextBox1.Text.Length < 10 Then
                MessageBox.Show("Oops, you need 10 numbers")
            Else
                If IsNumeric(number) Then
                    Dim example As String
                    Dim firstTwoDigits As Double = Double.Parse(number)
                    example = firstTwoDigits.ToString().Substring(0, 2)
                    If example = 69 Then
                        MessageBox.Show("Ok,It's a Greek number")
                    Else
                        MessageBox.Show("It's not a greek number")
                    End If
                End If
            End If
        End If
    End Sub
End Class
