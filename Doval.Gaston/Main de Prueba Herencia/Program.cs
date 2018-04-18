using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_Herencia;

namespace Main_de_Prueba_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lav = new Lavadero(10, 8, 15);
            Auto unAuto = new Auto(4, "888888", 4, EMarcas.Honda);
            Auto otroAuto = new Auto(2, "2222222", 3, EMarcas.Fiat);
            Camion unCamion = new Camion(587, "555555", 12, EMarcas.Scania);
            Camion otroCamion = new Camion(999, "333333", 1, EMarcas.Fiat);
            Moto unaMoto = new Moto(777, "11111111", 2, EMarcas.Zanella);
            lav = unAuto + lav;
            lav = otroAuto + lav;
            lav = unCamion + lav;
            lav = otroCamion + lav;
            lav = unaMoto + lav;
            Console.WriteLine("**********Sin Ordenar************");
            foreach (Vehiculo ve in lav.Vehiculos)
            {
                Console.WriteLine(ve);
            }

            Console.ReadLine();
            lav.Vehiculos.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine("\n\n**********Ordenado por patente************");
            foreach (Vehiculo ve in lav.Vehiculos)
            {
                Console.WriteLine(ve);
            }

            Console.ReadLine();

        }
    }
}
