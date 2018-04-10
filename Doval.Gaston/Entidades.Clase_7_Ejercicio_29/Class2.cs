using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_7_Ejercicio_29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
            this.cantidadDeJugadores = 5;
        }

        public Equipo(short cantidad, string nombre) : this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }


        public static bool operator +(Equipo e, Jugador j)
        {
            bool resp = false, validar;
            int flag = 0;
            foreach (Jugador jug in e.jugadores)
            {
                validar = jug == j;
                if (validar)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                if (e.jugadores.Count < e.cantidadDeJugadores)
                {
                    e.jugadores.Add(j);
                    resp = true;
                }
            }
            return resp;
        }

        public List<Jugador> GetJugadores()
        {
            return this.jugadores;
        }


    }
}
