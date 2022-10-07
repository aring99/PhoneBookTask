using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace PhoneBookTask
{
    public partial class Login : System.Web.UI.Page
    {
        private static string sqlConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginBtn_Click(object sender, EventArgs e)
        { string email = "";
            string password = "";
            email = userTxt.Text;
            password = passTxt.Text;
                SqlConnection con = new SqlConnection(sqlConn);
                try
                {

                    string query = "select * from UserTable where email ='" + email.ToString() + "' and Upassword= '" + password.ToString() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                    {
                    List<String> str = new List<string>();
                    foreach (DataRow row in dtbl.Rows)
                    {
                        string strValue = Convert.ToString(row["Uid"]);
                        str.Add(strValue.Trim());
                        strValue = Convert.ToString(row["IsAdmin"]);
                        str.Add(strValue.Trim());
                    }
                    ShowContacts.setLoggedInId(str[0]);
                    NewContact.userId(str[0]);
                    if (str[1].Equals("False"))
                        //FormsAuthentication.Authenticate(email, password);
                    FormsAuthentication.RedirectFromLoginPage(email,false);
                    //Response.Redirect("HomePage.aspx");
                    else if (str[1].Equals("True"))
                        Response.Redirect("HomePageAdmin.aspx");
                    //Response.Redirect("HomePage.aspx");
                }
                    else
                    {
                        MessageBox.Show("Wrong login information");
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    con.Close();
                }
            }
        
        
    }
}