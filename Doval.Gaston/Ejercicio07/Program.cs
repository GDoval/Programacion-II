using System;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";
            DateTime fecha_hoy = DateTime.Now;
            DateTime fecha_cumple;
            Console.WriteLine("Ingresame tu fecha de nacimiento ingresame: aa/mm/dd");
            fecha_cumple = DateTime.Parse(Console.ReadLine());
            long ticks = fecha_hoy.Ticks - fecha_cumple.Ticks;
            TimeSpan resultado = new TimeSpan(ticks);
            Console.WriteLine("Desde que naciste pasaron {0} dias. Bien por vos.", resultado.Days);
            Console.ReadLine();
        }
    }
}
