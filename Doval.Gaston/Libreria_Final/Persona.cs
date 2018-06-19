using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Final
{
    public abstract class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected int _dni;

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this._apellido = apellido;
            this._dni = dni;
            this._edad = edad;
            this._nombre = nombre;
        }

        public delegate void EdadErronea(Alumno a);

        public delegate void SueldoErroneo(Docente d);
    }
}
