using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Add_book : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\Users\\Asad Zafar\\Documents\\library.mdf;Integrated Security = True; Connect Timeout = 30");

    protected void Page_Load(object sender, EventArgs e)
    {
       
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("insert into [Books] (Book_Name,Author_Name,Book_Price) values(@Book_Name,@Author_Name,@Book_Price)",con);
        cmd.Parameters.AddWithValue("@Book_Name", Textbookname.Text.Trim());
        cmd.Parameters.AddWithValue("@Author_Name", Textauthr.Text.Trim());
        cmd.Parameters.AddWithValue("@Book_Price", Textprice.Text.Trim());
        cmd.ExecuteNonQuery();
        
        SqlCommand updtt = new SqlCommand("update [Books] set [Books].Pk_Lib_Id = Librarian.Pk_Lib_Id from [Books],Librarian Where [Books].pk_Book_id = [Books].pk_Book_id", con);
        updtt.ExecuteNonQuery();
        con.Close();

        Response.Redirect("~/Add Book.aspx");


    }
}