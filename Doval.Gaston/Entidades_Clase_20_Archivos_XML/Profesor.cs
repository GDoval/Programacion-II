using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase_20_Archivos_XML
{
    public class Profesor : Persona
    {
        public string titulo;


        public Profesor()
            : base("", "", 0)
        { }
        public Profesor(string titulo, string nombre, string apellido, int dni)
            : base(nombre, apellido, dni)
        { this.titulo = titulo; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Titulo: ");
            sb.AppendLine(this.titulo);
            sb.AppendLine(base.ToString());
            return sb.ToString();
        }
    }
}
