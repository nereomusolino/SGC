using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Proveedores : Datos
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
        public string SituacionFiscal { get; set; }
        public bool Estado { get; set; }
    }
}
