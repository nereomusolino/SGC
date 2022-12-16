using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Productos
    {
        private int Id;
        public int ID 
        {
            get { return Id; }
            set 
            {
                if (value > 0 ) Id = value;
                else Id = 0;
            }
        }
        public string Nombre { get; set; }
        /// <summary>
        ///  TEMA STOCK *
        /// </summary>
        public string Categoria { get; set; }
        public bool Actualizacion { get; set; }
        public bool Estado { get; set; }

    }
}
