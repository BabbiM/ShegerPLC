<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Email_and_Website
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Email_and_Website))
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblOwner = New System.Windows.Forms.Label()
        Me.txtEmailFullname = New System.Windows.Forms.TextBox()
        Me.txtEmailAddress = New System.Windows.Forms.TextBox()
        Me.txtEmailOwner = New System.Windows.Forms.TextBox()
        Me.btnEmailSave = New System.Windows.Forms.Button()
        Me.btnCancelEmail = New System.Windows.Forms.Button()
        Me.chkSerchEmail = New System.Windows.Forms.CheckBox()
        Me.dgrdEmailWebsite = New System.Windows.Forms.DataGridView()
        Me.btnEmailClear = New System.Windows.Forms.Button()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.txtRemarkEmailWebsite = New System.Windows.Forms.TextBox()
        CType(Me.dgrdEmailWebsite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(12, 36)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(76, 13)
        Me.lblEmail.TabIndex = 0
        Me.lblEmail.Text = "Email Address:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(12, 60)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(56, 13)
        Me.lblPassword.TabIndex = 1
        Me.lblPassword.Text = "Password:"
        '
        'lblOwner
        '
        Me.lblOwner.AutoSize = True
        Me.lblOwner.Location = New System.Drawing.Point(12, 86)
        Me.lblOwner.Name = "lblOwner"
        Me.lblOwner.Size = New System.Drawing.Size(41, 13)
        Me.lblOwner.TabIndex = 2
        Me.lblOwner.Text = "Owner:"
        '
        'txtEmailFullname
        '
        Me.txtEmailFullname.Location = New System.Drawing.Point(126, 28)
        Me.txtEmailFullname.Name = "txtEmailFullname"
        Me.txtEmailFullname.Size = New System.Drawing.Size(192, 20)
        Me.txtEmailFullname.TabIndex = 3
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(126, 53)
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(192, 20)
        Me.txtEmailAddress.TabIndex = 4
        '
        'txtEmailOwner
        '
        Me.txtEmailOwner.Location = New System.Drawing.Point(126, 79)
        Me.txtEmailOwner.Name = "txtEmailOwner"
        Me.txtEmailOwner.Size = New System.Drawing.Size(192, 20)
        Me.txtEmailOwner.TabIndex = 5
        '
        'btnEmailSave
        '
        Me.btnEmailSave.Location = New System.Drawing.Point(25, 146)
        Me.btnEmailSave.Name = "btnEmailSave"
        Me.btnEmailSave.Size = New System.Drawing.Size(75, 23)
        Me.btnEmailSave.TabIndex = 6
        Me.btnEmailSave.Text = "Save"
        Me.btnEmailSave.UseVisualStyleBackColor = True
        '
        'btnCancelEmail
        '
        Me.btnCancelEmail.Location = New System.Drawing.Point(232, 146)
        Me.btnCancelEmail.Name = "btnCancelEmail"
        Me.btnCancelEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelEmail.TabIndex = 8
        Me.btnCancelEmail.Text = "Cancel"
        Me.btnCancelEmail.UseVisualStyleBackColor = True
        '
        'chkSerchEmail
        '
        Me.chkSerchEmail.AutoSize = True
        Me.chkSerchEmail.Location = New System.Drawing.Point(15, 3)
        Me.chkSerchEmail.Name = "chkSerchEmail"
        Me.chkSerchEmail.Size = New System.Drawing.Size(110, 17)
        Me.chkSerchEmail.TabIndex = 9
        Me.chkSerchEmail.Text = "Add a new record"
        Me.chkSerchEmail.UseVisualStyleBackColor = True
        '
        'dgrdEmailWebsite
        '
        Me.dgrdEmailWebsite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrdEmailWebsite.EnableHeadersVisualStyles = False
        Me.dgrdEmailWebsite.Location = New System.Drawing.Point(337, 28)
        Me.dgrdEmailWebsite.Name = "dgrdEmailWebsite"
        Me.dgrdEmailWebsite.Size = New System.Drawing.Size(476, 221)
        Me.dgrdEmailWebsite.TabIndex = 13
        '
        'btnEmailClear
        '
        Me.btnEmailClear.Location = New System.Drawing.Point(126, 146)
        Me.btnEmailClear.Name = "btnEmailClear"
        Me.btnEmailClear.Size = New System.Drawing.Size(75, 23)
        Me.btnEmailClear.TabIndex = 14
        Me.btnEmailClear.Text = "Add New"
        Me.btnEmailClear.UseVisualStyleBackColor = True
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Location = New System.Drawing.Point(12, 113)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(47, 13)
        Me.lblRemark.TabIndex = 15
        Me.lblRemark.Text = "Remark:"
        '
        'txtRemarkEmailWebsite
        '
        Me.txtRemarkEmailWebsite.Location = New System.Drawing.Point(126, 106)
        Me.txtRemarkEmailWebsite.Name = "txtRemarkEmailWebsite"
        Me.txtRemarkEmailWebsite.Size = New System.Drawing.Size(192, 20)
        Me.txtRemarkEmailWebsite.TabIndex = 16
        '
        'Email_and_Website
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 261)
        Me.Controls.Add(Me.txtRemarkEmailWebsite)
        Me.Controls.Add(Me.lblRemark)
        Me.Controls.Add(Me.btnEmailClear)
        Me.Controls.Add(Me.dgrdEmailWebsite)
        Me.Controls.Add(Me.chkSerchEmail)
        Me.Controls.Add(Me.btnCancelEmail)
        Me.Controls.Add(Me.btnEmailSave)
        Me.Controls.Add(Me.txtEmailOwner)
        Me.Controls.Add(Me.txtEmailAddress)
        Me.Controls.Add(Me.txtEmailFullname)
        Me.Controls.Add(Me.lblOwner)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Email_and_Website"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email_and_Website"
        CType(Me.dgrdEmailWebsite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblOwner As System.Windows.Forms.Label
    Friend WithEvents txtEmailFullname As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailOwner As System.Windows.Forms.TextBox
    Friend WithEvents btnEmailSave As System.Windows.Forms.Button
    Friend WithEvents btnCancelEmail As System.Windows.Forms.Button
    Friend WithEvents chkSerchEmail As System.Windows.Forms.CheckBox
    Friend WithEvents dgrdEmailWebsite As System.Windows.Forms.DataGridView
    Friend WithEvents btnEmailClear As System.Windows.Forms.Button
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents txtRemarkEmailWebsite As System.Windows.Forms.TextBox
End Class
