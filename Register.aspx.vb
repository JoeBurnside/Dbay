
Partial Class Register
    Inherits System.Web.UI.Page
    'this code handles the click event for the login button
    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'redirect to login page
        Response.Redirect("Login.aspx")
    End Sub
    'this function validates the data entered
    Function Validated(ByVal Pnumber As String, ByVal Email As String, ByVal Telephone As String, ByVal Forename As String, ByVal Surname As String, ByVal Password As String, ByVal Confirm As String) As String
        'declare a variable for the errormessage and assign blank string
        Dim ErrorMessage As String = ""
        'check the pnumber has content
        If Len(Pnumber) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "P Number cannot be blank: "
        End If
        If Len(Telephone) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Telephone cannot be blank: "
        End If
        If Email.Contains("@") = False Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Invalid Email: "
        End If
        If Len(Forename) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Forename cannot be blank: "
        End If
        If Len(Surname) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Surname cannot be blank: "
        End If
        If Len(Password) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Password cannot be blank: "
        End If
        If Password <> Confirm Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Passwords do not match: "
        End If
        Return ErrorMessage
    End Function
    'this code handles the click event for the register button
    Protected Sub btnRegister_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        'declare variables to store the data and retrieve from textboxes
        Dim PNumber As String = txtPnumber.Text
        Dim Email As String = txtEmail.Text
        Dim Telephone As String = txtTelephone.Text
        Dim Forename As String = txtForename.Text
        Dim Surname As String = txtSurname.Text
        Dim Password As String = txtPassword.Text
        Dim Confirm As String = txtConfirm.Text
        'check if data is valid
        Dim Errormessage As String = Validated(PNumber, Email, Telephone, Forename, Surname, Password, Confirm)
        'chech if there is an errormessage
        If Errormessage = "" Then
            'call the addseller function
            Call AddSeller(PNumber, Password, Email, Forename, Surname, Telephone)
        Else
            'display an erormessage
            lblError.Text = Errormessage
        End If
    End Sub
    'this function adds a new seller
    Function AddSeller(ByVal PNumber As String, ByVal Password As String, ByVal Email As String, ByVal Forename As String, ByVal Surname As String, ByVal PhoneNo As String) As String
        'create an instance of the dataconnection class
        Dim NewSeller As New DataConnection
        'add parameters for use in the query
        NewSeller.AddParameter("@PNumber", PNumber)
        NewSeller.AddParameter("@Password", Password)
        NewSeller.AddParameter("@Email", Email)
        NewSeller.AddParameter("@Forename", Forename)
        NewSeller.AddParameter("@Surname", Surname)
        NewSeller.AddParameter("@PhoneNo", PhoneNo)
        'execute the query
        NewSeller.Execute("AddSeller")
        'return confirmation
        Return "Account Created"
    End Function
End Class

