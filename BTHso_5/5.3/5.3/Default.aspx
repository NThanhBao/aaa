<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5._3.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center; font-size:30px; font-weight:bold; padding:10px;">
            <asp:Label ID="ltbChao" runat="server"></asp:Label><br />
            <asp:Button ID="btnLogout" runat="server" Text="LogOut" OnClick="btnLogout_Click" style="font-size:20px;padding:5px;"/>
        </div>
    </form>
</body>
</html>
