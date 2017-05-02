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
    public partial class EditProfileT : System.Web.UI.Page
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
     ");User Id = C##university;password=pass;";

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

            try
            {
                String userid = Session["userid"].ToString();
                int n = int.Parse(userid);

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select fname,lname from teacher where userid=" + n;
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                String fname = dr.GetString(0);
                String lname = dr.GetString(1);
                


                OracleCommand cmdi = new OracleCommand();
                cmdi.CommandText = "delete from teacher where userid=" + n;
                cmdi.Connection = con;
                cmdi.CommandType = System.Data.CommandType.Text;
                cmdi.ExecuteNonQuery();


                OracleCommand cmda = new OracleCommand();
                cmda.Connection = con;
                cmda.CommandText = "insert into teacher values(:userid,:fname,:lname,:dept)";
                cmda.CommandType = System.Data.CommandType.Text;
                cmda.Parameters.Add(new OracleParameter("userid", n));
                cmda.Parameters.Add(new OracleParameter("fname", fname));
                cmda.Parameters.Add(new OracleParameter("lname", lname));
                cmda.Parameters.Add(new OracleParameter("dept", DropDownList1.SelectedItem.Value));
                cmda.ExecuteNonQuery();

                Response.Redirect("ProfileT.aspx");

            }
            catch(Exception err)
            {
                Response.Write("errror "+err);
            }
        }
    }
}