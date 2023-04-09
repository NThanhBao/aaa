<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Facebook.aspx.cs" Inherits="Cau_2.FaceBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Facebook</title>
    <link rel="stylesheet" href="StyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="Container">
            <div class="head_url">

            </div>
            <div class="header">
                <h1>Facebook</h1>
                <div class="InputLogin">
                    <div class="email">
                        <label>Email hoặc số điện thoại</label><br />
                        <asp:TextBox ID="InputEmail" runat="server" ></asp:TextBox>
                    </div>

                    <div class="matkhau">
                        <label>Mật khẩu</label><br />
                        <asp:TextBox ID="InputPassword" runat="server"></asp:TextBox><br />
                        <asp:LinkButton CssClass="InputLogin" ID="LinkBaocao" runat="server">Bạn gặp sự cố?</asp:LinkButton>
                    </div>
                    <div class="dangnhap">
                        <asp:Button class="btnDangnhap" ID="btnLogin" runat="server" Text="Đăng nhập" />
                    </div>



                </div>
            </div>
            <div class="section">

            </div>
            <div class="footer">

            </div>
        </div>
    </form>
</body>
</html>
