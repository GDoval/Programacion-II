using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Agenda
    {
        private Persona[] array_personas;
        private Persona persona;
        private int cant;

        public Agenda(string nombre, string mail, int dni, int tel)
        {
            persona.SetNom(nombre);
            persona.SetTel(tel);
            persona.SetMail(mail);
            persona.SetDni(dni);
        }

        public Agenda() :this("Sin Ingresar", "Sin ingresar", 0, 0)
        {   
        }
    }



    class Persona
    {
        private string nombre;
        private int telefono;
        private int dni;
        private string mail;

        public void SetNom(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetMail(string mail)
        {
            this.mail = mail;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public void SetTel(int tel)
        {
            this.telefono = tel;
        }

    }
}
