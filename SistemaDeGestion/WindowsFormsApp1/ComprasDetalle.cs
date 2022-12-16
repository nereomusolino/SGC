using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ComprasDetalle
    {
        private int idcompra;
        public string Producto { get; set; }
        private int cantidad;
        private float preciounidad;
        private float descuento;
        private float monto;

        public int IDCompra
        {
            get { return idcompra; }
            set
            {
                if (value > 0)
                {
                    idcompra = value;
                }
            }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set 
            {
                if (value > 0)
                {
                    cantidad= value;
                }
            }
        }

        public float PrecioUnidad
        {
            get { return preciounidad; }
            set
            {
                if (value > 0)
                {
                    preciounidad = value;
                }
            }
        }

        public float Descuento
        {
            get { return descuento; }
            set
            {
                if (value > 0)
                {
                    descuento = value;
                }
            }
        }

        public float Monto
        {
            get { return monto; }
            set
            {
                if (value > 0)
                {
                    monto = value;
                }
            }
        }

    }
}
