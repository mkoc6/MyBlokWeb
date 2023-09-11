using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class AdminDeneyimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLDENEYIMTableAdapter DT = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            Repeater1.DataSource = DT.DeneyimListesi();
            Repeater1.DataBind();

        }
    }
}