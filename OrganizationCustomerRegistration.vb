Public Class OrganizationCustomerRegistration
    Dim cnn As New OleDb.OleDbConnection

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnOrganizationRegistrationCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganizationRegistrationCancel.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles drpdwnOrganizationType.SelectedIndexChanged

    End Sub

    Private Sub OrganizationCustomerRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
    End Sub
    Private Sub RefreshData()
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Organizations", cnn)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgvData.DataSource = dt

        cnn.Close()

    End Sub
    Private Sub btnOrganizationRegistrationSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrganizationRegistrationSave.Click

        Dim cmd As New OleDb.OleDbCommand
        If Not cnn.State = ConnectionState.Open Then
            cnn.Open()
        End If
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO Organizations VALUES('" & Me.txtOrganizationCode.Text & "', '" & Me.txtOrganizationName.Text & "', '" & _
        Me.drpdwnOrganizationType.SelectedItem & "', '" & Me.txtRegion.Text & "' , '" & _
        Me.txtCity.Text & "', '" & Me.txtWoredaOrg.Text & "' , '" & _
        Me.txtContactPerson.Text & "', '" & Me.txtTelephoneNumber.Text & "', '" & Me.txtMobileNumber.Text & "')"
        cmd.ExecuteNonQuery()
        cnn.Close()
        RefreshData()

    End Sub
End Class