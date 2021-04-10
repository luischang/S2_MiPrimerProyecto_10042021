using S2_MiPrimerProyecto.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_MiPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = "Desarrollo de Aplicaciones Web 2021-1";
            int edad = 20;
            double monto = 350.50;
            string salario = "Mil dolares";

            var nuevaEdad = "Veinte";

            string detalleEdad = String.Empty;

            List<Persona> listado = new List<Persona>();
            Persona per1 = new Persona();
            per1.dni = "12345678";
            per1.nombreCompleto = "Jefferson Farfan";
            per1.telefono = 99858877;

            Persona per2 = new Persona("77884455", "Paolo Guerrero", 99887747);

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(new Persona("88554455", "Raul Ruidiaz", 77885487));

            detalleEdad = edad > 17 ? "Es mayor de edad" : "Es menor de edad";
            //if (edad > 17)
            //{
            //    detalleEdad = "Es mayor de edad";
            //}
            //else
            //{
            //    detalleEdad = "Es menor de edad";
            //}

            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " + item.nombreCompleto + " " + item.telefono);
            }

            var busqueda = listado.Where(x => x.dni == "77884455").FirstOrDefault();

            Console.WriteLine("La búsqueda encontró a: " + busqueda.nombreCompleto);

            
        }
    }
}
