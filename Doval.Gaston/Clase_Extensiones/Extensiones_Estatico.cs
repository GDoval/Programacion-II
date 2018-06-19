using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Alumnos;
using Entidades.Externa;
using Entidades.Externa.Sellada;
using System.IO;
using System.Data.SqlClient;
namespace Clase_Extensiones
{
    public static class Extensiones_Estatico
    {
        public static string ObtenerInfo(this Persona p)
        {
            return p.ToString();
        }

        public static string ObtenerInfoSellada(this PersonaExternaSellada p)
        {
            string resp = "";
            resp += "Nombre: " + p.Nombre + " Apellido: " + p.Apellido + " Edad: " + p.Edad + " Sexo: " + p.Sexo.ToString();
            return resp;
        }

        public static bool EscribirSellada(this PersonaExternaSellada p, string path)
        {
            bool resp = true;
            try
            {
                StreamWriter archivo = new StreamWriter(path, true);
                archivo.WriteLine(p.ObtenerInfoSellada());
                archivo.Close();
            }
            catch (Exception e)
            {
                resp = false;
                Console.WriteLine(e.Message);
            }
            return resp;
        }

        public static bool EsNulo(this object e)
        {
            if (e == null)
                return true;
            else
                return false;
        }

        public static int DevuelveLongitud(this String s, string cadena)
        {
            return cadena.Length;
        }

        public static bool GuardoEnDB(this PersonaExternaSellada p)
        {
            bool resp = true;
            int num = (int)p.Sexo;
            try
            {
                SqlConnection conectar = new SqlConnection(Properties.Settings.Default.Conexion);
                conectar.Open();
                SqlCommand comando = new SqlCommand("INSERT INTO Personas (Nombre, Apellido, Edad, Sexo) VALUES ('" + p.Nombre
                    + "','" + p.Apellido + "'," + p.Edad + "," + num + ")", conectar);
                comando.ExecuteNonQuery();
                conectar.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                resp = false;
            }
            return resp;
        }

        public static List<PersonaExternaSellada> LeoDB(this PersonaExternaSellada p)
        {
            List<PersonaExternaSellada> lista = new List<PersonaExternaSellada>();
            SqlConnection conectar = new SqlConnection(Properties.Settings.Default.Conexion);
            conectar.Open();
            SqlCommand comando = new SqlCommand("SELECT * FROM Personas", conectar);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new PersonaExternaSellada(lector["Nombre"].ToString(), lector["Apellido"].ToString(), int.Parse(lector["Edad"].ToString()), (Entidades.Externa.Sellada.ESexo)lector["Sexo"]));
            }
            return lista;
        }
    }
}
