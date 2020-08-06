Imports System.IO

Public Class G_Note

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '  System.IO.File.WriteAllText(Savefiledialog1.FileName, RichTextBox1.Text)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
            Dim a() As String = SaveFileDialog.FileName.Split("\")
            Dim sw As New StreamWriter(SaveFileDialog.FileName)
            sw.Write(Me.RichTextBox1.Text)
            My.Settings.Save()
            sw.Close()
        End If

    End Sub

    Private Sub btnCancelNote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelNote.Click
        Me.Close()

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 12, FontStyle.Regular)
        e.Graphics.DrawString(RichTextBox1.Text, font, Brushes.Black, 100, 100)

    End Sub
End Class