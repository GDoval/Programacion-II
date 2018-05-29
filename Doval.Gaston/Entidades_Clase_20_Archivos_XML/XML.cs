using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades_Clase_20_Archivos_XML
{
    public class XML<T>
    {
        public bool GuardarXML(string path, T a)
        {
            bool resp = true;
            try
            {
                XmlTextWriter guardar = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer serializa = new XmlSerializer(typeof(T));
                serializa.Serialize(guardar, a);
                guardar.Close();
            }
            catch (Exception e)
            {
                resp = false;
            }
            return resp;
        }

        public bool LeerXML(string path, out T a)
        {
            bool resp = true;
            a = default(T);
            try
            {
                XmlSerializer serializo = new XmlSerializer(typeof(T));
                XmlTextReader leo = new XmlTextReader(path);
                a = (T)serializo.Deserialize(leo);
                leo.Close();
            }
            catch (Exception e)
            {
                resp = false;
            }
            return resp;
        }
    }
}
