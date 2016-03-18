<%@ Page Language="VB" AutoEventWireup="false" CodeFile="DisplayItems.aspx.vb" Inherits="DisplayItems" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblDate" runat="server" 
            style="z-index: 1; left: 438px; top: 187px; position: absolute" 
            Text="Date Listed"></asp:Label>
    
        <asp:Button ID="btnContact" runat="server" 
            style="z-index: 1; top: 262px; position: absolute; left: 577px" 
            Text="Contact Seller" />
        <asp:Label ID="lblDescription" runat="server" 
            style="z-index: 1; left: 438px; top: 92px; position: absolute; height: 15px;" 
            Text="Description:"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" 
            style="z-index: 1; left: 438px; top: 155px; position: absolute" 
            Text="Price: "></asp:Label>
        <asp:Label ID="lblItemname" runat="server" 
            style="z-index: 1; left: 438px; top: 58px; position: absolute" 
            Text="Item Name:"></asp:Label>
        <asp:Button ID="btnBack" runat="server" 
            style="z-index: 1; left: 431px; top: 262px; position: absolute" 
            Text="Back" />
        <asp:Button ID="btnPrint" runat="server" 
            style="z-index: 1; left: 506px; top: 262px; position: absolute" 
            Text="Print" />
    
    </div>
    <asp:Image ID="imgItem" runat="server" 
        style="z-index: 1; left: 134px; top: 85px; position: absolute" 
        Width="15%" />
    </form>
</body>
</html>
