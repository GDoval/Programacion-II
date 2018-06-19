using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Data;
using Entidades.Externa;
using Entidades.Alumnos;
using Entidades.Externa.Sellada;
using Clase_Extensiones;
namespace Entidades.Alumnos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Ivan", "Ivanovich", 55, Entidades.Externa.ESexo.Masculino);
            PersonaExternaSellada pe = new PersonaExternaSellada("Alexa", "Ivanovich", 12313, Externa.Sellada.ESexo.Femenino);
            PersonaExternaSellada pea = new PersonaExternaSellada("Sergei", "Rohznov", 9999, Externa.Sellada.ESexo.Masculino);
            pea.GuardoEnDB();
            List<PersonaExternaSellada> lista = new List<PersonaExternaSellada>();
            lista = pe.LeoDB();
            foreach (PersonaExternaSellada a in lista)
                Console.WriteLine(a.ObtenerInfoSellada());
            Console.Read();
        }
    }


}
