using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{

    class Empresa
    {
        //Variables Miembro
        private ArrayList Profesionales = new ArrayList();
        private ArrayList Obras = new ArrayList();
        private ArrayList Empleados = new ArrayList();
        private const ulong MONTO2 = 400;
        private const ulong MONTO1 = 100;


        //Metodos Miembro
        private bool Buscar_Matricula_Profe(ulong MAT)
        {
            foreach (var item in Profesionales)
            {
                Profesional Profe = (Profesional)item;
                if (Profe.GetMatricula() == MAT)
                    return true;
            }
            return false;

        }

        private bool Buscar_Matricula_Obra(ulong MAT)
        {
            foreach (var item in Obras)
            {
                Obra ob = (Obra)item;
                if (ob.GetMatricula_Profe() == MAT)
                    return true;
            }
            return false;
        }

        private bool Buscar_Legajo(ulong Leg)
        {
            foreach (var item in Empleados)
            {
                if (item is Profesional Profe)
                {
                    if (Profe.GetLeg() == Leg)
                        return true;
                }
                if (item is Obrero Obre)
                {
                    if (Obre.GetLeg() == Leg)
                        return true;
                }
            }

            return false;
        }

        private bool Buscar_Obra(uint COD)
        {
            foreach (var item in Obras)
            {
                Obra ob = (Obra)item;
                if (ob.GetCodigo() == COD)
                {
                    return true;
                }
            }
            return false;
        }



        private void Cambiar_Sueldo_Mas(ulong MAT)
        {
            foreach (var item in Profesionales)
            {
                Profesional Profe = (Profesional)item;
                if (Profe.GetMatricula() == MAT)
                {
                    Profe.SetSueldo(Profe.GetSueldo() + MONTO2);
                }
            }

            foreach (var item in Empleados)
            {
                if (item is Profesional Profe)
                {
                    if (Profe.GetMatricula() == MAT)
                        Profe.SetSueldo(Profe.GetSueldo() + MONTO2);
                }
            }

        }

        private void Cambiar_Sueldo_Menos(ulong MAT)
        {
            foreach (var item in Profesionales)
            {
                Profesional Profe = (Profesional)item;
                if (Profe.GetMatricula() == MAT)
                {
                    Profe.SetSueldo(Profe.GetSueldo() - MONTO2);
                }
            }

            foreach (var item in Empleados)
            {
                if (item is Profesional Profe)
                {
                    Profe.SetSueldo(Profe.GetSueldo() - MONTO2);
                    return;
                }
            }
        }




        public bool Recibir_Obra(uint codigo, string direccion, ulong matricula_Profesional)
        {

            if (Buscar_Obra(codigo) == true)
            {
                Console.WriteLine("Se a detectado un codigo de obra repetido");
                return false;
            }

            if (Buscar_Matricula_Profe(matricula_Profesional) == true)
            {
                if (Buscar_Matricula_Obra(matricula_Profesional) == false)
                    Cambiar_Sueldo_Mas(matricula_Profesional);
            }
            else
            {
                Console.WriteLine("Matricula del Profesional no encontrada");
                return false;
            }


            Obra Dato_Obra = new Obra(codigo, direccion, matricula_Profesional);
            Obras.Add(Dato_Obra);

            return true;
        }


        public bool Recibir_Empleado(string Nom, string Ape, ulong Leg)
        {

            string TH;
            ulong MAT;
            string Consejo;
            float Porcentaje;


            if (Buscar_Legajo(Leg) == true)
            {
                Console.WriteLine("Legajo de Empleado Repetido");
                return false;
            }

            Console.WriteLine("Profesional(1) / Obrero(2)");

            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Titulo: ");
                TH = Console.ReadLine();

                Console.WriteLine("Consejo que emite el titulo: ");
                Consejo = Console.ReadLine();

                Console.WriteLine("Matricula: ");
                MAT = ulong.Parse(Console.ReadLine());

                Console.WriteLine("Porcentaje extra a pagar discutido: ");
                Porcentaje = float.Parse(Console.ReadLine()) / 100;

                if (Recibir_Profesional(TH, MAT, Consejo, Porcentaje, Nom, Ape, Leg) == false)
                    return false;
            }



            return true;
        }

        private bool Recibir_Profesional(string TH, ulong MAT, string Consejo, float P, string Nom, string Ape, ulong Leg)
        {

            float Sueldo = MONTO1 + MONTO1 * P;


            if (Buscar_Matricula_Profe(MAT) == true)
            {
                Console.WriteLine("Matricula de Profesional Repetida");
                return false;
            }


            Profesional Dato_Profe = new Profesional(TH, MAT, Consejo, Sueldo, Nom, Ape, Leg);
            Empleados.Add(Dato_Profe);
            Profesionales.Add(Dato_Profe);
            return true;
        }

        private bool Recibir_Obrero(string oficio, string categoria, string Nom, string Ape, ulong Leg)
        {

            float Sueldo = MONTO1;

            if (categoria == "medio-oficial")
                Sueldo = (float)(MONTO1 * 0.65);
            else if (categoria == "aprendiz")
                Sueldo = (float)(MONTO1 * 0.25);


            if (Buscar_Legajo(Leg) == true)
            {
                Console.WriteLine("Legajo de Empleado Repetido");
                return false;
            }

            Obrero Obre = new Obrero(oficio, categoria, Sueldo, Nom, Ape, Leg);

            Empleados.Add(Obre);

            Console.WriteLine("Codigo de Obra no Encontrado");
            return false;

        }

    }
}