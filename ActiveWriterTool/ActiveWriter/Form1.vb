Imports System.IO

Public Class Form1
    Private Sub Init()
        If (Not System.IO.Directory.Exists("music")) Then
            System.IO.Directory.CreateDirectory("music")
        End If
        If (Not System.IO.Directory.Exists("sfx")) Then
            System.IO.Directory.CreateDirectory("sfx")
        End If
        If (Not System.IO.Directory.Exists("textures")) Then
            System.IO.Directory.CreateDirectory("textures")
        End If
        If (Not System.IO.Directory.Exists("videos")) Then
            System.IO.Directory.CreateDirectory("videos")
        End If

    End Sub
    Private Sub saveTable()
        SaveFileDialog1.ShowDialog()
        Dim objrow(DataGridView1.RowCount) As String
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim objcolumn(DataGridView1.ColumnCount) As String
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                If DataGridView1.Rows(i).Cells(j).Value = "" Then
                    objcolumn(j) = "null"
                Else
                    objcolumn(j) = DataGridView1.Rows(i).Cells(j).Value
                End If
            Next
            objrow(i) = String.Join("µ", objcolumn)
        Next
        System.IO.File.WriteAllText(SaveFileDialog1.FileName, "")
        System.IO.File.WriteAllText(SaveFileDialog1.FileName, String.Join(";", objrow))
    End Sub

    Private Sub openTable()
        DataGridView1.Rows.Clear()
        OpenFileDialog1.ShowDialog()
        Dim ob As String = System.IO.File.ReadAllText(OpenFileDialog1.FileName)
        Dim objrows() As String = Split(";", ob)
        For i As Integer = 0 To objrows.Length - 1
            Dim objcells() As String = Split("µ", objrows(i))
            For j As Integer = 0 To objcells.Length - 1
                If objcells(j) = "null" Then
                    DataGridView1.Rows(i).Cells(j).Value = ""
                Else
                    DataGridView1.Rows(i).Cells(j).Value = objcells(j)
                End If
            Next
            DataGridView1.Rows.Add()
        Next
    End Sub

    Private Sub saveStory()
        Dim types(10) As String
        types(0) = "music"
        types(1) = "sfx"
        types(2) = "input"
        types(3) = "options"
        types(4) = "title"
        types(5) = "video"
        types(6) = "txtcolor"
        types(7) = "voice"
        types(8) = "text"
        types(9) = "image"
        types(10) = "image"
        Dim res(DataGridView1.RowCount + 2) As String
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim cr(10) As String
            For j As Integer = 0 To DataGridView1.ColumnCount - 1
                If DataGridView1.Rows(i).Cells.Item(j).Value = "" Then
                    cr(j) = ""
                Else
                    cr(j) = "<" & types(j) & ":" & DataGridView1.Rows(i).Cells.Item(j).Value & ">"
                End If
            Next
            res(i) = "'" & String.Join("", cr) & "', "
        Next
        System.IO.File.WriteAllText("story.txt", "")
        System.IO.File.WriteAllText("story.txt", String.Join(Environment.NewLine, res))
    End Sub

    Private Sub AddRowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRowToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub AddSoundEffectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddSoundEffectToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub RequestUserInputToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RequestUserInputToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub AddUserOptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserOptionsToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub DisplayTitleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayTitleToolStripMenuItem.Click
        Form9.Show()
    End Sub

    Private Sub DisplayVideoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisplayVideoToolStripMenuItem.Click
        Form10.Show()
    End Sub

    Private Sub SetTextColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetTextColorToolStripMenuItem.Click
        Form11.Show()
    End Sub

    Private Sub SetVoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetVoiceToolStripMenuItem.Click
        Form12.Show()
    End Sub

    Private Sub TypeTextToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeTextToolStripMenuItem.Click
        Form13.Show()
    End Sub

    Private Sub BackgrounImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackgrounImageToolStripMenuItem.Click
        Form14.Show()
    End Sub

    Private Sub ForegroundImageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForegroundImageToolStripMenuItem.Click
        Form15.Show()
    End Sub

    Private Sub AddRowToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRowToolStripMenuItem1.Click
        DataGridView1.Rows.Add()
    End Sub

    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        saveStory()
    End Sub

    Private Sub SaveProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveProjectToolStripMenuItem.Click
        saveTable()
    End Sub

    Private Sub OpenProjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProjectToolStripMenuItem.Click
        openTable()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init()
    End Sub
End Class
