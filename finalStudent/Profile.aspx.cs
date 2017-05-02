using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;


namespace finalStudent
{
    public partial class Profile : System.Web.UI.Page
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
                if (Session["userid"] == null)
                {
                    Response.Redirect("index.aspx");
                }
            }
            catch (Exception err) { }

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
                  String userid = Session["userid"].ToString();
                int n = int.Parse(userid);

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "select * from student where userid=" + n;
                cmd.Connection = con;
                cmd.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                dr.Read();

                Label2.Text = dr.GetString(2);
                Label3.Text = dr.GetString(3);
                Label5.Text = dr.GetString(4);
                Label7.Text = dr.GetString(5);
                Label9.Text = dr.GetString(7);
                Label11.Text = dr.GetString(8);
                Label13.Text = dr.GetString(6);
                Label15.Text = dr.GetString(9);
                Label16.Text = dr.GetInt32(10)+"";

                OracleCommand cmdcr = new OracleCommand();
                cmdcr.CommandText = "select sum(ccredits) from student,takes,course where student.userid=takes.userid and takes.cid=course.cid and student.userid=" + n;
                cmdcr.Connection = con;
                cmdcr.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr1 = cmdcr.ExecuteReader();
                dr1.Read();

                int cred = dr1.GetInt32(0);
                Label16.Text = cred + "";

                OracleCommand cmdcrs1 = new OracleCommand();
                cmdcrs1.CommandText = "select count(*) from (select course.cid,cname,cdept,cfaculty from takes,course where takes.cid=course.cid and takes.userid=" + n+")";
                cmdcrs1.Connection = con;
                cmdcrs1.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr3 = cmdcrs1.ExecuteReader();
                dr3.Read();
                int cntrow = dr3.GetInt32(0);
                //string select = "select course.cid,cname,cdept,cfaculty,ccredits from takes,course where takes.cid=course.cid and takes.userid=" + n; 
                OracleCommand cmdcrs = new OracleCommand();
                cmdcrs.CommandText = "select course.cid,cname,cdept,cfaculty from takes,course where takes.cid=course.cid and takes.userid="+n;
                cmdcrs.Connection = con;
                cmdcrs.CommandType = System.Data.CommandType.Text;
                OracleDataReader dr2 = cmdcrs.ExecuteReader();
               // dr2.Read();
                GridView1.DataSource = dr2;
                GridView1.DataBind();


                String cstr = "   cid         cname      cdept      cfaculty     \n";
                while(cntrow>0)
                {
                    cstr = cstr + dr2.GetInt32(0)+"     " ;
                    cstr = cstr + dr2.GetString(1) + "     ";
                    cstr = cstr + dr2.GetString(2) + "     ";
                    cstr = cstr + dr2.GetString(3) + "     ";
                    cstr = cstr + "\n";
                    cntrow = cntrow - 1;
                    //dr.NextResult();
                }

                TextBox1.Text = cstr;
                TextBox1.Enabled = false;

            /*    string select = "SELECT * FROM tblEmployee";
                Connection c = new Connection();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(select, c.con); //c.con is the connection string

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds);
                dataGridView1.ReadOnly = true;
                GridView1.DataSource = ds.tables[0];*/



            }
            catch (Exception ele)
            {
                Response.Write("Error: " + ele);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewCourses.aspx");
        }

      
    }
}