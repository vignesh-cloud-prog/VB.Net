Public Class Form1
    Dim item As String
    Dim position As Integer

    Private Sub Btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnadd.Click
        item = InputBox("Enter the item to insert")
        ComboBox1.Items.Add(item)
        MsgBox("Item added")
    End Sub

    Private Sub BtnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemove.Click
        item = InputBox("Enter the item to delete")
        If ComboBox1.Items.Contains(item) Then
            ComboBox1.Items.Remove(item)
            MsgBox("item deleted")
        Else
            MsgBox("Sorry item does not exist")
        End If
    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        item = InputBox("Enter the item to search")
        If ComboBox1.Items.Contains(item) Then
            position = ComboBox1.Items.IndexOf(item)
            MsgBox("item is at position" & position + 1)
        Else
            MsgBox("Sorry item does not exist")
        End If
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        ComboBox1.Items.Clear()
        MsgBox("All items cleared")

    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        End

    End Sub
End Class
