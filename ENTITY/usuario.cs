using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class usuario : persona
    {
        private string NombreUsuario {  get; set; }
        private string Contraseña { get; set; }
        private string Rol {  get; set; }

        public usuario() { }
        public usuario(int ID, string Nombre, string Apellido, string Email, int Telefono, string nombreUsuario, string contraseña, string rol)
            : base (ID, Nombre, Apellido, Email, Telefono)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contraseña = contraseña;
            this.Rol = rol;
        }
    }
}
