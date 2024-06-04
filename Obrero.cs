using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Obrero : Empleado
    {
        private string Oficio;
        private string Categoria;
        private ulong Sueldo;

        public Obrero(string oficio, string categoria, ulong sueldo, string inNom, string inApe, uint inLeg) : 
            base(inNom, inApe, inLeg)
        {
            Oficio = oficio;
            Categoria = categoria;
            Sueldo = sueldo;
        }

        public string oficio
        {
            get { return Oficio; }
            set { Oficio = value; }
        }
        public string categoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }
        public ulong sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
    }
}