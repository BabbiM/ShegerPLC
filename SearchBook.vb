Public Class SearchBook
    Dim con As New OleDb.OleDbConnection
    Private Property ShegerDB As Object
    Dim dbprovider As String
    Dim dbsource As String
    Dim ds As New DataSet
    Dim sql As String = "SELECT * FROM Book"
    Dim da As New OleDb.OleDbDataAdapter
    Dim len As Integer
    Dim i As Integer
    Private Sub SearchBook_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ShegerDBDataSet.Book' table. You can move, or remove it, as needed.
        ' Me.BookTableAdapter.Fill(Me.ShegerDBDataSet.Book)
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        con.Open()
        da = New OleDb.OleDbDataAdapter(Sql, con)
        '' da.Fill(ds, "ShegerDB")
        '' len = da.Fill(ds, "ShegerDB")
        da.Fill(ds)
        Len = da.Fill(ds, "ShegerDB")
    End Sub

    Private Sub FillBy2ToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim Book_Code As Object = New Object()
            Me.BookTableAdapter.FillBy2(Me.ShegerDBDataSet.Book, Book_Code)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtSearchBookTitleM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchBookTitleM.TextChanged
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Book WHERE [Title] LIKE '" & Me.txtSearchBookTitleM.Text & "%'"



        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Book WHERE [Title] LIKE '" & Me.txtSearchBookTitleM.Text & "%'", con)

        Dim dt As New DataTable
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub txtSearchBookAuthorM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchBookAuthorM.TextChanged
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "SELECT * FROM Book WHERE [Author] LIKE '" & Me.txtSearchBookAuthorM.Text & "%'"



        cmd.ExecuteNonQuery()
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Book WHERE [Author] LIKE '" & Me.txtSearchBookAuthorM.Text & "%'", con)

        Dim dt As New DataTable
        da.Fill(dt)
        Me.DataGridView1.DataSource = dt
    End Sub
End Class