using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 10";
            int num, max = 0, min = 0;
            float prom = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un numero entre -100 y 100: ");
                num = int.Parse(Console.ReadLine());
                bool asd = Validar.Validacion(num, 100, -100);
                while (!asd)
                {
                    Console.Write("Error! Dije entre -100 y 100: ");
                    num = int.Parse(Console.ReadLine());
                    asd = Validar.Validacion(num, 100, -100);
                }
                if (i == 0)
                {
                    min = num;
                    max = num;
                }
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
                prom = prom + num;
            }
            Console.Clear();
            prom = prom / 10;
            Console.Write("El mayor numero ingresado fue: {0}  el menor fue: {1} y el promedio de todo fue: {2}", max, min, prom);
            Console.ReadLine();
        }
    }
}
