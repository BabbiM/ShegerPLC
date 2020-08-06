<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Banks))
        Me.dgdBanks = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkaAddNewRecordBanks = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBankNameBanks = New System.Windows.Forms.TextBox()
        Me.txtLocationBanks = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber1Banks = New System.Windows.Forms.TextBox()
        Me.txtPhonenNumber2Banks = New System.Windows.Forms.TextBox()
        Me.btmSaveBanks = New System.Windows.Forms.Button()
        Me.btnCancelBanks = New System.Windows.Forms.Button()
        CType(Me.dgdBanks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgdBanks
        '
        Me.dgdBanks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdBanks.Location = New System.Drawing.Point(22, 170)
        Me.dgdBanks.Name = "dgdBanks"
        Me.dgdBanks.Size = New System.Drawing.Size(664, 161)
        Me.dgdBanks.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkaAddNewRecordBanks
        '
        Me.chkaAddNewRecordBanks.AutoSize = True
        Me.chkaAddNewRecordBanks.Location = New System.Drawing.Point(22, 12)
        Me.chkaAddNewRecordBanks.Name = "chkaAddNewRecordBanks"
        Me.chkaAddNewRecordBanks.Size = New System.Drawing.Size(110, 17)
        Me.chkaAddNewRecordBanks.TabIndex = 2
        Me.chkaAddNewRecordBanks.Text = "Add a new record"
        Me.chkaAddNewRecordBanks.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Bank Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Phone Nubmber1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone Number2"
        '
        'txtBankNameBanks
        '
        Me.txtBankNameBanks.Location = New System.Drawing.Point(178, 26)
        Me.txtBankNameBanks.Name = "txtBankNameBanks"
        Me.txtBankNameBanks.Size = New System.Drawing.Size(313, 20)
        Me.txtBankNameBanks.TabIndex = 7
        '
        'txtLocationBanks
        '
        Me.txtLocationBanks.Location = New System.Drawing.Point(178, 49)
        Me.txtLocationBanks.Name = "txtLocationBanks"
        Me.txtLocationBanks.Size = New System.Drawing.Size(313, 20)
        Me.txtLocationBanks.TabIndex = 8
        '
        'txtPhoneNumber1Banks
        '
        Me.txtPhoneNumber1Banks.Location = New System.Drawing.Point(178, 75)
        Me.txtPhoneNumber1Banks.Name = "txtPhoneNumber1Banks"
        Me.txtPhoneNumber1Banks.Size = New System.Drawing.Size(313, 20)
        Me.txtPhoneNumber1Banks.TabIndex = 9
        '
        'txtPhonenNumber2Banks
        '
        Me.txtPhonenNumber2Banks.Location = New System.Drawing.Point(178, 101)
        Me.txtPhonenNumber2Banks.Name = "txtPhonenNumber2Banks"
        Me.txtPhonenNumber2Banks.Size = New System.Drawing.Size(313, 20)
        Me.txtPhonenNumber2Banks.TabIndex = 10
        '
        'btmSaveBanks
        '
        Me.btmSaveBanks.Location = New System.Drawing.Point(114, 141)
        Me.btmSaveBanks.Name = "btmSaveBanks"
        Me.btmSaveBanks.Size = New System.Drawing.Size(75, 23)
        Me.btmSaveBanks.TabIndex = 11
        Me.btmSaveBanks.Text = "Save"
        Me.btmSaveBanks.UseVisualStyleBackColor = True
        '
        'btnCancelBanks
        '
        Me.btnCancelBanks.Location = New System.Drawing.Point(337, 141)
        Me.btnCancelBanks.Name = "btnCancelBanks"
        Me.btnCancelBanks.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelBanks.TabIndex = 12
        Me.btnCancelBanks.Text = "Cancel"
        Me.btnCancelBanks.UseVisualStyleBackColor = True
        '
        'Banks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 363)
        Me.Controls.Add(Me.btnCancelBanks)
        Me.Controls.Add(Me.btmSaveBanks)
        Me.Controls.Add(Me.txtPhonenNumber2Banks)
        Me.Controls.Add(Me.txtPhoneNumber1Banks)
        Me.Controls.Add(Me.txtLocationBanks)
        Me.Controls.Add(Me.txtBankNameBanks)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkaAddNewRecordBanks)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgdBanks)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Banks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Banks"
        CType(Me.dgdBanks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgdBanks As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkaAddNewRecordBanks As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBankNameBanks As System.Windows.Forms.TextBox
    Friend WithEvents txtLocationBanks As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber1Banks As System.Windows.Forms.TextBox
    Friend WithEvents txtPhonenNumber2Banks As System.Windows.Forms.TextBox
    Friend WithEvents btmSaveBanks As System.Windows.Forms.Button
    Friend WithEvents btnCancelBanks As System.Windows.Forms.Button
End Class
