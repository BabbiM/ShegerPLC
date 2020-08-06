Public Class SearchOrganizationCustomer
    Dim con As New OleDb.OleDbConnection
    Private Property ShegerDB As Object
    Dim dbprovider As String
    Dim dbsource As String
    Dim ds As New DataSet
    Dim sql As String = "SELECT * FROm Customer"
    Dim da As New OleDb.OleDbDataAdapter
    Dim len As Integer
    Dim i As Integer
    Private Sub btnSearchOrganizationCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchOrganizationCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSearchOrganizationSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)





    End Sub

    Private Sub txtSearchOrganization_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub SearchOrganizationCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShegerDBDataSet.Organizations' table. You can move, or remove it, as needed.
        Me.OrganizationsTableAdapter.Fill(Me.ShegerDBDataSet.Organizations)
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        con.Open()
        da = New OleDb.OleDbDataAdapter(Sql, con)
        '' da.Fill(ds, "ShegerDB")
        '' len = da.Fill(ds, "ShegerDB")
        da.Fill(ds)
        Len = da.Fill(ds, "ShegerDB")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'Label2.Text = ComboBox1.SelectedItem.ToString


    End Sub

   
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles srcOrganization.TextChanged
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Organizations WHERE [OrganizationName] LIKE '" & Me.srcOrganization.Text & "%'"



        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Organizations WHERE [OrganizationName] LIKE '" & Me.srcOrganization.Text & "%'", con)

        Dim dt As New DataTable
        da.Fill(dt)
        Me.drdSearchCustomer.DataSource = dt
    End Sub
End Class