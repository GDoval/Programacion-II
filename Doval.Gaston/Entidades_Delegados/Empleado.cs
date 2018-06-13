using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Delegados
{
    //Se crea al nivel del namespace para que sea visible por todas las clases de ese namespace
    public delegate void DelegadoSueldoCero();

    public delegate void DelegadoLimiteSueldo(double sueldo, Empleado empleado);

    public delegate void DelegadoLimiteSueldoMejorado(Empleado empleado, EmpleadoEventArgs e); //Se crea una extension propia de EventArgs para personalizar la informacion sobre lo que disparo el evento 

    public class Empleado
    {
        public string nombre;
        public string apellido;
        public int dni;
        private double sueldo;
        public event DelegadoSueldoCero SueldoCero; //Se crea el evento del tipo del Delegado apropiado al mismo
        public event DelegadoLimiteSueldo SueldoMaximo;
        public event DelegadoLimiteSueldoMejorado SueldoMaximoMejorado;

        public Empleado(string nombre, string apellido, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }

        public double Sueldo 
        { 
            get { return this.sueldo; } 
            set 
            {
                if (value < 0)
                    throw new ExcepcionSueldoNegativo("El sueldo no puede ser menor que cero");
                else if (value == 0)
                    this.SueldoCero(); //se llama al evento en caso de que sea 0 el sueldo  
                else if (value > 20000  && value < 30000)
                {
                    EmpleadoEventArgs info = new EmpleadoEventArgs();
                    info.Sueldo = value;
                    this.SueldoMaximoMejorado(this, info);
                }
                    this.sueldo = value;
            } 
        }

        public override string ToString()
        {
            string resp = "";
            resp += "Nombre: " + this.nombre + "\nApellido: " + this.apellido + "\nDNI: " + this.dni + "\nSueldo: " + this.Sueldo;
            return resp;
        }
        public void ManejadorEvento()
        { Console.WriteLine("El sueldo del empleado es cero"); }

        public void SueldoAlto(double sueldo, Empleado empleado)
        {
            Console.WriteLine("Sueldo muy alto para:\n" + empleado.ToString() + "\nQuiere ganar: " + sueldo);
        }

        public void SueldoAltoMejorado(Empleado empleado, EmpleadoEventArgs e)
        { Console.WriteLine("Sueldo muy alto para:\n" + empleado.ToString() + "\nQuiere ganar: " + e.Sueldo); }
        
    }
}
