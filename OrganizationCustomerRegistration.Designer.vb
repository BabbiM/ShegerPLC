<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrganizationCustomerRegistration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrganizationCustomerRegistration))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtOrganizationCode = New System.Windows.Forms.TextBox()
        Me.txtOrganizationName = New System.Windows.Forms.TextBox()
        Me.txtRegion = New System.Windows.Forms.TextBox()
        Me.drpdwnOrganizationType = New System.Windows.Forms.ComboBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.txtTelephoneNumber = New System.Windows.Forms.TextBox()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.btnOrganizationRegistrationSave = New System.Windows.Forms.Button()
        Me.btnOrganizationRegistrationClear = New System.Windows.Forms.Button()
        Me.btnOrganizationRegistrationCancel = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.txtWoredaOrg = New System.Windows.Forms.TextBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Organization Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Organization Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Organization Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Region"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(521, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Woreda"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(521, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Contact Person"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(521, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Telephone Number"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(521, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mobile Number"
        '
        'txtOrganizationCode
        '
        Me.txtOrganizationCode.Location = New System.Drawing.Point(211, 24)
        Me.txtOrganizationCode.Name = "txtOrganizationCode"
        Me.txtOrganizationCode.Size = New System.Drawing.Size(279, 20)
        Me.txtOrganizationCode.TabIndex = 9
        '
        'txtOrganizationName
        '
        Me.txtOrganizationName.Location = New System.Drawing.Point(211, 53)
        Me.txtOrganizationName.Name = "txtOrganizationName"
        Me.txtOrganizationName.Size = New System.Drawing.Size(279, 20)
        Me.txtOrganizationName.TabIndex = 10
        '
        'txtRegion
        '
        Me.txtRegion.Location = New System.Drawing.Point(211, 103)
        Me.txtRegion.Name = "txtRegion"
        Me.txtRegion.Size = New System.Drawing.Size(279, 20)
        Me.txtRegion.TabIndex = 11
        '
        'drpdwnOrganizationType
        '
        Me.drpdwnOrganizationType.FormattingEnabled = True
        Me.drpdwnOrganizationType.Items.AddRange(New Object() {"Joint Venture", "General Partnership", "Limited Partnership", "Companies Limitted by Shares", "Private Limitted Company", "NGO"})
        Me.drpdwnOrganizationType.Location = New System.Drawing.Point(211, 76)
        Me.drpdwnOrganizationType.Name = "drpdwnOrganizationType"
        Me.drpdwnOrganizationType.Size = New System.Drawing.Size(279, 21)
        Me.drpdwnOrganizationType.TabIndex = 12
        Me.drpdwnOrganizationType.Text = "Private Limited Company"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(211, 127)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(279, 20)
        Me.txtCity.TabIndex = 13
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(675, 54)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(279, 20)
        Me.txtContactPerson.TabIndex = 15
        '
        'txtTelephoneNumber
        '
        Me.txtTelephoneNumber.Location = New System.Drawing.Point(675, 80)
        Me.txtTelephoneNumber.Name = "txtTelephoneNumber"
        Me.txtTelephoneNumber.Size = New System.Drawing.Size(279, 20)
        Me.txtTelephoneNumber.TabIndex = 16
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Location = New System.Drawing.Point(675, 108)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(279, 20)
        Me.txtMobileNumber.TabIndex = 17
        '
        'btnOrganizationRegistrationSave
        '
        Me.btnOrganizationRegistrationSave.Location = New System.Drawing.Point(299, 177)
        Me.btnOrganizationRegistrationSave.Name = "btnOrganizationRegistrationSave"
        Me.btnOrganizationRegistrationSave.Size = New System.Drawing.Size(75, 23)
        Me.btnOrganizationRegistrationSave.TabIndex = 18
        Me.btnOrganizationRegistrationSave.Text = "Save"
        Me.btnOrganizationRegistrationSave.UseVisualStyleBackColor = True
        '
        'btnOrganizationRegistrationClear
        '
        Me.btnOrganizationRegistrationClear.Location = New System.Drawing.Point(465, 177)
        Me.btnOrganizationRegistrationClear.Name = "btnOrganizationRegistrationClear"
        Me.btnOrganizationRegistrationClear.Size = New System.Drawing.Size(75, 23)
        Me.btnOrganizationRegistrationClear.TabIndex = 19
        Me.btnOrganizationRegistrationClear.Text = "Add New"
        Me.btnOrganizationRegistrationClear.UseVisualStyleBackColor = True
        '
        'btnOrganizationRegistrationCancel
        '
        Me.btnOrganizationRegistrationCancel.Location = New System.Drawing.Point(631, 177)
        Me.btnOrganizationRegistrationCancel.Name = "btnOrganizationRegistrationCancel"
        Me.btnOrganizationRegistrationCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnOrganizationRegistrationCancel.TabIndex = 20
        Me.btnOrganizationRegistrationCancel.Text = "Cancel"
        Me.btnOrganizationRegistrationCancel.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.AllowUserToAddRows = False
        Me.dgvData.AllowUserToDeleteRows = False
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvData.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvData.Location = New System.Drawing.Point(0, 218)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(992, 282)
        Me.dgvData.TabIndex = 21
        '
        'txtWoredaOrg
        '
        Me.txtWoredaOrg.Location = New System.Drawing.Point(675, 27)
        Me.txtWoredaOrg.Name = "txtWoredaOrg"
        Me.txtWoredaOrg.Size = New System.Drawing.Size(279, 20)
        Me.txtWoredaOrg.TabIndex = 22
        '
        'OrganizationCustomerRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 500)
        Me.Controls.Add(Me.txtWoredaOrg)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnOrganizationRegistrationCancel)
        Me.Controls.Add(Me.btnOrganizationRegistrationClear)
        Me.Controls.Add(Me.btnOrganizationRegistrationSave)
        Me.Controls.Add(Me.txtMobileNumber)
        Me.Controls.Add(Me.txtTelephoneNumber)
        Me.Controls.Add(Me.txtContactPerson)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.drpdwnOrganizationType)
        Me.Controls.Add(Me.txtRegion)
        Me.Controls.Add(Me.txtOrganizationName)
        Me.Controls.Add(Me.txtOrganizationCode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "OrganizationCustomerRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Organization Registration"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtOrganizationCode As System.Windows.Forms.TextBox
    Friend WithEvents txtOrganizationName As System.Windows.Forms.TextBox
    Friend WithEvents txtRegion As System.Windows.Forms.TextBox
    Friend WithEvents drpdwnOrganizationType As System.Windows.Forms.ComboBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtTelephoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnOrganizationRegistrationSave As System.Windows.Forms.Button
    Friend WithEvents btnOrganizationRegistrationClear As System.Windows.Forms.Button
    Friend WithEvents btnOrganizationRegistrationCancel As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents txtWoredaOrg As System.Windows.Forms.TextBox
End Class
