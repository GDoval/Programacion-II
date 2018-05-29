using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml; //trae la clase xmlTextWriter
using System.Xml.Serialization; //agrega la clase XMLserializer para serializar archivos xml
using System.Runtime.Serialization.Formatters.Binary; //agregar para serializar. Trae la clase BinaryFormatter
using System.IO; // agregar para serializar. Trae la clase FileStream. Manipula archivos de cualqeuier tipo
namespace Entidades_Clase_Archivos 
{
    public enum EPuesto
    {
        Arquero, Defensa, Medio, Delantero
    }//se agrega [Serializable] para marcar que se puede erializar la clase
    [Serializable]public class Jugador : ISerializableBinario, ISerializableXML
    {
        protected string _nombre;
        public string _apellido;
        protected EPuesto _puesto;


        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
        public string Apellido { get { return this._apellido; } }
        public EPuesto Puesto { get { return this._puesto; } }

        public Jugador() { }
        public Jugador(string nombre, string apellido, EPuesto puesto)
        {
            this._puesto = puesto;
            this._nombre = nombre;
            this._apellido = apellido;
        }


        #region Métodos
        public override string ToString()
        {
            string resp = this.Nombre + "-" + this.Apellido + "-" + this.Puesto;
            return resp;
        }

        public static bool TraerUno(string path, Jugador buscado, out Jugador retorno )
        {
            bool resp = true;
            string todo;
            string[] nombres, cadobj;
            retorno = null;
            bool flag = AdministradorDeArchivos.Leer(path, out todo);
            if (flag)
            {
                nombres= todo.Split('\n');
                foreach (string i in nombres)
                {
                    cadobj = i.Split('-');
                    if (buscado.Nombre == cadobj[0] && buscado.Apellido == cadobj[1] && buscado.Puesto.ToString() == cadobj[2])
                    {
                        retorno = new Jugador(cadobj[0], cadobj[1], (EPuesto)Enum.Parse(typeof(EPuesto),cadobj[2]));
                        resp = true;
                        break;
                    }
                    else
                        resp = false;
                }
            }
            else
            {
                retorno = null;
                resp = false;
            }
            return resp;
        }
        #endregion

        void ISerializableBinario.Serializar()
        {
            BinaryFormatter binario = new BinaryFormatter();
            FileStream manipular = new FileStream("jugadores.dat", FileMode.Create); // por convencion los archivos de datos son .dat
            binario.Serialize(manipular, this); //Guarda el segundo parametro(un objeto cualquiera) en el archivo binario que se pasa como primer parametro
            manipular.Close();
        }

        Jugador ISerializableBinario.Deserializar()
        {
            FileStream leer = new FileStream("jugadores.dat", FileMode.Open);
            BinaryFormatter binario = new BinaryFormatter();
            Jugador j = (Jugador)binario.Deserialize(leer);
            leer.Close();
            return j;
        }

        void ISerializableXML.Serializar()
        {
            XmlTextWriter xml = new XmlTextWriter("jugadores.xml", Encoding.UTF8);
            XmlSerializer serializa = new XmlSerializer(typeof(Jugador));
            serializa.Serialize(xml, this);// tiene que coincidir el objeto que se pasa como parametro al metodo Serialize con el tipo de objeto que se paso como parametro cuando se instancio el tipo XmlSerializer
            xml.Close();
        }

        Jugador ISerializableXML.Deserializar()
        {
            XmlSerializer serializa = new XmlSerializer(typeof(Jugador));
            XmlTextReader leo = new XmlTextReader("jugadores.xml");
            Jugador j = (Jugador)serializa.Deserialize(leo);
            leo.Close();
            return j;
        }
    }
}
