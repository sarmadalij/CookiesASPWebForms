using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CookiesASPWebForms
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("userCookie");
            cookie["username"] = TextBoxUsername.Text;
            cookie.Expires = DateTime.Now.AddDays(1); //cookie expires in 1 day

            Response.Cookies.Add(cookie);
            Response.Redirect("WebForm1.aspx");

        }
    }
}