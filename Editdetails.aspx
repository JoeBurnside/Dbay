<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Editdetails.aspx.vb" Inherits="Editdetails" %>

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
        style="z-index: 1; left: 13px; top: 39px; position: absolute" Text="D-BAY"></asp:Label>
    
    </div>
    <asp:TextBox ID="txtConfirm" runat="server" 
        style="z-index: 1; left: 210px; top: 411px; position: absolute; bottom: 176px" 
        TextMode="Password"></asp:TextBox>
    <asp:TextBox ID="txtPassword" runat="server" 
        style="z-index: 1; left: 210px; top: 376px; position: absolute" 
        TextMode="Password"></asp:TextBox>
    <asp:TextBox ID="txtTelephone" runat="server" 
        style="z-index: 1; left: 210px; top: 275px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtEmail" runat="server" 
        style="z-index: 1; left: 210px; top: 241px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtSurname" runat="server" 
        style="z-index: 1; left: 210px; top: 345px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtForename" runat="server" 
        style="z-index: 1; left: 210px; top: 310px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPnumber" runat="server" 
        style="z-index: 1; left: 210px; top: 207px; position: absolute"></asp:TextBox>
    <asp:Button ID="btnUpdate" runat="server" 
        style="z-index: 1; left: 194px; top: 543px; position: absolute" 
        Text="Update" />
    <asp:Button ID="btnBack" runat="server" 
        style="z-index: 1; left: 277px; top: 543px; position: absolute" Text="Back" />
    <asp:Label ID="lblPnumber" runat="server" 
        style="z-index: 1; left: 111px; top: 210px; position: absolute" Text="Pnumber"></asp:Label>
    <asp:Label ID="lblSurname" runat="server" 
        style="z-index: 1; left: 112px; top: 347px; position: absolute" Text="Surname"></asp:Label>
    <asp:Label ID="lblEmail" runat="server" 
        style="z-index: 1; left: 132px; top: 243px; position: absolute" Text="Email"></asp:Label>
    <asp:Label ID="lblPassword" runat="server" 
        style="z-index: 1; left: 105px; top: 377px; position: absolute" Text="Password"></asp:Label>
    <asp:Label ID="lblConfirm" runat="server" 
        style="z-index: 1; left: 49px; position: absolute; top: 411px; width: 116px" 
        Text="Confirm Password"></asp:Label>
    <asp:Label ID="lblTelephone" runat="server" 
        style="z-index: 1; left: 102px; top: 278px; position: absolute; height: 19px" 
        Text="Telephone"></asp:Label>
    <asp:Label ID="lblForename" runat="server" 
        style="z-index: 1; left: 104px; top: 311px; position: absolute" Text="Forename"></asp:Label>
    <asp:Label ID="lblError" runat="server" ForeColor="Red" 
        style="z-index: 1; left: 247px; top: 500px; position: absolute; right: 847px"></asp:Label>
    </form>
</body>
</html>
