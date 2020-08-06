Public Class IndividualCustomerRegestration
    Dim con As New OleDb.OleDbConnection

    Private Property ShegerDB As Object

    Private Sub IndiBtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndiBtnCancel.Click
        Me.Close()
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

    Private Sub IndiBtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndiBtnSave.Click

        Dim cmd As New OleDb.OleDbCommand
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        cmd.Connection = con
        cmd.CommandText = "INSERT INTO Customer VALUES('" & Me.indiTxtCustomerCode.Text & "','" & Me.IndiTxtFirstName.Text & "','" & Me.IndiTxtMiddleName.Text & "','" & Me.IndiTxtLastName.Text & "', '" & Me.IndiDrpDwnSex.SelectedItem & "' ,'" & Me.IndiTxtJobTitle.Text & "','" & Me.DateTimePicker1.Value & "', '" & Me.IndiTxtCase.Text & "', '" & Me.IndiTxtHomePhone.Text & "', '" & Me.IndiTxtOfficePhone.Text & "', '" & Me.IndiTxtMobilePhone1.Text & "', '" & Me.IndiTxtMobilePhone2.Text & "')"
        cmd.ExecuteNonQuery()
        RefreshData()
    End Sub

    Private Sub IndiBtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndiBtnClear.Click
        IndiTxtAddress.Text = ""
        IndiTxtCase.Text = ""
        indiTxtCustomerCode.Text = ""
        IndiTxtFirstName.Text = ""
        IndiTxtHomePhone.Text = ""
        IndiTxtJobTitle.Text = ""
        IndiTxtLastName.Text = ""
        IndiTxtMiddleName.Text = ""
        IndiTxtMobilePhone1.Text = ""
        IndiTxtMobilePhone2.Text = ""
        IndiTxtOfficePhone.Text = ""



    End Sub

    Private Sub IndividualCustomerRegestration_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con = New OleDb.OleDbConnection
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\ShegerDB.accdb"
        Me.RefreshData()
    End Sub

   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button1.Click

        CaseAssociation.txtCaseCaseAssoc.Text = Me.IndiTxtCase.Text
        CaseAssociation.txtMiddleNameCaseAssoc.Text = Me.IndiTxtMiddleName.Text
        CaseAssociation.txtFirstNameCaseAssoc.Text = Me.IndiTxtFirstName.Text
        CaseAssociation.txtCustomerCodeCaseAssoc.Text = Me.indiTxtCustomerCode.Text
        CaseAssociation.Show()
        Me.Hide()

    End Sub
End Class