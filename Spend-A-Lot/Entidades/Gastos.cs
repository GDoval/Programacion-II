using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
namespace Entidades
{


    public enum ETipoGasto
    {
        Fijo, Necesario, Superfluo
    }

    [Serializable]
    [XmlInclude(typeof(Fijos))]
    [XmlInclude(typeof(Superfluo))]
    [XmlInclude(typeof(Necesarios))]
    public class Gastos
    {
        protected double _gasto;
        protected string justificacion;
        protected ETipoGasto tipo;

        public double Gasto { get { return this._gasto; } set { this._gasto = value; } }
        public string Justifiacion { get { return this.justificacion; } set { this.justificacion = value; } }
        public ETipoGasto Tipo { get { return this.tipo; } set { this.tipo = value; } }

        public Gastos(double gasto, string just, ETipoGasto tipo)
        {
            this.Gasto = gasto;
            this.Justifiacion = just;
            this.Tipo = tipo;
        }

        public Gastos()
        { }
    }
}
