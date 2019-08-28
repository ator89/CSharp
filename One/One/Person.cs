using System;
namespace One
{


    public class Person
    {
        private string nombre, apellido;

        public Person()
        {
            nombre = "";
            apellido = "";
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }//get & set nombre

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            { 
                apellido = value;
            }
        }//get & set apellido
    }


}
