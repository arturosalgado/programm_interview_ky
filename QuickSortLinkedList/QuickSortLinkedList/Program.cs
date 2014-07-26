using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortLinkedList
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
            // int[] t = { 4,3,3,2,1};
            int[] t = { 1,7, 3  , 5, 2,10,20 };
            Node p = create2(t);
            print(p);
            sort2(p,7);
            Console.WriteLine("");
            Console.WriteLine("Back in the Main");
            print(p);
            Console.ReadKey();
        }
        static Node sort(Node p, int k)
        {

            Console.WriteLine("In sort ....");
            print(p);

            
            Node greaterH=null;
            Node greaterT = null;

            Node lesserH = null;
            Node lesserT = null;


          
            while (p != null)
            {
                Console.Write("while loop");
                Node next = p.next;
                p.next = null;
                if (p.value < k)
                {
                    if (lesserH == null)
                    {
                        lesserH = p;
                        lesserT = p;
                    }
                    else
                    {

                        lesserT.next = p;
                        lesserT = p;

                    }
                }
                else {
                    if (greaterT == null)
                    {
                        greaterT = p;
                        greaterT = p;
                    }
                    else
                    {

                        greaterT.next = p;
                        greaterT = p;

                    }
                
                }

                p = next;
            }

            if (greaterH == null)
            {
                return lesserH;
            }


           
            greaterT.next = lesserH;


            return greaterH;
           


          
        }
        static Node sort2(Node p, int k)
        {

            Console.WriteLine("In sort 2 ....");
            print(p);


            Node bS = null;
            Node bE = null;

            Node aS = null;
            Node aE = null;



            while (p != null)
            {
                Console.Write("while loop");
                Node next = p.next;
                p.next = null; // is KEY to unlink this from the chain
                if (p.value < k)
                {
                    if (bS == null)
                    {
                        bS = p;
                        bE = bS;
                    }
                    else
                    {

                        bE.next = p;
                        bE = p;

                    }
                }
                else
                {
                    if (aS == null)
                    {
                        aS = p;
                        aE = aS;
                    }
                    else
                    {

                        aE.next = p;
                        aE = p;

                    }

                }

                p = next;
            }

            Console.WriteLine("BS is ");
            print(bS);
            Console.WriteLine("As is ");
            print(aS);


            if (bS == null) // watch the case where the list is only bigger or only smaller
            {
                return aS;
            }



           aE.next = bS;


            return aS;




        }
        static Node insert_greater(Node n, Node greater)
        {
            Node t = greater;
            if (greater == null)
                greater = n;
            else
            {
                Node temp = greater;
                n.next = greater;
                greater = temp;
            }
            
            return greater;


        }
        static Node insert_lesser(Node n,Node lesser)
        {
            Node t = lesser;
            if (lesser == null)
                lesser = n;
            else
            {
                Node temp = lesser;
                n.next = lesser;
                lesser = temp;
            }

            return lesser;
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

    }
}
