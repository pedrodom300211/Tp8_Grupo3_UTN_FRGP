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
        private NegocioMixto NegocioMixto = new NegocioMixto();
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if(! IsPostBack)
            {               
                grdDatos.DataSource = NegocioMixto.getTabla();
                grdDatos.DataBind();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            NegocioMixta auxNm = new NegocioMixta();
            auxNm.setId_Sucursal(Convert.ToInt32(txtIdSucursal.Text));
            grdDatos.DataSource = NegocioMixto.getTablaPorId(auxNm);
            grdDatos.DataBind();
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}