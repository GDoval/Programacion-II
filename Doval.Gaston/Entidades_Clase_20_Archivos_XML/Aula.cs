using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase_20_Archivos_XML
{
    public class Aula
    {
        private int _numero;
        private List<Persona> _lista;

        public Aula()
        { this._lista = new List<Persona>(); }
        public Aula(int num)
            :this()
        { this._numero = num;}

        public int Numero { get { return this._numero; } set { this._numero = value; } }
        public List<Persona> Lista { get { return this._lista; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Persona p in this.Lista)
            {
                if (p is Alumno)
                    sb.AppendLine(((Alumno)p).ToString());
                else
                    sb.AppendLine(((Profesor)p).ToString());
            }
            return sb.ToString();
        }
    }
}
