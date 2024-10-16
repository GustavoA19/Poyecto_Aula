using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class cliente : persona
    {
        private string Direccion {  get; set; }
        private string TipoCliente {  get; set; }

        public cliente() { }

        public cliente(int ID, string Nombre, string Apellido, string Email, int Telefono, string direccion, string tipoCliente)
            : base(ID, Nombre, Apellido, Email, Telefono)
        {
            this.Direccion = direccion;
            this.TipoCliente = tipoCliente;
        }
    }
}
