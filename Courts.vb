
Public Class Courts
    Dim con As New OleDb.OleDbConnection
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Courts", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt

        con.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Courts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
        txtCourtNameCourts.Enabled = False
        txtLocationCourts.Enabled = False
        txtPhoneNumber1Courts.Enabled = False
        txtPhoneNumber2Courts.Enabled = False
        Label1.Enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
        Label4.Enabled = False
        btnCancelCourts.Enabled = False
        btnSaveCourts.Enabled = False
    End Sub

    Private Sub chkCourts_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCourts.CheckedChanged
        If chkCourts.Checked = True Then
            txtCourtNameCourts.Enabled = True
            txtLocationCourts.Enabled = True
            txtPhoneNumber1Courts.Enabled = True
            txtPhoneNumber2Courts.Enabled = True
            Label1.Enabled = True
            Label2.Enabled = True
            Label3.Enabled = True
            Label4.Enabled = True
            btnCancelCourts.Enabled = True
            btnSaveCourts.Enabled = True
        End If
        If chkCourts.Checked = False Then
            txtCourtNameCourts.Enabled = False
            txtLocationCourts.Enabled = False
            txtPhoneNumber1Courts.Enabled = False
            txtPhoneNumber2Courts.Enabled = False
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
            btnCancelCourts.Enabled = False
            btnSaveCourts.Enabled = False
        End If
    End Sub

    Private Sub btnCancelCourts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelCourts.Click
        chkCourts.Checked = False
    End Sub

    Private Sub btnSaveCourts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCourts.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Courts VALUES('" & Me.txtCourtNameCourts.Text & "','" & Me.txtLocationCourts.Text & "','" & Me.txtPhoneNumber1Courts.Text & "','" & Me.txtPhoneNumber2Courts.Text & "')"


        cmd.ExecuteNonQuery()
        RefreshData()
    End Sub
End Class