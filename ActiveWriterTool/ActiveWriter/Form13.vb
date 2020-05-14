Public Class Form13

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or MaskedTextBox1.Text = "" Then
            MsgBox("Please fill in all the fields")
        Else
            Dim c As String
            If CheckBox1.Checked Then
                c = "true"
            Else
                c = "false"
            End If
            Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
            Form1.DataGridView1.Rows(ind).Cells(8).Value = c & ":" & TextBox1.Text & ":" & MaskedTextBox1.Text
            Me.Close()
        End If
    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class