using System;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 08";
            int plusvalor;
            string nombre;
            int ant;
            int horas;
            Console.Write("Ingrese el valor por hora: ");
            plusvalor = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el nombre del cristiano: ");
            nombre = Console.ReadLine();
            Console.Write("\nIngrese la antiguedad del susodicho cristiano: ");
            ant = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese la cantidad de horas trabajadas: ");
            horas = int.Parse(Console.ReadLine());
            double total = ((plusvalor * horas) + (ant * 150));
            double desc = total * 0.13;
            total = total - desc;
            Console.Write("\nEl total a abonar es de ${0}", total);
            Console.ReadLine();

        }
    }
}
