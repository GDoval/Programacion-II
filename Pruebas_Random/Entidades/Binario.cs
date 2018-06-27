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
    public class Binario<T>
    {
        public void SerializarBinario(string path, T p)
        {
            try
            {
                BinaryFormatter binario = new BinaryFormatter();
                FileStream manipular = new FileStream(path, FileMode.OpenOrCreate); // por convencion los archivos de datos son .dat
                binario.Serialize(manipular, p); //Guarda el segundo parametro(un objeto cualquiera) en el archivo binario que se pasa como primer parametro
                manipular.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
            }
        }

        public T DeSerializarBinario(string path)
        {
            T j = default(T);
            try
            {
                FileStream leer = new FileStream(path, FileMode.Open);
                BinaryFormatter binario = new BinaryFormatter();
                j = (T)binario.Deserialize(leer);
                leer.Close();
                return j;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Read();
                return j;
            }
        }
    }
}
