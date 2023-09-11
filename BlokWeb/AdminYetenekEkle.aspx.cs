using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class AdminYetenekEkle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKTableAdapter dt =new DataSet1TableAdapters.TBLYETENEKTableAdapter();
            dt.YetenkEkle(TextBox1.Text);
            Response.Redirect("AdminYenekeListesi.aspx");
        }
    }
}