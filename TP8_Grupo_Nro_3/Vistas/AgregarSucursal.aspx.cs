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
            CargarDropDownList(ddlProvincia);
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Boolean estado;
            Sucursal sucursal = new Sucursal();
            sucursal.setNombreSucursal(txtNombreSucursal.Text.ToString());
            sucursal.setDescripcionSucursal(txtDescripcion.Text.ToString());
            sucursal.setId_Provincia_Sucursal(Convert.ToInt32(ddlProvincia.SelectedIndex.ToString()));
            sucursal.setDireccionSucursal(txtDireccion.Text.ToString());
            estado = neg.agregarSucursal(sucursal/*txtNombreSucursal.Text*/);
            if (estado == true)
            {
                lblAgregarDato.Text = "Sucursal agregada con exito";
            }
            else
            {
                lblAgregarDato.Text = "No se pudo agregarSucursal";
            }
        }

        DropDownList CargarDropDownList(DropDownList ddl) // carga el DropDownList con las provincias de la base de datos
        {
            NegocioProvincia np = new NegocioProvincia();
            for (int i = 1; i <= np.getCantidadDeProvincias(); i++)
            {
                ddlProvincia.Items.Add(np.get(i).getDescripcionProvincia());
            }
            return ddl;
        }
    }
}