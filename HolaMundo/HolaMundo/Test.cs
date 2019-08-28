using System;
namespace HolaMundo
{
    public class Test
    {
        private string nombre;
        public string NombreTest
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public void MensajeTest()
        {
            Console.WriteLine("Hola, mi nombre es {0}", NombreTest);
        }
    }
}
