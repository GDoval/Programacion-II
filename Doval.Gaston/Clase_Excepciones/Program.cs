using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria_Clase_Excepciones;

namespace Clase_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero num1 = new Numero(1);
            string var = "54";
            bool resp  = Numero.Parse(var, out num1);
            if (resp)
                Console.WriteLine(Convert.ToString(num1._Numero));
            else
                Console.WriteLine("No se pudo parsear");
            ColectoraDeNumeros colec = new ColectoraDeNumeros(ETipoNumero.Par);
            try
            {
                colec = colec + num1;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();

        }
    }
}
