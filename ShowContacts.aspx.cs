using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PhoneBookTask
{
    public partial class ShowContacts : System.Web.UI.Page
    {
        private static int currentID { get; set; }
        private static string sqlConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static void setLoggedInId(string x)
        {
            currentID = Convert.ToInt16(x);
        }
        protected void licobtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                SqlCommand cmd = new SqlCommand("ShowContacts", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // FormsAuthentication is in System.Web.Security
                // SqlParameter is in System.Data namespace
                SqlParameter paramUid = new SqlParameter("@currentId", currentID);
                cmd.Parameters.Add(paramUid);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = rdr;
                gvPhoneBook.DataSource = source;
                gvPhoneBook.DataBind();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                con.Close();
            }

        }

        protected void btnHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}