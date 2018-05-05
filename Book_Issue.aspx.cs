using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class Book_Issue : System.Web.UI.Page
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
        Random rand = new Random();
        long randnum2 = (long)(rand.NextDouble() * 9000000000) + 1000000000;

       
        
        SqlCommand cmd2 = new SqlCommand("insert into [Students] (PK_USER_ID) (select pk_user_id from [User])", con);
        cmd2.ExecuteNonQuery();
        SqlCommand cmd = new SqlCommand("insert into [Book_Issue] (pk_Book_id,pk_Student_id) values(@pk_Book_id,@pk_student_id)", con);
        cmd.Parameters.AddWithValue("@pk_book_id", TextBox1.Text.Trim());
        cmd.Parameters.AddWithValue("@pk_student_id", TextBox2.Text.Trim());
        cmd.ExecuteNonQuery();
        SqlCommand cmd3 = new SqlCommand("  insert into [Book_Transaction] (generate_code,pk_Book_id) values('"+ randnum2.ToString() +"', (select pk_book_id from Books where pk_book_id = '" + TextBox1.Text+"')) ", con);
        
        cmd3.ExecuteNonQuery();


        con.Close();

        Response.Redirect("~/Book_Issue.aspx");
    }
    private string Encrypt(string clearText)
    {
        string EncryptionKey = "MAKV2SPBNI99212";
        byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                clearText = Convert.ToBase64String(ms.ToArray());
            }
        }
        return clearText;
    }
}