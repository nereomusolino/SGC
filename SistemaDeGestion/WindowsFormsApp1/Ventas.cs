using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Ventas
    {
        private int Id;
        public int ID
        {
            get { return Id; }
            set
            {
                if (value > 0) Id = value;
                else Id = 0;
            }
        }
        /// PEDIDOS
        public DateTime FechaCompra { get; set; }
        public string TipoVenta { get; set; }
        private float precioFinal;
        public float PrecioFinal
        {
            get { return precioFinal; }
            set 
            {
                if (value > 0) precioFinal = value;
                else precioFinal = 0;
            }
        }
        public string MetodoPago { get; set; }
        public bool Activo { get; set; }
        public bool Estado { get; set; }
    }
}
