Imports System.IO
Public Class Form2
    Public Music() As String
    Private rindex As Integer
    Private Sub loadSongs()
        Dim fileReader As String
        If My.Computer.FileSystem.FileExists("music.txt") Then
        Else
            File.Create("music.txt").Close()
        End If
        fileReader = My.Computer.FileSystem.ReadAllText("music.txt")
        Music = fileReader.Split(New Char() {","})
        For i As Integer = 0 To Music.Length - 1
            DataGridView1.Rows.Add(Music(i))
            DataGridView1.Refresh()
        Next
    End Sub
    Private Sub selectSong()
        OpenFileDialog1.ShowDialog()
        DataGridView1.Rows.Add(System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName))
        Dim MP3F As New FileInfo(OpenFileDialog1.FileName)
        MP3F.CopyTo("music/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName), True)
        DataGridView1.Refresh()
    End Sub
    Private Sub updateSong()
        If My.Computer.FileSystem.FileExists("music/" & DataGridView1.Rows(rindex).Cells(0).Value & ".mp3") Then
            My.Computer.FileSystem.DeleteFile("music/" & DataGridView1.Rows(rindex).Cells(0).Value & ".mp3")
        End If
        OpenFileDialog1.ShowDialog()
        DataGridView1.Rows(rindex).Cells(0).Value = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
        DataGridView1.Refresh()
        Dim MP3F As New FileInfo(OpenFileDialog1.FileName)
        If My.Computer.FileSystem.FileExists("music/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)) Then
            My.Computer.FileSystem.DeleteFile("music/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName))
        End If
        MP3F.CopyTo("music/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName), True)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ComboBox1.SelectedItem = "" Then
            MsgBox("Please fill in all the fields")
        Else
            Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
            If DataGridView1.SelectedCells.Item(0).Value = "" Then
                Form1.DataGridView1.Rows(ind).Cells(0).Value = "none:" & ComboBox1.SelectedItem
            Else
                Form1.DataGridView1.Rows(ind).Cells(0).Value = DataGridView1.SelectedCells.Item(0).Value & ":" & ComboBox1.SelectedItem
            End If
            Dim dbstr(DataGridView1.RowCount) As String
            For i As Integer = 0 To DataGridView1.RowCount - 1
                dbstr(i) = DataGridView1.Rows(i).Cells.Item(0).Value
            Next
            System.IO.File.WriteAllText("music.txt", "")
            My.Computer.FileSystem.WriteAllText("music.txt", String.Join(",", dbstr), True)
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        selectSong()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        rindex = e.RowIndex
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        updateSong()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        loadSongs()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView1.Rows.Remove(DataGridView1.Rows(rindex))
        DataGridView1.Refresh()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class