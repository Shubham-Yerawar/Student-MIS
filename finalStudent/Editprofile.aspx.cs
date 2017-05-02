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
     
    public partial class Editprofile : System.Web.UI.Page
    {
        OracleConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Session["userid"]==null)
                {
                    Response.Redirect("index.aspx");
                }
            }
            catch(Exception err){}
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

                String userid = Session["userid"].ToString();
                int n = int.Parse(userid);

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select fname,lname from student where userid=" + n;
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                TextBox1.Text = dr.GetString(0);
                TextBox2.Text = dr.GetString(1);
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
            

            }
            catch (Exception ele)
            {
                Response.Write("Error: " + ele);
            }
              

        }


        protected void Button1_Click1(object sender, EventArgs e)
        {
           // Response.Write("heloo");
            try
            {

                /* OracleCommand cmd = new OracleCommand();
                 cmd.CommandText = "insert into student values(222,:fname,:lname)";

                 cmd.Connection = con;

                 cmd.CommandType = System.Data.CommandType.Text;
                 cmd.Parameters.Add(new OracleParameter("fname",TextBox1.Text));
                 cmd.Parameters.Add(new OracleParameter("lname", TextBox2.Text));
                 cmd.ExecuteNonQuery();*/
                TextBox1.Enabled = false;
                TextBox2.Enabled = false;
                String userid = Session["userid"].ToString();
                int n = int.Parse(userid);

                // delete inittial entry
                OracleCommand cmdi = new OracleCommand();
                cmdi.CommandText = "delete from student where userid="+n;
                cmdi.Connection = con;
                cmdi.CommandType = System.Data.CommandType.Text;
                cmdi.ExecuteNonQuery();
                // insert new tuple
                    OracleCommand cmda = new OracleCommand();
                    cmda.Connection = con;

                    //cmda.CommandText = "update student set  dob=:dob  where userid=:userid";
                    //cmda.Parameters.Add(new OracleParameter("dob", TextBox3.Text));
                    cmda.CommandText = "insert into student values(:userid,:sid,:fname,:lname,:dob,:address,:email,:year,:dept,:clgname,:creditsearned)";
                    //cmda.CommandText = "update student set sid=:sid, dob=:dob, address=:address, email=:email, year=:year,dept=:dept,clgname=:clgname,creditsearned=:creitsearned where userid=:userid";
                    cmda.CommandType = System.Data.CommandType.Text;
                    int p = 0;
                    cmda.Parameters.Add(new OracleParameter("userid", n));
                    cmda.Parameters.Add(new OracleParameter("sid", n));
                    cmda.Parameters.Add(new OracleParameter("fname", TextBox1.Text));
                    cmda.Parameters.Add(new OracleParameter("lname", TextBox2.Text));
                    cmda.Parameters.Add(new OracleParameter("dob", TextBox3.Text));
                    cmda.Parameters.Add(new OracleParameter("address", TextBox4.Text));
                    cmda.Parameters.Add(new OracleParameter("email", TextBox5.Text));
                    cmda.Parameters.Add(new OracleParameter("year", DropDownList1.SelectedItem.Value));
                    cmda.Parameters.Add(new OracleParameter("dept", DropDownList2.SelectedItem.Value));
                    cmda.Parameters.Add(new OracleParameter("clgname", TextBox6.Text));
                    cmda.Parameters.Add(new OracleParameter("creditsearned",p));

                   cmda.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
               // Response.Write("Error:" + ex.ToString());
            }

            Response.Redirect("Profile.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
        }
    }
}