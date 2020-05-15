<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddSoundEffectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RequestUserInputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddUserOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisplayTitleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DisplayVideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetTextColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SetVoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TypeTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BackgrounImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ForegroundImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddRowToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.TypewriterOptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1165, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem, Me.OpenProjectToolStripMenuItem, Me.SaveProjectToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem})
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SaveAsToolStripMenuItem.Text = "run"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
        Me.ExportToolStripMenuItem.Text = "export"
        '
        'OpenProjectToolStripMenuItem
        '
        Me.OpenProjectToolStripMenuItem.Name = "OpenProjectToolStripMenuItem"
        Me.OpenProjectToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.OpenProjectToolStripMenuItem.Text = "open project"
        '
        'SaveProjectToolStripMenuItem
        '
        Me.SaveProjectToolStripMenuItem.Name = "SaveProjectToolStripMenuItem"
        Me.SaveProjectToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.SaveProjectToolStripMenuItem.Text = "save project"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ExitToolStripMenuItem.Text = "exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddRowToolStripMenuItem, Me.AddSoundEffectToolStripMenuItem, Me.RequestUserInputToolStripMenuItem, Me.AddUserOptionsToolStripMenuItem, Me.DisplayTitleToolStripMenuItem, Me.DisplayVideoToolStripMenuItem, Me.SetTextColorToolStripMenuItem, Me.SetVoiceToolStripMenuItem, Me.TypeTextToolStripMenuItem, Me.BackgrounImageToolStripMenuItem, Me.ForegroundImageToolStripMenuItem, Me.AddRowToolStripMenuItem1, Me.TypewriterOptionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "edit"
        '
        'AddRowToolStripMenuItem
        '
        Me.AddRowToolStripMenuItem.Name = "AddRowToolStripMenuItem"
        Me.AddRowToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AddRowToolStripMenuItem.Text = "add music..."
        '
        'AddSoundEffectToolStripMenuItem
        '
        Me.AddSoundEffectToolStripMenuItem.Name = "AddSoundEffectToolStripMenuItem"
        Me.AddSoundEffectToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AddSoundEffectToolStripMenuItem.Text = "add sound effect..."
        '
        'RequestUserInputToolStripMenuItem
        '
        Me.RequestUserInputToolStripMenuItem.Name = "RequestUserInputToolStripMenuItem"
        Me.RequestUserInputToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.RequestUserInputToolStripMenuItem.Text = "request user input..."
        '
        'AddUserOptionsToolStripMenuItem
        '
        Me.AddUserOptionsToolStripMenuItem.Name = "AddUserOptionsToolStripMenuItem"
        Me.AddUserOptionsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.AddUserOptionsToolStripMenuItem.Text = "add user options..."
        '
        'DisplayTitleToolStripMenuItem
        '
        Me.DisplayTitleToolStripMenuItem.Name = "DisplayTitleToolStripMenuItem"
        Me.DisplayTitleToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DisplayTitleToolStripMenuItem.Text = "display title..."
        '
        'DisplayVideoToolStripMenuItem
        '
        Me.DisplayVideoToolStripMenuItem.Name = "DisplayVideoToolStripMenuItem"
        Me.DisplayVideoToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.DisplayVideoToolStripMenuItem.Text = "display video..."
        '
        'SetTextColorToolStripMenuItem
        '
        Me.SetTextColorToolStripMenuItem.Name = "SetTextColorToolStripMenuItem"
        Me.SetTextColorToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SetTextColorToolStripMenuItem.Text = "set text color..."
        '
        'SetVoiceToolStripMenuItem
        '
        Me.SetVoiceToolStripMenuItem.Name = "SetVoiceToolStripMenuItem"
        Me.SetVoiceToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SetVoiceToolStripMenuItem.Text = "set voice..."
        '
        'TypeTextToolStripMenuItem
        '
        Me.TypeTextToolStripMenuItem.Name = "TypeTextToolStripMenuItem"
        Me.TypeTextToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TypeTextToolStripMenuItem.Text = "type text..."
        '
        'BackgrounImageToolStripMenuItem
        '
        Me.BackgrounImageToolStripMenuItem.Name = "BackgrounImageToolStripMenuItem"
        Me.BackgrounImageToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.BackgrounImageToolStripMenuItem.Text = "background image..."
        '
        'ForegroundImageToolStripMenuItem
        '
        Me.ForegroundImageToolStripMenuItem.Name = "ForegroundImageToolStripMenuItem"
        Me.ForegroundImageToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ForegroundImageToolStripMenuItem.Text = "foreground image...."
        '
        'AddRowToolStripMenuItem1
        '
        Me.AddRowToolStripMenuItem1.Name = "AddRowToolStripMenuItem1"
        Me.AddRowToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.AddRowToolStripMenuItem1.Text = "add row"
        '
        'TypewriterOptionsToolStripMenuItem
        '
        Me.TypewriterOptionsToolStripMenuItem.Name = "TypewriterOptionsToolStripMenuItem"
        Me.TypewriterOptionsToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TypewriterOptionsToolStripMenuItem.Text = "typewriter options..."
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column13, Me.Column12, Me.Column9, Me.Column10, Me.Column11})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1144, 380)
        Me.DataGridView1.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "background music"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "sound effect"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "input"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "options"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "display title"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "display video"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "text color"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "voice"
        Me.Column8.Name = "Column8"
        '
        'Column13
        '
        Me.Column13.HeaderText = "typewriter?"
        Me.Column13.Name = "Column13"
        '
        'Column12
        '
        Me.Column12.HeaderText = "speed (ms)"
        Me.Column12.Name = "Column12"
        '
        'Column9
        '
        Me.Column9.HeaderText = "text"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "background image"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "foreground image"
        Me.Column11.Name = "Column11"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "project.csv"
        Me.SaveFileDialog1.Filter = "CSV files|*.csv"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "project.csv"
        Me.OpenFileDialog1.Filter = "CSV files|*.csv"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1165, 420)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(1181, 459)
        Me.MinimumSize = New System.Drawing.Size(1181, 459)
        Me.Name = "Form1"
        Me.Text = "Active Writer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddSoundEffectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RequestUserInputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayTitleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisplayVideoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetTextColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetVoiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypeTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackgrounImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForegroundImageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRowToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TypewriterOptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
