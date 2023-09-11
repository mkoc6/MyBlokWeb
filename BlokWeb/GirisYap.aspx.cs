using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace BlokWeb
{
    public partial class GirişYap : System.Web.UI.Page
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1DQCP20\SQLEXPRESS;Initial Catalog=BlogWebDB;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
                  
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Add("KullaniciAdi", TextBox1.Text);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from TBLADMIN where KULLANICI=@P1 and SIFRE=@P2", connection);
            command.Parameters.AddWithValue("@P1", TextBox1.Text);
            command.Parameters.AddWithValue("@P2", TextBox2.Text);
            SqlDataReader DR = command.ExecuteReader();
            if (DR.Read())
            {
                Response.Redirect("AdminDeneyimler.aspx");
            }
            else 
            {
                Response.Write("Hatalı Kullanıcı Adı yada Sifre");
            }
          
        }
    }
}