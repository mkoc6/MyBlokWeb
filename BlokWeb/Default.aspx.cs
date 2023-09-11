using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter dt = new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
            Repeater1.DataSource = dt.HakkimdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.TBLDENEYIMTableAdapter dr = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            Repeater2.DataSource = dr.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.TBLEGITIMTableAdapter de = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            Repeater3.DataSource=de.EgitimListesi();
            Repeater3.DataBind();

            DataSet1TableAdapters.TBLHOBILERTableAdapter DY= new DataSet1TableAdapters .TBLHOBILERTableAdapter();
            Repeater4.DataSource=DY.HobiListesi();
            Repeater4.DataBind();   

            DataSet1TableAdapters.TBLPROJELERTableAdapter DU = new DataSet1TableAdapters.TBLPROJELERTableAdapter();
            Repeater5.DataSource=DU.ProjelerListesi();
            Repeater5.DataBind();
            
            DataSet1TableAdapters.TBLYETENEKTableAdapter dq= new DataSet1TableAdapters.TBLYETENEKTableAdapter();
            Repeater6.DataSource=dq.YenekListesi();
            Repeater6.DataBind();
            
            DataSet1TableAdapters.TBLHAKKIMDATableAdapter det= new DataSet1TableAdapters.TBLHAKKIMDATableAdapter();
           Repeater7.DataSource=det.HakkimdaListele();
            Repeater7.DataBind();
        }
    }
}