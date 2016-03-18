
Partial Class AddEdit
    Inherits System.Web.UI.Page
    Dim SellerID As Integer
    Dim ItemID As Integer
    'create a list to store the class staleitem
    Dim Mylist As New List(Of SaleItem)
    'this code handles the click event of the back button
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'redirect to the view items page
        Response.Redirect("ViewItems.aspx?SellerID=" & SellerID)
    End Sub
    'this code handles the click event for the submit button
    Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'declare variables to hold the data and retrieve from the textboxes
        Dim ItemName As String = txtName.Text
        Dim Category As String = ddlCategory.SelectedItem.Text
        Dim Description As String = txtDescription.Text
        Dim Price As Decimal = txtPrice.Text
        'check the data is valid by running the validitem function
        Dim ErrorMessage As String = ValidItem(ItemName, Description, Price)
        'if the errormessage is blank
        If ErrorMessage = "" Then
            'check if this is a new item listing
            If ItemID = -1 Then
                'create an item object
                Dim MyItem As New SaleItem(SellerID, Category, ItemName, Description, Price, Date.Today)
                'add object to the list
                Mylist.Add(MyItem)
            Else
                'run the update function
                UpdateItem(Category, ItemName, Description, Price, ItemID)
            End If
        Else
            'display an errormessage
            lblError.Text = ErrorMessage
        End If
    End Sub
    'this function adds a new item
    Function InsertItem(ByVal SellerID As Integer, ByVal Category As String, ByVal ItemName As String, ByVal Description As String, ByVal Price As Decimal) As Boolean
        'create an instance of the dataconnection class
        Dim NewItem As New DataConnection
        Dim Success As Boolean
        'add parameters for use in the query
        NewItem.AddParameter("@SellerID", SellerID)
        NewItem.AddParameter("@Category", Category)
        NewItem.AddParameter("@ItemName", ItemName)
        NewItem.AddParameter("@Description", Description)
        NewItem.AddParameter("@Price", Price)
        NewItem.AddParameter("@DateListed", Date.Today)
        'execute the query
        Success = NewItem.Execute("AddItem")
        'return a confirmation
        lblError.Text = "Item Added"
        Return Success
    End Function
    Function UpdateItem(ByVal Category As String, ByVal ItemName As String, ByVal Description As String, ByVal Price As Decimal, ByVal ItemID As Integer) As Boolean
        Dim NewItem As New DataConnection
        Dim Success As Boolean
        'add parameters for use in the query
        NewItem.AddParameter("@Category", Category)
        NewItem.AddParameter("@ItemName", ItemName)
        NewItem.AddParameter("@Description", Description)
        NewItem.AddParameter("@Price", Price)
        NewItem.AddParameter("@ItemID", ItemID)
        'execute the query
        Success = NewItem.Execute("EditItem")
        'return a confirmation
        lblError.Text = "Item Updated."
        Return Success
    End Function
    'this code handles the page load event
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'retrieve data from the previous page
        SellerID = Request.QueryString("SellerID")
        ItemID = Request.QueryString("ItemID")
        'check if tthis is a new item
        If ItemID <> -1 Then
            'call the displayitems function
            Call DisplayItems(ItemID)
        End If
        'check if this is the first time the page has loaded
        If IsPostBack Then
            'retrieve the list from the session
            Mylist = Session("MyList")
        Else

        End If
    End Sub
    'this function checks the data is valid
    Function ValidItem(ByVal ItemName As String, ByVal Description As String, ByVal Price As Decimal) As String
        'declare a variable to store the errormessage and assign a blank string
        Dim ErrorMessage As String = ""
        'check the itemname has content
        If Len(ItemName) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Please Enter Item Name: "
        End If
        'check the description has content
        If Len(Description) = 0 Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Please Enter Item Description: "
        End If
        'check the orice is numeric
        If IsNumeric(Price) = False Then
            'add to errormessage
            ErrorMessage = ErrorMessage & "Invalid Price: "
        End If
        Return ErrorMessage
    End Function
    'this function displays items data in the textboxes ready for editing
    Function DisplayItems(ByVal ItemID As Integer) As Boolean
        Dim Edititem As New DataConnection
        'add parameters for use in the query
        Edititem.AddParameter("@ItemID", ItemID)
        'execute the query
        Edititem.Execute("SelectItem")
        'check the query returns one result
        If Edititem.Count = 1 Then
            'retrieve data from the database and place into textboxes
            txtName.Text = Edititem.QueryResults.Rows(0)(3)
            txtDescription.Text = Edititem.QueryResults.Rows(0)(4)
            txtPrice.Text = Edititem.QueryResults.Rows(0)(5)
            ddlCategory.SelectedValue = Edititem.QueryResults.Rows(0)(2)
            'return a positive value
            Return True
        Else
            'return a negative value
            Return False
        End If
    End Function
    'this code handles the click event for the commit button
    Protected Sub btnCommit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        'create an instance of the saleitem class
        Dim Anob As SaleItem
        'loop through the list
        For i = 0 To Mylist.Count - 1
            'create an object
            Anob = Mylist(i)
            'run the insertitem function
            InsertItem(Anob.SellerID, Anob.Category, Anob.ItemName, Anob.Description, Anob.Price)
        Next
    End Sub
    'this code handles the page unload event
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        'store the mylist in session
        Session("MyList") = Mylist
    End Sub
End Class
