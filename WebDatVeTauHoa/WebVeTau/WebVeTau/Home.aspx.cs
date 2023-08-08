﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebVeTau
{
    public partial class Home : System.Web.UI.Page
    {
        public string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["User"] == null)
            {
                username = null;
            }
            else
            {
                    username = Session["User"].ToString();
            }
        }
    }
}