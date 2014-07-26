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
            
            //Console.WriteLine("Second Method");
           
            //Node n = createList(t);
            //print(n);
            ///int r = KthToLast(n,3);

//            Console.WriteLine(r);

  //          Console.ReadKey();


            int[] a = { 5, 8, 9 };
            Node p = create2(a);
            print(p);
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




        static Node create2(int[] a)
        {
            Node head=null;
            Node temp = null;
            for (int i = 0; i < a.Length; i++)
            {
                Node n = new Node(a[i]);
                if (head == null)
                {

                    head = n;

                }
                else {

                    temp = head;
                    head = n;
                    n.next = temp;
                   
                
                }
            
            }

            return head;
        
        }


        //it is in the stack where you actually count 
        static int KthToLast(Node n,int k)
        {

            if (n == null)
                return 0;
            else
            {
                int r =  1 + KthToLast(n.next,k);
                if (r == k)
                {
                    Console.WriteLine("Found it is {0}",n.value);
                }
                return r;
            }
        
        }

       

    }
}
