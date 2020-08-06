Public Class BookBorrow
    Dim con As New OleDb.OleDbConnection
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM BookBorrow", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgdBookBorrow.DataSource = dt

        con.Close()
    End Sub
    Private Sub btnCancelBookBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelBookBorrow.Click
        Me.Close()

    End Sub

    Private Sub BookBorrow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
    End Sub

    Private Sub btnSaveBookBorrow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveBookBorrow.Click
        Dim cmd As New OleDb.OleDbCommand
        Dim cmdDelete As New OleDb.OleDbCommand

        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmdDelete.Connection = con

        cmd.CommandText = "INSERT INTO BookBorrow VALUES('" & Me.txtBookCodeBookBorrow.Text & "','" & Me.txtBookTitleBookBorrow.Text & "','" & Me.txtFullNameBookBorrow.Text & "','" & Me.txtYearPublishedBookBorrow.Text & "','" & Me.txtAuthorBookBorrow.Text & "','" & Me.DateTimePicker1.Value & "')"
        cmdDelete.CommandText = " DELETE FROM Book WHERE [BookCode]='" & Me.txtBookCodeBookBorrow.Text & "'"


        cmd.ExecuteNonQuery()
        cmdDelete.ExecuteNonQuery()
        RefreshData()
    End Sub
End Class