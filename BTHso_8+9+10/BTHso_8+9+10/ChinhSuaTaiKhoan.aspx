<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChinhSuaTaiKhoan.aspx.cs" Inherits="BTHso_8_9_10.ChinhSuaTaiKhoan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container" style="width:70%; padding-left: 15%;">

            <div class="section" style="border:1px solid #000000">
        <div>
            <div class="head" style="text-align:center; font-size:25px; font-weight:bold; padding:10px">
                    <asp:Label ID="Label1" runat="server" Text="QUẢN LÝ TÀI KHOẢN"></asp:Label>
                </div>


                <div class="table">
                    <table style="width: 100%;">
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text="Tên đăng nhập" 
                                    style="font-size:20px; font-weight:bold; padding-left:20%;"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtTaiKhoan" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label3" runat="server" Text="Mật khẩu" 
                                    style="font-size:20px; font-weight:bold; padding-left:20%;"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtMatKhau" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Text="Tên" 
                                    style="font-size:20px; font-weight:bold; padding-left:20%;"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtTen" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label5" runat="server" Text="Họ và tên đệm" 
                                    style="font-size:20px; font-weight:bold; padding-left:20%;"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtHotendem" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label6" runat="server" Text="Email" 
                                    style="font-size:20px; font-weight:bold; padding-left:20%;"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtEmail" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label7" runat="server" Text="Giới tính" 
                                    style="font-size:20px; font-weight:bold; padding-left:20%;"></asp:Label>
                            </td>
                            <td>
                                <asp:RadioButtonList ID="rblGender" runat="server" >
                                    <asp:ListItem Text="Nam" Value="false" SelectedIndex="0"></asp:ListItem>
                                    <asp:ListItem Text="Nữ" Value="true" SelectedIndex="1"></asp:ListItem>
                                </asp:RadioButtonList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label8" runat="server" Text="Địa chỉ" 
                                    style="font-size:20px; font-weight:bold; padding-left:20%;"></asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtDiaChi" runat="server" Width="98%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label9" runat="server" Text="Hình ảnh" 
                                    style="font-size:20px; font-weight:bold; padding-left:20%;"></asp:Label>
                            </td>
                            <td>
                                <asp:FileUpload ID="fupAvatar" runat="server" />
                            </td>
                        </tr>
                    </table>
                </div>


                <div class="btn" style="padding:15px; text-align:center;">
                    <asp:Button ID="btnUpdate" runat="server" Text="Cập Nhật" 
                        style="background-color:darkblue; color:aliceblue; font-size:20px; font-weight:bold;" CssClass="auto-style1" OnClick="btnUpdate_Click" />&emsp;&emsp;
                    <asp:Button ID="btnXoaForm" runat="server" Text="Xóa Form" 
                        style="background-color:darkblue; color:aliceblue; font-size:20px; font-weight:bold;" OnClick="btnXoaForm_Click" />&emsp;&emsp;
                    <asp:Button ID="btnTrangChu"  runat="server" Text="Trang Chủ"
                        style="background-color:darkblue; color:aliceblue; font-size:20px; font-weight:bold;" OnClick="btnTrangChu_Click" />&emsp;&emsp;
                </div>

                <div style="text-align:center; color:red; padding:10px;">
                    <asp:Label ID="lblThongBao" runat="server" Text="###"></asp:Label>
                </div>
            </div>
          </div>
       </div>
    </form>

</body>
</html>
