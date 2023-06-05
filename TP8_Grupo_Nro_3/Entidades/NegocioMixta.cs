using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class NegocioMixta
    {
        private int ID_Provincia;
        private string Descripcion_Provincia;
        private int Id_Sucursal;
        private String NombreSucursal;
        private String DescripcionSucursal;
        private int Id_Provincia_Sucursal;
        private String DireccionSucursal;
        public NegocioMixta()
        { }
        public int getId_Sucursal()
        {
            return this.Id_Provincia_Sucursal;
        }
        public String getNombreSucursal()
        {
            return this.NombreSucursal;
        }
        public String getDescripcionSucursal()
        {
            return this.DescripcionSucursal;
        }
        public int getId_Provincia_Sucursal()
        {
            return this.Id_Provincia_Sucursal;
        }
        public String getDireccionSucursal()
        {
            return this.DireccionSucursal;
        }
        ///  Sets
        public void setId_Sucursal(int Id_Provincia_Sucursal)
        {
            this.Id_Provincia_Sucursal = Id_Provincia_Sucursal;
        }
        public void setNombreSucursal(String NombreSucursal)
        {
            this.NombreSucursal = NombreSucursal;
        }
        public void setDescripcionSucursal(String DescripcionSucursal)
        {
            this.DescripcionSucursal = DescripcionSucursal;
        }
        public void setId_Provincia_Sucursal(int Id_Provincia_Sucursal)
        {
            this.Id_Provincia_Sucursal = Id_Provincia_Sucursal;
        }
        public void setDireccionSucursal(String DireccionSucursal)
        {
            this.DireccionSucursal = DireccionSucursal;
        }
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
