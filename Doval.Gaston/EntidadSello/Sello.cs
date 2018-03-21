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
        public static string sal;
        public static void Imprimir()
        {
            bool ok = TryParse(mensaje, out sal);
            if (ok)
            {
                color = ConsoleColor.DarkCyan;
                Console.ForegroundColor = Sello.color;
                Console.WriteLine("{0}", Sello.sal);
                EntidadSello.Sello.color = ConsoleColor.DarkGray;
                Console.ForegroundColor = EntidadSello.Sello.color;
            }
            else
            {
                Console.WriteLine("\n\n ERRORRR!!");
            }
        }
        public static void Borrar()
        {
            Console.Clear();
        }
        public static ConsoleColor color; //ConsoleColor es un enumerado, una constante con n valores
        private static string ArmarFormatoMensaje()
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
        
        public static bool TryParse(string palabra, out string salida)
        {
            bool resp;
            int cant = palabra.Length;
            if (cant != 0)
            {
                salida = EntidadSello.Sello.ArmarFormatoMensaje();
                return true;
            }else
            {
                salida = "";
                return false;
            }
        }
    }
}
