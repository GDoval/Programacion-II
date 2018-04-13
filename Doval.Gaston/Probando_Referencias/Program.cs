using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probando_Referencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Marca cochera = new Marca(5);
            Auto coche = new Auto("Toyota", "Rojo", 1234);
            cochera.setAuto(coche);
            List<Auto> sad = cochera.getAutos();
            Auto asd = sad[0];
            Console.WriteLine("{0}    {1}    {2}", asd.getMarca(), asd.getColor(), asd.getPatente());
            Console.ReadLine();
            asd.setMarca("Peugeot");
            sad = cochera.getAutos();
            asd = sad[0];
            Console.WriteLine("{0}    {1}    {2}", asd.getMarca(), asd.getColor(), asd.getPatente());
            Console.ReadLine();
        }
    }
}
