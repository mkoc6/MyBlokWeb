using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class AdminYetenekGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
           int x = Convert.ToInt16( Request.QueryString["ID"]);
            TxtId.Text=x.ToString();
            TxtId.Enabled = false;
            if (Page.IsPostBack ==false)
            {
            DataSet1TableAdapters.TBLYETENEKTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKTableAdapter();
            TxtYetenek.Text = dt.YetenekGetir(Convert.ToInt16(x))[0].YETENEK;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLYETENEKTableAdapter dt = new DataSet1TableAdapters.TBLYETENEKTableAdapter();
            dt.YetenekGuncelle(TxtYetenek.Text, Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminYenekeListesi.aspx");
        }
    }
}