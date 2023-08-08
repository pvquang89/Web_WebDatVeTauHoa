using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebVeTau.Entity;

namespace WebVeTau
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            add();
        }

        protected void add()
        {
            var fullName = Request.Form["fullName"];
            var cccd = Request.Form["cccd"];
            var sdt = Request.Form["sdt"];
            var email = Request.Form["email"];
            var Password = Request.Form["Password"];
            var myDate = Request.Form["myDate"];
            string gioitinh;

            if (rdogtnu.Checked)
            {
                gioitinh = "Nữ";
            }
            else
            {
                gioitinh = "Nam";
            }

            List<User> users = (List<User>)Session["users"];
            if (Session["users"] == null) 
            {
                users = new List<User>();
            }
            
            if(fullName == null && cccd == null && sdt==null && email == null && Password == null)
            {

            }
            else
            {

            User u = new User(fullName, cccd, sdt, email, Password, gioitinh, myDate);
            users.Add(u);
            Session["users"] = users;
            }
            
        }


    }
}