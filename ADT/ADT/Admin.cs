using System;

namespace ADT
{
    public class Admin:Persona
    {
        private int id;
        private string roll;
        private ListaEnlazada listaUsuarios;

        //Constructor
        public Admin()
        {
            id = 0;
            roll = "";
            listaUsuarios = null;
        }

        public Admin(int id, string roll, string name, string ap, int age): base(name, ap, age)
        {
            this.id = id;
            this.roll = roll;
        }

        //Destructor
        ~Admin() { }

        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public string Roll
        {
            set { roll = value; }
            get { return roll; }
        }

        public ListaEnlazada ListaUsuarios
        {
            set { listaUsuarios = value; }
            get { return listaUsuarios; }
        }

    }
}
