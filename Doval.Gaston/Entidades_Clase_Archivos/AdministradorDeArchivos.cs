using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades_Clase_Archivos
{
    public static class AdministradorDeArchivos
    {
        public static bool Escribir(string path, string cadena, bool append)
        {
            try
            {
                StreamWriter archivo = new StreamWriter(path, append);
                archivo.WriteLine(cadena);
                archivo.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public static bool Leer(string path, out string info)
        {
            info = "";
            StreamReader leo;
            try
            {
                leo = new StreamReader(path);
            }
            catch (Exception e)
            {
                return false;
            }
            info = leo.ReadToEnd();
            leo.Close();
            return true;
        }
    }
}
