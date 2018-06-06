using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Clase_BaseDeDatos
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private int _id;

        public string Nombre { get { return this._nombre; } set { this._nombre = value; } }
        public string AApellido { get { return this._apellido; } set { this._apellido = value; } }
        public int Edad { get { return this._edad; } set { this._edad = value; } }
        public int Id { get { return this._id; } }


        public Persona(string nombre, string apellido, int edad)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
        }

        public Persona(int id, string nombre, string apellido, int edad)
            : this(nombre, apellido, edad)
        {
            this._id = id;
        }

        public static List<Persona> TraerTodos()
        {
            List<Persona> per = new List<Persona>();
            //el namespace properties se crea cuando guardo la value en setting//
            SqlConnection baseDeDato = new SqlConnection(Properties.Settings.Default.conexion);
            //abre la conexion//
            baseDeDato.Open();
            //configo para poder pasarle comandos a la base de datos//
            SqlCommand comando = new SqlCommand("SELECT [id],[nombre],[apellido],[edad] FROM [Padron].[dbo].[Personas]", baseDeDato);
            //el sqldatareader no se puede instanciar , siempre le pasa el valor el execute reader//
            //es un objeto de solo lectura y de avance , es decir cada vez que lee algo lo elimina y pasa al siguiente//
            SqlDataReader lectura = comando.ExecuteReader();
            while (lectura.Read())
            {
                // lectura[0].ToString();//me traeria solo el nombre. siempre devuelve un obj porque puede ser cualq tipo de dato//
                // lectura["id"];//otra manera de devolver un valor//
                per.Add(new Persona(int.Parse(lectura[0].ToString()), lectura[1].ToString(), lectura[2].ToString(), int.Parse(lectura[3].ToString())));
            }

            lectura.Close();
            baseDeDato.Close();

            return per;
        }

        public override string ToString()
        {

            return this._id + "--" + this._nombre + "--" + this._apellido + "--" + this._edad + "\n";
        }


    }
}