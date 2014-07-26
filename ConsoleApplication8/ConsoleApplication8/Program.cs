using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopInLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node p = createList();
            Node head = p;
            Node q = p;
            bool loop = false;
            while(q.next!=null && q.next.next!=null)
            {
                p = p.next;
                q = q.next.next;// detects if there is a loop
                if (p == q)
                {
                    loop = true;
                    Console.WriteLine("Loop");
                    break;
                }
            }

            Console.WriteLine(" q is {0}",q.value);
            Console.WriteLine(" p is {0}", p.value);
            Console.WriteLine("Loop is {0}",loop);
            q = head;
            while (q != p)
            {
                q = q.next;
                p = p.next;
            }
            Console.WriteLine(" q2 is {0}", q.value);

            Console.ReadKey();

        }

        public static Node createList()
        {

            Node a1 = new Node(1);
            Node a2 = new Node(2);
            Node a3 = new Node(3);
            Node a4 = new Node(4);
            Node a5 = new Node(5);
            Node a6 = new Node(6);
            Node a7 = new Node(7);
            Node a8 = new Node(8);

            a1.next = a2;
            a2.next = a3;
            a3.next = a4;
            a4.next = a5;
            a5.next = a6;
            a6.next = a7;
            a7.next = a8;
            a8.next = a4;


            return a1;

        }

    }
    class Node {

        public int  value { get; set; }
        public Node next { get; set; }

        public Node(int val)
        {
            this.value = val;
        }

    
    }

}
