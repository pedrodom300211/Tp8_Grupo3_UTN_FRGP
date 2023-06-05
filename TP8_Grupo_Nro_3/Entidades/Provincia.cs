using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        private int ID_Provincia;
        private string Descripcion_Provincia;
        public Provincia()
        { }

        public int getId_Provincia()
        {
            return this.ID_Provincia;
        }
        public String getDescripcionProvincia()
        {
            return this.Descripcion_Provincia;
        }
        public void setId_Provincial(int Id_Provincia)
        {
            this.ID_Provincia = Id_Provincia;
        }
        public void setDescripcionProvincia(String DescProvincia)
        {
            this.Descripcion_Provincia = DescProvincia;
        }
    }
   
}
