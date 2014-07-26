using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListAddition
{
    class Node {

        public int value { get; set; }
        public Node next { get; set; }

        public Node(int value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return Convert.ToString(this.value);
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 7,9,1};
            Node n = createListR(a);
            Node p = createListR(a);
            print(n);
            print(p);
            Node r = sum2(n,p,0);
            print(r);

          
            Console.ReadKey();

        }

        public static Node sum(Node a, Node b, int carry)
        {

            if (a== null && b== null && carry == 0)
            {
                return null;
            }

            Node res = new Node(0);

            int value = carry;

            value = value + a.value;// check if not null
            value = value + b.value;// check if not null


            res.value = value % 10;

            Node next = sum(a.next, b.next,value>10?1:0);

            res.next = next;

            return res;

        }



        public static Node sum2(Node a, Node b, int carry)
        {
            if (a == null || b == null )
                return null;    

            Node result = new Node(0);

            

            int value = carry + a.value + b.value;

            result.value = value % 10;

            Node next = sum2(a.next, b.next, value / 10);

            result.next = next;

            return result;

        
        }

        public static Node createList(int []a)
        {
            Node head=null;
            Node tail= null;

            for (int i = 0; i < a.Length; i++)
            {
                Node n = new Node(a[i]);
                if (head == null)
                {
                    head = n;
                    tail = n;
                }
                else {
                    tail.next = n;
                    tail = n;
                }
            }

            return head;



        }
        public static Node createListR(int[] a)
        {
            Node head = null;
           

            for (int i = 0; i < a.Length; i++)
            {
                Node n = new Node(a[i]);
                if (head == null)
                {
                    head = n;
                   
                }
                else
                {
                    n.next = head;
                    head = n;
                }
            }

            return head;



        }

        public static void print(Node n)
        {
            while (n != null)
            {
                Console.Write("{0}->",n.value);
                n = n.next;
            }
            Console.WriteLine("");
        }

    }
}
