using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class Node {

        public int value;
        public Node next; 
    
        public Node(int value){
            this.value = value;
            Console.WriteLine("Creating node with value; {0}",value);
        }
        public Node()
        {
            
        }
        public override string ToString()
        {
            return "v:"+this.value;
        }
    }


   

    class Program
    {
        static void Main(string[] args)
        {
           // int[] t = { 4,3,3,2,1};
            int[] t = { 5,1,3,7,2,2};

            //Node n = createList(t);
            //print(n);
            //n = removeDuplicates(n);
            //Console.WriteLine("second print");
            
            Console.WriteLine("Second Method");
           
            Node n = createList(t);
            print(n);
            n = removeDuplicates3(n);

            print(n);

            Console.ReadKey();

        }

        static Node createList(int[]list)
        {
            Node head=null;
            
            foreach (var x in list)
            {

                    Node n = new Node(x);
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

        static Node removeDuplicatesNoBuffer(Node n)
        {
            Node t = n;
            Node inner= null;
            while (n.next != null)
            {
                //Console.WriteLine("n value {0}", n.value);
                inner = n; 
                while (inner.next != null )
                {
                   
                    Console.WriteLine("n value {0}  innber value {1}",n.value, inner.next.value);
                    if (n.value == inner.next.value)
                    {
                        inner.next = inner.next.next;
                    }
                    else
                    inner = inner.next; 
                
                }
                n = n.next; 
            }
            return t;

                
        
        }
            
        static Node removeDuplicates(Node n)
        {
        
            List<int> list = new List<int>();
            Node previous=null;

            Node t = n;
            
            while(n!=null)
            {


                Console.WriteLine("Analizing {0}", n.value);
                {
                    if (list.Contains(n.value)) {

                        previous.next = n.next;  // this is the only trick. After this 

                    }
                    else
                    {
                        list.Add(n.value);

                    }
                
                }
                previous = n;
                n = n.next; 
            }
            foreach (var x in list)
            {
                Console.Write(": {0} ",x);
            }
            Console.Write(":  :: ");
            return t; 

        }
        static Node removeDuplicatesD(Node n)
        {
            Console.WriteLine("Method 2");

            Node t = n;
            Node inner = null;

            while (n != null)
            {
                inner = n;  // both start at the same place
                while (inner.next != null)
                {
                    if (inner.next.value == n.value)  // this is key check with neightbor
                    {
                        inner.next = inner.next.next; // skipe where i es pointing and point it to the next
                    }
                    else
                    inner = inner.next;
                    //Console.WriteLine("{0}{1}", n, inner);
                }
                n = n.next;
            }


            return t;



        }

        static Node removeDuplicates3(Node n)
        {
            Console.WriteLine("Method 3");

            if (n == null) return n;

            Node t = n;

            Node front = n;
            Node previous = n;



            while (front.next != null)// safe
            {
                if (front.value == front.next.value)
                {
                    previous  = front.next.next;
                    front.next = previous;
                }
                else
                front = front.next;
            }


            return t;



        }

        static void print(Node n)
        {

            while (n != null)
            {


                Console.Write(" {0} -> ",n.value);
                n = n.next;

            }
            Console.WriteLine("");
        }
        

        

    }
}
