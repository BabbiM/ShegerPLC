<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Courts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Courts))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkCourts = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCourtNameCourts = New System.Windows.Forms.TextBox()
        Me.txtLocationCourts = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber1Courts = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber2Courts = New System.Windows.Forms.TextBox()
        Me.btnSaveCourts = New System.Windows.Forms.Button()
        Me.btnCancelCourts = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 183)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(662, 138)
        Me.DataGridView1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'chkCourts
        '
        Me.chkCourts.AutoSize = True
        Me.chkCourts.Location = New System.Drawing.Point(24, 9)
        Me.chkCourts.Name = "chkCourts"
        Me.chkCourts.Size = New System.Drawing.Size(110, 17)
        Me.chkCourts.TabIndex = 2
        Me.chkCourts.Text = "Add a new record"
        Me.chkCourts.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Location = New System.Drawing.Point(24, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Court Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(24, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Location"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(24, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Phone Number1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Location = New System.Drawing.Point(24, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Phone Nubmer2"
        '
        'txtCourtNameCourts
        '
        Me.txtCourtNameCourts.Enabled = False
        Me.txtCourtNameCourts.Location = New System.Drawing.Point(180, 33)
        Me.txtCourtNameCourts.Name = "txtCourtNameCourts"
        Me.txtCourtNameCourts.Size = New System.Drawing.Size(466, 20)
        Me.txtCourtNameCourts.TabIndex = 7
        '
        'txtLocationCourts
        '
        Me.txtLocationCourts.Enabled = False
        Me.txtLocationCourts.Location = New System.Drawing.Point(180, 60)
        Me.txtLocationCourts.Name = "txtLocationCourts"
        Me.txtLocationCourts.Size = New System.Drawing.Size(343, 20)
        Me.txtLocationCourts.TabIndex = 8
        '
        'txtPhoneNumber1Courts
        '
        Me.txtPhoneNumber1Courts.Enabled = False
        Me.txtPhoneNumber1Courts.Location = New System.Drawing.Point(180, 87)
        Me.txtPhoneNumber1Courts.Name = "txtPhoneNumber1Courts"
        Me.txtPhoneNumber1Courts.Size = New System.Drawing.Size(230, 20)
        Me.txtPhoneNumber1Courts.TabIndex = 9
        '
        'txtPhoneNumber2Courts
        '
        Me.txtPhoneNumber2Courts.Enabled = False
        Me.txtPhoneNumber2Courts.Location = New System.Drawing.Point(180, 114)
        Me.txtPhoneNumber2Courts.Name = "txtPhoneNumber2Courts"
        Me.txtPhoneNumber2Courts.Size = New System.Drawing.Size(230, 20)
        Me.txtPhoneNumber2Courts.TabIndex = 10
        '
        'btnSaveCourts
        '
        Me.btnSaveCourts.Location = New System.Drawing.Point(148, 154)
        Me.btnSaveCourts.Name = "btnSaveCourts"
        Me.btnSaveCourts.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCourts.TabIndex = 11
        Me.btnSaveCourts.Text = "Save"
        Me.btnSaveCourts.UseVisualStyleBackColor = True
        '
        'btnCancelCourts
        '
        Me.btnCancelCourts.Location = New System.Drawing.Point(353, 154)
        Me.btnCancelCourts.Name = "btnCancelCourts"
        Me.btnCancelCourts.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelCourts.TabIndex = 12
        Me.btnCancelCourts.Text = "Cancel"
        Me.btnCancelCourts.UseVisualStyleBackColor = True
        '
        'Courts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 363)
        Me.Controls.Add(Me.btnCancelCourts)
        Me.Controls.Add(Me.btnSaveCourts)
        Me.Controls.Add(Me.txtPhoneNumber2Courts)
        Me.Controls.Add(Me.txtPhoneNumber1Courts)
        Me.Controls.Add(Me.txtLocationCourts)
        Me.Controls.Add(Me.txtCourtNameCourts)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkCourts)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Courts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Courts"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkCourts As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCourtNameCourts As System.Windows.Forms.TextBox
    Friend WithEvents txtLocationCourts As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber1Courts As System.Windows.Forms.TextBox
    Friend WithEvents txtPhoneNumber2Courts As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveCourts As System.Windows.Forms.Button
    Friend WithEvents btnCancelCourts As System.Windows.Forms.Button
End Class
