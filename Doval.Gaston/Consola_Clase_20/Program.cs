﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_Clase_20_Archivos_XML;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace Consola_Clase_20
{
    public class Program
    {
        #region Metodos estaticos reehechos en la clase generica XML
        static bool GuardarXML(string path, Alumno a)
        {
            bool resp = true;
            try
            {
                XmlTextWriter guardar = new XmlTextWriter(path, Encoding.UTF8);
                XmlSerializer serializa = new XmlSerializer(typeof(Alumno));
                serializa.Serialize(guardar, a);
                guardar.Close();
            }
            catch (Exception e)
            {
                resp = false;
            }
            return resp;
        }
        static bool LeerXML(string path, out Alumno a)
        {
            bool resp = true;
            a = null;
            try
            {
                XmlSerializer serializo = new XmlSerializer(typeof(Alumno));
                XmlTextReader leo = new XmlTextReader(path);
                a = (Alumno)serializo.Deserialize(leo);
                leo.Close();
            }
            catch (Exception e)
            {
                resp = false;
            }
            return resp;
        }
        #endregion

        static void Main(string[] args)
        {
            Alumno a = new Alumno(1, "Juan", "Goldberg", 12345);
            Profesor p = new Profesor("Geometristador", "Pedro", "Rohzkov", 898989);
            Aula aula = new Aula(4);
            aula.Lista.Add(a);
            aula.Lista.Add(p);
            XML<Profesor> xml = new XML<Profesor>();
            if (xml.GuardarXML("aula.xml", p))
            {
                Console.Write("OK\n");
            }
            else
                Console.Write("NO BUENO");
            Profesor buffer;
            if (xml.LeerXML("aula.xml", out buffer))
            {
                Console.WriteLine(buffer);
            }
            else
                Console.WriteLine("NO BUENO");

            Console.ReadLine();
        }
    }
}