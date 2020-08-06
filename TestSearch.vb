Public Class TestSearch
    Dim con As New OleDb.OleDbConnection
    Private Sub CustomerBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ShegerDBDataSet)

    End Sub
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.CustomerDataGridView.DataSource = dt

        con.Close()
    End Sub

    Private Sub TestSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShegerDBDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.ShegerDBDataSet.Customer)
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        'Data Source="C:\Users\Bisrat\documents\visual studio 2010\Projects\Sheger PLC\Sheger PLC\ShegerDB.accdb
        Me.RefreshData()
    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.CustomerTableAdapter.FillBy(Me.ShegerDBDataSet.Customer)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillBy1ToolStripButton.Click
        Try
            Me.CustomerTableAdapter.FillBy1(Me.ShegerDBDataSet.Customer, FirstNameToolStripTextBox.Text)
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
        cmd.CommandText = "SELECT * FROM Customer WHERE [FirstName] LIKE '" & Me.textData.Text & "%'"



        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer WHERE [FirstName] LIKE '" & Me.textData.Text & "%'", con)

        Dim dt As New DataTable
        da.Fill(dt)
        Me.CustomerDataGridView.DataSource = dt
        'RefreshData()
    End Sub

    Private Sub textData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textData.TextChanged
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Customer WHERE [FirstName] LIKE '" & Me.textData.Text & "%'"



        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Customer WHERE [FirstName] LIKE '" & Me.textData.Text & "%'", con)

        Dim dt As New DataTable
        da.Fill(dt)
        Me.CustomerDataGridView.DataSource = dt
    End Sub
End Class