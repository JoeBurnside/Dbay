
Partial Class login
    Inherits System.Web.UI.Page
    Dim SellerID As Integer
    'This code handles the click event for the Register button
    Protected Sub btnRegister_Click(sender As Object, e As System.EventArgs) Handles btnRegister.Click
        'Redirect to the registration page
        Response.Redirect("Register.aspx")
    End Sub
    'This code handles the click event for the login button
    Protected Sub btnLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        'Declare variables to store the password and P number
        Dim Pnumber, Password As String
        'Declare a variable to store the number of results from the query
        Dim Success As Integer
        'Retrieve the P number from the text box
        Pnumber = txtPnumber.Text
        'Retrieve the password from the text box
        Password = txtPassword.Text
        'Run the login function
        Success = Login(Pnumber, Password)
        'Check if there is a single result
        If Success = 1 Then
            'Redirect to the seller menu while passing the P number to the next page
            Response.Redirect("Seller.aspx?SellerID=" & SellerID)
        Else
            'Chance the text in the error label
            lblError.Text = "Incorrect Username or Password"
        End If

    End Sub
    'This function runs a query using the user entered values in the P number and password box
    Function Login(Pnumber As String, Password As String) As Integer
        'Create an instance of the dataconnection class
        Dim Users As New DataConnection
        'Add the P number parameter for use in the query
        Users.AddParameter("@Pnumber", Pnumber)
        'Add the password parameter for use in the query
        Users.AddParameter("@Password", Password)
        'Execute the login query
        Users.Execute("Login")
        If Users.Count = 1 Then
            SellerID = Users.QueryResults.Rows(0).Item("SellerID")
        End If

        'Return the number of results
        Return Users.Count
    End Function

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Response.Redirect("Index.aspx")
    End Sub
End Class
