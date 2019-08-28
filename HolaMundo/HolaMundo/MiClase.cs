using System;
namespace HolaMundo
{
    public class MiClase
    {
        public string NombreClase { get; set; }

        //Constructor
        public MiClase(string name)
        {
            NombreClase = name;
        }

        public void ImprimirMensaje()
        {
            Console.WriteLine("Mensaje de bienvenida a {0}", NombreClase);
        }
    }
}
