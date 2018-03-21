using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1_Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {
            EntidadSello.Sello.mensaje = "asd";
            EntidadSello.Sello.Imprimir();
            Console.ReadLine();
            EntidadSello.Sello.Borrar();
            Console.WriteLine("\nPulse una tecla para salir");
            Console.ReadLine();
        }
    }
}
