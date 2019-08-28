using System;
using System.Collections.Generic;

namespace ADT
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ListaEnlazada lista = new ListaEnlazada();
            List<Persona> listaPersonas = new List<Persona>();
            lista.insert(2);
            lista.insert(4);
            lista.insert(5);
            lista.insert(6);
            lista.insertAt(3, 5);
            lista.remove(1);
            lista.show();

            string nombre, apellido;
            int edad;

            Console.WriteLine("Ingrese el nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido: ");
            apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            Persona p1 = new Persona(nombre, apellido, edad);
            Persona p2 = new Persona("dos", "tres", 34);
            Persona p4 = new Persona("otro", "goku", 35);

            Persona u = new Usuario("at", "a123", "antonio", "alvarez", 18);

            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
            listaPersonas.Add(p4);
            listaPersonas.Add(u);

            for(int i = 0; i < listaPersonas.Count; i++)
            {
                Console.WriteLine("Nombre: {0}\nApellido: {1}\nEdad: {2}",
                listaPersonas[i].Nombre,
                listaPersonas[i].Apellido,
                listaPersonas[i].Edad);
            }


            lista.insert(1);
            lista.insert(3);
            lista.insert(5);
            lista.show();

            //Console.WriteLine("Nombre: {0}\nApellido: {1}\nEdad: {2}",
            //    nombre, apellido, edad);

        }

        public static void menu()
        {
            Console.WriteLine("\n\tMENU\n\n");
            Console.Write("1 - Add\n2 - List\n3 - Remove\n");
            Console.Write("4 - Modify\n0 - Exit");
        }
    }
}