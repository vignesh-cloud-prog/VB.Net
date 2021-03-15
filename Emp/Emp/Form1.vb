Imports System.Data.SqlClient

Module module1
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public Sub connect()
        con.ConnectionString = "Data Source=DESKTOP-AVOSAQF\SQLEXPRESS;Initial Catalog=Part_C_3_Emp;Integrated Security=True;Pooling=False"
        con.Open()
        cmd.Connection = con

    End Sub
End Module



Public Class Form1
    Dim adp As SqlDataAdapter
    Dim ds As DataSet
    Public Sub autogenerate()
        connect()
        Dim num As Integer
        cmd.CommandText = "select max(empcode) from empl"
        If IsDBNull(cmd.ExecuteScalar) Then
            num = 1001
        Else
            num = cmd.ExecuteScalar + 1
            
        End If
        txtid.Text = num
        con.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox2.Visible = False
        btnadd.Enabled = False

    End Sub

    Private Sub btnid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnid.Click
        autogenerate()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        connect()
        cmd.CommandText = "insert into empl(empcode,empname,basicpay,da,hra,pf ,gross,tax,netpay) values('" & txtid.Text & "','" & txtname.Text & "','" & txtbasicpay.Text & "','" & txtda.Text & "','" & txthra.Text & "','" & txtpf.Text & "','" & txtgross.Text & "','" & txttax.Text & "','" & txtnetpay.Text & "')"
        cmd.ExecuteNonQuery()
        MsgBox("record inserted")
        con.Close()
        connect()
        cmd.CommandText = "select * from empl"
        adp = New SqlDataAdapter(cmd)
        ds = New DataSet
        adp.Fill(ds, "emp")
        DataGridView1.DataMember = "emp"
        DataGridView1.DataSource = ds
        con.Close()
        btnadd.Enabled = False



    End Sub

    Private Sub btncompute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncompute.Click
        Dim basicpay, da, hra, pf, gross, tax, netpay As Decimal

        If txtname.Text = "" Or txtbasicpay.Text = "" Or txtid.Text = "" Then
            MsgBox("Enter all the fields")
            Exit Sub

        End If
        basicpay = Val(txtbasicpay.Text)
        If basicpay < 0 Then
            MsgBox("Basicpay should be positive")
            Exit Sub

        End If
        If basicpay > 20000 Then
            da = basicpay * 0.4
        Else
            da = basicpay * 0.3
        End If
        hra = basicpay * 0.1
        gross = basicpay + da + hra
        pf = gross * 0.12
        netpay = gross - (pf + tax)
        GroupBox2.Visible = True
        txtda.Text = da
        txthra.Text = hra
        txtgross.Text = gross
        txtpf.Text = pf
        txttax.Text = tax
        txtnetpay.Text = netpay

        For Each tb As TextBox In GroupBox2.Controls.OfType(Of TextBox)()
            tb.ReadOnly = True

        Next
        btnadd.Enabled = True

    End Sub

    Private Sub btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfirst.Click
        BindingContext(ds, "emp").Position = 0
    End Sub

    Private Sub btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlast.Click
        BindingContext(ds, "emp").Position = BindingContext(ds, "emp").Count - 1
    End Sub

    Private Sub btnfor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfor.Click
        If BindingContext(ds, "emp").Position = BindingContext(ds, "emp").Count - 1 Then
            MsgBox("cant move further")
        Else
            BindingContext(ds, "emp").Position = BindingContext(ds, "emp").Position + 1

        End If
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        If BindingContext(ds, "emp").Position = 0 Then
            MsgBox("cant move further")
        Else
            BindingContext(ds, "emp").Position = BindingContext(ds, "emp").Position - 1

        End If
    End Sub
End Class
