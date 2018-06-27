using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Pruebas_Random
{
    public class Program
    {
        static void Main(string[] args)
        {
            Personas per = new Personas("Gaston", "Doval", 30);
            Personas per2 = new Personas("Fleur", "Galetto", 22);
            List<Personas> lista = new List<Personas>();
            lista.Add(per);
            lista.Add(per2);
            List<Personas> buff = new List<Personas>();

            //Aca se instancian las clases genericas

            XML<List<Personas>> xml = new XML<List<Personas>>();
            Binario<List<Personas>> binario = new Binario<List<Personas>>();
            Texto<string> texto = new Texto<string>();

            Personas buffer = new Personas();

            //Archivos quedo obsoleto xq hice las clases genericas para cada tipo de operacion con archivos
            Archivos archivos = new Archivos();

            //Funciona. Guarda todos los objetos de la lista
            xml.GuardarXML("Generico.xml",lista);

            //Funciona. Guarda todos los objetos de la lista en el archivo binario
            binario.SerializarBinario("genericobin.dat", lista);
            

            buff = binario.DeSerializarBinario("genericobin.dat");
            xml.LeerXML("Generico.xml", out buff);
            foreach (Personas p in buff)
                Console.WriteLine(p);

            //No funciona, guarda el nombre del namespace de List<> no los objetos
            //texto.CrearTxt("textogenerico.txt", false, lista);

            //Funciona. Agrega todos los objetos de la lista al archivo de texto
            foreach (Personas p in lista)
                texto.CrearTxt("textogenerico.txt", true, p.ToString());

            //Funciona. Lee todo el archivo y lo guarda en la variable de tipo string
            string hola = texto.LeoArchivo("textogenerico.txt");
            Console.Write(hola);

            //Aca agrego las funciones a los eventos del objeto per
            Personas.Evento_Crear_Txt += new Entidades.CrearTxt(archivos.CrearTxt);
            Personas.Evento_Serializar_Binario += new Entidades.SerializarBinario(archivos.SerializarBinario);
            Personas.Evento_Serializar_XML += new Entidades.SerializarXml(archivos.SerializarXml);
            Personas.Evento_Deserializar_Binario += new Entidades.DeserializarBinario(archivos.DeSerializarBinario);
            Personas.Evento_Serializar_XML += new Entidades.SerializarXml(archivos.SerializarXml);
            Personas.Evento_Deserializar_XML += new Entidades.DeserializarXML(archivos.Deserializar_XML);
            Console.Read();

        }
    }
}
