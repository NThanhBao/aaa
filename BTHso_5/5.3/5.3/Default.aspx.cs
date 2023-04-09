using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5._3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String usr = (String)Application["username"];
            String pass = (String)Application["password"];
            if(pass == "123")
            {
                ltbChao.Text = "Chao " + usr;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Remove("username");
            Application.Remove("password");
            Response.Redirect("Default.aspx");
        }
    }
}