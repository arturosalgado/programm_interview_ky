using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimalistTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,3,5,9,10,15};
            Node n = BST(a,0,a.Length-1);
            printTree(n);
            Console.ReadKey();

        }
        static void printTree(Node n)
        {
            if (n == null) return;

            printTree(n.left);
            Console.WriteLine(n.value);
            printTree(n.right);

        }
        static Node BST(int []a,int start, int end)
        {
            if (end<start)
            {
                return null;
            }

            
            int mid =(start+end)/2;
            Node n = new Node(a[mid]);
            n.left  = BST(a, start, mid-1);
            n.right = BST(a, mid+1, end);

            return n;



        }
       

    }

    class Node
    {
        public Node left  {get;set;}
        public Node right { get; set; }
        public int value { get; set; }
        public Node(int v)
        {
            this.value = v;
        }



    }
}
