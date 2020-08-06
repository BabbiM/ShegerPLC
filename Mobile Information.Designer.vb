<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mobile_Information
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mobile_Information))
        Me.dgrMobileInfo = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.txtMobilePuk = New System.Windows.Forms.TextBox()
        Me.txtMobilePin = New System.Windows.Forms.TextBox()
        Me.txtMobileIccid = New System.Windows.Forms.TextBox()
        Me.txtMobileOwner = New System.Windows.Forms.TextBox()
        Me.txtMobileRemark = New System.Windows.Forms.TextBox()
        Me.btnMobileSave = New System.Windows.Forms.Button()
        Me.btnCancelMobile = New System.Windows.Forms.Button()
        Me.chkMobileAdd = New System.Windows.Forms.CheckBox()
        Me.btnMobileClear = New System.Windows.Forms.Button()
        Me.btnOkMobileInfo = New System.Windows.Forms.Button()
        CType(Me.dgrMobileInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgrMobileInfo
        '
        Me.dgrMobileInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrMobileInfo.Location = New System.Drawing.Point(12, 155)
        Me.dgrMobileInfo.Name = "dgrMobileInfo"
        Me.dgrMobileInfo.Size = New System.Drawing.Size(643, 146)
        Me.dgrMobileInfo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mobile Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "PUK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(12, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "PIN Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(332, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ICCID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(332, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Owner"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(332, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Remark"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.Enabled = False
        Me.txtMobileNumber.Location = New System.Drawing.Point(118, 39)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(199, 20)
        Me.txtMobileNumber.TabIndex = 8
        '
        'txtMobilePuk
        '
        Me.txtMobilePuk.Enabled = False
        Me.txtMobilePuk.Location = New System.Drawing.Point(118, 65)
        Me.txtMobilePuk.Name = "txtMobilePuk"
        Me.txtMobilePuk.Size = New System.Drawing.Size(199, 20)
        Me.txtMobilePuk.TabIndex = 9
        '
        'txtMobilePin
        '
        Me.txtMobilePin.Enabled = False
        Me.txtMobilePin.Location = New System.Drawing.Point(118, 96)
        Me.txtMobilePin.Name = "txtMobilePin"
        Me.txtMobilePin.Size = New System.Drawing.Size(199, 20)
        Me.txtMobilePin.TabIndex = 10
        '
        'txtMobileIccid
        '
        Me.txtMobileIccid.Enabled = False
        Me.txtMobileIccid.Location = New System.Drawing.Point(386, 39)
        Me.txtMobileIccid.Name = "txtMobileIccid"
        Me.txtMobileIccid.Size = New System.Drawing.Size(211, 20)
        Me.txtMobileIccid.TabIndex = 11
        '
        'txtMobileOwner
        '
        Me.txtMobileOwner.Enabled = False
        Me.txtMobileOwner.Location = New System.Drawing.Point(386, 65)
        Me.txtMobileOwner.Name = "txtMobileOwner"
        Me.txtMobileOwner.Size = New System.Drawing.Size(211, 20)
        Me.txtMobileOwner.TabIndex = 12
        '
        'txtMobileRemark
        '
        Me.txtMobileRemark.Enabled = False
        Me.txtMobileRemark.Location = New System.Drawing.Point(386, 96)
        Me.txtMobileRemark.Name = "txtMobileRemark"
        Me.txtMobileRemark.Size = New System.Drawing.Size(211, 20)
        Me.txtMobileRemark.TabIndex = 13
        '
        'btnMobileSave
        '
        Me.btnMobileSave.Enabled = False
        Me.btnMobileSave.Location = New System.Drawing.Point(99, 126)
        Me.btnMobileSave.Name = "btnMobileSave"
        Me.btnMobileSave.Size = New System.Drawing.Size(75, 23)
        Me.btnMobileSave.TabIndex = 14
        Me.btnMobileSave.Text = "Save"
        Me.btnMobileSave.UseVisualStyleBackColor = True
        '
        'btnCancelMobile
        '
        Me.btnCancelMobile.Enabled = False
        Me.btnCancelMobile.Location = New System.Drawing.Point(420, 126)
        Me.btnCancelMobile.Name = "btnCancelMobile"
        Me.btnCancelMobile.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelMobile.TabIndex = 15
        Me.btnCancelMobile.Text = "Cancel"
        Me.btnCancelMobile.UseVisualStyleBackColor = True
        '
        'chkMobileAdd
        '
        Me.chkMobileAdd.AutoSize = True
        Me.chkMobileAdd.Location = New System.Drawing.Point(12, 12)
        Me.chkMobileAdd.Name = "chkMobileAdd"
        Me.chkMobileAdd.Size = New System.Drawing.Size(115, 17)
        Me.chkMobileAdd.TabIndex = 16
        Me.chkMobileAdd.Text = "Add a new Record"
        Me.chkMobileAdd.UseVisualStyleBackColor = True
        '
        'btnMobileClear
        '
        Me.btnMobileClear.Enabled = False
        Me.btnMobileClear.Location = New System.Drawing.Point(264, 126)
        Me.btnMobileClear.Name = "btnMobileClear"
        Me.btnMobileClear.Size = New System.Drawing.Size(75, 23)
        Me.btnMobileClear.TabIndex = 17
        Me.btnMobileClear.Text = "Add New"
        Me.btnMobileClear.UseVisualStyleBackColor = True
        '
        'btnOkMobileInfo
        '
        Me.btnOkMobileInfo.Location = New System.Drawing.Point(274, 309)
        Me.btnOkMobileInfo.Name = "btnOkMobileInfo"
        Me.btnOkMobileInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnOkMobileInfo.TabIndex = 18
        Me.btnOkMobileInfo.Text = "Ok"
        Me.btnOkMobileInfo.UseVisualStyleBackColor = True
        '
        'Mobile_Information
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 344)
        Me.Controls.Add(Me.btnOkMobileInfo)
        Me.Controls.Add(Me.btnMobileClear)
        Me.Controls.Add(Me.chkMobileAdd)
        Me.Controls.Add(Me.btnCancelMobile)
        Me.Controls.Add(Me.btnMobileSave)
        Me.Controls.Add(Me.txtMobileRemark)
        Me.Controls.Add(Me.txtMobileOwner)
        Me.Controls.Add(Me.txtMobileIccid)
        Me.Controls.Add(Me.txtMobilePin)
        Me.Controls.Add(Me.txtMobilePuk)
        Me.Controls.Add(Me.txtMobileNumber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgrMobileInfo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Mobile_Information"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mobile_Information"
        CType(Me.dgrMobileInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgrMobileInfo As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtMobilePuk As System.Windows.Forms.TextBox
    Friend WithEvents txtMobilePin As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileIccid As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileOwner As System.Windows.Forms.TextBox
    Friend WithEvents txtMobileRemark As System.Windows.Forms.TextBox
    Friend WithEvents btnMobileSave As System.Windows.Forms.Button
    Friend WithEvents btnCancelMobile As System.Windows.Forms.Button
    Friend WithEvents chkMobileAdd As System.Windows.Forms.CheckBox
    Friend WithEvents btnMobileClear As System.Windows.Forms.Button
    Friend WithEvents btnOkMobileInfo As System.Windows.Forms.Button
End Class
