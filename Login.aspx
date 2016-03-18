<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:Button ID="Button1" runat="server" 
            style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Button" />
    <asp:Label ID="lblDbay" runat="server" BackColor="#660066" Font-Bold="True" 
        Font-Size="100pt" Font-Underline="True" ForeColor="Yellow" 
        style="z-index: 1; left: 16px; top: 16px; position: absolute" Text="D-BAY"></asp:Label>
    </p>
    <div>
    
    </div>
    <asp:TextBox ID="txtPnumber" runat="server" 
        style="z-index: 1; left: 191px; top: 288px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPassword" runat="server" 
        style="z-index: 1; left: 191px; top: 325px; position: absolute" 
        TextMode="Password"></asp:TextBox>
    <asp:Button ID="btnLogin" runat="server" 
        style="z-index: 1; left: 231px; top: 368px; position: absolute" Text="Login" />
    <asp:Button ID="btnRegister" runat="server" 
        style="z-index: 1; left: 126px; top: 417px; position: absolute" 
        Text="Register New Seller" />
    <asp:Button ID="btnBack" runat="server" 
        style="z-index: 1; left: 321px; top: 417px; position: absolute" Text="Back" />
    <asp:Label ID="lblPassword" runat="server" 
        style="z-index: 1; left: 104px; top: 329px; position: absolute" Text="Password"></asp:Label>
    <asp:Label ID="lblPnumber" runat="server" 
        style="z-index: 1; left: 104px; top: 290px; position: absolute" Text="P Number"></asp:Label>
    <asp:Label ID="lblLogin" runat="server" 
        style="z-index: 1; left: 153px; top: 217px; position: absolute" 
        Text="Please login to continue."></asp:Label>
    <asp:Label ID="lblError" runat="server" ForeColor="Red" 
        style="z-index: 1; left: 140px; top: 470px; position: absolute"></asp:Label>
    </form>
</body>
</html>
