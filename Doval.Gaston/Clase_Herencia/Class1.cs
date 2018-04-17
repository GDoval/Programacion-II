using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Herencia
{
    public class Vehiculo
    {
        protected string _patente;
        protected byte _cantRuedas;
        protected EMarcas _marca;

        public string Patente { get { return this._patente; } }
        public EMarcas Marca { get { return this._marca; } }

        protected string Mostrar()
        {
            string resp = "";
            resp = this.Patente + "  " + this.Marca + "    " + this._cantRuedas ;
            return resp;
        }

        public Vehiculo(string patente, byte ruedas, EMarcas marcas)
        {
            this._patente = patente;
            this._marca = marcas;
            this._cantRuedas = ruedas;
        }

        public static bool operator ==(Vehiculo ve1, Vehiculo ve2)
        {
            bool resp = false;
            if (ve1.Patente == ve2.Patente && ve1.Marca == ve2.Marca)
                return resp = true;
            return resp;
        }

        public static bool operator !=(Vehiculo ve1, Vehiculo ve2)
        {
            return !(ve1 == ve2);
        }
    }



    public class Auto : Vehiculo
    {
        protected int _cantAsientos;
        public string MostrarAuto()
        {
            string resp = "";
            resp = base.Mostrar() + "\nCantidad asientos: " + this._cantAsientos;
            return resp;
        }

        public Auto(int asientos, string patente, byte ruedas, EMarcas marca)
            : base(patente, ruedas, marca)
        {
            this._cantAsientos = asientos;
        }

    }

    public class Camion : Vehiculo
    {
        protected float _tara;
        public string MostrarCamion()
        {
            string resp = "";
            resp = base.Mostrar() + "\nTara: " + this._tara;
            return resp;
        }

        public Camion(float tara, string patente, byte ruedas, EMarcas marca)
            : base(patente, ruedas, marca)
        {
            this._tara = tara;
        }
    }

    public class Moto : Vehiculo
    {
        protected float _cilindrada;
        public string MostrarMoto()
        {
            string resp = "";
            resp = base.Mostrar() + "\nCilindrada: " + this._cilindrada;
            return resp;
        }

        public Moto(float cilindrada, string patente, byte ruedas, EMarcas marca)
            : base(patente, ruedas, marca)
        {
            this._cilindrada = cilindrada;
        }
    }


    public class Lavadero
    {
        private List<Vehiculo> _vehiculos;
        private float _precioAuto;
        private float _precioMoto;
        private float _precioCamion;

        public Lavadero(float precioAuto, float precioMoto, float precioCamion) : this()
        {
            this._precioAuto = precioAuto;
            this._precioCamion = precioCamion;
            this._precioMoto = precioMoto;
        }

        private Lavadero()
        {
            this._vehiculos = new List<Vehiculo>();
        }

        public string Lavero { 
            get { 
                string resp = "";
                resp += "$Autos: " + this._precioAuto + "\n$Camion: " + this._precioCamion + "\n$Moto: " + this._precioMoto + "\n";
                foreach (Vehiculo ve in this._vehiculos)
                {
                    if (ve is Auto)
                        resp += ((Auto)ve).MostrarAuto() + "\n";
                    if (ve is Moto)
                        resp += ((Moto)ve).MostrarMoto() + "\n";
                    if (ve is Camion)
                        resp += ((Camion)ve).MostrarCamion() + "\n";
                }
                return resp;
            } 
        }





    }
}
