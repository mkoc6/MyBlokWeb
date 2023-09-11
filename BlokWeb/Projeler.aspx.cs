using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class Projeler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLPROJELERTableAdapter dt = new DataSet1TableAdapters.TBLPROJELERTableAdapter();
            Repeater1.DataSource = dt.ProjelerListesi();
            Repeater1.DataBind();
        }
    }
}