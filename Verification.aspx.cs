using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Verification : System.Web.UI.Page
{
   SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Asad Zafar\\Documents\\library.mdf;Integrated Security = True; Connect Timeout = 30");
   
    string pk_User_id, Username;
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.QueryString["pk_User_id"] != null)
        {
            pk_User_id = Request.QueryString["pk_User_id"];
            SqlCommand cmd = new SqlCommand("Update [User] set IS_APPROVE=1 where pk_User_id=@pk_User_id", con);
            cmd.Parameters.AddWithValue("pk_User_id", pk_User_id);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write(Request.QueryString["pk_User_id"]);

        }
    }
}