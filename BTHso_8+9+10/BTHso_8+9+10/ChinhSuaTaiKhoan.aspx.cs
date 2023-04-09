using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTHso_8_9_10
{
    public partial class ChinhSuaTaiKhoan : System.Web.UI.Page
    {


        
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["uname"];

            if (username != null)
            {
                UserDAO userDAO = new UserDAO();
                User user = userDAO.GetUserByUsername(username);

                if (user != null)
                {
                    DoDuLieuLenForm(user);
                }
            }
        }
        private void DoDuLieuLenForm(User user)
        {
            txtTaiKhoan.Text = user.UserName;
            txtMatKhau.Text = user.PassWord;
            txtTen.Text = user.FirstName;
            txtHotendem.Text = user.LastName;
            rblGender.SelectedIndex = user.Gender ? 0 : 1;
            txtEmail.Text = user.Email;
            txtDiaChi.Text = user.Address;
        }
        public User LayDuLieuTuForm()
        {
            bool gender =
                Boolean.Parse(rblGender.SelectedValue.ToString());
            string extension = System.IO.Path.GetExtension(fupAvatar.FileName);
            string username = txtTaiKhoan.Text;
            
            string fileName = username + extension;
            User user = new User
            {
                FirstName = txtTen.Text,
                LastName = txtHotendem.Text,
                Email = txtEmail.Text,
                Gender = gender,
                Address = txtDiaChi.Text,
                UserName = username,
                PassWord = txtMatKhau.Text,
                AvatarFileName = fileName
            };
            return user;
        }
        public User LayDuLieuTuForm1()
        {
            bool gender =
                Boolean.Parse(rblGender.SelectedValue.ToString());
            User user = new User(txtTen.Text, txtHotendem.Text, txtEmail.Text,
                gender, txtDiaChi.Text, txtTaiKhoan.Text, txtMatKhau.Text);
            return user;
        }
        protected void btnTrangChu_Click(object sender, EventArgs e)
        {
            Response.Redirect("QuanLyTaiKhoan.aspx");
        }
        
        private void UpdateAvatar(string fileName)
        {
            String filePath = "~/Img/" + fileName;

            if (fupAvatar.HasFile)
            {
                fupAvatar.SaveAs(Server.MapPath(filePath));
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = LayDuLieuTuForm();
            UserDAO userDAO = new UserDAO();

            bool result = userDAO.UpdateUser(user);
            UpdateAvatar(user.AvatarFileName);
            if (result)
            {
                
                lblThongBao.Text = "Cập nhật thành công";
                DoDuLieuLenForm(user);
                
            }
            else
            {
                lblThongBao.Text = "Cập nhật không thành công";
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