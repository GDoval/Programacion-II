using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program //Contador de numeros primos
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int num;
            int flag = 0;
            Console.WriteLine("Ingresate un numero ingresate: ");
            num = int.Parse( Console.ReadLine());
            for (int i = num; i > 1; i--)
            {
                flag = 0;
                for (int j = 2; j  < i; j++ )
                {
                    if (i % j == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("{0}", i);
                }
                    
            }
            Console.ReadLine();

        }
    }
}
