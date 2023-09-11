using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class HobiGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtID.Text=x.ToString();
            TxtID.Enabled = false;
            if (Page.IsPostBack==false)
            {
                DataSet1TableAdapters.TBLHOBILERTableAdapter dr = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
           TxtHobi.Text=     dr.HobiGetir(Convert.ToInt16(TxtID.Text))[0].HOBI;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHOBILERTableAdapter DT = new DataSet1TableAdapters.TBLHOBILERTableAdapter();
            DT.HobiGuncelle(TxtHobi.Text,Convert.ToInt16( TxtID.Text));
            Response.Redirect("HobiListesi.aspx");
        }
    }
}