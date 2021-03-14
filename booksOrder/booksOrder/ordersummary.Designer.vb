<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ordersummary
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
        Me.TxtSummary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtSummary
        '
        Me.TxtSummary.Location = New System.Drawing.Point(204, 92)
        Me.TxtSummary.Multiline = True
        Me.TxtSummary.Name = "TxtSummary"
        Me.TxtSummary.Size = New System.Drawing.Size(598, 155)
        Me.TxtSummary.TabIndex = 0
        '
        'ordersummary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1052, 357)
        Me.Controls.Add(Me.TxtSummary)
        Me.Name = "ordersummary"
        Me.Text = "ordersummary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSummary As System.Windows.Forms.TextBox
End Class
