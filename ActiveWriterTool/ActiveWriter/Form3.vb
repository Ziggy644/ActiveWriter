Imports System.IO
Public Class Form3
    Public SFX() As String
    Private rindex As Integer
    Private Sub loadSFX()
        Dim fileReader As String
        If My.Computer.FileSystem.FileExists("sfx.txt") Then
        Else
            File.Create("sfx.txt").Close()
        End If
        fileReader = My.Computer.FileSystem.ReadAllText("sfx.txt")
        SFX = fileReader.Split(New Char() {","})
        For i As Integer = 0 To SFX.Length - 1
            DataGridView1.Rows.Add(SFX(i))
            DataGridView1.Refresh()
        Next
    End Sub
    Private Sub selectSFX()
        OpenFileDialog1.ShowDialog()
        DataGridView1.Rows.Add(System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName))
        DataGridView1.Refresh()
        Dim SFXF As New FileInfo(OpenFileDialog1.FileName)
        SFXF.CopyTo("sfx/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName), True)
    End Sub
    Private Sub updateSFX()
        If My.Computer.FileSystem.FileExists("sfx/" & DataGridView1.Rows(rindex).Cells(0).Value & ".wav") Then
            My.Computer.FileSystem.DeleteFile("sfx/" & DataGridView1.Rows(rindex).Cells(0).Value & ".wav")
        End If
        OpenFileDialog1.ShowDialog()
        DataGridView1.Rows(rindex).Cells(0).Value = System.IO.Path.GetFileNameWithoutExtension(OpenFileDialog1.FileName)
        DataGridView1.Refresh()
        Dim MP3F As New FileInfo(OpenFileDialog1.FileName)
        If My.Computer.FileSystem.FileExists("sfx/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)) Then
            My.Computer.FileSystem.DeleteFile("sfx/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName))
        End If
        MP3F.CopyTo("sfx/" & System.IO.Path.GetFileName(OpenFileDialog1.FileName), True)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ind As Integer = Form1.DataGridView1.CurrentRow.Index
        If DataGridView1.SelectedCells.Item(0).Value = "" Then
            Form1.DataGridView1.Rows(ind).Cells(1).Value = "none"
        Else
            Form1.DataGridView1.Rows(ind).Cells(1).Value = DataGridView1.SelectedCells.Item(0).Value
        End If
        Dim dbstr(DataGridView1.RowCount) As String
        For i As Integer = 0 To DataGridView1.RowCount - 1
            dbstr(i) = DataGridView1.Rows(i).Cells.Item(0).Value
        Next
        System.IO.File.WriteAllText("sfx.txt", "")
        My.Computer.FileSystem.WriteAllText("sfx.txt", String.Join(",", dbstr), True)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        selectSFX()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        rindex = e.RowIndex
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DataGridView1.Rows.Remove(DataGridView1.Rows(rindex))
        DataGridView1.Refresh()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        updateSFX()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        loadSFX()
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class