<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Seller.aspx.vb" Inherits="Seller" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:Label ID="lblDbay" runat="server" BackColor="#660066" Font-Bold="True" 
        Font-Size="100pt" Font-Underline="True" ForeColor="Yellow" 
        style="z-index: 1; left: 16px; top: 16px; position: absolute" Text="D-BAY"></asp:Label>
        <asp:Button ID="btnLogout" runat="server" height="26px" 
            style="z-index: 1; left: 130px; top: 308px; position: absolute" Text="Logout" 
            width="193px" />
        <asp:Button ID="btnEditDetails" runat="server" height="26px" 
            style="z-index: 1; left: 130px; top: 266px; position: absolute" 
            Text="Edit Personal Details" width="193px" />
        <asp:Button ID="BtnViewItems" runat="server" height="26px" 
            style="z-index: 1; left: 129px; top: 224px; position: absolute" 
            Text="Your Items" width="193px" />
    
    </div>
    </form>
</body>
</html>
