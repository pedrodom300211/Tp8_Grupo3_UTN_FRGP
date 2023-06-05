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
    public class DaoSucursal
    {
        private AccesoDatos ds = new AccesoDatos();
        public Sucursal getSucursal(Sucursal sucursal)
        {
            DataTable tabla = ds.ObtenerTabla("Sucursal", "Select * from Sucursal where Id_Sucursal=" + sucursal.getId_Sucursal());
            sucursal.setId_Sucursal(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            sucursal.setNombreSucursal(tabla.Rows[0][1].ToString());
            sucursal.setDescripcionSucursal(tabla.Rows[0][2].ToString());
            sucursal.setDireccionSucursal(tabla.Rows[0][3].ToString());
            return sucursal;
        }
        public Boolean existeSucursal(Sucursal sucursal)
        {
            String consulta = "Select * from Sucursal where NombreSucursal='" + sucursal.getNombreSucursal() + "'";
            return ds.existe(consulta);
        }
        public DataTable getTablaSucursal()
        {
            // List<Categoria> lista = new List<Categoria>();
            DataTable tabla = ds.ObtenerTabla("Sucursal", "Select * from Sucursal");
            return tabla;
        }
        public int eliminarSucursal(Sucursal sucursal)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalEliminar(ref comando, sucursal);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spEliminarSucursal");
        }
        public int agregarSucursal(Sucursal sucursal)
        {

            sucursal.setId_Sucursal(ds.ObtenerMaximo("SELECT max(Id_Sucursal) FROM Sucursal") + 1);
            SqlCommand comando = new SqlCommand();
            ArmarParametrosSucursalAgregar(ref comando, sucursal);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spAgregarSucursal");
        }
        private void ArmarParametrosSucursalEliminar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.getId_Sucursal();
        }
        private void ArmarParametrosSucursalAgregar(ref SqlCommand Comando, Sucursal sucursal)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@NOMBRESUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.getNombreSucursal();
            SqlParametros = Comando.Parameters.Add("@DESCRIPCIONSUCURSALL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.getDescripcionSucursal();
            SqlParametros = Comando.Parameters.Add("@IDPROVINCIASUCURSAL", SqlDbType.Int);
            SqlParametros.Value = sucursal.getId_Provincia_Sucursal();
            SqlParametros = Comando.Parameters.Add("@DIRECCIONSUCURSAL", SqlDbType.VarChar);
            SqlParametros.Value = sucursal.getDireccionSucursal();
        }
    }
}
