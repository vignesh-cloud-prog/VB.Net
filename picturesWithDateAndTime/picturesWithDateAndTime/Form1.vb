Public Class Form1
    Dim i As Integer
    Dim greet As String

    Dim pic() As String = {"C:\BCA\3rd sem\Lab\VB_Dot_Net\images\photo1.jpg", "C:\BCA\3rd sem\Lab\VB_Dot_Net\images\photo2.jpg", "C:\BCA\3rd sem\Lab\VB_Dot_Net\images\photo3.jpg", "C:\BCA\3rd sem\Lab\VB_Dot_Net\images\photo4.jpg", "C:\BCA\3rd sem\Lab\VB_Dot_Net\images\photo5.jpg"}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        Timer1.Interval = 1000
        Timer2.Interval = 5000
        Timer1.Enabled = True
        Timer2.Enabled = True
        i = 0
        PictureBox1.Image = Image.FromFile(pic(i))
        TextBox1.Text = DateTimePicker1.Value.ToShortDateString
        If DateTimePicker1.Value.Hour <= 12 Then
            greet = "GOOD MORNING"
        ElseIf DateTimePicker1.Value.Hour > 12 Then
            greet = "GOOD AFTERNOON"
        ElseIf DateTimePicker1.Value.Hour <= 19 Then
            greet = "GOOD EVENING"
        Else
            greet = "GOOD NIGHT"

        End If

        TextBox3.Text = greet
        VScrollBar1.Minimum = 8

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TextBox2.Text = Date.Now.ToString("hh:mm:ss")
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        i = i + 1
        PictureBox1.Image = Image.FromFile(pic(i))
        If i >= 4 Then
            i = 0
        End If
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim r, g, b As Integer
        r = HScrollBar1.Value
        g = HScrollBar2.Value
        b = HScrollBar3.Value
        TextBox3.ForeColor = Color.FromArgb(r, g, b)
    End Sub

    Private Sub HScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar2.Scroll
        Dim r, g, b As Integer
        r = HScrollBar1.Value
        g = HScrollBar2.Value
        b = HScrollBar3.Value
        TextBox3.ForeColor = Color.FromArgb(r, g, b)
    End Sub

    Private Sub HScrollBar3_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar3.Scroll
        Dim r, g, b As Integer
        r = HScrollBar1.Value
        g = HScrollBar2.Value
        b = HScrollBar3.Value
        TextBox3.ForeColor = Color.FromArgb(r, g, b)
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        TextBox3.Font = New Font(TextBox3.Font.Style, VScrollBar1.Value)
    End Sub
End Class
