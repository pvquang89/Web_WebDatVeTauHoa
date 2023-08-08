using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebVeTau.Entity;

namespace WebVeTau
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["User"] = null;
            btnLogin_Click();
        }
        protected void btnLogin_Click()
        {

            var username = Request.Form["Uname"];
            var password = Request.Form["passW"];
            List<User> users = (List<User>)Session["users"];
            if (users == null)
            {
                User u = new User();
                users = u.constructor();
                Session["users"] = users;
            }

            foreach (User user in users)
            {
                if (username == user.getmail() && password == user.getPass())
                {
                    Session["User"] = user.getFullNam();
                    Response.Redirect("Home.aspx");
                }
            }
           


        }
    }
}