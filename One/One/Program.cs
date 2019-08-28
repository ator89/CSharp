using System;

namespace One
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int opcionMenu = -1;
            bool menu1 = true;

            Person p = new Person();
            //Usuario u = new Usuario();

            Console.WriteLine("Escribir un nombre: ");
            p.Nombre = Console.ReadLine();
            Console.WriteLine();
            //Console.WriteLine("Escribir apellido: ");
            //p.Apellido = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Usuario: ");
            //u.User = Console.ReadLine();

            //Console.WriteLine();
            ////Console.WriteLine("Password: ");
            //u.Password = Console.ReadLine();


            Console.WriteLine("Hi {0}!\n", p.Nombre);
            //Console.WriteLine("Usuario {0}!\n", u.User);

            Console.WriteLine("Hello World!");

            while (menu1)
            {
                do
                {

                } while (opcionMenu != 0);
                menu1 = false;
            }
        }
    }
}
