using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero mayor a cero: ");
            double numero = double.Parse(Console.ReadLine());
            while (numero <= 0)
            {
                Console.WriteLine("Error!! Numero mayor a cero ingrese: ");
                numero = double.Parse(Console.ReadLine());
            }
            double cuadrado = Math.Pow(numero, 2);
            double cubo = Math.Pow(numero, 3);
            Console.WriteLine("Cuadrado: {0} -- Cubo: {1}", cuadrado, cubo);
            Console.ReadLine();
        }
    }
}
