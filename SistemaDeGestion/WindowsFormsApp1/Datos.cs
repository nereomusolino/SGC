using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Datos
    {
        private Domicilio direccion;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Cuit { get; set; }
        public Domicilio Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

    }
}
