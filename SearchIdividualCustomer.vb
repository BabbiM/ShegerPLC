Public Class SearchIdividualCustomer
    Dim con As New OleDb.OleDbConnection
    Private Property ShegerDB As Object
    Dim dbprovider As String
    Dim dbsource As String
    Dim ds As New DataSet
    Dim sql As String = "SELECT * FROm Customer"
    Dim da As New OleDb.OleDbDataAdapter
    Dim len As Integer
    Dim i As Integer





    Private Sub RefreshData()
        '   TextBox1.Text = ds.Tables("ShegerDB").Rows(i).Item(1).ToString

        ' TextBox2.Text = ds.Tables("ShegerDB").Rows(1).Item(1)

        '' If Not con.State = ConnectionState.Open Then
        ''con.Open()
        ''  End If
        'Dim cmd As New OleDb.OleDbCommand
        'cmd.Connection = con
        'cmd.CommandText = "SELECT * FROM Customer WHERE FirstName LIKE '" & Me.txtSearchFirstName.Text & "'"
        'cmd.CommandText = "SELECT * FROM Customer WHERE FirstName LIKE '" & Me.txtSearchFirstName.Text & "'"
        'cmd.ExecuteNonQuery()
        'Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer WHERE FirstName LIKE '" & Me.txtSearchFirstName.Text & "'", con)
        '' Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer ", con)
        '' Dim dt As New DataTable
        ''da.Fill(dt)
        ''Me.DgvSearchIndiCustomer.DataSource = dt
        ''con.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchCustomerBtnCancel.Click
        Me.Close()
    End Sub

    Private Sub SearchIdividualCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShegerDBDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.ShegerDBDataSet.Customer)
        'TODO: This line of code loads data into the 'ShegerDBDataSet.Customer' table. You can move, or remove it, as needed.
        ''Me.CustomerTableAdapter.Fill(Me.ShegerDBDataSet.Customer)
        'TODO: This line of code loads data into the 'DataSet1.Customer' table. You can move, or remove it, as needed.
        ' Me.CustomerTableAdapter.Fill(Me.DataSet1.Customer)
        ''con = New OleDb.OleDbConnection
        ''con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        ''dbprovider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        ''dbsource = "Data Source = C:\Users\Bisrat\Documents\Visual Studio 2010\Projects\Sheger PLC\Sheger PLC\ShegerDB.accdb"
        ''con.ConnectionString = dbprovider & dbsource
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        con.Open()
        da = New OleDb.OleDbDataAdapter(sql, con)
        '' da.Fill(ds, "ShegerDB")
        '' len = da.Fill(ds, "ShegerDB")
        da.Fill(ds)
        len = da.Fill(ds, "ShegerDB")



    End Sub

    

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)











    End Sub

    Private Sub drpdwnSerachByIndividual_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        '' Label2.Text = drpdwnSerachByIndividual.SelectedItem.ToString


    End Sub

    Private Sub FillBy2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableAdapter.FillBy2(Me.ShegerDBDataSet.Customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    


   



    Private Sub DgvSearchIndiCustomer_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvSearchIndiCustomer.CellContentClick

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchEngineFirstName.TextChanged
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Customer WHERE [FirstName] LIKE '" & Me.SearchEngineFirstName.Text & "%'"



        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer WHERE [FirstName] LIKE '" & Me.SearchEngineFirstName.Text & "%'", con)

        Dim dt As New DataTable
        da.Fill(dt)
        Me.DgvSearchIndiCustomer.DataSource = dt
    End Sub

    Private Sub txtSearchEngineLast_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchEngineLast.TextChanged
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Customer WHERE [LastName] LIKE '" & Me.txtSearchEngineLast.Text & "%'"



        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer WHERE [LastName] LIKE '" & Me.txtSearchEngineLast.Text & "%'", con)

        Dim dt As New DataTable
        da.Fill(dt)
        Me.DgvSearchIndiCustomer.DataSource = dt
    End Sub
End Class