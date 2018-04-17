using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Herencia
{
    public class Vehiculo
    {
        protected string _patente; //Protected significa que las clases hijas pueden acceder a los atributos/metodos como si fueran publicos
        protected byte _cantRuedas; // pero para el resto de las clases no-hijas estos atributos/métodos son privados
        protected EMarcas _marca;

        public string Patente { get { return this._patente; } }
        public EMarcas Marca { get { return this._marca; } }

        /// <summary>
        /// Muestra los atributos de la clase Vehiculo
        /// </summary>
        /// <returns></returns>
        protected string Mostrar()
        {
            string resp = "";
            resp = this.Patente + "  " + this.Marca + "    " + this._cantRuedas ;
            return resp;
        }

        /// <summary>
        /// Constructor de la clase vehiculo que recibe 3 parametros
        /// </summary>
        /// <param name="patente"></param>
        /// <param name="ruedas"></param>
        /// <param name="marcas"></param>
        public Vehiculo(string patente, byte ruedas, EMarcas marcas)
        {
            this._patente = patente;
            this._marca = marcas;
            this._cantRuedas = ruedas;
        }

        /// <summary>
        /// Sobrecarga del == que compara patente y marca de dos objetos de tipo Vehiculo
        /// </summary>
        /// <param name="ve1"></param>
        /// <param name="ve2"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Muestra el atributo propio de la clase, mas los atributos heredados de la clase Vehiculo
        /// </summary>
        /// <returns></returns>
        public string MostrarAuto()
        {
            string resp = "";
            resp = base.Mostrar() + "\nCantidad asientos: " + this._cantAsientos;
            return resp;
        }

        /// <summary>
        /// Constructor, pasa 3 parametros al constructor de la clase Padre
        /// </summary>
        /// <param name="asientos"></param>
        /// <param name="patente"></param>
        /// <param name="ruedas"></param>
        /// <param name="marca"></param>
        public Auto(int asientos, string patente, byte ruedas, EMarcas marca)
            : base(patente, ruedas, marca)
        {
            this._cantAsientos = asientos;
        }

    }

    public class Camion : Vehiculo
    {
        protected float _tara;

        /// <summary>
        /// Muestra el atributo propio de la clase, mas los atributos heredados de la clase Vehiculo
        /// </summary>
        /// <returns></returns>
        public string MostrarCamion()
        {
            string resp = "";
            resp = base.Mostrar() + "\nTara: " + this._tara;
            return resp;
        }
        /// <summary>
        /// Constructor, pasa 3 parametros al constructor de la clase Padre
        /// </summary>
        /// <param name="tara"></param>
        /// <param name="patente"></param>
        /// <param name="ruedas"></param>
        /// <param name="marca"></param>
        public Camion(float tara, string patente, byte ruedas, EMarcas marca)
            : base(patente, ruedas, marca)
        {
            this._tara = tara;
        }
    }

    public class Moto : Vehiculo
    {
        protected float _cilindrada;

        /// <summary>
        /// Muestra el atributo propio de la clase, mas los atributos heredados de la clase Vehiculo
        /// </summary>
        /// <returns></returns>
        public string MostrarMoto()
        {
            string resp = "";
            resp = base.Mostrar() + "\nCilindrada: " + this._cilindrada;
            return resp;
        }
        /// <summary>
        /// Constructor, pasa 3 parametros al constructor de la clase Padre
        /// </summary>
        /// <param name="cilindrada"></param>
        /// <param name="patente"></param>
        /// <param name="ruedas"></param>
        /// <param name="marca"></param>
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

        /// <summary>
        /// Constructor con parametros, llama al constructor privado que genera una nueva (new) List<Vehiculos>
        /// </summary>
        /// <param name="precioAuto"></param>
        /// <param name="precioMoto"></param>
        /// <param name="precioCamion"></param>
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

        /// <summary>
        /// Devuelve toda la informacion guardada en los atributos de la clase.
        /// </summary>
        public string Lava { 
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

        public List<Vehiculo> Vehiculos { get { return this._vehiculos; } }

        public double MostrarTotalFacturado() // Se llama al metodo que recibe el parametro para no repetir codigo, xq el otro retorna el total para un solo tipo de Vehiculo
        {
            return this.MostrarTotalFacturado(EVehiculos.Auto) + this.MostrarTotalFacturado(EVehiculos.Camion) + this.MostrarTotalFacturado(EVehiculos.Moto);
        }

        public double MostrarTotalFacturado(EVehiculos nume)
        {
            double total = 0;
            int cont = 0;
            foreach (Vehiculo ve in this._vehiculos) //Se puede hacer 3 contadores y eliminar unas de las condiciones de los If
            {
                if (nume == EVehiculos.Auto && ve is Auto)
                    cont++;
                if (nume == EVehiculos.Camion && ve is Camion)
                    cont++;
                if (nume == EVehiculos.Moto && ve is Moto)
                    cont++;
            }

            switch (nume)
            {
                case EVehiculos.Auto:
                    return total = Convert.ToDouble(cont * this._precioAuto);
                case EVehiculos.Camion:
                    return total = Convert.ToDouble(cont * this._precioCamion);
                case EVehiculos.Moto:
                    return total = Convert.ToDouble(cont * this._precioMoto);
            }
            return total;
        }
        /// <summary>
        /// Busca un objeto de tipo Vehiculo dentro de la List de la clase Lavadero
        /// </summary>
        /// <param name="ve"></param>
        /// <param name="lav"></param>
        /// <returns></returns>
        public static bool operator ==(Vehiculo ve, Lavadero lav)
        {
            bool resp = false;
            foreach (Vehiculo v in lav._vehiculos)
            {
                if (ve == v)
                    return resp = true;
            }
            return resp;
        }

        public static bool operator !=(Vehiculo ve, Lavadero lav)
        {
            return !(ve == lav);
        }

        public static Lavadero operator -(Vehiculo ve, Lavadero lav)
        {
            Lavadero resp;
            if (ve == lav) //Reutilizo codigo de la sobrecarga del operador == entre Vehiculo y Lavadero (que se fija si el Vehiculo está dentro de la lista en Lavadero)
            {
                lav._vehiculos.Remove(ve);
            }
            return resp = lav;
        }

        public static Lavadero operator +(Vehiculo ve, Lavadero lav)
        {
            Lavadero resp;
            if (ve != lav) // Idem operador menos. Si _no_ esta en la lista, se lo agrega
            {
                lav._vehiculos.Add(ve);
            }
            return resp = lav;
        }
        /// <summary>
        /// Devuelve 0 sin son iguales, 1 si el primero es mas grande, -1 si es mas chico
        /// </summary>
        /// <param name="ve1"></param>
        /// <param name="ve2"></param>
        /// <returns></returns>
        public static int OrdenarVehiculosPorPatente(Vehiculo ve1, Vehiculo ve2)
        {
             int resp = String.Compare(ve1.Patente, ve2.Patente);
             return resp;
        }
        /// <summary>
        /// Devuelve 0 sin son iguales, 1 si el primero es mas grande, -1 si es mas chico
        /// </summary>
        /// <param name="ve1"></param>
        /// <param name="ve2"></param>
        /// <returns></returns>
        public int OrdenarVehiculosPorMarca(Vehiculo ve1, Vehiculo ve2)
        {
            if (ve1 == ve2)
                return 0;
            int resp = String.Compare(Convert.ToString(ve1.Marca), Convert.ToString(ve2.Marca));
            return resp;
        }
    }
}
