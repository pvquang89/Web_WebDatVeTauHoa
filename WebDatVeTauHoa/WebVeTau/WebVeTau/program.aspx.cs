using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebVeTau.Entity;

namespace WebVeTau
{
    public partial class program : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //btnLogin_Click();

            //btnRegister_Click();

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {

            var username = Request.Form["Uname"];
            var password = Request.Form["passW"];
            List<User> users = (List<User>)Session["users"];
            if (users == null)
            {
                users = new List<User>();
                User u = new User();
                users = u.constructor();
            }
            foreach (User user in users)
            {
                if (username == user.getmail() && password == user.getPass())
                {
                    Session["User"] = user.getmail();
                    Response.Redirect("https://localhost:44327/html/homePage.html");
                }
            }
            Response.Redirect("https://localhost:44327/html/loginPage.html");

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            var fullName = Request.Form["fullName"];
            var cccd = Request.Form["cccd"];
            var sdt = Request.Form["sdt"];
            var email = Request.Form["email"];
            var Password = Request.Form["Password"];
            var gioitinh = Request.Form["rdo-gt"];
            var mydate = Request.Form["myDate"];

            List<User> users = (List<User>)Session["users"];
            User u = new User();
            users=u.constructor();
            foreach (User user in users)
            {
                if (user.getCccd() == cccd || user.getmail()==email || user.getTel() == sdt)
                {
                    
                    Response.Redirect("https://localhost:44327/html/RegisterPage.html");
                }
            }

        }

    }

}