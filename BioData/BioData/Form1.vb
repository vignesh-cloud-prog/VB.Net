
Imports System.Data.SqlClient
Module module1
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public Sub connect()
        con.ConnectionString = "Data Source=DESKTOP-AVOSAQF\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Pooling=False"
        con.Open()
        cmd.Connection = con

    End Sub

End Module
Public Class Form1
    Dim cmdstr As String
    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim quali, gender As String
        Dim hobby As New List(Of String)
        Dim dob As Date

        Dim checks = {CheckBox1, CheckBox2, CheckBox3, CheckBox4}
        If RadioButton1.Checked Then
            gender = "Male"
        ElseIf RadioButton2.Checked Then
            gender = "Female"
        Else
            MsgBox("Plz, select your gender")
        End If

        dob = DateTimePicker1.Value.ToString


        For Each box In checks
            If box.Checked Then
                hobby.Add(box.Text)
            End If

        Next

        Dim hobbystr = String.Join(",", hobby.ToArray)
        If OtherHobbies.Text <> "" Then
            hobbystr = hobbystr + "," + OtherHobbies.Text

        End If
        quali = ListBox1.SelectedItem

        If quali = "" Then
            MsgBox("Plz select your qualifications")
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or hobbystr = "" Then
            MsgBox("Plz enter the empty field")
        ElseIf (Date.Now.Subtract(DateTimePicker1.Value).Days / 365) < 18 Then

            MsgBox("below 18 years are not allowed")
        Else
            connect()
            cmd.CommandText = "insert into Student(sname,fname,dob,gender,qualification,address,hobbies)  values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & dob & "','" & gender & "','" & quali & "','" & TextBox3.Text & "','" & hobbystr & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Record inserted")
            con.Close()

        End If




    End Sub


    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If (Not Char.IsLetter(e.KeyChar) AndAlso e.KeyChar <> " "c) Then
            e.Handled = True

        End If
    End Sub

    Private Sub Btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnview.Click
        connect()
        cmdstr = "select * from student"
        cmd = New SqlCommand(cmdstr, con)
        adp = New SqlDataAdapter(cmd)
        ds = New DataSet
        adp.Fill(ds, "student")
        DataGridView1.DataMember = "student"
        DataGridView1.DataSource = ds
        con.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox3.Text = ""
        TextBox2.Text = ""
        OtherHobbies.Text = ""
    End Sub
End Class
