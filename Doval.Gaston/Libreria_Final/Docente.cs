using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Final
{
    public class Docente : Persona
    {
        #region Enumerados
        public enum ENomenclador
        {
            Historia, Fisica, Programacion, Geografia, Sistemas_II, Sistemas, Programacion_II
        }

        public enum ECategoria
        {
            Asalariado, AdHonorem
        }
        #endregion

        #region Atributos
        private int _legajo;
        private double sueldo;
        private double _horasTrabajadas;
        private double _descuentoPorFaltas;
        private ECategoria categoria;
        private ENomenclador nomenclador;
        #endregion


        public Docente(string nombre, string apellido, int edad, int dni, int legajo, ECategoria cate, ENomenclador nomen)
             :base(nombre, apellido, edad, dni)
        {
            this._legajo = legajo;
            this.categoria = cate;
            this.nomenclador = nomen;
        }

        public event SueldoErroneo Evento_NoSueldo;

        #region Sobrecarga de Operadores

        public static List<Docente> operator +(Facultad f, Docente d)
        {
            foreach (Docente de in f.Docentes)
                if (d == de)
                    resp = false;
            return resp;
        }

        public static bool operator ==(Docente d, Docente b)
        {
            if (d._dni == b._dni)
                return true;
            else
                return false;
        }

        public static bool operator !=(Docente d, Docente b)
        {
            return !(d == b);
        }

        #endregion

    }
}
