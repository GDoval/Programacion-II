using System;

namespace Ejercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 09";
            int num;
            string cositos = "*";
            Console.Write("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}", cositos);
                cositos += "**";
            }
            Console.ReadLine();
        }
    }
}
