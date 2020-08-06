<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchOrganizationCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchOrganizationCustomer))
        Me.btnSearchOrganizationCancel = New System.Windows.Forms.Button()
        Me.drdSearchCustomer = New System.Windows.Forms.DataGridView()
        Me.OrganizationCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizationNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizationTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegionalStateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WoredaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactPersonDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelephoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrganizationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShegerDBDataSet = New Sheger_PLC.ShegerDBDataSet()
        Me.OrganizationsTableAdapter = New Sheger_PLC.ShegerDBDataSetTableAdapters.OrganizationsTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.srcOrganization = New System.Windows.Forms.TextBox()
        CType(Me.drdSearchCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrganizationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShegerDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearchOrganizationCancel
        '
        Me.btnSearchOrganizationCancel.Location = New System.Drawing.Point(12, 70)
        Me.btnSearchOrganizationCancel.Name = "btnSearchOrganizationCancel"
        Me.btnSearchOrganizationCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchOrganizationCancel.TabIndex = 5
        Me.btnSearchOrganizationCancel.Text = "Cancel"
        Me.btnSearchOrganizationCancel.UseVisualStyleBackColor = True
        '
        'drdSearchCustomer
        '
        Me.drdSearchCustomer.AutoGenerateColumns = False
        Me.drdSearchCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.drdSearchCustomer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrganizationCodeDataGridViewTextBoxColumn, Me.OrganizationNameDataGridViewTextBoxColumn, Me.OrganizationTypeDataGridViewTextBoxColumn, Me.RegionalStateDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.WoredaDataGridViewTextBoxColumn, Me.ContactPersonDataGridViewTextBoxColumn, Me.TelephoneNumberDataGridViewTextBoxColumn, Me.MobileNumberDataGridViewTextBoxColumn})
        Me.drdSearchCustomer.DataSource = Me.OrganizationsBindingSource
        Me.drdSearchCustomer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.drdSearchCustomer.Location = New System.Drawing.Point(0, 99)
        Me.drdSearchCustomer.Name = "drdSearchCustomer"
        Me.drdSearchCustomer.Size = New System.Drawing.Size(986, 258)
        Me.drdSearchCustomer.TabIndex = 6
        '
        'OrganizationCodeDataGridViewTextBoxColumn
        '
        Me.OrganizationCodeDataGridViewTextBoxColumn.DataPropertyName = "OrganizationCode"
        Me.OrganizationCodeDataGridViewTextBoxColumn.HeaderText = "OrganizationCode"
        Me.OrganizationCodeDataGridViewTextBoxColumn.Name = "OrganizationCodeDataGridViewTextBoxColumn"
        '
        'OrganizationNameDataGridViewTextBoxColumn
        '
        Me.OrganizationNameDataGridViewTextBoxColumn.DataPropertyName = "OrganizationName"
        Me.OrganizationNameDataGridViewTextBoxColumn.HeaderText = "OrganizationName"
        Me.OrganizationNameDataGridViewTextBoxColumn.Name = "OrganizationNameDataGridViewTextBoxColumn"
        '
        'OrganizationTypeDataGridViewTextBoxColumn
        '
        Me.OrganizationTypeDataGridViewTextBoxColumn.DataPropertyName = "OrganizationType"
        Me.OrganizationTypeDataGridViewTextBoxColumn.HeaderText = "OrganizationType"
        Me.OrganizationTypeDataGridViewTextBoxColumn.Name = "OrganizationTypeDataGridViewTextBoxColumn"
        '
        'RegionalStateDataGridViewTextBoxColumn
        '
        Me.RegionalStateDataGridViewTextBoxColumn.DataPropertyName = "RegionalState"
        Me.RegionalStateDataGridViewTextBoxColumn.HeaderText = "RegionalState"
        Me.RegionalStateDataGridViewTextBoxColumn.Name = "RegionalStateDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'WoredaDataGridViewTextBoxColumn
        '
        Me.WoredaDataGridViewTextBoxColumn.DataPropertyName = "Woreda"
        Me.WoredaDataGridViewTextBoxColumn.HeaderText = "Woreda"
        Me.WoredaDataGridViewTextBoxColumn.Name = "WoredaDataGridViewTextBoxColumn"
        '
        'ContactPersonDataGridViewTextBoxColumn
        '
        Me.ContactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson"
        Me.ContactPersonDataGridViewTextBoxColumn.HeaderText = "ContactPerson"
        Me.ContactPersonDataGridViewTextBoxColumn.Name = "ContactPersonDataGridViewTextBoxColumn"
        '
        'TelephoneNumberDataGridViewTextBoxColumn
        '
        Me.TelephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "TelephoneNumber"
        Me.TelephoneNumberDataGridViewTextBoxColumn.HeaderText = "TelephoneNumber"
        Me.TelephoneNumberDataGridViewTextBoxColumn.Name = "TelephoneNumberDataGridViewTextBoxColumn"
        '
        'MobileNumberDataGridViewTextBoxColumn
        '
        Me.MobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.HeaderText = "MobileNumber"
        Me.MobileNumberDataGridViewTextBoxColumn.Name = "MobileNumberDataGridViewTextBoxColumn"
        '
        'OrganizationsBindingSource
        '
        Me.OrganizationsBindingSource.DataMember = "Organizations"
        Me.OrganizationsBindingSource.DataSource = Me.ShegerDBDataSet
        '
        'ShegerDBDataSet
        '
        Me.ShegerDBDataSet.DataSetName = "ShegerDBDataSet"
        Me.ShegerDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrganizationsTableAdapter
        '
        Me.OrganizationsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.srcOrganization)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 62)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "G Search Engine"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter the search text"
        '
        'srcOrganization
        '
        Me.srcOrganization.Location = New System.Drawing.Point(152, 25)
        Me.srcOrganization.Name = "srcOrganization"
        Me.srcOrganization.Size = New System.Drawing.Size(209, 20)
        Me.srcOrganization.TabIndex = 1
        '
        'SearchOrganizationCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.drdSearchCustomer)
        Me.Controls.Add(Me.btnSearchOrganizationCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "SearchOrganizationCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search Organization"
        CType(Me.drdSearchCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrganizationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShegerDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSearchOrganizationCancel As System.Windows.Forms.Button
    ' Friend WithEvents DataSet11 As Sheger_PLC.DataSet1
    Friend WithEvents drdSearchCustomer As System.Windows.Forms.DataGridView
    Friend WithEvents ShegerDBDataSet As Sheger_PLC.ShegerDBDataSet
    Friend WithEvents OrganizationsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrganizationsTableAdapter As Sheger_PLC.ShegerDBDataSetTableAdapters.OrganizationsTableAdapter
    Friend WithEvents OrganizationCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrganizationNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrganizationTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegionalStateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WoredaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactPersonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelephoneNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents srcOrganization As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
