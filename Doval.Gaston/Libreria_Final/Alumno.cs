using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Final
{
    public class Alumno : Persona
    {
        public enum EEstado
        {
            Deudor, AlDia
        }
        
        private int _legajo;
        private EEstado _estado;

        public Alumno(string nombre, string apellido, int edad, int dni, int legajo, EEstado estado)
            :base(nombre, apellido, edad, dni)
        {
            this._legajo = legajo;
            this._estado = estado;
        }
        public event EdadErronea Evento_Edad;

        #region Sobrecargas

        public static bool operator ==(Alumno f, Alumno a)
        {
            if (f._dni == a._dni)
                return true;
            return false;
        }

        public static bool operator !=(Alumno f, Alumno a)
        { return !(f == a); }

        public static List<Alumno> operator +(Facultad f, Alumno a)
        {
            if
        }
    }
}
