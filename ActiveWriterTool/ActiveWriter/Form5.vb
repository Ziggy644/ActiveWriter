Public Class Form5
    Public pn As Boolean = True
    Public positiveCall As String = "null$null"
    Public negativeCall As String = "null$null"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        pn = True
        If ComboBox1.SelectedItem = "confirm" Then
            Form6.Show()
        ElseIf ComboBox1.SelectedItem = "skip" Then
            Form7.Show()
        ElseIf ComboBox1.SelectedItem = "stop" Then
            Form8.Show()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "continue" Then
            Button1.Enabled = False
        ElseIf ComboBox1.SelectedItem = "confirm" Then
            Button1.Enabled = True
        ElseIf ComboBox1.SelectedItem = "skip" Then
            Button1.Enabled = True
        ElseIf ComboBox1.SelectedItem = "stop" Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text Or ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" & negativeCall = "null$null" Then
            MsgBox("Please fill in all the fields")
        Else
            Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
            Form1.DataGridView1.Rows(ind).Cells(3).Value = TextBox1.Text & ":" & TextBox2.Text & ":" & TextBox3.Text & ":" & ComboBox1.SelectedItem & ":" & ComboBox2.SelectedItem & ":" & positiveCall & ":" & negativeCall
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        pn = False
        If ComboBox2.SelectedItem = "confirm" Then
            Form6.Show()
        ElseIf ComboBox2.SelectedItem = "skip" Then
            Form7.Show()
        ElseIf ComboBox2.SelectedItem = "stop" Then
            Form8.Show()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem = "continue" Then
            Button2.Enabled = False
        ElseIf ComboBox2.SelectedItem = "confirm" Then
            Button2.Enabled = True
        ElseIf ComboBox2.SelectedItem = "skip" Then
            Button2.Enabled = True
        ElseIf ComboBox2.SelectedItem = "stop" Then
            Button2.Enabled = True
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class