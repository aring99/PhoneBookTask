using PhoneBookTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneBookTask
{
    public partial class NewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePageAdmin.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = email.Text; 
            user.Upassword = upassword.Text;
            user.IsAdmin = Convert.ToInt16(isAdmin.Text);

            DBQuery.AddUser(user);
        }

    }
}