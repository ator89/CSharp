using System;
namespace ADT
{
    public class Node
    {
        private int data;
        private Node link;

        //Constructor
        public Node() {
            data = 0;
            link = null;
        }

        //Destructor
        ~Node() { }

        
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        public Node Link
        {
            get { return link; }
            set { link = value; }
        }
    }
}
