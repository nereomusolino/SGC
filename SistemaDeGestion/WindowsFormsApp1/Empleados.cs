using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Empleados : Datos
    {
        private int id;
        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0) id = value;
                else id = 0;
            }
        }
        public string DNI { get; set; }
        public DateTime FechaNacimiento { get; set; }
        private float jornada;
        public float Jornada
        {
            get { return jornada; }
            set
            {
                if ((value > 0) && (value < 24)) jornada = value;
                else jornada = 0;
            }
        }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string TipoJornada { get; set; }
        private int dias;
        public int Dias
        {
            get { return dias; }
            set
            {
                if((value>0) && (value<8)) dias = value;
                else dias = 0;
            }
        }
        public bool Presentismo { get; set; }
    }
}
