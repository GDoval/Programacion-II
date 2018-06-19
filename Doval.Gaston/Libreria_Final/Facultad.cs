using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_Final
{
    public class Facultad
    {

        #region Atributos
        private List<Alumno> _alumnos;
        private List<Docente> _docentes;
        private double _gastos;
        private double _ganancia;
        private int _aula;
        #endregion

        #region Propiedades
        public List<Alumno> Alumnos { get { return this._alumnos; } set { this._alumnos = value;} }
        public List<Docente> Docentes { get { return this._docentes; } set { this._docentes =value ;} }
        #endregion


        public Facultad()
        {
            this._alumnos = new List<Alumno>();
            this._docentes = new List<Docente>();
        }
    }
}
