using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 14";
            double uno, dos;
            int opcion;
            Console.Write("Te calculo el area de algo te calculo\n");
            Console.WriteLine("**********************************");
            Console.Write("Elegi:\n1) Cuadrado\n2)Triangulo\n3)Circulo\n ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Ingresa el lado: ");
                    uno = double.Parse(Console.ReadLine());
                    Console.Write("\nEl area es: {0}", CalculoDeArea.CalcularCuadrado(uno));
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Ingresa la base: ");
                    uno = double.Parse(Console.ReadLine());
                    Console.Write("\nIngresa la altura: ");
                    dos = double.Parse(Console.ReadLine());
                    Console.Write("\nEl area es: {0}", CalculoDeArea.CalcularTriangulo(uno, dos));
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Ingresa el radio: ");
                    uno = double.Parse(Console.ReadLine());
                    Console.Write("\nEl area es: {0}", CalculoDeArea.CalcularCirculo(uno));
                    break;
            }
            Console.ReadLine();

        }
    }
}
