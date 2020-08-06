<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookRegistration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBookCodeRegisteration = New System.Windows.Forms.TextBox()
        Me.txtBookTitleRegistration = New System.Windows.Forms.TextBox()
        Me.txtBookAuthorRegistration = New System.Windows.Forms.TextBox()
        Me.txtPublisherRegistration = New System.Windows.Forms.TextBox()
        Me.txtYearPublishedRegistration = New System.Windows.Forms.TextBox()
        Me.btnSaveRegistration = New System.Windows.Forms.Button()
        Me.btnClearRegistration = New System.Windows.Forms.Button()
        Me.btnCancelRegistraiton = New System.Windows.Forms.Button()
        Me.dgrBookRegistration = New System.Windows.Forms.DataGridView()
        Me.txtNoOfPagesBookRegistration = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.drpdwnCategoryBook = New System.Windows.Forms.ComboBox()
        CType(Me.dgrBookRegistration, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(118, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(118, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No of Pages"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(118, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Publisher"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(118, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Year Published"
        '
        'txtBookCodeRegisteration
        '
        Me.txtBookCodeRegisteration.Location = New System.Drawing.Point(256, 27)
        Me.txtBookCodeRegisteration.Name = "txtBookCodeRegisteration"
        Me.txtBookCodeRegisteration.Size = New System.Drawing.Size(132, 20)
        Me.txtBookCodeRegisteration.TabIndex = 6
        '
        'txtBookTitleRegistration
        '
        Me.txtBookTitleRegistration.Location = New System.Drawing.Point(256, 53)
        Me.txtBookTitleRegistration.Name = "txtBookTitleRegistration"
        Me.txtBookTitleRegistration.Size = New System.Drawing.Size(316, 20)
        Me.txtBookTitleRegistration.TabIndex = 7
        '
        'txtBookAuthorRegistration
        '
        Me.txtBookAuthorRegistration.Location = New System.Drawing.Point(256, 75)
        Me.txtBookAuthorRegistration.Name = "txtBookAuthorRegistration"
        Me.txtBookAuthorRegistration.Size = New System.Drawing.Size(316, 20)
        Me.txtBookAuthorRegistration.TabIndex = 8
        '
        'txtPublisherRegistration
        '
        Me.txtPublisherRegistration.Location = New System.Drawing.Point(256, 130)
        Me.txtPublisherRegistration.Name = "txtPublisherRegistration"
        Me.txtPublisherRegistration.Size = New System.Drawing.Size(316, 20)
        Me.txtPublisherRegistration.TabIndex = 9
        '
        'txtYearPublishedRegistration
        '
        Me.txtYearPublishedRegistration.Location = New System.Drawing.Point(256, 154)
        Me.txtYearPublishedRegistration.Name = "txtYearPublishedRegistration"
        Me.txtYearPublishedRegistration.Size = New System.Drawing.Size(132, 20)
        Me.txtYearPublishedRegistration.TabIndex = 10
        '
        'btnSaveRegistration
        '
        Me.btnSaveRegistration.Location = New System.Drawing.Point(170, 219)
        Me.btnSaveRegistration.Name = "btnSaveRegistration"
        Me.btnSaveRegistration.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveRegistration.TabIndex = 11
        Me.btnSaveRegistration.Text = "Save"
        Me.btnSaveRegistration.UseVisualStyleBackColor = True
        '
        'btnClearRegistration
        '
        Me.btnClearRegistration.Location = New System.Drawing.Point(328, 219)
        Me.btnClearRegistration.Name = "btnClearRegistration"
        Me.btnClearRegistration.Size = New System.Drawing.Size(75, 23)
        Me.btnClearRegistration.TabIndex = 12
        Me.btnClearRegistration.Text = "Add New"
        Me.btnClearRegistration.UseVisualStyleBackColor = True
        '
        'btnCancelRegistraiton
        '
        Me.btnCancelRegistraiton.Location = New System.Drawing.Point(497, 219)
        Me.btnCancelRegistraiton.Name = "btnCancelRegistraiton"
        Me.btnCancelRegistraiton.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelRegistraiton.TabIndex = 13
        Me.btnCancelRegistraiton.Text = "Cancel"
        Me.btnCancelRegistraiton.UseVisualStyleBackColor = True
        '
        'dgrBookRegistration
        '
        Me.dgrBookRegistration.AllowUserToAddRows = False
        Me.dgrBookRegistration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrBookRegistration.Location = New System.Drawing.Point(6, 248)
        Me.dgrBookRegistration.Name = "dgrBookRegistration"
        Me.dgrBookRegistration.ReadOnly = True
        Me.dgrBookRegistration.Size = New System.Drawing.Size(666, 150)
        Me.dgrBookRegistration.TabIndex = 14
        '
        'txtNoOfPagesBookRegistration
        '
        Me.txtNoOfPagesBookRegistration.Location = New System.Drawing.Point(256, 104)
        Me.txtNoOfPagesBookRegistration.Name = "txtNoOfPagesBookRegistration"
        Me.txtNoOfPagesBookRegistration.Size = New System.Drawing.Size(132, 20)
        Me.txtNoOfPagesBookRegistration.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Category"
        '
        'drpdwnCategoryBook
        '
        Me.drpdwnCategoryBook.FormattingEnabled = True
        Me.drpdwnCategoryBook.Items.AddRange(New Object() {"000-099 (Generalities)", "100-199 (Phylosophy & Psychology)", "200-299 (Religion)", "300-399 (Social Science)", "400-499 (Languages)", "500-599 (Science)", "600-699 (Technology)", "700-799 (Arts & Recration)", "800-899 (Literature)", "900-999 (History & Geography)"})
        Me.drpdwnCategoryBook.Location = New System.Drawing.Point(256, 184)
        Me.drpdwnCategoryBook.Name = "drpdwnCategoryBook"
        Me.drpdwnCategoryBook.Size = New System.Drawing.Size(316, 21)
        Me.drpdwnCategoryBook.TabIndex = 17
        Me.drpdwnCategoryBook.Text = "Select a category"
        '
        'BookRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 379)
        Me.Controls.Add(Me.drpdwnCategoryBook)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtNoOfPagesBookRegistration)
        Me.Controls.Add(Me.dgrBookRegistration)
        Me.Controls.Add(Me.btnCancelRegistraiton)
        Me.Controls.Add(Me.btnClearRegistration)
        Me.Controls.Add(Me.btnSaveRegistration)
        Me.Controls.Add(Me.txtYearPublishedRegistration)
        Me.Controls.Add(Me.txtPublisherRegistration)
        Me.Controls.Add(Me.txtBookAuthorRegistration)
        Me.Controls.Add(Me.txtBookTitleRegistration)
        Me.Controls.Add(Me.txtBookCodeRegisteration)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BookRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Book Registration"
        CType(Me.dgrBookRegistration, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBookCodeRegisteration As System.Windows.Forms.TextBox
    Friend WithEvents txtBookTitleRegistration As System.Windows.Forms.TextBox
    Friend WithEvents txtBookAuthorRegistration As System.Windows.Forms.TextBox
    Friend WithEvents txtPublisherRegistration As System.Windows.Forms.TextBox
    Friend WithEvents txtYearPublishedRegistration As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveRegistration As System.Windows.Forms.Button
    Friend WithEvents btnClearRegistration As System.Windows.Forms.Button
    Friend WithEvents btnCancelRegistraiton As System.Windows.Forms.Button
    Friend WithEvents dgrBookRegistration As System.Windows.Forms.DataGridView
    Friend WithEvents txtNoOfPagesBookRegistration As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents drpdwnCategoryBook As System.Windows.Forms.ComboBox
End Class
