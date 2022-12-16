using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Compras
    {
        private int idcompra; //(autonum)
        private string metodopago;
        private float preciofinal;

        public int IDCompra
        {
            get { return idcompra; }
            set {
                if (value > 0)
                {
                    idcompra= value;
                }
            }
        }
        public string Cuit { get; set; }
        public DateTime FechaCompra { get; set; }

        public string MetodoPago
        {
            get
            {
                return metodopago;
            }
            set
            {
                if (value.ToString() == "Efectivo" || value.ToString() == "Debito" || value.ToString() == "Credito")
                {
                    metodopago = value;
                }
            }
        }

        public float PrecioFinal
        { 
            get { return preciofinal; } 
            
            set 
            {
                if (value > 0)
                {
                    preciofinal = value;
                }
            } 
        }

        public bool Estado { get; set; }

    }
}
