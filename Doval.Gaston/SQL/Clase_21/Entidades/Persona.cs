using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _id;
        #region Propiedades y Constructores
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public int Edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }
        public int Id { get { return this._id; } }

        public Persona(string nombre, string apellido, int edad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Edad = edad;
        }
        public Persona(string nombre, string apellido, int edad, int id)
            : this(nombre, apellido, edad)
        {
            this._id = id;
        }
        #endregion

        public static List<Persona> TraerTodos()
        {
            List<Persona> lista = null;
            try
            {
                //Esto se crea desde DEBUG, ultima opcion, Settings, nombre de la conexion (en este caso Conexion), Connection String
                //Poner e nombre de la base de datos, elegir la tabla, testear la conexion, poner ok, guardar con Crtl + S
                SqlConnection sqlPadron = new SqlConnection(Properties.Settings.Default.Conexion);

                sqlPadron.Open();

                SqlCommand comando = new SqlCommand("SELECT [id],[nombre],[apellido],[edad] FROM [padron].[dbo].[personas]", sqlPadron);

                SqlDataReader reader = comando.ExecuteReader(); //devuelve un objeto

                lista = new List<Persona>();

                while (reader.Read())
                {
                    //reader["nombre"] 
                    lista.Add(new Persona(reader[1].ToString(), reader[2].ToString(), (int)reader[3], (int)reader[0]));
                }

                reader.Close();
                sqlPadron.Close();
            }
            catch 
            {
                Console.WriteLine("error");
            }
            return lista;
        }

        public  bool Agregar()
        {
            bool resp = true;
            int num;
            try
            {
                SqlConnection sqlPadron = new SqlConnection(Properties.Settings.Default.Conexion);
                sqlPadron.Open(); //siempre se abre la conexion a la base de datos
                //Se pude poner o el nombre de la tabla o el path a la misma, pero nunca entre comillas
                SqlCommand comando = new SqlCommand("INSERT INTO [padron].[dbo].[personas] (nombre, apellido, edad) VALUES ('" + this.Nombre + "','" + this.Apellido + "','" + this.Edad + "')", sqlPadron);
                num = comando.ExecuteNonQuery(); //devuelve la cantidad de registros afectados por la consulta
                sqlPadron.Close();
            }
            catch
            {
                resp = false;
            }
            return resp;
        }

        public static bool Borrar(Persona per)
        {
            bool resp = true;
            try
            {
                SqlConnection sqlPadron = new SqlConnection(Properties.Settings.Default.Conexion);
                sqlPadron.Open();
                SqlCommand comando = new SqlCommand("DELETE FROM Personas WHERE id = " + per.Id, sqlPadron);
                comando.ExecuteNonQuery();
                sqlPadron.Close();
            }
             catch
            {
                 resp = false;  
            }
            return resp;
        }
        
    }
}
