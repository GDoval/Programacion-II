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
    public class Texto<T>
    {
        public void CrearTxt(string path, bool crear, T per)
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

        public string LeoArchivo(string path) //Abre el archivo para lectura
        {
            string texto;
            try
            {
                StreamReader archivo;
                archivo = File.OpenText(path);
                texto = archivo.ReadToEnd(); ; 
                archivo.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                texto = "";
            }
            return texto;
        }
    }


}
