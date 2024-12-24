using System;
using System.Web;

namespace CookiesASPWebForms
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["userCookie"];

            if (cookie != null)
            {
                Response.Write("Welcome " + cookie["username"].ToString());
            }
            else
            {
                Response.Write("Cookie is null or not created!");
            }
        }
    }
}