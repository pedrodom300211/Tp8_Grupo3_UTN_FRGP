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
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if(! IsPostBack)
            {
                NegocioMixto NegocioMixto= new NegocioMixto();
                /*grdDatos.DataSource = NegocioMixto.getTabla();
                grdDatos.DataBind();*/
                grdDatos.DataSource = NegocioMixto.getTabla();
                grdDatos.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}