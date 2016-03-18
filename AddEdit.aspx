<%@ Page Language="VB" AutoEventWireup="false" CodeFile="AddEdit.aspx.vb" Inherits="AddEdit" %>

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
        </p>
    <div>
    
    </div>
    <asp:Label ID="lblError" runat="server" ForeColor="Red" 
        style="z-index: 1; left: 255px; top: 428px; position: absolute"></asp:Label>
    <asp:Button ID="btnBack" runat="server" 
        style="z-index: 1; left: 295px; top: 478px; position: absolute" Text="Back" />
    <asp:Button ID="btnSubmit" runat="server" 
        style="z-index: 1; left: 187px; top: 478px; position: absolute; right: 704px; height: 26px;" 
        Text="Submit" />
    <asp:Label ID="lblPicture" runat="server" 
        style="z-index: 1; left: 129px; top: 366px; position: absolute" 
        Text="Picture"></asp:Label>
    <asp:Label ID="lblCategory" runat="server" 
        style="z-index: 1; left: 115px; top: 253px; position: absolute; bottom: 178px" 
        Text="Category"></asp:Label>
    <asp:Label ID="lblPrice" runat="server" 
        style="z-index: 1; left: 140px; top: 327px; position: absolute; bottom: 63px" 
        Text="Price"></asp:Label>
    <asp:Label ID="lblDescription" runat="server" 
        style="z-index: 1; left: 102px; top: 288px; position: absolute" 
        Text="Description"></asp:Label>
    <asp:Label ID="lblName" runat="server" 
        style="z-index: 1; left: 103px; top: 220px; position: absolute; bottom: 136px;" 
        Text="Item Name"></asp:Label>
    <asp:DropDownList ID="ddlCategory" runat="server" 
        style="z-index: 1; left: 214px; top: 251px; position: absolute">
        <asp:ListItem>Books</asp:ListItem>
        <asp:ListItem>Electronics</asp:ListItem>
        <asp:ListItem>Clothes</asp:ListItem>
        <asp:ListItem>Music</asp:ListItem>
        <asp:ListItem>Video</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox ID="txtName" runat="server" 
        style="z-index: 1; left: 214px; top: 218px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtPrice" runat="server" 
        style="z-index: 1; left: 214px; top: 328px; position: absolute"></asp:TextBox>
    <asp:TextBox ID="txtDescription" runat="server" 
        style="z-index: 1; left: 214px; top: 286px; position: absolute"></asp:TextBox>
    <asp:FileUpload ID="ulPicture" runat="server" 
        style="z-index: 1; left: 214px; top: 368px; position: absolute" />
    <asp:Button ID="btnCommit" runat="server" 
        style="z-index: 1; left: 189px; top: 519px; position: absolute" Text="Commit" />
    </form>
</body>
</html>
