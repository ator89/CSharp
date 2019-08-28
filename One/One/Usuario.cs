using System;
namespace One
{
    public class Usuario
    {
        private string usuario, password;

        public Usuario()
        {
            usuario = "";
            password = "";
        }

        public string User 
        {
            get { return usuario; }
            set { usuario = value;  }
        }

        public string Password
        {
            get { return password;  }
            set { password = value; }
        }
    }
}
