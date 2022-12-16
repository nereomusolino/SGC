using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Domicilio
    {
        public string Calle { get; set; }
        private int numero;
        public int Numero 
        { 
            get { return numero; } 
            set 
            {
                if (value > 0)
                    numero = value;
                else
                    numero = 0;
            } 
        }
        public string Localidad { get; set; }
        private int piso;
        public int Piso
        {
            get { return piso; }
            set
            {
                if (value > 0)
                    piso = value;
                else
                    piso = 0;
            }
        }
        public string Departamento { get; set; }

    }
}
