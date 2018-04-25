using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Practica_Parcial1
{
    public class Articulo
    {
        protected int _codigo;
        protected string _nombre;
        protected float _precioCosto;
        protected float _precioVenta;
        protected int _stock;

        public string NombreYCodigo 
        { get 
            {
                string resp;
                resp = Convert.ToString(this._nombre) + " --- " + Convert.ToString(this._codigo);
                return resp;
            }
        }


        public virtual float PrecioCosto
        {
            set
            {
                this._precioCosto = value;
                float recargo = value * 0.3f;
                this._precioVenta = value + recargo;
            }
        }

        public float PrecioVenta { get { return this._precioVenta; } }

        public int Stock { set { this._stock = value; } }

        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._stock = cantidad;
            this.PrecioCosto = precioCosto;
            this._nombre = nombre;
            this._codigo = codigo;
        }

        public bool HayStock(int cantidad)
        {
            bool resp = false;
            if (this._stock >= cantidad)
                return resp = true;
            return resp;
        }


        public static int operator +(Articulo articuloUno, Articulo articuloDos)
        {
            int resp;
            resp = articuloUno._stock+ articuloDos._stock;
            return resp;
        }

        public static bool operator ==(Articulo articuloUno, Articulo articuloDos)
        {
            bool resp = false;
            if (articuloUno.NombreYCodigo == articuloDos.NombreYCodigo)
                return resp = true;
            return resp;
        }

        public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
        {
            return !(articuloUno == articuloDos);
        }

        public override bool Equals(object obj)
        {
            if (obj is Articulo)
            {
                if (this == (Articulo)obj)
                    return true;
            }
            return false;
        }


        public static int operator -(Articulo articuloUno, int cantidad)
        {
            int resp;
            resp = articuloUno._stock - cantidad;
            return resp;
        }
    }
}
