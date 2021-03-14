Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With TreeView1
            .BeginUpdate()
            .Nodes.Add("fruits")
            .Nodes(0).Nodes.Add("Apple")
            .Nodes(0).Nodes(0).Nodes.Add("green apple")
            .Nodes(0).Nodes(0).Nodes.Add("red apple")
            .Nodes.Add("vegitable")
            .Nodes(1).Nodes.Add("Carrot")
            .Nodes(1).Nodes.Add("tomto")
            .Nodes.Add("groceries")
            .Nodes(2).Nodes.Add("rice")
            .Nodes(2).Nodes.Add("sugar")
            .EndUpdate()

        End With
    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        Label2.Text = "You selected " & e.Node.Text
    End Sub

    Private Sub Label2_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Label2.ForeColor = ColorDialog1.Color


        End If
    End Sub
End Class
