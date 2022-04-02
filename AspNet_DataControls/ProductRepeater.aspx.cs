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
    public partial class ProductRepeater : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            NorthwindContext ctx = new NorthwindContext();
            rptProducts.DataSource = ctx.Urunlers.ToList();
            rptProducts.DataBind();
        }
    }
}