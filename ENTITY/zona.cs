using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class zona
    {
        private int ID {  get; set; }
        private string Nombre { get; set; }
        private string Descripcion { get; set; }
        private int CodigoPostal { get; set; }
        public zona() { }
        public zona(int iD, string nombre, string descripcion, int codigoPostal)
        {
            this.ID = iD;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.CodigoPostal = codigoPostal;
        }
    }
}
