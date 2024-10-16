using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class envio
    {
        private int ID {  get; set; }
        private string DireccionEntrega { get; set; }
        private DateTime FechaEnvio { get; set; }
        private DateTime FechaEntrega { get; set;}
        private string EstadoEnvio { get; set; }
        public envio () { }
        public envio (int iD, string direccionEntrega, DateTime fechaEnvio, DateTime fechaEntrega, string estadoEnvio)
        {
            this.ID = iD;
            this.DireccionEntrega = direccionEntrega;
            this.FechaEnvio = fechaEnvio;
            this.FechaEntrega = fechaEntrega;
            this.EstadoEnvio = estadoEnvio;
        }
    }
}
