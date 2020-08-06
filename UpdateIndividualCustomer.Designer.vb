<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateIndividualCustomer
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateIndividualCustomer))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmharicFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobTitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CaseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomePhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OfficePhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobilePhoneNumber1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobilePhoneNumber2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShegerDBDataSet = New Sheger_PLC.ShegerDBDataSet()
        Me.btnOkUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUpdateLast = New System.Windows.Forms.TextBox()
        Me.txtUpdateNewFirst = New System.Windows.Forms.TextBox()
        Me.CustomerTableAdapter = New Sheger_PLC.ShegerDBDataSetTableAdapters.CustomerTableAdapter()
        Me.TxtCaseUpdate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtJobTitleUpdate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePickerUpdate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DrpDwnSexUpdate = New System.Windows.Forms.ComboBox()
        Me.TxtMobilePhone2Update = New System.Windows.Forms.TextBox()
        Me.TxtMobilePhone1Update = New System.Windows.Forms.TextBox()
        Me.TxtOfficePhoneUpdate = New System.Windows.Forms.TextBox()
        Me.TxtHomePhoneUpdate = New System.Windows.Forms.TextBox()
        Me.TxtAddressUpdate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrevFirstNameUpdate = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FillBy8ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FirstNameToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.FirstNameToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy8ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.txtCustomerCodeUpdate = New System.Windows.Forms.TextBox()
        Me.txtUpdateFirst = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShegerDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy8ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIDDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.AmharicFullNameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn, Me.JobTitleDataGridViewTextBoxColumn, Me.VisitingDateDataGridViewTextBoxColumn, Me.CaseDataGridViewTextBoxColumn, Me.HomePhoneNumberDataGridViewTextBoxColumn, Me.OfficePhoneNumberDataGridViewTextBoxColumn, Me.MobilePhoneNumber1DataGridViewTextBoxColumn, Me.MobilePhoneNumber2DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(0, 258)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(976, 178)
        Me.DataGridView1.TabIndex = 0
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "LastName"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'AmharicFullNameDataGridViewTextBoxColumn
        '
        Me.AmharicFullNameDataGridViewTextBoxColumn.DataPropertyName = "Amharic Full Name"
        Me.AmharicFullNameDataGridViewTextBoxColumn.HeaderText = "Amharic Full Name"
        Me.AmharicFullNameDataGridViewTextBoxColumn.Name = "AmharicFullNameDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'JobTitleDataGridViewTextBoxColumn
        '
        Me.JobTitleDataGridViewTextBoxColumn.DataPropertyName = "JobTitle"
        Me.JobTitleDataGridViewTextBoxColumn.HeaderText = "JobTitle"
        Me.JobTitleDataGridViewTextBoxColumn.Name = "JobTitleDataGridViewTextBoxColumn"
        '
        'VisitingDateDataGridViewTextBoxColumn
        '
        Me.VisitingDateDataGridViewTextBoxColumn.DataPropertyName = "VisitingDate"
        Me.VisitingDateDataGridViewTextBoxColumn.HeaderText = "VisitingDate"
        Me.VisitingDateDataGridViewTextBoxColumn.Name = "VisitingDateDataGridViewTextBoxColumn"
        '
        'CaseDataGridViewTextBoxColumn
        '
        Me.CaseDataGridViewTextBoxColumn.DataPropertyName = "Case"
        Me.CaseDataGridViewTextBoxColumn.HeaderText = "Case"
        Me.CaseDataGridViewTextBoxColumn.Name = "CaseDataGridViewTextBoxColumn"
        '
        'HomePhoneNumberDataGridViewTextBoxColumn
        '
        Me.HomePhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "HomePhoneNumber"
        Me.HomePhoneNumberDataGridViewTextBoxColumn.HeaderText = "HomePhoneNumber"
        Me.HomePhoneNumberDataGridViewTextBoxColumn.Name = "HomePhoneNumberDataGridViewTextBoxColumn"
        '
        'OfficePhoneNumberDataGridViewTextBoxColumn
        '
        Me.OfficePhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "OfficePhoneNumber"
        Me.OfficePhoneNumberDataGridViewTextBoxColumn.HeaderText = "OfficePhoneNumber"
        Me.OfficePhoneNumberDataGridViewTextBoxColumn.Name = "OfficePhoneNumberDataGridViewTextBoxColumn"
        '
        'MobilePhoneNumber1DataGridViewTextBoxColumn
        '
        Me.MobilePhoneNumber1DataGridViewTextBoxColumn.DataPropertyName = "MobilePhoneNumber1"
        Me.MobilePhoneNumber1DataGridViewTextBoxColumn.HeaderText = "MobilePhoneNumber1"
        Me.MobilePhoneNumber1DataGridViewTextBoxColumn.Name = "MobilePhoneNumber1DataGridViewTextBoxColumn"
        '
        'MobilePhoneNumber2DataGridViewTextBoxColumn
        '
        Me.MobilePhoneNumber2DataGridViewTextBoxColumn.DataPropertyName = "MobilePhoneNumber2"
        Me.MobilePhoneNumber2DataGridViewTextBoxColumn.HeaderText = "MobilePhoneNumber2"
        Me.MobilePhoneNumber2DataGridViewTextBoxColumn.Name = "MobilePhoneNumber2DataGridViewTextBoxColumn"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.ShegerDBDataSet
        '
        'ShegerDBDataSet
        '
        Me.ShegerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnOkUpdate
        '
        Me.btnOkUpdate.Location = New System.Drawing.Point(541, 229)
        Me.btnOkUpdate.Name = "btnOkUpdate"
        Me.btnOkUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnOkUpdate.TabIndex = 1
        Me.btnOkUpdate.Text = "Cancel"
        Me.btnOkUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "New First Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(253, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Name"
        '
        'txtUpdateLast
        '
        Me.txtUpdateLast.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "LastName", True))
        Me.txtUpdateLast.Location = New System.Drawing.Point(147, 117)
        Me.txtUpdateLast.Name = "txtUpdateLast"
        Me.txtUpdateLast.Size = New System.Drawing.Size(258, 20)
        Me.txtUpdateLast.TabIndex = 6
        '
        'txtUpdateNewFirst
        '
        Me.txtUpdateNewFirst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.txtUpdateNewFirst.Location = New System.Drawing.Point(147, 91)
        Me.txtUpdateNewFirst.Name = "txtUpdateNewFirst"
        Me.txtUpdateNewFirst.Size = New System.Drawing.Size(258, 20)
        Me.txtUpdateNewFirst.TabIndex = 7
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TxtCaseUpdate
        '
        Me.TxtCaseUpdate.Location = New System.Drawing.Point(602, 183)
        Me.TxtCaseUpdate.Name = "TxtCaseUpdate"
        Me.TxtCaseUpdate.Size = New System.Drawing.Size(258, 20)
        Me.TxtCaseUpdate.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(445, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Case"
        '
        'TxtJobTitleUpdate
        '
        Me.TxtJobTitleUpdate.Location = New System.Drawing.Point(147, 170)
        Me.TxtJobTitleUpdate.Name = "TxtJobTitleUpdate"
        Me.TxtJobTitleUpdate.Size = New System.Drawing.Size(258, 20)
        Me.TxtJobTitleUpdate.TabIndex = 46
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(9, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Job Title"
        '
        'DateTimePickerUpdate
        '
        Me.DateTimePickerUpdate.Location = New System.Drawing.Point(602, 52)
        Me.DateTimePickerUpdate.Name = "DateTimePickerUpdate"
        Me.DateTimePickerUpdate.Size = New System.Drawing.Size(258, 20)
        Me.DateTimePickerUpdate.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(445, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Visiting Date"
        '
        'DrpDwnSexUpdate
        '
        Me.DrpDwnSexUpdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DrpDwnSexUpdate.FormattingEnabled = True
        Me.DrpDwnSexUpdate.Items.AddRange(New Object() {"Male", "Female"})
        Me.DrpDwnSexUpdate.Location = New System.Drawing.Point(147, 143)
        Me.DrpDwnSexUpdate.Name = "DrpDwnSexUpdate"
        Me.DrpDwnSexUpdate.Size = New System.Drawing.Size(121, 21)
        Me.DrpDwnSexUpdate.TabIndex = 42
        '
        'TxtMobilePhone2Update
        '
        Me.TxtMobilePhone2Update.Location = New System.Drawing.Point(602, 155)
        Me.TxtMobilePhone2Update.Name = "TxtMobilePhone2Update"
        Me.TxtMobilePhone2Update.Size = New System.Drawing.Size(258, 20)
        Me.TxtMobilePhone2Update.TabIndex = 41
        '
        'TxtMobilePhone1Update
        '
        Me.TxtMobilePhone1Update.Location = New System.Drawing.Point(602, 131)
        Me.TxtMobilePhone1Update.Name = "TxtMobilePhone1Update"
        Me.TxtMobilePhone1Update.Size = New System.Drawing.Size(258, 20)
        Me.TxtMobilePhone1Update.TabIndex = 40
        '
        'TxtOfficePhoneUpdate
        '
        Me.TxtOfficePhoneUpdate.Location = New System.Drawing.Point(602, 104)
        Me.TxtOfficePhoneUpdate.Name = "TxtOfficePhoneUpdate"
        Me.TxtOfficePhoneUpdate.Size = New System.Drawing.Size(258, 20)
        Me.TxtOfficePhoneUpdate.TabIndex = 39
        '
        'TxtHomePhoneUpdate
        '
        Me.TxtHomePhoneUpdate.Location = New System.Drawing.Point(602, 78)
        Me.TxtHomePhoneUpdate.Name = "TxtHomePhoneUpdate"
        Me.TxtHomePhoneUpdate.Size = New System.Drawing.Size(258, 20)
        Me.TxtHomePhoneUpdate.TabIndex = 38
        '
        'TxtAddressUpdate
        '
        Me.TxtAddressUpdate.Location = New System.Drawing.Point(147, 196)
        Me.TxtAddressUpdate.Name = "TxtAddressUpdate"
        Me.TxtAddressUpdate.Size = New System.Drawing.Size(258, 20)
        Me.TxtAddressUpdate.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(445, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Mobile Phone Number2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(445, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Mobile Phone Number1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(445, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Office Phone Number"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(445, 85)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Home Phone Number"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAddress.Location = New System.Drawing.Point(9, 196)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(45, 13)
        Me.lblAddress.TabIndex = 31
        Me.lblAddress.Text = "Address"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAge.Location = New System.Drawing.Point(9, 144)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(25, 13)
        Me.lblAge.TabIndex = 30
        Me.lblAge.Text = "Sex"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Previous First Name"
        '
        'txtPrevFirstNameUpdate
        '
        Me.txtPrevFirstNameUpdate.Location = New System.Drawing.Point(147, 65)
        Me.txtPrevFirstNameUpdate.Name = "txtPrevFirstNameUpdate"
        Me.txtPrevFirstNameUpdate.Size = New System.Drawing.Size(258, 20)
        Me.txtPrevFirstNameUpdate.TabIndex = 50
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.TextBox1.Location = New System.Drawing.Point(279, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 51
        '
        'FillBy8ToolStrip
        '
        Me.FillBy8ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstNameToolStripLabel1, Me.FirstNameToolStripTextBox1, Me.FillBy8ToolStripButton})
        Me.FillBy8ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy8ToolStrip.Name = "FillBy8ToolStrip"
        Me.FillBy8ToolStrip.Size = New System.Drawing.Size(996, 25)
        Me.FillBy8ToolStrip.TabIndex = 52
        Me.FillBy8ToolStrip.Text = "FillBy8ToolStrip"
        '
        'FirstNameToolStripLabel1
        '
        Me.FirstNameToolStripLabel1.Name = "FirstNameToolStripLabel1"
        Me.FirstNameToolStripLabel1.Size = New System.Drawing.Size(64, 22)
        Me.FirstNameToolStripLabel1.Text = "FirstName:"
        '
        'FirstNameToolStripTextBox1
        '
        Me.FirstNameToolStripTextBox1.Name = "FirstNameToolStripTextBox1"
        Me.FirstNameToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'FillBy8ToolStripButton
        '
        Me.FillBy8ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy8ToolStripButton.Name = "FillBy8ToolStripButton"
        Me.FillBy8ToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.FillBy8ToolStripButton.Text = "Search"
        '
        'txtCustomerCodeUpdate
        '
        Me.txtCustomerCodeUpdate.Location = New System.Drawing.Point(147, 65)
        Me.txtCustomerCodeUpdate.Name = "txtCustomerCodeUpdate"
        Me.txtCustomerCodeUpdate.Size = New System.Drawing.Size(258, 20)
        Me.txtCustomerCodeUpdate.TabIndex = 50
        '
        'txtUpdateFirst
        '
        Me.txtUpdateFirst.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "FirstName", True))
        Me.txtUpdateFirst.Location = New System.Drawing.Point(147, 91)
        Me.txtUpdateFirst.Name = "txtUpdateFirst"
        Me.txtUpdateFirst.Size = New System.Drawing.Size(258, 20)
        Me.txtUpdateFirst.TabIndex = 7
        '
        'UpdateIndividualCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 490)
        Me.Controls.Add(Me.FillBy8ToolStrip)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtPrevFirstNameUpdate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtCaseUpdate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtJobTitleUpdate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePickerUpdate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DrpDwnSexUpdate)
        Me.Controls.Add(Me.TxtMobilePhone2Update)
        Me.Controls.Add(Me.TxtMobilePhone1Update)
        Me.Controls.Add(Me.TxtOfficePhoneUpdate)
        Me.Controls.Add(Me.TxtHomePhoneUpdate)
        Me.Controls.Add(Me.TxtAddressUpdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtUpdateNewFirst)
        Me.Controls.Add(Me.txtUpdateLast)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOkUpdate)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpdateIndividualCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Individual Customer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShegerDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy8ToolStrip.ResumeLayout(False)
        Me.FillBy8ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnOkUpdate As System.Windows.Forms.Button
    Friend WithEvents ShegerDBDataSet As Sheger_PLC.ShegerDBDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As Sheger_PLC.ShegerDBDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmharicFullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HomePhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OfficePhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobilePhoneNumber1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobilePhoneNumber2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUpdateLast As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateNewFirst As System.Windows.Forms.TextBox
    Friend WithEvents TxtCaseUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtJobTitleUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerUpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DrpDwnSexUpdate As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMobilePhone2Update As System.Windows.Forms.TextBox
    Friend WithEvents TxtMobilePhone1Update As System.Windows.Forms.TextBox
    Friend WithEvents TxtOfficePhoneUpdate As System.Windows.Forms.TextBox
    Friend WithEvents TxtHomePhoneUpdate As System.Windows.Forms.TextBox
    Friend WithEvents TxtAddressUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents lblAge As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrevFirstNameUpdate As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents FillBy8ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FirstNameToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FirstNameToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy8ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtCustomerCodeUpdate As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateFirst As System.Windows.Forms.TextBox
End Class
