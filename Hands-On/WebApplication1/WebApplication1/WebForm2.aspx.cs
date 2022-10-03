using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace producs
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string unmae = "Raj";
        string pass = "Raj@123";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == unmae && TextBox2.Text == pass)
            {
                Response.Redirect("~/WebForm1.aspx");
            }
            else
            {
                Response.Write("invalid username and password");
            }
        }
    }
}