using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
namespace Entidades
{
    //Delegados
    public delegate void CrearTxt(string path, bool crear, Personas pe);
    public delegate void SerializarBinario(string path, bool crear, Personas pe);
    public delegate void SerializarXml(string path, Personas pe);
    public delegate Personas DeserializarBinario(string path, Personas pe);
    public delegate Personas DeserializarXML(string path, Personas pe);

    [Serializable] public class Personas
    {
        private int edad;
        private string nombre;
        private string apellido;

        public int Edad { get { return this.edad; } set { this.edad = value; } }
        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public string Apellido { get { return this.apellido; } set { this.apellido = value; } }

        public Personas(string nombre, string apellido, int edad)
        {
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public Personas()
        { }



        //Eventos

        public static event CrearTxt Evento_Crear_Txt;
        public static event SerializarBinario Evento_Serializar_Binario;
        public static event SerializarXml Evento_Serializar_XML;
        public static  event DeserializarBinario Evento_Deserializar_Binario;
        public static event DeserializarXML Evento_Deserializar_XML;

        public override string ToString()
        {
            string resp = "";
            resp += "Nombre: " + this.Nombre + "\nApellido: " + this.Apellido + "\nEdad: " + Convert.ToString(this.Edad);
            return resp;
        }

        public void Crear_Txt(string path, bool crear)
        {
            Personas.Evento_Crear_Txt(path, crear, this);
        }

        public void Serializar_Binario(string path, bool crear)
        {
            Personas.Evento_Serializar_Binario(path, crear, this);
        }

        public Personas Deserializar_Binario(string path)
        {
            Personas buffer = Personas.Evento_Deserializar_Binario(path, this);
            return buffer;
        }

        public void Serializar_XML(string path)
        {
            Personas.Evento_Serializar_XML(path, this);
        }

        public Personas Deserializar_XML(string path)
        {
            Personas buffer = Personas.Evento_Deserializar_XML(path, this);
            return buffer;
        }

    }
}
