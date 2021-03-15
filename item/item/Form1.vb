
Imports System.Data.SqlClient
Module module1
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public Sub connect()
        con.Close()

        con.ConnectionString = "Data Source=DESKTOP-AVOSAQF\SQLEXPRESS;Initial Catalog=part_c_4;Integrated Security=True;Pooling=False"
        con.Open()
        cmd.Connection = con

    End Sub
End Module
Public Class Form1

    Dim adp As New SqlDataAdapter
    Dim ds As New DataSet
    Dim cmdstr As String

    Public Sub displaygrid()
        Dim rec As Integer
        cmd = New SqlCommand(cmdstr, con)
        adp = New SqlDataAdapter(cmd)
        ds = New DataSet
        rec = adp.Fill(ds, "item")
        If rec = 0 Then
            MsgBox("This item is not present in the database")
        Else
            DataGridView1.DataMember = "item"
            DataGridView1.DataSource = ds



        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        con.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.Enabled = False

    End Sub

    Private Sub Btnend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnend.Click
        End

    End Sub

    Private Sub Btninsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btninsert.Click
        connect()
        If Val(TextBox1.Text <= 0) Or Val(TextBox3.Text <= 0) Or Val(TextBox4.Text <= 0) Then
            MsgBox("Plz enter positive and non zero numbers")

            Exit Sub

        End If
        cmd.CommandText = "insert into items(itemno,name,qty,unitprice)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("Record inserted")
        con.Close()

    End Sub

    Private Sub Btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncancel.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Dim itemnum As String
        itemnum = InputBox("Enter the item number to be searched")
        connect()
        cmdstr = "select * from items where itemno=" & itemnum
        displaygrid()
        con.Close()


    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        connect()
        cmdstr = "select * from items where qty > 100"
        displaygrid()
        con.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        connect()
        cmdstr = "select * from items where qty <20 or unitprice>=100"
        displaygrid()
        con.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged
        connect()
        cmdstr = "select * from items "
        displaygrid()
        con.Close()
    End Sub

    Private Sub Btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnfirst.Click
        BindingContext(ds, "item").Position = 0

    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlast.Click
        BindingContext(ds, "item").Position = BindingContext(ds, "item").Count - 1

    End Sub

    Private Sub Ntnfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ntnfor.Click
        If BindingContext(ds, "item").Position = BindingContext(ds, "item").Count - 1 Then
            MsgBox("Can't move forward")
        Else
            BindingContext(ds, "item").Position = BindingContext(ds, "item").Position + 1

        End If
    End Sub

    Private Sub Btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnback.Click
        If BindingContext(ds, "item").Position = 0 Then
            MsgBox("Can't move backward")
        Else
            BindingContext(ds, "item").Position = BindingContext(ds, "item").Position - 1

        End If
    End Sub
End Class
