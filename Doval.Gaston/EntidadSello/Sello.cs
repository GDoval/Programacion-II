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
            color = ConsoleColor.DarkCyan;
            Console.ForegroundColor = Sello.color;
            mensaje = EntidadSello.Sello.ArmarFormatoMensaje();
            Console.WriteLine("{0}", Sello.mensaje);
            EntidadSello.Sello.color = ConsoleColor.DarkGray;
            Console.ForegroundColor = EntidadSello.Sello.color;
        }
        public static void Borrar()
        {
            Console.Clear();
        }
        public static ConsoleColor color; //ConsoleColor es un enumerado, una constante con n valores
        public static string ArmarFormatoMensaje()
        {
            string respuesta = "";
            int cant = mensaje.Length;
            for (int i = 0; i < cant + 2; i++)
            {
                respuesta += "*";
            }
            respuesta += "\n";
            respuesta += "*";
            respuesta += mensaje;
            respuesta += "*\n";
            for (int i = 0; i < cant + 2; i++)
            {
                respuesta += "*";
            }
            return respuesta;
        }
    }
}
