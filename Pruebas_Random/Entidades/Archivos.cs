using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;

namespace Entidades
{
    [Serializable]public class Archivos
    {
        public Archivos()
        { }
        
        public void CrearTxt(string path, bool crear, Personas per)
        {
            try
            {
                StreamWriter archivo = new StreamWriter(path, crear);
                archivo.WriteLine(per.ToString());
                archivo.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }

        public void SerializarBinario(string path, bool crear, Personas pe)
        {
            try
            {
                BinaryFormatter binario = new BinaryFormatter();
                FileStream manipular = new FileStream(path, FileMode.OpenOrCreate); // por convencion los archivos de datos son .dat
                binario.Serialize(manipular, pe); //Guarda el segundo parametro(un objeto cualquiera) en el archivo binario que se pasa como primer parametro
                manipular.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }

        public void SerializarXml(string path, Personas pe)
        {
            try
            {
                XmlTextWriter xml = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer serializa = new XmlSerializer(typeof(Personas));
                serializa.Serialize(xml, pe);// tiene que coincidir el objeto que se pasa como parametro al metodo Serialize con el tipo de objeto que se paso como parametro cuando se instancio el tipo XmlSerializer
                xml.Close(); //Siempre cerrar los manejadores de archivos para liberar la memoria
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }

        public Personas DeSerializarBinario(string path, Personas pe)
        {
            try
            {
                FileStream leer = new FileStream(path, FileMode.Open);
                BinaryFormatter binario = new BinaryFormatter();
                Personas j = (Personas)binario.Deserialize(leer);
                leer.Close();
                return j;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return pe;
            }
        }

        public void Serializar_Xml(string path, Personas pe)
        {
            try
            {
                XmlTextWriter xml = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer serializa = new XmlSerializer(typeof(Personas));
                serializa.Serialize(xml, pe);// tiene que coincidir el objeto que se pasa como parametro al metodo Serialize con el tipo de objeto que se paso como parametro cuando se instancio el tipo XmlSerializer
                xml.Close(); //Siempre cerrar los manejadores de archivos para liberar la memoria
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }

        public Personas Deserializar_XML(string path, Personas pe)
        {
            try
            {
                XmlSerializer serializa = new XmlSerializer(typeof(Personas));
                XmlTextReader leo = new XmlTextReader(path);
                Personas j = (Personas)serializa.Deserialize(leo);
                leo.Close(); //Siempre cerrar los manejadores de archivos
                return j;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return pe;
            }
        }


        public void SerializarXml_Lista(string path, List<Personas> pe)
        {
            try
            {
                XmlTextWriter xml = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer serializa = new XmlSerializer(typeof(List<Personas>));
                serializa.Serialize(xml, pe);// tiene que coincidir el objeto que se pasa como parametro al metodo Serialize con el tipo de objeto que se paso como parametro cuando se instancio el tipo XmlSerializer
                xml.Close(); //Siempre cerrar los manejadores de archivos para liberar la memoria
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }
    }
}
