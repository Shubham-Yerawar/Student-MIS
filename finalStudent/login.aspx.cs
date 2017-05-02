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
    public partial class login : System.Web.UI.Page
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
                Response.Write("Connection Successful");
            }
            else
            {
                Response.Write("Connection Unsuccessful");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
                string username = TextBox1.Text;
                String password = TextBox2.Text;
                //Session.Add("username", username);
              //  String userid = (String)Session["userid"];
               // int n = int.Parse(userid);

                OracleCommand cmd = new OracleCommand();

                cmd.CommandText = "select * from login where username='"+username+"'";
                cmd.Connection = con;
             //   con.Open();
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int userid = dr.GetInt32(0);
                String pass = dr.GetString(2);
                String type = dr.GetString(3);

                if (password.Equals(pass))
                {
                    //creating session
                    Session.Add("username", username);
                    Session.Add("userid", userid);
			//String a=session["username"].toString();
                    if (type.Equals("s"))
                    {
                        Response.Redirect("Profile.aspx");

                    }
                    else
                    {
                        if (type.Equals("t"))
                        {
                            Response.Redirect("ProfileT.aspx");

                        }

                    }

                    con.Close();
                }
            }
            catch(Exception err)
            {
                    Response.Write("error" + err);
            }
            



        }
    }
}