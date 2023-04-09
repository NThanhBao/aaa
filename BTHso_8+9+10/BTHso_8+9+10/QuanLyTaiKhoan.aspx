<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuanLyTaiKhoan.aspx.cs" Inherits="BTHso_8_9_10.QuanLyTaiKhoan" EnableEventValidation="false"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">

        <div class="container" style="width:70%; padding-left: 15%;">

            <div class="section" style="border:1px solid #000000">

                <div class="head" style="text-align:center; font-size:25px; font-weight:bold; padding:10px">
                    <asp:Label ID="Label1" runat="server" Text="QUẢN LÝ TÀI KHOẢN"></asp:Label>
                </div>


                <div class="table">
                    <table width="100%"
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
                                <asp:RadioButtonList ID="rblGender" runat="server"  >
                                    <asp:ListItem Text="Nam" Value="true" SelectedIndex="0"></asp:ListItem>
                                    <asp:ListItem Text="Nữ" Value="false" SelectedIndex="1"></asp:ListItem>
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
                    <asp:Button ID="btnLuu" runat="server" Text="Lưu" 
                        style="background-color:darkblue; color:aliceblue; font-size:20px; font-weight:bold;" OnClick="btnLuu_Click"  />&emsp;&emsp;
                    <asp:Button ID="btnXoa" runat="server" Text="Xóa" 
                        style="background-color:darkblue; color:aliceblue; font-size:20px; font-weight:bold;"  OnClick="btnXoa_Click" OnClientClick="return confirm('Bạn có chắc chắn muốn xóa không?')" />&emsp;&emsp;
                    <asp:Button ID="btnUpdate" runat="server" Text="Cập Nhật" 
                        style="background-color:darkblue; color:aliceblue; font-size:20px; font-weight:bold;"  OnClick="btnUpdate_Click" />&emsp;&emsp;
                    <asp:Button ID="btnXoaForm" runat="server" Text="Xóa Form" 
                        style="background-color:darkblue; color:aliceblue; font-size:20px; font-weight:bold;" OnClick="btnXoaForm_Click" />&emsp;&emsp;
                </div>
                <div style="text-align:center; color:red; padding:10px;">
                    <asp:Label ID="lblThongBao" runat="server" Text="###"></asp:Label>
                </div>
            </div>
        </div>


        <div style="padding:10px;">
                    <asp:GridView ID="gdvData" runat="server" 
                        AutoGenerateColumns="False" 
                        OnSelectedIndexChanged="gdvData_SelectedIndexChanged" 
                        Width="100%" CellPadding="4" 
                        BackColor="White" BorderColor="#CC9966" BorderStyle="None" 
                        BorderWidth="1px" OnRowDeleting="gdvData_RowDeleting" >
                        <Columns>
                            <asp:BoundField DataField="UserName" HeaderText="Tên đăng nhập" />
                            <asp:BoundField DataField="PassWord" HeaderText="Mật khẩu" />
                            <asp:BoundField DataField="FirstName" HeaderText="Tên" />
                            <asp:BoundField DataField="LastName" HeaderText="Họ và đệm" />

                            <asp:TemplateField HeaderText="Giới tính">
                                <ItemTemplate >
                                    <asp:CheckBox  ID="Gender" runat="server" Checked='<%# Convert.ToBoolean(Eval("Gender")) %>' Enabled="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                            <asp:BoundField DataField="Address" HeaderText="Địa chỉ" />

                            <asp:ImageField DataImageUrlField="Avatar" 
                                DataImageUrlFormatString="~/Img/{0}" 
                                
                                ControlStyle-Width="100px" 
                                ControlStyle-Height="100px" 
                                HeaderText="Hình ảnh" ></asp:ImageField>

                            <asp:CommandField ShowSelectButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                            <asp:TemplateField>
                                <ItemTemplate >
                                    <asp:Button ID="btnDELETE" runat="server" 
                                        OnClientClick="return confirm('Bạn chắc chắn muốn xóa ?');" 
                                        Text="Xóa" OnClick="btnDELETE_Click" 
                                        CommandArgument='<%# Eval("UserName") %>'/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:HyperLinkField DataNavigateUrlFields="UserName" DataNavigateUrlFormatString="ChinhSuaTaiKhoan.aspx?uname={0}" Text="Chỉnh sửa" />
                            <asp:TemplateField HeaderText="Hình ảnh"  >
                                <ItemTemplate >
                                    <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Avatar", "~/Img/{0}") %>' Width="100" Height="100" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#330099" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                        <SortedAscendingCellStyle BackColor="#FEFCEB" />
                        <SortedAscendingHeaderStyle BackColor="#AF0101" />
                        <SortedDescendingCellStyle BackColor="#F6F0C0" />
                        <SortedDescendingHeaderStyle BackColor="#7E0000" />
                    </asp:GridView>
                    
                </div>
    </form>
</body>
</html>
