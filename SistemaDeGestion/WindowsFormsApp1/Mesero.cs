using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Mesero : Empleados
    {
        int cantidadmesas; // (por jornada)
        float facturacion;  // (por jornada)

        public int CantidadMesas
        {
            get { return cantidadmesas; }

            set
            {
                if (value > 0)
                {
                    cantidadmesas = value;
                }
            }
        }

        public float Facturacion
        {
            get { return Facturacion; }
            set
            {
                if (value > 0)
                {
                    facturacion= value;
                }
            }
        }

        public string Sector { get; set; }
    }
}
