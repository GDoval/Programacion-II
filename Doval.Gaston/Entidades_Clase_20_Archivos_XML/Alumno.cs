using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase_20_Archivos_XML
{
    public class Alumno : Persona
    {
        public int legajo;
        public Alumno()
            :base("","",0)
        { }
        public Alumno(int legajo, string nombre, string apellido, int dni)
            : base(nombre, apellido, dni)
        { this.legajo = legajo; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Legajo: ");
            sb.AppendLine(Convert.ToString(this.legajo));
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
