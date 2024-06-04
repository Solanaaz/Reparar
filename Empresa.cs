using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Empresa
    {
        private ArrayList Profesional = new ArrayList();
        private ArrayList Obras = new ArrayList();

        public bool Recibir_Profesional(string TH, ulong Mat, string Consejo, ulong S, string inNom, string inApe, uint inLeg)
        {
            foreach(var item in Profesional)
            {
                Profesionales Profe = (Profesionales)item;
                if (Mat == Profe.matricula && inLeg == Profe.legajo)
                    return false; 
            }
            Profesionales Dato_Profe = new Profesionales(TH, Mat, Consejo, S, inNom, inApe, inLeg);
            Profesional.Add(Dato_Profe);
            return true;
        }
    }
}
