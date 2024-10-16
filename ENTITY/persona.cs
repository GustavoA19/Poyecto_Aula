using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class persona
    {
        private int ID { get; set; }
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Email { get; set; }
        private int Telefono { get; set; }

        public persona() { }
        public persona(int ID, string Nombre, string Apellido, string Email, int Telefono)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Telefono = Telefono;
        }
    }
}
