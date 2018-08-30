using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baseball
{
    class Estadio
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Capacidad { get; set; }

        public Estadio()
        {
            Direccion = "Direccion de estadio";
            Capacidad = 0;
        }

        public Estadio(string nombre)
        {
            Nombre = nombre;
        }
    }
}
