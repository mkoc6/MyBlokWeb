using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class AdminDeneyimSil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt16(Request.QueryString["ID"]);
            DataSet1TableAdapters.TBLDENEYIMTableAdapter DR = new DataSet1TableAdapters.TBLDENEYIMTableAdapter();
            DR.DeneyimSil(Convert.ToInt16(id));
            Response.Redirect("AdminDeneyimler.aspx");
        }
    }
}