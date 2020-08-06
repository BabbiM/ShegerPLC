Public Class CaseAssociation
    Dim con As New OleDb.OleDbConnection
    Private Sub RefreshData()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM CaseAssociation", con)
        Dim dt As New DataTable
        da.Fill(dt)
        Me.dgrCasetAssoc.DataSource = dt

        con.Close()
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnPrevCaseAso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevCaseAso.Click
        IndividualCustomerRegestration.Show()
        Me.Hide()
        '=IndividualCustomerRegestration.indiTxtCustomerCode.Text

    End Sub

    Private Sub btnCancelCaseAssoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelCaseAssoc.Click
        Me.Close()


    End Sub

    Private Sub btnClearCaseAssoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearCaseAssoc.Click
        txtCourtCaseAssoc.Text = ""
        txtCourtPhoneCaseAssoc.Text = ""
        txtCourtWoredaCaseAssoc.Text = ""
        MsgBox("Please note that you can clear only the data belongs to this form.i.e You need to get back to the previous form to register a new customer and associate a case with the customer.")


    End Sub

    Private Sub btnSaveCaseAssoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveCaseAssoc.Click
        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO CaseAssociation VALUES('" & Me.txtCustomerCodeCaseAssoc.Text & "','" & Me.txtFirstNameCaseAssoc.Text & "','" & Me.txtMiddleNameCaseAssoc.Text & "','" & Me.txtFileNumberCaseAssoc.Text & "','" & Me.txtCaseCaseAssoc.Text & "', '" & Me.txtCourtCaseAssoc.Text & "' ,'" & Me.txtCourtPhoneCaseAssoc.Text & "' ,'" & Me.txtCourtPhoneCaseAssoc.Text & "')"

        cmd.ExecuteNonQuery()
        RefreshData()
    End Sub

    Private Sub CaseAssociation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class