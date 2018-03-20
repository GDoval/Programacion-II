using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio #1";
            int max = 0;
            int min = 0;
            float promedio = 0;
            int flag = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\nIngrese un numero ingrese: ");
                int numero = int.Parse(Console.ReadLine());
                if (numero > max || flag == 0)
                {
                    max = numero;
                }
                if (numero < min || flag == 0)
                {
                    min = numero;
                    flag = 1;
                }
                promedio = promedio + numero;
            }
            promedio = promedio / 4;
            Console.WriteLine("\nEl mayor numero ingresado fue: {0}", max);
            Console.WriteLine("El menor numero ingresado fue {0}", min);
            Console.WriteLine("El promedio de todos los numeros fue: {0}", promedio);
            Console.ReadLine();

        }
    }
}
