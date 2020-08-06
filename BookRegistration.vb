Public Class BookRegistration
    Dim con As New OleDb.OleDbConnection
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Book", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgrBookRegistration.DataSource = dt

        con.Close()
    End Sub
    Private Sub btnCancelRegistraiton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelRegistraiton.Click
        Me.Close()

    End Sub

    Private Sub BookRegistration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        'Data Source="C:\Users\Bisrat\documents\visual studio 2010\Projects\Sheger PLC\Sheger PLC\ShegerDB.accdb
        Me.RefreshData()
    End Sub

    Private Sub btnSaveRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveRegistration.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Book VALUES('" & Me.txtBookCodeRegisteration.Text & "','" & Me.txtBookTitleRegistration.Text & "','" & Me.txtBookAuthorRegistration.Text & "','" & Me.txtNoOfPagesBookRegistration.Text & "', '" & Me.txtPublisherRegistration.Text & "' ,'" & Me.txtYearPublishedRegistration.Text & "','" & Me.drpdwnCategoryBook.SelectedItem & "')"

        cmd.ExecuteNonQuery()
        RefreshData()
    End Sub

    Private Sub btnClearRegistration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearRegistration.Click
        txtBookAuthorRegistration.Text = ""
        txtBookCodeRegisteration.Text = ""
        txtBookTitleRegistration.Text = ""
        txtNoOfPagesBookRegistration.Text = ""
        txtPublisherRegistration.Text = ""
        txtYearPublishedRegistration.Text = ""

    End Sub
End Class