Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim num, rev, res, sum As Integer

        If TextBox1.Text = "" Then
            MsgBox("Enter a number")
        
        ElseIf Not IsNumeric(TextBox1.Text) Then
            MsgBox("Enter numbers only")

        ElseIf TextBox1.Text < 0 Then
            MsgBox("Enter positive numbers")

        Else
            num = TextBox1.Text

            While num > 0
                res = num Mod 10
                rev = rev * 10 + res
                sum = sum + res
                num = num / 10

            End While
            TextBox2.Text = sum
            TextBox3.Text = rev

            If TextBox1.Text = TextBox3.Text Then
                Label5.Text = "Palindrome"
            Else
                Label5.Text = "Not palindrome"


            End If
        End If
        
    End Sub
End Class
