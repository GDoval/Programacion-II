using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 13";
            int num = 65;
            string a = "1101";
            string asd = Conversor.DecimalBinario(num);
            Console.Write("{0}", asd);
            Console.ReadLine();
            num = Conversor.BinarioDecimal(a);
            Console.Write("{0}", num);
            Console.ReadLine();
        }
    }
}
