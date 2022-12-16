using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Menu
    {
        public string Nombre { get; set; }
        private string Ingredientes { get; set; }
        private float precioActual;
        public float PrecioActual
        {
            get { return precioActual; }
            set 
            {
                if (value > 0) precioActual = value;
                else precioActual = 0;
                
            }
        }
        private int numero;
        public int Numero
        {
            get { return numero; }
            set
            {
                if (value > 0) numero = value;
                else numero = 0; 
            }
            
        }

    }
}
