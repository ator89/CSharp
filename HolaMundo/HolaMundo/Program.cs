using System;

namespace HolaMundo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Hola\n");
            Console.WriteLine("Hello World!");
            //Imprimir texto con formato
            Console.WriteLine("{0}\n{1}\n{2}", "Hola", "dos", "tres");

            int number1, number2, sum;

            Console.Write("Ingresar un entero: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar otro entero: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine("Sum is {0}", sum);


            int tres, cuatro;
            Console.Write("Ingrese otro entero: ");
            tres = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro más: ");
            cuatro = Convert.ToInt32(Console.ReadLine());

            if (tres == cuatro)
                Console.WriteLine("{0} == {1}", tres, cuatro);

            if (tres != cuatro)
                Console.WriteLine("{0} != {1}", tres, cuatro);

            if (tres < cuatro)
                Console.WriteLine("{0} < {1}", tres, cuatro);

            //Instancia de clase HolaMundo
            HolaMundo hola = new HolaMundo();

            hola.Mensaje();

            Console.WriteLine("Cual es tu nombre: ");
            string nombre = Console.ReadLine();

            hola.MostrarNombre(nombre);

            Test t = new Test();

            Console.WriteLine("Ingrese un nombre para test: ");
            t.NombreTest = Console.ReadLine();
            t.MensajeTest();

            MiClase miClase = new MiClase("nombre clase");
            miClase.ImprimirMensaje();
        }
    }

    //Clase Hola Mundo
    public class HolaMundo{
        //Imprimir cadena
        public void Mensaje() {
            Console.WriteLine("Estoy dentro de otra clase\n");
        }

        //Imprimir nombre pasado a función
        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Hola {0}", nombre);
        }
    }

}
