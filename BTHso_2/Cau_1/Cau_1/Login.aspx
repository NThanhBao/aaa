<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Cau_1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

                    <div>
                        <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label><br />
                        <input id="txtEmail" type="text" runat="server"/><br />
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label><br />
                        <input id="txtPassword" type="text" runat="server" /><br />
                        <br /><asp:Button ID="btnLogin" runat="server" Text="Sign In Now!" onserverclick="btnLogin_Click" OnClick="btnLogin_Click" /><br />

                        <div id="divInfo" runat="server"></div>
                    </div>

    </form>
</body>
</html>
