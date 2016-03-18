
Partial Class buyer
    Inherits System.Web.UI.Page
    'This code deals with the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Check if this is the first time the page has been loaded
        If IsPostBack = False Then
            'Declare a variable to store the itemcount and call the display items function
            Dim Itemcount As Integer = DisplayItems()
            'Display the number of records retrieved in the message label
            lblMessage.Text = "There are " & Itemcount & " items to display"
        End If
    End Sub
    'This function displays all items from a single category
    Function DisplayCategory() As Integer
        'Clear the listbox
        lstItems.Items.Clear()
        'Declare variables to store items retrieved from the database
        Dim FullText, Category, ItemName As String
        Dim Price As Decimal
        Dim ItemID As Integer
        'Create an instance of the dataconnection class 
        Dim Things As New DataConnection
        'Add a parameter for use in the query from the drop down list
        Things.AddParameter("@category", ddlCategory.SelectedItem.Text)
        'Execute the select category query 
        Things.Execute("SelectCategory")
        'Loop through the query results
        For i = 0 To Things.Count - 1
            'Retrieve the primary key from the database
            ItemID = Things.QueryResults.Rows(i)(0)
            'Retrieve the category from the database
            Category = Things.QueryResults.Rows(i)(2)
            'Retrieve the item name from the database
            ItemName = Things.QueryResults.Rows(i)(3)
            'Retrieve the item price from the database
            Price = Things.QueryResults.Rows(i)(5)
            'Format the price to contain 2 decimal places
            Price = FormatCurrency(Price, 2)
            'Concatenate the results to create a list item
            FullText = Category & " " & ItemName & " £" & Price
            'Create a listitem
            Dim NextItem As New ListItem(FullText, ItemID)
            'Add the listitem to the list box
            lstItems.Items.Add(NextItem)
        Next
        'Return the number of results
        Return Things.Count
    End Function
    'This function displays all items
    Function DisplayItems() As Integer
        'Clear the listbox
        lstItems.Items.Clear()
        'Declare variables to store items retrieved from the database
        Dim FullText, Category, ItemName As String
        Dim Price As Decimal
        Dim ItemID As Integer
        'Create an instance of the dataconnection
        Dim Things As New DataConnection
        'Execute the select all query
        Things.Execute("SelectAll")
        'Loop through the query results
        For i = 0 To Things.Count - 1
            'Retrieve the primary key from the database
            ItemID = Things.QueryResults.Rows(i)(0)
            'Retrieve the item category from the database
            Category = Things.QueryResults.Rows(i)(2)
            'Retrieve the item name from the database
            ItemName = Things.QueryResults.Rows(i)(3)
            'Retrieve the item price from the database
            Price = Things.QueryResults.Rows(i)(5)
            'Format the price to 2 decimal places
            Price = FormatCurrency(Price, 2)
            'Concatenate the items retrieved from the database
            FullText = Category & " " & ItemName & " £" & Price
            'Create a new list item
            Dim NextItem As New ListItem(FullText, ItemID)
            'Add the listitem to the text box
            lstItems.Items.Add(NextItem)
        Next
        'Return the number of query results
        Return Things.Count
    End Function
    'This code deals with the Go button click event 
    Protected Sub btnCategory_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCategory.Click
        'Check if All is selected
        If ddlCategory.SelectedItem.Text = "All" Then
            'Declare a variable to store the number of results and call the display all items function
            Dim Itemcount As Integer = DisplayItems()
            'Display the number of results in the message label
            lblMessage.Text = "There are " & Itemcount & " items to display"
        Else
            'Declare a variable to store the number of results and call the display category funtion
            Dim Itemcount As Integer = DisplayCategory()
            'Display the number of results in the message label
            lblMessage.Text = "There are " & Itemcount & " items to display"
        End If

    End Sub
    'This code deals with the view item button click event
    Protected Sub btnView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnView.Click
        'Declare a variable to store the primary key value
        Dim ItemID As Integer
        'Check that a record has been selected from the listbox
        If lstItems.SelectedIndex <> -1 Then
            'Retrieve the item ID from the listbox
            ItemID = lstItems.SelectedValue
            'Redirect to the display items page passing a primary key value
            Response.Redirect("DisplayItems.aspx?ItemID=" & ItemID)
        Else
            'Change the message label
            lblMessage.Text = "Please select an item from the list"
        End If
    End Sub

    Protected Sub btnHome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Response.Redirect("Index.aspx")
    End Sub
End Class
