using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Empleado
    {
        //Variables Miembro
        private string Nombre;
        private string Apellido;
        private ulong Legajo;


        //Metodos Miembro
        public Empleado(string Nom, string Ape, ulong Leg)
        {
            Nombre = Nom;
            Apellido = Ape;
            Legajo = Leg;
        }

        public void SetNom(string Nom)
        {
            this.Nombre = Nom;
        }

        public void SetApe(string Ape)
        {
            this.Apellido = Ape;
        }

        public void SetLeg(ulong Leg)
        {
            this.Legajo = Leg;
        }

        public string GetNom()
        {
            return this.Nombre;
        }

        public string GetApe()
        {
            return this.Apellido;
        }

        public ulong GetLeg()
        {
            return this.Legajo;
        }

    }
}