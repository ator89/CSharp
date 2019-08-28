using System;

namespace ADT
{
    public class ListaEnlazada
    {
        private Node head;

        public ListaEnlazada() { }
        ~ListaEnlazada() { }

        //Insertar al inicio de la lista
        public void insert(int data)
        {
            Node temp = new Node();
            temp.Data = data;
            temp.Link = null;
            if (temp != null)
                temp.Link = head;
            head = temp;

        }

        //Insertar en posición x
        public void insertAt(int data, int pos)
        {
            Node temp1 = new Node();
            temp1.Data = data;
            temp1.Link = null;
            if( pos == 1)
            {
                temp1.Link = head;
                head = temp1;
                return;
            }
            Node temp2 = head;
            for (int i = 0; i < pos - 2; i++)
                temp2 = temp2.Link;
            temp1.Link = temp2.Link;
            temp2.Link = temp1;
        }

        //Eliminar de posición X
        public void remove(int pos)
        {
            Node temp1 = head;
            if(pos == 1)
            {
                head = temp1.Link;
                temp1.Link = null;
                return;
            }
            for (int i = 0; i < pos - 2; i++)
                temp1 = temp1.Link;
            Node temp2 = temp1.Link;
            temp1.Link = temp2.Link;
            temp2.Link = null;
        }

        //Imprimir elementos de la lista
        public void show()
        {
            Node temp = head;
            while( temp != null)
            {
                Console.Write(" {0}",temp.Data);
                temp = temp.Link;
            }
            Console.Write("\n");
        }
    }
}
