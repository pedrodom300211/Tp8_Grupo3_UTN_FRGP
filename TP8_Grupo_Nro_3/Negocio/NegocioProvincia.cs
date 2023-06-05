using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Dao;
using System.Data;

namespace Negocio
{
    public class NegocioProvincia
    {
        public DataTable getTabla()
        {
            DaoProvincia dao = new DaoProvincia();
            return dao.getTablaProvincia();
        }

        public Provincia get(int id)
        {
            DaoProvincia dao = new DaoProvincia();
            Provincia provincia = new Provincia();
            provincia.setId_Provincial(id);
            return dao.getProvincia(provincia);
        }

        public int getCantidadDeProvincias() /// Llama a la funcion getCantidadDeProvincias de la biblioteca DAOProvincias.cs
        {
            DaoProvincia dao = new DaoProvincia();
            return dao.getCantidadDeProvincias();
        }
    } 
}
