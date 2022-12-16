using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Pedidos
    {
        public string Categoria { get; set; }
        public string Producto { get; set; }
        private int cantidad;
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value > 0) cantidad = value;
                else cantidad = 0;
            }
        }
        private float precioUnidad;
        public float PrecioUnidad
        {
            get { return precioUnidad; }
            set
            {
                if (value > 0) precioUnidad = value;
                else precioUnidad = 0;
            }
        }
    }
}
