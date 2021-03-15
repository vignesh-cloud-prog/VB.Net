Imports System.Data.SqlClient
Module module1
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public Sub connect()
        con.ConnectionString = "Data Source=DESKTOP-AVOSAQF\SQLEXPRESS;Initial Catalog=part_c_telephone;Integrated Security=True;Pooling=False"
        con.Open()
        cmd.Connection = con
    End Sub
End Module

Public Class Form1
    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dr As SqlDataReader
    Dim result As New Object
    Dim cmdstr As String
    Public Sub exist()
        connect()
        cmd.CommandText = "select * from tele where telno = '" & TextBox1.Text & "'"
        result = cmd.ExecuteScalar()
        con.Close()

    End Sub
    Public Sub displaygrid()
        connect()
        cmdstr = "select * from tele"
        cmd = New SqlCommand(cmdstr, con)
        adp = New SqlDataAdapter(cmd)
        ds = New DataSet()
        adp.Fill(ds, "tele")
        DataGridView1.DataMember = "tele"
        DataGridView1.DataSource = ds
        con.Close()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Btnupdate.Enabled = False
        displaygrid()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connect()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("Enter the empty field")
        ElseIf TextBox1.Text < 0 Then
            MsgBox("negative numbers nt allowed")
        Else

            cmd.CommandText = "insert into tele(telno,cname,caddress) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Record inserted")
            con.Close()
            displaygrid()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim tel As Integer = InputBox("Enter the telephone number to be deleted")
        TextBox1.Text = tel
        exist()
        If result Is Nothing Then
            MsgBox("Record does not exiist")
        Else
            connect()
            cmd.CommandText = "delete from tele where telno = '" & TextBox1.Text & "' "
            cmd.ExecuteNonQuery()
            MsgBox("Record deletd")
            con.Close()
            displaygrid()


        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim tel As Integer = InputBox("Enter the telephone number to be deleted" & tel)
        TextBox1.Text = tel
        exist()
        If result Is Nothing Then
            MsgBox("Record does not exiist")
        Else
            connect()
            TextBox1.ReadOnly = True
            cmd.CommandText = "select * from tele where telno = '" & TextBox1.Text & "'"
            dr = cmd.ExecuteReader
            If (dr.HasRows) Then
                dr.Read()
                TextBox2.Text = dr.Item("cname")
                TextBox3.Text = dr.Item("caddress")
                dr.Close()
            End If
            con.Close()
            Btnupdate.Enabled = True

            End If
    End Sub

    Private Sub Btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnupdate.Click
        connect()
        cmd.CommandText = "update tele set cname='" & TextBox2.Text & "', caddress='" & TextBox3.Text & "' where telno= '" & TextBox1.Text & "'"
        cmd.ExecuteNonQuery()
        MsgBox("Record upated")
        con.Close()
        displaygrid()
        Btnupdate.Enabled = False

    End Sub

    Private Sub TextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        exist()
        If TextBox1.Text <> "" Then
            If result Is Nothing Then
                MsgBox("This telephone number is not present in the databse you can add ")
            Else
                MsgBox("Record exist ... dupicate records are not allowed")
            End If
        End If
    End Sub
End Class
