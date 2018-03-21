using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadSello // Un nuevo NameSpace para guardar clases (una libreria, vamos). Haciendo esto se pueden generar clases
                       // con el mismo nombre y llamarlas anteponiendo el nombre del NameSpace especifico donde esta cada clase 
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
