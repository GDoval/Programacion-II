using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_7_Ejercicio_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(1, "Lanus");
            Jugador jug1 = new Jugador("Juan", 12345, 10, 5);
            bool validar = equipo + jug1;
            List <Jugador> lista = equipo.GetJugadores();
            if (validar)
            {
                foreach (Jugador jug in lista)
                {
                    Console.WriteLine(jug.MostrarDatos());
                }
            }
            Console.ReadLine();
        }
    }
}
