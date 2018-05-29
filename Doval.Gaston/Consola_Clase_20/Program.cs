using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Clase_20_Archivos_XML;

namespace Consola_Clase_20
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Juan", "Goldberg", 12345);
            Profesor p = new Profesor("Geometristador", "Pedro", "Rohzkov", 898989);
            Aula aula = new Aula(4);
            aula.Lista.Add(a);
            aula.Lista.Add(p);
            Console.WriteLine(aula);
            Console.ReadLine();
        }
    }
}
