Imports System.Windows.Forms
Imports System.IO

Public Class MainForm

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        ' Create a new instance of the child form.
        '' Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        '' ChildForm.MdiParent = Me
        ' G_Note.MdiParent = G_Note


        ' m_ChildFormNumber += 1
        ' ChildForm.Text = "Window " & m_ChildFormNumber
        G_Note.MdiParent = Me
        G_Note.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
            '  G_Note.RichTextBox1 = New Text(OpenFileDialog.OpenFile())
            G_Note.RichTextBox1.Text = FileIO.FileSystem.ReadAllText(OpenFileDialog.FileName)


            G_Note.Show()

            ''
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
            Dim a() As String = SaveFileDialog.FileName.Split("\")
            Dim sw As New StreamWriter(SaveFileDialog.FileName)
            sw.Write(G_Note.RichTextBox1.Text)
            My.Settings.Save()
            sw.Close()

            '''''
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click

    End Sub

    Private Sub IndividualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualToolStripMenuItem.Click
        IndividualCustomerRegestration.Show()
    End Sub

    Private Sub OrganizationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganizationToolStripMenuItem.Click
        OrganizationCustomerRegistration.Show()
    End Sub

    Private Sub IndividualToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualToolStripMenuItem1.Click
        SearchIdividualCustomer.Show()
    End Sub

    Private Sub OrganizationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganizationToolStripMenuItem1.Click
        SearchOrganizationCustomer.Show()
    End Sub

    Private Sub IndividualToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndividualToolStripMenuItem2.Click
        'UpdateIndividualCustomer.Show()
        UpdateIndividualCustomer.Show()

    End Sub

    Private Sub IndividualToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        HelpContent.Show()
    End Sub

    Private Sub PrintPreviewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripButton.Click

    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReturnABookToolStripMenuItem.Visible = False
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        G_Note.PrintPreviewDialog1.Show()

    End Sub

    Private Sub EmailAdressesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailAdressesToolStripMenuItem.Click
        Email_and_Website.Show()


    End Sub

    Private Sub ImprotantWebsitesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprotantWebsitesToolStripMenuItem.Click
        Important_Websites.Show()

    End Sub

    Private Sub MobileINFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MobileINFOToolStripMenuItem.Click
        Mobile_Information.Show()
    End Sub

    Private Sub RegisterABookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegisterABookToolStripMenuItem.Click
        BookRegistration.Show()

    End Sub

    Private Sub SearchABookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchABookToolStripMenuItem.Click
        SearchBook.Show()

    End Sub

    Private Sub BorrowABookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BorrowABookToolStripMenuItem.Click
        BookBorrow.Show()

    End Sub

    Private Sub AllBanksToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllBanksToolStripMenuItem1.Click
        Banks.Show()

    End Sub

    Private Sub AllBanksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Banks.Show()

    End Sub

    Private Sub AllCourtsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Courts.Show()

    End Sub

    Private Sub AllCourtsToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AllCourtsToolStripMenuItem.Click
        Courts.Show()

    End Sub

    Private Sub ReturnABookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReturnABookToolStripMenuItem.Click
        ReturnBook.Show()

    End Sub

    Private Sub OrganizationsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrganizationsToolStripMenuItem.Click
        'OrganizaitonReport.Show()
        'OrganiztionalReport.Show()
        OrganizationRepForm.Show()


    End Sub

    Private Sub SaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub CasesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CasesToolStripMenuItem.Click
        BookRepForm.Show()


    End Sub

    Private Sub ListOfCustomersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListOfCustomersToolStripMenuItem.Click
        CustomersRepForm.Show()


    End Sub

    Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
        G_Note.PrintDocument1.Print()

    End Sub
End Class
