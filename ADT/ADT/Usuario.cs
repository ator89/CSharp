using System;
namespace ADT
{
    public class Usuario: Persona
    {
        private string user;
        private string password;

        //Constructor por defecto
        public Usuario() {
            user = "";
            password = "";
        }

        //Constructor sobrecargado
        public Usuario(string us, string pas, string name, string lastna,
            int age) : base(name, lastna, age)
        {
            user = us;
            password = pas;
        }

        //Destructor
        ~Usuario() {}

        //user accesores
        public string User
        {
            get { return user; }
            set { password = value; }
        }

        //password accesores
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

    }
}
