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
    public class NegocioSucursal
    {
        public DataTable getTabla()
        {
            DaoSucursal dao = new DaoSucursal();
            return dao.getTablaSucursal();
        }

        public Sucursal get(int id)
        {
            DaoSucursal dao = new DaoSucursal();
            Sucursal sucursal = new Sucursal();
            sucursal.setId_Sucursal(id);
            return dao.getSucursal(sucursal);
        }

        public bool eliminarSucursal(int id)
        {
            //Validar id existente 
            DaoSucursal dao = new DaoSucursal();
            Sucursal sucursal = new Sucursal();
            sucursal.setId_Sucursal(id);
            int op = dao.eliminarSucursal(sucursal);
            if (op == 1)
                return true;
            else
                return false;
        }

        public bool agregarSucursal(Sucursal sucursal/*String nombre*/)
        {
            int cantFilas = 0;

            //Sucursal sucursal = new Sucursal();
            //sucursal.setNombreSucursal(nombre);

            DaoSucursal dao = new DaoSucursal();
            if (dao.existeSucursal(sucursal) == false)
            {
                cantFilas = dao.agregarSucursal(sucursal);
            }

            if (cantFilas == 1)
                return true;
            else
                return false;
        }
    }
}
