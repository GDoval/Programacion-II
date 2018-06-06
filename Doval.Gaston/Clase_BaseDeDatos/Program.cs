using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Persona per in Persona.TraerTodos())
            {
                Console.WriteLine(per.ToString());
            }
            Console.ReadLine();
        }
    }
}
