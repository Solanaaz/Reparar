using System;
using System.Collections;

namespace Reparar
{
    class Profesionales : Empleado
    {
        //Atributos privados
        private string TituloHabilitante;
        private ulong Matricula;
        private string ConsejoPro;
        private ulong Sueldo;

        public Profesionales(string TH, ulong Mat, string Consejo, ulong S, string inNom, string inApe, uint inLeg) :
            base( inNom, inApe, inLeg)
        {
            TituloHabilitante = TH;
            Matricula = Mat;
            ConsejoPro = Consejo;
            Sueldo = S;
        }

        public string TituloHab
        {
            get { return TituloHabilitante; }
            set { TituloHabilitante = value; }
        }
        public ulong matricula
        {
            get { return Matricula; }
            set { Matricula = value; }
        }
        public string consejo
        {
            get { return ConsejoPro; }
            set { ConsejoPro = value; }
        }
        public ulong sueldo
        {
            get { return Sueldo; }
            set { Sueldo = value; }
        }
    }
}