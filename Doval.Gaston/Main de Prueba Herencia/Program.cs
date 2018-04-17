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
            Lavadero lavadero = new Lavadero(10, 8, 15);
            Auto unAuto = new Auto(4, "ABC123", 4, EMarcas.Ford);
            Vehiculo auto = unAuto;

        }
    }
}
