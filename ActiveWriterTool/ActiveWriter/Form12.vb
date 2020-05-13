Public Class Form12

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Please fill in all the fields")
        Else
            Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
            Form1.DataGridView1.Rows(ind).Cells(7).Value = ComboBox1.SelectedItem
            Me.Close()
        End If
    End Sub

    Private Sub Form12_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class