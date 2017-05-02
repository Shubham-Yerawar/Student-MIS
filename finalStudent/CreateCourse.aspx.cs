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
    public partial class CreateCourse : System.Web.UI.Page
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
     ");User Id = C##university;password=pass";

                con = new OracleConnection();
                con.ConnectionString = connectionstring;

                con.Open();
                try
                {
                    if (Session["userid"] == null)
                    {
                        Response.Redirect("index.aspx");
                    }
                }
                catch (Exception err) { }

               

               

              

            }
            catch (Exception ele)
            {
                Response.Write("Error: " + ele);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //reset
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                String userid = Session["userid"].ToString();
                int uid = int.Parse(userid);

                OracleCommand cmd = new OracleCommand();

                cmd.CommandText = "select count(*) from course";
                cmd.Connection = con;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();
                /*String s= dr.GetString(0).ToString();
                int n = int.Parse(s);*/
                int n = dr.GetInt32(0);
                n = n + 1;
                cmd.CommandText = "insert into course values(:usrid,:cid,:cname,:cdept,:cfaculty,:ccredits)";
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.Add(new OracleParameter("userid", uid));
                cmd.Parameters.Add(new OracleParameter("cid", n));
                cmd.Parameters.Add(new OracleParameter("cname", TextBox1.Text));
                cmd.Parameters.Add(new OracleParameter("cdept", DropDownList1.SelectedItem.Value));
                cmd.Parameters.Add(new OracleParameter("cfaculty", TextBox2.Text));
                cmd.Parameters.Add(new OracleParameter("ccredits", TextBox3.Text));
                cmd.ExecuteNonQuery();

            }
            catch(Exception err)
            {
                Response.Write("error : " + err);
            }
        }
    }
}