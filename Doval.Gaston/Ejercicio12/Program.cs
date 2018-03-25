using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 12";
            bool resp = true;
            int num, sum = 0;
            char s;
            do
            {
                Console.Write("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());
                sum += num;
                Console.Write("\nQuiere seguir ingresando numeros? S/N: ");
                s = char.Parse(Console.ReadLine());
                resp = ValidarRespuesta.ValidaS_N(s);
            } while (resp);
            Console.Write("La suma total de todo es: {0}", sum);
            Console.ReadLine();
        }
    }
}
