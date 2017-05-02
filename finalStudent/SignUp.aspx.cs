using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls; 
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace finalStudent
{
    public partial class SignUp : System.Web.UI.Page
    {
        OracleConnection con = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            String connectionString = "Data Source= (DESCRIPTION =" +
   "(ADDRESS = (PROTOCOL = TCP)(HOST = shubham)(PORT = 1521))" +
   "(CONNECT_DATA ="
     + "(SERVER = DEDICATED)" +
     "(SERVICE_NAME = orcl)));" + "User Id=C##university; password=pass;";
            con = new OracleConnection(connectionString);
            // string connectionString ="Host=SHUBHAM; Data Source=orcl; User ID=C##sry; Password=pass";
            try
            {
                con.Open();
            }
            catch (Exception a)
            {
                Console.Write("error" + a);
            }
            if (con != null)
            {
                Console.Write("Connection Successful");
            }
            else
            {
                Console.Write("Connection Unsuccessful");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                OracleCommand cmd = new OracleCommand();

                cmd.CommandText = "select count(*) from login";
                cmd.Connection = con;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                /*String s= dr.GetString(0).ToString();
                int n = int.Parse(s);*/
                int n = dr.GetInt32(0);
                n = n + 1;
               cmd.CommandText = "insert into login values(:usrid,:username,:password,:type)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new OracleParameter("userid", n));
                cmd.Parameters.Add(new OracleParameter("username", TextBox3.Text));
                cmd.Parameters.Add(new OracleParameter("password", TextBox4.Text));
                cmd.Parameters.Add(new OracleParameter("type", DropDownList1.SelectedItem.Value));
                cmd.ExecuteNonQuery();

                //creating session
              //  Session.Add("username", TextBox3.Text);
                //Session.Add("userid", n);



                String type=DropDownList1.SelectedItem.Value;
              //   Console.Write(type);
               //  Label1.Text = type;
                 if(type.Equals("s"))
                 {
                    
                 OracleCommand cmda = new OracleCommand();
                 cmda.Connection = con;
                 cmda.CommandText = "insert into student values(:userid,:sid,:fname,:lname,:dob,:address,:email,:year,:dept,:clgname,:creditsearned)";
                 cmda.CommandType = System.Data.CommandType.Text;
                 cmda.Parameters.Add(new OracleParameter("userid", n));
                 cmda.Parameters.Add(new OracleParameter("sid", n));
                 cmda.Parameters.Add(new OracleParameter("fname", TextBox1.Text));
                 cmda.Parameters.Add(new OracleParameter("lname", TextBox5.Text));
                 cmda.Parameters.Add(new OracleParameter("dob", null));
                 cmda.Parameters.Add(new OracleParameter("address", null));
                 cmda.Parameters.Add(new OracleParameter("email", null));
                 cmda.Parameters.Add(new OracleParameter("year", null));
                 cmda.Parameters.Add(new OracleParameter("dept", null));
                 cmda.Parameters.Add(new OracleParameter("clgname", null));
                 cmda.Parameters.Add(new OracleParameter("creditsearned", null));

                 cmda.ExecuteNonQuery();
                 }
                 else
                 {
                     if (type.Equals("t"))
                     {
                         OracleCommand cmdt = new OracleCommand();
                         cmdt.Connection = con;
                         cmdt.CommandText = "insert into teacher values(:userid,:fname,:lname,:dept)";
                         cmdt.CommandType = System.Data.CommandType.Text;
                         cmdt.Parameters.Add(new OracleParameter("userid", n));
                     //    cmd.Parameters.Add(new OracleParameter("sid", n));
                         cmdt.Parameters.Add(new OracleParameter("fname", TextBox1.Text));
                         cmdt.Parameters.Add(new OracleParameter("lname", TextBox5.Text));
                         cmdt.Parameters.Add(new OracleParameter("dept", null));
                         cmdt.ExecuteNonQuery();
                     }
                 }
                 
            }
            catch (Exception ex)
            {
                Response.Write("Error:" + ex.ToString());
            }
            Response.Redirect("login.aspx");
        }
    }
}