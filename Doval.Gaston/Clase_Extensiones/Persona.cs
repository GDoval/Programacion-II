using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Externa;
using Entidades.Alumnos;
using Entidades.Externa.Sellada;

namespace Entidades.Alumnos
{
    public class Persona : PersonaExterna
    {
        /*protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;*/

        public string _Nombre { get { return base._nombre; } set { base._nombre = value ;} }
        public string _Apellido { get { return base._apellido; } set { base._apellido = value;} }
        public int _Edad { get { return base._edad; } set { base._edad = value; } }
        //public ESexo _Sexo { get { return base._sexo; } set { base._sexo = value;} }

        public override string ToString()
        {
            string resp = "";
            resp += "Nombre: " + this._nombre + "        Apellido: " + this._apellido + " \nEdad: " + this._edad + " \nSexo: " + this._sexo.ToString();
            return resp;
        }

        public Persona(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo)
            :base(nombre, apellido, edad, sexo)
        {
            /*this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = (ESexo)sexo;*/
        }


    }
}
