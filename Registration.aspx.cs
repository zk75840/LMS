using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Asad Zafar\\Documents\\library.mdf;Integrated Security=True;Connect Timeout=30");
    protected void Page_Load(object sender, EventArgs e)
    {

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

    }


    protected void Reg(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            if (IsUsernameEmailExist())
            {

                Messagebox("Username/Email address already exists. Please try another");
                return;
            }

             SqlCommand cmd = new SqlCommand("insert into [User] (UserName,Password,Email,City,Country,Addresss,Contact,First_Name,Last_Name,Account_Status) values(@UserName,@Password,@Email,@City,@Country,@Addresss,@Contact,@First_Name,@Last_Name,'Active')", con);
                cmd.Parameters.AddWithValue("@username", Textuname.Text.Trim());
                cmd.Parameters.AddWithValue("@First_Name", Textfname.Text.Trim());
                cmd.Parameters.AddWithValue("@Last_Name", Textlname.Text.Trim());
                cmd.Parameters.AddWithValue("@Email", Textemail.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", Textpass.Text.Trim());
                cmd.Parameters.AddWithValue("@Addresss", Textadres.Text.Trim());
                cmd.Parameters.AddWithValue("@Contact", Textcontact.Text.Trim());
                cmd.Parameters.AddWithValue("@City", Textcity.Text.Trim());
                cmd.Parameters.AddWithValue("@Country", Textcountry.Text.Trim());


                
                cmd.ExecuteNonQuery();
               
                Sendemail();
                Clear();
                Response.Redirect("thankyoureg.aspx");
                cmd.Dispose();

            }
            else
            {
                Messagebox("Passowrd Not Match");
            }
        
    }
    public void Sendemail()
    {
        string ActivationUrl;
        try
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("asadzafar26@gmail.com", "OPEN LIBRARY");
            message.To.Add(Textemail.Text);
            message.Subject = "Verification Email";
            ActivationUrl = Server.HtmlEncode("http://localhost:57245/Verification.aspx?pk_User_id=" + Getpk_User_id(Textemail.Text));
            //message.Body = "<a href="\"http://localhost:57245/Important_Testing/Verification.aspx?pk_User_id ="+Session">Click here to verify</a>dsdsdsdsds";
            message.Body = "<a href='" + ActivationUrl + "'>Click Here to Verify your account</a>";
            message.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new System.Net.NetworkCredential("asadzafar26@gmail.com", "dubai111244622");
            smtp.EnableSsl = true;
            smtp.Send(message);
        }
        catch (Exception ex)
        {
        }
    }
    private string Getpk_User_id(string Email)
    {

        SqlCommand cmd = new SqlCommand("SELECT pk_User_id FROM [User] WHERE Username=@Username", con);

        cmd.Parameters.AddWithValue("@Username",Textuname.Text);
        string Pk_Reg_Id = cmd.ExecuteScalar().ToString();
        return Pk_Reg_Id;
    }

    private bool IsUsernameEmailExist()
    {
        SqlCommand cmd = new SqlCommand("Select * from [User] where USERNAME='" + Textuname.Text + "' or Email='" + Textemail.Text + "'", con);
        cmd.ExecuteNonQuery();
        DataTable dt = new DataTable();
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        adp.Fill(dt);
        if (dt.Rows.Count > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void Messagebox(string Message)
    {
        Label lblMessageBox = new Label();

        lblMessageBox.Text =
            "<script language='javascript'>" + Environment.NewLine +
            "window.alert('" + Message + "')</script>";

        Page.Controls.Add(lblMessageBox);

    }
    public void Clear()
    {
        Textfname.Text = "";
        Textlname.Text = "";
        Textuname.Text = "";
       Textpass.Text = "";
       Textemail.Text = "";
        Textcountry.Text = "";
       Textcity.Text = "";
        Textcontact.Text = "";
    }
}