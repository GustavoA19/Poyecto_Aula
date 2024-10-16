using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class factura
    {
        private int ID {  get; set; }
        private double CostoTotal { get; set; }
        private DateTime FechaEmision {  get; set; }
        private string MetodoPago {  get; set; }

        public factura() { }
        public factura(int iD, double costoTotal, DateTime fechaEmision, string metodoPago)
        {
            this.ID = iD;
            this.CostoTotal = costoTotal;
            this.FechaEmision = fechaEmision;
            this.MetodoPago = metodoPago;
        }
    }
}
