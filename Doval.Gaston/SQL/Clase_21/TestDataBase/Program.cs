using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace TestDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona("Adadasdasdasdas", "Doval", 22, 1);
            Persona dos = new Persona("Juan", "Perezzzzz", 222, 10);
            //dos.Agregar();
            /*bool resp = per.Modificar();
            foreach (Persona i in Persona.TraerTodos())
            {
                Console.WriteLine(i.Nombre);
            }
            Console.Read();
            Persona.Borrar(dos);
            Console.Read();*/
            /*dos = Persona.TraerTodos(1);
            Console.WriteLine(dos.Nombre);*/
            DataTable tabla = Persona.TraerTodosTabla();
            foreach (DataRow dr in tabla.Rows) // Usar la propiedad para recorrer la tabla
            {
                Console.WriteLine(dr[2].ToString());
            }
            Console.ReadLine();
        }
    }
}
