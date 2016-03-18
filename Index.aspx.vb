
Partial Class Index
    Inherits System.Web.UI.Page
    'This code handles the click event for the buyers button
    Protected Sub btnBuyers_Click(sender As Object, e As System.EventArgs) Handles btnBuyers.Click
        'Redirect to the buyers page
        Response.Redirect("Buyer.aspx")
    End Sub
    'This code handles the click event for the sellers button
    Protected Sub btnSellers_Click(sender As Object, e As System.EventArgs) Handles btnSellers.Click
        'Redirect to the login screen
        Response.Redirect("Login.aspx")
    End Sub
End Class
