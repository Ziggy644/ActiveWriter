Public Class Form4
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please fill in all the fields")
        Else
            Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
            Form1.DataGridView1.Rows(ind).Cells(2).Value = TextBox2.Text & ":" & TextBox1.Text
            Me.Close()
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class