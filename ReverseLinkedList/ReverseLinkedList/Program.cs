using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLinkedList
{


    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,2,3};
            Node n = Node.createList(a);
            Node.p(n);
            Node p = reverse(n);
            Node.p(p);
            bool palindrome = palin(n,p);

            Console.WriteLine("Is palindrome {0}",palindrome);


            Node.p(p);

            Console.ReadKey();
        }
        static bool palin(Node a, Node b)
        {
            while (a != null && b != null)
            {
                if (a.Value != b.Value)
                {
                    return false;
                }
                a = a.next;
                b = b.next;
            }
            return true;
        }
        static Node reverse(Node p)
        {
            Node current = p;
            Node next = null;
            Node head = null;
            Node previous = null;
            while (current != null)
            {
                next = current.next;
               
                current.next = previous;
                previous = current;
                current = next;
                
            }
            head = previous;

            return head;
                
        }
        
    }


    class Node
    {

        public int Value { get; set; }
        public Node next { get; set; }
        public Node(int val)
        {
            this.Value = val;
        }

        public override string ToString()
        {
            return ":"+this.Value+" ";
        }

        public static void p(Node p)
        {
            while (p != null)
            {
                Console.Write("{0}->",p.Value);
                p = p.next;
            }
            Console.WriteLine("");
            Console.ReadKey();
        }

        public static Node createList()
        {


            Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);

            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;

            return n1;


        }

        public static Node createList(int[] a)
        {
            Node head = null;
            Node tail = null;
            foreach (var x in a)
            {
                Node n = new Node(x);
                if (head == null)
                {
                    head = n;
                    tail = n;
                }
                else
                {
                    tail.next = n;
                    tail = n;
                }
            }

            return head;
        }
    }

    
}
