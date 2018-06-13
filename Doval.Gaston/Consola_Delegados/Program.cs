using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Delegados;
namespace Consola_Delegados
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp = new Empleado("Illich", "Rozhkov", 123456);
            emp.SueldoCero += new DelegadoSueldoCero(emp.ManejadorEvento); //Agrego el manejador al evento. Notese el +=; que se pasa un metodo de instancia (por eso necesitamos el objeto emp)
            emp.SueldoMaximo += new DelegadoLimiteSueldo(emp.SueldoAlto);
            emp.SueldoMaximoMejorado += new DelegadoLimiteSueldoMejorado(emp.SueldoAltoMejorado);
            try
            {
                emp.Sueldo = 25000;
            }
            catch (ExcepcionSueldoNegativo e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();
        }
    }
}
