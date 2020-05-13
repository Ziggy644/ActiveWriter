Public Class Form10


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or MaskedTextBox1.Text = "" Or ComboBox1.SelectedItem = "" Then
            MsgBox("Please fill in all the fields")
        Else
            Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
            Form1.DataGridView1.Rows(ind).Cells(5).Value = TextBox1.Text & ":" & MaskedTextBox1.Text & ":" & ComboBox1.SelectedItem
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        TextBox1.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
        TextBox1.Refresh()
        Dim VID As New System.IO.FileInfo(OpenFileDialog1.FileName)
        VID.CopyTo("videos/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName), True)
    End Sub

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class