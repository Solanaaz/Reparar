using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Obrero : Empleado
    {
        //Variables Miembro
        private string Oficio;
        private string Categoria;
        private float Sueldo;

        //Metodos Miembro
        public Obrero(string oficio, string categoria, float sueldo, string inNom, string inApe, ulong inLeg) :
            base(inNom, inApe, inLeg)
        {
            Oficio = oficio;
            Categoria = categoria;
            Sueldo = sueldo;
        }

        public void SetOficio(string oficio)
        {
            this.Oficio = oficio;
        }

        public void SetCategoria(string categoria)
        {
            this.Categoria = categoria;
        }

        public void SetSueldo(float sueldo)
        {
            this.Sueldo = sueldo;
        }

        public string GetOficio()
        {
            return this.Oficio;
        }

        public string GetCategoria()
        {
            return this.Categoria;
        }

        public float GetSueldo()
        {
            return this.Sueldo;
        }
    }
}