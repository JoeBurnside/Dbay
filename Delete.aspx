<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Delete.aspx.vb" Inherits="Delete" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
    
    <asp:Label ID="lblDbay" runat="server" BackColor="#660066" Font-Bold="True" 
        Font-Size="100pt" Font-Underline="True" ForeColor="Yellow" 
        style="z-index: 1; left: 16px; top: 16px; position: absolute" Text="D-BAY"></asp:Label>
        <asp:Label ID="lblConfirm" runat="server" 
            style="z-index: 1; left: 81px; top: 199px; position: absolute"></asp:Label>
    </p>
    <div>
    
    </div>
    <asp:Button ID="btnBack" runat="server" 
        style="z-index: 1; left: 242px; top: 245px; position: absolute" Text="Back" />
    <asp:Button ID="btnDelete" runat="server" 
        style="z-index: 1; left: 130px; top: 248px; position: absolute" Text="Delete" />
    </form>
</body>
</html>
