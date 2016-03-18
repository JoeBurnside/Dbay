
Partial Class Seller
    Inherits System.Web.UI.Page
    'Declare a variable to store the users P Number
    Dim SellerID As Integer
    'This code handles the page load event
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'Retrieve the users P number from the previous screen
        SellerID = Request.QueryString("SellerID")
    End Sub
    'This code handles the click event for the View and Edit items button
    Protected Sub BtnViewItems_Click(sender As Object, e As System.EventArgs) Handles BtnViewItems.Click
        'Redirect to the view/edit items page while passing the P number to the next page
        Response.Redirect("Viewitems.aspx?SellerID=" & SellerID)
    End Sub
    'This code handles the click event for the edit details button
    Protected Sub btnEditDetails_Click(sender As Object, e As System.EventArgs) Handles btnEditDetails.Click
        'Redirect to the edit details page while passing the P number to the next page 
        Response.Redirect("Editdetails.aspx?SellerID=" & SellerID)
    End Sub
    'This code handles the click event for the Logout button
    Protected Sub btnLogout_Click(sender As Object, e As System.EventArgs) Handles btnLogout.Click
        'Redirect back to the index page
        Response.Redirect("Index.aspx")
    End Sub
End Class
