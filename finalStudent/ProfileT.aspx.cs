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
    public partial class ProfileT : System.Web.UI.Page
    {
        OracleConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionstring = "Data Source = (DESCRIPTION =" +
       "(ADDRESS = (PROTOCOL = TCP)(HOST = shubham)(PORT = 1521))" +
       "(CONNECT_DATA =" +
         "(SERVER = DEDICATED)" +
         "(SERVICE_NAME = orcl)" +
       ")" +
     ");User Id =C##university;password=pass;";

                try
                {
                    if (Session["userid"] == null)
                    {
                        Response.Redirect("index.aspx");
                    }
                }
                catch (Exception err) { }

                con = new OracleConnection();
                con.ConnectionString = connectionstring;

                con.Open();

                String userid = Session["userid"].ToString();
                int n = int.Parse(userid);

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select fname,lname,dept from teacher where userid=" + n;
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                Label2.Text = dr.GetString(0);
                Label3.Text = dr.GetString(1);
                Label5.Text = dr.GetString(2);
              

            }
            catch (Exception ele)
            {
                Console.Write("Error: " + ele);
            }
        }
    }
}