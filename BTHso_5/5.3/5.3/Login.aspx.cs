using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5._3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDongY_Click(object sender, EventArgs e)
        {
            Application["username"] = txtUsr.Text;
            Application["password"] = txtPass.Text;
            Response.Redirect("Default.aspx");
        }
    }
}