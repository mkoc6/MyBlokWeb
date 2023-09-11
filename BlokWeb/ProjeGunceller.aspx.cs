using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BlokWeb
{
    public partial class ProjeGunceller : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int s = Convert.ToInt16(Request.QueryString["ID"]);
            TextBox1.Text = s.ToString();
            TextBox1.Enabled = false;
            if (Page.IsPostBack == false)
            {
                DataSet1TableAdapters.TBLPROJELERTableAdapter dt = new DataSet1TableAdapters.TBLPROJELERTableAdapter();
                text2.Text = dt.ProjeGetir(Convert.ToInt16(s))[0].PROJELER;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TBLPROJELERTableAdapter dt = new DataSet1TableAdapters.TBLPROJELERTableAdapter();
            dt.ProjeGuncelle(text2.Text, Convert.ToInt16(TextBox1.Text));
            Response.Redirect("Projeler.aspx");          
        }
    }
}