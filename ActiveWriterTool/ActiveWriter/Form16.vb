Public Class Form16

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As String
        If CheckBox1.Checked Then
            c = "true"
        Else
            c = "false"
        End If
        Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
        Form1.DataGridView1.Rows(ind).Cells(8).Value = c
        Form1.DataGridView1.Rows(ind).Cells(9).Value = MaskedTextBox1.Text
        Me.Close()
    End Sub
End Class