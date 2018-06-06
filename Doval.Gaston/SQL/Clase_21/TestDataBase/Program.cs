using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace TestDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona("Gaston", "Doval", 22);
            Persona dos = new Persona("Juan", "Perezzzzz", 222, 10);
            //dos.Agregar();
            foreach (Persona i in Persona.TraerTodos())
            {
                Console.WriteLine(i.Nombre);
            }
            Console.Read();
            Persona.Borrar(dos);
            Console.Read();

        }
    }
}
