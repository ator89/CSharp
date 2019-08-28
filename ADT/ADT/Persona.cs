using System;
namespace ADT
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;

        //Constructor por defecto
        public Persona(){
            nombre = "";
            apellido = "";
            edad = 0;
        }

        //Destructor
        ~Persona() { }

        public Persona(string n, string ap, int ed)
        {
            Nombre = n;
            Apellido = ap;
            Edad = ed;
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
