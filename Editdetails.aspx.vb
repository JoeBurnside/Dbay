
Partial Class Editdetails
    Inherits System.Web.UI.Page
    Dim SellerID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to seller page
        Response.Redirect("Seller.aspx?SellerID=" & SellerID)
    End Sub
    'this code handles the click event for the update button
    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        'declare variables to store the data and retrieve from textboxes
        Dim PNumber As String = txtPnumber.Text
        Dim Email As String = txtEmail.Text
        Dim Telephone As String = txtTelephone.Text
        Dim Forename As String = txtForename.Text
        Dim Surname As String = txtSurname.Text
        Dim Password As String = txtPassword.Text
        Dim Confirm As String = txtConfirm.Text
        'check data is valid
        Dim Errormessage As String = Validated(PNumber, Email, Telephone, Forename, Surname, Password, Confirm)
        'check there is no errors
        If Errormessage = "" Then
            'call editseller function
            Call EditSeller(PNumber, Password, Email, Forename, Surname, Telephone, SellerID)
        Else
            'display an errormessage
            lblError.Text = Errormessage
        End If
    End Sub
    'this function updates seller records
    Function EditSeller(ByVal PNumber As String, ByVal Password As String, ByVal Email As String, ByVal Forename As String, ByVal Surname As String, ByVal PhoneNo As String, ByVal SellerID As Integer) As String
        'create an instance of the dataconnection class
        Dim NewSeller As New DataConnection
        'add parameters for use in the query
        NewSeller.AddParameter("@PNumber", PNumber)
        NewSeller.AddParameter("@Password", Password)
        NewSeller.AddParameter("@Email", Email)
        NewSeller.AddParameter("@Forename", Forename)
        NewSeller.AddParameter("@Surname", Surname)
        NewSeller.AddParameter("@PhoneNo", PhoneNo)
        NewSeller.AddParameter("@SellerID", SellerID)
        'execute the query
        NewSeller.Execute("EditSeller")
        'return a confirmation message
        Return "Details Updated"
    End Function
    Function Validated(ByVal Pnumber As String, ByVal Email As String, ByVal Telephone As String, ByVal Forename As String, ByVal Surname As String, ByVal Password As String, ByVal Confirm As String) As String
        Dim ErrorMessage As String = ""
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
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrive the sellerid from the previous page
        SellerID = Request.QueryString("SellerID")
    End Sub
End Class
