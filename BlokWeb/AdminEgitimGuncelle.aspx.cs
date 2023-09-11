using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class AdminEgitimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtId.Enabled = false;
            TxtId.Text =x.ToString();
            if (Page.IsPostBack == false) 
            {
            DataSet1TableAdapters.TBLEGITIMTableAdapter DT = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
                TxtBaslık.Text = DT.EgitimGetir(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBaslık.Text = DT.EgitimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = DT.EgitimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtTarih.Text = DT.EgitimGetir(Convert.ToInt16(x))[0].TARIH;
                TxtGmot.Text = DT.EgitimGetir(Convert.ToInt16(x))[0].GNOT;


            }

        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
           
         
        }

        protected void BtnGuncelle_Click1(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLEGITIMTableAdapter df = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            df.EgitimGuncelle(TxtBaslık.Text,TxtAltBaslık.Text,TxtAltBaslık.Text,TxtTarih.Text,Convert.ToInt16(TxtId.Text));
            Response.Redirect("AdminEgitimler.aspx");

        }
    }
}