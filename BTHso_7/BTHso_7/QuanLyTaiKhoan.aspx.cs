using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTHso_7
{
    public partial class QuanLyTaiKhoan : System.Web.UI.Page
    {
        private void LayDuLieuVaoGridView()
        {
            UserDAO userDAO = new UserDAO();
            gdvData.DataSource = userDAO.GetAllUsers();
            gdvData.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            LayDuLieuVaoGridView();
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
            User user = LayDuLieuTuForm();
            UserDAO userDAO= new UserDAO();
            bool exist = userDAO.CheckUser(user.UserName);
            if (exist)
            {
                lblThongBao.Text = "Username đã tồn tại";
            }
            else
            {
                bool result = userDAO.Insert(user);
                if (result)
                {
                    lblThongBao.Text = "Đăng kí thành công!!";
                }
                else
                {
                    lblThongBao.Text = "Có lỗi.";
                }
            }
            LayDuLieuVaoGridView();
        }
        protected void btnXoa_Click(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            string username = txtTaiKhoan.Text;
            bool result = userDAO.Delete(username);
            if (result)
            {
                lblThongBao.Text = "Xóa tài khoản thành công";
                LayDuLieuVaoGridView();
            }
            else
            {
                lblThongBao.Text = "Xóa tài khoản thất bại";
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
    }
}