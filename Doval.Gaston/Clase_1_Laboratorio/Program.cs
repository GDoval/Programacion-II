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
            Sello.mensaje = "Esto no es un mensaje";
            Sello.Imprimir();
            //Sello.Borrar();
            Console.ReadLine();
        }
    }
}
