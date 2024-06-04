using System;
using System.Collections;

namespace Reparar
{
    class Profesional : Empleado
    {
        //Variables Miembro
        private string Titulo_Habilitante;
        private ulong Matricula;
        private string Consejo_Profesional;
        private float Sueldo;



        //Metodos Miembro
        public Profesional(string TH, ulong MAT, string Consejo, float S, string inNom, string inApe, ulong inLeg) :
            base(inNom, inApe, inLeg)
        {
            Titulo_Habilitante = TH;
            Matricula = MAT;
            Consejo_Profesional = Consejo;
            Sueldo = S;
        }

        public void SetTitulo_H(string TH)
        {
            this.Titulo_Habilitante = TH;
        }

        public void SetMatri(ulong MAT)
        {
            this.Matricula = MAT;
        }

        public void SetCons(string Consejo)
        {
            this.Consejo_Profesional = Consejo;
        }

        public void SetSueldo(float S)
        {
            this.Sueldo = S;
        }

        public string GetTitulo_H()
        {
            return this.Titulo_Habilitante;
        }

        public ulong GetMatricula()
        {
            return this.Matricula;
        }

        public string GetConsejo()
        {
            return this.Consejo_Profesional;
        }

        public float GetSueldo()
        {
            return this.Sueldo;
        }
    }
}