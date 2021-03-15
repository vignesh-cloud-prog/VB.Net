Public Class Form1
    Dim opr1, opr2, res As Double
    Dim op As String
    Dim cleardisp As Boolean


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblDisp.Text = ""
    End Sub


    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        opr1 = LblDisp.Text
        op = "+"
        cleardisp = True

    End Sub

    Private Sub BtnSubs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSubs.Click
        If LblDisp.Text = "" Then
            LblDisp.Text = "-"
        Else
            opr1 = LblDisp.Text
            op = "-"
            cleardisp = True
        End If
    End Sub

    Private Sub BtnMul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMul.Click
        opr1 = LblDisp.Text
        op = "*"
        cleardisp = True
    End Sub

    Private Sub BtnDiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDiv.Click
        opr1 = LblDisp.Text
        op = "/"
        cleardisp = True
    End Sub

    Private Sub BtnClr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClr.Click
        LblDisp.Text = ""
    End Sub

    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click, Btn0.Click, Btn2.Click, Btn3.Click, Btn4.Click, Btn5.Click, Btn6.Click, Btn7.Click, Btn8.Click, Btn9.Click
        If cleardisp Then
            LblDisp.Text = ""
        End If
        cleardisp = False
        LblDisp.Text = LblDisp.Text + sender.text

    End Sub

    Private Sub BtnOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOff.Click
        End

    End Sub

    Private Sub BtnDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDot.Click
        If LblDisp.Text.IndexOf(".") > 0 Then
            Exit Sub
        Else
            LblDisp.Text = LblDisp.Text + sender.text
        End If

    End Sub

    Private Sub BtnEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEqual.Click
        opr2 = LblDisp.Text
        Select Case op
            Case "+"
                res = opr1 + opr2

            Case "-"
                res = opr1 - opr2
            Case "/"
                If opr2 = 0 Then
                    LblDisp.Text = "Divison by zero"
                    Exit Sub
                Else
                    res = opr1 / opr2
                End If
            Case "*"
                res = opr1 * opr2
        End Select
        LblDisp.Text = res
    End Sub
End Class
