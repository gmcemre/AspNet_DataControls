using AspNet_DataControls.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_DataControls
{
    public partial class CategoryRepeater : Page
    {
        NorthwindContext ctx = new NorthwindContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void KategoriListele()
        {
            rptKategori.DataSource = ctx.Kategorilers.ToList();
            rptKategori.DataBind();
        }

        protected void rptKategori_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Sil")
            {
                Kategoriler k = ctx.Kategorilers.FirstOrDefault(x => x.KategoriID == id);
                ctx.Kategorilers.Remove(k);
                ctx.SaveChanges();
                KategoriListele();
            }
        }
    }
}