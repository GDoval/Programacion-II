using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa instancia = new Cosa();
            Console.Write("Constructor por defecto: \n{0}\n\n", instancia.Mostrar());

            DateTime fecha = new DateTime(1988, 03, 14);
            Cosa otra = new Cosa(190, "Esto no es un string", fecha);
            Console.Write("Constructor con valores pasados por el usuario: \n{0}\n\n", otra.Mostrar());

            instancia.EstablecerValor(5);
            instancia.EstablecerValor("Hola");
            instancia.EstablecerValor(DateTime.Now);

            Console.Write("\nDespues de inicializar: \n{0}", instancia.Mostrar());

            Console.ReadLine();
        }
    }
}