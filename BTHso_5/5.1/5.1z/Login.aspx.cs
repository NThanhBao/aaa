using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5._1z
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String usr, pas;
            HttpCookie c1 = Request.Cookies["username"];
            HttpCookie c2 = Request.Cookies["password"];
            if (c1 != null)
            {
                usr = c1.Value.ToString();
                pas = c2.Value.ToString();
                Session.Add("username", usr);
                Session.Add("password", pas);
                if (pas == "123")
                {
                    Response.Redirect("Default.aspx");
                }
            }

        }

        protected void btnDongY_Click(object sender, EventArgs e)
        {
            if (txtPass.Text == "123")
            {
                Session.Add("username", txtUsr.Text);
                Session.Add("password", txtPass.Text);

                if (chkLuu.Checked)
                {
                    HttpCookie c1 = new HttpCookie("username", txtUsr.Text);
                    HttpCookie c2 = new HttpCookie("password", txtPass.Text);
                    DateTime d = DateTime.Now;
                    TimeSpan ts = new TimeSpan(0, 1, 0, 0);
                    c1.Expires = d.Add(ts);
                    c2.Expires = d.Add(ts);
                    Response.Cookies.Add(c1);
                    Response.Cookies.Add(c2);
                }
                Response.Redirect("Default.aspx");
            }

        }
    }
}