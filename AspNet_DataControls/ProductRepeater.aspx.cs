using AspNet_DataControls.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspNet_DataControls
{
    using Models;
    using System.Web.UI.HtmlControls;

    public partial class ProductRepeater : Page
    {
        NorthwindContext ctx = new NorthwindContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void UrunListele()
        {
            rptProducts.DataSource = ctx.Urunlers.ToList();
            rptProducts.DataBind();
        }

        protected void rptProducts_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            HtmlTableRow str = (HtmlTableRow)e.Item.FindControl("satir");
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Urunler u = (Urunler)e.Item.DataItem;
                if (u.BirimFiyati > 50)
                    str.Style.Add("color", "Red");
                else
                    str.Style.Add("color", "Green");
            }
        }

        protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Sil")
            {
                Urunler u = ctx.Urunlers.FirstOrDefault(x => x.UrunID == id);
                ctx.Urunlers.Remove(u);
                ctx.SaveChanges();
                UrunListele();
            }
            else if (e.CommandName == "Duzenle")
            {
            }
        }
    }
}