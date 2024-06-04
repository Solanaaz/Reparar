using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Obra
    {
        private uint Codigo;
        private string Direccion;
        private string Matricula_Profesional;
        private ArrayList Obreros = new ArrayList();

        public Obra(uint cod, string dire, string mat_pro) 
        {
            Codigo = cod;
            Direccion = dire;
            Matricula_Profesional = mat_pro;
        }

        public uint codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public string direccion
        {
            get { return Direccion; }
            set { Direccion = value; }
        }
        public string matricula
        {
            get { return Matricula_Profesional; }
            set { Matricula_Profesional = value;  }
        }
    }
}
