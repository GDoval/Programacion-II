using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_Interfaz_Libreria;

namespace Practica_Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Deportivo avioncito = new Deportivo(456, "ABC123", 15);
            avioncito.MostrarPrecio();
            Console.ReadLine();
        }
    }
}
