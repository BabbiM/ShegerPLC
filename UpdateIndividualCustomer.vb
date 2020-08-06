Public Class UpdateIndividualCustomer
    Dim con As New OleDb.OleDbConnection

    Private Sub UpdateIndividualCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShegerDBDataSet.Customer' table. You can move, or remove it, as needed.
        '' Me.CustomerTableAdapter.Fill(Me.ShegerDBDataSet.Customer)
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
    End Sub
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt

        con.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnOkUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkUpdate.Click
        Me.Close()

    End Sub

    Private Sub FillBy5ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.CustomerTableAdapter.FillBy5(Me.ShegerDBDataSet.Customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

   

    

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "UPDATE Customer SET [FirstName]='" & Me.txtUpdateNewFirst.Text & "' WHERE [FirstName] ='" & Me.txtPrevFirstNameUpdate.Text & "'"

        ', [LastName]='" & Me.txtUpdateLast.Text & "',[MobilePhoneNumber1]= '" & Me.TxtMobilePhone1Update.Text & "'

        'Dim cmdText As String = "UPDATE Animals SET LatinName=?,LocationFound=?,AverageHeight=?," + 
        '"AverageWeight = ?, DietaryNeeds = ?, ConservationStatus = ?, " + 
        '"AverageLifeSpan = ?, BreedingSeason = ?, AverageLength = ? " +
        ' "WHERE AnimalName = ?"
        cmd.ExecuteNonQuery()
        RefreshData()
    End Sub

    Private Sub FillBy8ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy8ToolStripButton.Click
        Try
            Me.CustomerTableAdapter.FillBy8(Me.ShegerDBDataSet.Customer, FirstNameToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class