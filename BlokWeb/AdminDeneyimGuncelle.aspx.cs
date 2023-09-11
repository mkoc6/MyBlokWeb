using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class AdminDeneyimGuncelle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(Request.QueryString["ID"]);
            TxtId.Enabled = false;
            TxtId.Text = x.ToString();
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLDENEYIMTableAdapter DT = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
                TxtBaslık.Text = DT.DeneyimGetir(Convert.ToInt16(x))[0].BASLIK;
                TxtAltBaslık.Text = DT.DeneyimGetir(Convert.ToInt16(x))[0].ALTBASLIK;
                TxtAciklama.Text = DT.DeneyimGetir(Convert.ToInt16(x))[0].ACIKLAMA;
                TxtTarih.Text = DT.DeneyimGetir(Convert.ToInt16(x))[0].TARIH;
            }
        }

        protected void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYIMTableAdapter dr = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            {
                dr.DeneyımGuncelle(TxtBaslık.Text, TxtAltBaslık.Text, TxtAciklama.Text, TxtTarih.Text, Convert.ToInt16(TxtId.Text));
                Response.Redirect("AdminDeneyimler.aspx");
            }
        }

    }
}