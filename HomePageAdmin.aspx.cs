using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneBookTask
{
    public partial class HomePageAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }

        protected void userHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}