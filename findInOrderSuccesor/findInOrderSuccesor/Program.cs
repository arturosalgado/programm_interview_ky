using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findInOrderSuccesor
{
    class Program
    {
        static int index = 0;
        public static int last_printed = Int32.MinValue;
        
        static void Main(string[] args)
        {
           
            Node<int> t = build2();
            Console.WriteLine("{0}",inorderSucc(t.Left.Right));
            Console.WriteLine("{0}", inorderSucc(t.Left.Left));
            Console.WriteLine("{0}", inorderSucc(t.Left));
            //print(t);
           

            Console.ReadKey();
        }

        static Node<int> inorderSucc(Node<int> n)
        {
            if (n == null) return null;

            if (n.Right != null)
            {
                return leftMostChild(n.Right);
            }
            else {

                Node<int> q = n;
                Node<int> xParent = q.Parent;
                while (xParent != null && xParent.Left != q)
                {
                    q = xParent;
                    xParent = xParent.Parent;
                }
                return xParent;
            }

            

           
        }


        static Node<int> build2()
        {
            Node<int>  n15 = new Node<int>(15);
            Node<int> n10 = new Node<int>(10);
            Node<int> n8 = new Node<int>(8);
            Node<int> n12 = new Node<int>(12);
            Node<int> n6 = new Node<int>(6);
            Node<int> n11 = new Node<int>(11);

            n15.Left = n10;

            n10.Left = n8;
            n10.Right = n12;

            n8.Left = n6;

            n12.Left = n11;
            //parents

            n6.Parent = n8;
            n8.Parent = n10;
            n10.Parent = n15;

            n12.Parent = n10;
            n11.Parent = n12;

            return n15;

        }

        static Node<int> leftMostChild(Node<int> n)
        {
            if (n == null) return null;

            while (n.Left != null)
            {
                n = n.Left;
            }
            return n;
        }

        static void print(Node<int> t)
        {
            if (t == null) return;



            print(t.Left);
            Console.Write(" {0} ", t.Value);
            print(t.Right);

        }
       

       

    }
    class Node<T>
    {
        public Node<T> Left, Right;
        public Node<T> Parent;
        public T Value;
        public Node(T value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            return this.Value + "";
        }
    }
}
