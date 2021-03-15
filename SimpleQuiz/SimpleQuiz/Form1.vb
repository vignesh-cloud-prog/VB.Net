Public Class Form1
    Dim Score As Integer

    Function load()
        BtnQn1.Enabled = True
        BtnQn2.Enabled = True
        BtnQn3.Enabled = True
        BtnQn4.Enabled = True
        BtnQn5.Enabled = True

        GroupBox2.Visible = False
        GroupBox3.Visible = False
        Score = 0

    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load()

    End Sub

    Private Sub BtnQn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQn1.Click
        GroupBox1.Text = BtnQn1.Text
        GroupBox2.Visible = True
        GroupBox3.Visible = False

        LabelQn.Text = "Who is president of india"
        RadioButton1.Text = "Narendra Modi"
        RadioButton2.Text = "Nagaraja s g"
        RadioButton3.Text = "Yadiyurappa"
        RadioButton4.Text = "Nithin gadkari"
        BtnQn1.Enabled = False


    End Sub

    Private Sub BtnQn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQn2.Click
        GroupBox1.Text = BtnQn2.Text
        GroupBox2.Visible = True
        GroupBox3.Visible = False
        LabelQn.Text = "Who is president of india"
        RadioButton1.Text = "Narendra Modi"
        RadioButton2.Text = "Nagaraja s g"
        RadioButton3.Text = "Yadiyurappa"
        RadioButton4.Text = "Nithin gadkari"
        BtnQn2.Enabled = False
    End Sub

    Private Sub BtnQn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQn3.Click
        GroupBox1.Text = BtnQn3.Text
        GroupBox2.Visible = True
        GroupBox3.Visible = False
        LabelQn.Text = "Who is president of india"
        RadioButton1.Text = "Narendra Modi"
        RadioButton2.Text = "Nagaraja s g"
        RadioButton3.Text = "Yadiyurappa"
        RadioButton4.Text = "Nithin gadkari"
        BtnQn3.Enabled = False
    End Sub

    Private Sub BtnQn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQn4.Click
        GroupBox1.Text = BtnQn4.Text
        GroupBox2.Visible = False
        GroupBox3.Visible = True
        LabelQn.Text = "OS stands for"
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Operating System")
        ComboBox1.Items.Add("Operator overloading")
        ComboBox1.Items.Add("Open souce")
        ComboBox1.Items.Add("order of significance ")
        BtnQn4.Enabled = False

    End Sub

    Private Sub BtnQn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQn5.Click
        GroupBox2.Visible = False
        GroupBox3.Visible = True
        GroupBox1.Text = BtnQn5.Text
        LabelQn.Text = "OS stands for"
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Operating System")
        ComboBox1.Items.Add("Operator overloading")
        ComboBox1.Items.Add("Open souce")
        ComboBox1.Items.Add("order of significance ")
        BtnQn5.Enabled = False
    End Sub

    Private Sub BtnScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnScore.Click
        MsgBox("Score is " & Score)

    End Sub

    Private Sub BtnRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestart.Click
        load()

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End

    End Sub

    Private Sub BtnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        Select Case GroupBox1.Text
            Case "Qn1"
                If RadioButton1.Checked Then
                    Score = Score + 20
                End If
            Case "Qn2"
                If RadioButton2.Checked Then
                    Score = Score + 20
                End If
            Case "Qn3"
                If RadioButton3.Checked Then
                    Score = Score + 20
                End If
            Case "Qn4"
                If ComboBox1.SelectedItem = "Operating System" Then
                    Score = Score + 20
                End If
            Case "Qn5"
                If ComboBox1.SelectedItem = "Open souce" Then
                    Score = Score + 20
                End If
        End Select
        GroupBox1.Text = ""
        GroupBox2.Visible = False
        GroupBox3.Visible = False

    End Sub
End Class
