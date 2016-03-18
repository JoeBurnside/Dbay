
Partial Class _Default
    Inherits System.Web.UI.Page
    'This code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Declare a variable to store the primary key value
        Dim SellerID As Integer
        'Declare variables to store the items retrieved from the database
        Dim Surname, Forename, PhoneNo, Email As String
        'Request a primary key value from the previous page
        SellerID = Request.QueryString("SellerID")
        'Create an instance of the dataconnection class
        Dim Things As New DataConnection
        'Add a parameter for use in the query
        Things.AddParameter("@SellerID", SellerID)
        'Execute the select seller query
        Things.Execute("SelectSeller")
        'Retrieve the forename from the database
        Forename = Things.QueryResults.Rows(0)(4)
        'Retrieve the surname from the database
        Surname = Things.QueryResults.Rows(0)(5)
        'Retrieve the email from the database
        Email = Things.QueryResults.Rows(0)(3)
        'Retrieve the phone number from the database
        PhoneNo = Things.QueryResults.Rows(0)(6)
        'Put the full name into the label using a concatenation
        lblName.Text = "Seller Name: " & Forename & " " & Surname
        'Put the email into the label using a concatenation
        lblEmail.Text = "Email: " & Email
        'Put the telephone number into the lavbel using a concatenation
        lblNumber.Text = "Telephone: " & PhoneNo
    End Sub
    'This code deals with the back button click event 
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Declare a variable to store the primary key value
        Dim ItemID As Integer
        'Request the primary key value from the previous page
        ItemID = Request.QueryString("ItemID")
        'Redirect back to the previous page passing the primary key value
        Response.Redirect("DisplayItems.aspx?ItemID=" & ItemID)
    End Sub
End Class
