
Public Class Mobile_Information
    Dim con As New OleDb.OleDbConnection
    Private Property ShegerDB As Object
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Mobile", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgrMobileInfo.DataSource = dt

        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub Mobile_Information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelMobile.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMobileSave.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Mobile VALUES('" & Me.txtMobileNumber.Text & "','" & Me.txtMobilePuk.Text & "','" & Me.txtMobilePin.Text & "','" & Me.txtMobileOwner.Text & "','" & Me.txtMobileRemark.Text & "','" & "')"
        cmd.ExecuteNonQuery()
        RefreshData()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMobileAdd.CheckedChanged
        If chkMobileAdd.Checked = True Then
            txtMobileIccid.Enabled = True
            txtMobileNumber.Enabled = True
            txtMobileOwner.Enabled = True
            txtMobilePin.Enabled = True
            txtMobileRemark.Enabled = True
            txtMobilePuk.Enabled = True
            Label1.Enabled = True
            Label2.Enabled = True
            Label3.Enabled = True
            Label4.Enabled = True
            Label5.Enabled = True
            Label6.Enabled = True
            btnCancelMobile.Enabled = True
            btnMobileSave.Enabled = True
            btnMobileClear.Enabled = True


        End If
        If chkMobileAdd.Checked = False Then
            txtMobileIccid.Enabled = False
            txtMobileNumber.Enabled = False
            txtMobileOwner.Enabled = False
            txtMobilePin.Enabled = False
            txtMobileRemark.Enabled = False
            txtMobilePuk.Enabled = False
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
            Label5.Enabled = False
            Label6.Enabled = False
            btnCancelMobile.Enabled = False
            btnMobileSave.Enabled = False
            btnMobileClear.Enabled = False


        End If


    End Sub

    Private Sub btnMobileClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMobileClear.Click
        txtMobileIccid.Text = ""
        txtMobileNumber.Text = ""
        txtMobilePin.Text = ""
        txtMobilePuk.Text = ""
        txtMobileRemark.Text = ""
        txtMobileOwner.Text = ""

    End Sub

    Private Sub btnOkMobileInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkMobileInfo.Click
        Me.Close()


    End Sub
End Class