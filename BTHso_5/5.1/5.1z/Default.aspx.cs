using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5._1z
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                String usr = Session["username"].ToString();
                String pas = Session["password"].ToString();
                lblThongbao.Text = "Xin Chào: " + usr;
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}