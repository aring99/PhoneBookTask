using PhoneBookTask.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace PhoneBookTask
{
    public class DBQuery
    {
        private static string sqlConn = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public static void AddContact(Contact c)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try {

                con.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("AddContact", con);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.Add("@Name", SqlDbType.NVarChar).Value = c.Name;
                sqlDA.SelectCommand.Parameters.Add("@Surname", SqlDbType.NVarChar).Value = c.Surname;
                sqlDA.SelectCommand.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = c.Phone;
                sqlDA.SelectCommand.Parameters.Add("@Uid", SqlDbType.Int).Value =c.Uid;
                sqlDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully!");

            }
            catch (Exception e) {
            }
            finally
            {
                con.Close();
            }
        }
        public static void AddUser(User u)
        {
            SqlConnection con = new SqlConnection(sqlConn);
            try
            {
                con.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("AddUser",con);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = u.Email;
                sqlDA.SelectCommand.Parameters.Add("@Upassword", SqlDbType.NVarChar).Value = u.Upassword;
                sqlDA.SelectCommand.Parameters.Add("@IsAdmin", SqlDbType.Bit).Value = u.IsAdmin;
                sqlDA.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Saved Successfully!");
            }
            catch (Exception e)
            {
            }
            finally
            {
                con.Close();
            }
        }
    }
}