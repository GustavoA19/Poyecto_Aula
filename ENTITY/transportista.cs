using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class transportista : persona
    {
        private bool EstadoVerificado {  get; set; }
        private bool Disponibilidad {  get; set; }
        private DateTime FechaRegistro { get; set; }
        private DateTime RegistroDiario { get; set; }
        private int EnviosDiario { get; set; }

        public transportista()
        {

        }

        public transportista(int ID, string Nombre, string Apellido, string Email, int Telefono, bool estadoVerificado, bool disponibilidad, DateTime fechaRegistro, DateTime registroDiario, int enviosDiario)
            : base(ID, Nombre, Apellido, Email, Telefono)
        {
            this.EstadoVerificado = estadoVerificado;
            this.Disponibilidad = disponibilidad;
            this.FechaRegistro = fechaRegistro;
            this.RegistroDiario = registroDiario;
            this.EnviosDiario = enviosDiario;
        }
    }
}
