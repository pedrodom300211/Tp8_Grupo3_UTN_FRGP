﻿using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vistas
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Boolean confirmacionDeEliminacion = false; 
            NegocioSucursal negocioSucursal = new NegocioSucursal();
            confirmacionDeEliminacion = negocioSucursal.eliminarSucursal(int.Parse(txtIdSucursal.Text));
            if (confirmacionDeEliminacion == true)
            {
                lblMensaje.Text = "La sucursal se ha eliminado con exito";
            }
            else {
                lblMensaje.Text = "Error, no se ha podido eliminar la sucursal"; 
            }
        }
    }
}