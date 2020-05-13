Public Class Form6
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MaskedTextBox1.Text = "" Then
            MsgBox("Please fill in all the fields")
        Else
            If Form5.pn = True Then
                Form5.positiveCall = MaskedTextBox1.Text
            Else
                Form5.negativeCall = MaskedTextBox1.Text
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class