using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)

        {


            using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asad Zafar\\Documents\\library.mdf;Integrated Security=True;Connect Timeout=30"))
  
                

            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from [User] where Username=@Username and Password=@Password AND IS_APPROVE=1 AND Account_Status = 'Active'", con);
                cmd.Parameters.AddWithValue("@Username", TextBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Password", TextBox2.Text.ToString());
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {



                    Session["Username"] = reader["Username"].ToString();
                    Session["Password"] = reader["Password"].ToString();
                    reader.Close();
                    cmd.Dispose();
                    con.Close();

                    Response.Redirect("~/Welcome.aspx");


                }


                else

                {
                    reader.Close();
                    cmd.Dispose();
                    con.Close();
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    Label3.Text = "Invalid User Name or Password!";
                    TextBox1.Text = "";
                    TextBox2.Text = "";



                }
            }
        }
    
}
}