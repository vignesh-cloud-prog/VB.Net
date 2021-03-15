<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtbasicpay = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.btnid = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnend = New System.Windows.Forms.Button()
        Me.btncompute = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtnetpay = New System.Windows.Forms.TextBox()
        Me.txttax = New System.Windows.Forms.TextBox()
        Me.txtpf = New System.Windows.Forms.TextBox()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btnfor = New System.Windows.Forms.Button()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.txtgross = New System.Windows.Forms.TextBox()
        Me.txthra = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtda = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtbasicpay)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.btnid)
        Me.GroupBox1.Location = New System.Drawing.Point(60, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 143)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee details"
        '
        'txtbasicpay
        '
        Me.txtbasicpay.Location = New System.Drawing.Point(126, 100)
        Me.txtbasicpay.Name = "txtbasicpay"
        Me.txtbasicpay.Size = New System.Drawing.Size(100, 22)
        Me.txtbasicpay.TabIndex = 5
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(350, 32)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(100, 22)
        Me.txtname.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Bsic pay"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Name"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(173, 37)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(100, 22)
        Me.txtid.TabIndex = 1
        '
        'btnid
        '
        Me.btnid.Location = New System.Drawing.Point(17, 37)
        Me.btnid.Name = "btnid"
        Me.btnid.Size = New System.Drawing.Size(150, 23)
        Me.btnid.TabIndex = 0
        Me.btnid.Text = "Click for employee id"
        Me.btnid.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Location = New System.Drawing.Point(255, 59)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(89, 23)
        Me.btnclear.TabIndex = 3
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnend)
        Me.GroupBox3.Controls.Add(Me.btnclear)
        Me.GroupBox3.Controls.Add(Me.btncompute)
        Me.GroupBox3.Controls.Add(Me.btnadd)
        Me.GroupBox3.Location = New System.Drawing.Point(60, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(536, 126)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Inserting"
        '
        'btnend
        '
        Me.btnend.Location = New System.Drawing.Point(361, 59)
        Me.btnend.Name = "btnend"
        Me.btnend.Size = New System.Drawing.Size(89, 23)
        Me.btnend.TabIndex = 4
        Me.btnend.Text = "End"
        Me.btnend.UseVisualStyleBackColor = True
        '
        'btncompute
        '
        Me.btncompute.Location = New System.Drawing.Point(137, 59)
        Me.btncompute.Name = "btncompute"
        Me.btncompute.Size = New System.Drawing.Size(89, 23)
        Me.btncompute.TabIndex = 2
        Me.btncompute.Text = "Compute"
        Me.btncompute.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(17, 59)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(89, 23)
        Me.btnadd.TabIndex = 1
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtnetpay
        '
        Me.txtnetpay.Location = New System.Drawing.Point(307, 90)
        Me.txtnetpay.Name = "txtnetpay"
        Me.txtnetpay.Size = New System.Drawing.Size(100, 22)
        Me.txtnetpay.TabIndex = 14
        '
        'txttax
        '
        Me.txttax.Location = New System.Drawing.Point(307, 62)
        Me.txttax.Name = "txttax"
        Me.txttax.Size = New System.Drawing.Size(100, 22)
        Me.txttax.TabIndex = 13
        '
        'txtpf
        '
        Me.txtpf.Location = New System.Drawing.Point(307, 25)
        Me.txtpf.Name = "txtpf"
        Me.txtpf.Size = New System.Drawing.Size(100, 22)
        Me.txtpf.TabIndex = 12
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(361, 54)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(89, 23)
        Me.btnlast.TabIndex = 5
        Me.btnlast.Text = "Last record"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnlast)
        Me.GroupBox4.Controls.Add(Me.btnback)
        Me.GroupBox4.Controls.Add(Me.btnfor)
        Me.GroupBox4.Controls.Add(Me.btnfirst)
        Me.GroupBox4.Location = New System.Drawing.Point(60, 403)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(536, 120)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Navigating"
        '
        'btnback
        '
        Me.btnback.Location = New System.Drawing.Point(255, 54)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(89, 23)
        Me.btnback.TabIndex = 4
        Me.btnback.Text = "Backward"
        Me.btnback.UseVisualStyleBackColor = True
        '
        'btnfor
        '
        Me.btnfor.Location = New System.Drawing.Point(137, 54)
        Me.btnfor.Name = "btnfor"
        Me.btnfor.Size = New System.Drawing.Size(89, 23)
        Me.btnfor.TabIndex = 3
        Me.btnfor.Text = "Forward"
        Me.btnfor.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.Location = New System.Drawing.Point(17, 54)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(103, 23)
        Me.btnfirst.TabIndex = 2
        Me.btnfirst.Text = "First Record"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'txtgross
        '
        Me.txtgross.Location = New System.Drawing.Point(93, 90)
        Me.txtgross.Name = "txtgross"
        Me.txtgross.Size = New System.Drawing.Size(100, 22)
        Me.txtgross.TabIndex = 11
        '
        'txthra
        '
        Me.txthra.Location = New System.Drawing.Point(93, 59)
        Me.txthra.Name = "txthra"
        Me.txthra.Size = New System.Drawing.Size(100, 22)
        Me.txthra.TabIndex = 10
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(624, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(583, 290)
        Me.DataGridView1.TabIndex = 9
        '
        'txtda
        '
        Me.txtda.Location = New System.Drawing.Point(93, 22)
        Me.txtda.Name = "txtda"
        Me.txtda.Size = New System.Drawing.Size(100, 22)
        Me.txtda.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(253, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Netpay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Tax"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "PF"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtnetpay)
        Me.GroupBox2.Controls.Add(Me.txttax)
        Me.GroupBox2.Controls.Add(Me.txtpf)
        Me.GroupBox2.Controls.Add(Me.txtgross)
        Me.GroupBox2.Controls.Add(Me.txthra)
        Me.GroupBox2.Controls.Add(Me.txtda)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(615, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(532, 140)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Allowances and deductions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gross"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "HRA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "DA"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 599)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtbasicpay As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents btnid As System.Windows.Forms.Button
    Friend WithEvents btnclear As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnend As System.Windows.Forms.Button
    Friend WithEvents btncompute As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents txtnetpay As System.Windows.Forms.TextBox
    Friend WithEvents txttax As System.Windows.Forms.TextBox
    Friend WithEvents txtpf As System.Windows.Forms.TextBox
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnback As System.Windows.Forms.Button
    Friend WithEvents btnfor As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents txtgross As System.Windows.Forms.TextBox
    Friend WithEvents txthra As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtda As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
