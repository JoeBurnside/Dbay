<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Buyer.aspx.vb" Inherits="buyer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnHome" runat="server" 
            style="z-index: 1; left: 880px; top: 455px; position: absolute" Text="Home" />
    
    </div>
    <asp:ListBox ID="lstItems" runat="server" 
        
        style="z-index: 1; left: 110px; top: 237px; position: absolute; height: 313px; width: 723px">
    </asp:ListBox>
    <asp:Button ID="btnView" runat="server" 
        style="z-index: 1; left: 873px; top: 396px; position: absolute" 
        Text="View Item" />
    <asp:Button ID="btnCategory" runat="server" 
        style="z-index: 1; left: 330px; top: 191px; position: absolute; right: 765px; height: 25px" 
        Text="Go" />
    <asp:DropDownList ID="ddlCategory" runat="server" 
        style="z-index: 1; left: 207px; top: 192px; position: absolute">
        <asp:ListItem>All</asp:ListItem>
        <asp:ListItem>Books</asp:ListItem>
        <asp:ListItem>Electronics</asp:ListItem>
        <asp:ListItem>Clothes</asp:ListItem>
        <asp:ListItem>Music</asp:ListItem>
        <asp:ListItem>Video</asp:ListItem>
    </asp:DropDownList>
    <p>
        <asp:Label ID="lblCategories" runat="server" 
            style="z-index: 1; left: 117px; top: 193px; position: absolute; height: 20px;" 
            Text="Categories"></asp:Label>
    </p>
    <asp:Label ID="lblMessage" runat="server" 
        
        style="z-index: 1; left: 134px; top: 575px; position: absolute; width: 310px"></asp:Label>
    <asp:Label ID="lblDbay" runat="server" BackColor="#660066" Font-Bold="True" 
        Font-Size="100pt" Font-Underline="True" ForeColor="Yellow" 
        style="z-index: 1; left: 11px; top: 10px; position: absolute" Text="D-BAY"></asp:Label>
    </form>
</body>
</html>
