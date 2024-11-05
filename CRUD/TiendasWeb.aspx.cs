using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD
{
    public partial class TiendasWeb : System.Web.UI.Page
    {
        BLTiendas clase = new BLTiendas();
        protected void Page_Load(object sender, EventArgs e)
        {
            rptLocales.DataSource = clase.GetLocales;
            rptLocales.DataBind();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            this.ucAgregar.Visible = true;
        }
    }
}