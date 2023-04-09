using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTHso_6
{
    public partial class QuanLyTaiKhoan : System.Web.UI.Page
    {
        private static List<User> listUser = new List<User>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gdvData.DataSource = listUser;
                this.DataBind();
            }
        }
        public bool CheckUser(User user)
        {
            for (int i=0; i < listUser.Count; i++)
                if(listUser[i].UserName.Equals(user.UserName))
                    return true;
            return false;
        }


        public User LayDuLieuTuForm()
        {

            User user = new User
            {
                FirstName = txtTen.Text,
                LastName = txtHotendem.Text,
                Email = txtEmail.Text,
                Gender = rblGender.Text,
                Address = txtDiaChi.Text,
                UserName = txtTaiKhoan.Text,
                PassWord = txtMatKhau.Text,
                
            };
            return user;
        }
        public User LayDuLieuTuForm1()
        {
            bool gender =
                Boolean.Parse(rblGender.SelectedValue.ToString());
            User user = new User(txtTen.Text, txtHotendem.Text, txtEmail.Text,
                rblGender.Text, txtDiaChi.Text, txtTaiKhoan.Text, txtMatKhau.Text);
            return user;
        }
        

        protected void btnLuu_Click1(object sender, EventArgs e)
        {
            User us = LayDuLieuTuForm();
            if (CheckUser(us))
            {
                lblThongBao.Text = "Trùng dữ liệu !!!";
            }
            else
            {
                lblThongBao.Text = "Đăng ký thành công !!!";
                listUser.Add(LayDuLieuTuForm());
                gdvData.DataSource = listUser;
                gdvData.DataBind();
            }
        }

        protected void btnXoa_Click(object sender, EventArgs e)
        {
            string userName = txtTaiKhoan.Text;
            User userToDelete = listUser.FirstOrDefault(u => u.UserName == userName);
            if (userToDelete != null)
            {
                lblThongBao.Text = "Xóa người dùng thành công!";
                listUser.Remove(userToDelete);
                gdvData.DataSource = listUser;
                gdvData.DataBind();
            }
            else
            {
                lblThongBao.Text = "Xóa người dùng thất bại !!!";
            }
        }
        

        protected void btnXoaForm_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTen.Text = "";
            txtHotendem.Text = "";
            txtEmail.Text = "";
            rblGender.ClearSelection();
            txtDiaChi.Text = "";
        }

        protected void rblGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gdvData_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Xoa")
            {
                string userName = e.CommandArgument.ToString();
                User userToDelete = listUser.FirstOrDefault(u => u.UserName == userName);
                if (userToDelete != null)
                {
                    listUser.Remove(userToDelete);
                    gdvData.DataSource = listUser;
                    gdvData.DataBind();
                }
            }
        }
        protected void gdvData_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        protected void gdvData_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            
        }
        protected void gdvData_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {
            
        }
    }
}