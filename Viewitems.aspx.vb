
Partial Class Viewitems
    Inherits System.Web.UI.Page
    Dim SellerID As Integer
    'this code handles the click event for the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to seller page
        Response.Redirect("Seller.aspx?SellerID=" & SellerID)
    End Sub
    'this code handles the click event for the add button
    Protected Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        'redirect to add page passing the sellerid
        Response.Redirect("AddEdit.aspx?ItemID=-1&SellerID=" & SellerID)
    End Sub
    'this code handles the click event for the edit button
    Protected Sub btnEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'declare a variable to store the itemid
        Dim ItemID As Integer
        'check a record has been selected from the listbox
        If lstItems.SelectedIndex <> -1 Then
            'retrieve the itemid from the listbox
            ItemID = lstItems.SelectedValue
            'redirect to addedit page passing the itemid
            Response.Redirect("AddEdit.aspx?ItemID=" & ItemID & "&SellerID=" & SellerID)
        Else
            'display an errormessage
            lblError.Text = "You must first select an item from the list."
        End If
    End Sub
    'this code handles the click event for the delete button
    Protected Sub btnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        'declare a variable to store the itemid
        Dim ItemID As Integer
        'check a record has been selected from the listbox
        If lstItems.SelectedIndex <> -1 Then
            'retrieve the itemid from the listbox
            ItemID = lstItems.SelectedValue
            'redirect to the delete page passing the itemid
            Response.Redirect("Delete.aspx?ItemID=" & ItemID & "&SellerID=" & SellerID)
        Else
            'display an errormessage
            lblError.Text = "You must first select an item from the list."
        End If
    End Sub
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve the sellerid from the previous page
        SellerID = Request.QueryString("SellerID")
        'check this is the first time the page has been loaded
        If IsPostBack = False Then
            'call the displayitems function
            Dim Itemcount As Integer = DisplayItems()
        End If
    End Sub
    'this code displays the sellers items in the listbox
    Function DisplayItems() As Integer
        'clear the listbox
        lstItems.Items.Clear()
        'declare variables to store the data
        Dim FullText, Category, ItemName As String
        Dim Price As Decimal
        Dim ItemID As Integer
        'create an instance of the dataconnection class
        Dim Things As New DataConnection
        'add a parameter for use in the query
        Things.AddParameter("@SellerID", SellerID)
        'execute the query
        Things.Execute("SelectSellerItems")
        'loop through the results
        For i = 0 To Things.Count - 1
            ''retrieve data from the database
            ItemID = Things.QueryResults.Rows(i)(0)
            Category = Things.QueryResults.Rows(i)(2)
            ItemName = Things.QueryResults.Rows(i)(3)
            Price = Things.QueryResults.Rows(i)(5)
            Price = FormatCurrency(Price, 2)
            'concatenate data for use in a listitem
            FullText = Category & " " & ItemName & " £" & Price
            'create a listitem
            Dim NextItem As New ListItem(FullText, ItemID)
            'add item to the listbox
            lstItems.Items.Add(NextItem)
        Next
        'return number of records found
        Return Things.Count
    End Function
End Class
