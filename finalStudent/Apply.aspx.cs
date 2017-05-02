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
    public partial class Apply : System.Web.UI.Page
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

            try
            {
                con.Open();
            }
            catch (Exception a)
            {
                Console.Write("error" + a);
            }
            try
            {
                if (Session["userid"] == null)
                {
                    Response.Redirect("index.aspx");
                }
            }
            catch (Exception err) { }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCourses.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                String userid = Session["userid"].ToString();
                int n = int.Parse(userid);

                String cidstr = TextBox1.Text;
                int cid = int.Parse(cidstr);

              /*  OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select cid from course where cid=" + cid;
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int val = dr.GetInt32(0);
                Response.Write(val + "");*/

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "insert into takes values(:sid,:cid,:userid)";
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new OracleParameter("sid", n));
                cmd.Parameters.Add(new OracleParameter("cid", cid));
                cmd.Parameters.Add(new OracleParameter("userid", n));
               
                cmd.ExecuteNonQuery();
                TextBox1.Text = "";
                Label1.Text = "applied successfully";
            }
            catch(Exception err)
            {
               // Response.Write("error ::"+err);
                Label1.Text = "application failed";           
            }
        }
    }
}