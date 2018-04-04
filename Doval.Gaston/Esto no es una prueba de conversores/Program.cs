using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esto_no_es_una_prueba_de_conversores
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosas jota = new Cosas(10, 10.05);
            int pepe = jota;
            double romina = jota;
            Console.WriteLine("{0}  {1}", pepe, romina);
            Console.ReadLine();
        }
    }
}
