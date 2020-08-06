Public Class Banks
    Dim con As New OleDb.OleDbConnection
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Banks", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgdBanks.DataSource = dt


        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Banks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
        Label1.Enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
        Label4.Enabled = False
        txtBankNameBanks.Enabled = False
        txtLocationBanks.Enabled = False
        txtPhonenNumber2Banks.Enabled = False
        txtPhoneNumber1Banks.Enabled = False
        btnCancelBanks.Enabled = False
        btmSaveBanks.Enabled = False

    End Sub

    Private Sub chkaAddNewRecordBanks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkaAddNewRecordBanks.CheckedChanged
        If chkaAddNewRecordBanks.Checked = True Then
            Label1.Enabled = True
            Label2.Enabled = True
            Label3.Enabled = True
            Label4.Enabled = True
            txtBankNameBanks.Enabled = True
            txtLocationBanks.Enabled = True
            txtPhonenNumber2Banks.Enabled = True
            txtPhoneNumber1Banks.Enabled = True
            btmSaveBanks.Enabled = True
            btnCancelBanks.Enabled = True
        End If
        If chkaAddNewRecordBanks.Checked = False Then
            Label1.Enabled = False
            Label2.Enabled = False
            Label3.Enabled = False
            Label4.Enabled = False
            txtBankNameBanks.Enabled = False
            txtLocationBanks.Enabled = False
            txtPhonenNumber2Banks.Enabled = False
            txtPhoneNumber1Banks.Enabled = False
            btmSaveBanks.Enabled = False
            btnCancelBanks.Enabled = False


        End If
    End Sub

    Private Sub btnCancelBanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelBanks.Click
        chkaAddNewRecordBanks.Checked = False
        '' Me.Close()

    End Sub

    Private Sub btmSaveBanks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmSaveBanks.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Banks VALUES('" & Me.txtBankNameBanks.Text & "','" & Me.txtLocationBanks.Text & "','" & Me.txtPhoneNumber1Banks.Text & "','" & Me.txtPhonenNumber2Banks.Text & "')"

        cmd.ExecuteNonQuery()
        RefreshData()
    End Sub
End Class