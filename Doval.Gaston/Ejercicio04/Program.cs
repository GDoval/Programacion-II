using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program// Te saca los 4 primeros numeros perfectos te saca
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";
            int suma = 0;
            int asd = 0;
            for (int i = 10000; i > 1; i--)
            {
                suma = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0  &&  i != j)
                    {
                        suma = suma + j;
                    }
                }
                if (suma == i)
                    Console.WriteLine("{0}", i);
            }
            Console.ReadLine();
        }
    }
}
