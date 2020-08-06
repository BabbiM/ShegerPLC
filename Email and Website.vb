
Public Class Email_and_Website
    Dim con As New OleDb.OleDbConnection
    Private Property ShegerDB As Object
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Email", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgrdEmailWebsite.DataSource = dt

        con.Close()
    End Sub


    Private Sub chkSerchEmail_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSerchEmail.CheckedChanged
        If chkSerchEmail.Checked = True Then
            txtEmailAddress.Enabled = True
            txtEmailFullname.Enabled = True
            txtRemarkEmailWebsite.Enabled = True
            txtEmailOwner.Enabled = True
            lblEmail.Enabled = True
            lblPassword.Enabled = True
            lblRemark.Enabled = True
            lblOwner.Enabled = True
        End If
        If chkSerchEmail.Checked = False Then
            txtEmailAddress.Enabled = False
            txtEmailFullname.Enabled = False
            txtEmailOwner.Enabled = False
            txtRemarkEmailWebsite.Enabled = False
            lblEmail.Enabled = False
            lblPassword.Enabled = False
            lblRemark.Enabled = False
            lblOwner.Enabled = False
            '  dgrdEmailWebsite.Enabled = flase
        End If
    End Sub

    Private Sub Email_and_Website_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
        txtEmailAddress.Enabled = False
        txtEmailFullname.Enabled = False
        txtEmailOwner.Enabled = False
        txtRemarkEmailWebsite.Enabled = False
        lblEmail.Enabled = False
        lblPassword.Enabled = False
        lblRemark.Enabled = False
        lblOwner.Enabled = False

    End Sub

    Private Sub btnEmailSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailSave.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Email VALUES('" & Me.txtEmailFullname.Text & "','" & Me.txtEmailAddress.Text & "','" & Me.txtEmailOwner.Text & "','" & "')"
        cmd.ExecuteNonQuery()
        RefreshData()
    End Sub

    Private Sub lblSerchByEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEmailClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailClear.Click
        txtEmailAddress.Text = ""
        txtEmailFullname.Text = ""
        txtEmailOwner.Text = ""
    End Sub

    Private Sub btnCancelEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelEmail.Click
        Me.Close()

    End Sub

    Private Sub btnSearchEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class