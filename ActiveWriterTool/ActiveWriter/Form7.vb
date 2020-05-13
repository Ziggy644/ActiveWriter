Public Class Form7
    Private result As String = ""
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If result = "" Or TextBox1.Text = "" Or MaskedTextBox1.Text = "" Or MaskedTextBox2.Text = "" Then
            MsgBox("Please fill in all fields")
        Else
            If Form5.pn = True Then
                Form5.positiveCall = result & "$" & TextBox1.Text & "$" & MaskedTextBox1.Text & "$" & MaskedTextBox2.Text
            Else
                Form5.negativeCall = result & "$" & TextBox1.Text & "$" & MaskedTextBox1.Text & "$" & MaskedTextBox2.Text
            End If
            Me.Close()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        result = ComboBox1.SelectedIndex
    End Sub

    Private Sub Form7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class