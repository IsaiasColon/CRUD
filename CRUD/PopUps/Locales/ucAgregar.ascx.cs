using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD;

namespace CRUD.PopUps.Locales
{
    public partial class ucAgregar : System.Web.UI.UserControl
    {
        BLTiendas clase = new BLTiendas();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public int idLocal
        {
            set
            {
                hidIdLocal.Value = value.ToString();
                if (hidIdLocal.Value != null || hidIdLocal.Value != "0")
                {
                    var local = clase.GetLocal(int.Parse(hidIdLocal.Value));

                    //var local = clase.GetLocal(value);
                    if (local != null)
                    {
                        hidIdLocal.Value = local.Id.ToString();
                        txtNombre.Value = local.Nombre;
                        txtDireccion.Text = local.Direccion;
                        txtTelefono.Value = local.Telefono;
                        txtEncargado.Value = local.Encargado;
                        txtDescripcion.Text = local.Descripcion;
                    }
                }
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (hidIdLocal.Value == "0")
            {
                    clase.Crear(txtNombre.Value, txtDireccion.Text, txtTelefono.Value, txtEncargado.Value, txtDescripcion.Text);
            }
            else
            {
                clase.Editar(int.Parse(hidIdLocal.Value), txtNombre.Value, txtDireccion.Text, txtTelefono.Value, txtEncargado.Value, txtDescripcion.Text);
            }

            this.Visible = false;
            Response.Redirect(Request.RawUrl);
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}