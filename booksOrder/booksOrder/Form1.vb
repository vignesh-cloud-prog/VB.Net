Public Class Form1
    Dim i, j, n As Integer
    Dim info As String
    Private Sub BtnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnContinue.Click
        n = Val(NoOfBooks.Text)
        If n < 0 Then
            MsgBox("Plz enter positive number")
        End If
        Dim x = 2
        Dim y = 2
        Dim no = 0
        For i = 1 To n
            For j = 1 To 3
                
                no = no + 1
                Dim TextBox As New TextBox
                TextBox.Name = "TextBox" & no
                TextBox.Size = New Size(120, 20)
                TextBox.Location = New Point(x, y + 50)
                MsgBox(TextBox.Name)
                x = x + 150
                GroupBox1.Controls.Add(TextBox)
            Next
            y = y + 50
            x = 2
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
        info = ""
        For i = 1 To n * 3
            info = info & " " & GroupBox1.Controls.Item("TextBox" & i.ToString).Text & Space(5)
            If i Mod 3 = 0 Then
                info = info + vbCrLf

            End If

        Next


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        Label3.Text = "Plz wait order summary is loading" & ProgressBar1.Value.ToString & "%"
        If ProgressBar1.Value = ProgressBar1.Maximum.ToString Then


            ordersummary.Show()
            ordersummary.TxtSummary.Text = "You ordered " & n & " Books" & vbCrLf & "Title          Author          No of copies" & vbCrLf & info
            Timer1.Enabled = False
        End If



    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
