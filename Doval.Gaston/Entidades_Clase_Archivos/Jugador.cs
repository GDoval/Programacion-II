using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase_Archivos
{
    public enum EPuesto
    {
        Arquero, Defensa, Medio, Delantero
    }
    public class Jugador
    {
        protected string _nombre;
        protected string _apellido;
        protected EPuesto _puesto;


        public string Nombre { get {return this._nombre;} }
        public string Apellido { get { return this._apellido; } }
        public EPuesto Puesto { get { return this._puesto; } }

        public Jugador(string nombre, string apellido, EPuesto puesto)
        {
            this._puesto = puesto;
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public override string ToString()
        {
            string resp = this.Nombre + "-" + this.Apellido + "-" + this.Puesto;
            return resp;
        }
    }
}
