using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 determines is a linked list of integer is a palindrom
 */
namespace PalindromeStack
{
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
            return ":" + this.Value + " ";
        }

        public static void p(Node p)
        {
            Node t = p;
            while (t != null)
            {
                Console.Write("{0}->", t.Value);
                t = t.next;
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

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 6,7,8,9,9,8,7, 6, 5 };
            Node p = Node.createList(a);
            Node.p(p);
            Console.WriteLine(isPalindromeR(p,a.Length));
            Console.ReadKey();
        }

        static int isPalindromeR(Node p, int length)
        {
            Console.WriteLine("Lenght is {0}",length);
            Console.ReadKey();
            Console.WriteLine("Building up {0}",p.Value);
            return -1;


        }


        static bool isPalindrome(Node a)
        {
            Node slow = a;
            Node fast = a;
            Stack<int> stack = new Stack<int>();
            while (fast!= null && fast.next != null)
            {
                stack.Push(slow.Value);
                slow = slow.next;
                
                fast = fast.next.next;
                
            }
            stack.Peek(); 
            // if fast != null
            if (fast != null)
            {
                slow = slow.next;
            }

            while (slow != null)
            {
                int top = stack.Pop();

                if (top != slow.Value) return false;
                slow = slow.next;
            }

            return true;
        }
    }
}
