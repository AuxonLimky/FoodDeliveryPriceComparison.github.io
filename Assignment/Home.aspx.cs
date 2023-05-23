using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Google.Cloud.Firestore;
using System.Windows.Forms;
using System.Collections;
using Assignment.LinkData;
using System.Web.Security;

namespace Assignment
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Member/ShoppingCart.aspx");
        }
    }
}