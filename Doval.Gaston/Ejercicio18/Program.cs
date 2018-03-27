using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 18";
            Punto vertice1 = new Punto(-2, -5);
            Punto vertice3 = new Punto(-8, -10);
            Rectangulo rec = new Rectangulo(vertice1, vertice3);
            float arrrea = rec.GetArea();
            Console.Write("{0}", arrrea);
            Console.ReadLine();
        }
    }
}
