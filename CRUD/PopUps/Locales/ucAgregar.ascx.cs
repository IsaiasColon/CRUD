using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUD.PopUps.Locales
{
    public partial class ucAgregar : System.Web.UI.UserControl
    {
        BLTiendas clase = new BLTiendas();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            clase.Crear(txtNombre.Value, txtDireccion.Text, txtTelefono.Value, txtEncargado.Value, txtDescripcion.Text);
            this.Visible = false;
            Response.Redirect(Request.RawUrl);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}