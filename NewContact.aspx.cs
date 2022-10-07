using PhoneBookTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneBookTask
{
    public partial class NewContact : System.Web.UI.Page
    {
        private static int currentID { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        public static void userId(string x)
        {
            currentID= Convert.ToInt16(x);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Contact contact = new Contact();
            contact.Name = name.Text;
            contact.Surname = surname.Text;
            contact.Phone = phone.Text;
            contact.Uid = currentID;

            DBQuery.AddContact(contact);

        }
    }
}