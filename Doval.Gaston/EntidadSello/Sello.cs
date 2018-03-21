using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadSello
{
    public class Sello
    {
        public static string mensaje;
        public static void Imprimir()
        {
            Console.WriteLine("{0}", Sello.mensaje);
        }
        public static void Borrar()
        {
            Console.Clear();
        }
    }
}
