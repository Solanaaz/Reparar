using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Empleado
    {
        private string Nombre;
        private string Apellido;
        private ulong Legajo;

        public Empleado(string Nom, string Ape, uint Leg)
        {
            Nombre = Nom;
            Apellido = Ape;
            Legajo = Leg;
        }

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public string apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public ulong legajo
        {
            get { return Legajo; }
            set { Legajo = value; }
        }

    }
}
