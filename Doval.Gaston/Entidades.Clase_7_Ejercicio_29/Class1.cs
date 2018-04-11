﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_7_Ejercicio_29
{
    public class Jugador
    {
        private long dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        public float GetPromedioGoles()
        {
            float promedio;
            promedio = this.totalGoles / this.partidosJugados;
            return promedio;
        }

        private Jugador() 
        {
            this.nombre = "Sin nombre";
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
            this.dni = 0;
        }

        public Jugador(string nombre, long dni) : this ()
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public Jugador(string nombre, long dni, int totalGoles, int totalPartidos) : this(nombre,dni)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.promedioGoles = GetPromedioGoles();
        }

        public string MostrarDatos()
        {
            string retorno = "";
            retorno += "Nombre: " + this.nombre  + " DNI: " + this.dni  + " Partidos Jugados: " + this.partidosJugados + " Goles totales: " + this.totalGoles +  " Promedio de goles: " + this.promedioGoles;
            return retorno;
        }

        public static bool operator ==(Jugador jug1, Jugador jug2)
        {
            bool resp = false;
            if (jug1.dni == jug2.dni)
                resp = true;
            return resp;
        }

        public static bool operator !=(Jugador jug1, Jugador jug2)
        {
            return !(jug1 == jug2);
        }


    }



}
