using System;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";
            int year;
            Console.Write("Ingresame un año: ");
            year = int.Parse(Console.ReadLine());
            if ((year % 4) == 0 || (year % 100 == 0 && year % 400 == 0))
            {
                Console.WriteLine("Año bisiesto");
            }
            else
            {
                Console.WriteLine("Nope");
            }
            Console.ReadLine();
        }
    }
}
