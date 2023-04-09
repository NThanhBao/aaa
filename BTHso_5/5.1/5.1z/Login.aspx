<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="_5._1z.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container" style="border:1px solid #000000; padding:10px; width:15%; background-color:bisque;">
                <div class="input">
                    <asp:Label ID="Label1" runat="server" Text="Tài khoản:"></asp:Label><br />
                    <asp:TextBox ID="txtUsr" runat="server" Width="99%" ></asp:TextBox><br />
                    <asp:Label ID="Label2" runat="server" Text="Mật khẩu:"></asp:Label><br />
                    <asp:TextBox ID="txtPass" runat="server" Width="99%" ></asp:TextBox><br />
                    <asp:CheckBox ID="chkLuu" runat="server" Text="Lưu mật khẩu" Text-align="center"/><br />
                </div>
                <div class="btn" style="padding:15px; text-align:center;">
                    <asp:Button ID="btnDongY" runat="server" Text="Đông ý" BackColor="Aqua" OnClick="btnDongY_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
