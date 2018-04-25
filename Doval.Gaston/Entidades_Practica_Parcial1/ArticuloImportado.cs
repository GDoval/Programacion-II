using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Practica_Parcial1
{
    class ArticuloImportado : Articulo
    {
        private string _paisOrigen;
        private double _impuesto;


        public override float PrecioCosto
        {
            set
            {
                base.PrecioCosto = value + (value * ((float)this._impuesto / 100));
            }
        }
        
        public ArticuloImportado(string pais, double impuesto, string nombre, int codigo, float precioCosto, int cantidad)
            : base(codigo, nombre, precioCosto, cantidad)
        {
            this._paisOrigen = pais;
            this._impuesto = impuesto;
            this.PrecioCosto = precioCosto;
        }
    }
}
