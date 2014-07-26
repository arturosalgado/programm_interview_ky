using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KthToLastIterative
{
    class Node
    {

        public int value;
        public Node next;

        public Node(int value)
        {
            this.value = value;
            Console.WriteLine("Creating node with value; {0}", value);
        }
        public Node()
        {

        }
        public override string ToString()
        {
            return "v:" + this.value;
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
        
            int[] a = { 5, 8, 9,7,3,7,2,1 };
            Node p = create2(a);
            print(p);

            int r = KthToLast(p,2);
            Console.WriteLine(r);

            Console.WriteLine("Second method");

            Node p1 = NthToLast(p,2);
            Console.WriteLine("{0}",p1.value);


            Console.ReadKey();
        }


        static Node NthToLast(Node head, int n)
        {
            Node p1 = head;
            Node p2 = head;

            if (n <= 0) return null;

            // Move p2 n nodes into the list.  Keep n1 in the same position.
            for (int i = 0; i < n - 1; i++)
            {
                if (p2 == null)
                {
                    return null; // Error: list is too small.
                }
                p2 = p2.next;
            }
            if (p2 == null)
            { // Another error check.
                return null;
            }

            // Move them at the same pace.  When p2 hits the end, 
            // p1 will be at the right element.
            while (p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }
            return p1;
        }


        static Node create2(int[] a)
        {
            Node head = null;
            Node temp = null;
            for (int i = 0; i < a.Length; i++)
            {
                Node n = new Node(a[i]);
                if (head == null)
                {
                  head = n;
                }
                else
                {
                    temp = head;
                    head = n;
                    n.next = temp;
                }

            }
            return head;
        }


        //it is in the stack where you actually count 
        static int KthToLast(Node n, int k)
        {
            Node t = n;
            
            for (int i = 1; i < k; i++)
            {
                if (t.next != null)
                    t = t.next;
                else
                    return -1;
                
            }
            while(t.next!=null)
            {
                n = n.next;
                t = t.next;
            }

            return n.value;

        }
        static void print(Node n)
        {

            while (n != null)
            {

                Console.Write(" {0} -> ", n.value);
                n = n.next;

            }
            Console.WriteLine("");
        }



    }
}

