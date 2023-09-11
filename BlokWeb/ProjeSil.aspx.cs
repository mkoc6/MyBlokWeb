using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class ProjeSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x= Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLPROJELERTableAdapter dt = new DataSet1TableAdapters.TBLPROJELERTableAdapter();
            dt.ProjeSil(Convert.ToInt16(x));
            Response.Redirect("Projeler.aspx");
        }
    }
}