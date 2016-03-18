Imports System.Data
Imports System.Diagnostics
Imports System.IO
Partial Class DisplayItems
    Inherits System.Web.UI.Page
    'Define the current directory
    Dim currentfolder As String = AppDomain.CurrentDomain.BaseDirectory
    'Define the route to the text file
    Dim reportPath As String = currentfolder & "listingdetails.txt"
    'Declare a variable to store the primary key
    Dim ItemID As Integer
    'Declare variables to store item name and description
    Dim ItemName, Description As String
    'Declare a variable to store items price
    Dim Price As Decimal
    'Declare a variable to store the date listed
    Dim DateListed As Date
    'This code deals with the page load
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'request the item id from the previous page
        ItemID = Request.QueryString("ItemID")
        'Create an instance of the dataconnection class
        Dim Things As New DataConnection
        'Add a parameter for use in the query
        Things.AddParameter("@ItemID", ItemID)
        'Execute a query to find the item in the database
        Things.Execute("SelectItem")
        'Retrieve the item name from the database
        ItemName = Things.QueryResults.Rows(0)(3)
        'Retrieve the item description from the database
        Description = Things.QueryResults.Rows(0)(4)
        'Retrieve the items price from the database
        Price = Things.QueryResults.Rows(0)(5)
        'Format the price to contain 2 decimal places
        Price = FormatCurrency(Price, 2)
        'Retrieve the date listed from the database
        DateListed = Things.QueryResults.Rows(0)(6)
        'Place the item name in the label using a concatenation
        lblItemname.Text = "Item Name: " & ItemName
        'Place the item description in the label using a concatenation
        lblDescription.Text = "Description: " & Description
        'Place the item price in the label using a concatenation
        lblPrice.Text = "Price: £" & Price
        'Place the items listing date in the label using a concatenation
        lblDate.Text = "Date Listed: " & DateListed
        'Assign a url to use for the items image
        imgItem.ImageUrl = "images/" & ItemID & ".jpg"
    End Sub
    'This code deals with the back button click event
    Protected Sub btnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Redirect back to buyer page
        Response.Redirect("Buyer.aspx")
    End Sub
    'This code deals with the contact seller click button
    Protected Sub btnContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnContact.Click
        'Declare variables to store the two primary keys
        Dim SellerID, ItemID As Integer
        'Retrieve the itemID from the previous page
        ItemID = Request.QueryString("ItemID")
        'Create an instance of the dataconnection class
        Dim Things As New DataConnection
        'Add a parameter for use in the query
        Things.AddParameter("@ItemID", ItemID)
        'Execute the select item query
        Things.Execute("SelectItem")
        'Retrieve the Seller ID from the database
        SellerID = Things.QueryResults.Rows(0)(1)
        'Redirect to the sellers contact details page sending two primary key variables
        Response.Redirect("ContactSeller.aspx?SellerID=" & SellerID & "&ItemID=" & ItemID)
    End Sub

    Protected Sub btnPrint_Click(sender As Object, e As System.EventArgs) Handles btnPrint.Click
        'Check that the text file exists
        If File.Exists(reportPath) Then
            'write a text file
            Using doc As New StreamWriter(reportPath)
                doc.WriteLine("")
                doc.WriteLine("Item Details")
                doc.WriteLine("Item Name: " & ItemName)
                doc.WriteLine("Description: " & Description)
                doc.WriteLine("Price: £" & Price)
                doc.WriteLine("Date Listed: " & DateListed)
                doc.WriteLine("")
                doc.WriteLine("======================================")
                doc.WriteLine("")
                doc.WriteLine("Report Printed on: " & Date.Today.ToShortDateString)
                'End streamwriter resources
            End Using
            'Open the text file
            Process.Start(reportPath)
        End If
    End Sub
End Class
