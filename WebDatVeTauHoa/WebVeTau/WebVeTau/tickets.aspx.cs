﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebVeTau
{
    public partial class tickets : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Form["date-di"] != null)
            {
                btn_onclick();
            }
        }

        protected void btn_onclick()
        {
            Response.Redirect("detailTicket.aspx");
        }


    }
}