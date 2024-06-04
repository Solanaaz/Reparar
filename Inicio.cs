using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reparar
{
    class Inicio
    {
        public static void Main()
        {
            ArrayList ListaPro = new ArrayList();

            Profesionales Profesional = new Profesionales("Arquitecto", 212312, "Colegio Estatal Ignacio San Justo", 500000, "Jorge", "Mata", 545577);



            ListaPro.Add(Profesional);
           
            MostrarDatos(ListaPro);
        }

        public static void MostrarDatos(ArrayList profesionales)
        {
            foreach(var item in profesionales)
            {
                Profesionales profe = (Profesionales)item;

                Console.WriteLine("Titulo: " + profe.TituloHab);
                Console.WriteLine("Matricula: " + profe.matricula);
                Console.WriteLine("Consejo Profesional: " + profe.consejo);
                Console.WriteLine("Sueldo: " + profe.sueldo);
                Console.WriteLine("Nombre: " + profe.nombre);
                Console.WriteLine("Apellido: " + profe.apellido);
                Console.WriteLine("Lgeajo: " + profe.legajo);
            }
        }
    }
}
