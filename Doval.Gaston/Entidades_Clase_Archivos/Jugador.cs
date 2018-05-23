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

        public static bool TraerUno(string path, Jugador buscado, out Jugador retorno )
        {
            bool resp = true;
            string todo;
            string[] nombres, cadobj;
            retorno = null;
            bool flag = AdministradorDeArchivos.Leer(path, out todo);
            if (flag)
            {
                nombres= todo.Split('\n');
                foreach (string i in nombres)
                {
                    cadobj = i.Split('-');
                    if (buscado.Nombre == cadobj[0] && buscado.Apellido == cadobj[1] && buscado.Puesto.ToString() == cadobj[2])
                    {
                        retorno = new Jugador(cadobj[0], cadobj[1], (EPuesto)Enum.Parse(typeof(EPuesto),cadobj[2]));
                        resp = true;
                        break;
                    }
                    else
                        resp = false;
                }
            }
            else
            {
                retorno = null;
                resp = false;
            }
            return resp;
        }
    }
}
