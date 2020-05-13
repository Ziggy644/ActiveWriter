Public Class Form14
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or MaskedTextBox1.Text = "" Then
            MsgBox("Please fill in all the fields")
        Else
            Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
            Form1.DataGridView1.Rows(ind).Cells(9).Value = TextBox1.Text & ":bkg:" & MaskedTextBox1.Text
            Me.Close()
        End If
    End Sub

    Private Sub Form14_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = OpenFileDialog1.FileName
        TextBox1.Refresh()
        Dim IMG As New System.IO.FileInfo(OpenFileDialog1.FileName)
        IMG.CopyTo("textures/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName), True)
    End Sub
End Class