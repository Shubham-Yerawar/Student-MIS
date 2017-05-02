using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace finalStudent
{
    public partial class LogoutS : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["userid"] == null)
                {
                    Response.Redirect("index.aspx");
                }
            }
            catch (Exception err) { }
            Session.Abandon();
            Response.Redirect("index.aspx");
        }
    }
}