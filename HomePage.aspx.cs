using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneBookTask
{
    public partial class HomePage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addContact_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewContact.aspx");
        }

        protected void logOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void showContacts_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowContacts.aspx");
        }

        protected void addUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewUser.aspx");
        }
    }
}