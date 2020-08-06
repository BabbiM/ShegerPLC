<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookBorrow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BookBorrow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFullNameBookBorrow = New System.Windows.Forms.TextBox()
        Me.txtBookTitleBookBorrow = New System.Windows.Forms.TextBox()
        Me.txtYearPublishedBookBorrow = New System.Windows.Forms.TextBox()
        Me.txtAuthorBookBorrow = New System.Windows.Forms.TextBox()
        Me.btnSaveBookBorrow = New System.Windows.Forms.Button()
        Me.btnCancelBookBorrow = New System.Windows.Forms.Button()
        Me.btnClearBookBorrow = New System.Windows.Forms.Button()
        Me.dgdBookBorrow = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBookCodeBookBorrow = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgdBookBorrow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Full Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(87, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year Published"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Author"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Borrowing Date"
        '
        'txtFullNameBookBorrow
        '
        Me.txtFullNameBookBorrow.Location = New System.Drawing.Point(226, 36)
        Me.txtFullNameBookBorrow.Name = "txtFullNameBookBorrow"
        Me.txtFullNameBookBorrow.Size = New System.Drawing.Size(279, 20)
        Me.txtFullNameBookBorrow.TabIndex = 5
        '
        'txtBookTitleBookBorrow
        '
        Me.txtBookTitleBookBorrow.Location = New System.Drawing.Point(226, 70)
        Me.txtBookTitleBookBorrow.Name = "txtBookTitleBookBorrow"
        Me.txtBookTitleBookBorrow.Size = New System.Drawing.Size(279, 20)
        Me.txtBookTitleBookBorrow.TabIndex = 6
        '
        'txtYearPublishedBookBorrow
        '
        Me.txtYearPublishedBookBorrow.Location = New System.Drawing.Point(226, 97)
        Me.txtYearPublishedBookBorrow.Name = "txtYearPublishedBookBorrow"
        Me.txtYearPublishedBookBorrow.Size = New System.Drawing.Size(279, 20)
        Me.txtYearPublishedBookBorrow.TabIndex = 7
        '
        'txtAuthorBookBorrow
        '
        Me.txtAuthorBookBorrow.Location = New System.Drawing.Point(226, 124)
        Me.txtAuthorBookBorrow.Name = "txtAuthorBookBorrow"
        Me.txtAuthorBookBorrow.Size = New System.Drawing.Size(279, 20)
        Me.txtAuthorBookBorrow.TabIndex = 8
        '
        'btnSaveBookBorrow
        '
        Me.btnSaveBookBorrow.Location = New System.Drawing.Point(79, 194)
        Me.btnSaveBookBorrow.Name = "btnSaveBookBorrow"
        Me.btnSaveBookBorrow.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveBookBorrow.TabIndex = 10
        Me.btnSaveBookBorrow.Text = "Save"
        Me.btnSaveBookBorrow.UseVisualStyleBackColor = True
        '
        'btnCancelBookBorrow
        '
        Me.btnCancelBookBorrow.Location = New System.Drawing.Point(472, 194)
        Me.btnCancelBookBorrow.Name = "btnCancelBookBorrow"
        Me.btnCancelBookBorrow.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelBookBorrow.TabIndex = 11
        Me.btnCancelBookBorrow.Text = "Cancel"
        Me.btnCancelBookBorrow.UseVisualStyleBackColor = True
        '
        'btnClearBookBorrow
        '
        Me.btnClearBookBorrow.Location = New System.Drawing.Point(269, 194)
        Me.btnClearBookBorrow.Name = "btnClearBookBorrow"
        Me.btnClearBookBorrow.Size = New System.Drawing.Size(75, 23)
        Me.btnClearBookBorrow.TabIndex = 12
        Me.btnClearBookBorrow.Text = "Add New"
        Me.btnClearBookBorrow.UseVisualStyleBackColor = True
        '
        'dgdBookBorrow
        '
        Me.dgdBookBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdBookBorrow.Location = New System.Drawing.Point(13, 223)
        Me.dgdBookBorrow.Name = "dgdBookBorrow"
        Me.dgdBookBorrow.Size = New System.Drawing.Size(645, 150)
        Me.dgdBookBorrow.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(85, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Book Code"
        '
        'txtBookCodeBookBorrow
        '
        Me.txtBookCodeBookBorrow.Location = New System.Drawing.Point(226, 9)
        Me.txtBookCodeBookBorrow.Name = "txtBookCodeBookBorrow"
        Me.txtBookCodeBookBorrow.Size = New System.Drawing.Size(279, 20)
        Me.txtBookCodeBookBorrow.TabIndex = 15
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(226, 152)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(279, 20)
        Me.DateTimePicker1.TabIndex = 16
        '
        'BookBorrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 378)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtBookCodeBookBorrow)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgdBookBorrow)
        Me.Controls.Add(Me.btnClearBookBorrow)
        Me.Controls.Add(Me.btnCancelBookBorrow)
        Me.Controls.Add(Me.btnSaveBookBorrow)
        Me.Controls.Add(Me.txtAuthorBookBorrow)
        Me.Controls.Add(Me.txtYearPublishedBookBorrow)
        Me.Controls.Add(Me.txtBookTitleBookBorrow)
        Me.Controls.Add(Me.txtFullNameBookBorrow)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "BookBorrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BookBorrow"
        CType(Me.dgdBookBorrow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFullNameBookBorrow As System.Windows.Forms.TextBox
    Friend WithEvents txtBookTitleBookBorrow As System.Windows.Forms.TextBox
    Friend WithEvents txtYearPublishedBookBorrow As System.Windows.Forms.TextBox
    Friend WithEvents txtAuthorBookBorrow As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveBookBorrow As System.Windows.Forms.Button
    Friend WithEvents btnCancelBookBorrow As System.Windows.Forms.Button
    Friend WithEvents btnClearBookBorrow As System.Windows.Forms.Button
    Friend WithEvents dgdBookBorrow As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBookCodeBookBorrow As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
