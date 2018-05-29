﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Clase_20_Archivos_XML
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public override string ToString()
        {
            string resp = this.nombre + " " + this.apellido + " Dni: " + this.dni;
            return resp;
        }

    }
}
