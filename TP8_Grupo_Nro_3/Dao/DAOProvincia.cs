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
    public class DaoProvincia
    {
        private AccesoDatos ds = new AccesoDatos();
        public Provincia getProvincia (Provincia provincia)
        {
            DataTable tabla = ds.ObtenerTabla("Provincia", "Select * from Provincia where Id_Provincia=" + provincia.getId_Provincia());
            provincia.setId_Provincial(Convert.ToInt32(tabla.Rows[0][0].ToString()));
            provincia.setDescripcionProvincia(tabla.Rows[0][1].ToString());
           
            return provincia;
        }
        public Boolean existeProvincia(Provincia provincia)
        {
            String consulta = "Select * from Provincia where Id_Provincia='" + provincia.getId_Provincia() + "'";
            return ds.existe(consulta);
        }
        public DataTable getTablaProvincia()
        {
           
            DataTable tabla = ds.ObtenerTabla("Provincia", "Select * from Provincia");
            return tabla;
        }
       
        public int getCantidadDeProvincias() /// devuelve la cantidad de provincias almacenadas en la tabla provincias
        {
            int cant = ds.ObtenerCantidadDeRegistros("Select * from Provincia");
            return cant;
        } 
    }
}
