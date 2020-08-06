<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchIdividualCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchIdividualCustomer))
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShegerDBDataSet = New Sheger_PLC.ShegerDBDataSet()
        Me.SearchCustomerBtnCancel = New System.Windows.Forms.Button()
        Me.DgvSearchIndiCustomer = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmharicFullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableAdapter = New Sheger_PLC.ShegerDBDataSetTableAdapters.CustomerTableAdapter()
        Me.TableAdapterManager = New Sheger_PLC.ShegerDBDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSearchEngineLast = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SearchEngineFirstName = New System.Windows.Forms.TextBox()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShegerDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSearchIndiCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.ShegerDBDataSet
        '
        'ShegerDBDataSet
        '
        Me.ShegerDBDataSet.DataSetName = "ShegerDBDataSet"
        Me.ShegerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchCustomerBtnCancel
        '
        Me.SearchCustomerBtnCancel.Location = New System.Drawing.Point(21, 127)
        Me.SearchCustomerBtnCancel.Name = "SearchCustomerBtnCancel"
        Me.SearchCustomerBtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.SearchCustomerBtnCancel.TabIndex = 6
        Me.SearchCustomerBtnCancel.Text = "Cancel"
        Me.SearchCustomerBtnCancel.UseVisualStyleBackColor = True
        '
        'DgvSearchIndiCustomer
        '
        Me.DgvSearchIndiCustomer.AutoGenerateColumns = False
        Me.DgvSearchIndiCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSearchIndiCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.AmharicFullNameDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.DgvSearchIndiCustomer.DataSource = Me.CustomerBindingSource1
        Me.DgvSearchIndiCustomer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DgvSearchIndiCustomer.Location = New System.Drawing.Point(0, 198)
        Me.DgvSearchIndiCustomer.Name = "DgvSearchIndiCustomer"
        Me.DgvSearchIndiCustomer.Size = New System.Drawing.Size(992, 316)
        Me.DgvSearchIndiCustomer.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'AmharicFullNameDataGridViewTextBoxColumn
        '
        Me.AmharicFullNameDataGridViewTextBoxColumn.DataPropertyName = "Amharic Full Name"
        Me.AmharicFullNameDataGridViewTextBoxColumn.HeaderText = "Amharic Full Name"
        Me.AmharicFullNameDataGridViewTextBoxColumn.Name = "AmharicFullNameDataGridViewTextBoxColumn"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Sex"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Sex"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "JobTitle"
        Me.DataGridViewTextBoxColumn5.HeaderText = "JobTitle"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "VisitingDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "VisitingDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Case"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Case"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "HomePhoneNumber"
        Me.DataGridViewTextBoxColumn8.HeaderText = "HomePhoneNumber"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "OfficePhoneNumber"
        Me.DataGridViewTextBoxColumn9.HeaderText = "OfficePhoneNumber"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "MobilePhoneNumber1"
        Me.DataGridViewTextBoxColumn10.HeaderText = "MobilePhoneNumber1"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "MobilePhoneNumber2"
        Me.DataGridViewTextBoxColumn11.HeaderText = "MobilePhoneNumber2"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BanksTableAdapter = Nothing
        Me.TableAdapterManager.BookBorrowTableAdapter = Nothing
        Me.TableAdapterManager.BookTableAdapter = Nothing
        Me.TableAdapterManager.CaseTableAdapter = Nothing
        Me.TableAdapterManager.CourtsTableAdapter = Nothing
        Me.TableAdapterManager.CustomerTableAdapter = Me.CustomerTableAdapter
        Me.TableAdapterManager.EmailTableAdapter = Nothing
        Me.TableAdapterManager.IndividualsTableAdapter = Nothing
        Me.TableAdapterManager.MobileTableAdapter = Nothing
        Me.TableAdapterManager.OrganizationsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Sheger_PLC.ShegerDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSearchEngineLast)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.SearchEngineFirstName)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 100)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "G Serarch Engine"
        '
        'txtSearchEngineLast
        '
        Me.txtSearchEngineLast.Location = New System.Drawing.Point(175, 56)
        Me.txtSearchEngineLast.Name = "txtSearchEngineLast"
        Me.txtSearchEngineLast.Size = New System.Drawing.Size(188, 20)
        Me.txtSearchEngineLast.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter Search Text (Last Name)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Search Text (First Name)"
        '
        'SearchEngineFirstName
        '
        Me.SearchEngineFirstName.Location = New System.Drawing.Point(175, 22)
        Me.SearchEngineFirstName.Name = "SearchEngineFirstName"
        Me.SearchEngineFirstName.Size = New System.Drawing.Size(188, 20)
        Me.SearchEngineFirstName.TabIndex = 0
        '
        'SearchIdividualCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 514)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvSearchIndiCustomer)
        Me.Controls.Add(Me.SearchCustomerBtnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SearchIdividualCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Idividual Customer"
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShegerDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSearchIndiCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchCustomerBtnCancel As System.Windows.Forms.Button
    Friend WithEvents DgvSearchIndiCustomer As System.Windows.Forms.DataGridView
    '' Friend WithEvents ShegerDBDataSet As Sheger_PLC.ShegerDBDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    ''Friend WithEvents CustomerTableAdapter As Sheger_PLC.ShegerDBDataSetTableAdapters.CustomerTableAdapter
    '' Friend WithEvents TableAdapterManager As Sheger_PLC.ShegerDBDataSetTableAdapters.TableAdapterManager

    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MiddleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VisitingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CaseDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HomePhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OfficePhoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobilePhoneNumber1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobilePhoneNumber2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShegerDBDataSet As Sheger_PLC.ShegerDBDataSet
    Friend WithEvents CustomerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As Sheger_PLC.ShegerDBDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents TableAdapterManager As Sheger_PLC.ShegerDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmharicFullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SearchEngineFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtSearchEngineLast As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
