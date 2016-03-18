<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Index.aspx.vb" Inherits="Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <p>
    <asp:Label ID="lblDbay" runat="server" BackColor="#660066" Font-Bold="True" 
        Font-Size="100pt" Font-Underline="True" ForeColor="Yellow" 
        style="z-index: 1; left: 16px; top: 16px; position: absolute" Text="D-BAY"></asp:Label>
    </p>
    <asp:Button ID="btnSellers" runat="server" height="26px" 
        style="z-index: 1; left: 168px; top: 252px; position: absolute" 
        Text="Sellers Menu" width="115px" />
    <p>
        <asp:Button ID="btnBuyers" runat="server" 
            style="z-index: 1; top: 320px; position: absolute; left: 168px" 
            Text="Buyers Menu" />
    </p>
    </form>
</body>
</html>
