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
   public class NegocioMixto
    {


        public DataTable getTabla()
        {
            DAOmixto dao  = new DAOmixto();
            return dao.getTablaMixta();
          
        }
        public DataTable getTablaPorId(NegocioMixta NM)
        {
            DAOmixto dao = new DAOmixto();
            return dao.getTablaPorId(NM);

        }
    }
}
