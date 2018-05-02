using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TP_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Changuito changoDeCompras = new Changuito(5);
            Dulce c1 = new Dulce(Producto.EMarca.Sancor, "ASD012", ConsoleColor.Black);

         
   changoDeCompras += c1;
            Console.WriteLine(changoDeCompras.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadLine();
        }
    }
}
