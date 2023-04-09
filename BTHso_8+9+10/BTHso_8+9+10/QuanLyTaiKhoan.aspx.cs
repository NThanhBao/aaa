using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTHso_8_9_10
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
        protected void gdvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            string username = gdvData.SelectedRow.Cells[0].Text;

            UserDAO userDAO = new UserDAO();
            User user = userDAO.GetUserByUsername(username);

            if (user != null)
            {
                DoDuLieuLenForm(user);
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
                Boolean.Parse(rblGender.SelectedValue);

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
        
        private void UploadAvatar(string fileName)
        {
            String filePath = "~/Img/" + fileName;

            if (fupAvatar.HasFile)
            {
                fupAvatar.SaveAs(Server.MapPath(filePath));
            }
        }
        private void UpdateAvatar(string fileName)
        {
            String filePath = "~/Img/" + fileName;

            if (fupAvatar.HasFile)
            {
                fupAvatar.SaveAs(Server.MapPath(filePath));
            }
        }

        protected void btnLuu_Click(object sender, EventArgs e)
        {
            User user = LayDuLieuTuForm();

            UserDAO userDAO = new UserDAO();

            bool exist = userDAO.CheckUser(user.UserName);

            if (exist)
            {
                lblThongBao.Text = "Username đã tồn tại";
            }
            else
            {
                bool result = userDAO.Insert(user);
                UploadAvatar(user.AvatarFileName);

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
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTen.Text = "";
            txtHotendem.Text = "";
            txtEmail.Text = "";
            rblGender.ClearSelection();
            txtDiaChi.Text = "";
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
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            User user = LayDuLieuTuForm();
            UserDAO userDAO = new UserDAO();

            bool result = userDAO.UpdateUser(user);
            UpdateAvatar(user.AvatarFileName);
            if (result)
            {
                lblThongBao.Text = "Cập nhật thành công";
                LayDuLieuVaoGridView();
            }
            else
            {
                lblThongBao.Text = "Cập nhật không thành công";
            }
        }

        /* ----------delete command------------ */
        protected void gdvData_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string username = gdvData.Rows[e.RowIndex].Cells[0].Text;

            UserDAO userDAO = new UserDAO();

            bool result = userDAO.Delete(username);

            if (result)
            {
                lblThongBao.Text = "Đã xóa thành công.";
                LayDuLieuVaoGridView();
            }
            else
            {
                lblThongBao.Text = "Xóa không thành công!!!";
            }
        }

        /* -----------btndelete------------ */
        protected void btnDELETE_Click(object sender, EventArgs e)
        {
            Button btnDELETE = (Button)sender;
            string username = btnDELETE.CommandArgument;

            UserDAO userDAO = new UserDAO();

            bool result = userDAO.Delete(username);

            if (result)
            {
                lblThongBao.Text = "Đã xóa thành công.";
                LayDuLieuVaoGridView();
            }
            else
            {
                lblThongBao.Text = "Xóa không thành công!!";
            }
        }


    }

}