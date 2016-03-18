<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Viewitems.aspx.vb" Inherits="Viewitems" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="lblError" runat="server" ForeColor="Red" 
            style="z-index: 1; left: 534px; top: 414px; position: absolute"></asp:Label>
    
    <asp:Label ID="lblDbay" runat="server" BackColor="#660066" Font-Bold="True" 
        Font-Size="100pt" Font-Underline="True" ForeColor="Yellow" 
        style="z-index: 1; left: 16px; top: 16px; position: absolute" Text="D-BAY"></asp:Label>
    
    </div>
    <asp:ListBox ID="lstItems" runat="server" 
        
        style="z-index: 1; left: 35px; top: 206px; position: absolute; height: 249px; width: 412px">
    </asp:ListBox>
    <asp:Button ID="btnEdit" runat="server" 
        style="z-index: 1; left: 527px; top: 268px; position: absolute" 
        Text="Edit Item" />
    <asp:Button ID="btnAdd" runat="server" 
        style="z-index: 1; left: 524px; top: 229px; position: absolute; " 
        Text="Add New Item" />
    <asp:Button ID="btnBack" runat="server" 
        style="z-index: 1; left: 528px; top: 357px; position: absolute" Text="Back" />
    <asp:Button ID="btnDelete" runat="server" 
        style="z-index: 1; left: 526px; top: 314px; position: absolute" 
        Text="Delete Item" />
    </form>
</body>
</html>
