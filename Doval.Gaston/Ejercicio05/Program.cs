using System;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";
            int num;
            int acum = 0;
            int acum2 = 0;
            int cont = 0;
            int ancla = 2;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            while (cont < num)
            {
                for (int i = 1; i < ancla; i ++ )
                {

                    acum = acum + i;
                }
                for (int j = ancla; j <= num; j++)
                {
                    if (j != ancla)
                        acum2 = acum2 + j;
                }
                if (acum == acum2)
                    Console.WriteLine("Tu centro es: {0}", ancla);
                acum = 0;
                acum2 = 0;
                ancla++;
                cont++;
            }
            Console.ReadLine();
        }
    }
}
