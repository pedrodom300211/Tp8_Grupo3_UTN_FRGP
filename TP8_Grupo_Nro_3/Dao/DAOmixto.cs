using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Dao
{
    class DAOmixto
    {
        private AccesoDatos ds = new AccesoDatos();
        public NegocioMixta getMixto(NegocioMixta NM)
        {
            DataTable tabla = ds.ObtenerTabla("Sucursal", "Select id_Sucursal,NombreSucursal,DescripcionSucursal,DescripcionProvincia,DireccionSucursal from Sucursal inner join  Provincia on Sucursal.Id_ProvinciaSucursal=Provincia.Id_Provincia where Id_Sucursal=" + NM.getId_Sucursal());
            NM.setId_Sucursal(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            NM.setNombreSucursal(tabla.Rows[0][1].ToString());
            NM.setDescripcionSucursal(tabla.Rows[0][2].ToString());
            NM.setDescripcionProvincia(tabla.Rows[0][3].ToString());
            NM.setDireccionSucursal(tabla.Rows[0][4].ToString());
            return NM;
        }
      
    }
}
