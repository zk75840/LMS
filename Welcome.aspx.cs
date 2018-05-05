using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Asad Zafar\\Documents\\library.mdf;Integrated Security = True; Connect Timeout = 30");

        if (con.State == ConnectionState.Closed)
        {
            con.Open();

            if (Session["Username"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            if (Session["Username"] != null)
            {

            }

        }
    }
}