//Crear archivo

            try
            {
                StreamWriter archivo = new StreamWriter(path, crear);
                archivo.WriteLine("Linea de prueba");
                archivo.Close();
            }
            catch (Exception e)

            //desde el Main para guardar en escritorio. False crea el archivo, True agrega lineas

            Violence vio = new Violence();
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\salida.txt";
            vio.Escribir(ruta, true);

//Serializar y deserializar en binario. Hay que agregar [Serializable] en la clase: [Serializable]public class Jugador

using System.Xml.Serialization; //agrega la clase XMLserializer para serializar archivos xml
using System.Runtime.Serialization.Formatters.Binary; //agregar para serializar. Trae la clase BinaryFormatter
using System.IO; // agregar para serializar. Trae la clase FileStream. Manipula archivos de cualqeuier tipo


        void ISerializableBinario.Serializar()
        {
            BinaryFormatter binario = new BinaryFormatter();
            FileStream manipular = new FileStream("jugadores.dat", FileMode.Create); // por convencion los archivos de datos son .dat
            binario.Serialize(manipular, this); //Guarda el segundo parametro(un objeto cualquiera) en el archivo binario que se pasa como primer parametro
            manipular.Close();
        }

        Jugador ISerializableBinario.Deserializar()
        {
            FileStream leer = new FileStream("jugadores.dat", FileMode.Open);
            BinaryFormatter binario = new BinaryFormatter();
            Jugador j = (Jugador)binario.Deserialize(leer);
            leer.Close();
            return j;
        }


//Serializar XML
using System.Xml; //trae la clase xmlTextWriter

        void ISerializableXML.Serializar()
        {
            XmlTextWriter xml = new XmlTextWriter("jugadores.xml", Encoding.UTF8);
            XmlSerializer serializa = new XmlSerializer(typeof(Jugador));
            serializa.Serialize(xml, this);// tiene que coincidir el objeto que se pasa como parametro al metodo Serialize con el tipo de objeto que se paso como parametro cuando se instancio el tipo XmlSerializer
            xml.Close(); //Siempre cerrar los manejadores de archivos para liberar la memoria
        }

        Jugador ISerializableXML.Deserializar()
        {
            XmlSerializer serializa = new XmlSerializer(typeof(Jugador));
            XmlTextReader leo = new XmlTextReader("jugadores.xml");
            Jugador j = (Jugador)serializa.Deserialize(leo);
            leo.Close(); //Siempre cerrar los manejadores de archivos
            return j;
        }



//Leer desde base de datos

        using System.Data;
using System.Data.SqlClient;

                    List<Momentum> lista = null;
            try
            {
                //El argumento que recibe el constructor es lo que se setea desde la IDE
                SqlConnection sqlPadron = new SqlConnection(Properties.Settings.Default.Conexion); 
 
                sqlPadron.Open(); //Siempre tenemos que abrir la conexion
 
               //Un simple comando SELECT
                SqlCommand comando = new SqlCommand("SELECT [id],[nombre],[apellido],[edad] FROM [padron].[dbo].[Momentums]", sqlPadron); 
 
                //Se ejecuta el comando y se lo guarda dentro de la variable reader que actua como un array
                SqlDataReader reader = comando.ExecuteReader(); 
 
                lista = new List<Momentum>();
 
                while (reader.Read()) //Lee cada uno de los registros guardados en el array
                {
                    lista.Add(new Momentum(reader[1].ToString(), reader[2].ToString(), (int)reader[3], (int)reader[0]));
                }
 
                reader.Close();   //Siempre cerrar la conexion
                sqlPadron.Close();

//Escribir en base de datos

                try
{
 SqlConnection sqlPadron = new SqlConnection(Properties.Settings.Default.Conexion);
 sqlPadron.Open(); //siempre se abre la conexion a la base de datos
 //Se pude poner o el nombre de la tabla o el path a la misma, pero nunca entre comillas
 SqlCommand comando = new SqlCommand("INSERT INTO [padron].[dbo].[Personas] (nombre, apellido, edad) VALUES ('" + 
 this.Nombre + "','" + this.Apellido + "','" + this.Edad + "')", sqlPadron);
 num = comando.ExecuteNonQuery(); //devuelve la cantidad de registros afectados por la consulta
 sqlPadron.Close();
}


