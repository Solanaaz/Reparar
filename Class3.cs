using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Obra
    {
        //Variables Miembro
        private uint Codigo;
        private string Direccion;
        private ulong Matricula_Profesional;
        public ArrayList Obreros = new ArrayList();


        //Metodos Miembro
        public Obra(uint codigo, string direccion, ulong matricula_Profesional)
        {
            Codigo = codigo;
            Direccion = direccion;
            Matricula_Profesional = matricula_Profesional;
        }

        public void SetCodigo(uint codigo)
        {
            this.Codigo = codigo;
        }

        public void SetDireccion(string direccion)
        {
            this.Direccion = direccion;
        }

        public void SetMatricula_Profe(ulong matricula)
        {
            this.Matricula_Profesional = matricula;
        }

        public uint GetCodigo()
        {
            return this.Codigo;
        }

        public string GetDireccion()
        {
            return this.Direccion;
        }
        public ulong GetMatricula_Profe()
        {
            return this.Matricula_Profesional;
        }
    }
}