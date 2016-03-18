
Partial Class Delete
    Inherits System.Web.UI.Page
    Dim SellerID As Integer
    Dim ItemID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the viewitems page
        Response.Redirect("Viewitems.aspx?SellerID=" & SellerID)
    End Sub
    'this code handles the click event for the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'call the deleteitem function
        Call DeleteItem(ItemID)
        'display a confirmation message
        lblConfirm.Text = "Item Deleted. Click Back to return."
    End Sub
    'this function deletes an item
    Function DeleteItem(ByVal ItemID As Integer) As Boolean
        'create an instance of the dataconnection class
        Dim DeleteQuery As New DataConnection
        Dim Success As Boolean
        'add a parameter for use in the query
        DeleteQuery.AddParameter("@ItemID", ItemID)
        'execute the query
        Success = DeleteQuery.Execute("DeleteItem")
        'return success value
        Return Success
    End Function
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve data from the previous page
        SellerID = Request.QueryString("SellerID")
        ItemID = Request.QueryString("ItemID")
        'display a confirmation message
        lblConfirm.Text = "Are you sure you would like to delete record " & ItemID & "?"
    End Sub
End Class
