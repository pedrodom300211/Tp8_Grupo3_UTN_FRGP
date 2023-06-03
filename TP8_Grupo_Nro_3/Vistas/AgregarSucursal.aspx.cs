using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Vistas
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        NegocioSucursal neg = new Negocio.NegocioSucursal();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean estado = false;
            Sucursal sucursal = new Sucursal();
            sucursal.setNombreSucursal(txtNombreSucursal.Text);
            sucursal.setDescripcionSucursal("Descripcion Sucursal"/*txtDescripcion.Text*/);
            sucursal.setId_Provincia_Sucursal(1/*ddlProvincia.SelectedIndex*/);
            sucursal.setDireccionSucursal("Direccion sucursal"/*txtDireccion.Text*/);
            estado = neg.agregarSucursal(sucursal/*txtNombreSucursal.Text*/);
            if (estado == true)
            {
                //lblAgregarDato.Text = "Sucursal agregada con exito";
            }
            else
            {
                //lblAgregarDato.Text = "No se pudo agregarSucursal";
            }
        }
    }
}