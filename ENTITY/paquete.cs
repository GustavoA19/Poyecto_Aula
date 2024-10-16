using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class paquete
    {
        private int ID {  get; set; }
        private string Descripcion { get; set; }
        private double Dimension { get; set; }
        private double Peso {  get; set; }
        private bool Fragil {  get; set; }
        private string EstadoPaquete {  get; set; }

        public paquete() { }

        public paquete (int iD, string descripcion, double dimension, double peso, bool fragil, string estadoPaquete)
        {
            this.ID = iD;
            this.Descripcion = descripcion;
            this.Dimension = dimension;
            this.Peso = peso;
            this.Fragil = fragil;
            this.EstadoPaquete = estadoPaquete;
        }
    }
}
