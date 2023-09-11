using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class AdminEgitimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = (Request.QueryString["ID"].ToString());
            DataSet1TableAdapters.TBLEGITIMTableAdapter dr = new DataSet1TableAdapters.TBLEGITIMTableAdapter();
            dr.EgitimSil(short.Parse(id));
            Response.Redirect("AdminEgitimler.aspx");

        }
    }
}